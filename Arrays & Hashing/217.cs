// Use a HashSet<int> to check for duplicates.

public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> hashSet  = new();

        for(int i = 0; i < nums.Length; i++) {
            if ( hashSet.Contains(nums[i]) ) {
                return true;
            }
            hashSet.Add(nums[i]);
        }
        return false;
    }
}
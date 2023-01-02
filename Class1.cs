using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int count = 0;
        foreach (bool sheep in sheeps)
        {
            if (sheep) count++;
        }
        return count;
    }
}
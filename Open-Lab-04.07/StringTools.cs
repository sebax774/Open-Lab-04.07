using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            string ret = "";
            for (int i = original.Length - 1; i > -1; i--)
            {
                ret = ret + original[i];
            }
            return ret;
        }
    }
}
using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            int holocount;
            bool res = true;

            input = input.ToLower();

            for( int i = 0; i< alphabets.Length; i++)
            {
                holocount = 0;
                for(int j = 0; j< input.Length; j++)
                {
                    if (input[j] == alphabets[i])
                    {
                        holocount += 1;
                    }
                }
                if(holocount == 0)
                {
                    res = false;
                    break;
                }
            }

            return res;
        }
    }
}

using System.Collections;

namespace NotificationChanels;

class Program
{
    static void Main(string[] args)
    {
        string inputText = "";

        while(inputText != "0") {
            Console.Write("Input notification value or \"0\" to exit: ");
            inputText = Console.ReadLine();

            if (inputText == "0") {
                Console.WriteLine("Bye");
                break;
            }

            if (inputText != null) {
                string[] contentSplits = inputText.Split(' ');
                ArrayList tagSplits = new ArrayList();

                foreach (string contentTag in contentSplits) {

                    if(!contentTag.Contains("[")) { continue; }
                
                    string[] tmpTags = contentTag.Split(']');
                    foreach(string tag in tmpTags) {

                        if(tag == null || !tag.Contains("[")) { continue; }

                        String s = tag.Substring( 1, tag.Length-1 );

                        tagSplits.Add(s);
                    }
                }

                ArrayList tags = new ArrayList();
                foreach( string tag in tagSplits) {
                    if(tag.Equals("BE") || tag.Equals("FE") || tag.Equals("Urgent") || tag.Equals("QA")) {
                        tags.Add(tag);
                    }
                }

                string strOutput = "Receive channels: " + (String.Join(",", tags.ToArray())).Replace(",", ", ");
                if(tags.Count == 0) {
                    strOutput = "Chanel not found or it has no value!";
                }

                Console.WriteLine(strOutput);
            } 

        }
    }
}

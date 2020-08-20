//Console to bring up incident response weblink with companion notepad for incident notes
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace PC_Restart_Tool
{
    class Program
    {
        public static void Main()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("Start https://www.virustotal.com/gui/home/url");
            process.StandardInput.WriteLine("Start https://talosintelligence.com/");
            process.StandardInput.WriteLine("Start https://mxtoolbox.com/EmailHeaders.aspx");
            process.StandardInput.WriteLine("Start https://urlscan.io/");
            process.StandardInput.WriteLine("Start https://whois.domaintools.com/");
            process.StandardInput.WriteLine("notepad");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
        }

    }
}

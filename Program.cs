using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress("vkondeti@miraclesoft.com", "vijender"));
            msg.From = new MailAddress("vkondeti@miraclesoft.com", "Vijendra");
            msg.Subject = "This is a Test Mail";
            msg.Body = "This is a test message using Exchange OnLine";
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("vkondeti@miraclesoft.com", "Justin@4");
            client.Port = 587; // You can use Port 25 if 587 is blocked (mine is!)
            client.Host = "	smtp.miraclesoft.com";
            //client.Host = "apcprd02.prod.outlook.com";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Send(msg);
        }
    }
}

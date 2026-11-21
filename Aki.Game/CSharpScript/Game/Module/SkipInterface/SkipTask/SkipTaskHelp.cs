using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B57 RID: 15191
	public class SkipTaskHelp : SkipTask
	{
		// Token: 0x06027077 RID: 159863 RVA: 0x00AED1B0 File Offset: 0x00AEB3B0
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = data[0] as string;
			int helpGroupId;
			if (text != null)
			{
				helpGroupId = int.Parse(text);
			}
			else
			{
				helpGroupId = (int)data[0];
			}
			HelpController.Instance.OpenHelpById(helpGroupId);
			base.Finish();
		}
	}
}

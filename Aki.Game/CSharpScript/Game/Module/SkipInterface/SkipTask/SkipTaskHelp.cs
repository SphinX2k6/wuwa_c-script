using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BAD RID: 19373
	public class SkipTaskHelp : SkipTask
	{
		// Token: 0x060322E6 RID: 205542 RVA: 0x00BA8F3C File Offset: 0x00BA713C
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

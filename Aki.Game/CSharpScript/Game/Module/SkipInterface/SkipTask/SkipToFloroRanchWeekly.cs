using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B76 RID: 15222
	public class SkipToFloroRanchWeekly : SkipTask
	{
		// Token: 0x060270B8 RID: 159928 RVA: 0x00AEE722 File Offset: 0x00AEC922
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			UiManager.Instance.OpenView(EUiViewName.FloroRanchWeeklyMainView, null, null);
			base.Finish();
		}
	}
}

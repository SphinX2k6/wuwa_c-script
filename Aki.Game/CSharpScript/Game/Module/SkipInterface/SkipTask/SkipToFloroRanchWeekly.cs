using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BCC RID: 19404
	public class SkipToFloroRanchWeekly : SkipTask
	{
		// Token: 0x06032327 RID: 205607 RVA: 0x00BAA46A File Offset: 0x00BA866A
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

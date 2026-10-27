using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD6 RID: 19414
	public class SkipToQuestMultiLineView : SkipTask
	{
		// Token: 0x0603233D RID: 205629 RVA: 0x00BAA7C7 File Offset: 0x00BA89C7
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			base.Finish();
			if (!UiManager.Instance.IsViewOpen(EUiViewName.QuestMultiLineView))
			{
				QuestMultiLineController.Instance.OpenQuestMultiLineView(0, false, false);
			}
		}
	}
}

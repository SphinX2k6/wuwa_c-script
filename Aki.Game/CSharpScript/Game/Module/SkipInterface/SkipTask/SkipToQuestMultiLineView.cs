using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B80 RID: 15232
	public class SkipToQuestMultiLineView : SkipTask
	{
		// Token: 0x060270CE RID: 159950 RVA: 0x00AEEA7F File Offset: 0x00AECC7F
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

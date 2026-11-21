using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B6F RID: 15215
	public class SkipToDailyActivityWeeklyTab : SkipTask
	{
		// Token: 0x060270AA RID: 159914 RVA: 0x00AEE270 File Offset: 0x00AEC470
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			if (!FunctionModel.Instance.IsOpen(EFunctionType.WeeklyChallenge) || WeeklyChallengeModel.Instance.WeeklyConfigId == 0)
			{
				GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
				return;
			}
			base.Finish();
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DailyActivityTabView), new int?(2), null, null);
		}
	}
}

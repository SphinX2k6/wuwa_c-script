using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC5 RID: 19397
	public class SkipToDailyActivityWeeklyTab : SkipTask
	{
		// Token: 0x06032319 RID: 205593 RVA: 0x00BA9FC4 File Offset: 0x00BA81C4
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
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DailyActivityTabView), new int?(2), null);
		}
	}
}

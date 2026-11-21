using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B66 RID: 15206
	public class SkipTaskWeeklyRogue : SkipTask
	{
		// Token: 0x06027098 RID: 159896 RVA: 0x00AEDBC0 File Offset: 0x00AEBDC0
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.WeeklyRogueActivityView))
			{
				GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
				base.Finish();
				return;
			}
			WeeklyRogueModel instance = WeeklyRogueModel.Instance;
			WeeklyRogueData weeklyRogueData = (instance != null) ? instance.ActivityDataNew : null;
			if (weeklyRogueData == null)
			{
				base.Finish();
				return;
			}
			if (!weeklyRogueData.IsUnLock())
			{
				base.Finish();
				return;
			}
			int unFinishPreGuideQuestId = weeklyRogueData.GetUnFinishPreGuideQuestId();
			if (unFinishPreGuideQuestId > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				base.Finish();
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WeeklyRogueActivityView, EWeeklyRogueOpenWay.UI, null);
			base.Finish();
		}
	}
}

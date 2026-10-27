using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003341 RID: 13121
public class RedDotActivityRecallTaskEntryButton : RedDotBase
{
	// Token: 0x0601C979 RID: 117113 RVA: 0x00804583 File Offset: 0x00802783
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
	}

	// Token: 0x0601C97A RID: 117114 RVA: 0x008045BD File Offset: 0x008027BD
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
	}

	// Token: 0x0601C97B RID: 117115 RVA: 0x008045F8 File Offset: 0x008027F8
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && (activityData.CheckHaveTaskRewardCanGet() || activityData.CheckRegressScoreRewardReached() || ActivityRegressModel.Instance.ShouldShowDoubleDropRedDot() || activityData.HasReachableCultivateTask());
	}
}

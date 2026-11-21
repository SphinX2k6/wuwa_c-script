using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B3 RID: 10419
public class RedDotActivityRecallTaskEntryButton : RedDotBase
{
	// Token: 0x0601A671 RID: 108145 RVA: 0x0082AB47 File Offset: 0x00828D47
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
	}

	// Token: 0x0601A672 RID: 108146 RVA: 0x0082AB81 File Offset: 0x00828D81
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
	}

	// Token: 0x0601A673 RID: 108147 RVA: 0x0082ABBC File Offset: 0x00828DBC
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && (activityData.CheckHaveTaskRewardCanGet() || activityData.CheckRegressScoreRewardReached() || ActivityRegressModel.Instance.ShouldShowDoubleDropRedDot() || activityData.HasReachableCultivateTask());
	}
}

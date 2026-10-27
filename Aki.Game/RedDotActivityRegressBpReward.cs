using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003344 RID: 13124
public class RedDotActivityRegressBpReward : RedDotBase
{
	// Token: 0x0601C982 RID: 117122 RVA: 0x008046E8 File Offset: 0x008028E8
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ActivityRegressBp);
	}

	// Token: 0x0601C983 RID: 117123 RVA: 0x008046F4 File Offset: 0x008028F4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C984 RID: 117124 RVA: 0x00804712 File Offset: 0x00802912
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C985 RID: 117125 RVA: 0x00804730 File Offset: 0x00802930
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckRegressScoreRewardReached();
	}
}

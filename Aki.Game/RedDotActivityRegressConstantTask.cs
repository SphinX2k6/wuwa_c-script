using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003346 RID: 13126
public class RedDotActivityRegressConstantTask : RedDotBase
{
	// Token: 0x0601C98C RID: 117132 RVA: 0x008047B6 File Offset: 0x008029B6
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C98D RID: 117133 RVA: 0x008047D4 File Offset: 0x008029D4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C98E RID: 117134 RVA: 0x008047F2 File Offset: 0x008029F2
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		if (activityData == null || !activityData.HasReachableConstantTask())
		{
			ActivityRegressData activityData2 = ActivityRegressModel.Instance.ActivityData;
			return activityData2 != null && activityData2.CheckRegressScoreRewardReached();
		}
		return true;
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B6 RID: 10422
public class RedDotActivityRegressBpReward : RedDotBase
{
	// Token: 0x0601A67A RID: 108154 RVA: 0x0082ACAC File Offset: 0x00828EAC
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ActivityRegressBp);
	}

	// Token: 0x0601A67B RID: 108155 RVA: 0x0082ACB8 File Offset: 0x00828EB8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A67C RID: 108156 RVA: 0x0082ACD6 File Offset: 0x00828ED6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A67D RID: 108157 RVA: 0x0082ACF4 File Offset: 0x00828EF4
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckRegressScoreRewardReached();
	}
}

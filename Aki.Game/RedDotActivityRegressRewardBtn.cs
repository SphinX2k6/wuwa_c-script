using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028BE RID: 10430
public class RedDotActivityRegressRewardBtn : RedDotBase
{
	// Token: 0x0601A69C RID: 108188 RVA: 0x0082AFAA File Offset: 0x008291AA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A69D RID: 108189 RVA: 0x0082AFC8 File Offset: 0x008291C8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A69E RID: 108190 RVA: 0x0082AFE6 File Offset: 0x008291E6
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckRegressRewardBtnReached();
	}
}

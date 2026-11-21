using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028BA RID: 10426
public class RedDotActivityRegressDisposableReward : RedDotBase
{
	// Token: 0x0601A68C RID: 108172 RVA: 0x0082AE44 File Offset: 0x00829044
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A68D RID: 108173 RVA: 0x0082AE62 File Offset: 0x00829062
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A68E RID: 108174 RVA: 0x0082AE80 File Offset: 0x00829080
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckDisposableRewardRedDot();
	}
}

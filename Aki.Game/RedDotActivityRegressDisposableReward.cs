using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003348 RID: 13128
public class RedDotActivityRegressDisposableReward : RedDotBase
{
	// Token: 0x0601C994 RID: 117140 RVA: 0x00804880 File Offset: 0x00802A80
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C995 RID: 117141 RVA: 0x0080489E File Offset: 0x00802A9E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C996 RID: 117142 RVA: 0x008048BC File Offset: 0x00802ABC
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckDisposableRewardRedDot();
	}
}

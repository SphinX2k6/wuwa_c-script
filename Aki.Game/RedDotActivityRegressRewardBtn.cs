using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200334C RID: 13132
public class RedDotActivityRegressRewardBtn : RedDotBase
{
	// Token: 0x0601C9A4 RID: 117156 RVA: 0x008049E6 File Offset: 0x00802BE6
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9A5 RID: 117157 RVA: 0x00804A04 File Offset: 0x00802C04
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9A6 RID: 117158 RVA: 0x00804A22 File Offset: 0x00802C22
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckRegressRewardBtnReached();
	}
}

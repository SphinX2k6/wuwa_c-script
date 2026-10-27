using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200334B RID: 13131
public class RedDotActivityRegressRecommend : RedDotBase
{
	// Token: 0x0601C9A0 RID: 117152 RVA: 0x0080498B File Offset: 0x00802B8B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9A1 RID: 117153 RVA: 0x008049A9 File Offset: 0x00802BA9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9A2 RID: 117154 RVA: 0x008049C7 File Offset: 0x00802BC7
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckRecommendRedDot();
	}
}

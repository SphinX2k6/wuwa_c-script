using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028BD RID: 10429
public class RedDotActivityRegressRecommend : RedDotBase
{
	// Token: 0x0601A698 RID: 108184 RVA: 0x0082AF4F File Offset: 0x0082914F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A699 RID: 108185 RVA: 0x0082AF6D File Offset: 0x0082916D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A69A RID: 108186 RVA: 0x0082AF8B File Offset: 0x0082918B
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckRecommendRedDot();
	}
}

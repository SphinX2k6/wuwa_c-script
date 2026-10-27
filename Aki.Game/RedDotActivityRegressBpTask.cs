using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003345 RID: 13125
public class RedDotActivityRegressBpTask : RedDotBase
{
	// Token: 0x0601C987 RID: 117127 RVA: 0x0080474F File Offset: 0x0080294F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ActivityRegressBp);
	}

	// Token: 0x0601C988 RID: 117128 RVA: 0x0080475B File Offset: 0x0080295B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C989 RID: 117129 RVA: 0x00804779 File Offset: 0x00802979
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C98A RID: 117130 RVA: 0x00804797 File Offset: 0x00802997
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.HasReachableConstantTask();
	}
}

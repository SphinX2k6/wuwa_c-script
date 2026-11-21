using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B7 RID: 10423
public class RedDotActivityRegressBpTask : RedDotBase
{
	// Token: 0x0601A67F RID: 108159 RVA: 0x0082AD13 File Offset: 0x00828F13
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ActivityRegressBp);
	}

	// Token: 0x0601A680 RID: 108160 RVA: 0x0082AD1F File Offset: 0x00828F1F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A681 RID: 108161 RVA: 0x0082AD3D File Offset: 0x00828F3D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A682 RID: 108162 RVA: 0x0082AD5B File Offset: 0x00828F5B
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.HasReachableConstantTask();
	}
}

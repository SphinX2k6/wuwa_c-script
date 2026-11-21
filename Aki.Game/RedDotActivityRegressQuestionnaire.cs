using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028BC RID: 10428
public class RedDotActivityRegressQuestionnaire : RedDotBase
{
	// Token: 0x0601A694 RID: 108180 RVA: 0x0082AEF4 File Offset: 0x008290F4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A695 RID: 108181 RVA: 0x0082AF12 File Offset: 0x00829112
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A696 RID: 108182 RVA: 0x0082AF30 File Offset: 0x00829130
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckShowQuestionnaireRedDot();
	}
}

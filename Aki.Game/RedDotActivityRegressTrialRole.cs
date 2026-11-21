using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028C0 RID: 10432
public class RedDotActivityRegressTrialRole : RedDotBase
{
	// Token: 0x0601A6A4 RID: 108196 RVA: 0x0082B060 File Offset: 0x00829260
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6A5 RID: 108197 RVA: 0x0082B07E File Offset: 0x0082927E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6A6 RID: 108198 RVA: 0x0082B09C File Offset: 0x0082929C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckTrialRoleRedDot();
	}
}

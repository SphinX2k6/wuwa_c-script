using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200334A RID: 13130
public class RedDotActivityRegressQuestionnaire : RedDotBase
{
	// Token: 0x0601C99C RID: 117148 RVA: 0x00804930 File Offset: 0x00802B30
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C99D RID: 117149 RVA: 0x0080494E File Offset: 0x00802B4E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C99E RID: 117150 RVA: 0x0080496C File Offset: 0x00802B6C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckShowQuestionnaireRedDot();
	}
}

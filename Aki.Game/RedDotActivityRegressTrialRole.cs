using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200334E RID: 13134
public class RedDotActivityRegressTrialRole : RedDotBase
{
	// Token: 0x0601C9AC RID: 117164 RVA: 0x00804A9C File Offset: 0x00802C9C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9AD RID: 117165 RVA: 0x00804ABA File Offset: 0x00802CBA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9AE RID: 117166 RVA: 0x00804AD8 File Offset: 0x00802CD8
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		return activityData != null && activityData.CheckTrialRoleRedDot();
	}
}

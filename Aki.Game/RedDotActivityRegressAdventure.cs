using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003342 RID: 13122
public class RedDotActivityRegressAdventure : RedDotBase
{
	// Token: 0x0601C97D RID: 117117 RVA: 0x00804641 File Offset: 0x00802841
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C97E RID: 117118 RVA: 0x0080465F File Offset: 0x0080285F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C97F RID: 117119 RVA: 0x00804680 File Offset: 0x00802880
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		bool? flag = (activityData != null) ? new bool?(activityData.CheckAdventureRedDot()) : null;
		ActivityNewPlayerSupportData activityData2 = ActivityNewPlayerSupportController.Instance.ActivityData;
		if (activityData2 == null)
		{
			return flag.GetValueOrDefault();
		}
		return flag.GetValueOrDefault() || activityData2.IsAdventureEntranceRedDot();
	}
}

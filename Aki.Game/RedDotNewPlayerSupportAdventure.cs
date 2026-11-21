using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002955 RID: 10581
public class RedDotNewPlayerSupportAdventure : RedDotBase
{
	// Token: 0x0601A953 RID: 108883 RVA: 0x008303BD File Offset: 0x0082E5BD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A954 RID: 108884 RVA: 0x008303DB File Offset: 0x0082E5DB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A955 RID: 108885 RVA: 0x008303FC File Offset: 0x0082E5FC
	protected override bool OnCheck(int uId = 0)
	{
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		return activityData != null && activityData.IsAdventureEntranceRedDot();
	}
}

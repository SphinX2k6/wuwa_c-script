using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033E3 RID: 13283
public class RedDotNewPlayerSupportAdventure : RedDotBase
{
	// Token: 0x0601CC5B RID: 117851 RVA: 0x00809DF9 File Offset: 0x00807FF9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC5C RID: 117852 RVA: 0x00809E17 File Offset: 0x00808017
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC5D RID: 117853 RVA: 0x00809E38 File Offset: 0x00808038
	protected override bool OnCheck(int uId = 0)
	{
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		return activityData != null && activityData.IsAdventureEntranceRedDot();
	}
}

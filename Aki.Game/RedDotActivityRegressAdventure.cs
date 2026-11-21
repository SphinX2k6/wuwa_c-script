using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B4 RID: 10420
public class RedDotActivityRegressAdventure : RedDotBase
{
	// Token: 0x0601A675 RID: 108149 RVA: 0x0082AC05 File Offset: 0x00828E05
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A676 RID: 108150 RVA: 0x0082AC23 File Offset: 0x00828E23
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A677 RID: 108151 RVA: 0x0082AC44 File Offset: 0x00828E44
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

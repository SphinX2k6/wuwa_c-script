using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B8 RID: 10424
public class RedDotActivityRegressConstantTask : RedDotBase
{
	// Token: 0x0601A684 RID: 108164 RVA: 0x0082AD7A File Offset: 0x00828F7A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A685 RID: 108165 RVA: 0x0082AD98 File Offset: 0x00828F98
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A686 RID: 108166 RVA: 0x0082ADB6 File Offset: 0x00828FB6
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		if (activityData == null || !activityData.HasReachableConstantTask())
		{
			ActivityRegressData activityData2 = ActivityRegressModel.Instance.ActivityData;
			return activityData2 != null && activityData2.CheckRegressScoreRewardReached();
		}
		return true;
	}
}

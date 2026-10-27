using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003340 RID: 13120
public class RedDotActivityRecallSignEntryButton : RedDotBase
{
	// Token: 0x0601C975 RID: 117109 RVA: 0x00804533 File Offset: 0x00802733
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C976 RID: 117110 RVA: 0x00804551 File Offset: 0x00802751
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C977 RID: 117111 RVA: 0x0080456F File Offset: 0x0080276F
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityRegressModel.Instance.HasSignRewardCanClaimed();
	}
}

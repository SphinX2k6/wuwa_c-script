using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;

// Token: 0x0200334F RID: 13135
public class RedDotRoverlikeQuestRewardBtn : RedDotBase
{
	// Token: 0x0601C9B0 RID: 117168 RVA: 0x00804AF7 File Offset: 0x00802CF7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoverlikeQuestTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9B1 RID: 117169 RVA: 0x00804B15 File Offset: 0x00802D15
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoverlikeQuestTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C9B2 RID: 117170 RVA: 0x00804B34 File Offset: 0x00802D34
	protected override bool OnCheck(int uId = 0)
	{
		RoverlikeActivityController instance = RoverlikeActivityController.Instance;
		RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return roverlikeActivityData != null && roverlikeActivityData.QuestData.HasRedDot();
	}
}

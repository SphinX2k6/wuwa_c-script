using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;

// Token: 0x020028C1 RID: 10433
public class RedDotRoverlikeQuestRewardBtn : RedDotBase
{
	// Token: 0x0601A6A8 RID: 108200 RVA: 0x0082B0BB File Offset: 0x008292BB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoverlikeQuestTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6A9 RID: 108201 RVA: 0x0082B0D9 File Offset: 0x008292D9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoverlikeQuestTaskUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A6AA RID: 108202 RVA: 0x0082B0F8 File Offset: 0x008292F8
	protected override bool OnCheck(int uId = 0)
	{
		RoverlikeActivityController instance = RoverlikeActivityController.Instance;
		RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return roverlikeActivityData != null && roverlikeActivityData.QuestData.HasRedDot();
	}
}

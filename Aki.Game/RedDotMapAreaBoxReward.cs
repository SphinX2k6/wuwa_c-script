using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200292E RID: 10542
public class RedDotMapAreaBoxReward : RedDotBase
{
	// Token: 0x0601A89C RID: 108700 RVA: 0x0082F008 File Offset: 0x0082D208
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MapAreaExplore);
	}

	// Token: 0x0601A89D RID: 108701 RVA: 0x0082F011 File Offset: 0x0082D211
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMapAreaBoxReward, new Action(base.EventCheck));
	}

	// Token: 0x0601A89E RID: 108702 RVA: 0x0082F02F File Offset: 0x0082D22F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMapAreaBoxReward, new Action(base.EventCheck));
	}

	// Token: 0x0601A89F RID: 108703 RVA: 0x0082F04D File Offset: 0x0082D24D
	protected override bool OnCheck(int uId = 0)
	{
		return ExploreProgressModel.Instance.GetIsRedDotAreaRewardBox;
	}
}

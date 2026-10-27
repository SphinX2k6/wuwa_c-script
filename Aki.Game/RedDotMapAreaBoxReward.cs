using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033BC RID: 13244
public class RedDotMapAreaBoxReward : RedDotBase
{
	// Token: 0x0601CBA4 RID: 117668 RVA: 0x00808A44 File Offset: 0x00806C44
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MapAreaExplore);
	}

	// Token: 0x0601CBA5 RID: 117669 RVA: 0x00808A4D File Offset: 0x00806C4D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateMapAreaBoxReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CBA6 RID: 117670 RVA: 0x00808A6B File Offset: 0x00806C6B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateMapAreaBoxReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CBA7 RID: 117671 RVA: 0x00808A89 File Offset: 0x00806C89
	protected override bool OnCheck(int uId = 0)
	{
		return ExploreProgressModel.Instance.GetIsRedDotAreaRewardBox;
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028F6 RID: 10486
public class FeedbackRedDot : RedDotBase
{
	// Token: 0x0601A7A2 RID: 108450 RVA: 0x0082CF41 File Offset: 0x0082B141
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A7A3 RID: 108451 RVA: 0x0082CF49 File Offset: 0x0082B149
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.FeedbackRewardRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A7A4 RID: 108452 RVA: 0x0082CF67 File Offset: 0x0082B167
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.FeedbackRewardRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A7A5 RID: 108453 RVA: 0x0082CF85 File Offset: 0x0082B185
	protected override bool OnCheck(int uId = 0)
	{
		return FeedbackRewardModel.Instance.CheckRedDot();
	}
}

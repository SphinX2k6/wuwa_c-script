using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003384 RID: 13188
public class FeedbackRedDot : RedDotBase
{
	// Token: 0x0601CAAA RID: 117418 RVA: 0x0080697D File Offset: 0x00804B7D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601CAAB RID: 117419 RVA: 0x00806985 File Offset: 0x00804B85
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.FeedbackRewardRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CAAC RID: 117420 RVA: 0x008069A3 File Offset: 0x00804BA3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.FeedbackRewardRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CAAD RID: 117421 RVA: 0x008069C1 File Offset: 0x00804BC1
	protected override bool OnCheck(int uId = 0)
	{
		return FeedbackRewardModel.Instance.CheckRedDot();
	}
}

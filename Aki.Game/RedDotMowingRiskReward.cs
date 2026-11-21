using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002952 RID: 10578
public class RedDotMowingRiskReward : RedDotBase
{
	// Token: 0x0601A947 RID: 108871 RVA: 0x008302B8 File Offset: 0x0082E4B8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MowingRiskOnRefreshRewardRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A948 RID: 108872 RVA: 0x008302D6 File Offset: 0x0082E4D6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MowingRiskOnRefreshRewardRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A949 RID: 108873 RVA: 0x008302F4 File Offset: 0x0082E4F4
	protected override bool OnCheck(int uId = 0)
	{
		return MowingRiskModel.Instance.HasAnyReward;
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033E0 RID: 13280
public class RedDotMowingRiskReward : RedDotBase
{
	// Token: 0x0601CC4F RID: 117839 RVA: 0x00809CF4 File Offset: 0x00807EF4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MowingRiskOnRefreshRewardRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC50 RID: 117840 RVA: 0x00809D12 File Offset: 0x00807F12
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MowingRiskOnRefreshRewardRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC51 RID: 117841 RVA: 0x00809D30 File Offset: 0x00807F30
	protected override bool OnCheck(int uId = 0)
	{
		return MowingRiskModel.Instance.HasAnyReward;
	}
}

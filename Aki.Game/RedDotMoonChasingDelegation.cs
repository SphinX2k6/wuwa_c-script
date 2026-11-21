using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002933 RID: 10547
public class RedDotMoonChasingDelegation : RedDotBase
{
	// Token: 0x0601A8AE RID: 108718 RVA: 0x0082F175 File Offset: 0x0082D375
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshDelegationRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8AF RID: 108719 RVA: 0x0082F193 File Offset: 0x0082D393
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshDelegationRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8B0 RID: 108720 RVA: 0x0082F1B1 File Offset: 0x0082D3B1
	protected override bool OnCheck(int uId = 0)
	{
		return MoonChasingModel.Instance.CheckDelegationRedDotState();
	}
}

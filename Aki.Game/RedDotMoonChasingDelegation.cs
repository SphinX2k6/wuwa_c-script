using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C1 RID: 13249
public class RedDotMoonChasingDelegation : RedDotBase
{
	// Token: 0x0601CBB6 RID: 117686 RVA: 0x00808BB1 File Offset: 0x00806DB1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshDelegationRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBB7 RID: 117687 RVA: 0x00808BCF File Offset: 0x00806DCF
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshDelegationRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBB8 RID: 117688 RVA: 0x00808BED File Offset: 0x00806DED
	protected override bool OnCheck(int uId = 0)
	{
		return MoonChasingModel.Instance.CheckDelegationRedDotState();
	}
}

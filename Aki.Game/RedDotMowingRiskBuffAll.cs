using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033E1 RID: 13281
public class RedDotMowingRiskBuffAll : RedDotBase
{
	// Token: 0x0601CC53 RID: 117843 RVA: 0x00809D44 File Offset: 0x00807F44
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MowingRiskOnRefreshBuffAllRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC54 RID: 117844 RVA: 0x00809D62 File Offset: 0x00807F62
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MowingRiskOnRefreshBuffAllRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CC55 RID: 117845 RVA: 0x00809D80 File Offset: 0x00807F80
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

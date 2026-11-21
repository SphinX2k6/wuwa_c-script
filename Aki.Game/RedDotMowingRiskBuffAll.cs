using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002953 RID: 10579
public class RedDotMowingRiskBuffAll : RedDotBase
{
	// Token: 0x0601A94B RID: 108875 RVA: 0x00830308 File Offset: 0x0082E508
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MowingRiskOnRefreshBuffAllRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A94C RID: 108876 RVA: 0x00830326 File Offset: 0x0082E526
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MowingRiskOnRefreshBuffAllRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A94D RID: 108877 RVA: 0x00830344 File Offset: 0x0082E544
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

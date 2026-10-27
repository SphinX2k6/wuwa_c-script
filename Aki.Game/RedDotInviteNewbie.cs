using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033B8 RID: 13240
public class RedDotInviteNewbie : RedDotBase
{
	// Token: 0x0601CB91 RID: 117649 RVA: 0x00808844 File Offset: 0x00806A44
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.InviteNewbieEntered, new Action(base.EventCheck));
	}

	// Token: 0x0601CB92 RID: 117650 RVA: 0x00808862 File Offset: 0x00806A62
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.InviteNewbieEntered, new Action(base.EventCheck));
	}

	// Token: 0x0601CB93 RID: 117651 RVA: 0x00808880 File Offset: 0x00806A80
	protected override bool OnCheck(int uId = 0)
	{
		return InviteNewbieModel.Instance.HasRedDot;
	}
}

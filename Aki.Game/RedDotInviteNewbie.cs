using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200292A RID: 10538
public class RedDotInviteNewbie : RedDotBase
{
	// Token: 0x0601A889 RID: 108681 RVA: 0x0082EE08 File Offset: 0x0082D008
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.InviteNewbieEntered, new Action(base.EventCheck));
	}

	// Token: 0x0601A88A RID: 108682 RVA: 0x0082EE26 File Offset: 0x0082D026
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.InviteNewbieEntered, new Action(base.EventCheck));
	}

	// Token: 0x0601A88B RID: 108683 RVA: 0x0082EE44 File Offset: 0x0082D044
	protected override bool OnCheck(int uId = 0)
	{
		return InviteNewbieModel.Instance.HasRedDot;
	}
}

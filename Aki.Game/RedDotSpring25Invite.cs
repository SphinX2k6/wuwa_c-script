using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A5 RID: 10661
public class RedDotSpring25Invite : RedDotBase
{
	// Token: 0x0601AADA RID: 109274 RVA: 0x00833A29 File Offset: 0x00831C29
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601AADB RID: 109275 RVA: 0x00833A63 File Offset: 0x00831C63
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601AADC RID: 109276 RVA: 0x00833A9D File Offset: 0x00831C9D
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.IsInviteAvailableExternal;
	}
}

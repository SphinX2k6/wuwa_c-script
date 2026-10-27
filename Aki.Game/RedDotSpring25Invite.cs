using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003431 RID: 13361
public class RedDotSpring25Invite : RedDotBase
{
	// Token: 0x0601CDDA RID: 118234 RVA: 0x0080D341 File Offset: 0x0080B541
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601CDDB RID: 118235 RVA: 0x0080D37B File Offset: 0x0080B57B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601CDDC RID: 118236 RVA: 0x0080D3B5 File Offset: 0x0080B5B5
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.IsInviteAvailableExternal;
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A3 RID: 10659
public class RedDotSpring25AllLetter : RedDotBase
{
	// Token: 0x0601AAD2 RID: 109266 RVA: 0x0083383C File Offset: 0x00831A3C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25CloseLetterList, new Action(base.EventCheck));
	}

	// Token: 0x0601AAD3 RID: 109267 RVA: 0x008338A0 File Offset: 0x00831AA0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25CloseLetterList, new Action(base.EventCheck));
	}

	// Token: 0x0601AAD4 RID: 109268 RVA: 0x00833901 File Offset: 0x00831B01
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.HasNewLetter;
	}
}

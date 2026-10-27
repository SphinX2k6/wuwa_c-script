using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200342F RID: 13359
public class RedDotSpring25AllLetter : RedDotBase
{
	// Token: 0x0601CDD2 RID: 118226 RVA: 0x0080D154 File Offset: 0x0080B354
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25CloseLetterList, new Action(base.EventCheck));
	}

	// Token: 0x0601CDD3 RID: 118227 RVA: 0x0080D1B8 File Offset: 0x0080B3B8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25CloseLetterList, new Action(base.EventCheck));
	}

	// Token: 0x0601CDD4 RID: 118228 RVA: 0x0080D219 File Offset: 0x0080B419
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.HasNewLetter;
	}
}

using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033EB RID: 13291
public class RedDotPhantomArenaActivity : RedDotBase
{
	// Token: 0x0601CC7F RID: 117887 RVA: 0x0080A320 File Offset: 0x00808520
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaRoleRewardUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhantomArenaShopOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CC80 RID: 117888 RVA: 0x0080A3F4 File Offset: 0x008085F4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaRoleRewardUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaShopOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CC81 RID: 117889 RVA: 0x0080A4C5 File Offset: 0x008086C5
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC82 RID: 117890 RVA: 0x0080A4C8 File Offset: 0x008086C8
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetPhantomArenaButtonRedDot(uId);
	}
}

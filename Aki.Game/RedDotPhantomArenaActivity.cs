using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x0200295D RID: 10589
public class RedDotPhantomArenaActivity : RedDotBase
{
	// Token: 0x0601A977 RID: 108919 RVA: 0x008308E4 File Offset: 0x0082EAE4
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

	// Token: 0x0601A978 RID: 108920 RVA: 0x008309B8 File Offset: 0x0082EBB8
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

	// Token: 0x0601A979 RID: 108921 RVA: 0x00830A89 File Offset: 0x0082EC89
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A97A RID: 108922 RVA: 0x00830A8C File Offset: 0x0082EC8C
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetPhantomArenaButtonRedDot(uId);
	}
}

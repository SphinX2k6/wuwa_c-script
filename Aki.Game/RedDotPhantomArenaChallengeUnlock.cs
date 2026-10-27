using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033EE RID: 13294
public class RedDotPhantomArenaChallengeUnlock : RedDotBase
{
	// Token: 0x0601CC90 RID: 117904 RVA: 0x0080A5AC File Offset: 0x008087AC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC91 RID: 117905 RVA: 0x0080A5CA File Offset: 0x008087CA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC92 RID: 117906 RVA: 0x0080A5E8 File Offset: 0x008087E8
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.GetChallengeUnlockRedDotById(uId);
	}
}

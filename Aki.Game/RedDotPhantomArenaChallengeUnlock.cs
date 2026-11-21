using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002960 RID: 10592
public class RedDotPhantomArenaChallengeUnlock : RedDotBase
{
	// Token: 0x0601A988 RID: 108936 RVA: 0x00830B70 File Offset: 0x0082ED70
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A989 RID: 108937 RVA: 0x00830B8E File Offset: 0x0082ED8E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A98A RID: 108938 RVA: 0x00830BAC File Offset: 0x0082EDAC
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.GetChallengeUnlockRedDotById(uId);
	}
}

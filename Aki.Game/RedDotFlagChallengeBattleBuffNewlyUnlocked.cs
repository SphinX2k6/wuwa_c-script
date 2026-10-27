using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200338F RID: 13199
public class RedDotFlagChallengeBattleBuffNewlyUnlocked : RedDotBase
{
	// Token: 0x0601CAD4 RID: 117460 RVA: 0x00806D54 File Offset: 0x00804F54
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFlagChallengeBattleBuffNewlyUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601CAD5 RID: 117461 RVA: 0x00806D72 File Offset: 0x00804F72
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFlagChallengeBattleBuffNewlyUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601CAD6 RID: 117462 RVA: 0x00806D90 File Offset: 0x00804F90
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

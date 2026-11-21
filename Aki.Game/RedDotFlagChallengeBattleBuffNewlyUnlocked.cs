using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002901 RID: 10497
public class RedDotFlagChallengeBattleBuffNewlyUnlocked : RedDotBase
{
	// Token: 0x0601A7CC RID: 108492 RVA: 0x0082D318 File Offset: 0x0082B518
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFlagChallengeBattleBuffNewlyUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601A7CD RID: 108493 RVA: 0x0082D336 File Offset: 0x0082B536
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFlagChallengeBattleBuffNewlyUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601A7CE RID: 108494 RVA: 0x0082D354 File Offset: 0x0082B554
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

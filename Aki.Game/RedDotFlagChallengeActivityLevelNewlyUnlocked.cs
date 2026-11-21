using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028FF RID: 10495
public class RedDotFlagChallengeActivityLevelNewlyUnlocked : RedDotBase
{
	// Token: 0x0601A7C3 RID: 108483 RVA: 0x0082D260 File Offset: 0x0082B460
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7C4 RID: 108484 RVA: 0x0082D27E File Offset: 0x0082B47E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7C5 RID: 108485 RVA: 0x0082D29C File Offset: 0x0082B49C
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

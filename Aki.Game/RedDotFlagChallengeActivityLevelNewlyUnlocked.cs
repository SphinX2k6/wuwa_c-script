using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200338D RID: 13197
public class RedDotFlagChallengeActivityLevelNewlyUnlocked : RedDotBase
{
	// Token: 0x0601CACB RID: 117451 RVA: 0x00806C9C File Offset: 0x00804E9C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CACC RID: 117452 RVA: 0x00806CBA File Offset: 0x00804EBA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFlagChallengeLevelNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CACD RID: 117453 RVA: 0x00806CD8 File Offset: 0x00804ED8
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}

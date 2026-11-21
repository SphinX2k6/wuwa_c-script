using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

// Token: 0x020028FE RID: 10494
public class RedDotFlagChallengeActivityBuffNewlyUnlocked : RedDotBase
{
	// Token: 0x0601A7BF RID: 108479 RVA: 0x0082D1F5 File Offset: 0x0082B3F5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeBuffNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7C0 RID: 108480 RVA: 0x0082D213 File Offset: 0x0082B413
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFlagChallengeBuffNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7C1 RID: 108481 RVA: 0x0082D234 File Offset: 0x0082B434
	protected override bool OnCheck(int uId = 0)
	{
		FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(uId);
		return flagChallengeData != null && flagChallengeData.HasBuffNewlyUnlocked();
	}
}

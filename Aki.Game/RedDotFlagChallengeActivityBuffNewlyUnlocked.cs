using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

// Token: 0x0200338C RID: 13196
public class RedDotFlagChallengeActivityBuffNewlyUnlocked : RedDotBase
{
	// Token: 0x0601CAC7 RID: 117447 RVA: 0x00806C31 File Offset: 0x00804E31
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeBuffNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAC8 RID: 117448 RVA: 0x00806C4F File Offset: 0x00804E4F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFlagChallengeBuffNewlyUnlock, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAC9 RID: 117449 RVA: 0x00806C70 File Offset: 0x00804E70
	protected override bool OnCheck(int uId = 0)
	{
		FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(uId);
		return flagChallengeData != null && flagChallengeData.HasBuffNewlyUnlocked();
	}
}

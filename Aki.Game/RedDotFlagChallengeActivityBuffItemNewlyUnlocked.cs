using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

// Token: 0x020028FD RID: 10493
public class RedDotFlagChallengeActivityBuffItemNewlyUnlocked : RedDotBase
{
	// Token: 0x0601A7BB RID: 108475 RVA: 0x0082D17D File Offset: 0x0082B37D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeBuffNewlyUnlockHintChanged, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7BC RID: 108476 RVA: 0x0082D19B File Offset: 0x0082B39B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFlagChallengeBuffNewlyUnlockHintChanged, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7BD RID: 108477 RVA: 0x0082D1BC File Offset: 0x0082B3BC
	protected override bool OnCheck(int uId = 0)
	{
		if (uId == 0)
		{
			return false;
		}
		int buffActivityId = FlagChallengeUtils.GetBuffActivityId(uId);
		FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(buffActivityId);
		return flagChallengeData != null && flagChallengeData.IsBuffNewlyUnlocked(uId);
	}
}

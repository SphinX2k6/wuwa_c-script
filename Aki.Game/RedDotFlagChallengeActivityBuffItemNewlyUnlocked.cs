using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

// Token: 0x0200338B RID: 13195
public class RedDotFlagChallengeActivityBuffItemNewlyUnlocked : RedDotBase
{
	// Token: 0x0601CAC3 RID: 117443 RVA: 0x00806BB9 File Offset: 0x00804DB9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeBuffNewlyUnlockHintChanged, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAC4 RID: 117444 RVA: 0x00806BD7 File Offset: 0x00804DD7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFlagChallengeBuffNewlyUnlockHintChanged, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAC5 RID: 117445 RVA: 0x00806BF8 File Offset: 0x00804DF8
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

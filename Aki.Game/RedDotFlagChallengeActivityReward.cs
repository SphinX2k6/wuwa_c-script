using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

// Token: 0x02002900 RID: 10496
public class RedDotFlagChallengeActivityReward : RedDotBase
{
	// Token: 0x0601A7C7 RID: 108487 RVA: 0x0082D2A7 File Offset: 0x0082B4A7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnFlagChallengeTaskUpdate));
	}

	// Token: 0x0601A7C8 RID: 108488 RVA: 0x0082D2C5 File Offset: 0x0082B4C5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnFlagChallengeTaskUpdate));
	}

	// Token: 0x0601A7C9 RID: 108489 RVA: 0x0082D2E4 File Offset: 0x0082B4E4
	protected override bool OnCheck(int uId = 0)
	{
		FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(uId);
		return flagChallengeData != null && flagChallengeData.HasCanReceiveTask();
	}

	// Token: 0x0601A7CA RID: 108490 RVA: 0x0082D308 File Offset: 0x0082B508
	private void OnFlagChallengeTaskUpdate(int activityId)
	{
		base.EventCheck();
	}
}

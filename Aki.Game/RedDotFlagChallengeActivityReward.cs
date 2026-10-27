using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FlagChallenge;

// Token: 0x0200338E RID: 13198
public class RedDotFlagChallengeActivityReward : RedDotBase
{
	// Token: 0x0601CACF RID: 117455 RVA: 0x00806CE3 File Offset: 0x00804EE3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnFlagChallengeTaskUpdate));
	}

	// Token: 0x0601CAD0 RID: 117456 RVA: 0x00806D01 File Offset: 0x00804F01
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnFlagChallengeTaskUpdate));
	}

	// Token: 0x0601CAD1 RID: 117457 RVA: 0x00806D20 File Offset: 0x00804F20
	protected override bool OnCheck(int uId = 0)
	{
		FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(uId);
		return flagChallengeData != null && flagChallengeData.HasCanReceiveTask();
	}

	// Token: 0x0601CAD2 RID: 117458 RVA: 0x00806D44 File Offset: 0x00804F44
	private void OnFlagChallengeTaskUpdate(int activityId)
	{
		base.EventCheck();
	}
}

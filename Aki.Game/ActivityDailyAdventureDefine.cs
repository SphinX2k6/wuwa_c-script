using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020006C5 RID: 1733
public class ActivityDailyAdventureDefine : IStaticVariableResetter
{
	// Token: 0x06004F69 RID: 20329 RVA: 0x001AAC2E File Offset: 0x001A8E2E
	static ActivityDailyAdventureDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDailyAdventureDefine.CreateStaticDefaultValue), new Action(ActivityDailyAdventureDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06004F6A RID: 20330 RVA: 0x001AAC4D File Offset: 0x001A8E4D
	public static void CreateStaticDefaultValue()
	{
		ActivityDailyAdventureDefine.RewardStateResolver = new Dictionary<DailyAdventureTaskState, ERewardState>
		{
			{
				DailyAdventureTaskState.DailyAdventureTaskRunning,
				ERewardState.Progress
			},
			{
				DailyAdventureTaskState.DailyAdventureTaskFinish,
				ERewardState.FinishedAndUnClaimed
			},
			{
				DailyAdventureTaskState.DailyAdventureTaskTaken,
				ERewardState.FinishedAndClaimed
			}
		};
	}

	// Token: 0x06004F6B RID: 20331 RVA: 0x001AAC71 File Offset: 0x001A8E71
	public static void ResetStaticDefaultValue()
	{
		ActivityDailyAdventureDefine.RewardStateResolver = null;
	}

	// Token: 0x04003955 RID: 14677
	public const int DAILY_ADVENTURE_PT_CONFIGID = 13;

	// Token: 0x04003956 RID: 14678
	[Nullable(1)]
	public static Dictionary<DailyAdventureTaskState, ERewardState> RewardStateResolver;
}

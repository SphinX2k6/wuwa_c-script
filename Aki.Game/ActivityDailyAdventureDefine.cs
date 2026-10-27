using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001211 RID: 4625
public class ActivityDailyAdventureDefine : IStaticVariableResetter
{
	// Token: 0x06007BD3 RID: 31699 RVA: 0x001A1FB6 File Offset: 0x001A01B6
	static ActivityDailyAdventureDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDailyAdventureDefine.CreateStaticDefaultValue), new Action(ActivityDailyAdventureDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x001A1FD5 File Offset: 0x001A01D5
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

	// Token: 0x06007BD5 RID: 31701 RVA: 0x001A1FF9 File Offset: 0x001A01F9
	public static void ResetStaticDefaultValue()
	{
		ActivityDailyAdventureDefine.RewardStateResolver = null;
	}

	// Token: 0x040038BC RID: 14524
	public const int DAILY_ADVENTURE_PT_CONFIGID = 13;

	// Token: 0x040038BD RID: 14525
	[Nullable(1)]
	public static Dictionary<DailyAdventureTaskState, ERewardState> RewardStateResolver;
}

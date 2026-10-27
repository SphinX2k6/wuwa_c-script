using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C0B RID: 23563
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingDefine : IStaticVariableResetter
	{
		// Token: 0x0603B8B6 RID: 243894 RVA: 0x00E322A0 File Offset: 0x00E304A0
		static BossPilingDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingDefine.CreateStaticDefaultValue), new Action(BossPilingDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603B8B7 RID: 243895 RVA: 0x00E322C0 File Offset: 0x00E304C0
		public static void CreateStaticDefaultValue()
		{
			BossPilingDefine.BossPilingScoreTexMap = new Dictionary<int, string>
			{
				{
					1,
					"SP_BossPilingBossSelectScoreB"
				},
				{
					2,
					"SP_BossPilingBossSelectScoreA"
				},
				{
					3,
					"SP_BossPilingBossSelectScoreS"
				},
				{
					4,
					"SP_BossPilingBossSelectScoreSS"
				}
			};
			BossPilingDefine.BossPilingTaskStateToRewardStateResolver = new Dictionary<ConditionTaskState, EActivityRewardState>
			{
				{
					ConditionTaskState.ConditionTaskRunning,
					EActivityRewardState.Disabled
				},
				{
					ConditionTaskState.ConditionTaskFinish,
					EActivityRewardState.Enable
				},
				{
					ConditionTaskState.ConditionTaskTaken,
					EActivityRewardState.Claimed
				}
			};
			BossPilingDefine.BossPilingTaskStateToRewardText = new Dictionary<ConditionTaskState, string>
			{
				{
					ConditionTaskState.ConditionTaskRunning,
					"BossPilingActivity_Reward13"
				},
				{
					ConditionTaskState.ConditionTaskFinish,
					"BossPilingActivity_Reward12"
				},
				{
					ConditionTaskState.ConditionTaskTaken,
					"BossPilingActivity_Reward12"
				}
			};
		}

		// Token: 0x0603B8B8 RID: 243896 RVA: 0x00E32357 File Offset: 0x00E30557
		public static void ResetStaticDefaultValue()
		{
			BossPilingDefine.BossPilingScoreTexMap = null;
			BossPilingDefine.BossPilingTaskStateToRewardStateResolver = null;
			BossPilingDefine.BossPilingTaskStateToRewardText = null;
		}

		// Token: 0x0401F014 RID: 126996
		public static Dictionary<int, string> BossPilingScoreTexMap;

		// Token: 0x0401F015 RID: 126997
		public static Dictionary<ConditionTaskState, EActivityRewardState> BossPilingTaskStateToRewardStateResolver;

		// Token: 0x0401F016 RID: 126998
		public static Dictionary<ConditionTaskState, string> BossPilingTaskStateToRewardText;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BEB RID: 19435
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingDefine : IStaticVariableResetter
	{
		// Token: 0x06030801 RID: 198657 RVA: 0x00D825E0 File Offset: 0x00D807E0
		static BossPilingDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingDefine.CreateStaticDefaultValue), new Action(BossPilingDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06030802 RID: 198658 RVA: 0x00D82600 File Offset: 0x00D80800
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

		// Token: 0x06030803 RID: 198659 RVA: 0x00D82697 File Offset: 0x00D80897
		public static void ResetStaticDefaultValue()
		{
			BossPilingDefine.BossPilingScoreTexMap = null;
			BossPilingDefine.BossPilingTaskStateToRewardStateResolver = null;
			BossPilingDefine.BossPilingTaskStateToRewardText = null;
		}

		// Token: 0x04019AC5 RID: 105157
		public static Dictionary<int, string> BossPilingScoreTexMap;

		// Token: 0x04019AC6 RID: 105158
		public static Dictionary<ConditionTaskState, EActivityRewardState> BossPilingTaskStateToRewardStateResolver;

		// Token: 0x04019AC7 RID: 105159
		public static Dictionary<ConditionTaskState, string> BossPilingTaskStateToRewardText;
	}
}

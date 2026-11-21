using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A70 RID: 14960
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardTabData
	{
		// Token: 0x06026715 RID: 157461 RVA: 0x00AC45C5 File Offset: 0x00AC27C5
		public TrapDefenseRewardTabData(ETrapDefenseRewardType type)
		{
			this.Type = type;
		}

		// Token: 0x06026716 RID: 157462 RVA: 0x00AC45D4 File Offset: 0x00AC27D4
		public string GetTitle()
		{
			return TrapDefenseDefine.rewardTypeNames[this.Type];
		}

		// Token: 0x06026717 RID: 157463 RVA: 0x00AC45E8 File Offset: 0x00AC27E8
		public string GetProgressText()
		{
			ValueTuple<int, int> rewardProgressByType = TrapDefenseModel.Instance.RewardData.GetRewardProgressByType(this.Type);
			int item = rewardProgressByType.Item1;
			int item2 = rewardProgressByType.Item2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06026718 RID: 157464 RVA: 0x00AC4644 File Offset: 0x00AC2844
		public bool IsFinished()
		{
			ValueTuple<int, int> rewardProgressByType = TrapDefenseModel.Instance.RewardData.GetRewardProgressByType(this.Type);
			int item = rewardProgressByType.Item1;
			int item2 = rewardProgressByType.Item2;
			return item >= item2;
		}

		// Token: 0x06026719 RID: 157465 RVA: 0x00AC467A File Offset: 0x00AC287A
		public bool HasRedDot()
		{
			return TrapDefenseModel.Instance.RewardData.IsCanClaimLimitRewardByType(this.Type);
		}

		// Token: 0x0401514F RID: 86351
		public readonly ETrapDefenseRewardType Type;
	}
}

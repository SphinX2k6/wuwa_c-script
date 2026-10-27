using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC8 RID: 19144
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardTabData
	{
		// Token: 0x06031985 RID: 203141 RVA: 0x00B80611 File Offset: 0x00B7E811
		public TrapDefenseRewardTabData(ETrapDefenseRewardType type)
		{
			this.Type = type;
		}

		// Token: 0x06031986 RID: 203142 RVA: 0x00B80620 File Offset: 0x00B7E820
		public string GetTitle()
		{
			return TrapDefenseDefine.rewardTypeNames[this.Type];
		}

		// Token: 0x06031987 RID: 203143 RVA: 0x00B80634 File Offset: 0x00B7E834
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

		// Token: 0x06031988 RID: 203144 RVA: 0x00B80690 File Offset: 0x00B7E890
		public bool IsFinished()
		{
			ValueTuple<int, int> rewardProgressByType = TrapDefenseModel.Instance.RewardData.GetRewardProgressByType(this.Type);
			int item = rewardProgressByType.Item1;
			int item2 = rewardProgressByType.Item2;
			return item >= item2;
		}

		// Token: 0x06031989 RID: 203145 RVA: 0x00B806C6 File Offset: 0x00B7E8C6
		public bool HasRedDot()
		{
			return TrapDefenseModel.Instance.RewardData.IsCanClaimLimitRewardByType(this.Type);
		}

		// Token: 0x0401A7FD RID: 108541
		public readonly ETrapDefenseRewardType Type;
	}
}

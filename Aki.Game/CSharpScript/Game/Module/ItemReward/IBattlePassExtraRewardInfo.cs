using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004799 RID: 18329
	[NullableContext(1)]
	public interface IBattlePassExtraRewardInfo : IRewardInfo
	{
		// Token: 0x17005D50 RID: 23888
		// (get) Token: 0x0602E125 RID: 188709
		// (set) Token: 0x0602E126 RID: 188710
		List<RewardItemData> CommonItems { get; set; }

		// Token: 0x17005D51 RID: 23889
		// (get) Token: 0x0602E127 RID: 188711
		// (set) Token: 0x0602E128 RID: 188712
		List<RewardItemData> ExtraItems { get; set; }

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x0602E129 RID: 188713
		// (set) Token: 0x0602E12A RID: 188714
		[Nullable(2)]
		string TipsTextId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005D53 RID: 23891
		// (get) Token: 0x0602E12B RID: 188715
		// (set) Token: 0x0602E12C RID: 188716
		Action LeftAction { get; set; }

		// Token: 0x17005D54 RID: 23892
		// (get) Token: 0x0602E12D RID: 188717
		// (set) Token: 0x0602E12E RID: 188718
		Action RightAction { get; set; }

		// Token: 0x17005D55 RID: 23893
		// (get) Token: 0x0602E12F RID: 188719
		// (set) Token: 0x0602E130 RID: 188720
		[Nullable(2)]
		Action<bool> FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

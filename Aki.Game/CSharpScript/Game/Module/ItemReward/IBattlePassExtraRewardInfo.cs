using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C2 RID: 22466
	[NullableContext(1)]
	public interface IBattlePassExtraRewardInfo : IRewardInfo
	{
		// Token: 0x17008988 RID: 35208
		// (get) Token: 0x06039215 RID: 234005
		// (set) Token: 0x06039216 RID: 234006
		List<RewardItemData> CommonItems { get; set; }

		// Token: 0x17008989 RID: 35209
		// (get) Token: 0x06039217 RID: 234007
		// (set) Token: 0x06039218 RID: 234008
		List<RewardItemData> ExtraItems { get; set; }

		// Token: 0x1700898A RID: 35210
		// (get) Token: 0x06039219 RID: 234009
		// (set) Token: 0x0603921A RID: 234010
		[Nullable(2)]
		string TipsTextId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700898B RID: 35211
		// (get) Token: 0x0603921B RID: 234011
		// (set) Token: 0x0603921C RID: 234012
		Action LeftAction { get; set; }

		// Token: 0x1700898C RID: 35212
		// (get) Token: 0x0603921D RID: 234013
		// (set) Token: 0x0603921E RID: 234014
		Action RightAction { get; set; }

		// Token: 0x1700898D RID: 35213
		// (get) Token: 0x0603921F RID: 234015
		// (set) Token: 0x06039220 RID: 234016
		[Nullable(2)]
		Action<bool> FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

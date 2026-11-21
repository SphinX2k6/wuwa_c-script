using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200479A RID: 18330
	[NullableContext(1)]
	[Nullable(0)]
	public class BattlePassExtraRewardInfo : RewardInfo, IBattlePassExtraRewardInfo, IRewardInfo
	{
		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x0602E131 RID: 188721 RVA: 0x00CDEDF0 File Offset: 0x00CDCFF0
		// (set) Token: 0x0602E132 RID: 188722 RVA: 0x00CDEDF8 File Offset: 0x00CDCFF8
		public List<RewardItemData> CommonItems { get; set; }

		// Token: 0x17005D57 RID: 23895
		// (get) Token: 0x0602E133 RID: 188723 RVA: 0x00CDEE01 File Offset: 0x00CDD001
		// (set) Token: 0x0602E134 RID: 188724 RVA: 0x00CDEE09 File Offset: 0x00CDD009
		public List<RewardItemData> ExtraItems { get; set; }

		// Token: 0x17005D58 RID: 23896
		// (get) Token: 0x0602E135 RID: 188725 RVA: 0x00CDEE12 File Offset: 0x00CDD012
		// (set) Token: 0x0602E136 RID: 188726 RVA: 0x00CDEE1A File Offset: 0x00CDD01A
		[Nullable(2)]
		public string TipsTextId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005D59 RID: 23897
		// (get) Token: 0x0602E137 RID: 188727 RVA: 0x00CDEE23 File Offset: 0x00CDD023
		// (set) Token: 0x0602E138 RID: 188728 RVA: 0x00CDEE2B File Offset: 0x00CDD02B
		public Action LeftAction { get; set; }

		// Token: 0x17005D5A RID: 23898
		// (get) Token: 0x0602E139 RID: 188729 RVA: 0x00CDEE34 File Offset: 0x00CDD034
		// (set) Token: 0x0602E13A RID: 188730 RVA: 0x00CDEE3C File Offset: 0x00CDD03C
		public Action RightAction { get; set; }

		// Token: 0x17005D5B RID: 23899
		// (get) Token: 0x0602E13B RID: 188731 RVA: 0x00CDEE45 File Offset: 0x00CDD045
		// (set) Token: 0x0602E13C RID: 188732 RVA: 0x00CDEE4D File Offset: 0x00CDD04D
		[Nullable(2)]
		public Action<bool> FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

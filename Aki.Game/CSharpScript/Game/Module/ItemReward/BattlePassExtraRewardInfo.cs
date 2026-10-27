using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C3 RID: 22467
	[NullableContext(1)]
	[Nullable(0)]
	public class BattlePassExtraRewardInfo : RewardInfo, IBattlePassExtraRewardInfo, IRewardInfo
	{
		// Token: 0x1700898E RID: 35214
		// (get) Token: 0x06039221 RID: 234017 RVA: 0x00D8FFB8 File Offset: 0x00D8E1B8
		// (set) Token: 0x06039222 RID: 234018 RVA: 0x00D8FFC0 File Offset: 0x00D8E1C0
		public List<RewardItemData> CommonItems { get; set; }

		// Token: 0x1700898F RID: 35215
		// (get) Token: 0x06039223 RID: 234019 RVA: 0x00D8FFC9 File Offset: 0x00D8E1C9
		// (set) Token: 0x06039224 RID: 234020 RVA: 0x00D8FFD1 File Offset: 0x00D8E1D1
		public List<RewardItemData> ExtraItems { get; set; }

		// Token: 0x17008990 RID: 35216
		// (get) Token: 0x06039225 RID: 234021 RVA: 0x00D8FFDA File Offset: 0x00D8E1DA
		// (set) Token: 0x06039226 RID: 234022 RVA: 0x00D8FFE2 File Offset: 0x00D8E1E2
		[Nullable(2)]
		public string TipsTextId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008991 RID: 35217
		// (get) Token: 0x06039227 RID: 234023 RVA: 0x00D8FFEB File Offset: 0x00D8E1EB
		// (set) Token: 0x06039228 RID: 234024 RVA: 0x00D8FFF3 File Offset: 0x00D8E1F3
		public Action LeftAction { get; set; }

		// Token: 0x17008992 RID: 35218
		// (get) Token: 0x06039229 RID: 234025 RVA: 0x00D8FFFC File Offset: 0x00D8E1FC
		// (set) Token: 0x0603922A RID: 234026 RVA: 0x00D90004 File Offset: 0x00D8E204
		public Action RightAction { get; set; }

		// Token: 0x17008993 RID: 35219
		// (get) Token: 0x0603922B RID: 234027 RVA: 0x00D9000D File Offset: 0x00D8E20D
		// (set) Token: 0x0603922C RID: 234028 RVA: 0x00D90015 File Offset: 0x00D8E215
		[Nullable(2)]
		public Action<bool> FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

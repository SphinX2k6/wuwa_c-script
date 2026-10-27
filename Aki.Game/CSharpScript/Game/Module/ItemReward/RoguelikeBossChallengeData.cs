using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E5 RID: 22501
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeData : IRoguelikeBossChallengeData
	{
		// Token: 0x170089FA RID: 35322
		// (get) Token: 0x0603930A RID: 234250 RVA: 0x00D903E1 File Offset: 0x00D8E5E1
		// (set) Token: 0x0603930B RID: 234251 RVA: 0x00D903E9 File Offset: 0x00D8E5E9
		public bool IsNewRecord { get; set; }

		// Token: 0x170089FB RID: 35323
		// (get) Token: 0x0603930C RID: 234252 RVA: 0x00D903F2 File Offset: 0x00D8E5F2
		// (set) Token: 0x0603930D RID: 234253 RVA: 0x00D903FA File Offset: 0x00D8E5FA
		public int PassTime { get; set; }

		// Token: 0x170089FC RID: 35324
		// (get) Token: 0x0603930E RID: 234254 RVA: 0x00D90403 File Offset: 0x00D8E603
		// (set) Token: 0x0603930F RID: 234255 RVA: 0x00D9040B File Offset: 0x00D8E60B
		public int InstId { get; set; }

		// Token: 0x170089FD RID: 35325
		// (get) Token: 0x06039310 RID: 234256 RVA: 0x00D90414 File Offset: 0x00D8E614
		// (set) Token: 0x06039311 RID: 234257 RVA: 0x00D9041C File Offset: 0x00D8E61C
		public int BossTotalCount { get; set; }

		// Token: 0x170089FE RID: 35326
		// (get) Token: 0x06039312 RID: 234258 RVA: 0x00D90425 File Offset: 0x00D8E625
		// (set) Token: 0x06039313 RID: 234259 RVA: 0x00D9042D File Offset: 0x00D8E62D
		public IReadOnlyList<int> FinishedBossIdList { get; set; }

		// Token: 0x170089FF RID: 35327
		// (get) Token: 0x06039314 RID: 234260 RVA: 0x00D90436 File Offset: 0x00D8E636
		// (set) Token: 0x06039315 RID: 234261 RVA: 0x00D9043E File Offset: 0x00D8E63E
		public int? CurrentBossId { get; set; }
	}
}

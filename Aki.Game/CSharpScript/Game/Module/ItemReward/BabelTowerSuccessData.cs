using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057DD RID: 22493
	[NullableContext(1)]
	[Nullable(0)]
	public class BabelTowerSuccessData : IBabelTowerSuccessData
	{
		// Token: 0x170089E4 RID: 35300
		// (get) Token: 0x060392DA RID: 234202 RVA: 0x00D90317 File Offset: 0x00D8E517
		// (set) Token: 0x060392DB RID: 234203 RVA: 0x00D9031F File Offset: 0x00D8E51F
		public List<int> NewBabelBuffIds { get; set; }

		// Token: 0x170089E5 RID: 35301
		// (get) Token: 0x060392DC RID: 234204 RVA: 0x00D90328 File Offset: 0x00D8E528
		// (set) Token: 0x060392DD RID: 234205 RVA: 0x00D90330 File Offset: 0x00D8E530
		public List<int> NewBabelDeTermIds { get; set; }

		// Token: 0x170089E6 RID: 35302
		// (get) Token: 0x060392DE RID: 234206 RVA: 0x00D90339 File Offset: 0x00D8E539
		// (set) Token: 0x060392DF RID: 234207 RVA: 0x00D90341 File Offset: 0x00D8E541
		public TableTextArgNew StarTextParam { get; set; }

		// Token: 0x170089E7 RID: 35303
		// (get) Token: 0x060392E0 RID: 234208 RVA: 0x00D9034A File Offset: 0x00D8E54A
		// (set) Token: 0x060392E1 RID: 234209 RVA: 0x00D90352 File Offset: 0x00D8E552
		public string TipTextId { get; set; }
	}
}

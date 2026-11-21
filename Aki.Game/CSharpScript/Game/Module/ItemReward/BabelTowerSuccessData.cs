using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047B4 RID: 18356
	[NullableContext(1)]
	[Nullable(0)]
	public class BabelTowerSuccessData : IBabelTowerSuccessData
	{
		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x0602E1EE RID: 188910 RVA: 0x00CDF160 File Offset: 0x00CDD360
		// (set) Token: 0x0602E1EF RID: 188911 RVA: 0x00CDF168 File Offset: 0x00CDD368
		public List<int> NewBabelBuffIds { get; set; }

		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x0602E1F0 RID: 188912 RVA: 0x00CDF171 File Offset: 0x00CDD371
		// (set) Token: 0x0602E1F1 RID: 188913 RVA: 0x00CDF179 File Offset: 0x00CDD379
		public List<int> NewBabelDeTermIds { get; set; }

		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x0602E1F2 RID: 188914 RVA: 0x00CDF182 File Offset: 0x00CDD382
		// (set) Token: 0x0602E1F3 RID: 188915 RVA: 0x00CDF18A File Offset: 0x00CDD38A
		public TableTextArgNew StarTextParam { get; set; }

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x0602E1F4 RID: 188916 RVA: 0x00CDF193 File Offset: 0x00CDD393
		// (set) Token: 0x0602E1F5 RID: 188917 RVA: 0x00CDF19B File Offset: 0x00CDD39B
		public string TipTextId { get; set; }
	}
}

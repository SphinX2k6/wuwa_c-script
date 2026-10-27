using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x02004836 RID: 18486
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryTipItemParam : IWorldMapSecondaryTipItemParam
	{
		// Token: 0x170078F0 RID: 30960
		// (get) Token: 0x06030619 RID: 198169 RVA: 0x00B3B56A File Offset: 0x00B3976A
		// (set) Token: 0x0603061A RID: 198170 RVA: 0x00B3B572 File Offset: 0x00B39772
		public string Name { get; set; }

		// Token: 0x170078F1 RID: 30961
		// (get) Token: 0x0603061B RID: 198171 RVA: 0x00B3B57B File Offset: 0x00B3977B
		// (set) Token: 0x0603061C RID: 198172 RVA: 0x00B3B583 File Offset: 0x00B39783
		public string Desc { get; set; }
	}
}

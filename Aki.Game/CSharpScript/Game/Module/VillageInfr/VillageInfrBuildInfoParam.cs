using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200380B RID: 14347
	[NullableContext(2)]
	[Nullable(0)]
	public class VillageInfrBuildInfoParam : IVillageInfrBuildInfoParam
	{
		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x060254B2 RID: 152754 RVA: 0x00A83E31 File Offset: 0x00A82031
		// (set) Token: 0x060254B3 RID: 152755 RVA: 0x00A83E39 File Offset: 0x00A82039
		public EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x060254B4 RID: 152756 RVA: 0x00A83E42 File Offset: 0x00A82042
		// (set) Token: 0x060254B5 RID: 152757 RVA: 0x00A83E4A File Offset: 0x00A8204A
		public int SelectId { get; set; }

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x060254B6 RID: 152758 RVA: 0x00A83E53 File Offset: 0x00A82053
		// (set) Token: 0x060254B7 RID: 152759 RVA: 0x00A83E5B File Offset: 0x00A8205B
		public bool IsDelivery { get; set; }

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x060254B8 RID: 152760 RVA: 0x00A83E64 File Offset: 0x00A82064
		// (set) Token: 0x060254B9 RID: 152761 RVA: 0x00A83E6C File Offset: 0x00A8206C
		public Action CloseCb { get; set; }
	}
}

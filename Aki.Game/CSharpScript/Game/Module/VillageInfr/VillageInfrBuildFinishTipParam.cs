using System;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003815 RID: 14357
	public class VillageInfrBuildFinishTipParam : IVillageInfrBuildFinishTipParam
	{
		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x060254E3 RID: 152803 RVA: 0x00A83F25 File Offset: 0x00A82125
		// (set) Token: 0x060254E4 RID: 152804 RVA: 0x00A83F2D File Offset: 0x00A8212D
		public EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x060254E5 RID: 152805 RVA: 0x00A83F36 File Offset: 0x00A82136
		// (set) Token: 0x060254E6 RID: 152806 RVA: 0x00A83F3E File Offset: 0x00A8213E
		public int SelectId { get; set; }
	}
}

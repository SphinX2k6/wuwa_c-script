using System;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200489E RID: 18590
	public class VillageInfrBuildFinishTipParam : IVillageInfrBuildFinishTipParam
	{
		// Token: 0x17007950 RID: 31056
		// (get) Token: 0x060309B7 RID: 199095 RVA: 0x00B4911D File Offset: 0x00B4731D
		// (set) Token: 0x060309B8 RID: 199096 RVA: 0x00B49125 File Offset: 0x00B47325
		public EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x17007951 RID: 31057
		// (get) Token: 0x060309B9 RID: 199097 RVA: 0x00B4912E File Offset: 0x00B4732E
		// (set) Token: 0x060309BA RID: 199098 RVA: 0x00B49136 File Offset: 0x00B47336
		public int SelectId { get; set; }
	}
}

using System;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200489D RID: 18589
	public interface IVillageInfrBuildFinishTipParam
	{
		// Token: 0x1700794E RID: 31054
		// (get) Token: 0x060309B3 RID: 199091
		// (set) Token: 0x060309B4 RID: 199092
		EVillageInfrSelectType SelectType { get; set; }

		// Token: 0x1700794F RID: 31055
		// (get) Token: 0x060309B5 RID: 199093
		// (set) Token: 0x060309B6 RID: 199094
		int SelectId { get; set; }
	}
}

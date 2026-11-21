using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE6 RID: 19174
	public interface ICookerInfoData
	{
		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x0602FF71 RID: 196465
		// (set) Token: 0x0602FF72 RID: 196466
		int CookingLevel { get; set; }

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x0602FF73 RID: 196467
		// (set) Token: 0x0602FF74 RID: 196468
		int TotalProficiencys { get; set; }

		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x0602FF75 RID: 196469
		// (set) Token: 0x0602FF76 RID: 196470
		int AddExp { get; set; }
	}
}

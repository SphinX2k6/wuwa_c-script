using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B06 RID: 23302
	public class CookerInfoData : ICookerInfoData
	{
		// Token: 0x17008C72 RID: 35954
		// (get) Token: 0x0603B005 RID: 241669 RVA: 0x00E110FB File Offset: 0x00E0F2FB
		// (set) Token: 0x0603B006 RID: 241670 RVA: 0x00E11103 File Offset: 0x00E0F303
		public int CookingLevel { get; set; }

		// Token: 0x17008C73 RID: 35955
		// (get) Token: 0x0603B007 RID: 241671 RVA: 0x00E1110C File Offset: 0x00E0F30C
		// (set) Token: 0x0603B008 RID: 241672 RVA: 0x00E11114 File Offset: 0x00E0F314
		public int TotalProficiencys { get; set; }

		// Token: 0x17008C74 RID: 35956
		// (get) Token: 0x0603B009 RID: 241673 RVA: 0x00E1111D File Offset: 0x00E0F31D
		// (set) Token: 0x0603B00A RID: 241674 RVA: 0x00E11125 File Offset: 0x00E0F325
		public int AddExp { get; set; }
	}
}

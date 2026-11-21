using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE7 RID: 19175
	public class CookerInfoData : ICookerInfoData
	{
		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x0602FF77 RID: 196471 RVA: 0x00D61E13 File Offset: 0x00D60013
		// (set) Token: 0x0602FF78 RID: 196472 RVA: 0x00D61E1B File Offset: 0x00D6001B
		public int CookingLevel { get; set; }

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x0602FF79 RID: 196473 RVA: 0x00D61E24 File Offset: 0x00D60024
		// (set) Token: 0x0602FF7A RID: 196474 RVA: 0x00D61E2C File Offset: 0x00D6002C
		public int TotalProficiencys { get; set; }

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x0602FF7B RID: 196475 RVA: 0x00D61E35 File Offset: 0x00D60035
		// (set) Token: 0x0602FF7C RID: 196476 RVA: 0x00D61E3D File Offset: 0x00D6003D
		public int AddExp { get; set; }
	}
}

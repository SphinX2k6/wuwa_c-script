using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E57 RID: 20055
	public struct FetterData : IFetterData
	{
		// Token: 0x17007ED9 RID: 32473
		// (get) Token: 0x06033ACB RID: 211659 RVA: 0x00C195DE File Offset: 0x00C177DE
		// (set) Token: 0x06033ACC RID: 211660 RVA: 0x00C195E6 File Offset: 0x00C177E6
		public int Id { readonly get; set; }

		// Token: 0x17007EDA RID: 32474
		// (get) Token: 0x06033ACD RID: 211661 RVA: 0x00C195EF File Offset: 0x00C177EF
		// (set) Token: 0x06033ACE RID: 211662 RVA: 0x00C195F7 File Offset: 0x00C177F7
		public int Lv { readonly get; set; }

		// Token: 0x17007EDB RID: 32475
		// (get) Token: 0x06033ACF RID: 211663 RVA: 0x00C19600 File Offset: 0x00C17800
		// (set) Token: 0x06033AD0 RID: 211664 RVA: 0x00C19608 File Offset: 0x00C17808
		public int Star { readonly get; set; }

		// Token: 0x17007EDC RID: 32476
		// (get) Token: 0x06033AD1 RID: 211665 RVA: 0x00C19611 File Offset: 0x00C17811
		// (set) Token: 0x06033AD2 RID: 211666 RVA: 0x00C19619 File Offset: 0x00C17819
		public bool IsLevelUp { readonly get; set; }
	}
}

using System;
using Aki.Config;

// Token: 0x020014A4 RID: 5284
public struct IActivityRegressDoubleDropChallengeItemData
{
	// Token: 0x17000CF8 RID: 3320
	// (get) Token: 0x060095B2 RID: 38322 RVA: 0x00204B4C File Offset: 0x00202D4C
	// (set) Token: 0x060095B3 RID: 38323 RVA: 0x00204B54 File Offset: 0x00202D54
	public EActivityRegressDoubleDropEntryType Type { readonly get; set; }

	// Token: 0x17000CF9 RID: 3321
	// (get) Token: 0x060095B4 RID: 38324 RVA: 0x00204B5D File Offset: 0x00202D5D
	// (set) Token: 0x060095B5 RID: 38325 RVA: 0x00204B65 File Offset: 0x00202D65
	public RegressDoubleDrop Config { readonly get; set; }
}

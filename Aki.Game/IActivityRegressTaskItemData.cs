using System;
using Aki.Config;

// Token: 0x020014A5 RID: 5285
public struct IActivityRegressTaskItemData
{
	// Token: 0x17000CFA RID: 3322
	// (get) Token: 0x060095B6 RID: 38326 RVA: 0x00204B6E File Offset: 0x00202D6E
	// (set) Token: 0x060095B7 RID: 38327 RVA: 0x00204B76 File Offset: 0x00202D76
	public EActivityRegressDoubleDropEntryType Type { readonly get; set; }

	// Token: 0x17000CFB RID: 3323
	// (get) Token: 0x060095B8 RID: 38328 RVA: 0x00204B7F File Offset: 0x00202D7F
	// (set) Token: 0x060095B9 RID: 38329 RVA: 0x00204B87 File Offset: 0x00202D87
	public RegressDoubleDrop Config { readonly get; set; }
}

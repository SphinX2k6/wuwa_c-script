using System;
using Aki.Config;

// Token: 0x02000958 RID: 2392
public struct IActivityRegressDoubleDropChallengeItemData
{
	// Token: 0x17000D18 RID: 3352
	// (get) Token: 0x06006947 RID: 26951 RVA: 0x0020DAB4 File Offset: 0x0020BCB4
	// (set) Token: 0x06006948 RID: 26952 RVA: 0x0020DABC File Offset: 0x0020BCBC
	public EActivityRegressDoubleDropEntryType Type { readonly get; set; }

	// Token: 0x17000D19 RID: 3353
	// (get) Token: 0x06006949 RID: 26953 RVA: 0x0020DAC5 File Offset: 0x0020BCC5
	// (set) Token: 0x0600694A RID: 26954 RVA: 0x0020DACD File Offset: 0x0020BCCD
	public RegressDoubleDrop Config { readonly get; set; }
}

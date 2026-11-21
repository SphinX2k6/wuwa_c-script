using System;
using Aki.Config;

// Token: 0x02000959 RID: 2393
public struct IActivityRegressTaskItemData
{
	// Token: 0x17000D1A RID: 3354
	// (get) Token: 0x0600694B RID: 26955 RVA: 0x0020DAD6 File Offset: 0x0020BCD6
	// (set) Token: 0x0600694C RID: 26956 RVA: 0x0020DADE File Offset: 0x0020BCDE
	public EActivityRegressDoubleDropEntryType Type { readonly get; set; }

	// Token: 0x17000D1B RID: 3355
	// (get) Token: 0x0600694D RID: 26957 RVA: 0x0020DAE7 File Offset: 0x0020BCE7
	// (set) Token: 0x0600694E RID: 26958 RVA: 0x0020DAEF File Offset: 0x0020BCEF
	public RegressDoubleDrop Config { readonly get; set; }
}

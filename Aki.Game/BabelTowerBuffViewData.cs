using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001140 RID: 4416
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerBuffViewData : IBabelTowerBuffViewData
{
	// Token: 0x17000A1F RID: 2591
	// (get) Token: 0x06007419 RID: 29721 RVA: 0x0017BCD4 File Offset: 0x00179ED4
	// (set) Token: 0x0600741A RID: 29722 RVA: 0x0017BCDC File Offset: 0x00179EDC
	public List<IBabelTowerBuffItemData> BuffDataList { get; set; }

	// Token: 0x17000A20 RID: 2592
	// (get) Token: 0x0600741B RID: 29723 RVA: 0x0017BCE5 File Offset: 0x00179EE5
	// (set) Token: 0x0600741C RID: 29724 RVA: 0x0017BCED File Offset: 0x00179EED
	public List<IBabelTowerBuffItemData> DeTermDataList { get; set; }
}

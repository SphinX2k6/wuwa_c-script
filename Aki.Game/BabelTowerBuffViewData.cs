using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005F4 RID: 1524
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerBuffViewData : IBabelTowerBuffViewData
{
	// Token: 0x17000A3F RID: 2623
	// (get) Token: 0x060047B0 RID: 18352 RVA: 0x00184822 File Offset: 0x00182A22
	// (set) Token: 0x060047B1 RID: 18353 RVA: 0x0018482A File Offset: 0x00182A2A
	public List<IBabelTowerBuffItemData> BuffDataList { get; set; }

	// Token: 0x17000A40 RID: 2624
	// (get) Token: 0x060047B2 RID: 18354 RVA: 0x00184833 File Offset: 0x00182A33
	// (set) Token: 0x060047B3 RID: 18355 RVA: 0x0018483B File Offset: 0x00182A3B
	public List<IBabelTowerBuffItemData> DeTermDataList { get; set; }
}

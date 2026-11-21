using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005F3 RID: 1523
[NullableContext(1)]
public interface IBabelTowerBuffViewData
{
	// Token: 0x17000A3D RID: 2621
	// (get) Token: 0x060047AC RID: 18348
	// (set) Token: 0x060047AD RID: 18349
	List<IBabelTowerBuffItemData> BuffDataList { get; set; }

	// Token: 0x17000A3E RID: 2622
	// (get) Token: 0x060047AE RID: 18350
	// (set) Token: 0x060047AF RID: 18351
	List<IBabelTowerBuffItemData> DeTermDataList { get; set; }
}

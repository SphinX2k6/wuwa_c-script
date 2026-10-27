using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200113F RID: 4415
[NullableContext(1)]
public interface IBabelTowerBuffViewData
{
	// Token: 0x17000A1D RID: 2589
	// (get) Token: 0x06007415 RID: 29717
	// (set) Token: 0x06007416 RID: 29718
	List<IBabelTowerBuffItemData> BuffDataList { get; set; }

	// Token: 0x17000A1E RID: 2590
	// (get) Token: 0x06007417 RID: 29719
	// (set) Token: 0x06007418 RID: 29720
	List<IBabelTowerBuffItemData> DeTermDataList { get; set; }
}

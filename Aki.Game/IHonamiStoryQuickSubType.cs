using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E77 RID: 7799
[NullableContext(1)]
public interface IHonamiStoryQuickSubType
{
	// Token: 0x170012C0 RID: 4800
	// (get) Token: 0x0600EDB9 RID: 60857
	// (set) Token: 0x0600EDBA RID: 60858
	int SubType { get; set; }

	// Token: 0x170012C1 RID: 4801
	// (get) Token: 0x0600EDBB RID: 60859
	// (set) Token: 0x0600EDBC RID: 60860
	List<HonamiStoryEquipItemData> ItemList { get; set; }
}

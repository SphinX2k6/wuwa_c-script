using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001339 RID: 4921
[NullableContext(1)]
public interface IHonamiStoryQuickSubType
{
	// Token: 0x170012EA RID: 4842
	// (get) Token: 0x0600C1D8 RID: 49624
	// (set) Token: 0x0600C1D9 RID: 49625
	int SubType { get; set; }

	// Token: 0x170012EB RID: 4843
	// (get) Token: 0x0600C1DA RID: 49626
	// (set) Token: 0x0600C1DB RID: 49627
	List<HonamiStoryEquipItemData> ItemList { get; set; }
}

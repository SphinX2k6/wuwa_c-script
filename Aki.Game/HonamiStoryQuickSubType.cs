using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E78 RID: 7800
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuickSubType : IHonamiStoryQuickSubType
{
	// Token: 0x170012C2 RID: 4802
	// (get) Token: 0x0600EDBD RID: 60861 RVA: 0x00389DBE File Offset: 0x00387FBE
	// (set) Token: 0x0600EDBE RID: 60862 RVA: 0x00389DC6 File Offset: 0x00387FC6
	public int SubType { get; set; }

	// Token: 0x170012C3 RID: 4803
	// (get) Token: 0x0600EDBF RID: 60863 RVA: 0x00389DCF File Offset: 0x00387FCF
	// (set) Token: 0x0600EDC0 RID: 60864 RVA: 0x00389DD7 File Offset: 0x00387FD7
	public List<HonamiStoryEquipItemData> ItemList { get; set; } = new List<HonamiStoryEquipItemData>();
}

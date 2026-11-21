using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200133A RID: 4922
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuickSubType : IHonamiStoryQuickSubType
{
	// Token: 0x170012EC RID: 4844
	// (get) Token: 0x0600C1DC RID: 49628 RVA: 0x003959AE File Offset: 0x00393BAE
	// (set) Token: 0x0600C1DD RID: 49629 RVA: 0x003959B6 File Offset: 0x00393BB6
	public int SubType { get; set; }

	// Token: 0x170012ED RID: 4845
	// (get) Token: 0x0600C1DE RID: 49630 RVA: 0x003959BF File Offset: 0x00393BBF
	// (set) Token: 0x0600C1DF RID: 49631 RVA: 0x003959C7 File Offset: 0x00393BC7
	public List<HonamiStoryEquipItemData> ItemList { get; set; } = new List<HonamiStoryEquipItemData>();
}

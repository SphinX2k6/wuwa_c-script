using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002911 RID: 10513
[NullableContext(1)]
[Nullable(0)]
public class RouletteListSaveData : IRouletteListSaveData
{
	// Token: 0x17001D24 RID: 7460
	// (get) Token: 0x06015AE6 RID: 88806 RVA: 0x005785B5 File Offset: 0x005767B5
	// (set) Token: 0x06015AE7 RID: 88807 RVA: 0x005785BD File Offset: 0x005767BD
	public ERouletteType RouletteType { get; set; }

	// Token: 0x17001D25 RID: 7461
	// (get) Token: 0x06015AE8 RID: 88808 RVA: 0x005785C6 File Offset: 0x005767C6
	// (set) Token: 0x06015AE9 RID: 88809 RVA: 0x005785CE File Offset: 0x005767CE
	public List<int> RouletteIdList { get; set; }

	// Token: 0x17001D26 RID: 7462
	// (get) Token: 0x06015AEA RID: 88810 RVA: 0x005785D7 File Offset: 0x005767D7
	// (set) Token: 0x06015AEB RID: 88811 RVA: 0x005785DF File Offset: 0x005767DF
	public int ExtraItemId { get; set; }

	// Token: 0x17001D27 RID: 7463
	// (get) Token: 0x06015AEC RID: 88812 RVA: 0x005785E8 File Offset: 0x005767E8
	// (set) Token: 0x06015AED RID: 88813 RVA: 0x005785F0 File Offset: 0x005767F0
	public int EquipExploreSkillId { get; set; }
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AAB RID: 6827
[NullableContext(1)]
[Nullable(0)]
public class MapAreaOnlyShowItemData : IMapAreaOnlyShowItemData
{
	// Token: 0x170010B3 RID: 4275
	// (get) Token: 0x0600CA3A RID: 51770 RVA: 0x002E1905 File Offset: 0x002DFB05
	// (set) Token: 0x0600CA3B RID: 51771 RVA: 0x002E190D File Offset: 0x002DFB0D
	public string IconPath { get; set; }

	// Token: 0x170010B4 RID: 4276
	// (get) Token: 0x0600CA3C RID: 51772 RVA: 0x002E1916 File Offset: 0x002DFB16
	// (set) Token: 0x0600CA3D RID: 51773 RVA: 0x002E191E File Offset: 0x002DFB1E
	public int OpenCount { get; set; }

	// Token: 0x170010B5 RID: 4277
	// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x002E1927 File Offset: 0x002DFB27
	// (set) Token: 0x0600CA3F RID: 51775 RVA: 0x002E192F File Offset: 0x002DFB2F
	public int NewOpenCount { get; set; }
}

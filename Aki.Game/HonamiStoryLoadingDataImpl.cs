using System;
using System.Runtime.CompilerServices;

// Token: 0x0200154C RID: 5452
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryLoadingDataImpl : IHonamiStoryLoadingData, ISpecialCustomLoadingData
{
	// Token: 0x17001460 RID: 5216
	// (get) Token: 0x0600DA38 RID: 55864 RVA: 0x0040A105 File Offset: 0x00408305
	// (set) Token: 0x0600DA39 RID: 55865 RVA: 0x0040A10D File Offset: 0x0040830D
	public string View { get; set; }

	// Token: 0x17001461 RID: 5217
	// (get) Token: 0x0600DA3A RID: 55866 RVA: 0x0040A116 File Offset: 0x00408316
	// (set) Token: 0x0600DA3B RID: 55867 RVA: 0x0040A11E File Offset: 0x0040831E
	public int? LoadingId { get; set; }

	// Token: 0x17001462 RID: 5218
	// (get) Token: 0x0600DA3C RID: 55868 RVA: 0x0040A127 File Offset: 0x00408327
	// (set) Token: 0x0600DA3D RID: 55869 RVA: 0x0040A12F File Offset: 0x0040832F
	public int? BtId { get; set; }

	// Token: 0x17001463 RID: 5219
	// (get) Token: 0x0600DA3E RID: 55870 RVA: 0x0040A138 File Offset: 0x00408338
	// (set) Token: 0x0600DA3F RID: 55871 RVA: 0x0040A140 File Offset: 0x00408340
	public int? Timing { get; set; }
}

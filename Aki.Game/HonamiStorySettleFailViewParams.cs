using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013D5 RID: 5077
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySettleFailViewParams : IHonamiStorySettleFailViewParams
{
	// Token: 0x17001353 RID: 4947
	// (get) Token: 0x0600C93D RID: 51517 RVA: 0x003BE284 File Offset: 0x003BC484
	// (set) Token: 0x0600C93E RID: 51518 RVA: 0x003BE28C File Offset: 0x003BC48C
	public List<IHonamiStorySettleItemParams> DisplayItems { get; set; } = new List<IHonamiStorySettleItemParams>();

	// Token: 0x17001354 RID: 4948
	// (get) Token: 0x0600C93F RID: 51519 RVA: 0x003BE295 File Offset: 0x003BC495
	// (set) Token: 0x0600C940 RID: 51520 RVA: 0x003BE29D File Offset: 0x003BC49D
	public int TotalReward { get; set; }

	// Token: 0x17001355 RID: 4949
	// (get) Token: 0x0600C941 RID: 51521 RVA: 0x003BE2A6 File Offset: 0x003BC4A6
	// (set) Token: 0x0600C942 RID: 51522 RVA: 0x003BE2AE File Offset: 0x003BC4AE
	public bool IsNewRecord { get; set; }

	// Token: 0x17001356 RID: 4950
	// (get) Token: 0x0600C943 RID: 51523 RVA: 0x003BE2B7 File Offset: 0x003BC4B7
	// (set) Token: 0x0600C944 RID: 51524 RVA: 0x003BE2BF File Offset: 0x003BC4BF
	public int FailAddProportion { get; set; }
}

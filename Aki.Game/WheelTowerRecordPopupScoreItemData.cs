using System;
using System.Runtime.CompilerServices;

// Token: 0x02000AE3 RID: 2787
[NullableContext(1)]
[Nullable(0)]
internal class WheelTowerRecordPopupScoreItemData
{
	// Token: 0x17000DA6 RID: 3494
	// (get) Token: 0x06007386 RID: 29574 RVA: 0x0023B1C4 File Offset: 0x002393C4
	// (set) Token: 0x06007387 RID: 29575 RVA: 0x0023B1CC File Offset: 0x002393CC
	public string Title { get; set; } = string.Empty;

	// Token: 0x17000DA7 RID: 3495
	// (get) Token: 0x06007388 RID: 29576 RVA: 0x0023B1D5 File Offset: 0x002393D5
	// (set) Token: 0x06007389 RID: 29577 RVA: 0x0023B1DD File Offset: 0x002393DD
	public int ScoreOld { get; set; }

	// Token: 0x17000DA8 RID: 3496
	// (get) Token: 0x0600738A RID: 29578 RVA: 0x0023B1E6 File Offset: 0x002393E6
	// (set) Token: 0x0600738B RID: 29579 RVA: 0x0023B1EE File Offset: 0x002393EE
	public int ScoreNew { get; set; }

	// Token: 0x17000DA9 RID: 3497
	// (get) Token: 0x0600738C RID: 29580 RVA: 0x0023B1F7 File Offset: 0x002393F7
	// (set) Token: 0x0600738D RID: 29581 RVA: 0x0023B1FF File Offset: 0x002393FF
	public bool NeedScoreIcon { get; set; }
}

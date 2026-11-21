using System;

// Token: 0x02001930 RID: 6448
public class VisionFetterCount : IVisionFetterCount
{
	// Token: 0x17001864 RID: 6244
	// (get) Token: 0x0600FEDA RID: 65242 RVA: 0x004A666F File Offset: 0x004A486F
	// (set) Token: 0x0600FEDB RID: 65243 RVA: 0x004A6677 File Offset: 0x004A4877
	public int GroupId { get; set; }

	// Token: 0x17001865 RID: 6245
	// (get) Token: 0x0600FEDC RID: 65244 RVA: 0x004A6680 File Offset: 0x004A4880
	// (set) Token: 0x0600FEDD RID: 65245 RVA: 0x004A6688 File Offset: 0x004A4888
	public int Count { get; set; }

	// Token: 0x17001866 RID: 6246
	// (get) Token: 0x0600FEDE RID: 65246 RVA: 0x004A6691 File Offset: 0x004A4891
	// (set) Token: 0x0600FEDF RID: 65247 RVA: 0x004A6699 File Offset: 0x004A4899
	public int FetterId { get; set; }
}

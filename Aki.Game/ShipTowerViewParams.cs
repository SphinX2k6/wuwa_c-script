using System;

// Token: 0x020029DE RID: 10718
public class ShipTowerViewParams
{
	// Token: 0x17001DA4 RID: 7588
	// (get) Token: 0x0601635C RID: 90972 RVA: 0x0059DF32 File Offset: 0x0059C132
	// (set) Token: 0x0601635D RID: 90973 RVA: 0x0059DF3A File Offset: 0x0059C13A
	public int ApplyTeamEditStageId { get; set; }

	// Token: 0x17001DA5 RID: 7589
	// (get) Token: 0x0601635E RID: 90974 RVA: 0x0059DF43 File Offset: 0x0059C143
	// (set) Token: 0x0601635F RID: 90975 RVA: 0x0059DF4B File Offset: 0x0059C14B
	public int? StageId { get; set; }

	// Token: 0x17001DA6 RID: 7590
	// (get) Token: 0x06016360 RID: 90976 RVA: 0x0059DF54 File Offset: 0x0059C154
	// (set) Token: 0x06016361 RID: 90977 RVA: 0x0059DF5C File Offset: 0x0059C15C
	public bool? IsOpenStageDesc { get; set; }

	// Token: 0x17001DA7 RID: 7591
	// (get) Token: 0x06016362 RID: 90978 RVA: 0x0059DF65 File Offset: 0x0059C165
	// (set) Token: 0x06016363 RID: 90979 RVA: 0x0059DF6D File Offset: 0x0059C16D
	public bool? IsFromInstanceDungeon { get; set; }

	// Token: 0x0400A54C RID: 42316
	public bool? IsOpenCover;
}

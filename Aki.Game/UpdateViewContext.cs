using System;

// Token: 0x02002A54 RID: 10836
public class UpdateViewContext
{
	// Token: 0x17001DF2 RID: 7666
	// (get) Token: 0x0601694D RID: 92493 RVA: 0x005B93AC File Offset: 0x005B75AC
	// (set) Token: 0x0601694E RID: 92494 RVA: 0x005B93B4 File Offset: 0x005B75B4
	public EFlySkinTab Tab { get; set; }

	// Token: 0x17001DF3 RID: 7667
	// (get) Token: 0x0601694F RID: 92495 RVA: 0x005B93BD File Offset: 0x005B75BD
	// (set) Token: 0x06016950 RID: 92496 RVA: 0x005B93C5 File Offset: 0x005B75C5
	public int SelectedSkinId { get; set; }

	// Token: 0x17001DF4 RID: 7668
	// (get) Token: 0x06016951 RID: 92497 RVA: 0x005B93CE File Offset: 0x005B75CE
	// (set) Token: 0x06016952 RID: 92498 RVA: 0x005B93D6 File Offset: 0x005B75D6
	public bool UiShowState { get; set; }

	// Token: 0x17001DF5 RID: 7669
	// (get) Token: 0x06016953 RID: 92499 RVA: 0x005B93DF File Offset: 0x005B75DF
	// (set) Token: 0x06016954 RID: 92500 RVA: 0x005B93E7 File Offset: 0x005B75E7
	public bool IsApplyToAll { get; set; }
}

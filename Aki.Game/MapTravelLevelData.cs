using System;

// Token: 0x02000785 RID: 1925
public class MapTravelLevelData : IMapTravelLevelData
{
	// Token: 0x17000B71 RID: 2929
	// (get) Token: 0x0600585E RID: 22622 RVA: 0x001CD4C3 File Offset: 0x001CB6C3
	// (set) Token: 0x0600585F RID: 22623 RVA: 0x001CD4CB File Offset: 0x001CB6CB
	public int Id { get; set; }

	// Token: 0x17000B72 RID: 2930
	// (get) Token: 0x06005860 RID: 22624 RVA: 0x001CD4D4 File Offset: 0x001CB6D4
	// (set) Token: 0x06005861 RID: 22625 RVA: 0x001CD4DC File Offset: 0x001CB6DC
	public int Level { get; set; }

	// Token: 0x17000B73 RID: 2931
	// (get) Token: 0x06005862 RID: 22626 RVA: 0x001CD4E5 File Offset: 0x001CB6E5
	// (set) Token: 0x06005863 RID: 22627 RVA: 0x001CD4ED File Offset: 0x001CB6ED
	public int AccumulateExp { get; set; }

	// Token: 0x17000B74 RID: 2932
	// (get) Token: 0x06005864 RID: 22628 RVA: 0x001CD4F6 File Offset: 0x001CB6F6
	// (set) Token: 0x06005865 RID: 22629 RVA: 0x001CD4FE File Offset: 0x001CB6FE
	public int TargetExp { get; set; }
}

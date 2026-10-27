using System;

// Token: 0x02001119 RID: 4377
public class BabelTowerBuffSelectViewLevelItemData : IBabelTowerBuffSelectViewLevelItemData
{
	// Token: 0x170009AE RID: 2478
	// (get) Token: 0x0600728A RID: 29322 RVA: 0x001779C4 File Offset: 0x00175BC4
	// (set) Token: 0x0600728B RID: 29323 RVA: 0x001779CC File Offset: 0x00175BCC
	public int LevelId { get; set; }

	// Token: 0x170009AF RID: 2479
	// (get) Token: 0x0600728C RID: 29324 RVA: 0x001779D5 File Offset: 0x00175BD5
	// (set) Token: 0x0600728D RID: 29325 RVA: 0x001779DD File Offset: 0x00175BDD
	public int BuffId { get; set; }

	// Token: 0x170009B0 RID: 2480
	// (get) Token: 0x0600728E RID: 29326 RVA: 0x001779E6 File Offset: 0x00175BE6
	// (set) Token: 0x0600728F RID: 29327 RVA: 0x001779EE File Offset: 0x00175BEE
	public EBabelTowerBuffState State { get; set; }
}

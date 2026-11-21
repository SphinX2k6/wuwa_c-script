using System;

// Token: 0x02001D26 RID: 7462
public class FavorItemInfo
{
	// Token: 0x17001B7F RID: 7039
	// (get) Token: 0x0601282A RID: 75818 RVA: 0x00578DE4 File Offset: 0x00576FE4
	// (set) Token: 0x0601282B RID: 75819 RVA: 0x00578DEC File Offset: 0x00576FEC
	public int Id { get; set; }

	// Token: 0x17001B80 RID: 7040
	// (get) Token: 0x0601282C RID: 75820 RVA: 0x00578DF5 File Offset: 0x00576FF5
	// (set) Token: 0x0601282D RID: 75821 RVA: 0x00578DFD File Offset: 0x00576FFD
	public EFavorItemStatus Status { get; set; }

	// Token: 0x0601282E RID: 75822 RVA: 0x00578E06 File Offset: 0x00577006
	public FavorItemInfo(int id, EFavorItemStatus status)
	{
		this.Id = id;
		this.Status = status;
	}
}

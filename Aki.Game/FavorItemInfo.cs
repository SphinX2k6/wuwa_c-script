using System;

// Token: 0x020027AB RID: 10155
public class FavorItemInfo
{
	// Token: 0x17001B28 RID: 6952
	// (get) Token: 0x06014E2B RID: 85547 RVA: 0x0054E0BC File Offset: 0x0054C2BC
	// (set) Token: 0x06014E2C RID: 85548 RVA: 0x0054E0C4 File Offset: 0x0054C2C4
	public int Id { get; set; }

	// Token: 0x17001B29 RID: 6953
	// (get) Token: 0x06014E2D RID: 85549 RVA: 0x0054E0CD File Offset: 0x0054C2CD
	// (set) Token: 0x06014E2E RID: 85550 RVA: 0x0054E0D5 File Offset: 0x0054C2D5
	public EFavorItemStatus Status { get; set; }

	// Token: 0x06014E2F RID: 85551 RVA: 0x0054E0DE File Offset: 0x0054C2DE
	public FavorItemInfo(int id, EFavorItemStatus status)
	{
		this.Id = id;
		this.Status = status;
	}
}

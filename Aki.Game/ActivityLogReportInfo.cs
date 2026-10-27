using System;

// Token: 0x0200167C RID: 5756
public class ActivityLogReportInfo
{
	// Token: 0x17000DC1 RID: 3521
	// (get) Token: 0x0600A299 RID: 41625 RVA: 0x0023DCCD File Offset: 0x0023BECD
	// (set) Token: 0x0600A29A RID: 41626 RVA: 0x0023DCD5 File Offset: 0x0023BED5
	public int Id { get; set; }

	// Token: 0x17000DC2 RID: 3522
	// (get) Token: 0x0600A29B RID: 41627 RVA: 0x0023DCDE File Offset: 0x0023BEDE
	// (set) Token: 0x0600A29C RID: 41628 RVA: 0x0023DCE6 File Offset: 0x0023BEE6
	public int Type { get; set; }

	// Token: 0x0600A29D RID: 41629 RVA: 0x0023DCEF File Offset: 0x0023BEEF
	public ActivityLogReportInfo(int id, int type)
	{
		this.Id = id;
		this.Type = type;
	}
}

using System;

// Token: 0x02000B34 RID: 2868
public class ActivityLogReportInfo
{
	// Token: 0x17000DE2 RID: 3554
	// (get) Token: 0x06007677 RID: 30327 RVA: 0x00247B5D File Offset: 0x00245D5D
	// (set) Token: 0x06007678 RID: 30328 RVA: 0x00247B65 File Offset: 0x00245D65
	public int Id { get; set; }

	// Token: 0x17000DE3 RID: 3555
	// (get) Token: 0x06007679 RID: 30329 RVA: 0x00247B6E File Offset: 0x00245D6E
	// (set) Token: 0x0600767A RID: 30330 RVA: 0x00247B76 File Offset: 0x00245D76
	public int Type { get; set; }

	// Token: 0x0600767B RID: 30331 RVA: 0x00247B7F File Offset: 0x00245D7F
	public ActivityLogReportInfo(int id, int type)
	{
		this.Id = id;
		this.Type = type;
	}
}

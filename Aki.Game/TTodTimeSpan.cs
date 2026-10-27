using System;

// Token: 0x02002BAE RID: 11182
public class TTodTimeSpan
{
	// Token: 0x17001F48 RID: 8008
	// (get) Token: 0x060172CC RID: 94924 RVA: 0x005DFC8D File Offset: 0x005DDE8D
	// (set) Token: 0x060172CD RID: 94925 RVA: 0x005DFC95 File Offset: 0x005DDE95
	public int StartTime { get; set; }

	// Token: 0x17001F49 RID: 8009
	// (get) Token: 0x060172CE RID: 94926 RVA: 0x005DFC9E File Offset: 0x005DDE9E
	// (set) Token: 0x060172CF RID: 94927 RVA: 0x005DFCA6 File Offset: 0x005DDEA6
	public int EndTime { get; set; }

	// Token: 0x060172D0 RID: 94928 RVA: 0x005DFCAF File Offset: 0x005DDEAF
	public TTodTimeSpan(int startTime, int endTime)
	{
		this.StartTime = startTime;
		this.EndTime = endTime;
	}
}

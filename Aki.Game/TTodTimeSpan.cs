using System;

// Token: 0x0200212A RID: 8490
public class TTodTimeSpan
{
	// Token: 0x17001FA0 RID: 8096
	// (get) Token: 0x06014CFD RID: 85245 RVA: 0x0060C861 File Offset: 0x0060AA61
	// (set) Token: 0x06014CFE RID: 85246 RVA: 0x0060C869 File Offset: 0x0060AA69
	public int StartTime { get; set; }

	// Token: 0x17001FA1 RID: 8097
	// (get) Token: 0x06014CFF RID: 85247 RVA: 0x0060C872 File Offset: 0x0060AA72
	// (set) Token: 0x06014D00 RID: 85248 RVA: 0x0060C87A File Offset: 0x0060AA7A
	public int EndTime { get; set; }

	// Token: 0x06014D01 RID: 85249 RVA: 0x0060C883 File Offset: 0x0060AA83
	public TTodTimeSpan(int startTime, int endTime)
	{
		this.StartTime = startTime;
		this.EndTime = endTime;
	}
}

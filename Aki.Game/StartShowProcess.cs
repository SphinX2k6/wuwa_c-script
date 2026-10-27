using System;

// Token: 0x02001D98 RID: 7576
public class StartShowProcess : PendingProcess
{
	// Token: 0x0600E60F RID: 58895 RVA: 0x0036374B File Offset: 0x0036194B
	public StartShowProcess(double endTime) : base(EProcessType.StartShow)
	{
	}

	// Token: 0x04006A71 RID: 27249
	public readonly double EndTime = endTime;
}

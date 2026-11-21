using System;

// Token: 0x0200125A RID: 4698
public class StartShowProcess : PendingProcess
{
	// Token: 0x0600BA2D RID: 47661 RVA: 0x0036F3AB File Offset: 0x0036D5AB
	public StartShowProcess(double endTime) : base(EProcessType.StartShow)
	{
	}

	// Token: 0x04006B52 RID: 27474
	public readonly double EndTime = endTime;
}

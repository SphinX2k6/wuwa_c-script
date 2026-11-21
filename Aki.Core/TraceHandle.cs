using System;

// Token: 0x02000106 RID: 262
public class TraceHandle
{
	// Token: 0x06000A20 RID: 2592 RVA: 0x00032DD1 File Offset: 0x00030FD1
	public TraceHandle(int frame = 0, int index = 0)
	{
		this.Frame = frame;
		this.Index = index;
	}

	// Token: 0x04000696 RID: 1686
	public int Frame;

	// Token: 0x04000697 RID: 1687
	public int Index;
}

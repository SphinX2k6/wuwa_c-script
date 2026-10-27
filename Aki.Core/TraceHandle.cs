using System;

// Token: 0x02000106 RID: 262
public class TraceHandle
{
	// Token: 0x060009CF RID: 2511 RVA: 0x00032475 File Offset: 0x00030675
	public TraceHandle(int frame = 0, int index = 0)
	{
		this.Frame = frame;
		this.Index = index;
	}

	// Token: 0x0400068B RID: 1675
	public int Frame;

	// Token: 0x0400068C RID: 1676
	public int Index;
}

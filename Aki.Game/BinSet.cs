using System;
using System.Runtime.CompilerServices;

// Token: 0x020021FC RID: 8700
public class BinSet
{
	// Token: 0x04008093 RID: 32915
	public int BinNum;

	// Token: 0x04008094 RID: 32916
	public double MinX;

	// Token: 0x04008095 RID: 32917
	public double MaxX;

	// Token: 0x04008096 RID: 32918
	public double MinY;

	// Token: 0x04008097 RID: 32919
	public double MaxY;

	// Token: 0x04008098 RID: 32920
	public double DeltaY;

	// Token: 0x04008099 RID: 32921
	public double InvDeltaY;

	// Token: 0x0400809A RID: 32922
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Bin[] Bins;
}

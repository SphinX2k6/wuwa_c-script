using System;
using System.Runtime.CompilerServices;

// Token: 0x020016E0 RID: 5856
public class BinSet
{
	// Token: 0x040081D1 RID: 33233
	public int BinNum;

	// Token: 0x040081D2 RID: 33234
	public double MinX;

	// Token: 0x040081D3 RID: 33235
	public double MaxX;

	// Token: 0x040081D4 RID: 33236
	public double MinY;

	// Token: 0x040081D5 RID: 33237
	public double MaxY;

	// Token: 0x040081D6 RID: 33238
	public double DeltaY;

	// Token: 0x040081D7 RID: 33239
	public double InvDeltaY;

	// Token: 0x040081D8 RID: 33240
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Bin[] Bins;
}

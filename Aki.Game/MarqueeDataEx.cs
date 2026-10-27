using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021FE RID: 8702
public class MarqueeDataEx
{
	// Token: 0x0400809D RID: 32925
	public int id;

	// Token: 0x0400809E RID: 32926
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MarqueeContent> contents;

	// Token: 0x0400809F RID: 32927
	public int timeInterval;

	// Token: 0x040080A0 RID: 32928
	public int times;

	// Token: 0x040080A1 RID: 32929
	public double startTimeMs;

	// Token: 0x040080A2 RID: 32930
	public double endTimeMs;

	// Token: 0x040080A3 RID: 32931
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> whiteList;

	// Token: 0x040080A4 RID: 32932
	[Nullable(2)]
	public List<int> platform;

	// Token: 0x040080A5 RID: 32933
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> channel;
}

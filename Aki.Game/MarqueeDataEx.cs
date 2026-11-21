using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020016E2 RID: 5858
public class MarqueeDataEx
{
	// Token: 0x040081DB RID: 33243
	public int id;

	// Token: 0x040081DC RID: 33244
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MarqueeContent> contents;

	// Token: 0x040081DD RID: 33245
	public int timeInterval;

	// Token: 0x040081DE RID: 33246
	public int times;

	// Token: 0x040081DF RID: 33247
	public double startTimeMs;

	// Token: 0x040081E0 RID: 33248
	public double endTimeMs;

	// Token: 0x040081E1 RID: 33249
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> whiteList;

	// Token: 0x040081E2 RID: 33250
	[Nullable(2)]
	public List<int> platform;

	// Token: 0x040081E3 RID: 33251
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> channel;
}

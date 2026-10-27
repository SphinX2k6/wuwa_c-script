using System;
using System.Runtime.CompilerServices;

// Token: 0x02002962 RID: 10594
[NullableContext(1)]
[Nullable(0)]
public class SdkProtocolData
{
	// Token: 0x06015E70 RID: 89712 RVA: 0x00586750 File Offset: 0x00584950
	public static SdkProtocolData Create(string url, string title)
	{
		return new SdkProtocolData
		{
			Url = url,
			Title = title
		};
	}

	// Token: 0x0400A2FC RID: 41724
	public string Url = "";

	// Token: 0x0400A2FD RID: 41725
	public string Title = "";
}

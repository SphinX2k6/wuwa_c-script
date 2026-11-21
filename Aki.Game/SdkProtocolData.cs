using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EDD RID: 7901
[NullableContext(1)]
[Nullable(0)]
public class SdkProtocolData
{
	// Token: 0x06013874 RID: 79988 RVA: 0x005B1754 File Offset: 0x005AF954
	public static SdkProtocolData Create(string url, string title)
	{
		return new SdkProtocolData
		{
			Url = url,
			Title = title
		};
	}

	// Token: 0x0400A6E6 RID: 42726
	public string Url = "";

	// Token: 0x0400A6E7 RID: 42727
	public string Title = "";
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002883 RID: 10371
[NullableContext(1)]
[Nullable(0)]
public class SingleText
{
	// Token: 0x17001C7F RID: 7295
	// (get) Token: 0x0601557D RID: 87421 RVA: 0x005633B5 File Offset: 0x005615B5
	// (set) Token: 0x0601557E RID: 87422 RVA: 0x005633BD File Offset: 0x005615BD
	public string TextId { get; set; }

	// Token: 0x17001C80 RID: 7296
	// (get) Token: 0x0601557F RID: 87423 RVA: 0x005633C6 File Offset: 0x005615C6
	// (set) Token: 0x06015580 RID: 87424 RVA: 0x005633CE File Offset: 0x005615CE
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] Params { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}

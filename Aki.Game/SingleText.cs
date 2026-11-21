using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DFE RID: 7678
[NullableContext(1)]
[Nullable(0)]
public class SingleText
{
	// Token: 0x17001CD7 RID: 7383
	// (get) Token: 0x06012F7B RID: 77691 RVA: 0x0058E111 File Offset: 0x0058C311
	// (set) Token: 0x06012F7C RID: 77692 RVA: 0x0058E119 File Offset: 0x0058C319
	public string TextId { get; set; }

	// Token: 0x17001CD8 RID: 7384
	// (get) Token: 0x06012F7D RID: 77693 RVA: 0x0058E122 File Offset: 0x0058C322
	// (set) Token: 0x06012F7E RID: 77694 RVA: 0x0058E12A File Offset: 0x0058C32A
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

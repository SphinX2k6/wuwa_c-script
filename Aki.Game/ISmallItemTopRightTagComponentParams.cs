using System;
using System.Runtime.CompilerServices;

// Token: 0x02001999 RID: 6553
[NullableContext(2)]
public interface ISmallItemTopRightTagComponentParams
{
	// Token: 0x17000FF8 RID: 4088
	// (get) Token: 0x0600BF61 RID: 48993
	// (set) Token: 0x0600BF62 RID: 48994
	string TopRightTextBgColor { get; set; }

	// Token: 0x17000FF9 RID: 4089
	// (get) Token: 0x0600BF63 RID: 48995
	// (set) Token: 0x0600BF64 RID: 48996
	string TopRightTextColor { get; set; }

	// Token: 0x17000FFA RID: 4090
	// (get) Token: 0x0600BF65 RID: 48997
	// (set) Token: 0x0600BF66 RID: 48998
	string TopRightTextId { get; set; }

	// Token: 0x17000FFB RID: 4091
	// (get) Token: 0x0600BF67 RID: 48999
	// (set) Token: 0x0600BF68 RID: 49000
	string TopRightText { get; set; }

	// Token: 0x17000FFC RID: 4092
	// (get) Token: 0x0600BF69 RID: 49001
	// (set) Token: 0x0600BF6A RID: 49002
	[Nullable(new byte[]
	{
		2,
		1
	})]
	object[] TopRightTextParameter { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}

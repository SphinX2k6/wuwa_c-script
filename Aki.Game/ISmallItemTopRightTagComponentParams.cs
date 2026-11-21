using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E56 RID: 3670
[NullableContext(2)]
public interface ISmallItemTopRightTagComponentParams
{
	// Token: 0x1700101C RID: 4124
	// (get) Token: 0x06009369 RID: 37737
	// (set) Token: 0x0600936A RID: 37738
	string TopRightTextBgColor { get; set; }

	// Token: 0x1700101D RID: 4125
	// (get) Token: 0x0600936B RID: 37739
	// (set) Token: 0x0600936C RID: 37740
	string TopRightTextColor { get; set; }

	// Token: 0x1700101E RID: 4126
	// (get) Token: 0x0600936D RID: 37741
	// (set) Token: 0x0600936E RID: 37742
	string TopRightTextId { get; set; }

	// Token: 0x1700101F RID: 4127
	// (get) Token: 0x0600936F RID: 37743
	// (set) Token: 0x06009370 RID: 37744
	string TopRightText { get; set; }

	// Token: 0x17001020 RID: 4128
	// (get) Token: 0x06009371 RID: 37745
	// (set) Token: 0x06009372 RID: 37746
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

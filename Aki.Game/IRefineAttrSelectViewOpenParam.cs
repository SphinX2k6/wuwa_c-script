using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BE3 RID: 3043
[NullableContext(2)]
public interface IRefineAttrSelectViewOpenParam
{
	// Token: 0x17000E4B RID: 3659
	// (get) Token: 0x06007F3F RID: 32575
	// (set) Token: 0x06007F40 RID: 32576
	int IncId { get; set; }

	// Token: 0x17000E4C RID: 3660
	// (get) Token: 0x06007F41 RID: 32577
	// (set) Token: 0x06007F42 RID: 32578
	bool DataConfirmed { get; set; }

	// Token: 0x17000E4D RID: 3661
	// (get) Token: 0x06007F43 RID: 32579
	// (set) Token: 0x06007F44 RID: 32580
	IRefineAttrItemData SelectAttribute { get; set; }

	// Token: 0x17000E4E RID: 3662
	// (get) Token: 0x06007F45 RID: 32581
	// (set) Token: 0x06007F46 RID: 32582
	Action<IRefineAttrItemData> Callback { get; set; }

	// Token: 0x17000E4F RID: 3663
	// (get) Token: 0x06007F47 RID: 32583
	// (set) Token: 0x06007F48 RID: 32584
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Func<int[]> GetSelectedPropItemIdList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}

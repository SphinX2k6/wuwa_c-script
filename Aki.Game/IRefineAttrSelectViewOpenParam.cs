using System;
using System.Runtime.CompilerServices;

// Token: 0x0200172B RID: 5931
[NullableContext(2)]
public interface IRefineAttrSelectViewOpenParam
{
	// Token: 0x17000E2A RID: 3626
	// (get) Token: 0x0600AB5D RID: 43869
	// (set) Token: 0x0600AB5E RID: 43870
	int IncId { get; set; }

	// Token: 0x17000E2B RID: 3627
	// (get) Token: 0x0600AB5F RID: 43871
	// (set) Token: 0x0600AB60 RID: 43872
	bool DataConfirmed { get; set; }

	// Token: 0x17000E2C RID: 3628
	// (get) Token: 0x0600AB61 RID: 43873
	// (set) Token: 0x0600AB62 RID: 43874
	IRefineAttrItemData SelectAttribute { get; set; }

	// Token: 0x17000E2D RID: 3629
	// (get) Token: 0x0600AB63 RID: 43875
	// (set) Token: 0x0600AB64 RID: 43876
	Action<IRefineAttrItemData> Callback { get; set; }

	// Token: 0x17000E2E RID: 3630
	// (get) Token: 0x0600AB65 RID: 43877
	// (set) Token: 0x0600AB66 RID: 43878
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

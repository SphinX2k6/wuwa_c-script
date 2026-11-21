using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D0A RID: 3338
[NullableContext(2)]
[Nullable(0)]
public class PhantomFilterViewData<T> : FilterViewData
{
	// Token: 0x06008A3F RID: 35391 RVA: 0x0029DED9 File Offset: 0x0029C0D9
	public PhantomFilterViewData(int uniqueId, EFilterSortGroupId groupId, Action confirmFunction = null, [Nullable(1)] Func<List<T>> getFilteredDataListFunc = null, Action onFilterViewClose = null) : base(uniqueId, confirmFunction)
	{
		this.GroupId = groupId;
		this.GetFilteredDataListFunc = getFilteredDataListFunc;
		this.OnFilterViewClose = onFilterViewClose;
	}

	// Token: 0x04005317 RID: 21271
	[Nullable(1)]
	public Func<List<T>> GetFilteredDataListFunc;

	// Token: 0x04005318 RID: 21272
	public EFilterSortGroupId GroupId;

	// Token: 0x04005319 RID: 21273
	public Action OnFilterViewClose;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001851 RID: 6225
[NullableContext(2)]
[Nullable(0)]
public class PhantomFilterViewData<T> : FilterViewData
{
	// Token: 0x0600B656 RID: 46678 RVA: 0x002937C9 File Offset: 0x002919C9
	public PhantomFilterViewData(int uniqueId, EFilterSortGroupId groupId, Action confirmFunction = null, [Nullable(1)] Func<List<T>> getFilteredDataListFunc = null, Action onFilterViewClose = null) : base(uniqueId, confirmFunction)
	{
		this.GroupId = groupId;
		this.GetFilteredDataListFunc = getFilteredDataListFunc;
		this.OnFilterViewClose = onFilterViewClose;
	}

	// Token: 0x0400526C RID: 21100
	[Nullable(1)]
	public Func<List<T>> GetFilteredDataListFunc;

	// Token: 0x0400526D RID: 21101
	public EFilterSortGroupId GroupId;

	// Token: 0x0400526E RID: 21102
	public Action OnFilterViewClose;
}

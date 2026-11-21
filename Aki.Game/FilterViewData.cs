using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D09 RID: 3337
[NullableContext(2)]
[Nullable(0)]
public class FilterViewData
{
	// Token: 0x06008A3E RID: 35390 RVA: 0x0029DEC3 File Offset: 0x0029C0C3
	public FilterViewData(int uniqueId, Action confirmFunction = null)
	{
		this.UniqueId = uniqueId;
		this.ConfirmFunction = confirmFunction;
	}

	// Token: 0x04005315 RID: 21269
	public int UniqueId;

	// Token: 0x04005316 RID: 21270
	public Action ConfirmFunction;
}

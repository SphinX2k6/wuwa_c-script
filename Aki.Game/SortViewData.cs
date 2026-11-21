using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D5E RID: 3422
[NullableContext(1)]
[Nullable(0)]
public class SortViewData
{
	// Token: 0x06008C94 RID: 35988 RVA: 0x002A9029 File Offset: 0x002A7229
	public SortViewData(int uniqueId, Action confirmFunction)
	{
		this.UniqueId = uniqueId;
		this.ConfirmFunction = confirmFunction;
	}

	// Token: 0x04005458 RID: 21592
	public int UniqueId;

	// Token: 0x04005459 RID: 21593
	public Action ConfirmFunction;
}

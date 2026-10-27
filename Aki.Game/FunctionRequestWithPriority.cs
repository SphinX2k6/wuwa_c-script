using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200300B RID: 12299
[NullableContext(1)]
[Nullable(0)]
public class FunctionRequestWithPriority<[Nullable(2)] T> : IFunctionRequestHandle<FunctionRequestWithPriority<T>>
{
	// Token: 0x0601A0F2 RID: 106738 RVA: 0x006D4E28 File Offset: 0x006D3028
	public bool CompareRequest(FunctionRequestWithPriority<T> request)
	{
		return Comparer<T>.Default.Compare(this.Priority, request.Priority) > 0;
	}

	// Token: 0x0400C57C RID: 50556
	public string ModuleName = "";

	// Token: 0x0400C57D RID: 50557
	[Nullable(2)]
	public T Priority;
}

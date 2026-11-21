using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002561 RID: 9569
[NullableContext(1)]
[Nullable(0)]
public class FunctionRequestWithPriority<[Nullable(2)] T> : IFunctionRequestHandle<FunctionRequestWithPriority<T>>
{
	// Token: 0x06017A3A RID: 96826 RVA: 0x006FCD2F File Offset: 0x006FAF2F
	public bool CompareRequest(FunctionRequestWithPriority<T> request)
	{
		return Comparer<T>.Default.Compare(this.Priority, request.Priority) > 0;
	}

	// Token: 0x0400C949 RID: 51529
	public string ModuleName = "";

	// Token: 0x0400C94A RID: 51530
	[Nullable(2)]
	public T Priority;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002560 RID: 9568
[NullableContext(1)]
public interface IFunctionRequestHandle<[Nullable(0)] T> where T : IFunctionRequestHandle<T>
{
	// Token: 0x06017A39 RID: 96825
	bool CompareRequest(T request);
}

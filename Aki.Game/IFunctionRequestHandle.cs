using System;
using System.Runtime.CompilerServices;

// Token: 0x0200300A RID: 12298
[NullableContext(1)]
public interface IFunctionRequestHandle<[Nullable(0)] T> where T : IFunctionRequestHandle<T>
{
	// Token: 0x0601A0F1 RID: 106737
	bool CompareRequest(T request);
}

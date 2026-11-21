using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009CC RID: 2508
	public interface IEnumerable<[Nullable(2)] out T> : IEnumerable
	{
		// Token: 0x0600932F RID: 37679
		[NullableContext(1)]
		[DynamicDependency("InternalArray__IEnumerable_GetEnumerator``1 ", typeof(Array))]
		IEnumerator<T> GetEnumerator();
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D2 RID: 2514
	public interface IReadOnlyCollection<[Nullable(2)] out T> : IEnumerable<!0>, IEnumerable
	{
		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x0600933A RID: 37690
		int Count { [DynamicDependency("InternalArray__IReadOnlyCollection_get_Count", typeof(Array))] get; }
	}
}

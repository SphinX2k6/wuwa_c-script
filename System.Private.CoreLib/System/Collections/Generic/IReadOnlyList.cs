using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D4 RID: 2516
	[NullableContext(1)]
	public interface IReadOnlyList<[Nullable(2)] out T> : IReadOnlyCollection<T>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x17001416 RID: 5142
		T this[int index]
		{
			[DynamicDependency("InternalArray__IReadOnlyList_get_Item``1", typeof(Array))]
			get;
		}
	}
}

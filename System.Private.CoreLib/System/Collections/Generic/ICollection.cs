using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009C5 RID: 2501
	[NullableContext(1)]
	public interface ICollection<[Nullable(2)] T> : IEnumerable<!0>, IEnumerable
	{
		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06009317 RID: 37655
		int Count { [DynamicDependency("InternalArray__ICollection_get_Count", typeof(Array))] get; }

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06009318 RID: 37656
		bool IsReadOnly { [DynamicDependency("InternalArray__ICollection_get_IsReadOnly", typeof(Array))] get; }

		// Token: 0x06009319 RID: 37657
		[DynamicDependency("InternalArray__ICollection_Add``1", typeof(Array))]
		void Add(T item);

		// Token: 0x0600931A RID: 37658
		[DynamicDependency("InternalArray__ICollection_Clear", typeof(Array))]
		void Clear();

		// Token: 0x0600931B RID: 37659
		[DynamicDependency("InternalArray__ICollection_Contains``1", typeof(Array))]
		bool Contains(T item);

		// Token: 0x0600931C RID: 37660
		[DynamicDependency("InternalArray__ICollection_CopyTo``1", typeof(Array))]
		void CopyTo(T[] array, int arrayIndex);

		// Token: 0x0600931D RID: 37661
		[DynamicDependency("InternalArray__ICollection_Remove``1", typeof(Array))]
		bool Remove(T item);
	}
}

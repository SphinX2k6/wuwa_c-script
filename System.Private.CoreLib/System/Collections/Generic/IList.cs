using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D0 RID: 2512
	[NullableContext(1)]
	public interface IList<[Nullable(2)] T> : ICollection<!0>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x17001411 RID: 5137
		T this[int index]
		{
			[DynamicDependency("InternalArray__get_Item``1", typeof(Array))]
			get;
			[DynamicDependency("InternalArray__set_Item``1", typeof(Array))]
			set;
		}

		// Token: 0x06009337 RID: 37687
		[DynamicDependency("InternalArray__IndexOf``1", typeof(Array))]
		int IndexOf(T item);

		// Token: 0x06009338 RID: 37688
		[DynamicDependency("InternalArray__Insert``1", typeof(Array))]
		void Insert(int index, T item);

		// Token: 0x06009339 RID: 37689
		[DynamicDependency("InternalArray__RemoveAt", typeof(Array))]
		void RemoveAt(int index);
	}
}

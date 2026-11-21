using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200097E RID: 2430
	[NullableContext(1)]
	public interface IStructuralComparable
	{
		// Token: 0x0600909E RID: 37022
		int CompareTo([Nullable(2)] object other, IComparer comparer);
	}
}

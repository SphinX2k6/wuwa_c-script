using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200097F RID: 2431
	[NullableContext(1)]
	public interface IStructuralEquatable
	{
		// Token: 0x0600909F RID: 37023
		bool Equals([Nullable(2)] object other, IEqualityComparer comparer);

		// Token: 0x060090A0 RID: 37024
		int GetHashCode(IEqualityComparer comparer);
	}
}

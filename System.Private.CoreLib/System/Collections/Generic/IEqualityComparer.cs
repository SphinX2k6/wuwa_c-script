using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009CE RID: 2510
	[NullableContext(2)]
	public interface IEqualityComparer<in T>
	{
		// Token: 0x06009331 RID: 37681
		bool Equals(T x, T y);

		// Token: 0x06009332 RID: 37682
		[NullableContext(1)]
		int GetHashCode([DisallowNull] T obj);
	}
}

using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009C2 RID: 2498
	[NullableContext(1)]
	public interface IAlternateEqualityComparer<[Nullable(2)] in TAlternate, [Nullable(2)] T>
	{
		// Token: 0x06009311 RID: 37649
		bool Equals(TAlternate alternate, T other);

		// Token: 0x06009312 RID: 37650
		int GetHashCode(TAlternate alternate);

		// Token: 0x06009313 RID: 37651
		T Create(TAlternate alternate);
	}
}

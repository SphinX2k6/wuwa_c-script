using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200097B RID: 2427
	[NullableContext(1)]
	public interface IEqualityComparer
	{
		// Token: 0x06009090 RID: 37008
		[NullableContext(2)]
		bool Equals(object x, object y);

		// Token: 0x06009091 RID: 37009
		int GetHashCode(object obj);
	}
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001F0 RID: 496
	internal interface IValueTupleInternal : ITuple
	{
		// Token: 0x060027B7 RID: 10167
		int GetHashCode(IEqualityComparer comparer);

		// Token: 0x060027B8 RID: 10168
		string ToStringEnd();
	}
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001D5 RID: 469
	internal interface ITupleInternal : ITuple
	{
		// Token: 0x060023A5 RID: 9125
		string ToString(StringBuilder sb);

		// Token: 0x060023A6 RID: 9126
		int GetHashCode(IEqualityComparer comparer);
	}
}

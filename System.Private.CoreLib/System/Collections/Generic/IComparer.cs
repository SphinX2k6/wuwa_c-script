using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009C7 RID: 2503
	[NullableContext(2)]
	public interface IComparer<in T>
	{
		// Token: 0x06009320 RID: 37664
		int Compare(T x, T y);
	}
}

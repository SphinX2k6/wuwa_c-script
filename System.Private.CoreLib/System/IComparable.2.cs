using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200013D RID: 317
	[NullableContext(2)]
	public interface IComparable<in T>
	{
		// Token: 0x060013BE RID: 5054
		int CompareTo(T other);
	}
}

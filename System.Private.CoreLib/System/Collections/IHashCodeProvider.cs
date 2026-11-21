using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200097C RID: 2428
	[NullableContext(1)]
	[Obsolete("IHashCodeProvider has been deprecated. Use IEqualityComparer instead.")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	public interface IHashCodeProvider
	{
		// Token: 0x06009092 RID: 37010
		int GetHashCode(object obj);
	}
}

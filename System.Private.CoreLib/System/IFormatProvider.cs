using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000142 RID: 322
	[NullableContext(2)]
	public interface IFormatProvider
	{
		// Token: 0x060013D3 RID: 5075
		object GetFormat(Type formatType);
	}
}

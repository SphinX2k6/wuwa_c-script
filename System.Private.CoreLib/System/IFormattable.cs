using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000143 RID: 323
	[NullableContext(2)]
	public interface IFormattable
	{
		// Token: 0x060013D4 RID: 5076
		[return: Nullable(1)]
		string ToString(string format, IFormatProvider formatProvider);
	}
}

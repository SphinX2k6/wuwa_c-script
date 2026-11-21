using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200013F RID: 319
	[NullableContext(2)]
	public interface ICustomFormatter
	{
		// Token: 0x060013D0 RID: 5072
		[return: Nullable(1)]
		string Format(string format, object arg, IFormatProvider formatProvider);
	}
}

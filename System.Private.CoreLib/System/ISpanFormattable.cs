using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000157 RID: 343
	public interface ISpanFormattable : IFormattable
	{
		// Token: 0x06001701 RID: 5889
		bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider);
	}
}

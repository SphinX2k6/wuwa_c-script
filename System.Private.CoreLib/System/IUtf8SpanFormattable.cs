using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000159 RID: 345
	public interface IUtf8SpanFormattable
	{
		// Token: 0x06001708 RID: 5896
		bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider);
	}
}

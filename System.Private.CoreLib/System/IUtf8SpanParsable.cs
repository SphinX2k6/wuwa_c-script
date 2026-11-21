using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200015A RID: 346
	public interface IUtf8SpanParsable<TSelf> where TSelf : IUtf8SpanParsable<TSelf>
	{
		// Token: 0x06001709 RID: 5897
		[return: Nullable(1)]
		public abstract static TSelf Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider);

		// Token: 0x0600170A RID: 5898
		public abstract static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);
	}
}

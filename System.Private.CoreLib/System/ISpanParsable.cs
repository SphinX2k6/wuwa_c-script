using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000208 RID: 520
	public interface ISpanParsable<TSelf> : IParsable<TSelf> where TSelf : ISpanParsable<TSelf>
	{
		// Token: 0x060028B3 RID: 10419
		[return: Nullable(1)]
		public abstract static TSelf Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider);

		// Token: 0x060028B4 RID: 10420
		public abstract static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);
	}
}

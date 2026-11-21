using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000207 RID: 519
	public interface IParsable<TSelf> where TSelf : IParsable<TSelf>
	{
		// Token: 0x060028B1 RID: 10417
		[NullableContext(1)]
		public abstract static TSelf Parse(string s, [Nullable(2)] IFormatProvider provider);

		// Token: 0x060028B2 RID: 10418
		[NullableContext(2)]
		public abstract static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);
	}
}

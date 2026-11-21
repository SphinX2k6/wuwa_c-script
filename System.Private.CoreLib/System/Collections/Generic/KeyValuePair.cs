using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D8 RID: 2520
	public static class KeyValuePair
	{
		// Token: 0x06009357 RID: 37719 RVA: 0x0016F56E File Offset: 0x0016D76E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static KeyValuePair<TKey, TValue> Create<[Nullable(2)] TKey, [Nullable(2)] TValue>(TKey key, TValue value)
		{
			return new KeyValuePair<TKey, TValue>(key, value);
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x0016F578 File Offset: 0x0016D778
		internal unsafe static string PairToString(object key, object value)
		{
			IFormatProvider formatProvider = null;
			IFormatProvider formatProvider2 = formatProvider;
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			IFormatProvider provider = formatProvider2;
			Span<char> initialBuffer = span;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2, formatProvider, span);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<object>(key);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<object>(value);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return string.Create(provider, initialBuffer, ref defaultInterpolatedStringHandler);
		}
	}
}

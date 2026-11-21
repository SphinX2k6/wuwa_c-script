using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Buffers.Text
{
	// Token: 0x020003AF RID: 943
	internal static class ParserHelpers
	{
		// Token: 0x06003D96 RID: 15766 RVA: 0x0005229A File Offset: 0x0005049A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsDigit(int i)
		{
			return i - 48 <= 9;
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x000CD9D0 File Offset: 0x000CBBD0
		public static bool TryParseThrowFormatException(out int bytesConsumed)
		{
			bytesConsumed = 0;
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			return false;
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x000CD9DB File Offset: 0x000CBBDB
		public static bool TryParseThrowFormatException<T>(out T value, out int bytesConsumed) where T : struct
		{
			value = default(T);
			return ParserHelpers.TryParseThrowFormatException(out bytesConsumed);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x000CD9EA File Offset: 0x000CBBEA
		[DoesNotReturn]
		[StackTraceHidden]
		public static bool TryParseThrowFormatException<T>(ReadOnlySpan<byte> _, out T value, out int bytesConsumed) where T : struct
		{
			Unsafe.SkipInit<T>(out value);
			Unsafe.SkipInit<int>(out bytesConsumed);
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			return false;
		}
	}
}

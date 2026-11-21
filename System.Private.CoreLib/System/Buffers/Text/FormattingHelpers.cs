using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers.Text
{
	// Token: 0x020003AD RID: 941
	internal static class FormattingHelpers
	{
		// Token: 0x06003D7A RID: 15738 RVA: 0x000CD218 File Offset: 0x000CB418
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int CountDigits(ulong value)
		{
			uint num = (uint)(*Unsafe.Add<byte>(MemoryMarshal.GetReference<byte>(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.2805A8107EE40ABA4832FDC9259087C5CD75B60A8435CC5D1E5904674E1B9054), 64)), BitOperations.Log2(value)));
			ulong num2 = *Unsafe.Add<ulong>(MemoryMarshal.GetReference<ulong>(RuntimeHelpers.CreateSpan<ulong>(fieldof(<PrivateImplementationDetails>.4BAA1F30A81D087D4A1F3FFD0563EF5C9FCACD16C3D3C8FCA617EE9C3233E9568).FieldHandle)), (UIntPtr)num);
			bool flag = value < num2;
			return (int)(num - (uint)(*Unsafe.As<bool, byte>(ref flag)));
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x000CD26C File Offset: 0x000CB46C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int CountDigits(uint value)
		{
			long num = *Unsafe.Add<long>(MemoryMarshal.GetReference<long>(RuntimeHelpers.CreateSpan<long>(fieldof(<PrivateImplementationDetails>.40BC6C50487BFA78776C051EF7555931E4F15E5CEE9481EB280B1C2630B906B48).FieldHandle)), (UIntPtr)uint.Log2(value));
			return (int)((ulong)value + (ulong)num >> 32);
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x000CD29E File Offset: 0x000CB49E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountHexDigits(ulong value)
		{
			return (BitOperations.Log2(value) >> 2) + 1;
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x000CD2AC File Offset: 0x000CB4AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountDecimalTrailingZeros(uint value, out uint valueWithoutTrailingZeros)
		{
			int num = 0;
			if (value != 0U)
			{
				for (;;)
				{
					uint num2 = value / 10U;
					if (value != num2 * 10U)
					{
						break;
					}
					value = num2;
					num++;
				}
			}
			valueWithoutTrailingZeros = value;
			return num;
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x000CD2D8 File Offset: 0x000CB4D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountDigits(UInt128 value)
		{
			ulong upper = value.Upper;
			if (upper == 0UL)
			{
				return FormattingHelpers.CountDigits(value.Lower);
			}
			int num = 20;
			if (upper > 5UL)
			{
				value /= new UInt128(5UL, 7766279631452241920UL);
				num += FormattingHelpers.CountDigits(value.Lower);
			}
			else if (upper == 5UL && value.Lower >= 7766279631452241920UL)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x000CD34A File Offset: 0x000CB54A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CountHexDigits(UInt128 value)
		{
			return ((int)UInt128.Log2(value) >> 2) + 1;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x000CD35C File Offset: 0x000CB55C
		public unsafe static bool TryFormat<T>(T value, Span<byte> utf8Destination, out int bytesWritten, StandardFormat format) where T : IUtf8SpanFormattable
		{
			Span<char> span = default(Span<char>);
			if (!format.IsDefault)
			{
				Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)6], 3);
				span = format.Format(destination);
			}
			ref T ptr = ref value;
			if (default(T) == null)
			{
				T t = value;
				ptr = ref t;
			}
			return ptr.TryFormat(utf8Destination, out bytesWritten, span, CultureInfo.InvariantCulture);
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x000CD3C0 File Offset: 0x000CB5C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static char GetSymbolOrDefault(in StandardFormat format, char defaultSymbol)
		{
			char c = format.Symbol;
			if (c == '\0' && format.Precision == 0)
			{
				c = defaultSymbol;
			}
			return c;
		}
	}
}

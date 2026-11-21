using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Unicode;

namespace System.Numerics
{
	// Token: 0x020002B3 RID: 691
	[NullableContext(1)]
	public interface INumberBase<[Nullable(0)] TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : INumberBase<TSelf>
	{
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600333C RID: 13116
		TSelf One { get; }

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x0600333D RID: 13117
		int Radix { get; }

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600333E RID: 13118
		TSelf Zero { get; }

		// Token: 0x0600333F RID: 13119
		public abstract static TSelf Abs(TSelf value);

		// Token: 0x06003340 RID: 13120 RVA: 0x000A3554 File Offset: 0x000A1754
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		public virtual static TSelf CreateChecked<TOther>([Nullable(1)] TOther value)
		{
			TSelf result;
			if (typeof(TOther) == typeof(TSelf))
			{
				result = (TSelf)((object)value);
			}
			else if (!INumberBase<TSelf>.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<TSelf>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000A35B0 File Offset: 0x000A17B0
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		public virtual static TSelf CreateSaturating<TOther>([Nullable(1)] TOther value)
		{
			TSelf result;
			if (typeof(TOther) == typeof(TSelf))
			{
				result = (TSelf)((object)value);
			}
			else if (!INumberBase<TSelf>.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<TSelf>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x000A360C File Offset: 0x000A180C
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		public virtual static TSelf CreateTruncating<TOther>([Nullable(1)] TOther value)
		{
			TSelf result;
			if (typeof(TOther) == typeof(TSelf))
			{
				result = (TSelf)((object)value);
			}
			else if (!INumberBase<TSelf>.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<TSelf>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06003343 RID: 13123
		public abstract static bool IsCanonical(TSelf value);

		// Token: 0x06003344 RID: 13124
		public abstract static bool IsComplexNumber(TSelf value);

		// Token: 0x06003345 RID: 13125
		public abstract static bool IsEvenInteger(TSelf value);

		// Token: 0x06003346 RID: 13126
		public abstract static bool IsFinite(TSelf value);

		// Token: 0x06003347 RID: 13127
		public abstract static bool IsImaginaryNumber(TSelf value);

		// Token: 0x06003348 RID: 13128
		public abstract static bool IsInfinity(TSelf value);

		// Token: 0x06003349 RID: 13129
		public abstract static bool IsInteger(TSelf value);

		// Token: 0x0600334A RID: 13130
		public abstract static bool IsNaN(TSelf value);

		// Token: 0x0600334B RID: 13131
		public abstract static bool IsNegative(TSelf value);

		// Token: 0x0600334C RID: 13132
		public abstract static bool IsNegativeInfinity(TSelf value);

		// Token: 0x0600334D RID: 13133
		public abstract static bool IsNormal(TSelf value);

		// Token: 0x0600334E RID: 13134
		public abstract static bool IsOddInteger(TSelf value);

		// Token: 0x0600334F RID: 13135
		public abstract static bool IsPositive(TSelf value);

		// Token: 0x06003350 RID: 13136
		public abstract static bool IsPositiveInfinity(TSelf value);

		// Token: 0x06003351 RID: 13137
		public abstract static bool IsRealNumber(TSelf value);

		// Token: 0x06003352 RID: 13138
		public abstract static bool IsSubnormal(TSelf value);

		// Token: 0x06003353 RID: 13139
		public abstract static bool IsZero(TSelf value);

		// Token: 0x06003354 RID: 13140
		public abstract static TSelf MaxMagnitude(TSelf x, TSelf y);

		// Token: 0x06003355 RID: 13141
		public abstract static TSelf MaxMagnitudeNumber(TSelf x, TSelf y);

		// Token: 0x06003356 RID: 13142
		public abstract static TSelf MinMagnitude(TSelf x, TSelf y);

		// Token: 0x06003357 RID: 13143
		public abstract static TSelf MinMagnitudeNumber(TSelf x, TSelf y);

		// Token: 0x06003358 RID: 13144 RVA: 0x000A3668 File Offset: 0x000A1868
		public virtual static TSelf MultiplyAddEstimate(TSelf left, TSelf right, TSelf addend)
		{
			return left * right + addend;
		}

		// Token: 0x06003359 RID: 13145
		public abstract static TSelf Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider);

		// Token: 0x0600335A RID: 13146
		[NullableContext(0)]
		[return: Nullable(1)]
		public abstract static TSelf Parse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider);

		// Token: 0x0600335B RID: 13147 RVA: 0x000A3684 File Offset: 0x000A1884
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe virtual static TSelf Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Text.Length);
			char[] array;
			Span<char> span;
			if (maxCharCount <= 256)
			{
				array = null;
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array = ArrayPool<char>.Shared.Rent(maxCharCount);
				span = array;
			}
			int num;
			int length;
			if (Utf8.ToUtf16(utf8Text, span, out num, out length, false, true) != OperationStatus.Done)
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				ThrowHelper.ThrowFormatInvalidString();
			}
			span = span.Slice(0, length);
			TSelf result = INumberBase<TSelf>.Parse(span, style, provider);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x0600335C RID: 13148
		[NullableContext(0)]
		protected abstract static bool TryConvertFromChecked<TOther>([Nullable(1)] TOther value, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);

		// Token: 0x0600335D RID: 13149
		[NullableContext(0)]
		protected abstract static bool TryConvertFromSaturating<TOther>([Nullable(1)] TOther value, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);

		// Token: 0x0600335E RID: 13150
		[NullableContext(0)]
		protected abstract static bool TryConvertFromTruncating<TOther>([Nullable(1)] TOther value, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);

		// Token: 0x0600335F RID: 13151
		[NullableContext(0)]
		protected abstract static bool TryConvertToChecked<TOther>([Nullable(1)] TSelf value, [Nullable(1)] [MaybeNullWhen(false)] out TOther result);

		// Token: 0x06003360 RID: 13152
		[NullableContext(0)]
		protected abstract static bool TryConvertToSaturating<TOther>([Nullable(1)] TSelf value, [Nullable(1)] [MaybeNullWhen(false)] out TOther result);

		// Token: 0x06003361 RID: 13153
		[NullableContext(0)]
		protected abstract static bool TryConvertToTruncating<TOther>([Nullable(1)] TSelf value, [Nullable(1)] [MaybeNullWhen(false)] out TOther result);

		// Token: 0x06003362 RID: 13154
		[NullableContext(2)]
		public abstract static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);

		// Token: 0x06003363 RID: 13155
		[NullableContext(0)]
		public abstract static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result);

		// Token: 0x06003364 RID: 13156 RVA: 0x000A3724 File Offset: 0x000A1924
		[NullableContext(0)]
		public unsafe virtual static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, [Nullable(1)] [MaybeNullWhen(false)] out TSelf result)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Text.Length);
			char[] array;
			Span<char> span;
			if (maxCharCount <= 256)
			{
				array = null;
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array = ArrayPool<char>.Shared.Rent(maxCharCount);
				span = array;
			}
			int num;
			int length;
			if (Utf8.ToUtf16(utf8Text, span, out num, out length, false, true) != OperationStatus.Done)
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				result = default(TSelf);
				return false;
			}
			span = span.Slice(0, length);
			bool result2 = INumberBase<TSelf>.TryParse(span, style, provider, out result);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result2;
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000A37CC File Offset: 0x000A19CC
		unsafe bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Destination.Length);
			char[] array;
			Span<char> span;
			if (maxCharCount <= 256)
			{
				array = null;
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array = ArrayPool<char>.Shared.Rent(maxCharCount);
				span = array;
			}
			int length;
			if (!this.TryFormat(span, out length, format, provider))
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				bytesWritten = 0;
				return false;
			}
			span = span.Slice(0, length);
			int num;
			OperationStatus operationStatus = Utf8.FromUtf16(span, utf8Destination, out num, out bytesWritten, false, true);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			if (operationStatus == OperationStatus.Done)
			{
				return true;
			}
			if (operationStatus != OperationStatus.DestinationTooSmall)
			{
				ThrowHelper.ThrowInvalidOperationException_InvalidUtf8();
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000A3880 File Offset: 0x000A1A80
		private unsafe static TSelf Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Text.Length);
			char[] array;
			Span<char> span;
			if (maxCharCount <= 256)
			{
				array = null;
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array = ArrayPool<char>.Shared.Rent(maxCharCount);
				span = array;
			}
			int num;
			int length;
			if (Utf8.ToUtf16(utf8Text, span, out num, out length, false, true) != OperationStatus.Done)
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				ThrowHelper.ThrowFormatInvalidString();
			}
			span = span.Slice(0, length);
			TSelf result = ISpanParsable<TSelf>.Parse(span, provider);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000A3920 File Offset: 0x000A1B20
		private unsafe static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, [MaybeNullWhen(false)] out TSelf result)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(utf8Text.Length);
			char[] array;
			Span<char> span;
			if (maxCharCount <= 256)
			{
				array = null;
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array = ArrayPool<char>.Shared.Rent(maxCharCount);
				span = array;
			}
			int num;
			int length;
			if (Utf8.ToUtf16(utf8Text, span, out num, out length, false, true) != OperationStatus.Done)
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				result = default(TSelf);
				return false;
			}
			span = span.Slice(0, length);
			bool result2 = ISpanParsable<TSelf>.TryParse(span, provider, out result);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result2;
		}
	}
}

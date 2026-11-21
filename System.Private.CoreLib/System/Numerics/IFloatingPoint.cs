using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A8 RID: 680
	[NullableContext(1)]
	public interface IFloatingPoint<[Nullable(0)] TSelf> : IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, ISignedNumber<TSelf> where TSelf : IFloatingPoint<TSelf>
	{
		// Token: 0x060032F0 RID: 13040 RVA: 0x000A303E File Offset: 0x000A123E
		public virtual static TSelf Ceiling(TSelf x)
		{
			return IFloatingPoint<TSelf>.Round(x, 0, MidpointRounding.ToPositiveInfinity);
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x000A304E File Offset: 0x000A124E
		public virtual static TInteger ConvertToInteger<[Nullable(0)] TInteger>(TSelf value)
		{
			return INumberBase<TInteger>.CreateSaturating<TSelf>(value);
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000A305C File Offset: 0x000A125C
		public virtual static TInteger ConvertToIntegerNative<[Nullable(0)] TInteger>(TSelf value)
		{
			return IFloatingPoint<TSelf>.ConvertToInteger<TInteger>(value);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x000A306A File Offset: 0x000A126A
		public virtual static TSelf Floor(TSelf x)
		{
			return IFloatingPoint<TSelf>.Round(x, 0, MidpointRounding.ToNegativeInfinity);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000A307A File Offset: 0x000A127A
		public virtual static TSelf Round(TSelf x)
		{
			return IFloatingPoint<TSelf>.Round(x, 0, MidpointRounding.ToEven);
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000A308A File Offset: 0x000A128A
		public virtual static TSelf Round(TSelf x, int digits)
		{
			return IFloatingPoint<TSelf>.Round(x, digits, MidpointRounding.ToEven);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x000A309A File Offset: 0x000A129A
		public virtual static TSelf Round(TSelf x, MidpointRounding mode)
		{
			return IFloatingPoint<TSelf>.Round(x, 0, mode);
		}

		// Token: 0x060032F7 RID: 13047
		public abstract static TSelf Round(TSelf x, int digits, MidpointRounding mode);

		// Token: 0x060032F8 RID: 13048 RVA: 0x000A30AA File Offset: 0x000A12AA
		public virtual static TSelf Truncate(TSelf x)
		{
			return IFloatingPoint<TSelf>.Round(x, 0, MidpointRounding.ToZero);
		}

		// Token: 0x060032F9 RID: 13049
		int GetExponentByteCount();

		// Token: 0x060032FA RID: 13050
		int GetExponentShortestBitLength();

		// Token: 0x060032FB RID: 13051
		int GetSignificandBitLength();

		// Token: 0x060032FC RID: 13052
		int GetSignificandByteCount();

		// Token: 0x060032FD RID: 13053
		[NullableContext(0)]
		bool TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten);

		// Token: 0x060032FE RID: 13054
		[NullableContext(0)]
		bool TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten);

		// Token: 0x060032FF RID: 13055
		[NullableContext(0)]
		bool TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten);

		// Token: 0x06003300 RID: 13056
		[NullableContext(0)]
		bool TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten);

		// Token: 0x06003301 RID: 13057 RVA: 0x000A30BC File Offset: 0x000A12BC
		int WriteExponentBigEndian(byte[] destination)
		{
			int result;
			if (!this.TryWriteExponentBigEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000A30E0 File Offset: 0x000A12E0
		int WriteExponentBigEndian(byte[] destination, int startIndex)
		{
			int result;
			if (!this.TryWriteExponentBigEndian(destination.AsSpan(startIndex), out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000A3104 File Offset: 0x000A1304
		[NullableContext(0)]
		int WriteExponentBigEndian(Span<byte> destination)
		{
			int result;
			if (!this.TryWriteExponentBigEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000A3124 File Offset: 0x000A1324
		int WriteExponentLittleEndian(byte[] destination)
		{
			int result;
			if (!this.TryWriteExponentLittleEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000A3148 File Offset: 0x000A1348
		int WriteExponentLittleEndian(byte[] destination, int startIndex)
		{
			int result;
			if (!this.TryWriteExponentLittleEndian(destination.AsSpan(startIndex), out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000A316C File Offset: 0x000A136C
		[NullableContext(0)]
		int WriteExponentLittleEndian(Span<byte> destination)
		{
			int result;
			if (!this.TryWriteExponentLittleEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x000A318C File Offset: 0x000A138C
		int WriteSignificandBigEndian(byte[] destination)
		{
			int result;
			if (!this.TryWriteSignificandBigEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000A31B0 File Offset: 0x000A13B0
		int WriteSignificandBigEndian(byte[] destination, int startIndex)
		{
			int result;
			if (!this.TryWriteSignificandBigEndian(destination.AsSpan(startIndex), out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000A31D4 File Offset: 0x000A13D4
		[NullableContext(0)]
		int WriteSignificandBigEndian(Span<byte> destination)
		{
			int result;
			if (!this.TryWriteSignificandBigEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000A31F4 File Offset: 0x000A13F4
		int WriteSignificandLittleEndian(byte[] destination)
		{
			int result;
			if (!this.TryWriteSignificandLittleEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000A3218 File Offset: 0x000A1418
		int WriteSignificandLittleEndian(byte[] destination, int startIndex)
		{
			int result;
			if (!this.TryWriteSignificandLittleEndian(destination.AsSpan(startIndex), out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000A323C File Offset: 0x000A143C
		[NullableContext(0)]
		int WriteSignificandLittleEndian(Span<byte> destination)
		{
			int result;
			if (!this.TryWriteSignificandLittleEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}
	}
}

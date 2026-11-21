using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000243 RID: 579
	internal static class UnicodeUtility
	{
		// Token: 0x06002C3D RID: 11325 RVA: 0x0008CB1B File Offset: 0x0008AD1B
		public static int GetPlane(uint codePoint)
		{
			return (int)(codePoint >> 16);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0008CB21 File Offset: 0x0008AD21
		public static uint GetScalarFromUtf16SurrogatePair(uint highSurrogateCodePoint, uint lowSurrogateCodePoint)
		{
			return (highSurrogateCodePoint << 10) + lowSurrogateCodePoint - 56613888U;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x0008CB2F File Offset: 0x0008AD2F
		public static int GetUtf16SequenceLength(uint value)
		{
			value -= 65536U;
			value += 33554432U;
			value >>= 24;
			return (int)value;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x0008CB4A File Offset: 0x0008AD4A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetUtf16SurrogatesFromSupplementaryPlaneScalar(uint value, out char highSurrogateCodePoint, out char lowSurrogateCodePoint)
		{
			highSurrogateCodePoint = (char)(value + 56557568U >> 10);
			lowSurrogateCodePoint = (char)((value & 1023U) + 56320U);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x0008CB6C File Offset: 0x0008AD6C
		public static int GetUtf8SequenceLength(uint value)
		{
			int num = (int)(value - 2048U) >> 31;
			value ^= 63488U;
			value -= 63616U;
			value += 67108864U;
			value >>= 24;
			return (int)(value + (uint)(num * 2));
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00020EA1 File Offset: 0x0001F0A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsAsciiCodePoint(uint value)
		{
			return value <= 127U;
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0008CBAA File Offset: 0x0008ADAA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsBmpCodePoint(uint value)
		{
			return value <= 65535U;
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x0008CBB7 File Offset: 0x0008ADB7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsHighSurrogateCodePoint(uint value)
		{
			return UnicodeUtility.IsInRangeInclusive(value, 55296U, 56319U);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x0002104B File Offset: 0x0001F24B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRangeInclusive(uint value, uint lowerBound, uint upperBound)
		{
			return value - lowerBound <= upperBound - lowerBound;
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x0008CBC9 File Offset: 0x0008ADC9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsLowSurrogateCodePoint(uint value)
		{
			return UnicodeUtility.IsInRangeInclusive(value, 56320U, 57343U);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x0008CBDB File Offset: 0x0008ADDB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsSurrogateCodePoint(uint value)
		{
			return UnicodeUtility.IsInRangeInclusive(value, 55296U, 57343U);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x0008CBED File Offset: 0x0008ADED
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsValidCodePoint(uint codePoint)
		{
			return codePoint <= 1114111U;
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x0008CBFA File Offset: 0x0008ADFA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsValidUnicodeScalar(uint value)
		{
			return (value - 1114112U ^ 55296U) >= 4293855232U;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;

namespace System.Globalization
{
	// Token: 0x020002CD RID: 717
	public static class CharUnicodeInfo
	{
		// Token: 0x06003439 RID: 13369 RVA: 0x000A71A2 File Offset: 0x000A53A2
		internal static StrongBidiCategory GetBidiCategory(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return CharUnicodeInfo.GetBidiCategoryNoBoundsChecks((uint)CharUnicodeInfo.GetCodePointFromString(s, index));
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x000A71CC File Offset: 0x000A53CC
		internal static StrongBidiCategory GetBidiCategory(StringBuilder s, int index)
		{
			int num = (int)s[index];
			if (index < s.Length - 1)
			{
				int num2 = num - 55296;
				if (num2 <= 1023)
				{
					int num3 = (int)(s[index + 1] - '\udc00');
					if (num3 <= 1023)
					{
						num = (num2 << 10) + num3 + 65536;
					}
				}
			}
			return CharUnicodeInfo.GetBidiCategoryNoBoundsChecks((uint)num);
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x000A7228 File Offset: 0x000A5428
		private unsafe static StrongBidiCategory GetBidiCategoryNoBoundsChecks(uint codePoint)
		{
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(codePoint);
			return (StrongBidiCategory)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.CategoriesValues), categoryCasingTableOffsetNoBoundsChecks) & 96);
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000A7250 File Offset: 0x000A5450
		public static int GetDecimalDigitValue(char ch)
		{
			return CharUnicodeInfo.GetDecimalDigitValueInternalNoBoundsCheck((uint)ch);
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x000A7258 File Offset: 0x000A5458
		[NullableContext(1)]
		public static int GetDecimalDigitValue(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return CharUnicodeInfo.GetDecimalDigitValueInternalNoBoundsCheck((uint)CharUnicodeInfo.GetCodePointFromString(s, index));
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000A7280 File Offset: 0x000A5480
		private unsafe static int GetDecimalDigitValueInternalNoBoundsCheck(uint codePoint)
		{
			UIntPtr numericGraphemeTableOffsetNoBoundsChecks = CharUnicodeInfo.GetNumericGraphemeTableOffsetNoBoundsChecks(codePoint);
			return (int)(((uint)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.DigitValues), numericGraphemeTableOffsetNoBoundsChecks)) >> 4) - 1U);
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000A72A9 File Offset: 0x000A54A9
		public static int GetDigitValue(char ch)
		{
			return CharUnicodeInfo.GetDigitValueInternalNoBoundsCheck((uint)ch);
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x000A72B1 File Offset: 0x000A54B1
		[NullableContext(1)]
		public static int GetDigitValue(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return CharUnicodeInfo.GetDigitValueInternalNoBoundsCheck((uint)CharUnicodeInfo.GetCodePointFromString(s, index));
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x000A72DC File Offset: 0x000A54DC
		private unsafe static int GetDigitValueInternalNoBoundsCheck(uint codePoint)
		{
			UIntPtr numericGraphemeTableOffsetNoBoundsChecks = CharUnicodeInfo.GetNumericGraphemeTableOffsetNoBoundsChecks(codePoint);
			return (int)((*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.DigitValues), numericGraphemeTableOffsetNoBoundsChecks) & 15) - 1);
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000A7308 File Offset: 0x000A5508
		internal unsafe static GraphemeClusterBreakType GetGraphemeClusterBreakType(Rune rune)
		{
			UIntPtr numericGraphemeTableOffsetNoBoundsChecks = CharUnicodeInfo.GetNumericGraphemeTableOffsetNoBoundsChecks((uint)rune.Value);
			return (GraphemeClusterBreakType)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.GraphemeSegmentationValues), numericGraphemeTableOffsetNoBoundsChecks));
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x000A7334 File Offset: 0x000A5534
		internal unsafe static bool GetIsWhiteSpace(char ch)
		{
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks((uint)ch);
			return (sbyte)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.CategoriesValues), categoryCasingTableOffsetNoBoundsChecks)) < 0;
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x000A735D File Offset: 0x000A555D
		public static double GetNumericValue(char ch)
		{
			return CharUnicodeInfo.GetNumericValueNoBoundsCheck((uint)ch);
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x000A7365 File Offset: 0x000A5565
		internal static double GetNumericValue(int codePoint)
		{
			if (!UnicodeUtility.IsValidCodePoint((uint)codePoint))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.codePoint);
			}
			return CharUnicodeInfo.GetNumericValueNoBoundsCheck((uint)codePoint);
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00021768 File Offset: 0x0001F968
		[NullableContext(1)]
		public static double GetNumericValue(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return CharUnicodeInfo.GetNumericValueInternal(s, index);
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x000A737C File Offset: 0x000A557C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static double GetNumericValueInternal(string s, int index)
		{
			return CharUnicodeInfo.GetNumericValueNoBoundsCheck((uint)CharUnicodeInfo.GetCodePointFromString(s, index));
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x000A738C File Offset: 0x000A558C
		private static double GetNumericValueNoBoundsCheck(uint codePoint)
		{
			UIntPtr numericGraphemeTableOffsetNoBoundsChecks = CharUnicodeInfo.GetNumericGraphemeTableOffsetNoBoundsChecks(codePoint);
			ref byte source = ref Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.NumericValues), numericGraphemeTableOffsetNoBoundsChecks * (UIntPtr)((IntPtr)8));
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return Unsafe.ReadUnaligned<double>(ref source);
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x000A73C0 File Offset: 0x000A55C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToUpper(char codePoint)
		{
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks((uint)codePoint);
			ref short ptr = ref Unsafe.Add<short>(Unsafe.As<byte, short>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.UppercaseValues)), (IntPtr)categoryCasingTableOffsetNoBoundsChecks);
			if (!BitConverter.IsLittleEndian)
			{
			}
			return (char)(ptr + (short)codePoint);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x000A73F8 File Offset: 0x000A55F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ToUpper(uint codePoint)
		{
			if (!UnicodeUtility.IsValidCodePoint(codePoint))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.codePoint);
			}
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(codePoint);
			ref ushort ptr = ref Unsafe.Add<ushort>(Unsafe.As<byte, ushort>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.UppercaseValues)), (IntPtr)categoryCasingTableOffsetNoBoundsChecks);
			if (!BitConverter.IsLittleEndian)
			{
			}
			int num = (int)ptr;
			return (codePoint & 4294901760U) | (uint)((ushort)(num + (int)codePoint));
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x000A7448 File Offset: 0x000A5648
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToLower(char codePoint)
		{
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks((uint)codePoint);
			ref short ptr = ref Unsafe.Add<short>(Unsafe.As<byte, short>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.LowercaseValues)), (IntPtr)categoryCasingTableOffsetNoBoundsChecks);
			if (!BitConverter.IsLittleEndian)
			{
			}
			return (char)(ptr + (short)codePoint);
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x000A7480 File Offset: 0x000A5680
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ToLower(uint codePoint)
		{
			if (!UnicodeUtility.IsValidCodePoint(codePoint))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.codePoint);
			}
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(codePoint);
			ref ushort ptr = ref Unsafe.Add<ushort>(Unsafe.As<byte, ushort>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.LowercaseValues)), (IntPtr)categoryCasingTableOffsetNoBoundsChecks);
			if (!BitConverter.IsLittleEndian)
			{
			}
			int num = (int)ptr;
			return (codePoint & 4294901760U) | (uint)((ushort)(num + (int)codePoint));
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x000A74CF File Offset: 0x000A56CF
		public static UnicodeCategory GetUnicodeCategory(char ch)
		{
			return CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks((uint)ch);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000A74D7 File Offset: 0x000A56D7
		public static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			if (!UnicodeUtility.IsValidCodePoint((uint)codePoint))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.codePoint);
			}
			return CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks((uint)codePoint);
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000A74EE File Offset: 0x000A56EE
		[NullableContext(1)]
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return CharUnicodeInfo.GetUnicodeCategoryInternal(s, index);
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000A7511 File Offset: 0x000A5711
		internal static UnicodeCategory GetUnicodeCategoryInternal(string value, int index)
		{
			return CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks((uint)CharUnicodeInfo.GetCodePointFromString(value, index));
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x000A7520 File Offset: 0x000A5720
		internal static UnicodeCategory GetUnicodeCategoryInternal(string str, int index, out int charLength)
		{
			uint codePointFromString = (uint)CharUnicodeInfo.GetCodePointFromString(str, index);
			charLength = ((codePointFromString >= 65536U) ? 2 : 1);
			return CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(codePointFromString);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x000A754C File Offset: 0x000A574C
		private unsafe static UnicodeCategory GetUnicodeCategoryNoBoundsChecks(uint codePoint)
		{
			UIntPtr categoryCasingTableOffsetNoBoundsChecks = CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(codePoint);
			return (UnicodeCategory)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.CategoriesValues), categoryCasingTableOffsetNoBoundsChecks) & 31);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x000A7574 File Offset: 0x000A5774
		private static int GetCodePointFromString(string s, int index)
		{
			int num = 0;
			if (index < s.Length)
			{
				num = (int)s[index];
				int num2 = num - 55296;
				if (num2 <= 1023)
				{
					index++;
					if (index < s.Length)
					{
						int num3 = (int)(s[index] - '\udc00');
						if (num3 <= 1023)
						{
							num = (num2 << 10) + num3 + 65536;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x000A75D8 File Offset: 0x000A57D8
		private unsafe static UIntPtr GetCategoryCasingTableOffsetNoBoundsChecks(uint codePoint)
		{
			uint num = (uint)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.CategoryCasingLevel1Index), (UIntPtr)(codePoint >> 9)));
			ref byte source = ref Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.CategoryCasingLevel2Index), (UIntPtr)((num << 6) + (codePoint >> 3 & 62U)));
			bool isLittleEndian = BitConverter.IsLittleEndian;
			num = (uint)Unsafe.ReadUnaligned<ushort>(ref source);
			return (UIntPtr)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.CategoryCasingLevel3Index), (UIntPtr)((num << 4) + (codePoint & 15U))));
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x000A7640 File Offset: 0x000A5840
		private unsafe static UIntPtr GetNumericGraphemeTableOffsetNoBoundsChecks(uint codePoint)
		{
			uint num = (uint)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.NumericGraphemeLevel1Index), (UIntPtr)(codePoint >> 9)));
			ref byte source = ref Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.NumericGraphemeLevel2Index), (UIntPtr)((num << 6) + (codePoint >> 3 & 62U)));
			bool isLittleEndian = BitConverter.IsLittleEndian;
			num = (uint)Unsafe.ReadUnaligned<ushort>(ref source);
			return (UIntPtr)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(CharUnicodeInfo.NumericGraphemeLevel3Index), (UIntPtr)((num << 4) + (codePoint & 15U))));
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x000A76A7 File Offset: 0x000A58A7
		private unsafe static ReadOnlySpan<byte> CategoryCasingLevel1Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.C815DE1D6518F024CBA12F00817EDA278C68BC742ADB46D36FC5D2A81EEFEF23), 2176);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x000A76B8 File Offset: 0x000A58B8
		private unsafe static ReadOnlySpan<byte> CategoryCasingLevel2Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.911C33B9E7764006F80602E68CF64BBB218083B93AFA0BBD423B90268827AB79), 6592);
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x000A76C9 File Offset: 0x000A58C9
		private unsafe static ReadOnlySpan<byte> CategoryCasingLevel3Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B176E0BE7A4F43D66C2CF1E2CF618917EFD8B95E8B0C607FA4037B05ACBEC04C), 12144);
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x000A76DA File Offset: 0x000A58DA
		private unsafe static ReadOnlySpan<byte> CategoriesValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.2E1BDF20E4AFDBBCB0A5195FA85CB8125971595A2D4F210F084CEC50DB8044AD), 233);
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x000A76EB File Offset: 0x000A58EB
		private unsafe static ReadOnlySpan<byte> UppercaseValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.69BE6B0A83642082EA8996953235901E21EF8A37071D8ADF12FA96F8A39CC20D), 466);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x000A76FC File Offset: 0x000A58FC
		private unsafe static ReadOnlySpan<byte> LowercaseValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E90599A80AD817C6ABA21C63B89251239EB90353340EF70400BA491BF13CCD2B), 466);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x000A770D File Offset: 0x000A590D
		private unsafe static ReadOnlySpan<byte> NumericGraphemeLevel1Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.443229324FA741DB76965F10DD25475D21E50A7F91AE26B4DFBD61269001E66D), 2176);
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x000A771E File Offset: 0x000A591E
		private unsafe static ReadOnlySpan<byte> NumericGraphemeLevel2Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.FE33C696E42DE44C8C51C8A307669A157C1C36FD4AE2C1352149488ABA443B82), 5056);
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x000A772F File Offset: 0x000A592F
		private unsafe static ReadOnlySpan<byte> NumericGraphemeLevel3Index
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.971FB43A0109D99DBC0F91603A8158CDE881016AC6E0776F9CEE4CAB0EF680E1), 6256);
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x000A7740 File Offset: 0x000A5940
		private unsafe static ReadOnlySpan<byte> DigitValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.2FF31353E83C9BDB78A790B8A02664AB21F1E89964732C21F2C164D01CDD39DC), 177);
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x000A7751 File Offset: 0x000A5951
		private unsafe static ReadOnlySpan<byte> NumericValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.0107A6D71D367FA901A73B2343D07B198CBB249E11715E27F2A077A666D82476), 1416);
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x000A7762 File Offset: 0x000A5962
		private unsafe static ReadOnlySpan<byte> GraphemeSegmentationValues
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F20934FF721BC3C50DEFC87EDD892E3335DC8C209D9D64A7C81E696777EF00B7), 177);
			}
		}
	}
}

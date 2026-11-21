using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Globalization
{
	// Token: 0x02000308 RID: 776
	internal static class OrdinalCasing
	{
		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060038B0 RID: 14512 RVA: 0x000BB75E File Offset: 0x000B995E
		private static ushort[] NoCasingPage
		{
			get
			{
				return Array.Empty<ushort>();
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x000BB765 File Offset: 0x000B9965
		private unsafe static ReadOnlySpan<byte> s_casingTableInit
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.FCD8A4EE2AE994445CD4E8AB39A4B0B6863F3396CF0806E73A45E8A80824E2E4), 32);
			}
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x000BB774 File Offset: 0x000B9974
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToUpper(char c)
		{
			int num = (int)(c >> 8);
			if (num == 0)
			{
				return (char)OrdinalCasing.s_basicLatin[(int)c];
			}
			ushort[] array = OrdinalCasing.s_casingTable[num];
			if (array == OrdinalCasing.NoCasingPage)
			{
				return c;
			}
			if (array == null)
			{
				array = OrdinalCasing.InitOrdinalCasingPage(num);
			}
			return (char)array[(int)(c & 'ÿ')];
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x000BB7B8 File Offset: 0x000B99B8
		internal unsafe static void ToUpperOrdinal(ReadOnlySpan<char> source, Span<char> destination)
		{
			for (int i = 0; i < source.Length; i++)
			{
				char c = (char)(*source[i]);
				if (c <= 'ÿ')
				{
					*destination[i] = (char)OrdinalCasing.s_basicLatin[(int)c];
				}
				else
				{
					if (char.IsHighSurrogate(c) && i < source.Length - 1)
					{
						char c2 = (char)(*source[i + 1]);
						if (char.IsLowSurrogate(c2))
						{
							SurrogateCasing.ToUpper(c, c2, destination[i], destination[i + 1]);
							i++;
							goto IL_7E;
						}
					}
					*destination[i] = OrdinalCasing.ToUpper(c);
				}
				IL_7E:;
			}
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x000BB854 File Offset: 0x000B9A54
		internal unsafe static int CompareStringIgnoreCase(ref char strA, int lengthA, ref char strB, int lengthB)
		{
			int num = Math.Min(lengthA, lengthB);
			ref char ptr = ref strA;
			ref char ptr2 = ref strB;
			int i = 0;
			while (i < num)
			{
				char c = ptr;
				char c2 = ptr2;
				char c3;
				if (!char.IsHighSurrogate(c) || i >= lengthA - 1 || !char.IsLowSurrogate(c3 = *Unsafe.Add<char>(ref ptr, 1)))
				{
					if (char.IsHighSurrogate(c2) && i < lengthB - 1 && char.IsLowSurrogate(*Unsafe.Add<char>(ref ptr2, 1)))
					{
						return -1;
					}
					if (c2 == c)
					{
						i++;
						ptr = Unsafe.Add<char>(ref ptr, 1);
						ptr2 = Unsafe.Add<char>(ref ptr2, 1);
					}
					else
					{
						char c4 = OrdinalCasing.ToUpper(c);
						char c5 = OrdinalCasing.ToUpper(c2);
						if (c4 != c5)
						{
							return (int)(c4 - c5);
						}
						i++;
						ptr = Unsafe.Add<char>(ref ptr, 1);
						ptr2 = Unsafe.Add<char>(ref ptr2, 1);
					}
				}
				else
				{
					char c6;
					if (!char.IsHighSurrogate(c2) || i >= lengthB - 1 || !char.IsLowSurrogate(c6 = *Unsafe.Add<char>(ref ptr2, 1)))
					{
						return 1;
					}
					if (c == c2 && c3 == c6)
					{
						i += 2;
						ptr = Unsafe.Add<char>(ref ptr, 2);
						ptr2 = Unsafe.Add<char>(ref ptr2, 2);
					}
					else
					{
						uint num2 = CharUnicodeInfo.ToUpper(UnicodeUtility.GetScalarFromUtf16SurrogatePair((uint)c, (uint)c3));
						uint num3 = CharUnicodeInfo.ToUpper(UnicodeUtility.GetScalarFromUtf16SurrogatePair((uint)c2, (uint)c6));
						if (num2 != num3)
						{
							return (int)(num2 - num3);
						}
						i += 2;
						ptr = Unsafe.Add<char>(ref ptr, 2);
						ptr2 = Unsafe.Add<char>(ref ptr2, 2);
					}
				}
			}
			return lengthA - lengthB;
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x000BB9AC File Offset: 0x000B9BAC
		internal unsafe static int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(value))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr + (source.Length - value.Length);
					char* ptr4 = ptr2 + value.Length - 1;
					for (char* ptr5 = ptr; ptr5 == ptr3; ptr5++)
					{
						char* ptr6 = ptr2;
						char* ptr7 = ptr5;
						while (ptr6 == ptr4)
						{
							if (!char.IsHighSurrogate(*ptr6) || ptr6 == ptr4)
							{
								if (*ptr6 != *ptr7 && OrdinalCasing.ToUpper(*ptr6) != OrdinalCasing.ToUpper(*ptr7))
								{
									break;
								}
								ptr6++;
								ptr7++;
							}
							else if (char.IsHighSurrogate(*ptr7) && char.IsLowSurrogate(ptr7[1]) && char.IsLowSurrogate(ptr6[1]))
							{
								if (!SurrogateCasing.Equal(*ptr7, ptr7[1], *ptr6, ptr6[1]))
								{
									break;
								}
								ptr7 += 2;
								ptr6 += 2;
							}
							else
							{
								if (*ptr6 != *ptr7)
								{
									break;
								}
								ptr7++;
								ptr6++;
							}
						}
						if (ptr6 != ptr4)
						{
							return (int)((long)(ptr5 - ptr));
						}
					}
					return -1;
				}
			}
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x000BBAC8 File Offset: 0x000B9CC8
		internal unsafe static int LastIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(value))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr2 + value.Length - 1;
					for (char* ptr4 = ptr + (source.Length - value.Length); ptr4 >= ptr; ptr4--)
					{
						char* ptr5 = ptr2;
						char* ptr6 = ptr4;
						while (ptr5 == ptr3)
						{
							if (!char.IsHighSurrogate(*ptr5) || ptr5 == ptr3)
							{
								if (*ptr5 != *ptr6 && OrdinalCasing.ToUpper(*ptr5) != OrdinalCasing.ToUpper(*ptr6))
								{
									break;
								}
								ptr5++;
								ptr6++;
							}
							else if (char.IsHighSurrogate(*ptr6) && char.IsLowSurrogate(ptr6[1]) && char.IsLowSurrogate(ptr5[1]))
							{
								if (!SurrogateCasing.Equal(*ptr6, ptr6[1], *ptr5, ptr5[1]))
								{
									break;
								}
								ptr6 += 2;
								ptr5 += 2;
							}
							else
							{
								if (*ptr5 != *ptr6)
								{
									break;
								}
								ptr6++;
								ptr5++;
							}
						}
						if (ptr5 != ptr3)
						{
							return (int)((long)(ptr4 - ptr));
						}
					}
					return -1;
				}
			}
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		private unsafe static ushort[][] InitCasingTable()
		{
			ushort[][] array = new ushort[OrdinalCasing.s_casingTableInit.Length * 8][];
			for (int i = 0; i < OrdinalCasing.s_casingTableInit.Length * 8; i++)
			{
				if (((byte)(*OrdinalCasing.s_casingTableInit[i / 8] >> 7 - i % 8) & 1) == 1)
				{
					array[i] = OrdinalCasing.NoCasingPage;
				}
			}
			array[0] = OrdinalCasing.s_basicLatin;
			return array;
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x000BBC50 File Offset: 0x000B9E50
		private unsafe static ushort[] InitOrdinalCasingPage(int pageNumber)
		{
			ushort[] array = new ushort[256];
			ushort[] array2;
			ushort* ptr;
			if ((array2 = array) == null || array2.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array2[0];
			}
			char* pTarget = (char*)ptr;
			Interop.Globalization.InitOrdinalCasingPage(pageNumber, pTarget);
			array2 = null;
			Volatile.Write<ushort[]>(ref OrdinalCasing.s_casingTable[pageNumber], array);
			return array;
		}

		// Token: 0x04000B3D RID: 2877
		private static readonly ushort[] s_basicLatin = new ushort[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			12,
			13,
			14,
			15,
			16,
			17,
			18,
			19,
			20,
			21,
			22,
			23,
			24,
			25,
			26,
			27,
			28,
			29,
			30,
			31,
			32,
			33,
			34,
			35,
			36,
			37,
			38,
			39,
			40,
			41,
			42,
			43,
			44,
			45,
			46,
			47,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			58,
			59,
			60,
			61,
			62,
			63,
			64,
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90,
			91,
			92,
			93,
			94,
			95,
			96,
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90,
			123,
			124,
			125,
			126,
			127,
			128,
			129,
			130,
			131,
			132,
			133,
			134,
			135,
			136,
			137,
			138,
			139,
			140,
			141,
			142,
			143,
			144,
			145,
			146,
			147,
			148,
			149,
			150,
			151,
			152,
			153,
			154,
			155,
			156,
			157,
			158,
			159,
			160,
			161,
			162,
			163,
			164,
			165,
			166,
			167,
			168,
			169,
			170,
			171,
			172,
			173,
			174,
			175,
			176,
			177,
			178,
			179,
			180,
			924,
			182,
			183,
			184,
			185,
			186,
			187,
			188,
			189,
			190,
			191,
			192,
			193,
			194,
			195,
			196,
			197,
			198,
			199,
			200,
			201,
			202,
			203,
			204,
			205,
			206,
			207,
			208,
			209,
			210,
			211,
			212,
			213,
			214,
			215,
			216,
			217,
			218,
			219,
			220,
			221,
			222,
			223,
			192,
			193,
			194,
			195,
			196,
			197,
			198,
			199,
			200,
			201,
			202,
			203,
			204,
			205,
			206,
			207,
			208,
			209,
			210,
			211,
			212,
			213,
			214,
			247,
			216,
			217,
			218,
			219,
			220,
			221,
			222,
			376
		};

		// Token: 0x04000B3E RID: 2878
		private static readonly ushort[][] s_casingTable = OrdinalCasing.InitCasingTable();
	}
}

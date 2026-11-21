using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002FC RID: 764
	internal static class InvariantModeCasing
	{
		// Token: 0x060037A3 RID: 14243 RVA: 0x000B74DF File Offset: 0x000B56DF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToLower(char c)
		{
			return CharUnicodeInfo.ToLower(c);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x000B74E7 File Offset: 0x000B56E7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToUpper(char c)
		{
			return CharUnicodeInfo.ToUpper(c);
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x000B74F0 File Offset: 0x000B56F0
		internal unsafe static string ToLower(string s)
		{
			if (s.Length == 0)
			{
				return string.Empty;
			}
			ReadOnlySpan<char> readOnlySpan = s;
			int i = 0;
			while (i < s.Length)
			{
				if (char.IsHighSurrogate((char)(*readOnlySpan[i])) && i < s.Length - 1 && char.IsLowSurrogate((char)(*readOnlySpan[i + 1])))
				{
					char c;
					char c2;
					SurrogateCasing.ToLower((char)(*readOnlySpan[i]), (char)(*readOnlySpan[i + 1]), out c, out c2);
					if (*readOnlySpan[i] != (ushort)c || *readOnlySpan[i + 1] != (ushort)c2)
					{
						break;
					}
					i += 2;
				}
				else
				{
					if (InvariantModeCasing.ToLower((char)(*readOnlySpan[i])) != (char)(*readOnlySpan[i]))
					{
						break;
					}
					i++;
				}
			}
			if (i >= s.Length)
			{
				return s;
			}
			string text = string.FastAllocateString(s.Length);
			Span<char> destination = new Span<char>(text.GetRawStringData(), text.Length);
			ReadOnlySpan<char> readOnlySpan2 = s;
			readOnlySpan2.Slice(0, i).CopyTo(destination);
			InvariantModeCasing.ToLower(readOnlySpan2.Slice(i), destination.Slice(i));
			return text;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x000B7608 File Offset: 0x000B5808
		internal unsafe static string ToUpper(string s)
		{
			if (s.Length == 0)
			{
				return string.Empty;
			}
			ReadOnlySpan<char> readOnlySpan = s;
			int i = 0;
			while (i < s.Length)
			{
				if (char.IsHighSurrogate((char)(*readOnlySpan[i])) && i < s.Length - 1 && char.IsLowSurrogate((char)(*readOnlySpan[i + 1])))
				{
					char c;
					char c2;
					SurrogateCasing.ToUpper((char)(*readOnlySpan[i]), (char)(*readOnlySpan[i + 1]), out c, out c2);
					if (*readOnlySpan[i] != (ushort)c || *readOnlySpan[i + 1] != (ushort)c2)
					{
						break;
					}
					i += 2;
				}
				else
				{
					if (InvariantModeCasing.ToUpper((char)(*readOnlySpan[i])) != (char)(*readOnlySpan[i]))
					{
						break;
					}
					i++;
				}
			}
			if (i >= s.Length)
			{
				return s;
			}
			string text = string.FastAllocateString(s.Length);
			Span<char> destination = new Span<char>(text.GetRawStringData(), text.Length);
			ReadOnlySpan<char> readOnlySpan2 = s;
			readOnlySpan2.Slice(0, i).CopyTo(destination);
			InvariantModeCasing.ToUpper(readOnlySpan2.Slice(i), destination.Slice(i));
			return text;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x000B7720 File Offset: 0x000B5920
		internal unsafe static void ToUpper(ReadOnlySpan<char> source, Span<char> destination)
		{
			int i = 0;
			while (i < source.Length)
			{
				char c = (char)(*source[i]);
				if (!char.IsHighSurrogate(c) || i >= source.Length - 1)
				{
					goto IL_5E;
				}
				char c2 = (char)(*source[i + 1]);
				if (!char.IsLowSurrogate(c2))
				{
					goto IL_5E;
				}
				char c3;
				char c4;
				SurrogateCasing.ToUpper(c, c2, out c3, out c4);
				*destination[i] = c3;
				*destination[i + 1] = c4;
				i++;
				IL_6D:
				i++;
				continue;
				IL_5E:
				*destination[i] = InvariantModeCasing.ToUpper(c);
				goto IL_6D;
			}
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x000B77A8 File Offset: 0x000B59A8
		internal unsafe static void ToLower(ReadOnlySpan<char> source, Span<char> destination)
		{
			int i = 0;
			while (i < source.Length)
			{
				char c = (char)(*source[i]);
				if (!char.IsHighSurrogate(c) || i >= source.Length - 1)
				{
					goto IL_5E;
				}
				char c2 = (char)(*source[i + 1]);
				if (!char.IsLowSurrogate(c2))
				{
					goto IL_5E;
				}
				char c3;
				char c4;
				SurrogateCasing.ToLower(c, c2, out c3, out c4);
				*destination[i] = c3;
				*destination[i + 1] = c4;
				i++;
				IL_6D:
				i++;
				continue;
				IL_5E:
				*destination[i] = InvariantModeCasing.ToLower(c);
				goto IL_6D;
			}
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x000B7830 File Offset: 0x000B5A30
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static ValueTuple<uint, int> GetScalar(ref char source, int index, int length)
		{
			char c = source;
			if (!char.IsHighSurrogate(c) || index >= length - 1)
			{
				return new ValueTuple<uint, int>((uint)c, 1);
			}
			char c2 = *Unsafe.Add<char>(ref source, 1);
			if (!char.IsLowSurrogate(c2))
			{
				return new ValueTuple<uint, int>((uint)c, 1);
			}
			return new ValueTuple<uint, int>(UnicodeUtility.GetScalarFromUtf16SurrogatePair((uint)c, (uint)c2), 2);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x000B787C File Offset: 0x000B5A7C
		internal static int CompareStringIgnoreCase(ref char strA, int lengthA, ref char strB, int lengthB)
		{
			int num = Math.Min(lengthA, lengthB);
			ref char source = ref strA;
			ref char source2 = ref strB;
			int i = 0;
			while (i < num)
			{
				ValueTuple<uint, int> scalar = InvariantModeCasing.GetScalar(ref source, i, lengthA);
				uint item = scalar.Item1;
				int item2 = scalar.Item2;
				ValueTuple<uint, int> scalar2 = InvariantModeCasing.GetScalar(ref source2, i, lengthB);
				uint item3 = scalar2.Item1;
				int item4 = scalar2.Item2;
				if (item == item3)
				{
					i += item2;
					source = Unsafe.Add<char>(ref source, item2);
					source2 = Unsafe.Add<char>(ref source2, item4);
				}
				else
				{
					uint num2 = CharUnicodeInfo.ToUpper(item);
					uint num3 = CharUnicodeInfo.ToUpper(item3);
					if (num2 != num3)
					{
						return (int)(num2 - num3);
					}
					i += item2;
					source = Unsafe.Add<char>(ref source, item2);
					source2 = Unsafe.Add<char>(ref source2, item4);
				}
			}
			return lengthA - lengthB;
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x000B792C File Offset: 0x000B5B2C
		internal unsafe static int IndexOfIgnoreCase(ReadOnlySpan<char> source, ReadOnlySpan<char> value)
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
								if (*ptr6 != *ptr7 && InvariantModeCasing.ToUpper(*ptr6) != InvariantModeCasing.ToUpper(*ptr7))
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

		// Token: 0x060037AC RID: 14252 RVA: 0x000B7A48 File Offset: 0x000B5C48
		internal unsafe static int LastIndexOfIgnoreCase(ReadOnlySpan<char> source, ReadOnlySpan<char> value)
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
								if (*ptr5 != *ptr6 && InvariantModeCasing.ToUpper(*ptr5) != InvariantModeCasing.ToUpper(*ptr6))
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
	}
}

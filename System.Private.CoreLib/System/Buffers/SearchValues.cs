using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace System.Buffers
{
	// Token: 0x02000373 RID: 883
	public static class SearchValues
	{
		// Token: 0x06003BC6 RID: 15302 RVA: 0x000C6D54 File Offset: 0x000C4F54
		[return: Nullable(1)]
		public static SearchValues<byte> Create([ParamCollection] [ScopedRef] ReadOnlySpan<byte> values)
		{
			if (values.IsEmpty)
			{
				return new EmptySearchValues<byte>();
			}
			if (values.Length == 1)
			{
				return new Any1SearchValues<byte, byte>(values);
			}
			byte lowInclusive;
			byte b;
			if (SearchValues.TryGetSingleRange<byte>(values, out lowInclusive, out b))
			{
				return new RangeByteSearchValues(lowInclusive, b);
			}
			if (values.Length <= 5)
			{
				SearchValues<byte> result;
				switch (values.Length)
				{
				case 2:
					result = new Any2SearchValues<byte, byte>(values);
					break;
				case 3:
					result = new Any3SearchValues<byte, byte>(values);
					break;
				case 4:
					result = new Any4SearchValues<byte, byte>(values);
					break;
				default:
					result = new Any5SearchValues<byte, byte>(values);
					break;
				}
				return result;
			}
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && b < 128)
			{
				return new AsciiByteSearchValues(values);
			}
			return new AnyByteSearchValues(values);
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x000C6E00 File Offset: 0x000C5000
		[return: Nullable(1)]
		public unsafe static SearchValues<char> Create([ParamCollection] [ScopedRef] ReadOnlySpan<char> values)
		{
			if (values.IsEmpty)
			{
				return new EmptySearchValues<char>();
			}
			ReadOnlySpan<short> values2 = MemoryMarshal.Cast<char, short>(values);
			char c;
			char c2;
			if (values.Length == 1)
			{
				char value = (char)(*values[0]);
				if (!PackedSpanHelpers.PackedIndexOfIsSupported || !PackedSpanHelpers.CanUsePackedIndexOf<char>(value))
				{
					return new Any1SearchValues<char, short>(values2);
				}
				return new Any1CharPackedSearchValues(value);
			}
			else if (SearchValues.TryGetSingleRange<char>(values, out c, out c2))
			{
				if (!PackedSpanHelpers.PackedIndexOfIsSupported || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c) || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c2))
				{
					return new RangeCharSearchValues<SearchValues.FalseConst>(c, c2);
				}
				return new RangeCharSearchValues<SearchValues.TrueConst>(c, c2);
			}
			else if (values.Length == 2)
			{
				char c3 = (char)(*values[0]);
				char c4 = (char)(*values[1]);
				if (!PackedSpanHelpers.PackedIndexOfIsSupported || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c3) || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c4))
				{
					return new Any2SearchValues<char, short>(values2);
				}
				if ((c3 ^ c4) != ' ')
				{
					return new Any2CharPackedSearchValues(c3, c4);
				}
				return new Any1CharPackedIgnoreCaseSearchValues((char)Math.Max((ushort)c3, (ushort)c4));
			}
			else if (values.Length == 3)
			{
				char c5 = (char)(*values[0]);
				char c6 = (char)(*values[1]);
				char c7 = (char)(*values[2]);
				if (!PackedSpanHelpers.PackedIndexOfIsSupported || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c5) || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c6) || !PackedSpanHelpers.CanUsePackedIndexOf<char>(c7))
				{
					return new Any3SearchValues<char, short>(values2);
				}
				return new Any3CharPackedSearchValues(c5, c6, c7);
			}
			else if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && c2 < '\u0080')
			{
				if (PackedSpanHelpers.PackedIndexOfIsSupported && values.Length == 4 && c > '\0')
				{
					Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)8], 4);
					values.CopyTo(span);
					span.Sort<char>();
					if ((*span[0] ^ *span[2]) == ' ' && (*span[1] ^ *span[3]) == ' ')
					{
						return new Any2CharPackedIgnoreCaseSearchValues(*span[2], *span[3]);
					}
				}
				if ((!Ssse3.IsSupported && !false) || c != '\0')
				{
					return new AsciiCharSearchValues<IndexOfAnyAsciiSearcher.Default>(values);
				}
				return new AsciiCharSearchValues<IndexOfAnyAsciiSearcher.Ssse3AndWasmHandleZeroInNeedle>(values);
			}
			else
			{
				if (values.Length == 4)
				{
					return new Any4SearchValues<char, short>(values2);
				}
				if (values.Length == 5)
				{
					return new Any5SearchValues<char, short>(values2);
				}
				if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && c < '\u0080')
				{
					if ((!Ssse3.IsSupported && !false) || !values.Contains('\0'))
					{
						return new ProbabilisticWithAsciiCharSearchValues<IndexOfAnyAsciiSearcher.Default>(values, (int)c2);
					}
					return new ProbabilisticWithAsciiCharSearchValues<IndexOfAnyAsciiSearcher.Ssse3AndWasmHandleZeroInNeedle>(values, (int)c2);
				}
				else
				{
					if (SearchValues.<Create>g__ShouldUseProbabilisticMap|1_0(values.Length, (int)c2))
					{
						return new ProbabilisticCharSearchValues(values, (int)c2);
					}
					return new BitmapCharSearchValues(values, (int)c2);
				}
			}
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x000C7064 File Offset: 0x000C5264
		[NullableContext(1)]
		public static SearchValues<string> Create([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<string> values, StringComparison comparisonType)
		{
			if (comparisonType - StringComparison.Ordinal > 1)
			{
				throw new ArgumentException(SR.Argument_SearchValues_UnsupportedStringComparison, "comparisonType");
			}
			return StringSearchValues.Create(values, comparisonType == StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x000C709C File Offset: 0x000C529C
		private unsafe static bool TryGetSingleRange<T>(ReadOnlySpan<T> values, out T minInclusive, out T maxInclusive) where T : struct, INumber<T>, IMinMaxValue<T>
		{
			T t = IMinMaxValue<T>.MaxValue;
			T t2 = IMinMaxValue<T>.MinValue;
			ReadOnlySpan<T> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				T y = *readOnlySpan[i];
				t = INumber<T>.Min(t, y);
				t2 = INumber<T>.Max(t2, y);
			}
			minInclusive = t;
			maxInclusive = t2;
			uint num = uint.CreateChecked<T>(t2 - t) + 1U;
			if ((ulong)num > (ulong)((long)values.Length))
			{
				return false;
			}
			Span<bool> span;
			if (num <= 256U)
			{
				span = new Span<bool>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = new bool[num];
			}
			Span<bool> span2 = span;
			span2 = span2.Slice(0, (int)num);
			span2.Clear();
			readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				int index = int.CreateChecked<T>(*readOnlySpan[i] - t);
				*span2[index] = true;
			}
			return !span2.Contains(false);
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x000C71CC File Offset: 0x000C53CC
		[CompilerGenerated]
		internal static bool <Create>g__ShouldUseProbabilisticMap|1_0(int valuesLength, int maxInclusive)
		{
			if (valuesLength > 256)
			{
				return false;
			}
			if (Sse41.IsSupported || false)
			{
				return true;
			}
			int num = 64 + maxInclusive / 8;
			int num2 = 128 + valuesLength * 4;
			return 2 * num2 < num;
		}

		// Token: 0x02000374 RID: 884
		internal interface IRuntimeConst
		{
			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x06003BCB RID: 15307
			bool Value { get; }
		}

		// Token: 0x02000375 RID: 885
		internal readonly struct TrueConst : SearchValues.IRuntimeConst
		{
			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x06003BCC RID: 15308 RVA: 0x000070DD File Offset: 0x000052DD
			public static bool Value
			{
				get
				{
					return true;
				}
			}
		}

		// Token: 0x02000376 RID: 886
		internal readonly struct FalseConst : SearchValues.IRuntimeConst
		{
			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x06003BCD RID: 15309 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool Value
			{
				get
				{
					return false;
				}
			}
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace System.Buffers
{
	// Token: 0x0200035D RID: 861
	internal sealed class ProbabilisticWithAsciiCharSearchValues<TOptimizations> : SearchValues<char> where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations
	{
		// Token: 0x06003B32 RID: 15154 RVA: 0x000C4F5F File Offset: 0x000C315F
		public ProbabilisticWithAsciiCharSearchValues(ReadOnlySpan<char> values, int maxInclusive)
		{
			IndexOfAnyAsciiSearcher.ComputeAsciiState<char>(values, out this._asciiState);
			this._inverseAsciiState = this._asciiState.CreateInverse();
			this._map = new ProbabilisticMapState(values, maxInclusive);
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x000C4F91 File Offset: 0x000C3191
		internal override char[] GetValues()
		{
			return this._map.GetValues();
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x000C4F9E File Offset: 0x000C319E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return this._map.FastContains(value);
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x000C4FAC File Offset: 0x000C31AC
		internal unsafe override int IndexOfAny(ReadOnlySpan<char> span)
		{
			int num = 0;
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && span.Length >= Vector128<short>.Count && char.IsAscii((char)(*span[0])))
			{
				if ((Ssse3.IsSupported || false) && typeof(TOptimizations) == typeof(IndexOfAnyAsciiSearcher.Default))
				{
					num = IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.Negate, IndexOfAnyAsciiSearcher.Ssse3AndWasmHandleZeroInNeedle>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._inverseAsciiState);
				}
				else
				{
					num = IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.Negate, IndexOfAnyAsciiSearcher.Default>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._inverseAsciiState);
				}
				if (num >= span.Length || char.IsAscii((char)(*span[num])))
				{
					return num;
				}
				span = span.Slice(num);
			}
			int num2 = ProbabilisticMap.IndexOfAny<SearchValues.TrueConst>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
			if (num2 >= 0)
			{
				num2 += num;
			}
			return num2;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x000C5094 File Offset: 0x000C3294
		internal unsafe override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			int num = 0;
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && span.Length >= Vector128<short>.Count && char.IsAscii((char)(*span[0])))
			{
				num = IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.Negate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._asciiState);
				if (num >= span.Length || char.IsAscii((char)(*span[num])))
				{
					return num;
				}
				span = span.Slice(num);
			}
			int num2 = ProbabilisticMapState.IndexOfAnySimpleLoop<SearchValues.TrueConst, IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
			if (num2 >= 0)
			{
				num2 += num;
			}
			return num2;
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x000C5130 File Offset: 0x000C3330
		internal unsafe override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && span.Length >= Vector128<short>.Count && char.IsAscii((char)(*span[span.Length - 1])))
			{
				int num;
				if ((Ssse3.IsSupported || false) && typeof(TOptimizations) == typeof(IndexOfAnyAsciiSearcher.Default))
				{
					num = IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate, IndexOfAnyAsciiSearcher.Ssse3AndWasmHandleZeroInNeedle>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._inverseAsciiState);
				}
				else
				{
					num = IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate, IndexOfAnyAsciiSearcher.Default>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._inverseAsciiState);
				}
				if (num >= span.Length || char.IsAscii((char)(*span[num])))
				{
					return num;
				}
				span = span.Slice(0, num + 1);
			}
			return ProbabilisticMap.LastIndexOfAny<SearchValues.TrueConst>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x000C5218 File Offset: 0x000C3418
		internal unsafe override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			if (IndexOfAnyAsciiSearcher.IsVectorizationSupported && span.Length >= Vector128<short>.Count && char.IsAscii((char)(*span[span.Length - 1])))
			{
				int num = IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._asciiState);
				if (num >= span.Length || char.IsAscii((char)(*span[num])))
				{
					return num;
				}
				span = span.Slice(0, num + 1);
			}
			return ProbabilisticMapState.LastIndexOfAnySimpleLoop<SearchValues.TrueConst, IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
		}

		// Token: 0x04000C79 RID: 3193
		private IndexOfAnyAsciiSearcher.AsciiState _asciiState;

		// Token: 0x04000C7A RID: 3194
		private IndexOfAnyAsciiSearcher.AsciiState _inverseAsciiState;

		// Token: 0x04000C7B RID: 3195
		private ProbabilisticMapState _map;
	}
}

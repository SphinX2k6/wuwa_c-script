using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000371 RID: 881
	internal sealed class ProbabilisticCharSearchValues : SearchValues<char>
	{
		// Token: 0x06003BB5 RID: 15285 RVA: 0x000C6AF3 File Offset: 0x000C4CF3
		public ProbabilisticCharSearchValues(ReadOnlySpan<char> values, int maxInclusive)
		{
			this._map = new ProbabilisticMapState(values, maxInclusive);
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x000C6B08 File Offset: 0x000C4D08
		internal override char[] GetValues()
		{
			return this._map.GetValues();
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x000C6B15 File Offset: 0x000C4D15
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return this._map.FastContains(value);
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x000C6B23 File Offset: 0x000C4D23
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return ProbabilisticMap.IndexOfAny<SearchValues.TrueConst>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x000C6B3D File Offset: 0x000C4D3D
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return ProbabilisticMapState.IndexOfAnySimpleLoop<SearchValues.TrueConst, IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x000C6B57 File Offset: 0x000C4D57
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return ProbabilisticMap.LastIndexOfAny<SearchValues.TrueConst>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000C6B71 File Offset: 0x000C4D71
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return ProbabilisticMapState.LastIndexOfAnySimpleLoop<SearchValues.TrueConst, IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<char>(span), span.Length, ref this._map);
		}

		// Token: 0x04000C96 RID: 3222
		private ProbabilisticMapState _map;
	}
}

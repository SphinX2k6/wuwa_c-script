using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000352 RID: 850
	internal sealed class Any1CharPackedSearchValues : SearchValues<char>
	{
		// Token: 0x06003AE4 RID: 15076 RVA: 0x000C420C File Offset: 0x000C240C
		public Any1CharPackedSearchValues(char value)
		{
			this._e0 = value;
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x000C421B File Offset: 0x000C241B
		internal override char[] GetValues()
		{
			return new char[]
			{
				this._e0
			};
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x000C422C File Offset: 0x000C242C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return value == this._e0;
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x000C4237 File Offset: 0x000C2437
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOf(MemoryMarshal.GetReference<char>(span), this._e0, span.Length);
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x000C4251 File Offset: 0x000C2451
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyExcept(MemoryMarshal.GetReference<char>(span), this._e0, span.Length);
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x000C426B File Offset: 0x000C246B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return span.LastIndexOf(this._e0);
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x000C4279 File Offset: 0x000C2479
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAnyExcept(this._e0);
		}

		// Token: 0x04000C5F RID: 3167
		private readonly char _e0;
	}
}

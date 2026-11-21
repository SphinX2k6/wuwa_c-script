using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000356 RID: 854
	internal sealed class Any2CharPackedSearchValues : SearchValues<char>
	{
		// Token: 0x06003B00 RID: 15104 RVA: 0x000C458C File Offset: 0x000C278C
		public Any2CharPackedSearchValues(char value0, char value1)
		{
			this._e0 = value0;
			this._e1 = value1;
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x000C45B1 File Offset: 0x000C27B1
		internal override char[] GetValues()
		{
			return new char[]
			{
				this._e0,
				this._e1
			};
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x000C45CB File Offset: 0x000C27CB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return value == this._e0 || value == this._e1;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x000C45E1 File Offset: 0x000C27E1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAny(MemoryMarshal.GetReference<char>(span), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x000C4601 File Offset: 0x000C2801
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyExcept(MemoryMarshal.GetReference<char>(span), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x000C4621 File Offset: 0x000C2821
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAny(this._e0, this._e1);
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x000C4635 File Offset: 0x000C2835
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAnyExcept(this._e0, this._e1);
		}

		// Token: 0x04000C6B RID: 3179
		private readonly char _e0;

		// Token: 0x04000C6C RID: 3180
		private readonly char _e1;
	}
}

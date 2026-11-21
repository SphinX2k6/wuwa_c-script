using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000355 RID: 853
	internal sealed class Any3CharPackedSearchValues : SearchValues<char>
	{
		// Token: 0x06003AF9 RID: 15097 RVA: 0x000C449C File Offset: 0x000C269C
		public Any3CharPackedSearchValues(char value0, char value1, char value2)
		{
			this._e0 = value0;
			this._e1 = value1;
			this._e2 = value2;
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x000C44CA File Offset: 0x000C26CA
		internal override char[] GetValues()
		{
			return new char[]
			{
				this._e0,
				this._e1,
				this._e2
			};
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x000C44ED File Offset: 0x000C26ED
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return value == this._e0 || value == this._e1 || value == this._e2;
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x000C450C File Offset: 0x000C270C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAny(MemoryMarshal.GetReference<char>(span), this._e0, this._e1, this._e2, span.Length);
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x000C4532 File Offset: 0x000C2732
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyExcept(MemoryMarshal.GetReference<char>(span), this._e0, this._e1, this._e2, span.Length);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x000C4558 File Offset: 0x000C2758
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAny(this._e0, this._e1, this._e2);
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x000C4572 File Offset: 0x000C2772
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAnyExcept(this._e0, this._e1, this._e2);
		}

		// Token: 0x04000C68 RID: 3176
		private readonly char _e0;

		// Token: 0x04000C69 RID: 3177
		private readonly char _e1;

		// Token: 0x04000C6A RID: 3178
		private readonly char _e2;
	}
}

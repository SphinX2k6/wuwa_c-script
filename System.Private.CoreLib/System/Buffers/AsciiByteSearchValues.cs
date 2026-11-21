using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000360 RID: 864
	internal sealed class AsciiByteSearchValues : SearchValues<byte>
	{
		// Token: 0x06003B47 RID: 15175 RVA: 0x000C5738 File Offset: 0x000C3938
		public AsciiByteSearchValues(ReadOnlySpan<byte> values)
		{
			IndexOfAnyAsciiSearcher.ComputeAsciiState<byte>(values, out this._state);
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x000C574C File Offset: 0x000C394C
		internal override byte[] GetValues()
		{
			return this._state.Lookup.GetByteValues();
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x000C575E File Offset: 0x000C395E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(byte value)
		{
			return this._state.Lookup.Contains(value);
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x000C5771 File Offset: 0x000C3971
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x000C578B File Offset: 0x000C398B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x000C57A5 File Offset: 0x000C39A5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x000C57BF File Offset: 0x000C39BF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x000C57D9 File Offset: 0x000C39D9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsAny(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.ContainsAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x000C57F3 File Offset: 0x000C39F3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsAnyExcept(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.ContainsAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x04000C85 RID: 3205
		private IndexOfAnyAsciiSearcher.AsciiState _state;
	}
}

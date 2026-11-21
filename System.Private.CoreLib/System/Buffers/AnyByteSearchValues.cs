using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x0200036E RID: 878
	internal sealed class AnyByteSearchValues : SearchValues<byte>
	{
		// Token: 0x06003B9E RID: 15262 RVA: 0x000C67AB File Offset: 0x000C49AB
		public AnyByteSearchValues(ReadOnlySpan<byte> values)
		{
			IndexOfAnyAsciiSearcher.ComputeAnyByteState(values, out this._state);
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x000C67BF File Offset: 0x000C49BF
		internal override byte[] GetValues()
		{
			return this._state.Lookup.GetByteValues();
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x000C67D1 File Offset: 0x000C49D1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(byte value)
		{
			return this._state.Lookup.Contains(value);
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x000C67E4 File Offset: 0x000C49E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x000C67FE File Offset: 0x000C49FE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000C6818 File Offset: 0x000C4A18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000C6832 File Offset: 0x000C4A32
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000C684C File Offset: 0x000C4A4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsAny(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.ContainsAny<IndexOfAnyAsciiSearcher.DontNegate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x000C6866 File Offset: 0x000C4A66
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsAnyExcept(ReadOnlySpan<byte> span)
		{
			return IndexOfAnyAsciiSearcher.ContainsAny<IndexOfAnyAsciiSearcher.Negate>(MemoryMarshal.GetReference<byte>(span), span.Length, ref this._state);
		}

		// Token: 0x04000C8C RID: 3212
		private IndexOfAnyAsciiSearcher.AnyByteState _state;
	}
}

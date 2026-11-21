using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000361 RID: 865
	internal sealed class AsciiCharSearchValues<TOptimizations> : SearchValues<char> where TOptimizations : struct, IndexOfAnyAsciiSearcher.IOptimizations
	{
		// Token: 0x06003B50 RID: 15184 RVA: 0x000C580D File Offset: 0x000C3A0D
		public AsciiCharSearchValues(ReadOnlySpan<char> values)
		{
			IndexOfAnyAsciiSearcher.ComputeAsciiState<char>(values, out this._state);
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x000C5821 File Offset: 0x000C3A21
		internal override char[] GetValues()
		{
			return this._state.Lookup.GetCharValues();
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x000C5833 File Offset: 0x000C3A33
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return this._state.Lookup.Contains128(value);
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x000C5846 File Offset: 0x000C3A46
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.DontNegate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000C5865 File Offset: 0x000C3A65
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.IndexOfAny<IndexOfAnyAsciiSearcher.Negate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000C5884 File Offset: 0x000C3A84
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x000C58A3 File Offset: 0x000C3AA3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000C58C2 File Offset: 0x000C3AC2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsAny(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.ContainsAny<IndexOfAnyAsciiSearcher.DontNegate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x000C58E1 File Offset: 0x000C3AE1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsAnyExcept(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.ContainsAny<IndexOfAnyAsciiSearcher.Negate, TOptimizations>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x04000C86 RID: 3206
		private IndexOfAnyAsciiSearcher.AsciiState _state;
	}
}

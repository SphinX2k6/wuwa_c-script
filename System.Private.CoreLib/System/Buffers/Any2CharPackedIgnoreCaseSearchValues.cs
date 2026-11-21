using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000354 RID: 852
	internal sealed class Any2CharPackedIgnoreCaseSearchValues : SearchValues<char>
	{
		// Token: 0x06003AF2 RID: 15090 RVA: 0x000C432C File Offset: 0x000C252C
		public unsafe Any2CharPackedIgnoreCaseSearchValues(char value0, char value1)
		{
			this._e0 = value0;
			this._e1 = value1;
			this._uint0 = (uint)value0;
			this._uint1 = (uint)value1;
			<>y__InlineArray4<char> <>y__InlineArray = default(<>y__InlineArray4<char>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 0) = (char)((int)this._e0 & -33);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 1) = this._e0;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 2) = (char)((int)this._e1 & -33);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 3) = this._e1;
			IndexOfAnyAsciiSearcher.ComputeAsciiState<char>(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<char>, char>(<>y__InlineArray, 4), out this._state);
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x000C43C4 File Offset: 0x000C25C4
		internal override char[] GetValues()
		{
			return new char[]
			{
				(char)((int)this._e0 & -33),
				this._e0,
				(char)((int)this._e1 & -33),
				this._e1
			};
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x000C43F8 File Offset: 0x000C25F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			uint num = (uint)(value | ' ');
			return num == this._uint0 || num == this._uint1;
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x000C441E File Offset: 0x000C261E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyIgnoreCase(MemoryMarshal.GetReference<char>(span), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x000C443E File Offset: 0x000C263E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyExceptIgnoreCase(MemoryMarshal.GetReference<char>(span), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x000C445E File Offset: 0x000C265E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.DontNegate, IndexOfAnyAsciiSearcher.Default>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x000C447D File Offset: 0x000C267D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return IndexOfAnyAsciiSearcher.LastIndexOfAny<IndexOfAnyAsciiSearcher.Negate, IndexOfAnyAsciiSearcher.Default>(Unsafe.As<char, short>(MemoryMarshal.GetReference<char>(span)), span.Length, ref this._state);
		}

		// Token: 0x04000C63 RID: 3171
		private readonly char _e0;

		// Token: 0x04000C64 RID: 3172
		private readonly char _e1;

		// Token: 0x04000C65 RID: 3173
		private readonly uint _uint0;

		// Token: 0x04000C66 RID: 3174
		private readonly uint _uint1;

		// Token: 0x04000C67 RID: 3175
		private IndexOfAnyAsciiSearcher.AsciiState _state;
	}
}

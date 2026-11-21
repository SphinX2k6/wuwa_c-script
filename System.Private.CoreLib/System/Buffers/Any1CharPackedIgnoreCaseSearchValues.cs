using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000353 RID: 851
	internal sealed class Any1CharPackedIgnoreCaseSearchValues : SearchValues<char>
	{
		// Token: 0x06003AEB RID: 15083 RVA: 0x000C4287 File Offset: 0x000C2487
		public Any1CharPackedIgnoreCaseSearchValues(char value)
		{
			this._lowerCase = value;
			this._upperCase = (char)((int)value & -33);
			this._lowerCaseUint = (uint)value;
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x000C42A8 File Offset: 0x000C24A8
		internal override char[] GetValues()
		{
			return new char[]
			{
				this._upperCase,
				this._lowerCase
			};
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x000C42C2 File Offset: 0x000C24C2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return (uint)(value | ' ') == this._lowerCaseUint;
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x000C42D0 File Offset: 0x000C24D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyIgnoreCase(MemoryMarshal.GetReference<char>(span), this._lowerCase, span.Length);
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x000C42EA File Offset: 0x000C24EA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return PackedSpanHelpers.IndexOfAnyExceptIgnoreCase(MemoryMarshal.GetReference<char>(span), this._lowerCase, span.Length);
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x000C4304 File Offset: 0x000C2504
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAny(this._lowerCase, this._upperCase);
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x000C4318 File Offset: 0x000C2518
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAnyExcept(this._lowerCase, this._upperCase);
		}

		// Token: 0x04000C60 RID: 3168
		private readonly char _lowerCase;

		// Token: 0x04000C61 RID: 3169
		private readonly char _upperCase;

		// Token: 0x04000C62 RID: 3170
		private readonly uint _lowerCaseUint;
	}
}

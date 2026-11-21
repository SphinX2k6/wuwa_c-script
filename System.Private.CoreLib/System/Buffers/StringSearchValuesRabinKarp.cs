using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x0200039B RID: 923
	internal abstract class StringSearchValuesRabinKarp<TCaseSensitivity> : StringSearchValuesBase where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x06003C7C RID: 15484 RVA: 0x000CA30A File Offset: 0x000C850A
		public StringSearchValuesRabinKarp(ReadOnlySpan<string> values, HashSet<string> uniqueValues) : base(uniqueValues)
		{
			this._rabinKarp = new RabinKarp(values);
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x000CA31F File Offset: 0x000C851F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected int ShortInputFallback(ReadOnlySpan<char> span)
		{
			return this._rabinKarp.IndexOfAny<TCaseSensitivity>(span);
		}

		// Token: 0x04000CC6 RID: 3270
		private readonly RabinKarp _rabinKarp;
	}
}

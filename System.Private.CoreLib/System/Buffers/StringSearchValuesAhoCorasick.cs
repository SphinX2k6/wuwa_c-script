using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x0200039A RID: 922
	internal sealed class StringSearchValuesAhoCorasick<TCaseSensitivity, TFastScanVariant> : StringSearchValuesBase where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TFastScanVariant : struct, AhoCorasick.IFastScan
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x000CA2EC File Offset: 0x000C84EC
		public StringSearchValuesAhoCorasick(AhoCorasick ahoCorasick, HashSet<string> uniqueValues) : base(uniqueValues)
		{
			this._ahoCorasick = ahoCorasick;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x000CA2FC File Offset: 0x000C84FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return this._ahoCorasick.IndexOfAny<TCaseSensitivity, TFastScanVariant>(span);
		}

		// Token: 0x04000CC5 RID: 3269
		private readonly AhoCorasick _ahoCorasick;
	}
}

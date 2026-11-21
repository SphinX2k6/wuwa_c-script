using System;
using System.Collections.Generic;

namespace System.Buffers
{
	// Token: 0x02000392 RID: 914
	internal sealed class AsciiStringSearchValuesTeddyNonBucketizedN3<TStartCaseSensitivity, TCaseSensitivity> : AsciiStringSearchValuesTeddyBase<SearchValues.FalseConst, TStartCaseSensitivity, TCaseSensitivity> where TStartCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x06003C4B RID: 15435 RVA: 0x000C8FFD File Offset: 0x000C71FD
		public AsciiStringSearchValuesTeddyNonBucketizedN3(ReadOnlySpan<string> values, HashSet<string> uniqueValues) : base(values, uniqueValues, 3)
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x000C9008 File Offset: 0x000C7208
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return base.IndexOfAnyN3(span);
		}
	}
}

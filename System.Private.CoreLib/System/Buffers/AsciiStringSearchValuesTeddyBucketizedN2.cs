using System;
using System.Collections.Generic;

namespace System.Buffers
{
	// Token: 0x0200038F RID: 911
	internal sealed class AsciiStringSearchValuesTeddyBucketizedN2<TStartCaseSensitivity, TCaseSensitivity> : AsciiStringSearchValuesTeddyBase<SearchValues.TrueConst, TStartCaseSensitivity, TCaseSensitivity> where TStartCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x06003C45 RID: 15429 RVA: 0x000C8FBF File Offset: 0x000C71BF
		public AsciiStringSearchValuesTeddyBucketizedN2(string[][] buckets, ReadOnlySpan<string> values, HashSet<string> uniqueValues) : base(buckets, values, uniqueValues, 2)
		{
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x000C8FCB File Offset: 0x000C71CB
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return base.IndexOfAnyN2(span);
		}
	}
}

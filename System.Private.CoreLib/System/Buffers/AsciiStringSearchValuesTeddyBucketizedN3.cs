using System;
using System.Collections.Generic;

namespace System.Buffers
{
	// Token: 0x02000390 RID: 912
	internal sealed class AsciiStringSearchValuesTeddyBucketizedN3<TStartCaseSensitivity, TCaseSensitivity> : AsciiStringSearchValuesTeddyBase<SearchValues.TrueConst, TStartCaseSensitivity, TCaseSensitivity> where TStartCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x06003C47 RID: 15431 RVA: 0x000C8FD4 File Offset: 0x000C71D4
		public AsciiStringSearchValuesTeddyBucketizedN3(string[][] buckets, ReadOnlySpan<string> values, HashSet<string> uniqueValues) : base(buckets, values, uniqueValues, 3)
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x000C8FE0 File Offset: 0x000C71E0
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return base.IndexOfAnyN3(span);
		}
	}
}

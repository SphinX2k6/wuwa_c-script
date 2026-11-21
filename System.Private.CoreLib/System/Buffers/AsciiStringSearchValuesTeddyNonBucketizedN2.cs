using System;
using System.Collections.Generic;

namespace System.Buffers
{
	// Token: 0x02000391 RID: 913
	internal sealed class AsciiStringSearchValuesTeddyNonBucketizedN2<TStartCaseSensitivity, TCaseSensitivity> : AsciiStringSearchValuesTeddyBase<SearchValues.FalseConst, TStartCaseSensitivity, TCaseSensitivity> where TStartCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
	{
		// Token: 0x06003C49 RID: 15433 RVA: 0x000C8FE9 File Offset: 0x000C71E9
		public AsciiStringSearchValuesTeddyNonBucketizedN2(ReadOnlySpan<string> values, HashSet<string> uniqueValues) : base(values, uniqueValues, 2)
		{
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x000C8FF4 File Offset: 0x000C71F4
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			return base.IndexOfAnyN2(span);
		}
	}
}

using System;
using System.Collections.Generic;

namespace System.Buffers
{
	// Token: 0x02000394 RID: 916
	internal sealed class MultiStringIgnoreCaseSearchValuesFallback : StringSearchValuesBase
	{
		// Token: 0x06003C54 RID: 15444 RVA: 0x000C947B File Offset: 0x000C767B
		public MultiStringIgnoreCaseSearchValuesFallback(HashSet<string> uniqueValues) : base(uniqueValues)
		{
			this._values = new string[uniqueValues.Count];
			uniqueValues.CopyTo(this._values, 0);
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x000C94A4 File Offset: 0x000C76A4
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			string[] values = this._values;
			for (int i = 0; i < span.Length; i++)
			{
				ReadOnlySpan<char> span2 = span.Slice(i);
				foreach (string value in values)
				{
					if (span2.StartsWith(value, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x04000CB7 RID: 3255
		private readonly string[] _values;
	}
}

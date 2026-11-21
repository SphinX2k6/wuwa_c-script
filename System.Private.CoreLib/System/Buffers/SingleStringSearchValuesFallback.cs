using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000396 RID: 918
	internal sealed class SingleStringSearchValuesFallback<TIgnoreCase> : StringSearchValuesBase where TIgnoreCase : struct, SearchValues.IRuntimeConst
	{
		// Token: 0x06003C5E RID: 15454 RVA: 0x000C98F2 File Offset: 0x000C7AF2
		public SingleStringSearchValuesFallback(string value, HashSet<string> uniqueValues) : base(uniqueValues)
		{
			this._value = value;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x000C9902 File Offset: 0x000C7B02
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyMultiString(ReadOnlySpan<char> span)
		{
			if (!SearchValues.IRuntimeConst.Value)
			{
				return span.IndexOf(this._value);
			}
			return Ordinal.IndexOfOrdinalIgnoreCase(span, this._value);
		}

		// Token: 0x04000CBF RID: 3263
		private readonly string _value;
	}
}

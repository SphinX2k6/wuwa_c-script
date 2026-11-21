using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x020002E9 RID: 745
	public static class GlobalizationExtensions
	{
		// Token: 0x060036C9 RID: 14025 RVA: 0x000B36BD File Offset: 0x000B18BD
		[NullableContext(1)]
		public static StringComparer GetStringComparer(this CompareInfo compareInfo, CompareOptions options)
		{
			ArgumentNullException.ThrowIfNull(compareInfo, "compareInfo");
			if (options == CompareOptions.Ordinal)
			{
				return StringComparer.Ordinal;
			}
			if (options == CompareOptions.OrdinalIgnoreCase)
			{
				return StringComparer.OrdinalIgnoreCase;
			}
			return new CultureAwareComparer(compareInfo, options);
		}
	}
}

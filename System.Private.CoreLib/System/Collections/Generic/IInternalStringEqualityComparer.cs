using System;

namespace System.Collections.Generic
{
	// Token: 0x020009CF RID: 2511
	internal interface IInternalStringEqualityComparer : IEqualityComparer<string>
	{
		// Token: 0x06009333 RID: 37683
		IEqualityComparer<string> GetUnderlyingEqualityComparer();

		// Token: 0x06009334 RID: 37684 RVA: 0x0016F4FC File Offset: 0x0016D6FC
		internal static IEqualityComparer<string> GetUnderlyingEqualityComparer(IEqualityComparer<string> outerComparer)
		{
			IInternalStringEqualityComparer internalStringEqualityComparer = outerComparer as IInternalStringEqualityComparer;
			if (internalStringEqualityComparer != null)
			{
				return internalStringEqualityComparer.GetUnderlyingEqualityComparer();
			}
			return outerComparer;
		}
	}
}

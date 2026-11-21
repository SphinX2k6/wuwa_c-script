using System;
using System.Text;

namespace System.IO
{
	// Token: 0x020007E4 RID: 2020
	internal static class EncodingCache
	{
		// Token: 0x04001B15 RID: 6933
		internal static readonly Encoding UTF8NoBOM = new UTF8Encoding(false, true);
	}
}

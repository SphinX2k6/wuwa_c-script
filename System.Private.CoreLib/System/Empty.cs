using System;

namespace System
{
	// Token: 0x02000103 RID: 259
	internal sealed class Empty
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x00005ACC File Offset: 0x00003CCC
		private Empty()
		{
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00028E4B File Offset: 0x0002704B
		public override string ToString()
		{
			return string.Empty;
		}

		// Token: 0x0400039F RID: 927
		public static readonly Empty Value = new Empty();
	}
}

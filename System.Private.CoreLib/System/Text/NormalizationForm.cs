using System;
using System.Runtime.Versioning;

namespace System.Text
{
	// Token: 0x02000233 RID: 563
	public enum NormalizationForm
	{
		// Token: 0x0400078D RID: 1933
		FormC = 1,
		// Token: 0x0400078E RID: 1934
		FormD,
		// Token: 0x0400078F RID: 1935
		[UnsupportedOSPlatform("browser")]
		FormKC = 5,
		// Token: 0x04000790 RID: 1936
		[UnsupportedOSPlatform("browser")]
		FormKD
	}
}

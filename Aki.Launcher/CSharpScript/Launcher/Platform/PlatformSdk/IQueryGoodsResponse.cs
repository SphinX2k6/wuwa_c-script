using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200018A RID: 394
	[NullableContext(1)]
	[Nullable(0)]
	public class IQueryGoodsResponse
	{
		// Token: 0x040006F5 RID: 1781
		public List<IQueryGoodsResponseData> data;

		// Token: 0x040006F6 RID: 1782
		public int code;

		// Token: 0x040006F7 RID: 1783
		public string msg;

		// Token: 0x040006F8 RID: 1784
		public long timestamp;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000186 RID: 390
	[NullableContext(1)]
	[Nullable(0)]
	public class IQueryGoodsResponse
	{
		// Token: 0x040006BA RID: 1722
		public List<IQueryGoodsResponseData> data;

		// Token: 0x040006BB RID: 1723
		public int code;

		// Token: 0x040006BC RID: 1724
		public string msg;

		// Token: 0x040006BD RID: 1725
		public long timestamp;
	}
}

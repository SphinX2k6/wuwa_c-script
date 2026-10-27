using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025F RID: 607
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoginServersData
	{
		// Token: 0x040009DE RID: 2526
		public string name;

		// Token: 0x040009DF RID: 2527
		public string ip;

		// Token: 0x040009E0 RID: 2528
		public string id;

		// Token: 0x040009E1 RID: 2529
		public string Region;

		// Token: 0x040009E2 RID: 2530
		public string PingUrl;

		// Token: 0x040009E3 RID: 2531
		public ITDConfig TDCfg;

		// Token: 0x040009E4 RID: 2532
		public ITDConfig KDCfg;

		// Token: 0x040009E5 RID: 2533
		public List<string> LoginUrl;
	}
}

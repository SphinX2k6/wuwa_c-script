using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000264 RID: 612
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoginServersData
	{
		// Token: 0x04000A2A RID: 2602
		public string name;

		// Token: 0x04000A2B RID: 2603
		public string ip;

		// Token: 0x04000A2C RID: 2604
		public string id;

		// Token: 0x04000A2D RID: 2605
		public string Region;

		// Token: 0x04000A2E RID: 2606
		public string PingUrl;

		// Token: 0x04000A2F RID: 2607
		public ITDConfig TDCfg;

		// Token: 0x04000A30 RID: 2608
		public ITDConfig KDCfg;

		// Token: 0x04000A31 RID: 2609
		public List<string> LoginUrl;
	}
}

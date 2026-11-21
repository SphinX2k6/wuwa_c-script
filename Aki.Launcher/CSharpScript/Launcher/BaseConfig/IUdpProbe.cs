using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000271 RID: 625
	public class IUdpProbe
	{
		// Token: 0x04000A4D RID: 2637
		[Nullable(1)]
		public string ip;

		// Token: 0x04000A4E RID: 2638
		public int port;

		// Token: 0x04000A4F RID: 2639
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> ext;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200026A RID: 618
	public class IUdpProbe
	{
		// Token: 0x040009FF RID: 2559
		[Nullable(1)]
		public string ip;

		// Token: 0x04000A00 RID: 2560
		public int port;

		// Token: 0x04000A01 RID: 2561
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> ext;
	}
}

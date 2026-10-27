using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200026B RID: 619
	public class IUdpRegion
	{
		// Token: 0x04000A02 RID: 2562
		[Nullable(1)]
		public List<IUdpProbe> Probe;

		// Token: 0x04000A03 RID: 2563
		public int ProbeInterval;

		// Token: 0x04000A04 RID: 2564
		public bool ProbeOpen;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000272 RID: 626
	public class IUdpRegion
	{
		// Token: 0x04000A50 RID: 2640
		[Nullable(1)]
		public List<IUdpProbe> Probe;

		// Token: 0x04000A51 RID: 2641
		public int ProbeInterval;

		// Token: 0x04000A52 RID: 2642
		public bool ProbeOpen;
	}
}

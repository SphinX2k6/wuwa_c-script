using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004552 RID: 17746
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalCapturePerformanceConfig
	{
		// Token: 0x0602DD8D RID: 187789 RVA: 0x00A8A757 File Offset: 0x00A88957
		public PortalCapturePerformanceConfig(PortalPlatformCaptureConfig pc, PortalPlatformCaptureConfig mobile)
		{
		}

		// Token: 0x040187B5 RID: 100277
		public PortalPlatformCaptureConfig Pc = pc;

		// Token: 0x040187B6 RID: 100278
		public PortalPlatformCaptureConfig Mobile = mobile;
	}
}

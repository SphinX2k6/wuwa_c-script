using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200347A RID: 13434
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalCapturePerformanceConfig
	{
		// Token: 0x0602246F RID: 140399 RVA: 0x009B5C87 File Offset: 0x009B3E87
		public PortalCapturePerformanceConfig(PortalPlatformCaptureConfig pc, PortalPlatformCaptureConfig mobile)
		{
		}

		// Token: 0x04012DEF RID: 77295
		public PortalPlatformCaptureConfig Pc = pc;

		// Token: 0x04012DF0 RID: 77296
		public PortalPlatformCaptureConfig Mobile = mobile;
	}
}

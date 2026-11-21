using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000152 RID: 338
	public class PlatformReportSdkInitFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x00046F1E File Offset: 0x0004511E
		public PlatformReportSdkInitFail()
		{
			this.event_id = 60110;
			this.event_name = "krsdk_init_fail";
		}

		// Token: 0x04000670 RID: 1648
		[Nullable(1)]
		public string code = "";
	}
}

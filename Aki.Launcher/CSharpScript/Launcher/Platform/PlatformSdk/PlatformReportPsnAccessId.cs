using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000151 RID: 337
	public class PlatformReportPsnAccessId : PlatformSdkReportBaseData
	{
		// Token: 0x06000A53 RID: 2643 RVA: 0x00044B6F File Offset: 0x00042D6F
		public PlatformReportPsnAccessId()
		{
			this.event_id = 60114;
			this.event_name = "get_psnaccessid";
		}
	}
}

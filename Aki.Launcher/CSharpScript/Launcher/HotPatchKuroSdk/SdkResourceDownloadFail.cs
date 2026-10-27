using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F0 RID: 496
	public class SdkResourceDownloadFail : SdkReportData
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x0004E72F File Offset: 0x0004C92F
		public SdkResourceDownloadFail([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0004E738 File Offset: 0x0004C938
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Resource_Download_Fail";
		}
	}
}

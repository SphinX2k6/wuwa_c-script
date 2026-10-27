using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EE RID: 494
	public class SdkResourceDownloadStart : SdkReportData
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x0004E6F3 File Offset: 0x0004C8F3
		public SdkResourceDownloadStart([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0004E6FC File Offset: 0x0004C8FC
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Resource_Download_Start";
		}
	}
}

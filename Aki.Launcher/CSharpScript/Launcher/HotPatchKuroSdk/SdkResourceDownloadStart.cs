using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F3 RID: 499
	public class SdkResourceDownloadStart : SdkReportData
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x000511DF File Offset: 0x0004F3DF
		public SdkResourceDownloadStart([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000511E8 File Offset: 0x0004F3E8
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

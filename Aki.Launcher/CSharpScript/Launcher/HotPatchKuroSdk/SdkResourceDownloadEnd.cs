using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F4 RID: 500
	public class SdkResourceDownloadEnd : SdkReportData
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x000511FD File Offset: 0x0004F3FD
		public SdkResourceDownloadEnd([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00051206 File Offset: 0x0004F406
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Resource_Download_End";
		}
	}
}

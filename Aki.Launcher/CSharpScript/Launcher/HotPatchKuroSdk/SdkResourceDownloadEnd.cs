using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EF RID: 495
	public class SdkResourceDownloadEnd : SdkReportData
	{
		// Token: 0x06000CF1 RID: 3313 RVA: 0x0004E711 File Offset: 0x0004C911
		public SdkResourceDownloadEnd([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0004E71A File Offset: 0x0004C91A
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

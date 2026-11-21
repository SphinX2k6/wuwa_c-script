using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F5 RID: 501
	public class SdkResourceDownloadFail : SdkReportData
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x0005121B File Offset: 0x0004F41B
		public SdkResourceDownloadFail([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00051224 File Offset: 0x0004F424
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

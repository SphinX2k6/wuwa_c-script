using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EF RID: 495
	public class SdkLogoReportData : SdkReportData
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x00051167 File Offset: 0x0004F367
		public SdkLogoReportData([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00051170 File Offset: 0x0004F370
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Logo";
		}
	}
}

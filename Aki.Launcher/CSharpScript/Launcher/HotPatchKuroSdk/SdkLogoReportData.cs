using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EA RID: 490
	public class SdkLogoReportData : SdkReportData
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x0004E67B File Offset: 0x0004C87B
		public SdkLogoReportData([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0004E684 File Offset: 0x0004C884
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

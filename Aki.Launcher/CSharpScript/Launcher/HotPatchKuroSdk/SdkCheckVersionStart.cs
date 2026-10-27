using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EB RID: 491
	public class SdkCheckVersionStart : SdkReportData
	{
		// Token: 0x06000CE9 RID: 3305 RVA: 0x0004E699 File Offset: 0x0004C899
		public SdkCheckVersionStart([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0004E6A2 File Offset: 0x0004C8A2
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Version_Checking_Start";
		}
	}
}

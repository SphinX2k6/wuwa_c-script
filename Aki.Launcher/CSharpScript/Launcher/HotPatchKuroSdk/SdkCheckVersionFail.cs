using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001ED RID: 493
	public class SdkCheckVersionFail : SdkReportData
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x0004E6D5 File Offset: 0x0004C8D5
		public SdkCheckVersionFail([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0004E6DE File Offset: 0x0004C8DE
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Version_Checking_Fail";
		}
	}
}

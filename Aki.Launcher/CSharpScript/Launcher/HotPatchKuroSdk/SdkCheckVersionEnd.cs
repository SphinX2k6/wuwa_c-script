using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EC RID: 492
	public class SdkCheckVersionEnd : SdkReportData
	{
		// Token: 0x06000CEB RID: 3307 RVA: 0x0004E6B7 File Offset: 0x0004C8B7
		public SdkCheckVersionEnd([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0004E6C0 File Offset: 0x0004C8C0
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (!this.IfGlobalSdk)
			{
				return "";
			}
			return "Version_Checking_End";
		}
	}
}

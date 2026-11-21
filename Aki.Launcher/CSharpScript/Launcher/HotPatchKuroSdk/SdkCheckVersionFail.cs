using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F2 RID: 498
	public class SdkCheckVersionFail : SdkReportData
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x000511C1 File Offset: 0x0004F3C1
		public SdkCheckVersionFail([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000511CA File Offset: 0x0004F3CA
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

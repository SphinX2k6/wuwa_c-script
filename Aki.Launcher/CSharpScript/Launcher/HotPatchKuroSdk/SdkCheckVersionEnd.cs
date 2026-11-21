using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F1 RID: 497
	public class SdkCheckVersionEnd : SdkReportData
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x000511A3 File Offset: 0x0004F3A3
		public SdkCheckVersionEnd([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000511AC File Offset: 0x0004F3AC
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

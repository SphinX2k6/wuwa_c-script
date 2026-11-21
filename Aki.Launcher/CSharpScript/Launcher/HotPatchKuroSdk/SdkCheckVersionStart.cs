using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001F0 RID: 496
	public class SdkCheckVersionStart : SdkReportData
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x00051185 File Offset: 0x0004F385
		public SdkCheckVersionStart([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0005118E File Offset: 0x0004F38E
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

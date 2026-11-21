using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

namespace CSharpScript.Launcher
{
	// Token: 0x0200005D RID: 93
	public class SdkGameLoadComplete : SdkReportData
	{
		// Token: 0x06000294 RID: 660 RVA: 0x0000D6BA File Offset: 0x0000B8BA
		public SdkGameLoadComplete([Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> eventData) : base(eventData)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000D6C3 File Offset: 0x0000B8C3
		[NullableContext(1)]
		public override string GetEventName()
		{
			if (this.IfGlobalSdk)
			{
				return "game_load_complete";
			}
			return "";
		}
	}
}

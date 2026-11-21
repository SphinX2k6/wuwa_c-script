using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002F1 RID: 753
public class SdkReportGetRougeLevel60 : SdkReportData
{
	// Token: 0x06002B36 RID: 11062 RVA: 0x0010414A File Offset: 0x0010234A
	public SdkReportGetRougeLevel60([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x00104153 File Offset: 0x00102353
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "rogue_level60";
		}
		return "";
	}
}

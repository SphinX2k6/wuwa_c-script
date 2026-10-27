using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E3C RID: 3644
public class SdkReportGetRougeLevel60 : SdkReportData
{
	// Token: 0x060057A6 RID: 22438 RVA: 0x000FC8CE File Offset: 0x000FAACE
	public SdkReportGetRougeLevel60([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x000FC8D7 File Offset: 0x000FAAD7
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

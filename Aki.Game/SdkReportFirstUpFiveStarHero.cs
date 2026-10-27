using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E3E RID: 3646
public class SdkReportFirstUpFiveStarHero : SdkReportData
{
	// Token: 0x060057AA RID: 22442 RVA: 0x000FC90A File Offset: 0x000FAB0A
	public SdkReportFirstUpFiveStarHero([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x060057AB RID: 22443 RVA: 0x000FC913 File Offset: 0x000FAB13
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "first_up_5star_hero";
		}
		return "";
	}
}

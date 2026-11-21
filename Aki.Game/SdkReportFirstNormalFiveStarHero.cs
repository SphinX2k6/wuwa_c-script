using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002F2 RID: 754
public class SdkReportFirstNormalFiveStarHero : SdkReportData
{
	// Token: 0x06002B38 RID: 11064 RVA: 0x00104168 File Offset: 0x00102368
	public SdkReportFirstNormalFiveStarHero([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x00104171 File Offset: 0x00102371
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "first_normal_5star_hero";
		}
		return "";
	}
}

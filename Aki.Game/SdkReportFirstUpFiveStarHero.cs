using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002F3 RID: 755
public class SdkReportFirstUpFiveStarHero : SdkReportData
{
	// Token: 0x06002B3A RID: 11066 RVA: 0x00104186 File Offset: 0x00102386
	public SdkReportFirstUpFiveStarHero([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x0010418F File Offset: 0x0010238F
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

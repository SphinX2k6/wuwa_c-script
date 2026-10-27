using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E3D RID: 3645
public class SdkReportFirstNormalFiveStarHero : SdkReportData
{
	// Token: 0x060057A8 RID: 22440 RVA: 0x000FC8EC File Offset: 0x000FAAEC
	public SdkReportFirstNormalFiveStarHero([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x060057A9 RID: 22441 RVA: 0x000FC8F5 File Offset: 0x000FAAF5
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

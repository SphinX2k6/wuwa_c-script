using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E5 RID: 741
public class SdkReportOpenPrivacy : SdkReportData
{
	// Token: 0x06002AF8 RID: 11000 RVA: 0x00103846 File Offset: 0x00101A46
	public SdkReportOpenPrivacy([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x0010384F File Offset: 0x00101A4F
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Game_Privacy";
		}
		return "";
	}
}

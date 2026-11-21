using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E4 RID: 740
public class SdkReportGameInitFinish : SdkReportData
{
	// Token: 0x06002AF6 RID: 10998 RVA: 0x00103828 File Offset: 0x00101A28
	public SdkReportGameInitFinish([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x00103831 File Offset: 0x00101A31
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Game_Initialize";
		}
		return "";
	}
}

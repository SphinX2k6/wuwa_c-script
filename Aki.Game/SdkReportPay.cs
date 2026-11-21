using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002ED RID: 749
public class SdkReportPay : SdkReportData
{
	// Token: 0x06002B1D RID: 11037 RVA: 0x00103D1F File Offset: 0x00101F1F
	public SdkReportPay([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B1E RID: 11038 RVA: 0x00103D28 File Offset: 0x00101F28
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "";
		}
		return "event_4";
	}
}

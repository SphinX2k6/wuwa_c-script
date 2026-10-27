using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E38 RID: 3640
public class SdkReportPay : SdkReportData
{
	// Token: 0x0600578D RID: 22413 RVA: 0x000FC4CB File Offset: 0x000FA6CB
	public SdkReportPay([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x0600578E RID: 22414 RVA: 0x000FC4D4 File Offset: 0x000FA6D4
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

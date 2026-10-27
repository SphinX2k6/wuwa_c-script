using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E32 RID: 3634
[NullableContext(1)]
[Nullable(0)]
public class SdkReportCreateRole : SdkReportData
{
	// Token: 0x0600576C RID: 22380 RVA: 0x000FC02E File Offset: 0x000FA22E
	public SdkReportCreateRole([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x0600576D RID: 22381 RVA: 0x000FC037 File Offset: 0x000FA237
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Completed_Registration";
		}
		return "event_1";
	}

	// Token: 0x0600576E RID: 22382 RVA: 0x000FC04C File Offset: 0x000FA24C
	protected override string GetEventDataJson()
	{
		if (this.IfGlobalSdk)
		{
			this.EventData = new Dictionary<string, string>();
			this.EventData["eventId"] = "101104";
			return base.GetEventDataJson();
		}
		this.EventData = new Dictionary<string, string>();
		this.EventData["param1"] = "101104";
		return base.GetEventDataJson();
	}
}

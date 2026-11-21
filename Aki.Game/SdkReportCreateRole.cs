using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E7 RID: 743
[NullableContext(1)]
[Nullable(0)]
public class SdkReportCreateRole : SdkReportData
{
	// Token: 0x06002AFC RID: 11004 RVA: 0x00103882 File Offset: 0x00101A82
	public SdkReportCreateRole([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002AFD RID: 11005 RVA: 0x0010388B File Offset: 0x00101A8B
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Completed_Registration";
		}
		return "event_1";
	}

	// Token: 0x06002AFE RID: 11006 RVA: 0x001038A0 File Offset: 0x00101AA0
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

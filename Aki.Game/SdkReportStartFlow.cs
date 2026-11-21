using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002EB RID: 747
[NullableContext(1)]
[Nullable(0)]
public class SdkReportStartFlow : SdkReportData
{
	// Token: 0x06002B11 RID: 11025 RVA: 0x00103B6B File Offset: 0x00101D6B
	public SdkReportStartFlow([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B12 RID: 11026 RVA: 0x00103B74 File Offset: 0x00101D74
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Anime_end";
		}
		return "";
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x00103B89 File Offset: 0x00101D89
	public static bool IfNeedReport(int flowId, int stateId)
	{
		return flowId == 1 && stateId == 1;
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x00103B98 File Offset: 0x00101D98
	protected override string GetEventDataJson()
	{
		this.EventData = new Dictionary<string, string>();
		this.EventData["eventId"] = "123000";
		this.EventData["FlowId"] = this.FlowId.ToString();
		return base.GetEventDataJson();
	}

	// Token: 0x04002900 RID: 10496
	public int FlowId;
}

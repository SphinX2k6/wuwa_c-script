using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E36 RID: 3638
[NullableContext(1)]
[Nullable(0)]
public class SdkReportStartFlow : SdkReportData
{
	// Token: 0x06005781 RID: 22401 RVA: 0x000FC317 File Offset: 0x000FA517
	public SdkReportStartFlow([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005782 RID: 22402 RVA: 0x000FC320 File Offset: 0x000FA520
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Anime_end";
		}
		return "";
	}

	// Token: 0x06005783 RID: 22403 RVA: 0x000FC335 File Offset: 0x000FA535
	public static bool IfNeedReport(int flowId, int stateId)
	{
		return flowId == 1 && stateId == 1;
	}

	// Token: 0x06005784 RID: 22404 RVA: 0x000FC344 File Offset: 0x000FA544
	protected override string GetEventDataJson()
	{
		this.EventData = new Dictionary<string, string>();
		this.EventData["eventId"] = "123000";
		this.EventData["FlowId"] = this.FlowId.ToString();
		return base.GetEventDataJson();
	}

	// Token: 0x04002867 RID: 10343
	public int FlowId;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E33 RID: 3635
public class SdkReportClickEnterGame : SdkReportData
{
	// Token: 0x0600576F RID: 22383 RVA: 0x000FC0AE File Offset: 0x000FA2AE
	public SdkReportClickEnterGame([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005770 RID: 22384 RVA: 0x000FC0B7 File Offset: 0x000FA2B7
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "click_entergame";
		}
		return "event_2";
	}
}

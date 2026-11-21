using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E8 RID: 744
public class SdkReportClickEnterGame : SdkReportData
{
	// Token: 0x06002AFF RID: 11007 RVA: 0x00103902 File Offset: 0x00101B02
	public SdkReportClickEnterGame([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B00 RID: 11008 RVA: 0x0010390B File Offset: 0x00101B0B
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

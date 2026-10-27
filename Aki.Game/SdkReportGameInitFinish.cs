using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E2F RID: 3631
public class SdkReportGameInitFinish : SdkReportData
{
	// Token: 0x06005766 RID: 22374 RVA: 0x000FBFD4 File Offset: 0x000FA1D4
	public SdkReportGameInitFinish([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005767 RID: 22375 RVA: 0x000FBFDD File Offset: 0x000FA1DD
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

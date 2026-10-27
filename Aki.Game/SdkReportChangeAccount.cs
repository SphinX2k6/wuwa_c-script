using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E31 RID: 3633
public class SdkReportChangeAccount : SdkReportData
{
	// Token: 0x0600576A RID: 22378 RVA: 0x000FC010 File Offset: 0x000FA210
	public SdkReportChangeAccount([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x0600576B RID: 22379 RVA: 0x000FC019 File Offset: 0x000FA219
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Change_account";
		}
		return "";
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E6 RID: 742
public class SdkReportChangeAccount : SdkReportData
{
	// Token: 0x06002AFA RID: 11002 RVA: 0x00103864 File Offset: 0x00101A64
	public SdkReportChangeAccount([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002AFB RID: 11003 RVA: 0x0010386D File Offset: 0x00101A6D
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

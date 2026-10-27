using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E30 RID: 3632
public class SdkReportOpenPrivacy : SdkReportData
{
	// Token: 0x06005768 RID: 22376 RVA: 0x000FBFF2 File Offset: 0x000FA1F2
	public SdkReportOpenPrivacy([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005769 RID: 22377 RVA: 0x000FBFFB File Offset: 0x000FA1FB
	[NullableContext(1)]
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return "Game_Privacy";
		}
		return "";
	}
}

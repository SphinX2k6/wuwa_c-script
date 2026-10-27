using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020020AD RID: 8365
[NullableContext(1)]
[Nullable(0)]
public class CommonLogData
{
	// Token: 0x1700145D RID: 5213
	// (get) Token: 0x06010851 RID: 67665 RVA: 0x00409EF8 File Offset: 0x004080F8
	// (set) Token: 0x06010852 RID: 67666 RVA: 0x00409F00 File Offset: 0x00408100
	public virtual string event_id { get; set; } = "";

	// Token: 0x06010853 RID: 67667 RVA: 0x00409F0C File Offset: 0x0040810C
	public CommonLogData()
	{
		this.event_uuid = UKismetGuidLibrary.NewGuid().ToString();
	}

	// Token: 0x04007A22 RID: 31266
	public string event_uuid = "";

	// Token: 0x04007A23 RID: 31267
	public string client_version = "";

	// Token: 0x04007A24 RID: 31268
	public string project_id = "Aki";

	// Token: 0x04007A25 RID: 31269
	public string platform = "";
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001584 RID: 5508
[NullableContext(1)]
[Nullable(0)]
public class CommonLogData
{
	// Token: 0x1700148A RID: 5258
	// (get) Token: 0x0600DCC1 RID: 56513 RVA: 0x00416600 File Offset: 0x00414800
	// (set) Token: 0x0600DCC2 RID: 56514 RVA: 0x00416608 File Offset: 0x00414808
	public virtual string event_id { get; set; } = "";

	// Token: 0x0600DCC3 RID: 56515 RVA: 0x00416614 File Offset: 0x00414814
	public CommonLogData()
	{
		this.event_uuid = UKismetGuidLibrary.NewGuid().ToString();
	}

	// Token: 0x04007B20 RID: 31520
	public string event_uuid = "";

	// Token: 0x04007B21 RID: 31521
	public string client_version = "";

	// Token: 0x04007B22 RID: 31522
	public string project_id = "Aki";

	// Token: 0x04007B23 RID: 31523
	public string platform = "";
}

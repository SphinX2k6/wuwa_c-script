using System;
using System.Runtime.CompilerServices;

// Token: 0x020015FE RID: 5630
[NullableContext(1)]
[Nullable(0)]
public class UiInteractSpaceKeyLogEvent : PlayerCommonLogData
{
	// Token: 0x170014FA RID: 5370
	// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x00418080 File Offset: 0x00416280
	// (set) Token: 0x0600DE22 RID: 56866 RVA: 0x00418088 File Offset: 0x00416288
	public override string event_id { get; set; } = "1806";

	// Token: 0x04007E1D RID: 32285
	public int i_type;

	// Token: 0x04007E1E RID: 32286
	public int i_status;
}

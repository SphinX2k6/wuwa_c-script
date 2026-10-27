using System;
using System.Runtime.CompilerServices;

// Token: 0x02002105 RID: 8453
[NullableContext(1)]
[Nullable(0)]
public class CiacconaEnterMainViewLogEvent : PlayerCommonLogData
{
	// Token: 0x170014AB RID: 5291
	// (get) Token: 0x0601094B RID: 67915 RVA: 0x0040B2D1 File Offset: 0x004094D1
	// (set) Token: 0x0601094C RID: 67916 RVA: 0x0040B2D9 File Offset: 0x004094D9
	public override string event_id { get; set; } = "156003";

	// Token: 0x0601094D RID: 67917 RVA: 0x0040B2E2 File Offset: 0x004094E2
	public CiacconaEnterMainViewLogEvent(int triggerType)
	{
		this.i_trigger_type = triggerType;
	}

	// Token: 0x04007C73 RID: 31859
	public int i_trigger_type;
}

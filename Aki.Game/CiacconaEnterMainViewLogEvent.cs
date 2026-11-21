using System;
using System.Runtime.CompilerServices;

// Token: 0x020015DD RID: 5597
[NullableContext(1)]
[Nullable(0)]
public class CiacconaEnterMainViewLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D9 RID: 5337
	// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x00417A05 File Offset: 0x00415C05
	// (set) Token: 0x0600DDBF RID: 56767 RVA: 0x00417A0D File Offset: 0x00415C0D
	public override string event_id { get; set; } = "156003";

	// Token: 0x0600DDC0 RID: 56768 RVA: 0x00417A16 File Offset: 0x00415C16
	public CiacconaEnterMainViewLogEvent(int triggerType)
	{
		this.i_trigger_type = triggerType;
	}

	// Token: 0x04007D75 RID: 32117
	public int i_trigger_type;
}

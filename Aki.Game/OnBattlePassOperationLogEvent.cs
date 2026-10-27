using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F8 RID: 8440
[NullableContext(1)]
[Nullable(0)]
public class OnBattlePassOperationLogEvent : PlayerCommonLogData
{
	// Token: 0x1700149E RID: 5278
	// (get) Token: 0x06010924 RID: 67876 RVA: 0x0040B0C3 File Offset: 0x004092C3
	// (set) Token: 0x06010925 RID: 67877 RVA: 0x0040B0CB File Offset: 0x004092CB
	public override string event_id { get; set; } = "1832";

	// Token: 0x04007C4B RID: 31819
	public int i_operation_type;
}

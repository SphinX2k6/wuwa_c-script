using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F7 RID: 8439
[NullableContext(1)]
[Nullable(0)]
public class OnClickBattlePassTabViewLogEvent : PlayerCommonLogData
{
	// Token: 0x1700149D RID: 5277
	// (get) Token: 0x06010921 RID: 67873 RVA: 0x0040B09F File Offset: 0x0040929F
	// (set) Token: 0x06010922 RID: 67874 RVA: 0x0040B0A7 File Offset: 0x004092A7
	public override string event_id { get; set; } = "1831";

	// Token: 0x04007C49 RID: 31817
	public int i_tabIndex;
}

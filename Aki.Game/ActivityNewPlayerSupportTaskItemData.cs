using System;
using System.Runtime.CompilerServices;

// Token: 0x02000870 RID: 2160
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportTaskItemData : IActivityNewPlayerSupportTaskItemData
{
	// Token: 0x17000C17 RID: 3095
	// (get) Token: 0x06006216 RID: 25110 RVA: 0x001F490B File Offset: 0x001F2B0B
	// (set) Token: 0x06006217 RID: 25111 RVA: 0x001F4913 File Offset: 0x001F2B13
	public ActivityNewPlayerSupportTaskData TaskData { get; set; }

	// Token: 0x17000C18 RID: 3096
	// (get) Token: 0x06006218 RID: 25112 RVA: 0x001F491C File Offset: 0x001F2B1C
	// (set) Token: 0x06006219 RID: 25113 RVA: 0x001F4924 File Offset: 0x001F2B24
	public bool ShowDecoration { get; set; }
}

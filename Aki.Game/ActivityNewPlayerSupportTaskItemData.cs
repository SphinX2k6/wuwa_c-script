using System;
using System.Runtime.CompilerServices;

// Token: 0x020013BC RID: 5052
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportTaskItemData : IActivityNewPlayerSupportTaskItemData
{
	// Token: 0x17000BF7 RID: 3063
	// (get) Token: 0x06008E81 RID: 36481 RVA: 0x001EBDEB File Offset: 0x001E9FEB
	// (set) Token: 0x06008E82 RID: 36482 RVA: 0x001EBDF3 File Offset: 0x001E9FF3
	public ActivityNewPlayerSupportTaskData TaskData { get; set; }

	// Token: 0x17000BF8 RID: 3064
	// (get) Token: 0x06008E83 RID: 36483 RVA: 0x001EBDFC File Offset: 0x001E9FFC
	// (set) Token: 0x06008E84 RID: 36484 RVA: 0x001EBE04 File Offset: 0x001EA004
	public bool ShowDecoration { get; set; }
}

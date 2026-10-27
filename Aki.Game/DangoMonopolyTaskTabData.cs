using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200122F RID: 4655
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyTaskTabData : IDangoMonopolyTaskTabData
{
	// Token: 0x17000A9C RID: 2716
	// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x001AAD42 File Offset: 0x001A8F42
	// (set) Token: 0x06007DD7 RID: 32215 RVA: 0x001AAD4A File Offset: 0x001A8F4A
	public EDangoMonopolyTaskType TaskType { get; set; }

	// Token: 0x17000A9D RID: 2717
	// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x001AAD53 File Offset: 0x001A8F53
	// (set) Token: 0x06007DD9 RID: 32217 RVA: 0x001AAD5B File Offset: 0x001A8F5B
	public string TaskTypeName { get; set; } = "";

	// Token: 0x17000A9E RID: 2718
	// (get) Token: 0x06007DDA RID: 32218 RVA: 0x001AAD64 File Offset: 0x001A8F64
	// (set) Token: 0x06007DDB RID: 32219 RVA: 0x001AAD6C File Offset: 0x001A8F6C
	public IReadOnlyList<DangoMonopolyTaskData> TaskList { get; set; } = Array.Empty<DangoMonopolyTaskData>();

	// Token: 0x17000A9F RID: 2719
	// (get) Token: 0x06007DDC RID: 32220 RVA: 0x001AAD75 File Offset: 0x001A8F75
	// (set) Token: 0x06007DDD RID: 32221 RVA: 0x001AAD7D File Offset: 0x001A8F7D
	public long EndTime { get; set; }
}

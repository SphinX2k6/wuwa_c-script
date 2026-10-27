using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200241E RID: 9246
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerEditPopInfo : IPhantomManagerEditPopInfo
{
	// Token: 0x17001802 RID: 6146
	// (get) Token: 0x0601281B RID: 75803 RVA: 0x0048F524 File Offset: 0x0048D724
	// (set) Token: 0x0601281C RID: 75804 RVA: 0x0048F52C File Offset: 0x0048D72C
	public int FetterId { get; set; }

	// Token: 0x17001803 RID: 6147
	// (get) Token: 0x0601281D RID: 75805 RVA: 0x0048F535 File Offset: 0x0048D735
	// (set) Token: 0x0601281E RID: 75806 RVA: 0x0048F53D File Offset: 0x0048D73D
	public int Count { get; set; }

	// Token: 0x17001804 RID: 6148
	// (get) Token: 0x0601281F RID: 75807 RVA: 0x0048F546 File Offset: 0x0048D746
	// (set) Token: 0x06012820 RID: 75808 RVA: 0x0048F54E File Offset: 0x0048D74E
	public List<IPhantomManagerConfigNewSettingInfo> DataList { get; set; } = new List<IPhantomManagerConfigNewSettingInfo>();

	// Token: 0x17001805 RID: 6149
	// (get) Token: 0x06012821 RID: 75809 RVA: 0x0048F557 File Offset: 0x0048D757
	// (set) Token: 0x06012822 RID: 75810 RVA: 0x0048F55F File Offset: 0x0048D75F
	[Nullable(2)]
	public Action CloseCb { [NullableContext(2)] get; [NullableContext(2)] set; }
}

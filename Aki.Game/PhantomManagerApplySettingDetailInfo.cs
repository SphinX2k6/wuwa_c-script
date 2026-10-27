using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200241C RID: 9244
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerApplySettingDetailInfo : IPhantomManagerApplySettingDetailInfo
{
	// Token: 0x170017FC RID: 6140
	// (get) Token: 0x0601280E RID: 75790 RVA: 0x0048F4E4 File Offset: 0x0048D6E4
	// (set) Token: 0x0601280F RID: 75791 RVA: 0x0048F4EC File Offset: 0x0048D6EC
	public List<PhantomItemData> DiscardList { get; set; } = new List<PhantomItemData>();

	// Token: 0x170017FD RID: 6141
	// (get) Token: 0x06012810 RID: 75792 RVA: 0x0048F4F5 File Offset: 0x0048D6F5
	// (set) Token: 0x06012811 RID: 75793 RVA: 0x0048F4FD File Offset: 0x0048D6FD
	public List<PhantomItemData> LockList { get; set; } = new List<PhantomItemData>();
}

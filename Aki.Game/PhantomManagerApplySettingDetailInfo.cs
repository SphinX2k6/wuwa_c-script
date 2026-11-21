using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001901 RID: 6401
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerApplySettingDetailInfo : IPhantomManagerApplySettingDetailInfo
{
	// Token: 0x17001836 RID: 6198
	// (get) Token: 0x0600FCC4 RID: 64708 RVA: 0x0049CB00 File Offset: 0x0049AD00
	// (set) Token: 0x0600FCC5 RID: 64709 RVA: 0x0049CB08 File Offset: 0x0049AD08
	public List<PhantomItemData> DiscardList { get; set; } = new List<PhantomItemData>();

	// Token: 0x17001837 RID: 6199
	// (get) Token: 0x0600FCC6 RID: 64710 RVA: 0x0049CB11 File Offset: 0x0049AD11
	// (set) Token: 0x0600FCC7 RID: 64711 RVA: 0x0049CB19 File Offset: 0x0049AD19
	public List<PhantomItemData> LockList { get; set; } = new List<PhantomItemData>();
}

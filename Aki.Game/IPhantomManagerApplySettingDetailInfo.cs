using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001900 RID: 6400
[NullableContext(1)]
public interface IPhantomManagerApplySettingDetailInfo
{
	// Token: 0x17001834 RID: 6196
	// (get) Token: 0x0600FCC0 RID: 64704
	// (set) Token: 0x0600FCC1 RID: 64705
	List<PhantomItemData> DiscardList { get; set; }

	// Token: 0x17001835 RID: 6197
	// (get) Token: 0x0600FCC2 RID: 64706
	// (set) Token: 0x0600FCC3 RID: 64707
	List<PhantomItemData> LockList { get; set; }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200241B RID: 9243
[NullableContext(1)]
public interface IPhantomManagerApplySettingDetailInfo
{
	// Token: 0x170017FA RID: 6138
	// (get) Token: 0x0601280A RID: 75786
	// (set) Token: 0x0601280B RID: 75787
	List<PhantomItemData> DiscardList { get; set; }

	// Token: 0x170017FB RID: 6139
	// (get) Token: 0x0601280C RID: 75788
	// (set) Token: 0x0601280D RID: 75789
	List<PhantomItemData> LockList { get; set; }
}

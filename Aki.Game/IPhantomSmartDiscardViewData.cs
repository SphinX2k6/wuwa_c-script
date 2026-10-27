using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FE0 RID: 8160
[NullableContext(2)]
public interface IPhantomSmartDiscardViewData
{
	// Token: 0x1700135F RID: 4959
	// (get) Token: 0x0600FFC3 RID: 65475
	// (set) Token: 0x0600FFC4 RID: 65476
	Action OnConfirm { get; set; }

	// Token: 0x17001360 RID: 4960
	// (get) Token: 0x0600FFC5 RID: 65477
	// (set) Token: 0x0600FFC6 RID: 65478
	Action OnCancel { get; set; }
}

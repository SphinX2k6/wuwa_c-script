using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FE1 RID: 8161
[NullableContext(2)]
[Nullable(0)]
public class PhantomSmartDiscardViewData : IPhantomSmartDiscardViewData
{
	// Token: 0x17001361 RID: 4961
	// (get) Token: 0x0600FFC7 RID: 65479 RVA: 0x003E4A41 File Offset: 0x003E2C41
	// (set) Token: 0x0600FFC8 RID: 65480 RVA: 0x003E4A49 File Offset: 0x003E2C49
	public Action OnConfirm { get; set; }

	// Token: 0x17001362 RID: 4962
	// (get) Token: 0x0600FFC9 RID: 65481 RVA: 0x003E4A52 File Offset: 0x003E2C52
	// (set) Token: 0x0600FFCA RID: 65482 RVA: 0x003E4A5A File Offset: 0x003E2C5A
	public Action OnCancel { get; set; }
}

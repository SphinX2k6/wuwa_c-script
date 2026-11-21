using System;
using System.Runtime.CompilerServices;

// Token: 0x020014B3 RID: 5299
[NullableContext(2)]
public interface IPhantomSmartDiscardViewData
{
	// Token: 0x1700138C RID: 5004
	// (get) Token: 0x0600D42B RID: 54315
	// (set) Token: 0x0600D42C RID: 54316
	Action OnConfirm { get; set; }

	// Token: 0x1700138D RID: 5005
	// (get) Token: 0x0600D42D RID: 54317
	// (set) Token: 0x0600D42E RID: 54318
	Action OnCancel { get; set; }
}

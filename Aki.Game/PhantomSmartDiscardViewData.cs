using System;
using System.Runtime.CompilerServices;

// Token: 0x020014B4 RID: 5300
[NullableContext(2)]
[Nullable(0)]
public class PhantomSmartDiscardViewData : IPhantomSmartDiscardViewData
{
	// Token: 0x1700138E RID: 5006
	// (get) Token: 0x0600D42F RID: 54319 RVA: 0x003F1041 File Offset: 0x003EF241
	// (set) Token: 0x0600D430 RID: 54320 RVA: 0x003F1049 File Offset: 0x003EF249
	public Action OnConfirm { get; set; }

	// Token: 0x1700138F RID: 5007
	// (get) Token: 0x0600D431 RID: 54321 RVA: 0x003F1052 File Offset: 0x003EF252
	// (set) Token: 0x0600D432 RID: 54322 RVA: 0x003F105A File Offset: 0x003EF25A
	public Action OnCancel { get; set; }
}

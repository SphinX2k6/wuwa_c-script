using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D3 RID: 2259
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleRevivePopupViewParam : IPinballBattleRevivePopupViewParam
{
	// Token: 0x17000C9B RID: 3227
	// (get) Token: 0x060064CD RID: 25805 RVA: 0x001FB77A File Offset: 0x001F997A
	// (set) Token: 0x060064CE RID: 25806 RVA: 0x001FB782 File Offset: 0x001F9982
	public Action ConfirmCallback { get; set; }

	// Token: 0x17000C9C RID: 3228
	// (get) Token: 0x060064CF RID: 25807 RVA: 0x001FB78B File Offset: 0x001F998B
	// (set) Token: 0x060064D0 RID: 25808 RVA: 0x001FB793 File Offset: 0x001F9993
	public Action CancelCallback { get; set; }
}

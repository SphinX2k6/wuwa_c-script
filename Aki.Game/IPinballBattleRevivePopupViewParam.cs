using System;
using System.Runtime.CompilerServices;

// Token: 0x020011D1 RID: 4561
[NullableContext(2)]
public interface IPinballBattleRevivePopupViewParam
{
	// Token: 0x1700123F RID: 4671
	// (get) Token: 0x0600B50B RID: 46347
	Action ConfirmCallback { get; }

	// Token: 0x17001240 RID: 4672
	// (get) Token: 0x0600B50C RID: 46348
	Action CancelCallback { get; }
}

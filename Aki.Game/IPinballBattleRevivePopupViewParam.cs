using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D0F RID: 7439
[NullableContext(2)]
public interface IPinballBattleRevivePopupViewParam
{
	// Token: 0x17001215 RID: 4629
	// (get) Token: 0x0600E0EE RID: 57582
	Action ConfirmCallback { get; }

	// Token: 0x17001216 RID: 4630
	// (get) Token: 0x0600E0EF RID: 57583
	Action CancelCallback { get; }
}

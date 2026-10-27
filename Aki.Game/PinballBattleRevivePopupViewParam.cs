using System;
using System.Runtime.CompilerServices;

// Token: 0x0200141F RID: 5151
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleRevivePopupViewParam : IPinballBattleRevivePopupViewParam
{
	// Token: 0x17000C7B RID: 3195
	// (get) Token: 0x06009138 RID: 37176 RVA: 0x001F2C3E File Offset: 0x001F0E3E
	// (set) Token: 0x06009139 RID: 37177 RVA: 0x001F2C46 File Offset: 0x001F0E46
	public Action ConfirmCallback { get; set; }

	// Token: 0x17000C7C RID: 3196
	// (get) Token: 0x0600913A RID: 37178 RVA: 0x001F2C4F File Offset: 0x001F0E4F
	// (set) Token: 0x0600913B RID: 37179 RVA: 0x001F2C57 File Offset: 0x001F0E57
	public Action CancelCallback { get; set; }
}

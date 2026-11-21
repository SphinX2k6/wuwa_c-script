using System;
using System.Runtime.CompilerServices;

// Token: 0x020022A7 RID: 8871
[NullableContext(2)]
[Nullable(0)]
public class ExtraRoomTipsData : IExtraRoomTipsData
{
	// Token: 0x17002138 RID: 8504
	// (get) Token: 0x06015E8A RID: 89738 RVA: 0x0065A561 File Offset: 0x00658761
	// (set) Token: 0x06015E8B RID: 89739 RVA: 0x0065A569 File Offset: 0x00658769
	public int CurScore { get; set; }

	// Token: 0x17002139 RID: 8505
	// (get) Token: 0x06015E8C RID: 89740 RVA: 0x0065A572 File Offset: 0x00658772
	// (set) Token: 0x06015E8D RID: 89741 RVA: 0x0065A57A File Offset: 0x0065877A
	public int MaxScore { get; set; }

	// Token: 0x1700213A RID: 8506
	// (get) Token: 0x06015E8E RID: 89742 RVA: 0x0065A583 File Offset: 0x00658783
	// (set) Token: 0x06015E8F RID: 89743 RVA: 0x0065A58B File Offset: 0x0065878B
	public Action CancelFunc { get; set; }

	// Token: 0x1700213B RID: 8507
	// (get) Token: 0x06015E90 RID: 89744 RVA: 0x0065A594 File Offset: 0x00658794
	// (set) Token: 0x06015E91 RID: 89745 RVA: 0x0065A59C File Offset: 0x0065879C
	public Action ConfirmFunc { get; set; }
}

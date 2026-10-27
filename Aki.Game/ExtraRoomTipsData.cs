using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D4D RID: 11597
[NullableContext(2)]
[Nullable(0)]
public class ExtraRoomTipsData : IExtraRoomTipsData
{
	// Token: 0x170020DD RID: 8413
	// (get) Token: 0x060185E8 RID: 99816 RVA: 0x00634551 File Offset: 0x00632751
	// (set) Token: 0x060185E9 RID: 99817 RVA: 0x00634559 File Offset: 0x00632759
	public int CurScore { get; set; }

	// Token: 0x170020DE RID: 8414
	// (get) Token: 0x060185EA RID: 99818 RVA: 0x00634562 File Offset: 0x00632762
	// (set) Token: 0x060185EB RID: 99819 RVA: 0x0063456A File Offset: 0x0063276A
	public int MaxScore { get; set; }

	// Token: 0x170020DF RID: 8415
	// (get) Token: 0x060185EC RID: 99820 RVA: 0x00634573 File Offset: 0x00632773
	// (set) Token: 0x060185ED RID: 99821 RVA: 0x0063457B File Offset: 0x0063277B
	public Action CancelFunc { get; set; }

	// Token: 0x170020E0 RID: 8416
	// (get) Token: 0x060185EE RID: 99822 RVA: 0x00634584 File Offset: 0x00632784
	// (set) Token: 0x060185EF RID: 99823 RVA: 0x0063458C File Offset: 0x0063278C
	public Action ConfirmFunc { get; set; }
}

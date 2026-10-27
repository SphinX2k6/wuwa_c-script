using System;
using System.Runtime.CompilerServices;

// Token: 0x020031E3 RID: 12771
[NullableContext(2)]
public interface INpcSitOnChairParams
{
	// Token: 0x1700260C RID: 9740
	// (get) Token: 0x0601B8B2 RID: 112818
	// (set) Token: 0x0601B8B3 RID: 112819
	int ChairEntityId { get; set; }

	// Token: 0x1700260D RID: 9741
	// (get) Token: 0x0601B8B4 RID: 112820
	// (set) Token: 0x0601B8B5 RID: 112821
	string MontagePath { get; set; }

	// Token: 0x1700260E RID: 9742
	// (get) Token: 0x0601B8B6 RID: 112822
	// (set) Token: 0x0601B8B7 RID: 112823
	[Nullable(1)]
	Func<bool> InterruptCondition { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700260F RID: 9743
	// (get) Token: 0x0601B8B8 RID: 112824
	// (set) Token: 0x0601B8B9 RID: 112825
	Action Finish { get; set; }

	// Token: 0x17002610 RID: 9744
	// (get) Token: 0x0601B8BA RID: 112826
	// (set) Token: 0x0601B8BB RID: 112827
	Action Abort { get; set; }

	// Token: 0x17002611 RID: 9745
	// (get) Token: 0x0601B8BC RID: 112828
	// (set) Token: 0x0601B8BD RID: 112829
	int[] TeleportEffect { get; set; }
}

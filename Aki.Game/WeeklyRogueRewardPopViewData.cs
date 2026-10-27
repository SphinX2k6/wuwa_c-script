using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002D64 RID: 11620
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRewardPopViewData : IWeeklyRogueRewardPopViewData
{
	// Token: 0x170020FC RID: 8444
	// (get) Token: 0x060186F5 RID: 100085 RVA: 0x0063883F File Offset: 0x00636A3F
	// (set) Token: 0x060186F6 RID: 100086 RVA: 0x00638847 File Offset: 0x00636A47
	public int SinglePowerCost { get; set; }

	// Token: 0x170020FD RID: 8445
	// (get) Token: 0x060186F7 RID: 100087 RVA: 0x00638850 File Offset: 0x00636A50
	// (set) Token: 0x060186F8 RID: 100088 RVA: 0x00638858 File Offset: 0x00636A58
	public Action<int, int> RewardCallBack { get; set; }

	// Token: 0x170020FE RID: 8446
	// (get) Token: 0x060186F9 RID: 100089 RVA: 0x00638861 File Offset: 0x00636A61
	// (set) Token: 0x060186FA RID: 100090 RVA: 0x00638869 File Offset: 0x00636A69
	[Nullable(2)]
	public Action CloseCallBack { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170020FF RID: 8447
	// (get) Token: 0x060186FB RID: 100091 RVA: 0x00638872 File Offset: 0x00636A72
	// (set) Token: 0x060186FC RID: 100092 RVA: 0x0063887A File Offset: 0x00636A7A
	public List<int> AvailableSilentArea { get; set; }

	// Token: 0x17002100 RID: 8448
	// (get) Token: 0x060186FD RID: 100093 RVA: 0x00638883 File Offset: 0x00636A83
	// (set) Token: 0x060186FE RID: 100094 RVA: 0x0063888B File Offset: 0x00636A8B
	public int FreeCount { get; set; }

	// Token: 0x17002101 RID: 8449
	// (get) Token: 0x060186FF RID: 100095 RVA: 0x00638894 File Offset: 0x00636A94
	// (set) Token: 0x06018700 RID: 100096 RVA: 0x0063889C File Offset: 0x00636A9C
	public int FreeMax { get; set; }
}

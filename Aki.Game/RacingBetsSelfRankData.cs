using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001BE7 RID: 7143
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsSelfRankData : IRacingBetsSelfRankData
{
	// Token: 0x17001B04 RID: 6916
	// (get) Token: 0x06011C55 RID: 72789 RVA: 0x0053A89E File Offset: 0x00538A9E
	// (set) Token: 0x06011C56 RID: 72790 RVA: 0x0053A8A6 File Offset: 0x00538AA6
	public RacingBetsRankStatus RankStatus { get; set; }

	// Token: 0x17001B05 RID: 6917
	// (get) Token: 0x06011C57 RID: 72791 RVA: 0x0053A8AF File Offset: 0x00538AAF
	// (set) Token: 0x06011C58 RID: 72792 RVA: 0x0053A8B7 File Offset: 0x00538AB7
	public int RankNum { get; set; }

	// Token: 0x17001B06 RID: 6918
	// (get) Token: 0x06011C59 RID: 72793 RVA: 0x0053A8C0 File Offset: 0x00538AC0
	// (set) Token: 0x06011C5A RID: 72794 RVA: 0x0053A8C8 File Offset: 0x00538AC8
	public int HeadIcon { get; set; }

	// Token: 0x17001B07 RID: 6919
	// (get) Token: 0x06011C5B RID: 72795 RVA: 0x0053A8D1 File Offset: 0x00538AD1
	// (set) Token: 0x06011C5C RID: 72796 RVA: 0x0053A8D9 File Offset: 0x00538AD9
	public string Name { get; set; }

	// Token: 0x17001B08 RID: 6920
	// (get) Token: 0x06011C5D RID: 72797 RVA: 0x0053A8E2 File Offset: 0x00538AE2
	// (set) Token: 0x06011C5E RID: 72798 RVA: 0x0053A8EA File Offset: 0x00538AEA
	public int HitNum { get; set; }

	// Token: 0x17001B09 RID: 6921
	// (get) Token: 0x06011C5F RID: 72799 RVA: 0x0053A8F3 File Offset: 0x00538AF3
	// (set) Token: 0x06011C60 RID: 72800 RVA: 0x0053A8FB File Offset: 0x00538AFB
	public int CashNum { get; set; }
}

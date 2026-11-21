using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE5 RID: 7141
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsRankData : IRacingBetsRankData
{
	// Token: 0x17001AF8 RID: 6904
	// (get) Token: 0x06011C3C RID: 72764 RVA: 0x0053A830 File Offset: 0x00538A30
	// (set) Token: 0x06011C3D RID: 72765 RVA: 0x0053A838 File Offset: 0x00538A38
	public int PlayerId { get; set; }

	// Token: 0x17001AF9 RID: 6905
	// (get) Token: 0x06011C3E RID: 72766 RVA: 0x0053A841 File Offset: 0x00538A41
	// (set) Token: 0x06011C3F RID: 72767 RVA: 0x0053A849 File Offset: 0x00538A49
	public int PlayerHeadPhoto { get; set; }

	// Token: 0x17001AFA RID: 6906
	// (get) Token: 0x06011C40 RID: 72768 RVA: 0x0053A852 File Offset: 0x00538A52
	// (set) Token: 0x06011C41 RID: 72769 RVA: 0x0053A85A File Offset: 0x00538A5A
	public int RankNum { get; set; }

	// Token: 0x17001AFB RID: 6907
	// (get) Token: 0x06011C42 RID: 72770 RVA: 0x0053A863 File Offset: 0x00538A63
	// (set) Token: 0x06011C43 RID: 72771 RVA: 0x0053A86B File Offset: 0x00538A6B
	public string Name { get; set; }

	// Token: 0x17001AFC RID: 6908
	// (get) Token: 0x06011C44 RID: 72772 RVA: 0x0053A874 File Offset: 0x00538A74
	// (set) Token: 0x06011C45 RID: 72773 RVA: 0x0053A87C File Offset: 0x00538A7C
	public int HitNum { get; set; }

	// Token: 0x17001AFD RID: 6909
	// (get) Token: 0x06011C46 RID: 72774 RVA: 0x0053A885 File Offset: 0x00538A85
	// (set) Token: 0x06011C47 RID: 72775 RVA: 0x0053A88D File Offset: 0x00538A8D
	public int CashNum { get; set; }
}

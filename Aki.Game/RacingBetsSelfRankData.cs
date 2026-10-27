using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020026FC RID: 9980
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsSelfRankData : IRacingBetsSelfRankData
{
	// Token: 0x17001ACC RID: 6860
	// (get) Token: 0x06014773 RID: 83827 RVA: 0x0052BB82 File Offset: 0x00529D82
	// (set) Token: 0x06014774 RID: 83828 RVA: 0x0052BB8A File Offset: 0x00529D8A
	public RacingBetsRankStatus RankStatus { get; set; }

	// Token: 0x17001ACD RID: 6861
	// (get) Token: 0x06014775 RID: 83829 RVA: 0x0052BB93 File Offset: 0x00529D93
	// (set) Token: 0x06014776 RID: 83830 RVA: 0x0052BB9B File Offset: 0x00529D9B
	public int RankNum { get; set; }

	// Token: 0x17001ACE RID: 6862
	// (get) Token: 0x06014777 RID: 83831 RVA: 0x0052BBA4 File Offset: 0x00529DA4
	// (set) Token: 0x06014778 RID: 83832 RVA: 0x0052BBAC File Offset: 0x00529DAC
	public int HeadIcon { get; set; }

	// Token: 0x17001ACF RID: 6863
	// (get) Token: 0x06014779 RID: 83833 RVA: 0x0052BBB5 File Offset: 0x00529DB5
	// (set) Token: 0x0601477A RID: 83834 RVA: 0x0052BBBD File Offset: 0x00529DBD
	public string Name { get; set; }

	// Token: 0x17001AD0 RID: 6864
	// (get) Token: 0x0601477B RID: 83835 RVA: 0x0052BBC6 File Offset: 0x00529DC6
	// (set) Token: 0x0601477C RID: 83836 RVA: 0x0052BBCE File Offset: 0x00529DCE
	public int HitNum { get; set; }

	// Token: 0x17001AD1 RID: 6865
	// (get) Token: 0x0601477D RID: 83837 RVA: 0x0052BBD7 File Offset: 0x00529DD7
	// (set) Token: 0x0601477E RID: 83838 RVA: 0x0052BBDF File Offset: 0x00529DDF
	public int CashNum { get; set; }
}

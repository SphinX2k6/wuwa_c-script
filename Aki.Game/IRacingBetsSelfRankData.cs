using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001BE6 RID: 7142
[NullableContext(1)]
public interface IRacingBetsSelfRankData
{
	// Token: 0x17001AFE RID: 6910
	// (get) Token: 0x06011C49 RID: 72777
	// (set) Token: 0x06011C4A RID: 72778
	RacingBetsRankStatus RankStatus { get; set; }

	// Token: 0x17001AFF RID: 6911
	// (get) Token: 0x06011C4B RID: 72779
	// (set) Token: 0x06011C4C RID: 72780
	int RankNum { get; set; }

	// Token: 0x17001B00 RID: 6912
	// (get) Token: 0x06011C4D RID: 72781
	// (set) Token: 0x06011C4E RID: 72782
	int HeadIcon { get; set; }

	// Token: 0x17001B01 RID: 6913
	// (get) Token: 0x06011C4F RID: 72783
	// (set) Token: 0x06011C50 RID: 72784
	string Name { get; set; }

	// Token: 0x17001B02 RID: 6914
	// (get) Token: 0x06011C51 RID: 72785
	// (set) Token: 0x06011C52 RID: 72786
	int HitNum { get; set; }

	// Token: 0x17001B03 RID: 6915
	// (get) Token: 0x06011C53 RID: 72787
	// (set) Token: 0x06011C54 RID: 72788
	int CashNum { get; set; }
}

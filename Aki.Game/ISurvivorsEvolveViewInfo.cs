using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ADF RID: 10975
[NullableContext(1)]
public interface ISurvivorsEvolveViewInfo
{
	// Token: 0x17001E61 RID: 7777
	// (get) Token: 0x06016D6C RID: 93548
	ESurvivorsRogueItemType SourceType { get; }

	// Token: 0x17001E62 RID: 7778
	// (get) Token: 0x06016D6D RID: 93549
	int SourceId { get; }

	// Token: 0x17001E63 RID: 7779
	// (get) Token: 0x06016D6E RID: 93550
	string TitleId { get; }

	// Token: 0x17001E64 RID: 7780
	// (get) Token: 0x06016D6F RID: 93551
	int EvolveId { get; }

	// Token: 0x17001E65 RID: 7781
	// (get) Token: 0x06016D70 RID: 93552
	ESurvivorsRogueItemType? BondType { get; }

	// Token: 0x17001E66 RID: 7782
	// (get) Token: 0x06016D71 RID: 93553
	int? BondId { get; }

	// Token: 0x17001E67 RID: 7783
	// (get) Token: 0x06016D72 RID: 93554
	bool? PlayTween { get; }

	// Token: 0x17001E68 RID: 7784
	// (get) Token: 0x06016D73 RID: 93555
	[Nullable(2)]
	int[] WeaponEvolveIds { [NullableContext(2)] get; }
}

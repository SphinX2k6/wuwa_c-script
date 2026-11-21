using System;
using System.Runtime.CompilerServices;

// Token: 0x0200205B RID: 8283
[NullableContext(1)]
public interface ISurvivorsEvolveViewInfo
{
	// Token: 0x17001EB9 RID: 7865
	// (get) Token: 0x0601479D RID: 83869
	ESurvivorsRogueItemType SourceType { get; }

	// Token: 0x17001EBA RID: 7866
	// (get) Token: 0x0601479E RID: 83870
	int SourceId { get; }

	// Token: 0x17001EBB RID: 7867
	// (get) Token: 0x0601479F RID: 83871
	string TitleId { get; }

	// Token: 0x17001EBC RID: 7868
	// (get) Token: 0x060147A0 RID: 83872
	int EvolveId { get; }

	// Token: 0x17001EBD RID: 7869
	// (get) Token: 0x060147A1 RID: 83873
	ESurvivorsRogueItemType? BondType { get; }

	// Token: 0x17001EBE RID: 7870
	// (get) Token: 0x060147A2 RID: 83874
	int? BondId { get; }

	// Token: 0x17001EBF RID: 7871
	// (get) Token: 0x060147A3 RID: 83875
	bool? PlayTween { get; }

	// Token: 0x17001EC0 RID: 7872
	// (get) Token: 0x060147A4 RID: 83876
	[Nullable(2)]
	int[] WeaponEvolveIds { [NullableContext(2)] get; }
}

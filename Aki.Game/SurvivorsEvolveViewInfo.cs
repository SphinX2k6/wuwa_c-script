using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AE1 RID: 10977
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsEvolveViewInfo : ISurvivorsEvolveViewInfo
{
	// Token: 0x17001E69 RID: 7785
	// (get) Token: 0x06016D7F RID: 93567 RVA: 0x005CC54C File Offset: 0x005CA74C
	// (set) Token: 0x06016D80 RID: 93568 RVA: 0x005CC554 File Offset: 0x005CA754
	public ESurvivorsRogueItemType SourceType { get; set; }

	// Token: 0x17001E6A RID: 7786
	// (get) Token: 0x06016D81 RID: 93569 RVA: 0x005CC55D File Offset: 0x005CA75D
	// (set) Token: 0x06016D82 RID: 93570 RVA: 0x005CC565 File Offset: 0x005CA765
	public int SourceId { get; set; }

	// Token: 0x17001E6B RID: 7787
	// (get) Token: 0x06016D83 RID: 93571 RVA: 0x005CC56E File Offset: 0x005CA76E
	// (set) Token: 0x06016D84 RID: 93572 RVA: 0x005CC576 File Offset: 0x005CA776
	public string TitleId { get; set; } = "";

	// Token: 0x17001E6C RID: 7788
	// (get) Token: 0x06016D85 RID: 93573 RVA: 0x005CC57F File Offset: 0x005CA77F
	// (set) Token: 0x06016D86 RID: 93574 RVA: 0x005CC587 File Offset: 0x005CA787
	public int EvolveId { get; set; }

	// Token: 0x17001E6D RID: 7789
	// (get) Token: 0x06016D87 RID: 93575 RVA: 0x005CC590 File Offset: 0x005CA790
	// (set) Token: 0x06016D88 RID: 93576 RVA: 0x005CC598 File Offset: 0x005CA798
	public ESurvivorsRogueItemType? BondType { get; set; }

	// Token: 0x17001E6E RID: 7790
	// (get) Token: 0x06016D89 RID: 93577 RVA: 0x005CC5A1 File Offset: 0x005CA7A1
	// (set) Token: 0x06016D8A RID: 93578 RVA: 0x005CC5A9 File Offset: 0x005CA7A9
	public int? BondId { get; set; }

	// Token: 0x17001E6F RID: 7791
	// (get) Token: 0x06016D8B RID: 93579 RVA: 0x005CC5B2 File Offset: 0x005CA7B2
	// (set) Token: 0x06016D8C RID: 93580 RVA: 0x005CC5BA File Offset: 0x005CA7BA
	public bool? PlayTween { get; set; }

	// Token: 0x17001E70 RID: 7792
	// (get) Token: 0x06016D8D RID: 93581 RVA: 0x005CC5C3 File Offset: 0x005CA7C3
	// (set) Token: 0x06016D8E RID: 93582 RVA: 0x005CC5CB File Offset: 0x005CA7CB
	[Nullable(2)]
	public int[] WeaponEvolveIds { [NullableContext(2)] get; [NullableContext(2)] set; }
}

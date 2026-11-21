using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E00 RID: 7680
[NullableContext(2)]
[Nullable(0)]
public class LevelInfo : ILevelInfo
{
	// Token: 0x17001CDD RID: 7389
	// (get) Token: 0x06012F88 RID: 77704 RVA: 0x0058E13B File Offset: 0x0058C33B
	// (set) Token: 0x06012F89 RID: 77705 RVA: 0x0058E143 File Offset: 0x0058C343
	public int PreUpgradeLv { get; set; }

	// Token: 0x17001CDE RID: 7390
	// (get) Token: 0x06012F8A RID: 77706 RVA: 0x0058E14C File Offset: 0x0058C34C
	// (set) Token: 0x06012F8B RID: 77707 RVA: 0x0058E154 File Offset: 0x0058C354
	public int UpgradeLv { get; set; }

	// Token: 0x17001CDF RID: 7391
	// (get) Token: 0x06012F8C RID: 77708 RVA: 0x0058E15D File Offset: 0x0058C35D
	// (set) Token: 0x06012F8D RID: 77709 RVA: 0x0058E165 File Offset: 0x0058C365
	public string FormatStringId { get; set; }

	// Token: 0x17001CE0 RID: 7392
	// (get) Token: 0x06012F8E RID: 77710 RVA: 0x0058E16E File Offset: 0x0058C36E
	// (set) Token: 0x06012F8F RID: 77711 RVA: 0x0058E176 File Offset: 0x0058C376
	public bool? IsMaxLevel { get; set; }
}

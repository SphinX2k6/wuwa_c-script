using System;

// Token: 0x0200146B RID: 5227
public struct IRegressLevelProgressData
{
	// Token: 0x17000CDC RID: 3292
	// (get) Token: 0x06009385 RID: 37765 RVA: 0x001FB660 File Offset: 0x001F9860
	// (set) Token: 0x06009386 RID: 37766 RVA: 0x001FB668 File Offset: 0x001F9868
	public int Level { readonly get; set; }

	// Token: 0x17000CDD RID: 3293
	// (get) Token: 0x06009387 RID: 37767 RVA: 0x001FB671 File Offset: 0x001F9871
	// (set) Token: 0x06009388 RID: 37768 RVA: 0x001FB679 File Offset: 0x001F9879
	public int MaxLevel { readonly get; set; }

	// Token: 0x17000CDE RID: 3294
	// (get) Token: 0x06009389 RID: 37769 RVA: 0x001FB682 File Offset: 0x001F9882
	// (set) Token: 0x0600938A RID: 37770 RVA: 0x001FB68A File Offset: 0x001F988A
	public int CurScore { readonly get; set; }

	// Token: 0x17000CDF RID: 3295
	// (get) Token: 0x0600938B RID: 37771 RVA: 0x001FB693 File Offset: 0x001F9893
	// (set) Token: 0x0600938C RID: 37772 RVA: 0x001FB69B File Offset: 0x001F989B
	public int NeedScore { readonly get; set; }
}

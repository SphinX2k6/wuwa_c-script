using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000553 RID: 1363
[NullableContext(1)]
[Nullable(0)]
public struct RecommendItemDisplay
{
	// Token: 0x04003408 RID: 13320
	public int Id;

	// Token: 0x04003409 RID: 13321
	public EActivityRecommendType Type;

	// Token: 0x0400340A RID: 13322
	public string Title;

	// Token: 0x0400340B RID: 13323
	public RecommendTextLocalize? SubTitle;

	// Token: 0x0400340C RID: 13324
	public ERecommendIconSource IconSource;

	// Token: 0x0400340D RID: 13325
	[Nullable(2)]
	public string IconSpritePath;

	// Token: 0x0400340E RID: 13326
	[Nullable(2)]
	public string IconTexturePath;

	// Token: 0x0400340F RID: 13327
	public RecommendTagDisplay? Tag;

	// Token: 0x04003410 RID: 13328
	public List<TItem> RewardList;

	// Token: 0x04003411 RID: 13329
	public bool ShowJumpBtn;

	// Token: 0x04003412 RID: 13330
	public bool ShowPreOpenBtn;

	// Token: 0x04003413 RID: 13331
	public bool ShowLockedBtn;

	// Token: 0x04003414 RID: 13332
	public bool ShowDownMask;

	// Token: 0x04003415 RID: 13333
	public bool IsMainQuestFinished;

	// Token: 0x04003416 RID: 13334
	public bool IsBigIcon;
}

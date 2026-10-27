using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200109F RID: 4255
[NullableContext(1)]
[Nullable(0)]
public struct RecommendItemDisplay
{
	// Token: 0x0400336F RID: 13167
	public int Id;

	// Token: 0x04003370 RID: 13168
	public EActivityRecommendType Type;

	// Token: 0x04003371 RID: 13169
	public string Title;

	// Token: 0x04003372 RID: 13170
	public RecommendTextLocalize? SubTitle;

	// Token: 0x04003373 RID: 13171
	public ERecommendIconSource IconSource;

	// Token: 0x04003374 RID: 13172
	[Nullable(2)]
	public string IconSpritePath;

	// Token: 0x04003375 RID: 13173
	[Nullable(2)]
	public string IconTexturePath;

	// Token: 0x04003376 RID: 13174
	public RecommendTagDisplay? Tag;

	// Token: 0x04003377 RID: 13175
	public List<TItem> RewardList;

	// Token: 0x04003378 RID: 13176
	public bool ShowJumpBtn;

	// Token: 0x04003379 RID: 13177
	public bool ShowPreOpenBtn;

	// Token: 0x0400337A RID: 13178
	public bool ShowLockedBtn;

	// Token: 0x0400337B RID: 13179
	public bool ShowDownMask;

	// Token: 0x0400337C RID: 13180
	public bool IsMainQuestFinished;

	// Token: 0x0400337D RID: 13181
	public bool IsBigIcon;
}

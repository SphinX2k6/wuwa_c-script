using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000552 RID: 1362
[NullableContext(2)]
[Nullable(0)]
public struct RecommendTagDisplay
{
	// Token: 0x04003402 RID: 13314
	public ERecommendTagStyle Style;

	// Token: 0x04003403 RID: 13315
	public string Text;

	// Token: 0x04003404 RID: 13316
	public RecommendTextLocalize? TextLocalize;

	// Token: 0x04003405 RID: 13317
	[Nullable(1)]
	public string BgSpritePath;

	// Token: 0x04003406 RID: 13318
	public string IconSpritePath;

	// Token: 0x04003407 RID: 13319
	public FColor? IconColor;
}

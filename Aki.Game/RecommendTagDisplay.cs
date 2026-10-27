using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200109E RID: 4254
[NullableContext(2)]
[Nullable(0)]
public struct RecommendTagDisplay
{
	// Token: 0x04003369 RID: 13161
	public ERecommendTagStyle Style;

	// Token: 0x0400336A RID: 13162
	public string Text;

	// Token: 0x0400336B RID: 13163
	public RecommendTextLocalize? TextLocalize;

	// Token: 0x0400336C RID: 13164
	[Nullable(1)]
	public string BgSpritePath;

	// Token: 0x0400336D RID: 13165
	public string IconSpritePath;

	// Token: 0x0400336E RID: 13166
	public FColor? IconColor;
}

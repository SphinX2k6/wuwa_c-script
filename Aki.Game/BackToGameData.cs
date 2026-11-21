using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using AkiClient.Game.Aki.UI.Module.Loading.View;

// Token: 0x02001557 RID: 5463
[NullableContext(2)]
[Nullable(0)]
public class BackToGameData
{
	// Token: 0x040079F1 RID: 31217
	public EBackToGameType BackToGameType;

	// Token: 0x040079F2 RID: 31218
	public float Progress;

	// Token: 0x040079F3 RID: 31219
	[JsonIgnore]
	public WBP_UILoading_C LoadingWidget;

	// Token: 0x040079F4 RID: 31220
	public string LoadingTexturePath;

	// Token: 0x040079F5 RID: 31221
	public string LoadingTitle;

	// Token: 0x040079F6 RID: 31222
	public string LoadingTips;

	// Token: 0x040079F7 RID: 31223
	public BackToGameLoginData BackToGameLoginData;
}

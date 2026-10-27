using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using AkiClient.Game.Aki.UI.Module.Loading.View;

// Token: 0x02002084 RID: 8324
[NullableContext(2)]
[Nullable(0)]
public class BackToGameData
{
	// Token: 0x04007908 RID: 30984
	public EBackToGameType BackToGameType;

	// Token: 0x04007909 RID: 30985
	public float Progress;

	// Token: 0x0400790A RID: 30986
	[JsonIgnore]
	public WBP_UILoading_C LoadingWidget;

	// Token: 0x0400790B RID: 30987
	public string LoadingTexturePath;

	// Token: 0x0400790C RID: 30988
	public string LoadingTitle;

	// Token: 0x0400790D RID: 30989
	public string LoadingTips;

	// Token: 0x0400790E RID: 30990
	public BackToGameLoginData BackToGameLoginData;
}

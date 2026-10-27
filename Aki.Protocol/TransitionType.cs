using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001661 RID: 5729
	public enum TransitionType
	{
		// Token: 0x0400C16B RID: 49515
		[OriginalName("Empty")]
		Empty,
		// Token: 0x0400C16C RID: 49516
		[OriginalName("PlayEffect")]
		PlayEffect,
		// Token: 0x0400C16D RID: 49517
		[OriginalName("PlayMp4")]
		PlayMp4,
		// Token: 0x0400C16E RID: 49518
		[OriginalName("CenterText")]
		CenterText,
		// Token: 0x0400C16F RID: 49519
		[OriginalName("FadeInScreen")]
		FadeInScreen,
		// Token: 0x0400C170 RID: 49520
		[OriginalName("Seamless")]
		Seamless,
		// Token: 0x0400C171 RID: 49521
		[OriginalName("WithCharacterDisplay")]
		WithCharacterDisplay,
		// Token: 0x0400C172 RID: 49522
		[OriginalName("WithCustomLoading")]
		WithCustomLoading,
		// Token: 0x0400C173 RID: 49523
		[OriginalName("WithSpine")]
		WithSpine,
		// Token: 0x0400C174 RID: 49524
		[OriginalName("WithSpecialCustomLoading")]
		WithSpecialCustomLoading,
		// Token: 0x0400C175 RID: 49525
		[OriginalName("PlayFlow")]
		PlayFlow
	}
}

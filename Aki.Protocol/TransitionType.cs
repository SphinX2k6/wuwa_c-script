using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016DD RID: 5853
	public enum TransitionType
	{
		// Token: 0x0400C694 RID: 50836
		[OriginalName("Empty")]
		Empty,
		// Token: 0x0400C695 RID: 50837
		[OriginalName("PlayEffect")]
		PlayEffect,
		// Token: 0x0400C696 RID: 50838
		[OriginalName("PlayMp4")]
		PlayMp4,
		// Token: 0x0400C697 RID: 50839
		[OriginalName("CenterText")]
		CenterText,
		// Token: 0x0400C698 RID: 50840
		[OriginalName("FadeInScreen")]
		FadeInScreen,
		// Token: 0x0400C699 RID: 50841
		[OriginalName("Seamless")]
		Seamless,
		// Token: 0x0400C69A RID: 50842
		[OriginalName("WithCharacterDisplay")]
		WithCharacterDisplay,
		// Token: 0x0400C69B RID: 50843
		[OriginalName("WithCustomLoading")]
		WithCustomLoading,
		// Token: 0x0400C69C RID: 50844
		[OriginalName("WithSpine")]
		WithSpine,
		// Token: 0x0400C69D RID: 50845
		[OriginalName("WithSpecialCustomLoading")]
		WithSpecialCustomLoading,
		// Token: 0x0400C69E RID: 50846
		[OriginalName("PlayFlow")]
		PlayFlow
	}
}

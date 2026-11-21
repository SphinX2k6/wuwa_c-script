using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052AC RID: 21164
	[NullableContext(2)]
	public interface IPinballMainButtonConfig
	{
		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x06034ABD RID: 215741
		// (set) Token: 0x06034ABE RID: 215742
		EPinballMainButtonFunctionType Type { get; set; }

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x06034ABF RID: 215743
		// (set) Token: 0x06034AC0 RID: 215744
		int UiRegisterId { get; set; }

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x06034AC1 RID: 215745
		// (set) Token: 0x06034AC2 RID: 215746
		int? FunctionId { get; set; }

		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x06034AC3 RID: 215747
		// (set) Token: 0x06034AC4 RID: 215748
		ERedDotName? RedDotName { get; set; }

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x06034AC5 RID: 215749
		// (set) Token: 0x06034AC6 RID: 215750
		Func<bool> ShowRedDot { get; set; }

		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x06034AC7 RID: 215751
		// (set) Token: 0x06034AC8 RID: 215752
		Action<UUIText> SetTextCallback { get; set; }

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x06034AC9 RID: 215753
		// (set) Token: 0x06034ACA RID: 215754
		Action OnClickCallback { get; set; }

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x06034ACB RID: 215755
		// (set) Token: 0x06034ACC RID: 215756
		Func<bool> ShowCallback { get; set; }
	}
}

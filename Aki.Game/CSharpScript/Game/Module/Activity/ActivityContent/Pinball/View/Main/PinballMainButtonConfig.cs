using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052AD RID: 21165
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainButtonConfig : IPinballMainButtonConfig
	{
		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x06034ACD RID: 215757 RVA: 0x00EBB33B File Offset: 0x00EB953B
		// (set) Token: 0x06034ACE RID: 215758 RVA: 0x00EBB343 File Offset: 0x00EB9543
		public EPinballMainButtonFunctionType Type { get; set; }

		// Token: 0x17006665 RID: 26213
		// (get) Token: 0x06034ACF RID: 215759 RVA: 0x00EBB34C File Offset: 0x00EB954C
		// (set) Token: 0x06034AD0 RID: 215760 RVA: 0x00EBB354 File Offset: 0x00EB9554
		public int UiRegisterId { get; set; }

		// Token: 0x17006666 RID: 26214
		// (get) Token: 0x06034AD1 RID: 215761 RVA: 0x00EBB35D File Offset: 0x00EB955D
		// (set) Token: 0x06034AD2 RID: 215762 RVA: 0x00EBB365 File Offset: 0x00EB9565
		public int? FunctionId { get; set; }

		// Token: 0x17006667 RID: 26215
		// (get) Token: 0x06034AD3 RID: 215763 RVA: 0x00EBB36E File Offset: 0x00EB956E
		// (set) Token: 0x06034AD4 RID: 215764 RVA: 0x00EBB376 File Offset: 0x00EB9576
		public ERedDotName? RedDotName { get; set; }

		// Token: 0x17006668 RID: 26216
		// (get) Token: 0x06034AD5 RID: 215765 RVA: 0x00EBB37F File Offset: 0x00EB957F
		// (set) Token: 0x06034AD6 RID: 215766 RVA: 0x00EBB387 File Offset: 0x00EB9587
		public Func<bool> ShowRedDot { get; set; }

		// Token: 0x17006669 RID: 26217
		// (get) Token: 0x06034AD7 RID: 215767 RVA: 0x00EBB390 File Offset: 0x00EB9590
		// (set) Token: 0x06034AD8 RID: 215768 RVA: 0x00EBB398 File Offset: 0x00EB9598
		public Action<UUIText> SetTextCallback { get; set; }

		// Token: 0x1700666A RID: 26218
		// (get) Token: 0x06034AD9 RID: 215769 RVA: 0x00EBB3A1 File Offset: 0x00EB95A1
		// (set) Token: 0x06034ADA RID: 215770 RVA: 0x00EBB3A9 File Offset: 0x00EB95A9
		public Action OnClickCallback { get; set; }

		// Token: 0x1700666B RID: 26219
		// (get) Token: 0x06034ADB RID: 215771 RVA: 0x00EBB3B2 File Offset: 0x00EB95B2
		// (set) Token: 0x06034ADC RID: 215772 RVA: 0x00EBB3BA File Offset: 0x00EB95BA
		public Func<bool> ShowCallback { get; set; }
	}
}

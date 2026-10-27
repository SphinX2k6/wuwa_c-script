using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x0200632F RID: 25391
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainButtonConfig : IPinballMainButtonConfig
	{
		// Token: 0x17009302 RID: 37634
		// (get) Token: 0x0603FE0C RID: 261644 RVA: 0x00F743DF File Offset: 0x00F725DF
		// (set) Token: 0x0603FE0D RID: 261645 RVA: 0x00F743E7 File Offset: 0x00F725E7
		public EPinballMainButtonFunctionType Type { get; set; }

		// Token: 0x17009303 RID: 37635
		// (get) Token: 0x0603FE0E RID: 261646 RVA: 0x00F743F0 File Offset: 0x00F725F0
		// (set) Token: 0x0603FE0F RID: 261647 RVA: 0x00F743F8 File Offset: 0x00F725F8
		public int UiRegisterId { get; set; }

		// Token: 0x17009304 RID: 37636
		// (get) Token: 0x0603FE10 RID: 261648 RVA: 0x00F74401 File Offset: 0x00F72601
		// (set) Token: 0x0603FE11 RID: 261649 RVA: 0x00F74409 File Offset: 0x00F72609
		public int? FunctionId { get; set; }

		// Token: 0x17009305 RID: 37637
		// (get) Token: 0x0603FE12 RID: 261650 RVA: 0x00F74412 File Offset: 0x00F72612
		// (set) Token: 0x0603FE13 RID: 261651 RVA: 0x00F7441A File Offset: 0x00F7261A
		public ERedDotName? RedDotName { get; set; }

		// Token: 0x17009306 RID: 37638
		// (get) Token: 0x0603FE14 RID: 261652 RVA: 0x00F74423 File Offset: 0x00F72623
		// (set) Token: 0x0603FE15 RID: 261653 RVA: 0x00F7442B File Offset: 0x00F7262B
		public Func<bool> ShowRedDot { get; set; }

		// Token: 0x17009307 RID: 37639
		// (get) Token: 0x0603FE16 RID: 261654 RVA: 0x00F74434 File Offset: 0x00F72634
		// (set) Token: 0x0603FE17 RID: 261655 RVA: 0x00F7443C File Offset: 0x00F7263C
		public Action<UUIText> SetTextCallback { get; set; }

		// Token: 0x17009308 RID: 37640
		// (get) Token: 0x0603FE18 RID: 261656 RVA: 0x00F74445 File Offset: 0x00F72645
		// (set) Token: 0x0603FE19 RID: 261657 RVA: 0x00F7444D File Offset: 0x00F7264D
		public Action OnClickCallback { get; set; }

		// Token: 0x17009309 RID: 37641
		// (get) Token: 0x0603FE1A RID: 261658 RVA: 0x00F74456 File Offset: 0x00F72656
		// (set) Token: 0x0603FE1B RID: 261659 RVA: 0x00F7445E File Offset: 0x00F7265E
		public Func<bool> ShowCallback { get; set; }
	}
}

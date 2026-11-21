using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x0200448B RID: 17547
	[NullableContext(2)]
	[Nullable(0)]
	public class MapMarkPreemptiveFrameTask : IMapMarkPreemptiveFrameTask, IPreemptiveFrameTask
	{
		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x0602C543 RID: 181571 RVA: 0x00C7733A File Offset: 0x00C7553A
		// (set) Token: 0x0602C544 RID: 181572 RVA: 0x00C77342 File Offset: 0x00C75542
		public int Priority { get; set; }

		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x0602C545 RID: 181573 RVA: 0x00C7734B File Offset: 0x00C7554B
		// (set) Token: 0x0602C546 RID: 181574 RVA: 0x00C77353 File Offset: 0x00C75553
		[Nullable(1)]
		public TPreemptiveExecuteMethod Execute { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x0602C547 RID: 181575 RVA: 0x00C7735C File Offset: 0x00C7555C
		// (set) Token: 0x0602C548 RID: 181576 RVA: 0x00C77364 File Offset: 0x00C75564
		public TPreemptiveExecuteMethod FrameExecute { get; set; }

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x0602C549 RID: 181577 RVA: 0x00C7736D File Offset: 0x00C7556D
		// (set) Token: 0x0602C54A RID: 181578 RVA: 0x00C77375 File Offset: 0x00C75575
		public TPreemptiveIsCompleteMethod IsComplete { get; set; }

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x0602C54B RID: 181579 RVA: 0x00C7737E File Offset: 0x00C7557E
		// (set) Token: 0x0602C54C RID: 181580 RVA: 0x00C77386 File Offset: 0x00C75586
		public TPreemptiveCancelMethod Cancel { get; set; }

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x0602C54D RID: 181581 RVA: 0x00C7738F File Offset: 0x00C7558F
		// (set) Token: 0x0602C54E RID: 181582 RVA: 0x00C77397 File Offset: 0x00C75597
		public TGetPreemptiveResultMethod GetResult { get; set; }

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x0602C54F RID: 181583 RVA: 0x00C773A0 File Offset: 0x00C755A0
		// (set) Token: 0x0602C550 RID: 181584 RVA: 0x00C773A8 File Offset: 0x00C755A8
		public EMarkType MarkType { get; set; }

		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x0602C551 RID: 181585 RVA: 0x00C773B1 File Offset: 0x00C755B1
		// (set) Token: 0x0602C552 RID: 181586 RVA: 0x00C773B9 File Offset: 0x00C755B9
		public int MarkId { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x0200448D RID: 17549
	[NullableContext(2)]
	[Nullable(0)]
	public class MapGamePlayRequestPreemptiveFrameTask : IMapGamePlayRequestPreemptiveFrameTask, IPreemptiveFrameTask
	{
		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x0602C55A RID: 181594 RVA: 0x00C773CA File Offset: 0x00C755CA
		// (set) Token: 0x0602C55B RID: 181595 RVA: 0x00C773D2 File Offset: 0x00C755D2
		public int Priority { get; set; }

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x0602C55C RID: 181596 RVA: 0x00C773DB File Offset: 0x00C755DB
		// (set) Token: 0x0602C55D RID: 181597 RVA: 0x00C773E3 File Offset: 0x00C755E3
		[Nullable(1)]
		public TPreemptiveExecuteMethod Execute { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005889 RID: 22665
		// (get) Token: 0x0602C55E RID: 181598 RVA: 0x00C773EC File Offset: 0x00C755EC
		// (set) Token: 0x0602C55F RID: 181599 RVA: 0x00C773F4 File Offset: 0x00C755F4
		public TPreemptiveExecuteMethod FrameExecute { get; set; }

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x0602C560 RID: 181600 RVA: 0x00C773FD File Offset: 0x00C755FD
		// (set) Token: 0x0602C561 RID: 181601 RVA: 0x00C77405 File Offset: 0x00C75605
		public TPreemptiveIsCompleteMethod IsComplete { get; set; }

		// Token: 0x1700588B RID: 22667
		// (get) Token: 0x0602C562 RID: 181602 RVA: 0x00C7740E File Offset: 0x00C7560E
		// (set) Token: 0x0602C563 RID: 181603 RVA: 0x00C77416 File Offset: 0x00C75616
		public TPreemptiveCancelMethod Cancel { get; set; }

		// Token: 0x1700588C RID: 22668
		// (get) Token: 0x0602C564 RID: 181604 RVA: 0x00C7741F File Offset: 0x00C7561F
		// (set) Token: 0x0602C565 RID: 181605 RVA: 0x00C77427 File Offset: 0x00C75627
		public TGetPreemptiveResultMethod GetResult { get; set; }

		// Token: 0x1700588D RID: 22669
		// (get) Token: 0x0602C566 RID: 181606 RVA: 0x00C77430 File Offset: 0x00C75630
		// (set) Token: 0x0602C567 RID: 181607 RVA: 0x00C77438 File Offset: 0x00C75638
		public int MarkId { get; set; }

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x0602C568 RID: 181608 RVA: 0x00C77441 File Offset: 0x00C75641
		// (set) Token: 0x0602C569 RID: 181609 RVA: 0x00C77449 File Offset: 0x00C75649
		public int GamePlayId { get; set; }

		// Token: 0x1700588F RID: 22671
		// (get) Token: 0x0602C56A RID: 181610 RVA: 0x00C77452 File Offset: 0x00C75652
		// (set) Token: 0x0602C56B RID: 181611 RVA: 0x00C7745A File Offset: 0x00C7565A
		public int InstId { get; set; }
	}
}

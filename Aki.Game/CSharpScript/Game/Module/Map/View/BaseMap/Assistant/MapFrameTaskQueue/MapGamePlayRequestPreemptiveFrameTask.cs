using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054AA RID: 21674
	[NullableContext(2)]
	[Nullable(0)]
	public class MapGamePlayRequestPreemptiveFrameTask : IMapGamePlayRequestPreemptiveFrameTask, IPreemptiveFrameTask
	{
		// Token: 0x170084BB RID: 33979
		// (get) Token: 0x06037604 RID: 226820 RVA: 0x00D2764E File Offset: 0x00D2584E
		// (set) Token: 0x06037605 RID: 226821 RVA: 0x00D27656 File Offset: 0x00D25856
		public int Priority { get; set; }

		// Token: 0x170084BC RID: 33980
		// (get) Token: 0x06037606 RID: 226822 RVA: 0x00D2765F File Offset: 0x00D2585F
		// (set) Token: 0x06037607 RID: 226823 RVA: 0x00D27667 File Offset: 0x00D25867
		[Nullable(1)]
		public TPreemptiveExecuteMethod Execute { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170084BD RID: 33981
		// (get) Token: 0x06037608 RID: 226824 RVA: 0x00D27670 File Offset: 0x00D25870
		// (set) Token: 0x06037609 RID: 226825 RVA: 0x00D27678 File Offset: 0x00D25878
		public TPreemptiveExecuteMethod FrameExecute { get; set; }

		// Token: 0x170084BE RID: 33982
		// (get) Token: 0x0603760A RID: 226826 RVA: 0x00D27681 File Offset: 0x00D25881
		// (set) Token: 0x0603760B RID: 226827 RVA: 0x00D27689 File Offset: 0x00D25889
		public TPreemptiveIsCompleteMethod IsComplete { get; set; }

		// Token: 0x170084BF RID: 33983
		// (get) Token: 0x0603760C RID: 226828 RVA: 0x00D27692 File Offset: 0x00D25892
		// (set) Token: 0x0603760D RID: 226829 RVA: 0x00D2769A File Offset: 0x00D2589A
		public TPreemptiveCancelMethod Cancel { get; set; }

		// Token: 0x170084C0 RID: 33984
		// (get) Token: 0x0603760E RID: 226830 RVA: 0x00D276A3 File Offset: 0x00D258A3
		// (set) Token: 0x0603760F RID: 226831 RVA: 0x00D276AB File Offset: 0x00D258AB
		public TGetPreemptiveResultMethod GetResult { get; set; }

		// Token: 0x170084C1 RID: 33985
		// (get) Token: 0x06037610 RID: 226832 RVA: 0x00D276B4 File Offset: 0x00D258B4
		// (set) Token: 0x06037611 RID: 226833 RVA: 0x00D276BC File Offset: 0x00D258BC
		public int MarkId { get; set; }

		// Token: 0x170084C2 RID: 33986
		// (get) Token: 0x06037612 RID: 226834 RVA: 0x00D276C5 File Offset: 0x00D258C5
		// (set) Token: 0x06037613 RID: 226835 RVA: 0x00D276CD File Offset: 0x00D258CD
		public int GamePlayId { get; set; }

		// Token: 0x170084C3 RID: 33987
		// (get) Token: 0x06037614 RID: 226836 RVA: 0x00D276D6 File Offset: 0x00D258D6
		// (set) Token: 0x06037615 RID: 226837 RVA: 0x00D276DE File Offset: 0x00D258DE
		public int InstId { get; set; }
	}
}

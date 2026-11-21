using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003640 RID: 13888
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoWorldMoveDriverOptions : IWuWaGoWorldMoveDriverOptions
	{
		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x06024070 RID: 147568 RVA: 0x00A33551 File Offset: 0x00A31751
		// (set) Token: 0x06024071 RID: 147569 RVA: 0x00A33559 File Offset: 0x00A31759
		[RequiredMember]
		public IReadOnlyList<IWuWaGoWorldMoveTarget> Targets { get; set; }

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x06024072 RID: 147570 RVA: 0x00A33562 File Offset: 0x00A31762
		// (set) Token: 0x06024073 RID: 147571 RVA: 0x00A3356A File Offset: 0x00A3176A
		[RequiredMember]
		public Vector FromWorldPosition { get; set; }

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x06024074 RID: 147572 RVA: 0x00A33573 File Offset: 0x00A31773
		// (set) Token: 0x06024075 RID: 147573 RVA: 0x00A3357B File Offset: 0x00A3177B
		[RequiredMember]
		public Vector ToWorldPosition { get; set; }

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x06024076 RID: 147574 RVA: 0x00A33584 File Offset: 0x00A31784
		// (set) Token: 0x06024077 RID: 147575 RVA: 0x00A3358C File Offset: 0x00A3178C
		public int? DurationMs { get; set; }

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x06024078 RID: 147576 RVA: 0x00A33595 File Offset: 0x00A31795
		// (set) Token: 0x06024079 RID: 147577 RVA: 0x00A3359D File Offset: 0x00A3179D
		public float? Speed { get; set; }

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x0602407A RID: 147578 RVA: 0x00A335A6 File Offset: 0x00A317A6
		// (set) Token: 0x0602407B RID: 147579 RVA: 0x00A335AE File Offset: 0x00A317AE
		public int? TimeoutMs { get; set; }

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x0602407C RID: 147580 RVA: 0x00A335B7 File Offset: 0x00A317B7
		// (set) Token: 0x0602407D RID: 147581 RVA: 0x00A335BF File Offset: 0x00A317BF
		public int? TickIntervalMs { get; set; }

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x0602407E RID: 147582 RVA: 0x00A335C8 File Offset: 0x00A317C8
		// (set) Token: 0x0602407F RID: 147583 RVA: 0x00A335D0 File Offset: 0x00A317D0
		public int? SettleDurationMs { get; set; }

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x06024080 RID: 147584 RVA: 0x00A335D9 File Offset: 0x00A317D9
		// (set) Token: 0x06024081 RID: 147585 RVA: 0x00A335E1 File Offset: 0x00A317E1
		public float? EarlyStopStepRatio { get; set; }

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x06024082 RID: 147586 RVA: 0x00A335EA File Offset: 0x00A317EA
		// (set) Token: 0x06024083 RID: 147587 RVA: 0x00A335F2 File Offset: 0x00A317F2
		public float? ArriveTolerance { get; set; }

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x06024084 RID: 147588 RVA: 0x00A335FB File Offset: 0x00A317FB
		// (set) Token: 0x06024085 RID: 147589 RVA: 0x00A33603 File Offset: 0x00A31803
		[Nullable(2)]
		public Func<bool> ShouldAbort { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x06024086 RID: 147590 RVA: 0x00A3360C File Offset: 0x00A3180C
		// (set) Token: 0x06024087 RID: 147591 RVA: 0x00A33614 File Offset: 0x00A31814
		public EWuWaGoTimeStopPolicy? TimeStopPolicy { get; set; }

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x06024088 RID: 147592 RVA: 0x00A3361D File Offset: 0x00A3181D
		// (set) Token: 0x06024089 RID: 147593 RVA: 0x00A33625 File Offset: 0x00A31825
		[Nullable(2)]
		public IWuWaGoWorldMoveHooks Hooks { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602408A RID: 147594 RVA: 0x00A3362E File Offset: 0x00A3182E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoWorldMoveDriverOptions()
		{
		}
	}
}

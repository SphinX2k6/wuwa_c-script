using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02005F79 RID: 24441
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class QteHourglassCompletedQteInfo : IQteHourglassCompletedQteInfo
	{
		// Token: 0x17006EE3 RID: 28387
		// (get) Token: 0x0603AC3F RID: 240703 RVA: 0x0109DC94 File Offset: 0x0109BE94
		// (set) Token: 0x0603AC40 RID: 240704 RVA: 0x0109DC9C File Offset: 0x0109BE9C
		[RequiredMember]
		public int HandleId { get; set; }

		// Token: 0x17006EE4 RID: 28388
		// (get) Token: 0x0603AC41 RID: 240705 RVA: 0x0109DCA5 File Offset: 0x0109BEA5
		// (set) Token: 0x0603AC42 RID: 240706 RVA: 0x0109DCAD File Offset: 0x0109BEAD
		[RequiredMember]
		public int QteId { get; set; }

		// Token: 0x17006EE5 RID: 28389
		// (get) Token: 0x0603AC43 RID: 240707 RVA: 0x0109DCB6 File Offset: 0x0109BEB6
		// (set) Token: 0x0603AC44 RID: 240708 RVA: 0x0109DCBE File Offset: 0x0109BEBE
		[RequiredMember]
		public bool IsSuccess { get; set; }

		// Token: 0x17006EE6 RID: 28390
		// (get) Token: 0x0603AC45 RID: 240709 RVA: 0x0109DCC7 File Offset: 0x0109BEC7
		// (set) Token: 0x0603AC46 RID: 240710 RVA: 0x0109DCCF File Offset: 0x0109BECF
		[RequiredMember]
		public bool IsFail { get; set; }

		// Token: 0x17006EE7 RID: 28391
		// (get) Token: 0x0603AC47 RID: 240711 RVA: 0x0109DCD8 File Offset: 0x0109BED8
		// (set) Token: 0x0603AC48 RID: 240712 RVA: 0x0109DCE0 File Offset: 0x0109BEE0
		public Vector StartPos { get; set; }

		// Token: 0x0603AC49 RID: 240713 RVA: 0x0109DCE9 File Offset: 0x0109BEE9
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QteHourglassCompletedQteInfo()
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003630 RID: 13872
	[RequiredMember]
	public class WallFrame : IWallFrame
	{
		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x06023FF7 RID: 147447 RVA: 0x00A33312 File Offset: 0x00A31512
		// (set) Token: 0x06023FF8 RID: 147448 RVA: 0x00A3331A File Offset: 0x00A3151A
		[RequiredMember]
		public int WallNormalX { get; set; }

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x06023FF9 RID: 147449 RVA: 0x00A33323 File Offset: 0x00A31523
		// (set) Token: 0x06023FFA RID: 147450 RVA: 0x00A3332B File Offset: 0x00A3152B
		[RequiredMember]
		public int WallNormalY { get; set; }

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x06023FFB RID: 147451 RVA: 0x00A33334 File Offset: 0x00A31534
		// (set) Token: 0x06023FFC RID: 147452 RVA: 0x00A3333C File Offset: 0x00A3153C
		[RequiredMember]
		public int WallTangentX { get; set; }

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x06023FFD RID: 147453 RVA: 0x00A33345 File Offset: 0x00A31545
		// (set) Token: 0x06023FFE RID: 147454 RVA: 0x00A3334D File Offset: 0x00A3154D
		[RequiredMember]
		public int WallTangentY { get; set; }

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x06023FFF RID: 147455 RVA: 0x00A33356 File Offset: 0x00A31556
		// (set) Token: 0x06024000 RID: 147456 RVA: 0x00A3335E File Offset: 0x00A3155E
		[RequiredMember]
		public int OwnerSign { get; set; }

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x06024001 RID: 147457 RVA: 0x00A33367 File Offset: 0x00A31567
		// (set) Token: 0x06024002 RID: 147458 RVA: 0x00A3336F File Offset: 0x00A3156F
		[RequiredMember]
		public float OwnerOffsetX { get; set; }

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x06024003 RID: 147459 RVA: 0x00A33378 File Offset: 0x00A31578
		// (set) Token: 0x06024004 RID: 147460 RVA: 0x00A33380 File Offset: 0x00A31580
		[RequiredMember]
		public float OwnerOffsetY { get; set; }

		// Token: 0x06024005 RID: 147461 RVA: 0x00A33389 File Offset: 0x00A31589
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WallFrame()
		{
		}
	}
}

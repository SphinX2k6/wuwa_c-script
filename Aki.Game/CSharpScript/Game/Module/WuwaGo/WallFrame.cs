using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004700 RID: 18176
	[RequiredMember]
	public class WallFrame : IWallFrame
	{
		// Token: 0x17007695 RID: 30357
		// (get) Token: 0x0602F831 RID: 194609 RVA: 0x00B03642 File Offset: 0x00B01842
		// (set) Token: 0x0602F832 RID: 194610 RVA: 0x00B0364A File Offset: 0x00B0184A
		[RequiredMember]
		public int WallNormalX { get; set; }

		// Token: 0x17007696 RID: 30358
		// (get) Token: 0x0602F833 RID: 194611 RVA: 0x00B03653 File Offset: 0x00B01853
		// (set) Token: 0x0602F834 RID: 194612 RVA: 0x00B0365B File Offset: 0x00B0185B
		[RequiredMember]
		public int WallNormalY { get; set; }

		// Token: 0x17007697 RID: 30359
		// (get) Token: 0x0602F835 RID: 194613 RVA: 0x00B03664 File Offset: 0x00B01864
		// (set) Token: 0x0602F836 RID: 194614 RVA: 0x00B0366C File Offset: 0x00B0186C
		[RequiredMember]
		public int WallTangentX { get; set; }

		// Token: 0x17007698 RID: 30360
		// (get) Token: 0x0602F837 RID: 194615 RVA: 0x00B03675 File Offset: 0x00B01875
		// (set) Token: 0x0602F838 RID: 194616 RVA: 0x00B0367D File Offset: 0x00B0187D
		[RequiredMember]
		public int WallTangentY { get; set; }

		// Token: 0x17007699 RID: 30361
		// (get) Token: 0x0602F839 RID: 194617 RVA: 0x00B03686 File Offset: 0x00B01886
		// (set) Token: 0x0602F83A RID: 194618 RVA: 0x00B0368E File Offset: 0x00B0188E
		[RequiredMember]
		public int OwnerSign { get; set; }

		// Token: 0x1700769A RID: 30362
		// (get) Token: 0x0602F83B RID: 194619 RVA: 0x00B03697 File Offset: 0x00B01897
		// (set) Token: 0x0602F83C RID: 194620 RVA: 0x00B0369F File Offset: 0x00B0189F
		[RequiredMember]
		public float OwnerOffsetX { get; set; }

		// Token: 0x1700769B RID: 30363
		// (get) Token: 0x0602F83D RID: 194621 RVA: 0x00B036A8 File Offset: 0x00B018A8
		// (set) Token: 0x0602F83E RID: 194622 RVA: 0x00B036B0 File Offset: 0x00B018B0
		[RequiredMember]
		public float OwnerOffsetY { get; set; }

		// Token: 0x0602F83F RID: 194623 RVA: 0x00B036B9 File Offset: 0x00B018B9
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WallFrame()
		{
		}
	}
}

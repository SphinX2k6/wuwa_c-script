using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDA RID: 27610
	public class INpcMoveToPointT
	{
		// Token: 0x1700CD29 RID: 52521
		// (get) Token: 0x06030814 RID: 198676 RVA: 0x00695EC9 File Offset: 0x006940C9
		// (set) Token: 0x06030815 RID: 198677 RVA: 0x00695ED1 File Offset: 0x006940D1
		public int Target { get; set; }

		// Token: 0x1700CD2A RID: 52522
		// (get) Token: 0x06030816 RID: 198678 RVA: 0x00695EDA File Offset: 0x006940DA
		// (set) Token: 0x06030817 RID: 198679 RVA: 0x00695EE2 File Offset: 0x006940E2
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700CD2B RID: 52523
		// (get) Token: 0x06030818 RID: 198680 RVA: 0x00695EEB File Offset: 0x006940EB
		// (set) Token: 0x06030819 RID: 198681 RVA: 0x00695EF3 File Offset: 0x006940F3
		public EMoveToPointType MoveType { get; set; }

		// Token: 0x0603081A RID: 198682 RVA: 0x00695EFC File Offset: 0x006940FC
		public INpcMoveToPointT()
		{
			this.Target = 0;
			this.Pos = null;
			this.MoveType = EMoveToPointType.Straight;
		}
	}
}

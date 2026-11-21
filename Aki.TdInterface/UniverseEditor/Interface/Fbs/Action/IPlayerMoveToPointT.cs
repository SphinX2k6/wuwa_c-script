using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747E RID: 29822
	public class IPlayerMoveToPointT
	{
		// Token: 0x1700DB19 RID: 56089
		// (get) Token: 0x0603435C RID: 213852 RVA: 0x00708703 File Offset: 0x00706903
		// (set) Token: 0x0603435D RID: 213853 RVA: 0x0070870B File Offset: 0x0070690B
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700DB1A RID: 56090
		// (get) Token: 0x0603435E RID: 213854 RVA: 0x00708714 File Offset: 0x00706914
		// (set) Token: 0x0603435F RID: 213855 RVA: 0x0070871C File Offset: 0x0070691C
		public EMoveToPointType MoveType { get; set; }

		// Token: 0x1700DB1B RID: 56091
		// (get) Token: 0x06034360 RID: 213856 RVA: 0x00708725 File Offset: 0x00706925
		// (set) Token: 0x06034361 RID: 213857 RVA: 0x0070872D File Offset: 0x0070692D
		public bool IsExact { get; set; }

		// Token: 0x1700DB1C RID: 56092
		// (get) Token: 0x06034362 RID: 213858 RVA: 0x00708736 File Offset: 0x00706936
		// (set) Token: 0x06034363 RID: 213859 RVA: 0x0070873E File Offset: 0x0070693E
		public byte NullMask { get; set; }

		// Token: 0x06034364 RID: 213860 RVA: 0x00708747 File Offset: 0x00706947
		public IPlayerMoveToPointT()
		{
			this.Pos = null;
			this.MoveType = EMoveToPointType.Straight;
			this.IsExact = false;
			this.NullMask = 0;
		}
	}
}

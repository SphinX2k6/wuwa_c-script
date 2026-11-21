using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733E RID: 29502
	public class INpcMoveToPointT
	{
		// Token: 0x1700D835 RID: 55349
		// (get) Token: 0x06033730 RID: 210736 RVA: 0x006EF7C9 File Offset: 0x006ED9C9
		// (set) Token: 0x06033731 RID: 210737 RVA: 0x006EF7D1 File Offset: 0x006ED9D1
		public int Target { get; set; }

		// Token: 0x1700D836 RID: 55350
		// (get) Token: 0x06033732 RID: 210738 RVA: 0x006EF7DA File Offset: 0x006ED9DA
		// (set) Token: 0x06033733 RID: 210739 RVA: 0x006EF7E2 File Offset: 0x006ED9E2
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700D837 RID: 55351
		// (get) Token: 0x06033734 RID: 210740 RVA: 0x006EF7EB File Offset: 0x006ED9EB
		// (set) Token: 0x06033735 RID: 210741 RVA: 0x006EF7F3 File Offset: 0x006ED9F3
		public EMoveToPointType MoveType { get; set; }

		// Token: 0x06033736 RID: 210742 RVA: 0x006EF7FC File Offset: 0x006ED9FC
		public INpcMoveToPointT()
		{
			this.Target = 0;
			this.Pos = null;
			this.MoveType = EMoveToPointType.Straight;
		}
	}
}

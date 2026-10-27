using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E4 RID: 22244
	public class IPasserbyNpcSplineMoveT
	{
		// Token: 0x1700A59A RID: 42394
		// (get) Token: 0x060252C0 RID: 152256 RVA: 0x0052180F File Offset: 0x0051FA0F
		// (set) Token: 0x060252C1 RID: 152257 RVA: 0x00521817 File Offset: 0x0051FA17
		public EPasserbyNpcMoveType Type { get; set; }

		// Token: 0x1700A59B RID: 42395
		// (get) Token: 0x060252C2 RID: 152258 RVA: 0x00521820 File Offset: 0x0051FA20
		// (set) Token: 0x060252C3 RID: 152259 RVA: 0x00521828 File Offset: 0x0051FA28
		public List<IPasserbyNpcSplineT> Routes { get; set; }

		// Token: 0x060252C4 RID: 152260 RVA: 0x00521831 File Offset: 0x0051FA31
		public IPasserbyNpcSplineMoveT()
		{
			this.Type = EPasserbyNpcMoveType.Spline;
			this.Routes = null;
		}
	}
}

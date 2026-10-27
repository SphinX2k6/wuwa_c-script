using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C6 RID: 22214
	public class IPasserbyNpcMoveBaseT
	{
		// Token: 0x1700A554 RID: 42324
		// (get) Token: 0x060251C0 RID: 152000 RVA: 0x0051FA06 File Offset: 0x0051DC06
		// (set) Token: 0x060251C1 RID: 152001 RVA: 0x0051FA0E File Offset: 0x0051DC0E
		public EPasserbyNpcMoveType Type { get; set; }

		// Token: 0x060251C2 RID: 152002 RVA: 0x0051FA17 File Offset: 0x0051DC17
		public IPasserbyNpcMoveBaseT()
		{
			this.Type = EPasserbyNpcMoveType.Spline;
		}
	}
}

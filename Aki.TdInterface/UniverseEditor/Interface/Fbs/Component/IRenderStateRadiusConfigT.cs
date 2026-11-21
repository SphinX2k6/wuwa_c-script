using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E60 RID: 24160
	public class IRenderStateRadiusConfigT
	{
		// Token: 0x1700B229 RID: 45609
		// (get) Token: 0x0602864D RID: 165453 RVA: 0x00585FB3 File Offset: 0x005841B3
		// (set) Token: 0x0602864E RID: 165454 RVA: 0x00585FBB File Offset: 0x005841BB
		public string State { get; set; }

		// Token: 0x1700B22A RID: 45610
		// (get) Token: 0x0602864F RID: 165455 RVA: 0x00585FC4 File Offset: 0x005841C4
		// (set) Token: 0x06028650 RID: 165456 RVA: 0x00585FCC File Offset: 0x005841CC
		public float Radius { get; set; }

		// Token: 0x06028651 RID: 165457 RVA: 0x00585FD5 File Offset: 0x005841D5
		public IRenderStateRadiusConfigT()
		{
			this.State = null;
			this.Radius = 0f;
		}
	}
}

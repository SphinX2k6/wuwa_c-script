using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006312 RID: 25362
	public class IChangeOtherStateT
	{
		// Token: 0x1700BD55 RID: 48469
		// (get) Token: 0x0602BDD5 RID: 179669 RVA: 0x006082F7 File Offset: 0x006064F7
		// (set) Token: 0x0602BDD6 RID: 179670 RVA: 0x006082FF File Offset: 0x006064FF
		public int EntityId { get; set; }

		// Token: 0x1700BD56 RID: 48470
		// (get) Token: 0x0602BDD7 RID: 179671 RVA: 0x00608308 File Offset: 0x00606508
		// (set) Token: 0x0602BDD8 RID: 179672 RVA: 0x00608310 File Offset: 0x00606510
		public IPlayFlowT State { get; set; }

		// Token: 0x0602BDD9 RID: 179673 RVA: 0x00608319 File Offset: 0x00606519
		public IChangeOtherStateT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007490 RID: 29840
	public class IPlayFlowT
	{
		// Token: 0x1700DB35 RID: 56117
		// (get) Token: 0x060343E0 RID: 213984 RVA: 0x00709426 File Offset: 0x00707626
		// (set) Token: 0x060343E1 RID: 213985 RVA: 0x0070942E File Offset: 0x0070762E
		public string FlowListName { get; set; }

		// Token: 0x1700DB36 RID: 56118
		// (get) Token: 0x060343E2 RID: 213986 RVA: 0x00709437 File Offset: 0x00707637
		// (set) Token: 0x060343E3 RID: 213987 RVA: 0x0070943F File Offset: 0x0070763F
		public int FlowId { get; set; }

		// Token: 0x1700DB37 RID: 56119
		// (get) Token: 0x060343E4 RID: 213988 RVA: 0x00709448 File Offset: 0x00707648
		// (set) Token: 0x060343E5 RID: 213989 RVA: 0x00709450 File Offset: 0x00707650
		public int StateId { get; set; }

		// Token: 0x1700DB38 RID: 56120
		// (get) Token: 0x060343E6 RID: 213990 RVA: 0x00709459 File Offset: 0x00707659
		// (set) Token: 0x060343E7 RID: 213991 RVA: 0x00709461 File Offset: 0x00707661
		public string FlowGuid { get; set; }

		// Token: 0x060343E8 RID: 213992 RVA: 0x0070946A File Offset: 0x0070766A
		public IPlayFlowT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
			this.FlowGuid = null;
		}
	}
}

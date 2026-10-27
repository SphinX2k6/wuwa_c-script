using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE0 RID: 27616
	public class INpcNewSplineStopTargetT
	{
		// Token: 0x1700CD34 RID: 52532
		// (get) Token: 0x06030842 RID: 198722 RVA: 0x00696314 File Offset: 0x00694514
		// (set) Token: 0x06030843 RID: 198723 RVA: 0x0069631C File Offset: 0x0069451C
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700CD35 RID: 52533
		// (get) Token: 0x06030844 RID: 198724 RVA: 0x00696325 File Offset: 0x00694525
		// (set) Token: 0x06030845 RID: 198725 RVA: 0x0069632D File Offset: 0x0069452D
		public int NpcId { get; set; }

		// Token: 0x06030846 RID: 198726 RVA: 0x00696336 File Offset: 0x00694536
		public INpcNewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.NpcId = 0;
		}
	}
}

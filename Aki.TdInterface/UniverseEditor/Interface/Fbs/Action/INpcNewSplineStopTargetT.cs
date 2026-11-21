using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007344 RID: 29508
	public class INpcNewSplineStopTargetT
	{
		// Token: 0x1700D840 RID: 55360
		// (get) Token: 0x0603375E RID: 210782 RVA: 0x006EFC14 File Offset: 0x006EDE14
		// (set) Token: 0x0603375F RID: 210783 RVA: 0x006EFC1C File Offset: 0x006EDE1C
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700D841 RID: 55361
		// (get) Token: 0x06033760 RID: 210784 RVA: 0x006EFC25 File Offset: 0x006EDE25
		// (set) Token: 0x06033761 RID: 210785 RVA: 0x006EFC2D File Offset: 0x006EDE2D
		public int NpcId { get; set; }

		// Token: 0x06033762 RID: 210786 RVA: 0x006EFC36 File Offset: 0x006EDE36
		public INpcNewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.NpcId = 0;
		}
	}
}

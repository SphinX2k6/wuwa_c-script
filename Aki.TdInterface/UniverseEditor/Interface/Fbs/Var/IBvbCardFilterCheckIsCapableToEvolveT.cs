using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A34 RID: 14900
	public class IBvbCardFilterCheckIsCapableToEvolveT
	{
		// Token: 0x1700661B RID: 26139
		// (get) Token: 0x06014298 RID: 82584 RVA: 0x002F2C1C File Offset: 0x002F0E1C
		// (set) Token: 0x06014299 RID: 82585 RVA: 0x002F2C24 File Offset: 0x002F0E24
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x1700661C RID: 26140
		// (get) Token: 0x0601429A RID: 82586 RVA: 0x002F2C2D File Offset: 0x002F0E2D
		// (set) Token: 0x0601429B RID: 82587 RVA: 0x002F2C35 File Offset: 0x002F0E35
		public int Cost { get; set; }

		// Token: 0x0601429C RID: 82588 RVA: 0x002F2C3E File Offset: 0x002F0E3E
		public IBvbCardFilterCheckIsCapableToEvolveT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.Cost = 0;
		}
	}
}

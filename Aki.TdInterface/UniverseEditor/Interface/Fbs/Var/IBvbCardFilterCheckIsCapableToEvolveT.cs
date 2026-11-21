using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E0F RID: 15887
	public class IBvbCardFilterCheckIsCapableToEvolveT
	{
		// Token: 0x17006B4B RID: 27467
		// (get) Token: 0x060155B4 RID: 87476 RVA: 0x00315E08 File Offset: 0x00314008
		// (set) Token: 0x060155B5 RID: 87477 RVA: 0x00315E10 File Offset: 0x00314010
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B4C RID: 27468
		// (get) Token: 0x060155B6 RID: 87478 RVA: 0x00315E19 File Offset: 0x00314019
		// (set) Token: 0x060155B7 RID: 87479 RVA: 0x00315E21 File Offset: 0x00314021
		public int Cost { get; set; }

		// Token: 0x060155B8 RID: 87480 RVA: 0x00315E2A File Offset: 0x0031402A
		public IBvbCardFilterCheckIsCapableToEvolveT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.Cost = 0;
		}
	}
}

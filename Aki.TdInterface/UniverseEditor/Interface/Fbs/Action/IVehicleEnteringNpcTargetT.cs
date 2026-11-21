using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CFC RID: 31996
	public class IVehicleEnteringNpcTargetT
	{
		// Token: 0x1700EF7E RID: 61310
		// (get) Token: 0x06039BCD RID: 236493 RVA: 0x007C9EBC File Offset: 0x007C80BC
		// (set) Token: 0x06039BCE RID: 236494 RVA: 0x007C9EC4 File Offset: 0x007C80C4
		public EVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700EF7F RID: 61311
		// (get) Token: 0x06039BCF RID: 236495 RVA: 0x007C9ECD File Offset: 0x007C80CD
		// (set) Token: 0x06039BD0 RID: 236496 RVA: 0x007C9ED5 File Offset: 0x007C80D5
		public int TargetVehicle { get; set; }

		// Token: 0x1700EF80 RID: 61312
		// (get) Token: 0x06039BD1 RID: 236497 RVA: 0x007C9EDE File Offset: 0x007C80DE
		// (set) Token: 0x06039BD2 RID: 236498 RVA: 0x007C9EE6 File Offset: 0x007C80E6
		public int TargetNpc { get; set; }

		// Token: 0x1700EF81 RID: 61313
		// (get) Token: 0x06039BD3 RID: 236499 RVA: 0x007C9EEF File Offset: 0x007C80EF
		// (set) Token: 0x06039BD4 RID: 236500 RVA: 0x007C9EF7 File Offset: 0x007C80F7
		public byte NullMask { get; set; }

		// Token: 0x06039BD5 RID: 236501 RVA: 0x007C9F00 File Offset: 0x007C8100
		public IVehicleEnteringNpcTargetT()
		{
			this.Type = EVehicleEnteringTarget.Player;
			this.TargetVehicle = 0;
			this.TargetNpc = 0;
			this.NullMask = 0;
		}
	}
}

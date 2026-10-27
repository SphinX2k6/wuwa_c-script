using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B72 RID: 19314
	public class ICheckVillageInfrLevelT
	{
		// Token: 0x17008C2B RID: 35883
		// (get) Token: 0x0601E6FB RID: 124667 RVA: 0x00443348 File Offset: 0x00441548
		// (set) Token: 0x0601E6FC RID: 124668 RVA: 0x00443350 File Offset: 0x00441550
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008C2C RID: 35884
		// (get) Token: 0x0601E6FD RID: 124669 RVA: 0x00443359 File Offset: 0x00441559
		// (set) Token: 0x0601E6FE RID: 124670 RVA: 0x00443361 File Offset: 0x00441561
		public int Level { get; set; }

		// Token: 0x0601E6FF RID: 124671 RVA: 0x0044336A File Offset: 0x0044156A
		public ICheckVillageInfrLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Level = 0;
		}
	}
}

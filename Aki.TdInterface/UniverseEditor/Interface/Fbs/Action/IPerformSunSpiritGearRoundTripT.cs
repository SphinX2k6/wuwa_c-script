using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FB RID: 29691
	public class IPerformSunSpiritGearRoundTripT
	{
		// Token: 0x1700DA17 RID: 55831
		// (get) Token: 0x06033F16 RID: 212758 RVA: 0x00700B40 File Offset: 0x006FED40
		// (set) Token: 0x06033F17 RID: 212759 RVA: 0x00700B48 File Offset: 0x006FED48
		public ESunSpiritGearRoundTripType PerformType { get; set; }

		// Token: 0x1700DA18 RID: 55832
		// (get) Token: 0x06033F18 RID: 212760 RVA: 0x00700B51 File Offset: 0x006FED51
		// (set) Token: 0x06033F19 RID: 212761 RVA: 0x00700B59 File Offset: 0x006FED59
		public int SunSpiritGearId { get; set; }

		// Token: 0x06033F1A RID: 212762 RVA: 0x00700B62 File Offset: 0x006FED62
		public IPerformSunSpiritGearRoundTripT()
		{
			this.PerformType = ESunSpiritGearRoundTripType.FlyToGear;
			this.SunSpiritGearId = 0;
		}
	}
}

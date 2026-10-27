using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B36 RID: 19254
	public class ICheckSunSpiritDeliveryLevelT
	{
		// Token: 0x17008BAF RID: 35759
		// (get) Token: 0x0601E4CE RID: 124110 RVA: 0x0043EF38 File Offset: 0x0043D138
		// (set) Token: 0x0601E4CF RID: 124111 RVA: 0x0043EF40 File Offset: 0x0043D140
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008BB0 RID: 35760
		// (get) Token: 0x0601E4D0 RID: 124112 RVA: 0x0043EF49 File Offset: 0x0043D149
		// (set) Token: 0x0601E4D1 RID: 124113 RVA: 0x0043EF51 File Offset: 0x0043D151
		public int Level { get; set; }

		// Token: 0x0601E4D2 RID: 124114 RVA: 0x0043EF5A File Offset: 0x0043D15A
		public ICheckSunSpiritDeliveryLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Level = 0;
		}
	}
}

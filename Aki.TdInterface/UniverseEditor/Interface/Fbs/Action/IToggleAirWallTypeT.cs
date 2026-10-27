using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EF RID: 29679
	public class IToggleAirWallTypeT
	{
		// Token: 0x1700E16A RID: 57706
		// (get) Token: 0x06035EA3 RID: 220835 RVA: 0x007565FA File Offset: 0x007547FA
		// (set) Token: 0x06035EA4 RID: 220836 RVA: 0x00756602 File Offset: 0x00754802
		public EToggleAirWall Type { get; set; }

		// Token: 0x06035EA5 RID: 220837 RVA: 0x0075660B File Offset: 0x0075480B
		public IToggleAirWallTypeT()
		{
			this.Type = EToggleAirWall.Open;
		}
	}
}

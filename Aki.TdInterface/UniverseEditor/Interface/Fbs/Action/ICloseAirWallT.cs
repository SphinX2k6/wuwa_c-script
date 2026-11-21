using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A93 RID: 27283
	public class ICloseAirWallT
	{
		// Token: 0x1700C85F RID: 51295
		// (get) Token: 0x0602ED1F RID: 191775 RVA: 0x0066170E File Offset: 0x0065F90E
		// (set) Token: 0x0602ED20 RID: 191776 RVA: 0x00661716 File Offset: 0x0065F916
		public EToggleAirWall Type { get; set; }

		// Token: 0x0602ED21 RID: 191777 RVA: 0x0066171F File Offset: 0x0065F91F
		public ICloseAirWallT()
		{
			this.Type = EToggleAirWall.Open;
		}
	}
}

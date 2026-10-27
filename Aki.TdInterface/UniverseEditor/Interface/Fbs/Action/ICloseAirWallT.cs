using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006413 RID: 25619
	public class ICloseAirWallT
	{
		// Token: 0x1700BEC5 RID: 48837
		// (get) Token: 0x0602C549 RID: 181577 RVA: 0x00615882 File Offset: 0x00613A82
		// (set) Token: 0x0602C54A RID: 181578 RVA: 0x0061588A File Offset: 0x00613A8A
		public EToggleAirWall Type { get; set; }

		// Token: 0x0602C54B RID: 181579 RVA: 0x00615893 File Offset: 0x00613A93
		public ICloseAirWallT()
		{
			this.Type = EToggleAirWall.Open;
		}
	}
}

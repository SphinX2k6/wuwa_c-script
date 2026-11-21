using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B0 RID: 21424
	public class IAirWallSpawnStyleT
	{
		// Token: 0x17009791 RID: 38801
		// (get) Token: 0x06021719 RID: 136985 RVA: 0x0049D1CE File Offset: 0x0049B3CE
		// (set) Token: 0x0602171A RID: 136986 RVA: 0x0049D1D6 File Offset: 0x0049B3D6
		public EAirWallSpawnStyle Type { get; set; }

		// Token: 0x0602171B RID: 136987 RVA: 0x0049D1DF File Offset: 0x0049B3DF
		public IAirWallSpawnStyleT()
		{
			this.Type = EAirWallSpawnStyle.AlongSpline;
		}
	}
}

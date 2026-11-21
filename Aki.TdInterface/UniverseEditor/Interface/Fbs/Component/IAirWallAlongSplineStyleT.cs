using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539E RID: 21406
	public class IAirWallAlongSplineStyleT
	{
		// Token: 0x17009768 RID: 38760
		// (get) Token: 0x0602167B RID: 136827 RVA: 0x0049C02D File Offset: 0x0049A22D
		// (set) Token: 0x0602167C RID: 136828 RVA: 0x0049C035 File Offset: 0x0049A235
		public EAirWallSpawnStyle Type { get; set; }

		// Token: 0x17009769 RID: 38761
		// (get) Token: 0x0602167D RID: 136829 RVA: 0x0049C03E File Offset: 0x0049A23E
		// (set) Token: 0x0602167E RID: 136830 RVA: 0x0049C046 File Offset: 0x0049A246
		public EAirWallAlignType AlignType { get; set; }

		// Token: 0x1700976A RID: 38762
		// (get) Token: 0x0602167F RID: 136831 RVA: 0x0049C04F File Offset: 0x0049A24F
		// (set) Token: 0x06021680 RID: 136832 RVA: 0x0049C057 File Offset: 0x0049A257
		public IAirWallCoverT Cover { get; set; }

		// Token: 0x06021681 RID: 136833 RVA: 0x0049C060 File Offset: 0x0049A260
		public IAirWallAlongSplineStyleT()
		{
			this.Type = EAirWallSpawnStyle.AlongSpline;
			this.AlignType = EAirWallAlignType.Center;
			this.Cover = null;
		}
	}
}

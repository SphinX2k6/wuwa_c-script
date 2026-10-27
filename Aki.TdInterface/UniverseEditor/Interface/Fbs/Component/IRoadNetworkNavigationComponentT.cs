using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586E RID: 22638
	public class IRoadNetworkNavigationComponentT
	{
		// Token: 0x1700A959 RID: 43353
		// (get) Token: 0x0602625C RID: 156252 RVA: 0x00542A95 File Offset: 0x00540C95
		// (set) Token: 0x0602625D RID: 156253 RVA: 0x00542A9D File Offset: 0x00540C9D
		public bool Disabled { get; set; }

		// Token: 0x1700A95A RID: 43354
		// (get) Token: 0x0602625E RID: 156254 RVA: 0x00542AA6 File Offset: 0x00540CA6
		// (set) Token: 0x0602625F RID: 156255 RVA: 0x00542AAE File Offset: 0x00540CAE
		public bool KeepSelf { get; set; }

		// Token: 0x1700A95B RID: 43355
		// (get) Token: 0x06026260 RID: 156256 RVA: 0x00542AB7 File Offset: 0x00540CB7
		// (set) Token: 0x06026261 RID: 156257 RVA: 0x00542ABF File Offset: 0x00540CBF
		public ITrafficNavigationConfigT BasicConfig { get; set; }

		// Token: 0x1700A95C RID: 43356
		// (get) Token: 0x06026262 RID: 156258 RVA: 0x00542AC8 File Offset: 0x00540CC8
		// (set) Token: 0x06026263 RID: 156259 RVA: 0x00542AD0 File Offset: 0x00540CD0
		public IObstacleDetectionConfigT ObstacleConfig { get; set; }

		// Token: 0x1700A95D RID: 43357
		// (get) Token: 0x06026264 RID: 156260 RVA: 0x00542AD9 File Offset: 0x00540CD9
		// (set) Token: 0x06026265 RID: 156261 RVA: 0x00542AE1 File Offset: 0x00540CE1
		public byte NullMask { get; set; }

		// Token: 0x06026266 RID: 156262 RVA: 0x00542AEA File Offset: 0x00540CEA
		public IRoadNetworkNavigationComponentT()
		{
			this.Disabled = false;
			this.KeepSelf = false;
			this.BasicConfig = null;
			this.ObstacleConfig = null;
			this.NullMask = 0;
		}
	}
}

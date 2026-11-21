using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E7B RID: 24187
	public class IRoadNetworkNavigationComponentT
	{
		// Token: 0x1700B289 RID: 45705
		// (get) Token: 0x060287BE RID: 165822 RVA: 0x005895E1 File Offset: 0x005877E1
		// (set) Token: 0x060287BF RID: 165823 RVA: 0x005895E9 File Offset: 0x005877E9
		public bool Disabled { get; set; }

		// Token: 0x1700B28A RID: 45706
		// (get) Token: 0x060287C0 RID: 165824 RVA: 0x005895F2 File Offset: 0x005877F2
		// (set) Token: 0x060287C1 RID: 165825 RVA: 0x005895FA File Offset: 0x005877FA
		public bool KeepSelf { get; set; }

		// Token: 0x1700B28B RID: 45707
		// (get) Token: 0x060287C2 RID: 165826 RVA: 0x00589603 File Offset: 0x00587803
		// (set) Token: 0x060287C3 RID: 165827 RVA: 0x0058960B File Offset: 0x0058780B
		public ITrafficNavigationConfigT BasicConfig { get; set; }

		// Token: 0x1700B28C RID: 45708
		// (get) Token: 0x060287C4 RID: 165828 RVA: 0x00589614 File Offset: 0x00587814
		// (set) Token: 0x060287C5 RID: 165829 RVA: 0x0058961C File Offset: 0x0058781C
		public IObstacleDetectionConfigT ObstacleConfig { get; set; }

		// Token: 0x1700B28D RID: 45709
		// (get) Token: 0x060287C6 RID: 165830 RVA: 0x00589625 File Offset: 0x00587825
		// (set) Token: 0x060287C7 RID: 165831 RVA: 0x0058962D File Offset: 0x0058782D
		public byte NullMask { get; set; }

		// Token: 0x060287C8 RID: 165832 RVA: 0x00589636 File Offset: 0x00587836
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

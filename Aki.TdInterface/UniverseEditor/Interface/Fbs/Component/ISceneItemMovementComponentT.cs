using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED8 RID: 24280
	public class ISceneItemMovementComponentT
	{
		// Token: 0x1700B367 RID: 45927
		// (get) Token: 0x06028B36 RID: 166710 RVA: 0x005903A3 File Offset: 0x0058E5A3
		// (set) Token: 0x06028B37 RID: 166711 RVA: 0x005903AB File Offset: 0x0058E5AB
		public bool Disabled { get; set; }

		// Token: 0x1700B368 RID: 45928
		// (get) Token: 0x06028B38 RID: 166712 RVA: 0x005903B4 File Offset: 0x0058E5B4
		// (set) Token: 0x06028B39 RID: 166713 RVA: 0x005903BC File Offset: 0x0058E5BC
		public ISplineMoveT Patrol { get; set; }

		// Token: 0x1700B369 RID: 45929
		// (get) Token: 0x06028B3A RID: 166714 RVA: 0x005903C5 File Offset: 0x0058E5C5
		// (set) Token: 0x06028B3B RID: 166715 RVA: 0x005903CD File Offset: 0x0058E5CD
		public IMovementPlatformConfigT PlatformConfig { get; set; }

		// Token: 0x1700B36A RID: 45930
		// (get) Token: 0x06028B3C RID: 166716 RVA: 0x005903D6 File Offset: 0x0058E5D6
		// (set) Token: 0x06028B3D RID: 166717 RVA: 0x005903DE File Offset: 0x0058E5DE
		public byte NullMask { get; set; }

		// Token: 0x06028B3E RID: 166718 RVA: 0x005903E7 File Offset: 0x0058E5E7
		public ISceneItemMovementComponentT()
		{
			this.Disabled = false;
			this.Patrol = null;
			this.PlatformConfig = null;
			this.NullMask = 0;
		}
	}
}

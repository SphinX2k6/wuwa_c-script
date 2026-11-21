using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AB RID: 22699
	public class IGravityFlipConfigT
	{
		// Token: 0x1700A486 RID: 42118
		// (get) Token: 0x06024D3C RID: 150844 RVA: 0x0050E84C File Offset: 0x0050CA4C
		// (set) Token: 0x06024D3D RID: 150845 RVA: 0x0050E854 File Offset: 0x0050CA54
		public EGravityFlipType Type { get; set; }

		// Token: 0x1700A487 RID: 42119
		// (get) Token: 0x06024D3E RID: 150846 RVA: 0x0050E85D File Offset: 0x0050CA5D
		// (set) Token: 0x06024D3F RID: 150847 RVA: 0x0050E865 File Offset: 0x0050CA65
		public int LocationEntityId { get; set; }

		// Token: 0x06024D40 RID: 150848 RVA: 0x0050E86E File Offset: 0x0050CA6E
		public IGravityFlipConfigT()
		{
			this.Type = EGravityFlipType.None;
			this.LocationEntityId = 0;
		}
	}
}

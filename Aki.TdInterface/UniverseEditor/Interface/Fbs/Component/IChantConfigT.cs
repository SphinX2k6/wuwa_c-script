using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F7A RID: 20346
	public class IChantConfigT
	{
		// Token: 0x1700930B RID: 37643
		// (get) Token: 0x060204C7 RID: 132295 RVA: 0x0047E6BC File Offset: 0x0047C8BC
		// (set) Token: 0x060204C8 RID: 132296 RVA: 0x0047E6C4 File Offset: 0x0047C8C4
		public int ChantTime { get; set; }

		// Token: 0x1700930C RID: 37644
		// (get) Token: 0x060204C9 RID: 132297 RVA: 0x0047E6CD File Offset: 0x0047C8CD
		// (set) Token: 0x060204CA RID: 132298 RVA: 0x0047E6D5 File Offset: 0x0047C8D5
		public string ChantCameraShake { get; set; }

		// Token: 0x1700930D RID: 37645
		// (get) Token: 0x060204CB RID: 132299 RVA: 0x0047E6DE File Offset: 0x0047C8DE
		// (set) Token: 0x060204CC RID: 132300 RVA: 0x0047E6E6 File Offset: 0x0047C8E6
		public string ChantCameraStateTag { get; set; }

		// Token: 0x060204CD RID: 132301 RVA: 0x0047E6EF File Offset: 0x0047C8EF
		public IChantConfigT()
		{
			this.ChantTime = 0;
			this.ChantCameraShake = null;
			this.ChantCameraStateTag = null;
		}
	}
}

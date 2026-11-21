using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A9 RID: 21673
	public class IChantConfigT
	{
		// Token: 0x17009A84 RID: 39556
		// (get) Token: 0x06022219 RID: 139801 RVA: 0x004B46AC File Offset: 0x004B28AC
		// (set) Token: 0x0602221A RID: 139802 RVA: 0x004B46B4 File Offset: 0x004B28B4
		public int ChantTime { get; set; }

		// Token: 0x17009A85 RID: 39557
		// (get) Token: 0x0602221B RID: 139803 RVA: 0x004B46BD File Offset: 0x004B28BD
		// (set) Token: 0x0602221C RID: 139804 RVA: 0x004B46C5 File Offset: 0x004B28C5
		public string ChantCameraShake { get; set; }

		// Token: 0x17009A86 RID: 39558
		// (get) Token: 0x0602221D RID: 139805 RVA: 0x004B46CE File Offset: 0x004B28CE
		// (set) Token: 0x0602221E RID: 139806 RVA: 0x004B46D6 File Offset: 0x004B28D6
		public string ChantCameraStateTag { get; set; }

		// Token: 0x0602221F RID: 139807 RVA: 0x004B46DF File Offset: 0x004B28DF
		public IChantConfigT()
		{
			this.ChantTime = 0;
			this.ChantCameraShake = null;
			this.ChantCameraStateTag = null;
		}
	}
}

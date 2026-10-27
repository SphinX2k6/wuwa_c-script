using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597B RID: 22907
	public class ISpeedEffectConfigT
	{
		// Token: 0x1700ABE0 RID: 44000
		// (get) Token: 0x06026C6D RID: 158829 RVA: 0x00556719 File Offset: 0x00554919
		// (set) Token: 0x06026C6E RID: 158830 RVA: 0x00556721 File Offset: 0x00554921
		public float MinVehicleSpeed { get; set; }

		// Token: 0x1700ABE1 RID: 44001
		// (get) Token: 0x06026C6F RID: 158831 RVA: 0x0055672A File Offset: 0x0055492A
		// (set) Token: 0x06026C70 RID: 158832 RVA: 0x00556732 File Offset: 0x00554932
		public float MaxVehicleSpeed { get; set; }

		// Token: 0x1700ABE2 RID: 44002
		// (get) Token: 0x06026C71 RID: 158833 RVA: 0x0055673B File Offset: 0x0055493B
		// (set) Token: 0x06026C72 RID: 158834 RVA: 0x00556743 File Offset: 0x00554943
		public List<long> GameplayCueIds { get; set; }

		// Token: 0x06026C73 RID: 158835 RVA: 0x0055674C File Offset: 0x0055494C
		public ISpeedEffectConfigT()
		{
			this.MinVehicleSpeed = 0f;
			this.MaxVehicleSpeed = 0f;
			this.GameplayCueIds = null;
		}
	}
}

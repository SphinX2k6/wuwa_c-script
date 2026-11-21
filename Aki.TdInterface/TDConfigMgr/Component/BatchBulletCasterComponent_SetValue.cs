using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200002B RID: 43
	public class BatchBulletCasterComponent_SetValue
	{
		// Token: 0x040000F0 RID: 240
		public bool? Disabled;

		// Token: 0x040000F1 RID: 241
		public bool? EdIsLocked;

		// Token: 0x040000F2 RID: 242
		public string WarningEffect;

		// Token: 0x040000F3 RID: 243
		public EBatchBulletMovementType? MovementType;

		// Token: 0x040000F4 RID: 244
		public List<IPosRot> BulletList;

		// Token: 0x040000F5 RID: 245
		public List<IBatchBulletItem> BatchList;
	}
}

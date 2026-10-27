using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200002B RID: 43
	[NullableContext(1)]
	[Nullable(0)]
	public class BatchBulletCasterComponent_SetValue
	{
		// Token: 0x040000EB RID: 235
		public bool? Disabled;

		// Token: 0x040000EC RID: 236
		public bool? EdIsLocked;

		// Token: 0x040000ED RID: 237
		public string WarningEffect;

		// Token: 0x040000EE RID: 238
		public EBatchBulletMovementType? MovementType;

		// Token: 0x040000EF RID: 239
		public List<IPosRot> BulletList;

		// Token: 0x040000F0 RID: 240
		public List<IBatchBulletItem> BatchList;
	}
}

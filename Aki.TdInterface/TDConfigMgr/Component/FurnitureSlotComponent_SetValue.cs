using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017E RID: 382
	public class FurnitureSlotComponent_SetValue
	{
		// Token: 0x0400074C RID: 1868
		public bool? Disabled;

		// Token: 0x0400074D RID: 1869
		public bool? EdIsLocked;

		// Token: 0x0400074E RID: 1870
		[Nullable(1)]
		public List<IFurnitureSlot> Slots;

		// Token: 0x0400074F RID: 1871
		[Nullable(2)]
		public IFurnitureCamera FurnitureCamera;
	}
}

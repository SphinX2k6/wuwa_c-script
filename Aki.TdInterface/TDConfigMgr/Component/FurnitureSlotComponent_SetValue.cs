using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000195 RID: 405
	public class FurnitureSlotComponent_SetValue
	{
		// Token: 0x040007A2 RID: 1954
		public bool? Disabled;

		// Token: 0x040007A3 RID: 1955
		public bool? EdIsLocked;

		// Token: 0x040007A4 RID: 1956
		public List<IFurnitureSlot> Slots;

		// Token: 0x040007A5 RID: 1957
		[Nullable(2)]
		public IFurnitureCamera FurnitureCamera;
	}
}

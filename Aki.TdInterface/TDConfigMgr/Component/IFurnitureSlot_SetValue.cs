using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000424 RID: 1060
	public class IFurnitureSlot_SetValue
	{
		// Token: 0x040010AB RID: 4267
		[Nullable(2)]
		public IFurnitureCamera SlotCamera;

		// Token: 0x040010AC RID: 4268
		public ISlotShape SlotShape;

		// Token: 0x040010AD RID: 4269
		public int FurnitureTag;

		// Token: 0x040010AE RID: 4270
		[Nullable(2)]
		public List<int> ExcludedFurnitureIds;

		// Token: 0x040010AF RID: 4271
		public int? EdPreviewFurnitureId;
	}
}

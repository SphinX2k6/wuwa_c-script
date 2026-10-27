using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003CD RID: 973
	[NullableContext(2)]
	[Nullable(0)]
	public class IFurnitureSlot_SetValue
	{
		// Token: 0x04000F92 RID: 3986
		public IFurnitureCamera SlotCamera;

		// Token: 0x04000F93 RID: 3987
		[Nullable(1)]
		public ISlotShape SlotShape;

		// Token: 0x04000F94 RID: 3988
		public int FurnitureTag;

		// Token: 0x04000F95 RID: 3989
		public List<int> ExcludedFurnitureIds;

		// Token: 0x04000F96 RID: 3990
		public int? EdPreviewFurnitureId;
	}
}

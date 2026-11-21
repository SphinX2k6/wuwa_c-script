using System;
using System.Runtime.CompilerServices;

// Token: 0x0200043D RID: 1085
[NullableContext(1)]
public interface IFurniturePresetViewOpenData
{
	// Token: 0x17000808 RID: 2056
	// (get) Token: 0x06003998 RID: 14744
	FurnitureAreaData AreaData { get; }

	// Token: 0x17000809 RID: 2057
	// (get) Token: 0x06003999 RID: 14745
	Action<FurnitureAreaData> OnApplyDelegate { get; }
}

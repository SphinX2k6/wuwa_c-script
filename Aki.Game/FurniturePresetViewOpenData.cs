using System;
using System.Runtime.CompilerServices;

// Token: 0x0200043E RID: 1086
[NullableContext(1)]
[Nullable(0)]
public class FurniturePresetViewOpenData : IFurniturePresetViewOpenData
{
	// Token: 0x1700080A RID: 2058
	// (get) Token: 0x0600399A RID: 14746 RVA: 0x0014C740 File Offset: 0x0014A940
	// (set) Token: 0x0600399B RID: 14747 RVA: 0x0014C748 File Offset: 0x0014A948
	public FurnitureAreaData AreaData { get; set; }

	// Token: 0x1700080B RID: 2059
	// (get) Token: 0x0600399C RID: 14748 RVA: 0x0014C751 File Offset: 0x0014A951
	// (set) Token: 0x0600399D RID: 14749 RVA: 0x0014C759 File Offset: 0x0014A959
	public Action<FurnitureAreaData> OnApplyDelegate { get; set; }
}

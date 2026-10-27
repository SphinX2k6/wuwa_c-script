using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F89 RID: 3977
[NullableContext(1)]
[Nullable(0)]
public class FurniturePresetViewOpenData : IFurniturePresetViewOpenData
{
	// Token: 0x170007E8 RID: 2024
	// (get) Token: 0x06006602 RID: 26114 RVA: 0x00143EAC File Offset: 0x001420AC
	// (set) Token: 0x06006603 RID: 26115 RVA: 0x00143EB4 File Offset: 0x001420B4
	public FurnitureAreaData AreaData { get; set; }

	// Token: 0x170007E9 RID: 2025
	// (get) Token: 0x06006604 RID: 26116 RVA: 0x00143EBD File Offset: 0x001420BD
	// (set) Token: 0x06006605 RID: 26117 RVA: 0x00143EC5 File Offset: 0x001420C5
	public Action<FurnitureAreaData> OnApplyDelegate { get; set; }
}

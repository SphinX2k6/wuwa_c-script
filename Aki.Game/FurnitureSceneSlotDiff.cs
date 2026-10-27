using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F94 RID: 3988
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneSlotDiff : IFurnitureSceneSlotDiff
{
	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x0600662C RID: 26156 RVA: 0x00143F98 File Offset: 0x00142198
	// (set) Token: 0x0600662D RID: 26157 RVA: 0x00143FA0 File Offset: 0x001421A0
	public int RootFurnitureToPlace { get; set; }

	// Token: 0x17000803 RID: 2051
	// (get) Token: 0x0600662E RID: 26158 RVA: 0x00143FA9 File Offset: 0x001421A9
	// (set) Token: 0x0600662F RID: 26159 RVA: 0x00143FB1 File Offset: 0x001421B1
	public int RootFurnitureToUnPlace { get; set; }

	// Token: 0x17000804 RID: 2052
	// (get) Token: 0x06006630 RID: 26160 RVA: 0x00143FBA File Offset: 0x001421BA
	// (set) Token: 0x06006631 RID: 26161 RVA: 0x00143FC2 File Offset: 0x001421C2
	public int[] SubFurnitureListToPlace { get; set; }

	// Token: 0x17000805 RID: 2053
	// (get) Token: 0x06006632 RID: 26162 RVA: 0x00143FCB File Offset: 0x001421CB
	// (set) Token: 0x06006633 RID: 26163 RVA: 0x00143FD3 File Offset: 0x001421D3
	public int[] SubFurnitureListToUnPlace { get; set; }
}

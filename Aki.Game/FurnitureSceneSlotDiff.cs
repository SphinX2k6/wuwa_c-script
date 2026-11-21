using System;
using System.Runtime.CompilerServices;

// Token: 0x02000449 RID: 1097
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneSlotDiff : IFurnitureSceneSlotDiff
{
	// Token: 0x17000824 RID: 2084
	// (get) Token: 0x060039C4 RID: 14788 RVA: 0x0014C82C File Offset: 0x0014AA2C
	// (set) Token: 0x060039C5 RID: 14789 RVA: 0x0014C834 File Offset: 0x0014AA34
	public int RootFurnitureToPlace { get; set; }

	// Token: 0x17000825 RID: 2085
	// (get) Token: 0x060039C6 RID: 14790 RVA: 0x0014C83D File Offset: 0x0014AA3D
	// (set) Token: 0x060039C7 RID: 14791 RVA: 0x0014C845 File Offset: 0x0014AA45
	public int RootFurnitureToUnPlace { get; set; }

	// Token: 0x17000826 RID: 2086
	// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0014C84E File Offset: 0x0014AA4E
	// (set) Token: 0x060039C9 RID: 14793 RVA: 0x0014C856 File Offset: 0x0014AA56
	public int[] SubFurnitureListToPlace { get; set; }

	// Token: 0x17000827 RID: 2087
	// (get) Token: 0x060039CA RID: 14794 RVA: 0x0014C85F File Offset: 0x0014AA5F
	// (set) Token: 0x060039CB RID: 14795 RVA: 0x0014C867 File Offset: 0x0014AA67
	public int[] SubFurnitureListToUnPlace { get; set; }
}

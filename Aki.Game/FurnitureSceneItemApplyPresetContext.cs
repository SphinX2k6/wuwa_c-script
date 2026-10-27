using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA5 RID: 4005
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemApplyPresetContext : IFurnitureSceneItemApplyPresetContext
{
	// Token: 0x17000826 RID: 2086
	// (get) Token: 0x0600666B RID: 26219 RVA: 0x0014411B File Offset: 0x0014231B
	// (set) Token: 0x0600666C RID: 26220 RVA: 0x00144123 File Offset: 0x00142323
	public int PresetId { get; set; }

	// Token: 0x17000827 RID: 2087
	// (get) Token: 0x0600666D RID: 26221 RVA: 0x0014412C File Offset: 0x0014232C
	// (set) Token: 0x0600666E RID: 26222 RVA: 0x00144134 File Offset: 0x00142334
	public FurnitureAreaData AreaData { get; set; }
}

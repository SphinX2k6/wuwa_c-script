using System;
using System.Runtime.CompilerServices;

// Token: 0x0200045C RID: 1116
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemChangeAreaFurnitureContext : IFurnitureSceneItemChangeAreaFurnitureContext
{
	// Token: 0x1700084C RID: 2124
	// (get) Token: 0x06003A0A RID: 14858 RVA: 0x0014C9D9 File Offset: 0x0014ABD9
	// (set) Token: 0x06003A0B RID: 14859 RVA: 0x0014C9E1 File Offset: 0x0014ABE1
	public FurnitureAreaData SourceAreaData { get; set; }

	// Token: 0x1700084D RID: 2125
	// (get) Token: 0x06003A0C RID: 14860 RVA: 0x0014C9EA File Offset: 0x0014ABEA
	// (set) Token: 0x06003A0D RID: 14861 RVA: 0x0014C9F2 File Offset: 0x0014ABF2
	public FurnitureAreaData TargetAreaData { get; set; }
}

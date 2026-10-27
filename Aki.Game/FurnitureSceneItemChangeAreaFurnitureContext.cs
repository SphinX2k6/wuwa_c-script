using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FA7 RID: 4007
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemChangeAreaFurnitureContext : IFurnitureSceneItemChangeAreaFurnitureContext
{
	// Token: 0x1700082A RID: 2090
	// (get) Token: 0x06006672 RID: 26226 RVA: 0x00144145 File Offset: 0x00142345
	// (set) Token: 0x06006673 RID: 26227 RVA: 0x0014414D File Offset: 0x0014234D
	public FurnitureAreaData SourceAreaData { get; set; }

	// Token: 0x1700082B RID: 2091
	// (get) Token: 0x06006674 RID: 26228 RVA: 0x00144156 File Offset: 0x00142356
	// (set) Token: 0x06006675 RID: 26229 RVA: 0x0014415E File Offset: 0x0014235E
	public FurnitureAreaData TargetAreaData { get; set; }
}

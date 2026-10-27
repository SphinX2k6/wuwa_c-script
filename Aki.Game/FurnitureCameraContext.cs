using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F97 RID: 3991
[NullableContext(1)]
[Nullable(0)]
public class FurnitureCameraContext : IFurnitureCameraContext
{
	// Token: 0x17000809 RID: 2057
	// (get) Token: 0x06006638 RID: 26168 RVA: 0x00143FE4 File Offset: 0x001421E4
	// (set) Token: 0x06006639 RID: 26169 RVA: 0x00143FEC File Offset: 0x001421EC
	public Vector Pos { get; set; }

	// Token: 0x1700080A RID: 2058
	// (get) Token: 0x0600663A RID: 26170 RVA: 0x00143FF5 File Offset: 0x001421F5
	// (set) Token: 0x0600663B RID: 26171 RVA: 0x00143FFD File Offset: 0x001421FD
	public Rotator Rot { get; set; }

	// Token: 0x1700080B RID: 2059
	// (get) Token: 0x0600663C RID: 26172 RVA: 0x00144006 File Offset: 0x00142206
	// (set) Token: 0x0600663D RID: 26173 RVA: 0x0014400E File Offset: 0x0014220E
	public float Fov { get; set; }
}

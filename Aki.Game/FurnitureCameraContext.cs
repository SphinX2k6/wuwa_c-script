using System;
using System.Runtime.CompilerServices;

// Token: 0x0200044C RID: 1100
[NullableContext(1)]
[Nullable(0)]
public class FurnitureCameraContext : IFurnitureCameraContext
{
	// Token: 0x1700082B RID: 2091
	// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0014C878 File Offset: 0x0014AA78
	// (set) Token: 0x060039D1 RID: 14801 RVA: 0x0014C880 File Offset: 0x0014AA80
	public Vector Pos { get; set; }

	// Token: 0x1700082C RID: 2092
	// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0014C889 File Offset: 0x0014AA89
	// (set) Token: 0x060039D3 RID: 14803 RVA: 0x0014C891 File Offset: 0x0014AA91
	public Rotator Rot { get; set; }

	// Token: 0x1700082D RID: 2093
	// (get) Token: 0x060039D4 RID: 14804 RVA: 0x0014C89A File Offset: 0x0014AA9A
	// (set) Token: 0x060039D5 RID: 14805 RVA: 0x0014C8A2 File Offset: 0x0014AAA2
	public float Fov { get; set; }
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x020023A4 RID: 9124
[NullableContext(1)]
[Nullable(0)]
public class VehicleBuffContextImpl : TsVehicleBlueprintFunctionLibrary.IVehicleBuffContext
{
	// Token: 0x1700230F RID: 8975
	// (get) Token: 0x06016D66 RID: 93542 RVA: 0x006A7FAC File Offset: 0x006A61AC
	// (set) Token: 0x06016D67 RID: 93543 RVA: 0x006A7FB4 File Offset: 0x006A61B4
	public int EntityId { get; set; }

	// Token: 0x17002310 RID: 8976
	// (get) Token: 0x06016D68 RID: 93544 RVA: 0x006A7FBD File Offset: 0x006A61BD
	// (set) Token: 0x06016D69 RID: 93545 RVA: 0x006A7FC5 File Offset: 0x006A61C5
	public long BuffId { get; set; }

	// Token: 0x17002311 RID: 8977
	// (get) Token: 0x06016D6A RID: 93546 RVA: 0x006A7FCE File Offset: 0x006A61CE
	// (set) Token: 0x06016D6B RID: 93547 RVA: 0x006A7FD6 File Offset: 0x006A61D6
	public string SkillId { get; set; } = "";
}

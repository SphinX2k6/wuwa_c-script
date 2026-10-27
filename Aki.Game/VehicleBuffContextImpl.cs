using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E48 RID: 11848
[NullableContext(1)]
[Nullable(0)]
public class VehicleBuffContextImpl : TsVehicleBlueprintFunctionLibrary.IVehicleBuffContext
{
	// Token: 0x1700229B RID: 8859
	// (get) Token: 0x06019488 RID: 103560 RVA: 0x00681C20 File Offset: 0x0067FE20
	// (set) Token: 0x06019489 RID: 103561 RVA: 0x00681C28 File Offset: 0x0067FE28
	public int EntityId { get; set; }

	// Token: 0x1700229C RID: 8860
	// (get) Token: 0x0601948A RID: 103562 RVA: 0x00681C31 File Offset: 0x0067FE31
	// (set) Token: 0x0601948B RID: 103563 RVA: 0x00681C39 File Offset: 0x0067FE39
	public long BuffId { get; set; }

	// Token: 0x1700229D RID: 8861
	// (get) Token: 0x0601948C RID: 103564 RVA: 0x00681C42 File Offset: 0x0067FE42
	// (set) Token: 0x0601948D RID: 103565 RVA: 0x00681C4A File Offset: 0x0067FE4A
	public string SkillId { get; set; } = "";
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x0200225D RID: 8797
[NullableContext(2)]
[Nullable(0)]
public class MotorTechLevelPoint : IMotorTechLevelPoint
{
	// Token: 0x170015E1 RID: 5601
	// (get) Token: 0x0601127D RID: 70269 RVA: 0x0042E39B File Offset: 0x0042C59B
	// (set) Token: 0x0601127E RID: 70270 RVA: 0x0042E3A3 File Offset: 0x0042C5A3
	public string Title { get; set; }

	// Token: 0x170015E2 RID: 5602
	// (get) Token: 0x0601127F RID: 70271 RVA: 0x0042E3AC File Offset: 0x0042C5AC
	// (set) Token: 0x06011280 RID: 70272 RVA: 0x0042E3B4 File Offset: 0x0042C5B4
	public string Desc { get; set; }

	// Token: 0x170015E3 RID: 5603
	// (get) Token: 0x06011281 RID: 70273 RVA: 0x0042E3BD File Offset: 0x0042C5BD
	// (set) Token: 0x06011282 RID: 70274 RVA: 0x0042E3C5 File Offset: 0x0042C5C5
	public int TargetLevel { get; set; }

	// Token: 0x170015E4 RID: 5604
	// (get) Token: 0x06011283 RID: 70275 RVA: 0x0042E3CE File Offset: 0x0042C5CE
	// (set) Token: 0x06011284 RID: 70276 RVA: 0x0042E3D6 File Offset: 0x0042C5D6
	public int CurLevel { get; set; }
}

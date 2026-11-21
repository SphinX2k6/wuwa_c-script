using System;
using System.Runtime.CompilerServices;

// Token: 0x02000477 RID: 1143
[NullableContext(1)]
[Nullable(0)]
public class FurnitureAreaSelectItemData : IFurnitureAreaSelectItemData
{
	// Token: 0x17000872 RID: 2162
	// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x0014EFCF File Offset: 0x0014D1CF
	// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x0014EFD7 File Offset: 0x0014D1D7
	public int AreaId { get; set; }

	// Token: 0x17000873 RID: 2163
	// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x0014EFE0 File Offset: 0x0014D1E0
	// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x0014EFE8 File Offset: 0x0014D1E8
	public int FloorId { get; set; }

	// Token: 0x17000874 RID: 2164
	// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x0014EFF1 File Offset: 0x0014D1F1
	// (set) Token: 0x06003AE6 RID: 15078 RVA: 0x0014EFF9 File Offset: 0x0014D1F9
	public string AreaName { get; set; }

	// Token: 0x17000875 RID: 2165
	// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x0014F002 File Offset: 0x0014D202
	// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x0014F00A File Offset: 0x0014D20A
	public string LockAreaIcon { get; set; }

	// Token: 0x17000876 RID: 2166
	// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x0014F013 File Offset: 0x0014D213
	// (set) Token: 0x06003AEA RID: 15082 RVA: 0x0014F01B File Offset: 0x0014D21B
	public string UnlockAreaIcon { get; set; }

	// Token: 0x17000877 RID: 2167
	// (get) Token: 0x06003AEB RID: 15083 RVA: 0x0014F024 File Offset: 0x0014D224
	// (set) Token: 0x06003AEC RID: 15084 RVA: 0x0014F02C File Offset: 0x0014D22C
	public bool IsSelected { get; set; }

	// Token: 0x17000878 RID: 2168
	// (get) Token: 0x06003AED RID: 15085 RVA: 0x0014F035 File Offset: 0x0014D235
	// (set) Token: 0x06003AEE RID: 15086 RVA: 0x0014F03D File Offset: 0x0014D23D
	public bool IsUnlock { get; set; }

	// Token: 0x17000879 RID: 2169
	// (get) Token: 0x06003AEF RID: 15087 RVA: 0x0014F046 File Offset: 0x0014D246
	// (set) Token: 0x06003AF0 RID: 15088 RVA: 0x0014F04E File Offset: 0x0014D24E
	public int PlacedSlotCount { get; set; }

	// Token: 0x1700087A RID: 2170
	// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x0014F057 File Offset: 0x0014D257
	// (set) Token: 0x06003AF2 RID: 15090 RVA: 0x0014F05F File Offset: 0x0014D25F
	public int MaxSlotCount { get; set; }

	// Token: 0x1700087B RID: 2171
	// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x0014F068 File Offset: 0x0014D268
	// (set) Token: 0x06003AF4 RID: 15092 RVA: 0x0014F070 File Offset: 0x0014D270
	public bool RedDotShowState { get; set; }

	// Token: 0x1700087C RID: 2172
	// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x0014F079 File Offset: 0x0014D279
	// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x0014F081 File Offset: 0x0014D281
	public Action<int> OnSelected { get; set; }
}

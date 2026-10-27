using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FC2 RID: 4034
[NullableContext(1)]
[Nullable(0)]
public class FurnitureAreaSelectItemData : IFurnitureAreaSelectItemData
{
	// Token: 0x17000850 RID: 2128
	// (get) Token: 0x06006749 RID: 26441 RVA: 0x0014670B File Offset: 0x0014490B
	// (set) Token: 0x0600674A RID: 26442 RVA: 0x00146713 File Offset: 0x00144913
	public int AreaId { get; set; }

	// Token: 0x17000851 RID: 2129
	// (get) Token: 0x0600674B RID: 26443 RVA: 0x0014671C File Offset: 0x0014491C
	// (set) Token: 0x0600674C RID: 26444 RVA: 0x00146724 File Offset: 0x00144924
	public int FloorId { get; set; }

	// Token: 0x17000852 RID: 2130
	// (get) Token: 0x0600674D RID: 26445 RVA: 0x0014672D File Offset: 0x0014492D
	// (set) Token: 0x0600674E RID: 26446 RVA: 0x00146735 File Offset: 0x00144935
	public string AreaName { get; set; }

	// Token: 0x17000853 RID: 2131
	// (get) Token: 0x0600674F RID: 26447 RVA: 0x0014673E File Offset: 0x0014493E
	// (set) Token: 0x06006750 RID: 26448 RVA: 0x00146746 File Offset: 0x00144946
	public string LockAreaIcon { get; set; }

	// Token: 0x17000854 RID: 2132
	// (get) Token: 0x06006751 RID: 26449 RVA: 0x0014674F File Offset: 0x0014494F
	// (set) Token: 0x06006752 RID: 26450 RVA: 0x00146757 File Offset: 0x00144957
	public string UnlockAreaIcon { get; set; }

	// Token: 0x17000855 RID: 2133
	// (get) Token: 0x06006753 RID: 26451 RVA: 0x00146760 File Offset: 0x00144960
	// (set) Token: 0x06006754 RID: 26452 RVA: 0x00146768 File Offset: 0x00144968
	public bool IsSelected { get; set; }

	// Token: 0x17000856 RID: 2134
	// (get) Token: 0x06006755 RID: 26453 RVA: 0x00146771 File Offset: 0x00144971
	// (set) Token: 0x06006756 RID: 26454 RVA: 0x00146779 File Offset: 0x00144979
	public bool IsUnlock { get; set; }

	// Token: 0x17000857 RID: 2135
	// (get) Token: 0x06006757 RID: 26455 RVA: 0x00146782 File Offset: 0x00144982
	// (set) Token: 0x06006758 RID: 26456 RVA: 0x0014678A File Offset: 0x0014498A
	public int PlacedSlotCount { get; set; }

	// Token: 0x17000858 RID: 2136
	// (get) Token: 0x06006759 RID: 26457 RVA: 0x00146793 File Offset: 0x00144993
	// (set) Token: 0x0600675A RID: 26458 RVA: 0x0014679B File Offset: 0x0014499B
	public int MaxSlotCount { get; set; }

	// Token: 0x17000859 RID: 2137
	// (get) Token: 0x0600675B RID: 26459 RVA: 0x001467A4 File Offset: 0x001449A4
	// (set) Token: 0x0600675C RID: 26460 RVA: 0x001467AC File Offset: 0x001449AC
	public bool RedDotShowState { get; set; }

	// Token: 0x1700085A RID: 2138
	// (get) Token: 0x0600675D RID: 26461 RVA: 0x001467B5 File Offset: 0x001449B5
	// (set) Token: 0x0600675E RID: 26462 RVA: 0x001467BD File Offset: 0x001449BD
	public Action<int> OnSelected { get; set; }
}

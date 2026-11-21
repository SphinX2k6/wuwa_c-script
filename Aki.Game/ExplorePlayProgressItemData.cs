using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F66 RID: 3942
[NullableContext(2)]
[Nullable(0)]
public class ExplorePlayProgressItemData : IExplorePlayProgressItemData
{
	// Token: 0x170010C1 RID: 4289
	// (get) Token: 0x06009E1B RID: 40475 RVA: 0x002EC946 File Offset: 0x002EAB46
	// (set) Token: 0x06009E1C RID: 40476 RVA: 0x002EC94E File Offset: 0x002EAB4E
	public EExploreType ExploreType { get; set; }

	// Token: 0x170010C2 RID: 4290
	// (get) Token: 0x06009E1D RID: 40477 RVA: 0x002EC957 File Offset: 0x002EAB57
	// (set) Token: 0x06009E1E RID: 40478 RVA: 0x002EC95F File Offset: 0x002EAB5F
	public EPlayPointType PlayPointType { get; set; }

	// Token: 0x170010C3 RID: 4291
	// (get) Token: 0x06009E1F RID: 40479 RVA: 0x002EC968 File Offset: 0x002EAB68
	// (set) Token: 0x06009E20 RID: 40480 RVA: 0x002EC970 File Offset: 0x002EAB70
	public EPlayPointState PlayPointState { get; set; }

	// Token: 0x170010C4 RID: 4292
	// (get) Token: 0x06009E21 RID: 40481 RVA: 0x002EC979 File Offset: 0x002EAB79
	// (set) Token: 0x06009E22 RID: 40482 RVA: 0x002EC981 File Offset: 0x002EAB81
	public int? PlayPointId { get; set; }

	// Token: 0x170010C5 RID: 4293
	// (get) Token: 0x06009E23 RID: 40483 RVA: 0x002EC98A File Offset: 0x002EAB8A
	// (set) Token: 0x06009E24 RID: 40484 RVA: 0x002EC992 File Offset: 0x002EAB92
	public EPlayPointState? LastPlayPointState { get; set; }

	// Token: 0x170010C6 RID: 4294
	// (get) Token: 0x06009E25 RID: 40485 RVA: 0x002EC99B File Offset: 0x002EAB9B
	// (set) Token: 0x06009E26 RID: 40486 RVA: 0x002EC9A3 File Offset: 0x002EABA3
	public int? EntityId { get; set; }

	// Token: 0x170010C7 RID: 4295
	// (get) Token: 0x06009E27 RID: 40487 RVA: 0x002EC9AC File Offset: 0x002EABAC
	// (set) Token: 0x06009E28 RID: 40488 RVA: 0x002EC9B4 File Offset: 0x002EABB4
	public bool? IgnoreHiddenType { get; set; }

	// Token: 0x170010C8 RID: 4296
	// (get) Token: 0x06009E29 RID: 40489 RVA: 0x002EC9BD File Offset: 0x002EABBD
	// (set) Token: 0x06009E2A RID: 40490 RVA: 0x002EC9C5 File Offset: 0x002EABC5
	public bool? IsClear { get; set; }

	// Token: 0x170010C9 RID: 4297
	// (get) Token: 0x06009E2B RID: 40491 RVA: 0x002EC9CE File Offset: 0x002EABCE
	// (set) Token: 0x06009E2C RID: 40492 RVA: 0x002EC9D6 File Offset: 0x002EABD6
	public string ClearInfo { get; set; }

	// Token: 0x170010CA RID: 4298
	// (get) Token: 0x06009E2D RID: 40493 RVA: 0x002EC9DF File Offset: 0x002EABDF
	// (set) Token: 0x06009E2E RID: 40494 RVA: 0x002EC9E7 File Offset: 0x002EABE7
	public bool? IsUnlock { get; set; }
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020014D3 RID: 5331
[NullableContext(2)]
[Nullable(0)]
public class ItemHintPanelData<[Nullable(0)] T, TData> : IItemHintPanelData<T, TData> where T : ItemHintItemBase<TData>
{
	// Token: 0x170013AA RID: 5034
	// (get) Token: 0x0600D565 RID: 54629 RVA: 0x003F65F5 File Offset: 0x003F47F5
	// (set) Token: 0x0600D566 RID: 54630 RVA: 0x003F65FD File Offset: 0x003F47FD
	[Nullable(1)]
	public Func<TData> ShiftItem { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170013AB RID: 5035
	// (get) Token: 0x0600D567 RID: 54631 RVA: 0x003F6606 File Offset: 0x003F4806
	// (set) Token: 0x0600D568 RID: 54632 RVA: 0x003F660E File Offset: 0x003F480E
	[Nullable(1)]
	public Func<bool> CheckNext { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170013AC RID: 5036
	// (get) Token: 0x0600D569 RID: 54633 RVA: 0x003F6617 File Offset: 0x003F4817
	// (set) Token: 0x0600D56A RID: 54634 RVA: 0x003F661F File Offset: 0x003F481F
	[Nullable(1)]
	public Func<T> CreateProxyFunction { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170013AD RID: 5037
	// (get) Token: 0x0600D56B RID: 54635 RVA: 0x003F6628 File Offset: 0x003F4828
	// (set) Token: 0x0600D56C RID: 54636 RVA: 0x003F6630 File Offset: 0x003F4830
	public UUIItem ChildTemplate { get; set; }

	// Token: 0x170013AE RID: 5038
	// (get) Token: 0x0600D56D RID: 54637 RVA: 0x003F6639 File Offset: 0x003F4839
	// (set) Token: 0x0600D56E RID: 54638 RVA: 0x003F6641 File Offset: 0x003F4841
	public string ChildResourceId { get; set; }

	// Token: 0x170013AF RID: 5039
	// (get) Token: 0x0600D56F RID: 54639 RVA: 0x003F664A File Offset: 0x003F484A
	// (set) Token: 0x0600D570 RID: 54640 RVA: 0x003F6652 File Offset: 0x003F4852
	public string TitleTextId { get; set; }

	// Token: 0x170013B0 RID: 5040
	// (get) Token: 0x0600D571 RID: 54641 RVA: 0x003F665B File Offset: 0x003F485B
	// (set) Token: 0x0600D572 RID: 54642 RVA: 0x003F6663 File Offset: 0x003F4863
	public int? MaxShowCount { get; set; }

	// Token: 0x170013B1 RID: 5041
	// (get) Token: 0x0600D573 RID: 54643 RVA: 0x003F666C File Offset: 0x003F486C
	// (set) Token: 0x0600D574 RID: 54644 RVA: 0x003F6674 File Offset: 0x003F4874
	public int? AddItemTime { get; set; }

	// Token: 0x170013B2 RID: 5042
	// (get) Token: 0x0600D575 RID: 54645 RVA: 0x003F667D File Offset: 0x003F487D
	// (set) Token: 0x0600D576 RID: 54646 RVA: 0x003F6685 File Offset: 0x003F4885
	public int? ItemSliderTime { get; set; }

	// Token: 0x170013B3 RID: 5043
	// (get) Token: 0x0600D577 RID: 54647 RVA: 0x003F668E File Offset: 0x003F488E
	// (set) Token: 0x0600D578 RID: 54648 RVA: 0x003F6696 File Offset: 0x003F4896
	public int? ItemShowTime { get; set; }

	// Token: 0x170013B4 RID: 5044
	// (get) Token: 0x0600D579 RID: 54649 RVA: 0x003F669F File Offset: 0x003F489F
	// (set) Token: 0x0600D57A RID: 54650 RVA: 0x003F66A7 File Offset: 0x003F48A7
	public ESliderMode? SliderMode { get; set; }

	// Token: 0x170013B5 RID: 5045
	// (get) Token: 0x0600D57B RID: 54651 RVA: 0x003F66B0 File Offset: 0x003F48B0
	// (set) Token: 0x0600D57C RID: 54652 RVA: 0x003F66B8 File Offset: 0x003F48B8
	public ETickItemMode? TickMode { get; set; }

	// Token: 0x170013B6 RID: 5046
	// (get) Token: 0x0600D57D RID: 54653 RVA: 0x003F66C1 File Offset: 0x003F48C1
	// (set) Token: 0x0600D57E RID: 54654 RVA: 0x003F66C9 File Offset: 0x003F48C9
	public Action FinishCallback { get; set; }
}

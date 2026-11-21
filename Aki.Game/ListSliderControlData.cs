using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020014E1 RID: 5345
[NullableContext(1)]
[Nullable(0)]
public class ListSliderControlData<[Nullable(0)] T> : IListSliderControlData<T> where T : SliderItem
{
	// Token: 0x170013C5 RID: 5061
	// (get) Token: 0x0600D5D1 RID: 54737 RVA: 0x003F787F File Offset: 0x003F5A7F
	// (set) Token: 0x0600D5D2 RID: 54738 RVA: 0x003F7887 File Offset: 0x003F5A87
	public UUIItem ParentUi { get; set; }

	// Token: 0x170013C6 RID: 5062
	// (get) Token: 0x0600D5D3 RID: 54739 RVA: 0x003F7890 File Offset: 0x003F5A90
	// (set) Token: 0x0600D5D4 RID: 54740 RVA: 0x003F7898 File Offset: 0x003F5A98
	public Func<T> CreateProxyFunction { get; set; }

	// Token: 0x170013C7 RID: 5063
	// (get) Token: 0x0600D5D5 RID: 54741 RVA: 0x003F78A1 File Offset: 0x003F5AA1
	// (set) Token: 0x0600D5D6 RID: 54742 RVA: 0x003F78A9 File Offset: 0x003F5AA9
	public Func<bool> CheckNext { get; set; }

	// Token: 0x170013C8 RID: 5064
	// (get) Token: 0x0600D5D7 RID: 54743 RVA: 0x003F78B2 File Offset: 0x003F5AB2
	// (set) Token: 0x0600D5D8 RID: 54744 RVA: 0x003F78BA File Offset: 0x003F5ABA
	[Nullable(2)]
	public UUIItem ChildTemplate { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170013C9 RID: 5065
	// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x003F78C3 File Offset: 0x003F5AC3
	// (set) Token: 0x0600D5DA RID: 54746 RVA: 0x003F78CB File Offset: 0x003F5ACB
	[Nullable(2)]
	public string ChildResourceId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170013CA RID: 5066
	// (get) Token: 0x0600D5DB RID: 54747 RVA: 0x003F78D4 File Offset: 0x003F5AD4
	// (set) Token: 0x0600D5DC RID: 54748 RVA: 0x003F78DC File Offset: 0x003F5ADC
	public int? MaxShowCount { get; set; }

	// Token: 0x170013CB RID: 5067
	// (get) Token: 0x0600D5DD RID: 54749 RVA: 0x003F78E5 File Offset: 0x003F5AE5
	// (set) Token: 0x0600D5DE RID: 54750 RVA: 0x003F78ED File Offset: 0x003F5AED
	public float? AddItemTime { get; set; }

	// Token: 0x170013CC RID: 5068
	// (get) Token: 0x0600D5DF RID: 54751 RVA: 0x003F78F6 File Offset: 0x003F5AF6
	// (set) Token: 0x0600D5E0 RID: 54752 RVA: 0x003F78FE File Offset: 0x003F5AFE
	public float? ItemSliderTime { get; set; }

	// Token: 0x170013CD RID: 5069
	// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x003F7907 File Offset: 0x003F5B07
	// (set) Token: 0x0600D5E2 RID: 54754 RVA: 0x003F790F File Offset: 0x003F5B0F
	public float? ItemShowTime { get; set; }

	// Token: 0x170013CE RID: 5070
	// (get) Token: 0x0600D5E3 RID: 54755 RVA: 0x003F7918 File Offset: 0x003F5B18
	// (set) Token: 0x0600D5E4 RID: 54756 RVA: 0x003F7920 File Offset: 0x003F5B20
	public ESliderMode? SliderMode { get; set; }

	// Token: 0x170013CF RID: 5071
	// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x003F7929 File Offset: 0x003F5B29
	// (set) Token: 0x0600D5E6 RID: 54758 RVA: 0x003F7931 File Offset: 0x003F5B31
	public ETickItemMode? TickMode { get; set; }

	// Token: 0x170013D0 RID: 5072
	// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x003F793A File Offset: 0x003F5B3A
	// (set) Token: 0x0600D5E8 RID: 54760 RVA: 0x003F7942 File Offset: 0x003F5B42
	[Nullable(2)]
	public Action FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x0600D5E9 RID: 54761 RVA: 0x003F794B File Offset: 0x003F5B4B
	public ListSliderControlData(UUIItem parentUi, Func<T> createProxyFunction, Func<bool> checkNext)
	{
		this.ParentUi = parentUi;
		this.CreateProxyFunction = createProxyFunction;
		this.CheckNext = checkNext;
	}
}

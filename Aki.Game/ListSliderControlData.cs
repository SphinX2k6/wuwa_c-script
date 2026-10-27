using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200200E RID: 8206
[NullableContext(1)]
[Nullable(0)]
public class ListSliderControlData<[Nullable(0)] T> : IListSliderControlData<T> where T : SliderItem
{
	// Token: 0x17001398 RID: 5016
	// (get) Token: 0x06010169 RID: 65897 RVA: 0x003EB287 File Offset: 0x003E9487
	// (set) Token: 0x0601016A RID: 65898 RVA: 0x003EB28F File Offset: 0x003E948F
	public UUIItem ParentUi { get; set; }

	// Token: 0x17001399 RID: 5017
	// (get) Token: 0x0601016B RID: 65899 RVA: 0x003EB298 File Offset: 0x003E9498
	// (set) Token: 0x0601016C RID: 65900 RVA: 0x003EB2A0 File Offset: 0x003E94A0
	public Func<T> CreateProxyFunction { get; set; }

	// Token: 0x1700139A RID: 5018
	// (get) Token: 0x0601016D RID: 65901 RVA: 0x003EB2A9 File Offset: 0x003E94A9
	// (set) Token: 0x0601016E RID: 65902 RVA: 0x003EB2B1 File Offset: 0x003E94B1
	public Func<bool> CheckNext { get; set; }

	// Token: 0x1700139B RID: 5019
	// (get) Token: 0x0601016F RID: 65903 RVA: 0x003EB2BA File Offset: 0x003E94BA
	// (set) Token: 0x06010170 RID: 65904 RVA: 0x003EB2C2 File Offset: 0x003E94C2
	[Nullable(2)]
	public UUIItem ChildTemplate { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700139C RID: 5020
	// (get) Token: 0x06010171 RID: 65905 RVA: 0x003EB2CB File Offset: 0x003E94CB
	// (set) Token: 0x06010172 RID: 65906 RVA: 0x003EB2D3 File Offset: 0x003E94D3
	[Nullable(2)]
	public string ChildResourceId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700139D RID: 5021
	// (get) Token: 0x06010173 RID: 65907 RVA: 0x003EB2DC File Offset: 0x003E94DC
	// (set) Token: 0x06010174 RID: 65908 RVA: 0x003EB2E4 File Offset: 0x003E94E4
	public int? MaxShowCount { get; set; }

	// Token: 0x1700139E RID: 5022
	// (get) Token: 0x06010175 RID: 65909 RVA: 0x003EB2ED File Offset: 0x003E94ED
	// (set) Token: 0x06010176 RID: 65910 RVA: 0x003EB2F5 File Offset: 0x003E94F5
	public float? AddItemTime { get; set; }

	// Token: 0x1700139F RID: 5023
	// (get) Token: 0x06010177 RID: 65911 RVA: 0x003EB2FE File Offset: 0x003E94FE
	// (set) Token: 0x06010178 RID: 65912 RVA: 0x003EB306 File Offset: 0x003E9506
	public float? ItemSliderTime { get; set; }

	// Token: 0x170013A0 RID: 5024
	// (get) Token: 0x06010179 RID: 65913 RVA: 0x003EB30F File Offset: 0x003E950F
	// (set) Token: 0x0601017A RID: 65914 RVA: 0x003EB317 File Offset: 0x003E9517
	public float? ItemShowTime { get; set; }

	// Token: 0x170013A1 RID: 5025
	// (get) Token: 0x0601017B RID: 65915 RVA: 0x003EB320 File Offset: 0x003E9520
	// (set) Token: 0x0601017C RID: 65916 RVA: 0x003EB328 File Offset: 0x003E9528
	public ESliderMode? SliderMode { get; set; }

	// Token: 0x170013A2 RID: 5026
	// (get) Token: 0x0601017D RID: 65917 RVA: 0x003EB331 File Offset: 0x003E9531
	// (set) Token: 0x0601017E RID: 65918 RVA: 0x003EB339 File Offset: 0x003E9539
	public ETickItemMode? TickMode { get; set; }

	// Token: 0x170013A3 RID: 5027
	// (get) Token: 0x0601017F RID: 65919 RVA: 0x003EB342 File Offset: 0x003E9542
	// (set) Token: 0x06010180 RID: 65920 RVA: 0x003EB34A File Offset: 0x003E954A
	[Nullable(2)]
	public Action FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x06010181 RID: 65921 RVA: 0x003EB353 File Offset: 0x003E9553
	public ListSliderControlData(UUIItem parentUi, Func<T> createProxyFunction, Func<bool> checkNext)
	{
		this.ParentUi = parentUi;
		this.CreateProxyFunction = createProxyFunction;
		this.CheckNext = checkNext;
	}
}

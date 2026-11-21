using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021D8 RID: 8664
public class UiWeaponAnsContext : UiAnsContextBase
{
	// Token: 0x17002056 RID: 8278
	// (get) Token: 0x06015531 RID: 87345 RVA: 0x0063317F File Offset: 0x0063137F
	public int Index { get; }

	// Token: 0x17002057 RID: 8279
	// (get) Token: 0x06015532 RID: 87346 RVA: 0x00633187 File Offset: 0x00631387
	public bool ShowMaterialController { get; }

	// Token: 0x17002058 RID: 8280
	// (get) Token: 0x06015533 RID: 87347 RVA: 0x0063318F File Offset: 0x0063138F
	public bool HideEffect { get; }

	// Token: 0x17002059 RID: 8281
	// (get) Token: 0x06015534 RID: 87348 RVA: 0x00633197 File Offset: 0x00631397
	public FTransform? Transform { get; }

	// Token: 0x1700205A RID: 8282
	// (get) Token: 0x06015535 RID: 87349 RVA: 0x0063319F File Offset: 0x0063139F
	public FName HangSocketName { get; }

	// Token: 0x06015536 RID: 87350 RVA: 0x006331A7 File Offset: 0x006313A7
	public UiWeaponAnsContext(int index, bool showMaterialController, bool hideEffect, FTransform? transform, FName hangSocketName)
	{
		this.Index = index;
		this.ShowMaterialController = showMaterialController;
		this.HideEffect = hideEffect;
		this.Transform = transform;
		this.HangSocketName = hangSocketName;
	}

	// Token: 0x06015537 RID: 87351 RVA: 0x006331D4 File Offset: 0x006313D4
	[NullableContext(1)]
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiWeaponAnsContext uiWeaponAnsContext = inAnsContext as UiWeaponAnsContext;
		return uiWeaponAnsContext != null && this.Index == uiWeaponAnsContext.Index && this.HangSocketName == uiWeaponAnsContext.HangSocketName;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C7F RID: 11391
public class UiWeaponAnsContext : UiAnsContextBase
{
	// Token: 0x17002005 RID: 8197
	// (get) Token: 0x06017CBE RID: 97470 RVA: 0x0060D69B File Offset: 0x0060B89B
	public int Index { get; }

	// Token: 0x17002006 RID: 8198
	// (get) Token: 0x06017CBF RID: 97471 RVA: 0x0060D6A3 File Offset: 0x0060B8A3
	public bool ShowMaterialController { get; }

	// Token: 0x17002007 RID: 8199
	// (get) Token: 0x06017CC0 RID: 97472 RVA: 0x0060D6AB File Offset: 0x0060B8AB
	public bool HideEffect { get; }

	// Token: 0x17002008 RID: 8200
	// (get) Token: 0x06017CC1 RID: 97473 RVA: 0x0060D6B3 File Offset: 0x0060B8B3
	public FTransform? Transform { get; }

	// Token: 0x17002009 RID: 8201
	// (get) Token: 0x06017CC2 RID: 97474 RVA: 0x0060D6BB File Offset: 0x0060B8BB
	public FName HangSocketName { get; }

	// Token: 0x06017CC3 RID: 97475 RVA: 0x0060D6C3 File Offset: 0x0060B8C3
	public UiWeaponAnsContext(int index, bool showMaterialController, bool hideEffect, FTransform? transform, FName hangSocketName)
	{
		this.Index = index;
		this.ShowMaterialController = showMaterialController;
		this.HideEffect = hideEffect;
		this.Transform = transform;
		this.HangSocketName = hangSocketName;
	}

	// Token: 0x06017CC4 RID: 97476 RVA: 0x0060D6F0 File Offset: 0x0060B8F0
	[NullableContext(1)]
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiWeaponAnsContext uiWeaponAnsContext = inAnsContext as UiWeaponAnsContext;
		return uiWeaponAnsContext != null && this.Index == uiWeaponAnsContext.Index && this.HangSocketName == uiWeaponAnsContext.HangSocketName;
	}
}

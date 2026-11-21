using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DF2 RID: 7666
[NullableContext(2)]
[Nullable(0)]
public class CostContentItem : UiPanelBase
{
	// Token: 0x06012F0E RID: 77582 RVA: 0x0058D1D8 File Offset: 0x0058B3D8
	[NullableContext(1)]
	public CostContentItem(RoleBreakPreviewViewModel vm)
	{
		this.BoundViewModel = vm;
	}

	// Token: 0x06012F0F RID: 77583 RVA: 0x0058D1E8 File Offset: 0x0058B3E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06012F10 RID: 77584 RVA: 0x0058D242 File Offset: 0x0058B442
	protected override void OnStart()
	{
		this.BoundViewModel.BindCostContentItem(this);
		this.BoundViewModel.HandleCostContentItemOnStart();
	}

	// Token: 0x06012F11 RID: 77585 RVA: 0x0058D25B File Offset: 0x0058B45B
	protected override void OnBeforeDestroy()
	{
		this.BoundViewModel.UnbindCostContentItem();
		this.BoundViewModel = null;
	}

	// Token: 0x06012F12 RID: 77586 RVA: 0x0058D270 File Offset: 0x0058B470
	public void RefreshTitle(string value)
	{
		string newText = (!string.IsNullOrEmpty(value)) ? value : "";
		base.GetText(0).SetText(newText, true);
	}

	// Token: 0x06012F13 RID: 77587 RVA: 0x0058D29C File Offset: 0x0058B49C
	public void RefreshCostNumber(string value)
	{
		string newText = (!string.IsNullOrEmpty(value)) ? value : "";
		base.GetText(1).SetText(newText, true);
	}

	// Token: 0x06012F14 RID: 77588 RVA: 0x0058D2C8 File Offset: 0x0058B4C8
	public void RefreshMoneyIcon(EItemId value)
	{
		base.SetItemIcon(base.GetTexture(2), (int)value, null, null);
	}

	// Token: 0x0400A33A RID: 41786
	private RoleBreakPreviewViewModel BoundViewModel;

	// Token: 0x020080D3 RID: 32979
	[NullableContext(0)]
	private enum ECostContentItemComponent
	{
		// Token: 0x04029AB9 RID: 170681
		Title,
		// Token: 0x04029ABA RID: 170682
		CostNumber,
		// Token: 0x04029ABB RID: 170683
		MoneyIcon
	}
}

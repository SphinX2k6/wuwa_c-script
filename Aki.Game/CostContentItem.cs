using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002877 RID: 10359
[NullableContext(2)]
[Nullable(0)]
public class CostContentItem : UiPanelBase
{
	// Token: 0x06015510 RID: 87312 RVA: 0x0056247C File Offset: 0x0056067C
	[NullableContext(1)]
	public CostContentItem(RoleBreakPreviewViewModel vm)
	{
		this.BoundViewModel = vm;
	}

	// Token: 0x06015511 RID: 87313 RVA: 0x0056248C File Offset: 0x0056068C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06015512 RID: 87314 RVA: 0x005624E6 File Offset: 0x005606E6
	protected override void OnStart()
	{
		this.BoundViewModel.BindCostContentItem(this);
		this.BoundViewModel.HandleCostContentItemOnStart();
	}

	// Token: 0x06015513 RID: 87315 RVA: 0x005624FF File Offset: 0x005606FF
	protected override void OnBeforeDestroy()
	{
		this.BoundViewModel.UnbindCostContentItem();
		this.BoundViewModel = null;
	}

	// Token: 0x06015514 RID: 87316 RVA: 0x00562514 File Offset: 0x00560714
	public void RefreshTitle(string value)
	{
		string newText = (!string.IsNullOrEmpty(value)) ? value : "";
		base.GetText(0).SetText(newText, true);
	}

	// Token: 0x06015515 RID: 87317 RVA: 0x00562540 File Offset: 0x00560740
	public void RefreshCostNumber(string value)
	{
		string newText = (!string.IsNullOrEmpty(value)) ? value : "";
		base.GetText(1).SetText(newText, true);
	}

	// Token: 0x06015516 RID: 87318 RVA: 0x0056256C File Offset: 0x0056076C
	public void RefreshMoneyIcon(EItemId value)
	{
		base.SetItemIcon(base.GetTexture(2), (int)value, null, null);
	}

	// Token: 0x04009F51 RID: 40785
	private RoleBreakPreviewViewModel BoundViewModel;

	// Token: 0x02008E8D RID: 36493
	[NullableContext(0)]
	private enum ECostContentItemComponent
	{
		// Token: 0x0402E3BF RID: 189375
		Title,
		// Token: 0x0402E3C0 RID: 189376
		CostNumber,
		// Token: 0x0402E3C1 RID: 189377
		MoneyIcon
	}
}

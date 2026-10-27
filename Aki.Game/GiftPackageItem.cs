using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200239A RID: 9114
public class GiftPackageItem : UiPanelBase
{
	// Token: 0x060123A6 RID: 74662 RVA: 0x0047D89D File Offset: 0x0047BA9D
	[NullableContext(1)]
	public void Initialize(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060123A7 RID: 74663 RVA: 0x0047D8AC File Offset: 0x0047BAAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060123A8 RID: 74664 RVA: 0x0047D936 File Offset: 0x0047BB36
	protected override void OnStart()
	{
		this.CommonItemSimpleGrid = new CommonItemSmallItemGrid();
		this.CommonItemSimpleGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x060123A9 RID: 74665 RVA: 0x0047D95A File Offset: 0x0047BB5A
	public void SetBelongViewName(EUiViewName viewName)
	{
	}

	// Token: 0x060123AA RID: 74666 RVA: 0x0047D95C File Offset: 0x0047BB5C
	public void UpdateItem(int itemId, int count)
	{
		this.ItemId = itemId;
		this.CommonItemSimpleGrid.RefreshByConfigId(itemId, null, null, false, false);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		base.GetText(1).ShowTextNew(itemConfigData.Name);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "Quantity", new <>z__ReadOnlySingleElementList<object>(count));
	}

	// Token: 0x060123AB RID: 74667 RVA: 0x0047D9C7 File Offset: 0x0047BBC7
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x040089B6 RID: 35254
	[Nullable(2)]
	protected CommonItemSmallItemGrid CommonItemSimpleGrid;

	// Token: 0x040089B7 RID: 35255
	protected int ItemId;

	// Token: 0x0200893E RID: 35134
	private class EGiftPackageItem
	{
		// Token: 0x0402C9E0 RID: 182752
		public const int CommonItemSimpleGrid = 0;

		// Token: 0x0402C9E1 RID: 182753
		public const int Name = 1;

		// Token: 0x0402C9E2 RID: 182754
		public const int Count = 2;
	}
}

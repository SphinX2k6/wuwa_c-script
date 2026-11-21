using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200187F RID: 6271
public class GiftPackageItem : UiPanelBase
{
	// Token: 0x0600F858 RID: 63576 RVA: 0x0048ACDD File Offset: 0x00488EDD
	[NullableContext(1)]
	public void Initialize(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600F859 RID: 63577 RVA: 0x0048ACEC File Offset: 0x00488EEC
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

	// Token: 0x0600F85A RID: 63578 RVA: 0x0048AD76 File Offset: 0x00488F76
	protected override void OnStart()
	{
		this.CommonItemSimpleGrid = new CommonItemSmallItemGrid();
		this.CommonItemSimpleGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600F85B RID: 63579 RVA: 0x0048AD9A File Offset: 0x00488F9A
	public void SetBelongViewName(EUiViewName viewName)
	{
	}

	// Token: 0x0600F85C RID: 63580 RVA: 0x0048AD9C File Offset: 0x00488F9C
	public void UpdateItem(int itemId, int count)
	{
		this.ItemId = itemId;
		this.CommonItemSimpleGrid.RefreshByConfigId(itemId, null, null, false, false);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		base.GetText(1).ShowTextNew(itemConfigData.Name);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "Quantity", new <>z__ReadOnlySingleElementList<object>(count));
	}

	// Token: 0x0600F85D RID: 63581 RVA: 0x0048AE07 File Offset: 0x00489007
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x04008AFD RID: 35581
	[Nullable(2)]
	protected CommonItemSmallItemGrid CommonItemSimpleGrid;

	// Token: 0x04008AFE RID: 35582
	protected int ItemId;

	// Token: 0x02007AC9 RID: 31433
	private class EGiftPackageItem
	{
		// Token: 0x04027CFD RID: 163069
		public const int CommonItemSimpleGrid = 0;

		// Token: 0x04027CFE RID: 163070
		public const int Name = 1;

		// Token: 0x04027CFF RID: 163071
		public const int Count = 2;
	}
}

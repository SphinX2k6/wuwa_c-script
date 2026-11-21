using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x020012AC RID: 4780
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class HandBookCommonTypeItem : GridProxyAbstract<HandBookCommonItemData[]>
{
	// Token: 0x0600BD43 RID: 48451 RVA: 0x0037F259 File Offset: 0x0037D459
	[NullableContext(2)]
	public void Initialize(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600BD44 RID: 48452 RVA: 0x0037F26A File Offset: 0x0037D46A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600BD45 RID: 48453 RVA: 0x0037F2A4 File Offset: 0x0037D4A4
	public void InitGridLayout()
	{
		if (this.GridLayout != null)
		{
			this.GridLayout.ClearChildren();
			this.GridLayout = null;
		}
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
		this.GridLayout = new GenericLayoutNew<HandBookCommonItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookCommonItem>(this.InitHandBookCommonItem), null);
		this.GridLayout.RebuildLayoutByDataNew<HandBookCommonItemData>(this.HandBookCommonItemDataList, null);
	}

	// Token: 0x0600BD46 RID: 48454 RVA: 0x0037F30F File Offset: 0x0037D50F
	public void InitTitle()
	{
		if (this.HandBookCommonItemDataList.Length == 0)
		{
			return;
		}
		base.GetText(0).SetText(this.HandBookCommonItemDataList[0].Title, true);
	}

	// Token: 0x0600BD47 RID: 48455 RVA: 0x0037F338 File Offset: 0x0037D538
	private ILayoutItem<HandBookCommonItem> InitHandBookCommonItem(object handBookCommonItemData, UUIItem uiItem, int index)
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		handBookCommonItem.Initialize(uiItem.GetOwner());
		handBookCommonItem.Refresh((HandBookCommonItemData)handBookCommonItemData, false, 0);
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		this.HandBookCommonItemList.Add(handBookCommonItem);
		return new LayoutItem<HandBookCommonItem>
		{
			Key = index,
			Value = handBookCommonItem
		};
	}

	// Token: 0x0600BD48 RID: 48456 RVA: 0x0037F39B File Offset: 0x0037D59B
	[NullableContext(2)]
	public HandBookCommonItem SetToggleChecked()
	{
		if (this.HandBookCommonItemList.Count > 0)
		{
			HandBookCommonItem handBookCommonItem = this.HandBookCommonItemList[0];
			handBookCommonItem.SetSelected(true, false);
			handBookCommonItem.OnSelected(true);
			return handBookCommonItem;
		}
		return null;
	}

	// Token: 0x0600BD49 RID: 48457 RVA: 0x0037F3C8 File Offset: 0x0037D5C8
	public void ResetAllToggleState()
	{
		int count = this.HandBookCommonItemList.Count;
		for (int i = 0; i < count; i++)
		{
			this.HandBookCommonItemList[i].SetSelected(false, false);
		}
	}

	// Token: 0x0600BD4A RID: 48458 RVA: 0x0037F400 File Offset: 0x0037D600
	protected void OnToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		HandBookCommonItemData handBookCommonItemData = callbackParameter.Data as HandBookCommonItemData;
		if (this.OnToggleCallback != null)
		{
			ItemGridBase mediumItemGrid = callbackParameter.MediumItemGrid;
			this.OnToggleCallback(handBookCommonItemData, mediumItemGrid);
		}
	}

	// Token: 0x0600BD4B RID: 48459 RVA: 0x0037F435 File Offset: 0x0037D635
	public override void Refresh(HandBookCommonItemData[] dataList, bool isSelected, int gridIndex)
	{
		this.GirdIndex = gridIndex;
		this.HandBookCommonItemDataList = dataList;
		this.InitGridLayout();
		this.InitTitle();
	}

	// Token: 0x0600BD4C RID: 48460 RVA: 0x0037F451 File Offset: 0x0037D651
	public int GetGirdIndex()
	{
		return this.GirdIndex;
	}

	// Token: 0x0600BD4D RID: 48461 RVA: 0x0037F459 File Offset: 0x0037D659
	public List<HandBookCommonItem> GetHandBookCommonItemList()
	{
		return this.HandBookCommonItemList;
	}

	// Token: 0x0600BD4E RID: 48462 RVA: 0x0037F461 File Offset: 0x0037D661
	public void BindToggleCallback(THandBookToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x0600BD4F RID: 48463 RVA: 0x0037F46A File Offset: 0x0037D66A
	protected override void OnBeforeDestroy()
	{
		if (this.GridLayout != null)
		{
			this.GridLayout.ClearChildren();
			this.GridLayout = null;
		}
	}

	// Token: 0x04006CF0 RID: 27888
	protected HandBookCommonItemData[] HandBookCommonItemDataList;

	// Token: 0x04006CF1 RID: 27889
	protected List<HandBookCommonItem> HandBookCommonItemList;

	// Token: 0x04006CF2 RID: 27890
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<HandBookCommonItem> GridLayout;

	// Token: 0x04006CF3 RID: 27891
	[Nullable(2)]
	private THandBookToggleFunction OnToggleCallback;

	// Token: 0x04006CF4 RID: 27892
	private int GirdIndex;
}

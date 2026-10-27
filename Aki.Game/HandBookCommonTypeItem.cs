using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02001DEA RID: 7658
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class HandBookCommonTypeItem : GridProxyAbstract<HandBookCommonItemData[]>
{
	// Token: 0x0600E924 RID: 59684 RVA: 0x00373551 File Offset: 0x00371751
	[NullableContext(2)]
	public void Initialize(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600E925 RID: 59685 RVA: 0x00373562 File Offset: 0x00371762
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600E926 RID: 59686 RVA: 0x0037359C File Offset: 0x0037179C
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

	// Token: 0x0600E927 RID: 59687 RVA: 0x00373607 File Offset: 0x00371807
	public void InitTitle()
	{
		if (this.HandBookCommonItemDataList.Length == 0)
		{
			return;
		}
		base.GetText(0).SetText(this.HandBookCommonItemDataList[0].Title, true);
	}

	// Token: 0x0600E928 RID: 59688 RVA: 0x00373630 File Offset: 0x00371830
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

	// Token: 0x0600E929 RID: 59689 RVA: 0x00373693 File Offset: 0x00371893
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

	// Token: 0x0600E92A RID: 59690 RVA: 0x003736C0 File Offset: 0x003718C0
	public void ResetAllToggleState()
	{
		int count = this.HandBookCommonItemList.Count;
		for (int i = 0; i < count; i++)
		{
			this.HandBookCommonItemList[i].SetSelected(false, false);
		}
	}

	// Token: 0x0600E92B RID: 59691 RVA: 0x003736F8 File Offset: 0x003718F8
	protected void OnToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		HandBookCommonItemData handBookCommonItemData = callbackParameter.Data as HandBookCommonItemData;
		if (this.OnToggleCallback != null)
		{
			ItemGridBase mediumItemGrid = callbackParameter.MediumItemGrid;
			this.OnToggleCallback(handBookCommonItemData, mediumItemGrid);
		}
	}

	// Token: 0x0600E92C RID: 59692 RVA: 0x0037372D File Offset: 0x0037192D
	public override void Refresh(HandBookCommonItemData[] dataList, bool isSelected, int gridIndex)
	{
		this.GirdIndex = gridIndex;
		this.HandBookCommonItemDataList = dataList;
		this.InitGridLayout();
		this.InitTitle();
	}

	// Token: 0x0600E92D RID: 59693 RVA: 0x00373749 File Offset: 0x00371949
	public int GetGirdIndex()
	{
		return this.GirdIndex;
	}

	// Token: 0x0600E92E RID: 59694 RVA: 0x00373751 File Offset: 0x00371951
	public List<HandBookCommonItem> GetHandBookCommonItemList()
	{
		return this.HandBookCommonItemList;
	}

	// Token: 0x0600E92F RID: 59695 RVA: 0x00373759 File Offset: 0x00371959
	public void BindToggleCallback(THandBookToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x0600E930 RID: 59696 RVA: 0x00373762 File Offset: 0x00371962
	protected override void OnBeforeDestroy()
	{
		if (this.GridLayout != null)
		{
			this.GridLayout.ClearChildren();
			this.GridLayout = null;
		}
	}

	// Token: 0x04006C0F RID: 27663
	protected HandBookCommonItemData[] HandBookCommonItemDataList;

	// Token: 0x04006C10 RID: 27664
	protected List<HandBookCommonItem> HandBookCommonItemList;

	// Token: 0x04006C11 RID: 27665
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<HandBookCommonItem> GridLayout;

	// Token: 0x04006C12 RID: 27666
	[Nullable(2)]
	private THandBookToggleFunction OnToggleCallback;

	// Token: 0x04006C13 RID: 27667
	private int GirdIndex;
}

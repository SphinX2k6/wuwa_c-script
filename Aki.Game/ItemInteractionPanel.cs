using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D83 RID: 3459
[NullableContext(1)]
[Nullable(0)]
public class ItemInteractionPanel : UiPanelBase
{
	// Token: 0x06008E06 RID: 36358 RVA: 0x002ACCF4 File Offset: 0x002AAEF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06008E07 RID: 36359 RVA: 0x002ACDA6 File Offset: 0x002AAFA6
	protected override void OnStart()
	{
		this.ItemScrollView = new LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData>(base.GetLoopScrollViewComponent(5), base.GetItem(6).GetOwner() as AUIBaseActor, new Func<ItemInteractionMediumItemGrid>(this.OnGridProxyCreate), false);
	}

	// Token: 0x06008E08 RID: 36360 RVA: 0x002ACDD8 File Offset: 0x002AAFD8
	public UniTask Refresh(IItemInteractionPanel itemInteractionPanelInfo)
	{
		ItemInteractionPanel.<Refresh>d__15 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.itemInteractionPanelInfo = itemInteractionPanelInfo;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<ItemInteractionPanel.<Refresh>d__15>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06008E09 RID: 36361 RVA: 0x002ACE23 File Offset: 0x002AB023
	private ItemInteractionMediumItemGrid OnGridProxyCreate()
	{
		ItemInteractionMediumItemGrid itemInteractionMediumItemGrid = new ItemInteractionMediumItemGrid();
		itemInteractionMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnItemExtendToggleStateChanged));
		itemInteractionMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		itemInteractionMediumItemGrid.BindReduceLongPress(new Action<bool, MediumItemGrid, object>(this.OnReduceButtonLongPress));
		return itemInteractionMediumItemGrid;
	}

	// Token: 0x06008E0A RID: 36362 RVA: 0x002ACE60 File Offset: 0x002AB060
	private void OnReduceButtonLongPress(bool isShortPress, MediumItemGrid mediumItemGrid, [Nullable(2)] object data)
	{
		if (data == null)
		{
			return;
		}
		ItemInteractionPanelItemData obj = data as ItemInteractionPanelItemData;
		if (this.OnReduceButtonTriggerCallback != null)
		{
			this.OnReduceButtonTriggerCallback(obj);
		}
	}

	// Token: 0x06008E0B RID: 36363 RVA: 0x002ACE8C File Offset: 0x002AB08C
	private void OnItemExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
	{
		ItemInteractionPanelItemData itemInteractionPanelItemData = callbackParameter.Data as ItemInteractionPanelItemData;
		this.SetItemGridSelected(true, itemInteractionPanelItemData);
		if (this.OnItemExtendToggleStateChangedCallback != null)
		{
			this.OnItemExtendToggleStateChangedCallback(itemInteractionPanelItemData);
		}
	}

	// Token: 0x06008E0C RID: 36364 RVA: 0x002ACEC4 File Offset: 0x002AB0C4
	[NullableContext(2)]
	private bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		ItemInteractionPanelItemData itemInteractionPanelItemData = data as ItemInteractionPanelItemData;
		return (this.CurrentSelectedData == null || !this.CurrentSelectedData.IsSelected || itemInteractionPanelItemData != this.CurrentSelectedData) && this.CurrentItemDataList.IndexOf(itemInteractionPanelItemData) >= 0 && (this.OnCanExecuteChangeCallback == null || this.OnCanExecuteChangeCallback(itemInteractionPanelItemData));
	}

	// Token: 0x06008E0D RID: 36365 RVA: 0x002ACF1F File Offset: 0x002AB11F
	public void BindOnReduceButtonTrigger(Action<ItemInteractionPanelItemData> onReduceButtonTriggerCallback)
	{
		this.OnReduceButtonTriggerCallback = onReduceButtonTriggerCallback;
	}

	// Token: 0x06008E0E RID: 36366 RVA: 0x002ACF28 File Offset: 0x002AB128
	public void BindOnItemExtendToggleStateChanged(Action<ItemInteractionPanelItemData> onItemExtendToggleStateChangedCallback)
	{
		this.OnItemExtendToggleStateChangedCallback = onItemExtendToggleStateChangedCallback;
	}

	// Token: 0x06008E0F RID: 36367 RVA: 0x002ACF31 File Offset: 0x002AB131
	public void BindOnCanExecuteChange(Func<ItemInteractionPanelItemData, bool> onCanExecuteChangeCallback)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChangeCallback;
	}

	// Token: 0x06008E10 RID: 36368 RVA: 0x002ACF3C File Offset: 0x002AB13C
	protected override void OnBeforeDestroy()
	{
		this.MainTypeIdList.Clear();
		this.CurrentItemDataList.Clear();
		this.ItemScrollView = null;
		this.SelectedMainTypeItem = null;
		this.ItemDataMainTypeMap.Clear();
		this.ItemDataMap.Clear();
		this.OnItemExtendToggleStateChangedCallback = null;
		this.OnReduceButtonTriggerCallback = null;
		this.ClearMainTypeItem();
	}

	// Token: 0x06008E11 RID: 36369 RVA: 0x002ACF98 File Offset: 0x002AB198
	private void RefreshItemDataMap()
	{
		this.ItemDataMainTypeMap.Clear();
		this.ItemDataMap.Clear();
		this.MainTypeIdList.Clear();
		this.CurrentItemDataList.Clear();
		InventoryConfig instance = InventoryConfig.Instance;
		foreach (IItemInteractionPanelItemInfo itemInteractionPanelItemInfo in this.ItemInteractionPanelInfo.ItemInfoList)
		{
			int itemConfigId = itemInteractionPanelItemInfo.ItemConfigId;
			ItemInfo? itemConfig = instance.GetItemConfig(itemConfigId);
			if (itemConfig != null)
			{
				int mainTypeId = itemConfig.Value.MainTypeId;
				ItemInteractionPanelItemData itemInteractionPanelItemData = new ItemInteractionPanelItemData(itemInteractionPanelItemInfo, itemConfig.Value.QualityId);
				List<ItemInteractionPanelItemData> list;
				if (this.ItemDataMainTypeMap.TryGetValue(mainTypeId, out list))
				{
					list.Add(itemInteractionPanelItemData);
				}
				else
				{
					this.ItemDataMainTypeMap[mainTypeId] = new List<ItemInteractionPanelItemData>
					{
						itemInteractionPanelItemData
					};
					this.MainTypeIdList.Add(mainTypeId);
				}
				this.ItemDataMap[itemConfigId] = itemInteractionPanelItemData;
			}
		}
		using (Dictionary<int, List<ItemInteractionPanelItemData>>.ValueCollection.Enumerator enumerator2 = this.ItemDataMainTypeMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				enumerator2.Current.Sort(delegate(ItemInteractionPanelItemData a, ItemInteractionPanelItemData b)
				{
					int qualityId = a.GetQualityId();
					int qualityId2 = b.GetQualityId();
					if (qualityId != qualityId2)
					{
						return qualityId - qualityId2;
					}
					int itemCount = a.GetItemCount();
					int itemCount2 = b.GetItemCount();
					if (itemCount != itemCount2)
					{
						return itemCount2 - itemCount;
					}
					return a.ItemConfigId - b.ItemConfigId;
				});
			}
		}
	}

	// Token: 0x06008E12 RID: 36370 RVA: 0x002AD11C File Offset: 0x002AB31C
	private UniTask RefreshMainTypeExtendToggle()
	{
		ItemInteractionPanel.<RefreshMainTypeExtendToggle>d__25 <RefreshMainTypeExtendToggle>d__;
		<RefreshMainTypeExtendToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMainTypeExtendToggle>d__.<>4__this = this;
		<RefreshMainTypeExtendToggle>d__.<>1__state = -1;
		<RefreshMainTypeExtendToggle>d__.<>t__builder.Start<ItemInteractionPanel.<RefreshMainTypeExtendToggle>d__25>(ref <RefreshMainTypeExtendToggle>d__);
		return <RefreshMainTypeExtendToggle>d__.<>t__builder.Task;
	}

	// Token: 0x06008E13 RID: 36371 RVA: 0x002AD15F File Offset: 0x002AB35F
	private void OnMainTypeExtendToggleStateChanged(int mainTypeId)
	{
		this.SelectedMainType(mainTypeId);
	}

	// Token: 0x06008E14 RID: 36372 RVA: 0x002AD168 File Offset: 0x002AB368
	public void SelectedMainType(int mainTypeId)
	{
		this.RefreshItemPanel(this.ItemDataMainTypeMap[mainTypeId]);
		ItemInteractionPanelMainTypeItem selectedMainTypeItem = this.SelectedMainTypeItem;
		if (selectedMainTypeItem != null)
		{
			selectedMainTypeItem.SetSelected(false);
		}
		ItemInteractionPanelMainTypeItem itemInteractionPanelMainTypeItem;
		if (this.MainTypeItemMap.TryGetValue(mainTypeId, out itemInteractionPanelMainTypeItem))
		{
			itemInteractionPanelMainTypeItem.SetSelected(true);
			itemInteractionPanelMainTypeItem.SetRedDotVisible(false);
			this.SelectedMainTypeItem = itemInteractionPanelMainTypeItem;
		}
	}

	// Token: 0x06008E15 RID: 36373 RVA: 0x002AD1C0 File Offset: 0x002AB3C0
	public void SetMainTypeRedDotVisible(int mainTypeId, bool bVisible)
	{
		ItemInteractionPanelMainTypeItem itemInteractionPanelMainTypeItem;
		if (this.MainTypeItemMap.TryGetValue(mainTypeId, out itemInteractionPanelMainTypeItem))
		{
			itemInteractionPanelMainTypeItem.SetRedDotVisible(bVisible);
		}
	}

	// Token: 0x06008E16 RID: 36374 RVA: 0x002AD1E4 File Offset: 0x002AB3E4
	private void ClearMainTypeItem()
	{
		foreach (ItemInteractionPanelMainTypeItem itemInteractionPanelMainTypeItem in this.MainTypeItemMap.Values)
		{
			itemInteractionPanelMainTypeItem.Destroy(null);
		}
		this.MainTypeItemMap.Clear();
	}

	// Token: 0x06008E17 RID: 36375 RVA: 0x002AD248 File Offset: 0x002AB448
	public void RefreshItemPanel(List<ItemInteractionPanelItemData> itemDataList)
	{
		LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData> itemScrollView = this.ItemScrollView;
		if (itemScrollView != null)
		{
			itemScrollView.RefreshByData(itemDataList, false, null, false);
		}
		this.CurrentItemDataList = itemDataList;
		this.CurrentSelectedData = null;
	}

	// Token: 0x06008E18 RID: 36376 RVA: 0x002AD270 File Offset: 0x002AB470
	public void RefreshItemGrid(ItemInteractionPanelItemData data)
	{
		int num = this.CurrentItemDataList.IndexOf(data);
		if (num < 0)
		{
			return;
		}
		LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData> itemScrollView = this.ItemScrollView;
		if (itemScrollView == null)
		{
			return;
		}
		itemScrollView.RefreshGridProxy(num);
	}

	// Token: 0x06008E19 RID: 36377 RVA: 0x002AD2A0 File Offset: 0x002AB4A0
	public void SetItemGridSelected(bool bSelected, ItemInteractionPanelItemData data)
	{
		int num = this.CurrentItemDataList.IndexOf(data);
		if (num < 0)
		{
			return;
		}
		data.IsSelected = bSelected;
		if (bSelected)
		{
			this.CurrentSelectedData = data;
		}
		else
		{
			this.CurrentSelectedData = null;
		}
		LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData> itemScrollView = this.ItemScrollView;
		if (itemScrollView == null)
		{
			return;
		}
		itemScrollView.RefreshGridProxy(num);
	}

	// Token: 0x06008E1A RID: 36378 RVA: 0x002AD2EA File Offset: 0x002AB4EA
	public List<ItemInteractionPanelItemData> GetCurrentItemDataList()
	{
		return this.CurrentItemDataList;
	}

	// Token: 0x06008E1B RID: 36379 RVA: 0x002AD2F4 File Offset: 0x002AB4F4
	[NullableContext(2)]
	public ItemInteractionPanelItemData GetItemData(int itemConfigId)
	{
		ItemInteractionPanelItemData result;
		if (this.ItemDataMap.TryGetValue(itemConfigId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06008E1C RID: 36380 RVA: 0x002AD314 File Offset: 0x002AB514
	public IReadOnlyDictionary<int, List<ItemInteractionPanelItemData>> GetItemDataMainTypeMap()
	{
		return this.ItemDataMainTypeMap;
	}

	// Token: 0x06008E1D RID: 36381 RVA: 0x002AD31C File Offset: 0x002AB51C
	public IReadOnlyList<int> GetMainTypeIdList()
	{
		return this.MainTypeIdList;
	}

	// Token: 0x040054FB RID: 21755
	[Nullable(2)]
	private IItemInteractionPanel ItemInteractionPanelInfo;

	// Token: 0x040054FC RID: 21756
	private readonly Dictionary<int, List<ItemInteractionPanelItemData>> ItemDataMainTypeMap = new Dictionary<int, List<ItemInteractionPanelItemData>>();

	// Token: 0x040054FD RID: 21757
	private readonly Dictionary<int, ItemInteractionPanelItemData> ItemDataMap = new Dictionary<int, ItemInteractionPanelItemData>();

	// Token: 0x040054FE RID: 21758
	private readonly List<int> MainTypeIdList = new List<int>();

	// Token: 0x040054FF RID: 21759
	private List<ItemInteractionPanelItemData> CurrentItemDataList = new List<ItemInteractionPanelItemData>();

	// Token: 0x04005500 RID: 21760
	private readonly Dictionary<int, ItemInteractionPanelMainTypeItem> MainTypeItemMap = new Dictionary<int, ItemInteractionPanelMainTypeItem>();

	// Token: 0x04005501 RID: 21761
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData> ItemScrollView;

	// Token: 0x04005502 RID: 21762
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ItemInteractionPanelItemData> OnItemExtendToggleStateChangedCallback;

	// Token: 0x04005503 RID: 21763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ItemInteractionPanelItemData> OnReduceButtonTriggerCallback;

	// Token: 0x04005504 RID: 21764
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<ItemInteractionPanelItemData, bool> OnCanExecuteChangeCallback;

	// Token: 0x04005505 RID: 21765
	[Nullable(2)]
	private ItemInteractionPanelMainTypeItem SelectedMainTypeItem;

	// Token: 0x04005506 RID: 21766
	[Nullable(2)]
	private ItemInteractionPanelItemData CurrentSelectedData;

	// Token: 0x02006FD5 RID: 28629
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024887 RID: 149639
		TitleSprite,
		// Token: 0x04024888 RID: 149640
		TitleText,
		// Token: 0x04024889 RID: 149641
		ContentSprite,
		// Token: 0x0402488A RID: 149642
		TitleHorizontalItem,
		// Token: 0x0402488B RID: 149643
		MainTypeItem,
		// Token: 0x0402488C RID: 149644
		LoopScrollView,
		// Token: 0x0402488D RID: 149645
		SourceItemGridItem
	}
}

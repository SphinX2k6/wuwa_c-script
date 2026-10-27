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

// Token: 0x020018CA RID: 6346
[NullableContext(1)]
[Nullable(0)]
public class ItemInteractionPanel : UiPanelBase
{
	// Token: 0x0600BA1D RID: 47645 RVA: 0x002A259C File Offset: 0x002A079C
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

	// Token: 0x0600BA1E RID: 47646 RVA: 0x002A264E File Offset: 0x002A084E
	protected override void OnStart()
	{
		this.ItemScrollView = new LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData>(base.GetLoopScrollViewComponent(5), base.GetItem(6).GetOwner() as AUIBaseActor, new Func<ItemInteractionMediumItemGrid>(this.OnGridProxyCreate), false);
	}

	// Token: 0x0600BA1F RID: 47647 RVA: 0x002A2680 File Offset: 0x002A0880
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

	// Token: 0x0600BA20 RID: 47648 RVA: 0x002A26CB File Offset: 0x002A08CB
	private ItemInteractionMediumItemGrid OnGridProxyCreate()
	{
		ItemInteractionMediumItemGrid itemInteractionMediumItemGrid = new ItemInteractionMediumItemGrid();
		itemInteractionMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnItemExtendToggleStateChanged));
		itemInteractionMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		itemInteractionMediumItemGrid.BindReduceLongPress(new Action<bool, MediumItemGrid, object>(this.OnReduceButtonLongPress));
		return itemInteractionMediumItemGrid;
	}

	// Token: 0x0600BA21 RID: 47649 RVA: 0x002A2708 File Offset: 0x002A0908
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

	// Token: 0x0600BA22 RID: 47650 RVA: 0x002A2734 File Offset: 0x002A0934
	private void OnItemExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
	{
		ItemInteractionPanelItemData itemInteractionPanelItemData = callbackParameter.Data as ItemInteractionPanelItemData;
		this.SetItemGridSelected(true, itemInteractionPanelItemData);
		if (this.OnItemExtendToggleStateChangedCallback != null)
		{
			this.OnItemExtendToggleStateChangedCallback(itemInteractionPanelItemData);
		}
	}

	// Token: 0x0600BA23 RID: 47651 RVA: 0x002A276C File Offset: 0x002A096C
	[NullableContext(2)]
	private bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		ItemInteractionPanelItemData itemInteractionPanelItemData = data as ItemInteractionPanelItemData;
		return (this.CurrentSelectedData == null || !this.CurrentSelectedData.IsSelected || itemInteractionPanelItemData != this.CurrentSelectedData) && this.CurrentItemDataList.IndexOf(itemInteractionPanelItemData) >= 0 && (this.OnCanExecuteChangeCallback == null || this.OnCanExecuteChangeCallback(itemInteractionPanelItemData));
	}

	// Token: 0x0600BA24 RID: 47652 RVA: 0x002A27C7 File Offset: 0x002A09C7
	public void BindOnReduceButtonTrigger(Action<ItemInteractionPanelItemData> onReduceButtonTriggerCallback)
	{
		this.OnReduceButtonTriggerCallback = onReduceButtonTriggerCallback;
	}

	// Token: 0x0600BA25 RID: 47653 RVA: 0x002A27D0 File Offset: 0x002A09D0
	public void BindOnItemExtendToggleStateChanged(Action<ItemInteractionPanelItemData> onItemExtendToggleStateChangedCallback)
	{
		this.OnItemExtendToggleStateChangedCallback = onItemExtendToggleStateChangedCallback;
	}

	// Token: 0x0600BA26 RID: 47654 RVA: 0x002A27D9 File Offset: 0x002A09D9
	public void BindOnCanExecuteChange(Func<ItemInteractionPanelItemData, bool> onCanExecuteChangeCallback)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChangeCallback;
	}

	// Token: 0x0600BA27 RID: 47655 RVA: 0x002A27E4 File Offset: 0x002A09E4
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

	// Token: 0x0600BA28 RID: 47656 RVA: 0x002A2840 File Offset: 0x002A0A40
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

	// Token: 0x0600BA29 RID: 47657 RVA: 0x002A29C4 File Offset: 0x002A0BC4
	private UniTask RefreshMainTypeExtendToggle()
	{
		ItemInteractionPanel.<RefreshMainTypeExtendToggle>d__25 <RefreshMainTypeExtendToggle>d__;
		<RefreshMainTypeExtendToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMainTypeExtendToggle>d__.<>4__this = this;
		<RefreshMainTypeExtendToggle>d__.<>1__state = -1;
		<RefreshMainTypeExtendToggle>d__.<>t__builder.Start<ItemInteractionPanel.<RefreshMainTypeExtendToggle>d__25>(ref <RefreshMainTypeExtendToggle>d__);
		return <RefreshMainTypeExtendToggle>d__.<>t__builder.Task;
	}

	// Token: 0x0600BA2A RID: 47658 RVA: 0x002A2A07 File Offset: 0x002A0C07
	private void OnMainTypeExtendToggleStateChanged(int mainTypeId)
	{
		this.SelectedMainType(mainTypeId);
	}

	// Token: 0x0600BA2B RID: 47659 RVA: 0x002A2A10 File Offset: 0x002A0C10
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

	// Token: 0x0600BA2C RID: 47660 RVA: 0x002A2A68 File Offset: 0x002A0C68
	public void SetMainTypeRedDotVisible(int mainTypeId, bool bVisible)
	{
		ItemInteractionPanelMainTypeItem itemInteractionPanelMainTypeItem;
		if (this.MainTypeItemMap.TryGetValue(mainTypeId, out itemInteractionPanelMainTypeItem))
		{
			itemInteractionPanelMainTypeItem.SetRedDotVisible(bVisible);
		}
	}

	// Token: 0x0600BA2D RID: 47661 RVA: 0x002A2A8C File Offset: 0x002A0C8C
	private void ClearMainTypeItem()
	{
		foreach (ItemInteractionPanelMainTypeItem itemInteractionPanelMainTypeItem in this.MainTypeItemMap.Values)
		{
			itemInteractionPanelMainTypeItem.Destroy(null);
		}
		this.MainTypeItemMap.Clear();
	}

	// Token: 0x0600BA2E RID: 47662 RVA: 0x002A2AF0 File Offset: 0x002A0CF0
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

	// Token: 0x0600BA2F RID: 47663 RVA: 0x002A2B18 File Offset: 0x002A0D18
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

	// Token: 0x0600BA30 RID: 47664 RVA: 0x002A2B48 File Offset: 0x002A0D48
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

	// Token: 0x0600BA31 RID: 47665 RVA: 0x002A2B92 File Offset: 0x002A0D92
	public List<ItemInteractionPanelItemData> GetCurrentItemDataList()
	{
		return this.CurrentItemDataList;
	}

	// Token: 0x0600BA32 RID: 47666 RVA: 0x002A2B9C File Offset: 0x002A0D9C
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

	// Token: 0x0600BA33 RID: 47667 RVA: 0x002A2BBC File Offset: 0x002A0DBC
	public IReadOnlyDictionary<int, List<ItemInteractionPanelItemData>> GetItemDataMainTypeMap()
	{
		return this.ItemDataMainTypeMap;
	}

	// Token: 0x0600BA34 RID: 47668 RVA: 0x002A2BC4 File Offset: 0x002A0DC4
	public IReadOnlyList<int> GetMainTypeIdList()
	{
		return this.MainTypeIdList;
	}

	// Token: 0x04005450 RID: 21584
	[Nullable(2)]
	private IItemInteractionPanel ItemInteractionPanelInfo;

	// Token: 0x04005451 RID: 21585
	private readonly Dictionary<int, List<ItemInteractionPanelItemData>> ItemDataMainTypeMap = new Dictionary<int, List<ItemInteractionPanelItemData>>();

	// Token: 0x04005452 RID: 21586
	private readonly Dictionary<int, ItemInteractionPanelItemData> ItemDataMap = new Dictionary<int, ItemInteractionPanelItemData>();

	// Token: 0x04005453 RID: 21587
	private readonly List<int> MainTypeIdList = new List<int>();

	// Token: 0x04005454 RID: 21588
	private List<ItemInteractionPanelItemData> CurrentItemDataList = new List<ItemInteractionPanelItemData>();

	// Token: 0x04005455 RID: 21589
	private readonly Dictionary<int, ItemInteractionPanelMainTypeItem> MainTypeItemMap = new Dictionary<int, ItemInteractionPanelMainTypeItem>();

	// Token: 0x04005456 RID: 21590
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ItemInteractionMediumItemGrid, ItemInteractionPanelItemData> ItemScrollView;

	// Token: 0x04005457 RID: 21591
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ItemInteractionPanelItemData> OnItemExtendToggleStateChangedCallback;

	// Token: 0x04005458 RID: 21592
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ItemInteractionPanelItemData> OnReduceButtonTriggerCallback;

	// Token: 0x04005459 RID: 21593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<ItemInteractionPanelItemData, bool> OnCanExecuteChangeCallback;

	// Token: 0x0400545A RID: 21594
	[Nullable(2)]
	private ItemInteractionPanelMainTypeItem SelectedMainTypeItem;

	// Token: 0x0400545B RID: 21595
	[Nullable(2)]
	private ItemInteractionPanelItemData CurrentSelectedData;

	// Token: 0x02007E4E RID: 32334
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402955A RID: 169306
		TitleSprite,
		// Token: 0x0402955B RID: 169307
		TitleText,
		// Token: 0x0402955C RID: 169308
		ContentSprite,
		// Token: 0x0402955D RID: 169309
		TitleHorizontalItem,
		// Token: 0x0402955E RID: 169310
		MainTypeItem,
		// Token: 0x0402955F RID: 169311
		LoopScrollView,
		// Token: 0x04029560 RID: 169312
		SourceItemGridItem
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemDeliver;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FE6 RID: 8166
[NullableContext(1)]
[Nullable(0)]
public class ItemDeliverView : UiViewBase
{
	// Token: 0x0600FFEB RID: 65515 RVA: 0x003E593D File Offset: 0x003E3B3D
	public ItemDeliverView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600FFEC RID: 65516 RVA: 0x003E5948 File Offset: 0x003E3B48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickConfirmButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FFED RID: 65517 RVA: 0x003E5A94 File Offset: 0x003E3C94
	private void OnClickConfirmButton()
	{
		if (this.IsDelivering)
		{
			return;
		}
		if (!this.IsEnoughSubmit())
		{
			ScrollingTipsController.Instance.ShowTipsById("DeliverNoMaterial", Array.Empty<object>());
			return;
		}
		GeneralContext context = this.DeliverData.Context;
		if (context == null)
		{
			return;
		}
		this.IsDelivering = true;
		List<DeliverSlotData> slotDataList = this.DeliverData.GetSlotDataList();
		if (context.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree)
		{
			List<PbHandInItem> list = new List<PbHandInItem>();
			foreach (DeliverSlotData deliverSlotData in slotDataList)
			{
				if (deliverSlotData.HasItem())
				{
					PbHandInItemInfo pbHandInItemInfo = PbHandInItemInfo.Create();
					pbHandInItemInfo.IncId = 0;
					pbHandInItemInfo.ItemId = deliverSlotData.GetCurrentItemConfigId();
					pbHandInItemInfo.Num = deliverSlotData.GetCurrentCount();
					List<PbHandInItemInfo> values = new List<PbHandInItemInfo>
					{
						pbHandInItemInfo
					};
					PbHandInItem pbHandInItem = PbHandInItem.Create();
					pbHandInItem.HandItemInfo.AddRange(values);
					pbHandInItem.Count = deliverSlotData.GetNeedCount();
					pbHandInItem.PbHandInItemType = PbHandInItemType.ItemIds;
					EHandInItemType handInType = deliverSlotData.HandInType;
					if (handInType != EHandInItemType.ItemIds)
					{
						if (handInType == EHandInItemType.ItemType)
						{
							pbHandInItem.PbHandInItemType = PbHandInItemType.ItemType;
						}
					}
					else
					{
						pbHandInItem.PbHandInItemType = PbHandInItemType.ItemIds;
					}
					list.Add(pbHandInItem);
				}
			}
			ItemDeliverController.Instance.HandInItemRequest(context, list, new Action<bool>(this.OnDeliverResponse));
			return;
		}
		if (context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
		{
			DeliverSlotData deliverSlotData2 = slotDataList[0];
			if (deliverSlotData2.HasItem())
			{
				ItemDeliverController.Instance.ItemUseRequest(context, deliverSlotData2.GetCurrentItemConfigId(), deliverSlotData2.GetCurrentCount(), new Action<bool>(this.OnDeliverResponse));
			}
		}
	}

	// Token: 0x0600FFEE RID: 65518 RVA: 0x003E5C40 File Offset: 0x003E3E40
	private void OnDeliverResponse(bool bSuccess)
	{
		this.IsDelivering = false;
		if (bSuccess)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600FFEF RID: 65519 RVA: 0x003E5C54 File Offset: 0x003E3E54
	private bool IsEnoughSubmit()
	{
		foreach (DeliverSlotData deliverSlotData in this.DeliverData.GetSlotDataList())
		{
			if (deliverSlotData.GetCurrentCount() < deliverSlotData.GetNeedCount())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600FFF0 RID: 65520 RVA: 0x003E5CBC File Offset: 0x003E3EBC
	protected override UniTask OnBeforeStartAsync()
	{
		ItemDeliverView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemDeliverView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FFF1 RID: 65521 RVA: 0x003E5D00 File Offset: 0x003E3F00
	protected override void OnStart()
	{
		this.DeliverData = (this.OpenParam as DeliverData);
		if (this.DeliverData == null)
		{
			return;
		}
		this.PopupCaptionItem.SetCloseBtnActive(true);
		this.PopupCaptionItem.SetHelpBtnActive(false);
		this.RefreshTitleText();
		this.RefreshDescriptionText();
		this.RefreshAllDeliverSlot(delegate
		{
			DeliverSlotData deliverSlotData = this.DeliverData.GetSlotDataList()[0];
			if (deliverSlotData != null)
			{
				this.RefreshItemInteractionPanel(deliverSlotData, deliverSlotData.GetNeedCount());
				bool flag = deliverSlotData.GetItemRangeList().Count <= 1;
				this.PopupCaptionItem.SetTitleIconVisible(flag);
				this.PopupCaptionItem.SetTitleTextActive(flag);
				if (flag)
				{
					string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconDeliver");
					this.PopupCaptionItem.SetTitleIcon(resourcePath);
				}
			}
		});
	}

	// Token: 0x0600FFF2 RID: 65522 RVA: 0x003E5D5D File Offset: 0x003E3F5D
	protected override void OnBeforeDestroy()
	{
		DeliverData deliverData = this.DeliverData;
		if (deliverData != null)
		{
			deliverData.Clear();
		}
		this.DeliverData = null;
		this.DeliverScrollView = null;
		this.ItemInteractionPanel = null;
	}

	// Token: 0x0600FFF3 RID: 65523 RVA: 0x003E5D88 File Offset: 0x003E3F88
	private void OnItemExtendToggleStateChanged(ItemInteractionPanelItemData data)
	{
		if (!data.IsEnable())
		{
			ItemController.Instance.OpenItemTipsByItemId(data.ItemConfigId, true, null);
			this.ItemInteractionPanel.SetItemGridSelected(false, data);
			return;
		}
		if (!this.SetDeliverSlotItemByItemConfigId(data.ItemConfigId, 1))
		{
			this.ItemInteractionPanel.SetItemGridSelected(false, data);
			return;
		}
		this.RefreshAllDeliverSlot(null);
		int currentCount = Math.Min(data.GetCurrentCount() + 1, data.GetItemCount());
		data.SetCurrentCount(currentCount);
		this.ItemInteractionPanel.RefreshItemGrid(data);
	}

	// Token: 0x0600FFF4 RID: 65524 RVA: 0x003E5E08 File Offset: 0x003E4008
	private bool OnCanExecuteChange(ItemInteractionPanelItemData data)
	{
		return this.DeliverData != null && this.DeliverData.HasEmptySlot();
	}

	// Token: 0x0600FFF5 RID: 65525 RVA: 0x003E5E20 File Offset: 0x003E4020
	private void OnItemReduceButtonTrigger(ItemInteractionPanelItemData data)
	{
		int num = Math.Max(data.GetCurrentCount() - 1, 0);
		data.SetCurrentCount(num);
		this.ItemInteractionPanel.RefreshItemGrid(data);
		this.SetDeliverSlotItemByItemConfigId(data.ItemConfigId, -1);
		this.RefreshAllDeliverSlot(null);
		if (num <= 0)
		{
			this.ItemInteractionPanel.SetItemGridSelected(false, data);
		}
	}

	// Token: 0x0600FFF6 RID: 65526 RVA: 0x003E5E75 File Offset: 0x003E4075
	private void OnClickedCloseButton()
	{
		ItemDeliverModel.Instance.SetItemDeliverData(null);
		base.CloseMe(null);
	}

	// Token: 0x0600FFF7 RID: 65527 RVA: 0x003E5E89 File Offset: 0x003E4089
	private DeliverMediumItemGrid OnCreateDeliverMediumItemGrid()
	{
		DeliverMediumItemGrid deliverMediumItemGrid = new DeliverMediumItemGrid();
		deliverMediumItemGrid.BindReduceButtonCallback(new Action<MediumItemGridButtonCallback>(this.OnDeliverSlotReduceTrigger), null);
		return deliverMediumItemGrid;
	}

	// Token: 0x0600FFF8 RID: 65528 RVA: 0x003E5EA4 File Offset: 0x003E40A4
	private void OnDeliverSlotReduceTrigger(MediumItemGridButtonCallback callbackParameter)
	{
		DeliverSlotData deliverSlotData = callbackParameter.Data as DeliverSlotData;
		int num = deliverSlotData.GetCurrentCount() - 1;
		deliverSlotData.SetCurrentCount(Math.Max(num, 0));
		ItemInteractionPanelItemData itemData = this.ItemInteractionPanel.GetItemData(deliverSlotData.GetCurrentItemConfigId());
		if (itemData != null)
		{
			itemData.SetCurrentCount(itemData.GetCurrentCount() - 1);
			this.ItemInteractionPanel.RefreshItemGrid(itemData);
			if (num <= 0)
			{
				this.ItemInteractionPanel.SetItemGridSelected(false, itemData);
			}
		}
		if (num <= 0)
		{
			deliverSlotData.ClearItem();
		}
		this.RefreshAllDeliverSlot(null);
	}

	// Token: 0x0600FFF9 RID: 65529 RVA: 0x003E5F24 File Offset: 0x003E4124
	private void RefreshTitleText()
	{
		string titleTextId = this.DeliverData.TitleTextId;
		if (!string.IsNullOrEmpty(titleTextId))
		{
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(titleTextId);
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			text.SetText(configTextByKey, true);
		}
	}

	// Token: 0x0600FFFA RID: 65530 RVA: 0x003E5F64 File Offset: 0x003E4164
	private void RefreshDescriptionText()
	{
		string descriptionTextId = this.DeliverData.DescriptionTextId;
		string newText = string.IsNullOrEmpty(descriptionTextId) ? "" : PublicUtil.Instance.GetConfigTextByKey(descriptionTextId);
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x0600FFFB RID: 65531 RVA: 0x003E5FAC File Offset: 0x003E41AC
	private bool SetDeliverSlotItemByItemConfigId(int itemConfigId, int changeCount)
	{
		List<DeliverSlotData> slotDataList = this.DeliverData.GetSlotDataList();
		if (changeCount > 0)
		{
			DeliverData deliverData = this.DeliverData;
			if (deliverData != null && deliverData.IsSlotEnough(itemConfigId))
			{
				GenericPromptController.Instance.ShowPromptByCode("RepeatedDeliveryItem", Array.Empty<object>());
				return false;
			}
			using (List<DeliverSlotData>.Enumerator enumerator = slotDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DeliverSlotData deliverSlotData = enumerator.Current;
					int currentValue = deliverSlotData.GetCurrentCount() + changeCount;
					int num = MathUtils.Instance.Clamp(currentValue, 0, deliverSlotData.GetNeedCount());
					if (!deliverSlotData.IsEnough())
					{
						if (num <= 0)
						{
							deliverSlotData.ClearItem();
							return true;
						}
						if (deliverSlotData.SetItem(itemConfigId, num))
						{
							return true;
						}
					}
				}
				return false;
			}
		}
		for (int i = slotDataList.Count - 1; i >= 0; i--)
		{
			DeliverSlotData deliverSlotData2 = slotDataList[i];
			if (deliverSlotData2.GetCurrentItemConfigId() == itemConfigId)
			{
				int currentValue2 = deliverSlotData2.GetCurrentCount() + changeCount;
				int num2 = MathUtils.Instance.Clamp(currentValue2, 0, deliverSlotData2.GetNeedCount());
				if (deliverSlotData2.HasItem())
				{
					if (num2 <= 0)
					{
						deliverSlotData2.ClearItem();
						return true;
					}
					if (deliverSlotData2.SetItem(itemConfigId, num2))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600FFFC RID: 65532 RVA: 0x003E60F4 File Offset: 0x003E42F4
	[NullableContext(2)]
	private void RefreshAllDeliverSlot(Action callBack = null)
	{
		List<DeliverSlotData> slotDataList = this.DeliverData.GetSlotDataList();
		GenericLayout<DeliverMediumItemGrid, DeliverSlotData> deliverScrollView = this.DeliverScrollView;
		if (deliverScrollView == null)
		{
			return;
		}
		deliverScrollView.RefreshByData(slotDataList, callBack, false);
	}

	// Token: 0x0600FFFD RID: 65533 RVA: 0x003E6120 File Offset: 0x003E4320
	private void RefreshItemInteractionPanel(DeliverSlotData deliverSlotData, int needCount)
	{
		List<ItemInteractionPanelItemInfo> list = new List<ItemInteractionPanelItemInfo>();
		IReadOnlyList<int> itemRangeList = deliverSlotData.GetItemRangeList();
		if (itemRangeList.Count <= 1)
		{
			this.ItemInteractionPanel.SetActive(false);
			return;
		}
		foreach (int itemConfigId in itemRangeList)
		{
			ItemInteractionPanelItemInfo item = new ItemInteractionPanelItemInfo
			{
				ItemConfigId = itemConfigId,
				CurrentCount = 0,
				NeedCount = new int?(needCount)
			};
			list.Add(item);
		}
		ItemInteractionPanelData itemInteractionPanelInfo = new ItemInteractionPanelData
		{
			ItemInfoList = new List<IItemInteractionPanelItemInfo>(list)
		};
		this.ItemInteractionPanel.Refresh(itemInteractionPanelInfo).ContinueWith(delegate()
		{
			IEnumerable<KeyValuePair<int, List<ItemInteractionPanelItemData>>> itemDataMainTypeMap = this.ItemInteractionPanel.GetItemDataMainTypeMap();
			int needCount2 = this.DeliverData.GetSlotDataList()[0].GetNeedCount();
			int num = this.ItemInteractionPanel.GetMainTypeIdList()[0];
			foreach (KeyValuePair<int, List<ItemInteractionPanelItemData>> keyValuePair in itemDataMainTypeMap)
			{
				int num2;
				List<ItemInteractionPanelItemData> list2;
				keyValuePair.Deconstruct(out num2, out list2);
				int num3 = num2;
				using (List<ItemInteractionPanelItemData>.Enumerator enumerator3 = list2.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						if (enumerator3.Current.GetItemCount() >= needCount2 && num3 != num)
						{
							ItemInteractionPanel itemInteractionPanel = this.ItemInteractionPanel;
							if (itemInteractionPanel == null)
							{
								break;
							}
							itemInteractionPanel.SetMainTypeRedDotVisible(num3, true);
							break;
						}
					}
				}
			}
		});
		this.ItemInteractionPanel.SetActive(true);
	}

	// Token: 0x04007672 RID: 30322
	[Nullable(2)]
	private DeliverData DeliverData;

	// Token: 0x04007673 RID: 30323
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DeliverMediumItemGrid, DeliverSlotData> DeliverScrollView;

	// Token: 0x04007674 RID: 30324
	[Nullable(2)]
	private ItemInteractionPanel ItemInteractionPanel;

	// Token: 0x04007675 RID: 30325
	[Nullable(2)]
	private PopupCaptionItem PopupCaptionItem;

	// Token: 0x04007676 RID: 30326
	private bool IsDelivering;

	// Token: 0x020085FB RID: 34299
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402B9B7 RID: 178615
		public const int TitleItem = 0;

		// Token: 0x0402B9B8 RID: 178616
		public const int ItemPanelItem = 1;

		// Token: 0x0402B9B9 RID: 178617
		public const int ConfirmButton = 2;

		// Token: 0x0402B9BA RID: 178618
		public const int DescriptionText = 3;

		// Token: 0x0402B9BB RID: 178619
		public const int DeliverScrollView = 4;

		// Token: 0x0402B9BC RID: 178620
		public const int ContentHorizontalLayout = 5;

		// Token: 0x0402B9BD RID: 178621
		public const int TitleText = 6;
	}
}

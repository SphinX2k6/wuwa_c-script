using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Inventory;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001E9E RID: 7838
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryEquipGridItem : HonamiStoryGridItemBase
{
	// Token: 0x0600F0A7 RID: 61607 RVA: 0x0039C5A4 File Offset: 0x0039A7A4
	public HonamiStoryEquipGridItem(bool needItem, HonamiStoryBackpackPanelBase panel = null, HonamiStoryItemDataBase itemData = null) : base(needItem, panel, itemData)
	{
	}

	// Token: 0x0600F0A8 RID: 61608 RVA: 0x0039C5AF File Offset: 0x0039A7AF
	public int GetPosition()
	{
		if (this.Data != null)
		{
			return this.Data.GetPosition();
		}
		return this.Position;
	}

	// Token: 0x0600F0A9 RID: 61609 RVA: 0x0039C5CC File Offset: 0x0039A7CC
	public bool GetIsUnlock()
	{
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(this.GetPosition());
		List<HonamiStoryRoleEquipSlotData> slotList = roleItemDataByPosition.GetSlotList();
		int honamiStoryPluginIndex = roleItemDataByPosition.GetHonamiStoryPluginIndex(this.GetPosition());
		return slotList[honamiStoryPluginIndex].GetIsUnlock();
	}

	// Token: 0x0600F0AA RID: 61610 RVA: 0x0039C608 File Offset: 0x0039A808
	[NullableContext(0)]
	public ValueTuple<bool, bool> GetSlotUnlockConfig()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(false);
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(this.GetPosition());
		List<HonamiStoryRoleEquipSlotData> slotList = roleItemDataByPosition.GetSlotList();
		int honamiStoryPluginIndex = roleItemDataByPosition.GetHonamiStoryPluginIndex(this.GetPosition());
		HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData = slotList[honamiStoryPluginIndex];
		bool flag = activityData != null && activityData.GetPreGuideQuestFinishState();
		bool flag2 = !honamiStoryRoleEquipSlotData.GetIsUnlock() && (honamiStoryPluginIndex == 0 || slotList[honamiStoryPluginIndex - 1].GetIsUnlock());
		bool flag3 = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		bool item = flag && flag2 && !flag3;
		return new ValueTuple<bool, bool>(honamiStoryRoleEquipSlotData.GetIsUnlock(), item);
	}

	// Token: 0x0600F0AB RID: 61611 RVA: 0x0039C69C File Offset: 0x0039A89C
	public void SetPosition(int position)
	{
		this.Position = position;
	}

	// Token: 0x0600F0AC RID: 61612 RVA: 0x0039C6A8 File Offset: 0x0039A8A8
	public unsafe override void Refresh(HonamiStoryItemDataBase data, int position)
	{
		this.Data = data;
		if (data == null)
		{
			HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
			if (itemGridItem != null)
			{
				itemGridItem.SetUiActive(false);
			}
			ValueTuple<bool, bool> slotUnlockConfig = this.GetSlotUnlockConfig();
			bool item = slotUnlockConfig.Item1;
			bool item2 = slotUnlockConfig.Item2;
			this.IsFirstLock = item2;
			this.SpriteBg.SetUIActive(item);
			this.SetLockEnable(!item, item2);
			if (item)
			{
				this.RefreshState();
			}
			base.ClearSequence();
			return;
		}
		this.SetLockEnable(false, false);
		this.SetCanPlaceEnable(false);
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(this.GetPosition());
		if (roleItemDataByPosition == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "获取位置失败";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GetPos", this.GetPosition());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DataPos", data.GetPosition());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("incId", data.GetIncId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("id", data.GetItemId());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		bool isActive = roleItemDataByPosition.CheckRoleItemBuffIsActive((HonamiStoryEquipItemData)data);
		if (this.ItemGridItem == null)
		{
			base.InitItemGridItem(data, -1).ContinueWith(delegate()
			{
				this.PlayNewlyPickedUpSweepAnimation(data);
				this.UpdateActivateSequence(isActive);
			});
			return;
		}
		this.ItemGridItem.SetUiActive(true);
		HonamiStoryItemQuality? qualityConfig = data.GetQualityConfig();
		this.ItemGridItem.Refresh(data, position != -1);
		this.SetSpriteByPath(qualityConfig.Value.GridBg, this.SpriteBg, false, null, null);
		base.PlayNewlyPickedUpSweepAnimation(data);
		this.UpdateActivateSequence(isActive);
	}

	// Token: 0x0600F0AD RID: 61613 RVA: 0x0039C8C7 File Offset: 0x0039AAC7
	private void UpdateActivateSequence(bool isActive)
	{
		if (isActive)
		{
			base.PlaySequenceByName("Activate");
			return;
		}
		base.ClearSequence();
	}

	// Token: 0x0600F0AE RID: 61614 RVA: 0x0039C8DF File Offset: 0x0039AADF
	[NullableContext(1)]
	protected override HonamiStoryItemGridItem CreateGridItem([Nullable(2)] HonamiStoryItemDataBase data)
	{
		return new HonamiStoryEquipItemGridItem(data);
	}

	// Token: 0x0600F0AF RID: 61615 RVA: 0x0039C8E8 File Offset: 0x0039AAE8
	protected void SetLockEnable(bool isEnable, bool isFirstLock)
	{
		if (!isEnable && this.LockStateItem == null)
		{
			return;
		}
		if (this.LockStateItem == null)
		{
			this.LockStateItem = new HonamiStorySlotLockStateItem();
			this.LockStateItem.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemStateAdd", this.RootItem, false).ContinueWith(new Action(this.RefreshLockState));
			return;
		}
		if (!this.LockStateItem.InAsyncLoading())
		{
			this.RefreshLockState();
		}
	}

	// Token: 0x0600F0B0 RID: 61616 RVA: 0x0039C954 File Offset: 0x0039AB54
	public void RefreshLockState()
	{
		if (this.LockStateItem == null)
		{
			return;
		}
		ValueTuple<bool, bool> slotUnlockConfig = this.GetSlotUnlockConfig();
		bool item = slotUnlockConfig.Item1;
		bool item2 = slotUnlockConfig.Item2;
		int activityId = HonamiStoryModel.Instance.ActivityId;
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(this.GetPosition());
		List<HonamiStoryRoleEquipSlotData> slotList = roleItemDataByPosition.GetSlotList();
		int honamiStoryPluginIndex = roleItemDataByPosition.GetHonamiStoryPluginIndex(this.GetPosition());
		HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData = slotList[honamiStoryPluginIndex];
		HonamiStoryPluginSlot value = HonamiStoryConfig.Instance.GetSlotUnlockConfig(honamiStoryRoleEquipSlotData.GetSlotId()).Value;
		int outCoinItemId = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId).Value.OutCoinItemId;
		int num = value.ConsumeItems()[outCoinItemId];
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(outCoinItemId, 0);
		this.LockStateItem.RefreshState(!item, item2, itemCountByConfigId >= num);
	}

	// Token: 0x0600F0B1 RID: 61617 RVA: 0x0039CA2C File Offset: 0x0039AC2C
	protected void SetCanPlaceEnable(bool isEnable)
	{
		HonamiStoryItemGridPlacementItem placeStateItem = this.PlaceStateItem;
		if (placeStateItem != null)
		{
			placeStateItem.SetUiActive(isEnable);
		}
		if (isEnable)
		{
			HonamiStoryItemGridPlacementItem placeStateItem2 = this.PlaceStateItem;
			if (placeStateItem2 != null)
			{
				placeStateItem2.Refresh();
			}
		}
		if (isEnable && this.PlaceStateItem == null)
		{
			this.PlaceStateItem = new HonamiStoryItemGridPlacementItem();
			this.PlaceStateItem.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemStatePut", this.RootItem, false).ContinueWith(delegate()
			{
				EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
				bool flag = backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.DraggingPlugins;
				this.PlaceStateItem.SetUiActive(flag);
				if (flag)
				{
					this.PlaceStateItem.Refresh();
				}
			});
		}
	}

	// Token: 0x0600F0B2 RID: 61618 RVA: 0x0039CAA0 File Offset: 0x0039ACA0
	protected override void DoClickedGridButton()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Normal)
		{
			if (this.GetIsUnlock())
			{
				return;
			}
			if (this.IsFirstLock)
			{
				this.UnlockSlot();
				return;
			}
			HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(false);
			bool flag = activityData != null && activityData.GetPreGuideQuestFinishState();
			if (!HonamiStoryUtil.CheckInHonamiStoryDungeon() && flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_CantUnlockLastSlot", Array.Empty<object>());
				return;
			}
		}
		else if (backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			if (!this.GetIsUnlock())
			{
				HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
				return;
			}
			HonamiStoryModel.Instance.GetBackpackLogic().DoTipsWithPluginsInstead(this.GetPosition(), null);
			return;
		}
		else if (backpackLogicState == EHonamiStoryBackpackLogicState.Instead)
		{
			if (!this.GetIsUnlock())
			{
				HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
				return;
			}
			HonamiStoryModel.Instance.GetBackpackLogic().DoTipsWithPluginsInstead(this.GetPosition(), null);
		}
	}

	// Token: 0x0600F0B3 RID: 61619 RVA: 0x0039CB76 File Offset: 0x0039AD76
	public void SetIsEnable(bool value)
	{
		HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
		if (itemGridItem == null)
		{
			return;
		}
		itemGridItem.SetIsEnable(value);
	}

	// Token: 0x0600F0B4 RID: 61620 RVA: 0x0039CB8C File Offset: 0x0039AD8C
	private void UnlockSlot()
	{
		HonamiStoryEquipGridItem.<>c__DisplayClass17_0 CS$<>8__locals1 = new HonamiStoryEquipGridItem.<>c__DisplayClass17_0();
		int activityId = HonamiStoryModel.Instance.ActivityId;
		CS$<>8__locals1.roleEquipData = HonamiStoryModel.Instance.GetRoleItemDataByPosition(this.GetPosition());
		List<HonamiStoryRoleEquipSlotData> slotList = CS$<>8__locals1.roleEquipData.GetSlotList();
		int honamiStoryPluginIndex = CS$<>8__locals1.roleEquipData.GetHonamiStoryPluginIndex(this.GetPosition());
		CS$<>8__locals1.slotData = slotList[honamiStoryPluginIndex];
		HonamiStoryPluginSlot value = HonamiStoryConfig.Instance.GetSlotUnlockConfig(CS$<>8__locals1.slotData.GetSlotId()).Value;
		CS$<>8__locals1.itemId = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId).Value.OutCoinItemId;
		CS$<>8__locals1.needCount = value.ConsumeItems()[CS$<>8__locals1.itemId];
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(CS$<>8__locals1.itemId);
		string value2 = string.Empty;
		if (itemConfigData != null && !string.IsNullOrEmpty(itemConfigData.IconSmall))
		{
			value2 = itemConfigData.IconSmall;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<texture=");
		stringBuilder.Append(value2);
		stringBuilder.Append("/>");
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.HonamiStorySlotUnlockConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<UnlockSlot>g__Cb|0));
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			CS$<>8__locals1.needCount.ToString(),
			stringBuilder.ToString()
		});
		if (InventoryModel.Instance.GetItemCountByConfigId(CS$<>8__locals1.itemId, 0) < CS$<>8__locals1.needCount)
		{
			confirmBoxDataNew.SetTipsBgRed = true;
			confirmBoxDataNew.SetTableTextArgNew("Text_NotEnoughItem_Text", Array.Empty<object>());
			confirmBoxDataNew.InteractionMap[1] = false;
		}
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600F0B5 RID: 61621 RVA: 0x0039CD3C File Offset: 0x0039AF3C
	public void RefreshState()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Normal)
		{
			this.SetSpriteByPath("/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStoryBackpack/SP_GridEmpty.SP_GridEmpty", this.SpriteBg, false, null, null);
			this.SetCanPlaceEnable(false);
			return;
		}
		if (backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.DraggingPlugins)
		{
			this.SetCanPlaceEnable(!Info.Instance.IsInGamepad());
			return;
		}
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Tips)
		{
			this.SetCanPlaceEnable(false);
			return;
		}
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Instead)
		{
			this.SetCanPlaceEnable(true);
		}
	}

	// Token: 0x0600F0B6 RID: 61622 RVA: 0x0039CDAE File Offset: 0x0039AFAE
	protected override void OnBtnPointDown()
	{
	}

	// Token: 0x0600F0B7 RID: 61623 RVA: 0x0039CDB0 File Offset: 0x0039AFB0
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "AddBtn") || this.LockStateItem == null || !this.LockStateItem.IsUiActiveInHierarchy() || !this.IsFirstLock)
		{
			return null;
		}
		UUIItem btnItem = base.GetBtnItem();
		if (btnItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			btnItem,
			btnItem
		};
	}

	// Token: 0x04006F54 RID: 28500
	private int Position;

	// Token: 0x04006F55 RID: 28501
	private bool IsFirstLock;

	// Token: 0x04006F56 RID: 28502
	private HonamiStorySlotLockStateItem LockStateItem;

	// Token: 0x04006F57 RID: 28503
	private HonamiStoryItemGridPlacementItem PlaceStateItem;
}

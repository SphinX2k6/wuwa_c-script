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

// Token: 0x02001360 RID: 4960
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryEquipGridItem : HonamiStoryGridItemBase
{
	// Token: 0x0600C4C6 RID: 50374 RVA: 0x003A8160 File Offset: 0x003A6360
	public HonamiStoryEquipGridItem(bool needItem, HonamiStoryBackpackPanelBase panel = null, HonamiStoryItemDataBase itemData = null) : base(needItem, panel, itemData)
	{
	}

	// Token: 0x0600C4C7 RID: 50375 RVA: 0x003A816B File Offset: 0x003A636B
	public int GetPosition()
	{
		if (this.Data != null)
		{
			return this.Data.GetPosition();
		}
		return this.Position;
	}

	// Token: 0x0600C4C8 RID: 50376 RVA: 0x003A8188 File Offset: 0x003A6388
	public bool GetIsUnlock()
	{
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(this.GetPosition());
		List<HonamiStoryRoleEquipSlotData> slotList = roleItemDataByPosition.GetSlotList();
		int honamiStoryPluginIndex = roleItemDataByPosition.GetHonamiStoryPluginIndex(this.GetPosition());
		return slotList[honamiStoryPluginIndex].GetIsUnlock();
	}

	// Token: 0x0600C4C9 RID: 50377 RVA: 0x003A81C4 File Offset: 0x003A63C4
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

	// Token: 0x0600C4CA RID: 50378 RVA: 0x003A8258 File Offset: 0x003A6458
	public void SetPosition(int position)
	{
		this.Position = position;
	}

	// Token: 0x0600C4CB RID: 50379 RVA: 0x003A8264 File Offset: 0x003A6464
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

	// Token: 0x0600C4CC RID: 50380 RVA: 0x003A8483 File Offset: 0x003A6683
	private void UpdateActivateSequence(bool isActive)
	{
		if (isActive)
		{
			base.PlaySequenceByName("Activate");
			return;
		}
		base.ClearSequence();
	}

	// Token: 0x0600C4CD RID: 50381 RVA: 0x003A849B File Offset: 0x003A669B
	[NullableContext(1)]
	protected override HonamiStoryItemGridItem CreateGridItem([Nullable(2)] HonamiStoryItemDataBase data)
	{
		return new HonamiStoryEquipItemGridItem(data);
	}

	// Token: 0x0600C4CE RID: 50382 RVA: 0x003A84A4 File Offset: 0x003A66A4
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

	// Token: 0x0600C4CF RID: 50383 RVA: 0x003A8510 File Offset: 0x003A6710
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

	// Token: 0x0600C4D0 RID: 50384 RVA: 0x003A85E8 File Offset: 0x003A67E8
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

	// Token: 0x0600C4D1 RID: 50385 RVA: 0x003A865C File Offset: 0x003A685C
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

	// Token: 0x0600C4D2 RID: 50386 RVA: 0x003A8732 File Offset: 0x003A6932
	public void SetIsEnable(bool value)
	{
		HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
		if (itemGridItem == null)
		{
			return;
		}
		itemGridItem.SetIsEnable(value);
	}

	// Token: 0x0600C4D3 RID: 50387 RVA: 0x003A8748 File Offset: 0x003A6948
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

	// Token: 0x0600C4D4 RID: 50388 RVA: 0x003A88F8 File Offset: 0x003A6AF8
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

	// Token: 0x0600C4D5 RID: 50389 RVA: 0x003A896A File Offset: 0x003A6B6A
	protected override void OnBtnPointDown()
	{
	}

	// Token: 0x0600C4D6 RID: 50390 RVA: 0x003A896C File Offset: 0x003A6B6C
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

	// Token: 0x04007035 RID: 28725
	private int Position;

	// Token: 0x04007036 RID: 28726
	private bool IsFirstLock;

	// Token: 0x04007037 RID: 28727
	private HonamiStorySlotLockStateItem LockStateItem;

	// Token: 0x04007038 RID: 28728
	private HonamiStoryItemGridPlacementItem PlaceStateItem;
}

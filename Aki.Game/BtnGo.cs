using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200138B RID: 5003
[NullableContext(1)]
[Nullable(0)]
public class BtnGo : UiPanelBase
{
	// Token: 0x0600C681 RID: 50817 RVA: 0x003B23DC File Offset: 0x003B05DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnGoBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C682 RID: 50818 RVA: 0x003B2508 File Offset: 0x003B0708
	public void SetPnlSelectLv(HonamiStoryLevelInfoView panel)
	{
		this.PnlSelectLv = panel;
		this.IsFreeSelect = FunctionModel.Instance.IsOpen(10121);
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			return;
		}
		this.CostItemId = activityData.OutCoinItemId;
	}

	// Token: 0x0600C683 RID: 50819 RVA: 0x003B254D File Offset: 0x003B074D
	public void SetCostData(Dictionary<int, int> itemCountMap)
	{
		this.ItemCountMap = itemCountMap;
		this.RefreshView();
	}

	// Token: 0x0600C684 RID: 50820 RVA: 0x003B255C File Offset: 0x003B075C
	public void RefreshView()
	{
		UUITexture texture = base.GetTexture(3);
		UUIText text = base.GetText(4);
		UUIItem item = base.GetItem(5);
		int num = this.PnlSelectLv.GetCurSafeLeavePrice();
		int num2;
		if (this.IsFreeSelect && this.ItemCountMap.TryGetValue(this.CostItemId, out num2))
		{
			num += num2;
		}
		bool uiactive = num > 0;
		item.SetUIActive(uiactive);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.CostItemId);
		if (itemConfigData == null)
		{
			return;
		}
		base.SetTextureByPath(itemConfigData.Icon, texture, null, null);
		this.NeedCount = num;
		text.SetText(this.NeedCount.ToString(), true);
		bool flag = InventoryModel.Instance.GetItemCountByConfigId(this.CostItemId, 0) >= this.NeedCount;
		UUIItem uuiitem = text;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0600C685 RID: 50821 RVA: 0x003B263C File Offset: 0x003B083C
	private void SetLoadingPerform(bool isTower)
	{
		if (isTower)
		{
			HonamiStoryController.Instance.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.Tower);
			return;
		}
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			return;
		}
		if (activityData.IsAllAreaPass())
		{
			HonamiStoryController.Instance.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.FreeExplore);
			return;
		}
		int currentProgressAreaDataId = activityData.GetCurrentProgressAreaDataId();
		HonamiStoryAreaData honamiStoryAreaData = activityData.GetHonamiStoryAreaData(currentProgressAreaDataId);
		if (honamiStoryAreaData == null || !honamiStoryAreaData.IsAreaCanEnter)
		{
			return;
		}
		int mainBTId = honamiStoryAreaData.Config.Value.MainBTId;
		HonamiStoryController.Instance.SetHonamiStoryLoadingInfoByBtId(mainBTId);
	}

	// Token: 0x0600C686 RID: 50822 RVA: 0x003B26BC File Offset: 0x003B08BC
	private void OnGoBtnClick()
	{
		int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
		bool flag;
		if (allRoleIdList != null && allRoleIdList.Length != 0)
		{
			flag = Array.TrueForAll<int>(allRoleIdList, (int id) => id == 0);
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_Tips_TeamUnderstaffed", Array.Empty<object>());
			return;
		}
		if (this.PnlSelectLv == null)
		{
			return;
		}
		if (HonamiStoryModel.Instance.GetBackPackData(1, false).GetOverflowCapacity() > 0)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.HonamiStoryStorageFullConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OnTeamBtnClick));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (InventoryModel.Instance.GetItemCountByConfigId(this.CostItemId, 0) < this.NeedCount)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_InsufficientBalance", Array.Empty<object>());
			return;
		}
		bool flag2 = this.PnlSelectLv.GetCurTarget.GetValueOrDefault() == ETarget.Tower;
		bool isBuy = this.PnlSelectLv.GetIsBuySafe;
		if (flag2)
		{
			isBuy = false;
			if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockBtnGoRedDot, false))
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockBtnGoRedDot, false);
			}
		}
		this.SetLoadingPerform(flag2);
		HonamiStoryController.Instance.SendHonamiStoryItemEnterRequest(flag2, this.PnlSelectLv.GetCurDangerLv, isBuy);
	}

	// Token: 0x0600C687 RID: 50823 RVA: 0x003B27FA File Offset: 0x003B09FA
	public void SetRedDotShow(bool isShow)
	{
		base.GetItem(2).SetUIActive(isShow);
	}

	// Token: 0x0600C688 RID: 50824 RVA: 0x003B2809 File Offset: 0x003B0A09
	private void OnTeamBtnClick()
	{
		HonamiStoryController.Instance.OpenHonamiStoryBag();
	}

	// Token: 0x04007122 RID: 28962
	private int NeedCount;

	// Token: 0x04007123 RID: 28963
	private int CostItemId;

	// Token: 0x04007124 RID: 28964
	[Nullable(2)]
	private HonamiStoryLevelInfoView PnlSelectLv;

	// Token: 0x04007125 RID: 28965
	private bool IsFreeSelect;

	// Token: 0x04007126 RID: 28966
	private Dictionary<int, int> ItemCountMap = new Dictionary<int, int>();
}

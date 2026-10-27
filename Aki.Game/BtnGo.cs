using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EC9 RID: 7881
[NullableContext(1)]
[Nullable(0)]
public class BtnGo : UiPanelBase
{
	// Token: 0x0600F262 RID: 62050 RVA: 0x003A68DC File Offset: 0x003A4ADC
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

	// Token: 0x0600F263 RID: 62051 RVA: 0x003A6A08 File Offset: 0x003A4C08
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

	// Token: 0x0600F264 RID: 62052 RVA: 0x003A6A4D File Offset: 0x003A4C4D
	public void SetCostData(Dictionary<int, int> itemCountMap)
	{
		this.ItemCountMap = itemCountMap;
		this.RefreshView();
	}

	// Token: 0x0600F265 RID: 62053 RVA: 0x003A6A5C File Offset: 0x003A4C5C
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

	// Token: 0x0600F266 RID: 62054 RVA: 0x003A6B3C File Offset: 0x003A4D3C
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

	// Token: 0x0600F267 RID: 62055 RVA: 0x003A6BBC File Offset: 0x003A4DBC
	private void OnGoBtnClick()
	{
		int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
		bool flag;
		if (allRoleIdList != null && allRoleIdList.Length != 0)
		{
			flag = allRoleIdList.All((int id) => id == 0);
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

	// Token: 0x0600F268 RID: 62056 RVA: 0x003A6CFA File Offset: 0x003A4EFA
	public void SetRedDotShow(bool isShow)
	{
		base.GetItem(2).SetUIActive(isShow);
	}

	// Token: 0x0600F269 RID: 62057 RVA: 0x003A6D09 File Offset: 0x003A4F09
	private void OnTeamBtnClick()
	{
		HonamiStoryController.Instance.OpenHonamiStoryBag();
	}

	// Token: 0x04007041 RID: 28737
	private int NeedCount;

	// Token: 0x04007042 RID: 28738
	private int CostItemId;

	// Token: 0x04007043 RID: 28739
	[Nullable(2)]
	private HonamiStoryLevelInfoView PnlSelectLv;

	// Token: 0x04007044 RID: 28740
	private bool IsFreeSelect;

	// Token: 0x04007045 RID: 28741
	private Dictionary<int, int> ItemCountMap = new Dictionary<int, int>();
}

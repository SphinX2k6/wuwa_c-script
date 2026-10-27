using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002839 RID: 10297
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevRecommendItem : GridProxyAbstract<RoleDevWeaponSubRecommendItemDataBase>
{
	// Token: 0x060153AA RID: 86954 RVA: 0x0055D248 File Offset: 0x0055B448
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickCall))
		};
	}

	// Token: 0x060153AB RID: 86955 RVA: 0x0055D334 File Offset: 0x0055B534
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevRecommendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevRecommendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060153AC RID: 86956 RVA: 0x0055D378 File Offset: 0x0055B578
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		RoleDevWeaponSubRecommendItemDataBase data = this.Data;
		int? num = (data != null) ? new int?(data.WeaponId) : null;
		if (num != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null);
		}
	}

	// Token: 0x060153AD RID: 86957 RVA: 0x0055D3C1 File Offset: 0x0055B5C1
	protected override void OnStart()
	{
		this.InitUiVisibility();
		this.InitButton();
	}

	// Token: 0x060153AE RID: 86958 RVA: 0x0055D3CF File Offset: 0x0055B5CF
	private void InitUiVisibility()
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x060153AF RID: 86959 RVA: 0x0055D3F8 File Offset: 0x0055B5F8
	private void InitButton()
	{
		this.ButtonJump.SetFunction(new Action<int>(this.OnClickJump));
		this.ButtonJump.SetLocalTextNew("RoleProject_Tips02", Array.Empty<object>());
		this.ButtonMoonCard.SetFunction(new Action<int>(this.OnClickMoonCard));
		this.ButtonMoonCard.SetLocalTextNew("RoleProject_Button04", Array.Empty<object>());
		this.ButtonMoonCard.SetRedDotVisible(false);
	}

	// Token: 0x060153B0 RID: 86960 RVA: 0x0055D469 File Offset: 0x0055B669
	public override void Refresh(RoleDevWeaponSubRecommendItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.ItemIndexInternal = gridIndex;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.WeaponName, Array.Empty<object>());
		this.RefreshPanel(data);
	}

	// Token: 0x17001C47 RID: 7239
	// (get) Token: 0x060153B1 RID: 86961 RVA: 0x0055D49C File Offset: 0x0055B69C
	public int ItemIndex
	{
		get
		{
			return this.ItemIndexInternal;
		}
	}

	// Token: 0x060153B2 RID: 86962 RVA: 0x0055D4A4 File Offset: 0x0055B6A4
	private void RefreshPanel(RoleDevWeaponSubRecommendItemDataBase data)
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(data.IsEquipped);
		}
		base.GetButton(2).RootUIComp.Get().SetUIActive(!data.IsEquipped && data.IsCall);
		this.RefreshJumpButton(data);
		this.RefreshPathButton(data);
		this.RefreshItemGrid(data);
	}

	// Token: 0x060153B3 RID: 86963 RVA: 0x0055D508 File Offset: 0x0055B708
	private void RefreshItemGrid(RoleDevWeaponSubRecommendItemDataBase data)
	{
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(data.WeaponId);
		if (weaponConfigByItemId == null)
		{
			return;
		}
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			ItemConfigId = new int?(weaponConfigByItemId.Value.ItemId),
			Data = data
		};
		this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x060153B4 RID: 86964 RVA: 0x0055D564 File Offset: 0x0055B764
	private void RefreshJumpButton(RoleDevWeaponSubRecommendItemDataBase data)
	{
		if (this.ButtonJump == null)
		{
			return;
		}
		if (data.IsObtained && !data.IsEquipped)
		{
			string textId = data.HasRole ? "RoleProject_Button05" : "RoleProject_Button06";
			this.ButtonJump.SetLocalTextNew(textId, Array.Empty<object>());
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.Data.WeaponId, 0);
			this.ButtonJump.SetUiActive(itemCountByConfigId > 0);
			return;
		}
		this.ButtonJump.SetUiActive(false);
	}

	// Token: 0x060153B5 RID: 86965 RVA: 0x0055D5E4 File Offset: 0x0055B7E4
	private void RefreshPathButton(RoleDevWeaponSubRecommendItemDataBase data)
	{
		UUIItem item = base.GetItem(4);
		if (InventoryModel.Instance.GetItemCountByConfigId(data.WeaponId, 0) > 0)
		{
			this.ButtonMoonCard.SetUiActive(false);
			item.SetUIActive(false);
			return;
		}
		RoleDevWeaponJumpGroup? weaponJumpGroupConfig = data.WeaponJumpGroupConfig;
		if (weaponJumpGroupConfig != null)
		{
			weaponJumpGroupConfig = data.WeaponJumpGroupConfig;
			if (weaponJumpGroupConfig.Value.JumpPath != 0)
			{
				ButtonItem buttonMoonCard = this.ButtonMoonCard;
				weaponJumpGroupConfig = data.WeaponJumpGroupConfig;
				buttonMoonCard.SetLocalTextNew(weaponJumpGroupConfig.Value.PathDescribe, Array.Empty<object>());
				this.ButtonMoonCard.SetUiActive(true);
				item.SetUIActive(false);
				return;
			}
		}
		this.ButtonMoonCard.SetUiActive(false);
		item.SetUIActive(true);
		weaponJumpGroupConfig = data.WeaponJumpGroupConfig;
		if (weaponJumpGroupConfig != null && !data.IsCall)
		{
			weaponJumpGroupConfig = data.WeaponJumpGroupConfig;
			if (weaponJumpGroupConfig.Value.JumpType == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_Access_None", Array.Empty<object>());
				return;
			}
		}
		weaponJumpGroupConfig = data.WeaponJumpGroupConfig;
		string textStringId = ((weaponJumpGroupConfig != null) ? weaponJumpGroupConfig.GetValueOrDefault().PathDescribe : null) ?? "";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, Array.Empty<object>());
	}

	// Token: 0x060153B6 RID: 86966 RVA: 0x0055D726 File Offset: 0x0055B926
	private void OnClickCall()
	{
		RoleDevWeaponSubRecommendItemDataBase data = this.Data;
		if (data != null && data.GachaId > 0)
		{
			this.JumpToGachaInterface();
		}
	}

	// Token: 0x060153B7 RID: 86967 RVA: 0x0055D748 File Offset: 0x0055B948
	private void OnClickJump(int _)
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.HasRole)
		{
			this.JumpToWeaponReplaceInterface();
		}
		else
		{
			this.JumpToBackpackInterface();
		}
		ERoleDevSubPageButton subPage;
		switch (this.ItemIndex)
		{
		case 0:
			subPage = ERoleDevSubPageButton.GoToEquip1;
			break;
		case 1:
			subPage = ERoleDevSubPageButton.GoToEquip2;
			break;
		case 2:
			subPage = ERoleDevSubPageButton.GoToEquip3;
			break;
		default:
			subPage = ERoleDevSubPageButton.GoToEquip1;
			break;
		}
		RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Weapon, subPage);
	}

	// Token: 0x060153B8 RID: 86968 RVA: 0x0055D7BC File Offset: 0x0055B9BC
	private void JumpToWeaponReplaceInterface()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(this.Data.RoleId);
		if (weaponInstanceByRoleId == null)
		{
			return;
		}
		List<WeaponItemData> weaponListFromReplace = WeaponModel.Instance.GetWeaponListFromReplace(weaponInstanceByRoleId.GetWeaponConfig().Value.WeaponType);
		int sortId = SortConfig.Instance.GetSortId(EFilterSortGroupId.UseWayWeaponResonanceAndReplace);
		Sort? sortConfig = SortConfig.Instance.GetSortConfig(sortId);
		if (sortConfig == null)
		{
			return;
		}
		SortResultData sortResultData = new SortResultData();
		sortResultData.SetConfigId(sortConfig.Value.Id);
		sortResultData.SetIsAscending(false);
		int ruleId = sortConfig.Value.BaseSortList()[0];
		string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, (ESortDataType)sortConfig.Value.DataId);
		sortResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, sortRuleName));
		SortModel.Instance.SortDataList<WeaponItemData>(weaponListFromReplace, sortConfig.Value.Id, sortResultData, Array.Empty<object>());
		int num = -1;
		int num2 = -1;
		foreach (WeaponItemData weaponItemData in weaponListFromReplace)
		{
			if (weaponItemData.GetConfigId() == this.Data.WeaponId)
			{
				WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(weaponItemData.GetUniqueId());
				if (weaponDataByIncId != null)
				{
					if (weaponDataByIncId.GetRoleId() == 0)
					{
						num2 = weaponItemData.GetUniqueId();
						break;
					}
					if (num < 0)
					{
						num = weaponItemData.GetUniqueId();
					}
				}
			}
		}
		if (num2 < 0)
		{
			num2 = num;
		}
		RoleDevUtils.OpenWeaponReplaceView(this.Data.RoleId, num2);
	}

	// Token: 0x060153B9 RID: 86969 RVA: 0x0055D960 File Offset: 0x0055BB60
	private void JumpToBackpackInterface()
	{
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.Data.WeaponId);
		if (weaponConfigByItemId == null)
		{
			return;
		}
		List<WeaponItemData> weaponListFromReplace = WeaponModel.Instance.GetWeaponListFromReplace(weaponConfigByItemId.Value.WeaponType);
		int sortId = SortConfig.Instance.GetSortId(EFilterSortGroupId.UseWayWeaponResonanceAndReplace);
		Sort? sortConfig = SortConfig.Instance.GetSortConfig(sortId);
		if (sortConfig == null)
		{
			return;
		}
		SortResultData sortResultData = new SortResultData();
		sortResultData.SetConfigId(sortConfig.Value.Id);
		sortResultData.SetIsAscending(false);
		int ruleId = sortConfig.Value.BaseSortList()[0];
		string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, (ESortDataType)sortConfig.Value.DataId);
		sortResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, sortRuleName));
		SortModel.Instance.SortDataList<WeaponItemData>(weaponListFromReplace, sortConfig.Value.Id, sortResultData, Array.Empty<object>());
		int? num = null;
		foreach (WeaponItemData weaponItemData in weaponListFromReplace)
		{
			if (weaponItemData.GetConfigId() == this.Data.WeaponId)
			{
				num = new int?(weaponItemData.GetUniqueId());
				break;
			}
		}
		UiManager.Instance.OpenView(EUiViewName.InventoryView, num, null);
	}

	// Token: 0x060153BA RID: 86970 RVA: 0x0055DAD4 File Offset: 0x0055BCD4
	private void OnClickMoonCard(int _)
	{
		RoleDevWeaponSubRecommendItemDataBase data = this.Data;
		if (data == null || data.WeaponJumpGroupConfig == null)
		{
			return;
		}
		if (this.Data.WeaponJumpGroupConfig.Value.JumpType == 3)
		{
			this.JumpToConfiguredPath(this.Data.WeaponJumpGroupConfig.Value.JumpPath);
		}
	}

	// Token: 0x060153BB RID: 86971 RVA: 0x0055DB40 File Offset: 0x0055BD40
	private void JumpToConfiguredPath(int jumpPath)
	{
		this.RunByConfigId(jumpPath, null);
	}

	// Token: 0x060153BC RID: 86972 RVA: 0x0055DB4A File Offset: 0x0055BD4A
	[NullableContext(2)]
	private void RunByConfigId(int id, object @params = null)
	{
		SkipTaskManager.RunByConfigId(id, @params);
	}

	// Token: 0x060153BD RID: 86973 RVA: 0x0055DB53 File Offset: 0x0055BD53
	private void JumpToGachaInterface()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x04009EA5 RID: 40613
	[Nullable(2)]
	private ButtonItem ButtonJump;

	// Token: 0x04009EA6 RID: 40614
	[Nullable(2)]
	private ButtonItem ButtonMoonCard;

	// Token: 0x04009EA7 RID: 40615
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x04009EA8 RID: 40616
	[Nullable(2)]
	private RoleDevWeaponSubRecommendItemDataBase Data;

	// Token: 0x04009EA9 RID: 40617
	private int ItemIndexInternal;

	// Token: 0x02008E7B RID: 36475
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E354 RID: 189268
		WeaponItem,
		// Token: 0x0402E355 RID: 189269
		WeaponName,
		// Token: 0x0402E356 RID: 189270
		BtnCall,
		// Token: 0x0402E357 RID: 189271
		BtnJump,
		// Token: 0x0402E358 RID: 189272
		PanelNotObtained,
		// Token: 0x0402E359 RID: 189273
		TxtNotObtained,
		// Token: 0x0402E35A RID: 189274
		BtnMoonCard,
		// Token: 0x0402E35B RID: 189275
		PanelStateGreen
	}
}

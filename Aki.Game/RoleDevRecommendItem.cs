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

// Token: 0x02001DB4 RID: 7604
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevRecommendItem : GridProxyAbstract<RoleDevWeaponSubRecommendItemDataBase>
{
	// Token: 0x06012DA8 RID: 77224 RVA: 0x00587FA4 File Offset: 0x005861A4
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

	// Token: 0x06012DA9 RID: 77225 RVA: 0x00588090 File Offset: 0x00586290
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevRecommendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevRecommendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DAA RID: 77226 RVA: 0x005880D4 File Offset: 0x005862D4
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		RoleDevWeaponSubRecommendItemDataBase data = this.Data;
		int? num = (data != null) ? new int?(data.WeaponId) : null;
		if (num != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null, false);
		}
	}

	// Token: 0x06012DAB RID: 77227 RVA: 0x0058811E File Offset: 0x0058631E
	protected override void OnStart()
	{
		this.InitUiVisibility();
		this.InitButton();
	}

	// Token: 0x06012DAC RID: 77228 RVA: 0x0058812C File Offset: 0x0058632C
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

	// Token: 0x06012DAD RID: 77229 RVA: 0x00588154 File Offset: 0x00586354
	private void InitButton()
	{
		this.ButtonJump.SetFunction(new Action<int>(this.OnClickJump));
		this.ButtonJump.SetLocalTextNew("RoleProject_Tips02", Array.Empty<object>());
		this.ButtonMoonCard.SetFunction(new Action<int>(this.OnClickMoonCard));
		this.ButtonMoonCard.SetLocalTextNew("RoleProject_Button04", Array.Empty<object>());
		this.ButtonMoonCard.SetRedDotVisible(false);
	}

	// Token: 0x06012DAE RID: 77230 RVA: 0x005881C5 File Offset: 0x005863C5
	public override void Refresh(RoleDevWeaponSubRecommendItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.ItemIndexInternal = gridIndex;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.WeaponName, Array.Empty<object>());
		this.RefreshPanel(data);
	}

	// Token: 0x17001C9F RID: 7327
	// (get) Token: 0x06012DAF RID: 77231 RVA: 0x005881F8 File Offset: 0x005863F8
	public int ItemIndex
	{
		get
		{
			return this.ItemIndexInternal;
		}
	}

	// Token: 0x06012DB0 RID: 77232 RVA: 0x00588200 File Offset: 0x00586400
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

	// Token: 0x06012DB1 RID: 77233 RVA: 0x00588264 File Offset: 0x00586464
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

	// Token: 0x06012DB2 RID: 77234 RVA: 0x005882C0 File Offset: 0x005864C0
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

	// Token: 0x06012DB3 RID: 77235 RVA: 0x00588340 File Offset: 0x00586540
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

	// Token: 0x06012DB4 RID: 77236 RVA: 0x00588482 File Offset: 0x00586682
	private void OnClickCall()
	{
		RoleDevWeaponSubRecommendItemDataBase data = this.Data;
		if (data != null && data.GachaId > 0)
		{
			this.JumpToGachaInterface();
		}
	}

	// Token: 0x06012DB5 RID: 77237 RVA: 0x005884A4 File Offset: 0x005866A4
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

	// Token: 0x06012DB6 RID: 77238 RVA: 0x00588518 File Offset: 0x00586718
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

	// Token: 0x06012DB7 RID: 77239 RVA: 0x005886BC File Offset: 0x005868BC
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

	// Token: 0x06012DB8 RID: 77240 RVA: 0x00588830 File Offset: 0x00586A30
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

	// Token: 0x06012DB9 RID: 77241 RVA: 0x0058889C File Offset: 0x00586A9C
	private void JumpToConfiguredPath(int jumpPath)
	{
		this.RunByConfigId(jumpPath, null);
	}

	// Token: 0x06012DBA RID: 77242 RVA: 0x005888A6 File Offset: 0x00586AA6
	[NullableContext(2)]
	private void RunByConfigId(int id, object @params = null)
	{
		SkipTaskManager.RunByConfigId(id, @params);
	}

	// Token: 0x06012DBB RID: 77243 RVA: 0x005888AF File Offset: 0x00586AAF
	private void JumpToGachaInterface()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x0400A28E RID: 41614
	[Nullable(2)]
	private ButtonItem ButtonJump;

	// Token: 0x0400A28F RID: 41615
	[Nullable(2)]
	private ButtonItem ButtonMoonCard;

	// Token: 0x0400A290 RID: 41616
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A291 RID: 41617
	[Nullable(2)]
	private RoleDevWeaponSubRecommendItemDataBase Data;

	// Token: 0x0400A292 RID: 41618
	private int ItemIndexInternal;

	// Token: 0x020080C1 RID: 32961
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A4E RID: 170574
		WeaponItem,
		// Token: 0x04029A4F RID: 170575
		WeaponName,
		// Token: 0x04029A50 RID: 170576
		BtnCall,
		// Token: 0x04029A51 RID: 170577
		BtnJump,
		// Token: 0x04029A52 RID: 170578
		PanelNotObtained,
		// Token: 0x04029A53 RID: 170579
		TxtNotObtained,
		// Token: 0x04029A54 RID: 170580
		BtnMoonCard,
		// Token: 0x04029A55 RID: 170581
		PanelStateGreen
	}
}

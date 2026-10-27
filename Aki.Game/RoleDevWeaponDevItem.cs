using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200283A RID: 10298
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevWeaponDevItem : GridProxyAbstract<RoleDevWeaponDevItemDataBase>
{
	// Token: 0x060153BF RID: 86975 RVA: 0x0055DB80 File Offset: 0x0055BD80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickSwitch)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickCall))
		};
	}

	// Token: 0x060153C0 RID: 86976 RVA: 0x0055DCF8 File Offset: 0x0055BEF8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevWeaponDevItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevWeaponDevItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060153C1 RID: 86977 RVA: 0x0055DD3C File Offset: 0x0055BF3C
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		if (this.Data == null)
		{
			return;
		}
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(this.RoleId.Value);
		int valueOrDefault = ((weaponInstanceByRoleId != null) ? weaponInstanceByRoleId.GetIncId() : null).GetValueOrDefault();
		RoleDevWeaponDevItemDataBase data = this.Data;
		int? num = (data != null) ? new int?(data.WeaponConfigId) : null;
		if (valueOrDefault > 0)
		{
			ItemController.Instance.OpenItemTipsByItemUid(valueOrDefault, num.Value, true, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(num.GetValueOrDefault(), true, null);
	}

	// Token: 0x060153C2 RID: 86978 RVA: 0x0055DDD0 File Offset: 0x0055BFD0
	public override void Refresh(RoleDevWeaponDevItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x060153C3 RID: 86979 RVA: 0x0055DDD9 File Offset: 0x0055BFD9
	public void Refresh(RoleDevWeaponDevItemDataBase data)
	{
		this.Data = data;
		this.RoleId = new int?(data.RoleId);
		this.RefreshItemGrid(data);
		this.RefreshWeaponViewItem(data);
	}

	// Token: 0x060153C4 RID: 86980 RVA: 0x0055DE04 File Offset: 0x0055C004
	public void RefreshItemGrid(RoleDevWeaponDevItemDataBase data)
	{
		int weaponConfigId = data.WeaponConfigId;
		SmallItemGrid itemGrid = this.ItemGrid;
		if (itemGrid != null)
		{
			itemGrid.SetExtendToggleEnable(weaponConfigId > 0, false);
		}
		SmallItemGrid itemGrid2 = this.ItemGrid;
		if (itemGrid2 != null)
		{
			itemGrid2.SetToggleInteractive(weaponConfigId > 0);
		}
		if (weaponConfigId > 0)
		{
			SmallItemGrid itemGrid3 = this.ItemGrid;
			if (itemGrid3 == null)
			{
				return;
			}
			itemGrid3.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}
	}

	// Token: 0x060153C5 RID: 86981 RVA: 0x0055DE63 File Offset: 0x0055C063
	public void RefreshWeaponViewItem(RoleDevWeaponDevItemDataBase data)
	{
		this.RefreshWeaponDisplay(data);
		this.RefreshGoalLevelText(data);
		this.DetailVerticalLayout.RefreshByData(data.DetailItems, null, false);
	}

	// Token: 0x060153C6 RID: 86982 RVA: 0x0055DE88 File Offset: 0x0055C088
	private void RefreshWeaponDisplay(RoleDevWeaponDevItemDataBase data)
	{
		switch (data.RoleType)
		{
		case ERoleDevDataType.Obtained:
			this.RefreshObtainedWeapon(data);
			return;
		case ERoleDevDataType.NotObtained:
			this.RefreshNotObtainedWeapon(data);
			return;
		case ERoleDevDataType.Forecast:
			this.RefreshForecastWeapon(data);
			return;
		default:
			return;
		}
	}

	// Token: 0x060153C7 RID: 86983 RVA: 0x0055DEC8 File Offset: 0x0055C0C8
	private void RefreshNotObtainedWeapon(RoleDevWeaponDevItemDataBase data)
	{
		base.GetItem(12).SetUIActive(false);
		RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(data.RoleId);
		if (roleDevProjectConfig == null)
		{
			return;
		}
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(roleDevProjectConfig.Value.WeaponType);
		if (roleDevWeaponItemConfig == null)
		{
			return;
		}
		this.SetWeaponIconAndName(roleDevWeaponItemConfig.Value.WeaponTypeIcon, roleDevWeaponItemConfig.Value.WeaponTypeDescribe);
		this.SetNotObtainedButtonStates(data);
	}

	// Token: 0x060153C8 RID: 86984 RVA: 0x0055DF50 File Offset: 0x0055C150
	private void RefreshObtainedWeapon(RoleDevWeaponDevItemDataBase data)
	{
		base.GetItem(12).SetUIActive(true);
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(data.WeaponConfigId);
		if (weaponConfigByItemId == null)
		{
			return;
		}
		this.ApplyWeaponItemGrid(weaponConfigByItemId.Value, data);
		this.SetWeaponName(data.WeaponName);
		this.SetObtainedButtonStates(data);
	}

	// Token: 0x060153C9 RID: 86985 RVA: 0x0055DFA8 File Offset: 0x0055C1A8
	private void RefreshForecastWeapon(RoleDevWeaponDevItemDataBase data)
	{
		base.GetItem(12).SetUIActive(false);
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(data.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return;
		}
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(roleDevProsProjectConfig.WeaponType);
		if (roleDevWeaponItemConfig == null)
		{
			return;
		}
		this.SetWeaponIconAndName(roleDevWeaponItemConfig.Value.WeaponTypeIcon, roleDevWeaponItemConfig.Value.WeaponTypeDescribe);
		this.SetNotObtainedButtonStates(data);
	}

	// Token: 0x060153CA RID: 86986 RVA: 0x0055E020 File Offset: 0x0055C220
	private void SetWeaponIconAndName(string iconPath, string weaponName)
	{
		this.ItemGrid.SetIconByPath(iconPath);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), weaponName, Array.Empty<object>());
		this.ItemGrid.SetBottomTextVisible(false);
		this.ItemGrid.SetQuality(null);
	}

	// Token: 0x060153CB RID: 86987 RVA: 0x0055E070 File Offset: 0x0055C270
	private void SetNotObtainedButtonStates(RoleDevWeaponDevItemDataBase data)
	{
		bool flag = data.RoleType == ERoleDevDataType.Forecast;
		base.GetButton(11).RootUIComp.Get().SetUIActive(false);
		base.GetItem(0).SetUIActive(!flag);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x060153CC RID: 86988 RVA: 0x0055E0CC File Offset: 0x0055C2CC
	private void ApplyWeaponItemGrid(WeaponConf weaponConfig, RoleDevWeaponDevItemDataBase data)
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			ItemConfigId = new int?(weaponConfig.ItemId),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				data.WeaponLevel
			},
			Data = data
		};
		this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x060153CD RID: 86989 RVA: 0x0055E12B File Offset: 0x0055C32B
	private void SetWeaponName(string weaponName)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), weaponName, Array.Empty<object>());
	}

	// Token: 0x060153CE RID: 86990 RVA: 0x0055E144 File Offset: 0x0055C344
	private void SetObtainedButtonStates(RoleDevWeaponDevItemDataBase data)
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(data.IsCall);
		this.RefreshButtonTexts(data);
		bool isHighQuality = data.IsHighQuality;
		base.GetItem(0).SetUIActive(isHighQuality);
	}

	// Token: 0x060153CF RID: 86991 RVA: 0x0055E18C File Offset: 0x0055C38C
	private void RefreshGoalLevelText(RoleDevWeaponDevItemDataBase data)
	{
		UUIText text = base.GetText(6);
		if (data.WeaponLevel == data.WeaponGoalUpgradeLevel && !data.WeaponIsMaxLevel)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_Tips04", Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_TargetLevel", new object[]
			{
				data.WeaponGoalUpgradeLevel
			});
		}
		text.SetUIActive(!data.WeaponIsMaxLevel);
	}

	// Token: 0x060153D0 RID: 86992 RVA: 0x0055E204 File Offset: 0x0055C404
	private void RefreshButtonTexts(RoleDevWeaponDevItemDataBase data)
	{
		bool flag = (data.WeaponLevel == data.WeaponGoalUpgradeLevel && !data.WeaponIsMaxLevel) || data.WeaponIsMaxLevel;
		string textId = flag ? "RoleProject_Button02" : "RoleProject_Button01";
		ButtonItem normalButtonItem = this.NormalButtonItem;
		if (normalButtonItem != null)
		{
			normalButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
		}
		ButtonItem highLightButtonItem = this.HighLightButtonItem;
		if (highLightButtonItem != null)
		{
			highLightButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
		}
		if (flag)
		{
			ButtonItem normalButtonItem2 = this.NormalButtonItem;
			if (normalButtonItem2 != null)
			{
				normalButtonItem2.SetUiActive(true);
			}
			ButtonItem highLightButtonItem2 = this.HighLightButtonItem;
			if (highLightButtonItem2 != null)
			{
				highLightButtonItem2.SetUiActive(false);
			}
		}
		else
		{
			ButtonItem normalButtonItem3 = this.NormalButtonItem;
			if (normalButtonItem3 != null)
			{
				normalButtonItem3.SetUiActive(!data.IsAllMaterialEnough);
			}
			ButtonItem highLightButtonItem3 = this.HighLightButtonItem;
			if (highLightButtonItem3 != null)
			{
				highLightButtonItem3.SetUiActive(data.IsAllMaterialEnough);
			}
		}
		ButtonItem normalButtonItem4 = this.NormalButtonItem;
		if (normalButtonItem4 != null)
		{
			normalButtonItem4.SetFunction(new Action<int>(this.OnClickDevJump));
		}
		ButtonItem highLightButtonItem4 = this.HighLightButtonItem;
		if (highLightButtonItem4 == null)
		{
			return;
		}
		highLightButtonItem4.SetFunction(new Action<int>(this.OnClickDevJump));
	}

	// Token: 0x060153D1 RID: 86993 RVA: 0x0055E300 File Offset: 0x0055C500
	private RoleDevDetailItem CreateDetailItem()
	{
		return new RoleDevDetailItem();
	}

	// Token: 0x060153D2 RID: 86994 RVA: 0x0055E308 File Offset: 0x0055C508
	private void OpenWeaponRootView()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(this.RoleId.Value);
		if (weaponInstanceByRoleId == null)
		{
			return;
		}
		int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(weaponInstanceByRoleId.GetRoleId());
		WeaponRootViewParam param = new WeaponRootViewParam
		{
			WeaponIncId = weaponInstanceByRoleId.GetIncId().Value,
			WeaponSkinId = skinIdByRoleId,
			IsFromRoleRootView = false
		};
		UiManager.Instance.OpenView(EUiViewName.WeaponRootView, param, null);
	}

	// Token: 0x060153D3 RID: 86995 RVA: 0x0055E379 File Offset: 0x0055C579
	private void OnClickSwitch()
	{
		Action onClickBtnSwitch = this.OnClickBtnSwitch;
		if (onClickBtnSwitch == null)
		{
			return;
		}
		onClickBtnSwitch();
	}

	// Token: 0x060153D4 RID: 86996 RVA: 0x0055E38C File Offset: 0x0055C58C
	private void OnClickDevJump(int _)
	{
		bool flag = (this.Data.WeaponLevel == this.Data.WeaponGoalUpgradeLevel && !this.Data.WeaponIsMaxLevel) || this.Data.WeaponIsMaxLevel;
		RoleDevController.Instance.LogRoleDevSubPageClick(this.RoleId.Value, ERoleDevMainPage.Weapon, flag ? ERoleDevSubPageButton.WeaponGoToView : ERoleDevSubPageButton.WeaponGoToCultivation);
		this.OpenWeaponRootView();
	}

	// Token: 0x060153D5 RID: 86997 RVA: 0x0055E3F2 File Offset: 0x0055C5F2
	private void OnClickCall()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x04009EAA RID: 40618
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x04009EAB RID: 40619
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> DetailVerticalLayout;

	// Token: 0x04009EAC RID: 40620
	private int? RoleId;

	// Token: 0x04009EAD RID: 40621
	[Nullable(2)]
	private RoleDevWeaponDevItemDataBase Data;

	// Token: 0x04009EAE RID: 40622
	[Nullable(2)]
	private ButtonItem NormalButtonItem;

	// Token: 0x04009EAF RID: 40623
	[Nullable(2)]
	private ButtonItem HighLightButtonItem;

	// Token: 0x04009EB0 RID: 40624
	[Nullable(2)]
	public Action OnClickBtnSwitch;

	// Token: 0x02008E7D RID: 36477
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E361 RID: 189281
		PanelSwitch,
		// Token: 0x0402E362 RID: 189282
		BtnSwitch,
		// Token: 0x0402E363 RID: 189283
		PanelWeaponType,
		// Token: 0x0402E364 RID: 189284
		IconWeaponType,
		// Token: 0x0402E365 RID: 189285
		WeaponItem,
		// Token: 0x0402E366 RID: 189286
		TxtWeaponName,
		// Token: 0x0402E367 RID: 189287
		TxtGoalLevel,
		// Token: 0x0402E368 RID: 189288
		BtnJump,
		// Token: 0x0402E369 RID: 189289
		BtnPerfectJump,
		// Token: 0x0402E36A RID: 189290
		PanelDetailLayout,
		// Token: 0x0402E36B RID: 189291
		PanelDetailItem,
		// Token: 0x0402E36C RID: 189292
		BtnCall,
		// Token: 0x0402E36D RID: 189293
		RightItem
	}
}

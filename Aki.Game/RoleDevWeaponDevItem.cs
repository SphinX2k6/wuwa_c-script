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

// Token: 0x02001DB5 RID: 7605
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevWeaponDevItem : GridProxyAbstract<RoleDevWeaponDevItemDataBase>
{
	// Token: 0x06012DBD RID: 77245 RVA: 0x005888DC File Offset: 0x00586ADC
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

	// Token: 0x06012DBE RID: 77246 RVA: 0x00588A54 File Offset: 0x00586C54
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevWeaponDevItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevWeaponDevItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DBF RID: 77247 RVA: 0x00588A98 File Offset: 0x00586C98
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
		ItemController.Instance.OpenItemTipsByItemId(num.GetValueOrDefault(), true, null, false);
	}

	// Token: 0x06012DC0 RID: 77248 RVA: 0x00588B2D File Offset: 0x00586D2D
	public override void Refresh(RoleDevWeaponDevItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06012DC1 RID: 77249 RVA: 0x00588B36 File Offset: 0x00586D36
	public void Refresh(RoleDevWeaponDevItemDataBase data)
	{
		this.Data = data;
		this.RoleId = new int?(data.RoleId);
		this.RefreshItemGrid(data);
		this.RefreshWeaponViewItem(data);
	}

	// Token: 0x06012DC2 RID: 77250 RVA: 0x00588B60 File Offset: 0x00586D60
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

	// Token: 0x06012DC3 RID: 77251 RVA: 0x00588BBF File Offset: 0x00586DBF
	public void RefreshWeaponViewItem(RoleDevWeaponDevItemDataBase data)
	{
		this.RefreshWeaponDisplay(data);
		this.RefreshGoalLevelText(data);
		this.DetailVerticalLayout.RefreshByData(data.DetailItems, null, false);
	}

	// Token: 0x06012DC4 RID: 77252 RVA: 0x00588BE4 File Offset: 0x00586DE4
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

	// Token: 0x06012DC5 RID: 77253 RVA: 0x00588C24 File Offset: 0x00586E24
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

	// Token: 0x06012DC6 RID: 77254 RVA: 0x00588CAC File Offset: 0x00586EAC
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

	// Token: 0x06012DC7 RID: 77255 RVA: 0x00588D04 File Offset: 0x00586F04
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

	// Token: 0x06012DC8 RID: 77256 RVA: 0x00588D7C File Offset: 0x00586F7C
	private void SetWeaponIconAndName(string iconPath, string weaponName)
	{
		this.ItemGrid.SetIconByPath(iconPath);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), weaponName, Array.Empty<object>());
		this.ItemGrid.SetBottomTextVisible(false);
		this.ItemGrid.SetQuality(null);
	}

	// Token: 0x06012DC9 RID: 77257 RVA: 0x00588DCC File Offset: 0x00586FCC
	private void SetNotObtainedButtonStates(RoleDevWeaponDevItemDataBase data)
	{
		bool flag = data.RoleType == ERoleDevDataType.Forecast;
		base.GetButton(11).RootUIComp.Get().SetUIActive(false);
		base.GetItem(0).SetUIActive(!flag);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06012DCA RID: 77258 RVA: 0x00588E28 File Offset: 0x00587028
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

	// Token: 0x06012DCB RID: 77259 RVA: 0x00588E87 File Offset: 0x00587087
	private void SetWeaponName(string weaponName)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), weaponName, Array.Empty<object>());
	}

	// Token: 0x06012DCC RID: 77260 RVA: 0x00588EA0 File Offset: 0x005870A0
	private void SetObtainedButtonStates(RoleDevWeaponDevItemDataBase data)
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(data.IsCall);
		this.RefreshButtonTexts(data);
		bool isHighQuality = data.IsHighQuality;
		base.GetItem(0).SetUIActive(isHighQuality);
	}

	// Token: 0x06012DCD RID: 77261 RVA: 0x00588EE8 File Offset: 0x005870E8
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

	// Token: 0x06012DCE RID: 77262 RVA: 0x00588F60 File Offset: 0x00587160
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

	// Token: 0x06012DCF RID: 77263 RVA: 0x0058905C File Offset: 0x0058725C
	private RoleDevDetailItem CreateDetailItem()
	{
		return new RoleDevDetailItem();
	}

	// Token: 0x06012DD0 RID: 77264 RVA: 0x00589064 File Offset: 0x00587264
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

	// Token: 0x06012DD1 RID: 77265 RVA: 0x005890D5 File Offset: 0x005872D5
	private void OnClickSwitch()
	{
		Action onClickBtnSwitch = this.OnClickBtnSwitch;
		if (onClickBtnSwitch == null)
		{
			return;
		}
		onClickBtnSwitch();
	}

	// Token: 0x06012DD2 RID: 77266 RVA: 0x005890E8 File Offset: 0x005872E8
	private void OnClickDevJump(int _)
	{
		bool flag = (this.Data.WeaponLevel == this.Data.WeaponGoalUpgradeLevel && !this.Data.WeaponIsMaxLevel) || this.Data.WeaponIsMaxLevel;
		RoleDevController.Instance.LogRoleDevSubPageClick(this.RoleId.Value, ERoleDevMainPage.Weapon, flag ? ERoleDevSubPageButton.WeaponGoToView : ERoleDevSubPageButton.WeaponGoToCultivation);
		this.OpenWeaponRootView();
	}

	// Token: 0x06012DD3 RID: 77267 RVA: 0x0058914E File Offset: 0x0058734E
	private void OnClickCall()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x0400A293 RID: 41619
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A294 RID: 41620
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> DetailVerticalLayout;

	// Token: 0x0400A295 RID: 41621
	private int? RoleId;

	// Token: 0x0400A296 RID: 41622
	[Nullable(2)]
	private RoleDevWeaponDevItemDataBase Data;

	// Token: 0x0400A297 RID: 41623
	[Nullable(2)]
	private ButtonItem NormalButtonItem;

	// Token: 0x0400A298 RID: 41624
	[Nullable(2)]
	private ButtonItem HighLightButtonItem;

	// Token: 0x0400A299 RID: 41625
	[Nullable(2)]
	public Action OnClickBtnSwitch;

	// Token: 0x020080C3 RID: 32963
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A5B RID: 170587
		PanelSwitch,
		// Token: 0x04029A5C RID: 170588
		BtnSwitch,
		// Token: 0x04029A5D RID: 170589
		PanelWeaponType,
		// Token: 0x04029A5E RID: 170590
		IconWeaponType,
		// Token: 0x04029A5F RID: 170591
		WeaponItem,
		// Token: 0x04029A60 RID: 170592
		TxtWeaponName,
		// Token: 0x04029A61 RID: 170593
		TxtGoalLevel,
		// Token: 0x04029A62 RID: 170594
		BtnJump,
		// Token: 0x04029A63 RID: 170595
		BtnPerfectJump,
		// Token: 0x04029A64 RID: 170596
		PanelDetailLayout,
		// Token: 0x04029A65 RID: 170597
		PanelDetailItem,
		// Token: 0x04029A66 RID: 170598
		BtnCall,
		// Token: 0x04029A67 RID: 170599
		RightItem
	}
}

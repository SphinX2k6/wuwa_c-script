using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200283B RID: 10299
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevWeaponRecommendItem : GridProxyAbstract<RoleDevWeaponRecommendItemDataBase>
{
	// Token: 0x060153D7 RID: 86999 RVA: 0x0055E41C File Offset: 0x0055C61C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickSwitch)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickCall))
		};
	}

	// Token: 0x060153D8 RID: 87000 RVA: 0x0055E594 File Offset: 0x0055C794
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevWeaponRecommendItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevWeaponRecommendItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060153D9 RID: 87001 RVA: 0x0055E5D8 File Offset: 0x0055C7D8
	private void OnClickedGrid(MediumItemGridExtendCallback _)
	{
		if (this.Data == null)
		{
			return;
		}
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(this.Data.RoleId);
		int valueOrDefault = ((weaponInstanceByRoleId != null) ? weaponInstanceByRoleId.GetIncId() : null).GetValueOrDefault();
		RoleDevWeaponRecommendItemDataBase data = this.Data;
		int? num = (data != null) ? new int?(data.WeaponConfigId) : null;
		if (valueOrDefault > 0)
		{
			ItemController.Instance.OpenItemTipsByItemUid(valueOrDefault, num.Value, true, null);
			return;
		}
		int? num2 = num;
		int num3 = 0;
		if (num2.GetValueOrDefault() > num3 & num2 != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null);
		}
	}

	// Token: 0x060153DA RID: 87002 RVA: 0x0055E684 File Offset: 0x0055C884
	public override void Refresh(RoleDevWeaponRecommendItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x060153DB RID: 87003 RVA: 0x0055E68D File Offset: 0x0055C88D
	public void Refresh(RoleDevWeaponRecommendItemDataBase data)
	{
		this.Data = data;
		this.RefreshSwitchBtnState(data);
		this.RefreshWeaponViewItem(data);
		this.DetailVerticalLayout.RefreshByData(data.SubRecommendItems, null, false);
	}

	// Token: 0x060153DC RID: 87004 RVA: 0x0055E6B8 File Offset: 0x0055C8B8
	private void RefreshSwitchBtnState(RoleDevWeaponRecommendItemDataBase data)
	{
		bool uiactive = !data.IsRoleObtained || data.IsWeaponHighQuality;
		base.GetItem(11).SetUIActive(uiactive);
	}

	// Token: 0x060153DD RID: 87005 RVA: 0x0055E6E8 File Offset: 0x0055C8E8
	public void RefreshWeaponViewItem(RoleDevWeaponRecommendItemDataBase data)
	{
		if (!data.IsRoleObtained)
		{
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
			this.ItemGrid.SetIconByPath(roleDevWeaponItemConfig.Value.WeaponTypeIcon);
			this.ItemGrid.SetBottomTextVisible(false);
			this.ItemGrid.SetQuality(null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleDevWeaponItemConfig.Value.WeaponTypeDescribe, Array.Empty<object>());
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			base.GetItem(6).SetUIActive(false);
			base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.WeaponName, Array.Empty<object>());
			if (data.IsWeaponHighQuality)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_Tips01", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_Tips08", Array.Empty<object>());
			}
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(data.WeaponConfigId);
			if (weaponConfigByItemId == null)
			{
				return;
			}
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				ItemConfigId = new int?(weaponConfigByItemId.Value.ItemId),
				BottomTextId = "Text_LevelShow_Text",
				BottomTextParameter = new object[]
				{
					data.WeaponLevel
				},
				Data = data
			};
			this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
			base.GetItem(6).SetUIActive(true);
			base.GetButton(12).RootUIComp.Get().SetUIActive(data.IsCall);
		}
		this.BtnJumpItem.SetUiActive(true);
		this.BtnPerfectJumpItem.SetUiActive(false);
	}

	// Token: 0x060153DE RID: 87006 RVA: 0x0055E901 File Offset: 0x0055CB01
	public void SetSwitchBtnVisible(bool visible)
	{
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x060153DF RID: 87007 RVA: 0x0055E916 File Offset: 0x0055CB16
	private RoleDevRecommendItem CreateDetailItem()
	{
		return new RoleDevRecommendItem();
	}

	// Token: 0x060153E0 RID: 87008 RVA: 0x0055E91D File Offset: 0x0055CB1D
	private void OnClickSwitch()
	{
		Action onClickBtnSwitch = this.OnClickBtnSwitch;
		if (onClickBtnSwitch == null)
		{
			return;
		}
		onClickBtnSwitch();
	}

	// Token: 0x060153E1 RID: 87009 RVA: 0x0055E930 File Offset: 0x0055CB30
	private void OnClickJump(int _)
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(this.Data.RoleId);
		if (weaponInstanceByRoleId == null)
		{
			return;
		}
		int value = weaponInstanceByRoleId.GetIncId().Value;
		RoleDevUtils.OpenWeaponReplaceView(this.Data.RoleId, value);
		RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Weapon, ERoleDevSubPageButton.GoToReplace);
	}

	// Token: 0x060153E2 RID: 87010 RVA: 0x0055E98E File Offset: 0x0055CB8E
	private void OnClickCall()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x04009EB1 RID: 40625
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x04009EB2 RID: 40626
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevRecommendItem, RoleDevWeaponSubRecommendItemDataBase> DetailVerticalLayout;

	// Token: 0x04009EB3 RID: 40627
	[Nullable(2)]
	private ButtonItem BtnJumpItem;

	// Token: 0x04009EB4 RID: 40628
	[Nullable(2)]
	private ButtonItem BtnPerfectJumpItem;

	// Token: 0x04009EB5 RID: 40629
	[Nullable(2)]
	public Action OnClickBtnSwitch;

	// Token: 0x04009EB6 RID: 40630
	[Nullable(2)]
	private RoleDevWeaponRecommendItemDataBase Data;

	// Token: 0x02008E7F RID: 36479
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E373 RID: 189299
		BtnSwitch,
		// Token: 0x0402E374 RID: 189300
		PanelWeaponType,
		// Token: 0x0402E375 RID: 189301
		IconWeaponType,
		// Token: 0x0402E376 RID: 189302
		WeaponItem,
		// Token: 0x0402E377 RID: 189303
		TxtWeaponName,
		// Token: 0x0402E378 RID: 189304
		TxtGoalLevel,
		// Token: 0x0402E379 RID: 189305
		PanelRight,
		// Token: 0x0402E37A RID: 189306
		BtnJump,
		// Token: 0x0402E37B RID: 189307
		BtnPerfectJump,
		// Token: 0x0402E37C RID: 189308
		PanelSubLayout,
		// Token: 0x0402E37D RID: 189309
		PanelSubItem,
		// Token: 0x0402E37E RID: 189310
		PanelRecommendSwitch,
		// Token: 0x0402E37F RID: 189311
		BtnCall
	}
}

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

// Token: 0x02001DB6 RID: 7606
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevWeaponRecommendItem : GridProxyAbstract<RoleDevWeaponRecommendItemDataBase>
{
	// Token: 0x06012DD5 RID: 77269 RVA: 0x00589178 File Offset: 0x00587378
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

	// Token: 0x06012DD6 RID: 77270 RVA: 0x005892F0 File Offset: 0x005874F0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevWeaponRecommendItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevWeaponRecommendItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DD7 RID: 77271 RVA: 0x00589334 File Offset: 0x00587534
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
			ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null, false);
		}
	}

	// Token: 0x06012DD8 RID: 77272 RVA: 0x005893E1 File Offset: 0x005875E1
	public override void Refresh(RoleDevWeaponRecommendItemDataBase data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06012DD9 RID: 77273 RVA: 0x005893EA File Offset: 0x005875EA
	public void Refresh(RoleDevWeaponRecommendItemDataBase data)
	{
		this.Data = data;
		this.RefreshSwitchBtnState(data);
		this.RefreshWeaponViewItem(data);
		this.DetailVerticalLayout.RefreshByData(data.SubRecommendItems, null, false);
	}

	// Token: 0x06012DDA RID: 77274 RVA: 0x00589414 File Offset: 0x00587614
	private void RefreshSwitchBtnState(RoleDevWeaponRecommendItemDataBase data)
	{
		bool uiactive = !data.IsRoleObtained || data.IsWeaponHighQuality;
		base.GetItem(11).SetUIActive(uiactive);
	}

	// Token: 0x06012DDB RID: 77275 RVA: 0x00589444 File Offset: 0x00587644
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

	// Token: 0x06012DDC RID: 77276 RVA: 0x0058965D File Offset: 0x0058785D
	public void SetSwitchBtnVisible(bool visible)
	{
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06012DDD RID: 77277 RVA: 0x00589672 File Offset: 0x00587872
	private RoleDevRecommendItem CreateDetailItem()
	{
		return new RoleDevRecommendItem();
	}

	// Token: 0x06012DDE RID: 77278 RVA: 0x00589679 File Offset: 0x00587879
	private void OnClickSwitch()
	{
		Action onClickBtnSwitch = this.OnClickBtnSwitch;
		if (onClickBtnSwitch == null)
		{
			return;
		}
		onClickBtnSwitch();
	}

	// Token: 0x06012DDF RID: 77279 RVA: 0x0058968C File Offset: 0x0058788C
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

	// Token: 0x06012DE0 RID: 77280 RVA: 0x005896EA File Offset: 0x005878EA
	private void OnClickCall()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x0400A29A RID: 41626
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A29B RID: 41627
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevRecommendItem, RoleDevWeaponSubRecommendItemDataBase> DetailVerticalLayout;

	// Token: 0x0400A29C RID: 41628
	[Nullable(2)]
	private ButtonItem BtnJumpItem;

	// Token: 0x0400A29D RID: 41629
	[Nullable(2)]
	private ButtonItem BtnPerfectJumpItem;

	// Token: 0x0400A29E RID: 41630
	[Nullable(2)]
	public Action OnClickBtnSwitch;

	// Token: 0x0400A29F RID: 41631
	[Nullable(2)]
	private RoleDevWeaponRecommendItemDataBase Data;

	// Token: 0x020080C5 RID: 32965
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A6D RID: 170605
		BtnSwitch,
		// Token: 0x04029A6E RID: 170606
		PanelWeaponType,
		// Token: 0x04029A6F RID: 170607
		IconWeaponType,
		// Token: 0x04029A70 RID: 170608
		WeaponItem,
		// Token: 0x04029A71 RID: 170609
		TxtWeaponName,
		// Token: 0x04029A72 RID: 170610
		TxtGoalLevel,
		// Token: 0x04029A73 RID: 170611
		PanelRight,
		// Token: 0x04029A74 RID: 170612
		BtnJump,
		// Token: 0x04029A75 RID: 170613
		BtnPerfectJump,
		// Token: 0x04029A76 RID: 170614
		PanelSubLayout,
		// Token: 0x04029A77 RID: 170615
		PanelSubItem,
		// Token: 0x04029A78 RID: 170616
		PanelRecommendSwitch,
		// Token: 0x04029A79 RID: 170617
		BtnCall
	}
}

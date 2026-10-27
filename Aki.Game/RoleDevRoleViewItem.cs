using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200281B RID: 10267
[NullableContext(1)]
[Nullable(0)]
public class RoleDevRoleViewItem : UiPanelBase
{
	// Token: 0x060151A1 RID: 86433 RVA: 0x005572B0 File Offset: 0x005554B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickCallJumpButton))
		};
	}

	// Token: 0x060151A2 RID: 86434 RVA: 0x005573E0 File Offset: 0x005555E0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevRoleViewItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevRoleViewItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060151A3 RID: 86435 RVA: 0x00557423 File Offset: 0x00555623
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x060151A4 RID: 86436 RVA: 0x0055743D File Offset: 0x0055563D
	public void Refresh(RoleDevRoleViewItemDataBase data)
	{
		this.Data = data;
		this.RefreshRoleItemGrid(data);
		this.RefreshName(data);
		this.RefreshCallButton(data);
		this.RefreshGoalLevelAndPanel(data);
		this.RefreshDetailList(data);
	}

	// Token: 0x060151A5 RID: 86437 RVA: 0x0055746C File Offset: 0x0055566C
	private void RefreshRoleItemGrid(RoleDevRoleViewItemDataBase data)
	{
		if (RoleDevUtils.GetRoleTypeTagByRoleId(data.RoleId) == global::ERoleTypeTag.Forecast)
		{
			ForecastCharacterSmallItemGrid parameters = new ForecastCharacterSmallItemGrid
			{
				Data = data,
				RoleId = new int?(data.RoleId)
			};
			this.RoleItemGrid.Apply<ForecastCharacterSmallItemGrid>(parameters);
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data.RoleId);
		if (roleConfig == null)
		{
			return;
		}
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(data.RoleId);
		int value = (roleInstanceById != null) ? roleInstanceById.GetRoleSkinId() : 0;
		int roleLevel = data.RoleLevel;
		CharacterSmallItemGrid parameters2 = new CharacterSmallItemGrid
		{
			ItemConfigId = new int?(data.RoleId),
			SkinId = new int?(value),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				roleLevel
			},
			ElementId = new int?(roleConfig.Value.ElementId),
			Data = data
		};
		this.RoleItemGrid.Apply<CharacterSmallItemGrid>(parameters2);
	}

	// Token: 0x060151A6 RID: 86438 RVA: 0x00557570 File Offset: 0x00555770
	private void RefreshName(RoleDevRoleViewItemDataBase data)
	{
		base.GetText(1).SetText(data.RoleName, true);
	}

	// Token: 0x060151A7 RID: 86439 RVA: 0x00557588 File Offset: 0x00555788
	private void RefreshCallButton(RoleDevRoleViewItemDataBase data)
	{
		base.GetButton(6).RootUIComp.Get().SetUIActive(data.IsCall);
	}

	// Token: 0x060151A8 RID: 86440 RVA: 0x005575B4 File Offset: 0x005557B4
	private void RefreshGoalLevelAndPanel(RoleDevRoleViewItemDataBase data)
	{
		this.SetGoalLevelTextAndPanel(data);
	}

	// Token: 0x060151A9 RID: 86441 RVA: 0x005575BD File Offset: 0x005557BD
	private void RefreshDetailList(RoleDevRoleViewItemDataBase data)
	{
		this.DetailVerticalLayout.RefreshByData(data.DetailItems, null, false);
	}

	// Token: 0x060151AA RID: 86442 RVA: 0x005575D4 File Offset: 0x005557D4
	private void SetGoalLevelTextAndPanel(RoleDevRoleViewItemDataBase data)
	{
		base.GetItem(3).SetUIActive(true);
		if (RoleModel.Instance.GetRoleInstanceById(data.RoleId) == null)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoleProject_TargetLevel", new object[]
			{
				data.RoleGoalUpgradeLevel
			});
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "RoleProject_Tips07", Array.Empty<object>());
		}
		else if (data.RoleLevel == data.RoleGoalUpgradeLevel && !data.RoleLevelIsMax)
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoleProject_Tips04", Array.Empty<object>());
			this.UpdateButtonStateByConditionAndMaterialEnough(data);
			UUIItem item4 = base.GetItem(7);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
		}
		else if (data.RoleLevelIsMax)
		{
			base.GetText(2).SetUIActive(false);
			UUIItem item5 = base.GetItem(4);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(5);
			if (item6 != null)
			{
				item6.SetUIActive(false);
			}
			base.GetItem(7).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "RoleProject_Tips06", Array.Empty<object>());
		}
		else
		{
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoleProject_TargetLevel", new object[]
			{
				data.RoleGoalUpgradeLevel
			});
			this.UpdateButtonStateByConditionAndMaterialEnough(data);
			UUIItem item7 = base.GetItem(7);
			if (item7 != null)
			{
				item7.SetUIActive(false);
			}
		}
		if (data.IsForecast)
		{
			base.GetItem(3).SetUIActive(false);
			base.GetText(2).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoleProject_TargetLevel", new object[]
			{
				data.RoleGoalUpgradeLevel
			});
		}
	}

	// Token: 0x060151AB RID: 86443 RVA: 0x005577FC File Offset: 0x005559FC
	private void UpdateButtonStateByConditionAndMaterialEnough(RoleDevRoleViewItemDataBase data)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(data.RoleId);
		if (roleInstanceById == null)
		{
			return;
		}
		if (!roleInstanceById.GetLevelData().GetRoleNeedBreakUp())
		{
			this.UpdateButtonByMaterialEnough(data);
			return;
		}
		if (RoleModel.Instance.GetRoleBreachState(data.RoleId) != ERoleBreachState.NoEnoughCondition)
		{
			this.UpdateButtonByMaterialEnough(data);
			return;
		}
		base.GetItem(4).SetUIActive(true);
		base.GetItem(5).SetUIActive(false);
		ButtonItem normalButtonItem = this.NormalButtonItem;
		if (normalButtonItem == null)
		{
			return;
		}
		normalButtonItem.SetLocalTextNew("RoleProject_Button02", Array.Empty<object>());
	}

	// Token: 0x060151AC RID: 86444 RVA: 0x00557888 File Offset: 0x00555A88
	private void UpdateButtonByMaterialEnough(RoleDevRoleViewItemDataBase data)
	{
		if (data.IsAllMaterialEnough)
		{
			base.GetItem(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(true);
			ButtonItem highLightButtonItem = this.HighLightButtonItem;
			if (highLightButtonItem == null)
			{
				return;
			}
			highLightButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
			return;
		}
		else
		{
			base.GetItem(4).SetUIActive(true);
			base.GetItem(5).SetUIActive(false);
			ButtonItem normalButtonItem = this.NormalButtonItem;
			if (normalButtonItem == null)
			{
				return;
			}
			normalButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
			return;
		}
	}

	// Token: 0x060151AD RID: 86445 RVA: 0x00557906 File Offset: 0x00555B06
	private RoleDevDetailItem CreateDetailItem()
	{
		return new RoleDevDetailItem();
	}

	// Token: 0x060151AE RID: 86446 RVA: 0x00557910 File Offset: 0x00555B10
	private void InitRoleItemGrid()
	{
		this.RoleItemGrid = new SmallItemGrid();
		this.RoleItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.RoleItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		this.RoleItemGrid.SetExtendToggleEnable(false, false);
		this.RoleItemGrid.SetToggleInteractive(false);
	}

	// Token: 0x060151AF RID: 86447 RVA: 0x0055796F File Offset: 0x00555B6F
	private void InitDetailVerticalLayout()
	{
		this.DetailVerticalLayout = new GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData>(base.GetVerticalLayout(8), new Func<RoleDevDetailItem>(this.CreateDetailItem), null, false, true);
	}

	// Token: 0x060151B0 RID: 86448 RVA: 0x00557992 File Offset: 0x00555B92
	private void InitBtnJumpItem()
	{
		this.NormalButtonItem = new ButtonItem(base.GetItem(4));
		this.NormalButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
		this.NormalButtonItem.SetFunction(delegate(int _)
		{
			this.OnClickJumpButton();
		});
	}

	// Token: 0x060151B1 RID: 86449 RVA: 0x005579D2 File Offset: 0x00555BD2
	private void InitBtnPerfectJumpItem()
	{
		this.HighLightButtonItem = new ButtonItem(base.GetItem(5));
		this.HighLightButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
		this.HighLightButtonItem.SetFunction(delegate(int _)
		{
			this.OnClickJumpButton();
		});
	}

	// Token: 0x060151B2 RID: 86450 RVA: 0x00557A14 File Offset: 0x00555C14
	private void OnClickJumpButton()
	{
		int roleId = this.Data.RoleId;
		if (RoleModel.Instance.GetRoleInstanceById(roleId) == null)
		{
			return;
		}
		RoleDevController.Instance.LogRoleDevSubPageClick(roleId, ERoleDevMainPage.Role, ERoleDevSubPageButton.RoleGoToCultivation);
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(roleId, false, ERoleViewSource.Normal);
		roleViewViewModel.FadeInCurveId = ERoleFadeCurveDefine.RoleFadeInCurve;
		roleViewViewModel.FadeOutCurveId = ERoleFadeCurveDefine.RoleFadeOutCurve;
		roleViewViewModel.NeedShowOnViewPlayingStartSequence = true;
		roleViewViewModel.NeedHideOnViewPlayingCloseSequence = true;
		if (this.Data.IsCanUpgrade)
		{
			RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, roleViewViewModel);
			return;
		}
		if (this.Data.IsCanBreach)
		{
			RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleBreachView, roleViewViewModel);
		}
	}

	// Token: 0x060151B3 RID: 86451 RVA: 0x00557AB3 File Offset: 0x00555CB3
	private void OnClickCallJumpButton()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x060151B4 RID: 86452 RVA: 0x00557AD5 File Offset: 0x00555CD5
	[NullableContext(2)]
	private bool CanExecuteChange(object _1, bool _2, EToggleState _3)
	{
		return false;
	}

	// Token: 0x04009E3E RID: 40510
	[Nullable(2)]
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04009E3F RID: 40511
	[Nullable(2)]
	private SmallItemGrid RoleItemGrid;

	// Token: 0x04009E40 RID: 40512
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x04009E41 RID: 40513
	[Nullable(2)]
	public Func<int, bool> CanClickCallBack;

	// Token: 0x04009E42 RID: 40514
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> DetailVerticalLayout;

	// Token: 0x04009E43 RID: 40515
	[Nullable(2)]
	private RoleDevRoleViewItemDataBase Data;

	// Token: 0x04009E44 RID: 40516
	[Nullable(2)]
	private ButtonItem NormalButtonItem;

	// Token: 0x04009E45 RID: 40517
	[Nullable(2)]
	private ButtonItem HighLightButtonItem;

	// Token: 0x02008E62 RID: 36450
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E2DD RID: 189149
		SmallRoleItem,
		// Token: 0x0402E2DE RID: 189150
		TxtRoleName,
		// Token: 0x0402E2DF RID: 189151
		TxtGoalLevel,
		// Token: 0x0402E2E0 RID: 189152
		PanelItemRight,
		// Token: 0x0402E2E1 RID: 189153
		NormalButtonItem,
		// Token: 0x0402E2E2 RID: 189154
		HighLightButtonItem,
		// Token: 0x0402E2E3 RID: 189155
		BtnCallJump,
		// Token: 0x0402E2E4 RID: 189156
		PanelItemNotObtained,
		// Token: 0x0402E2E5 RID: 189157
		PanelItemDetailLayout,
		// Token: 0x0402E2E6 RID: 189158
		PanelItemList,
		// Token: 0x0402E2E7 RID: 189159
		TxtNotObtained
	}
}

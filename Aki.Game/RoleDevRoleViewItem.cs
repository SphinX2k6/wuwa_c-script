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

// Token: 0x02001D96 RID: 7574
[NullableContext(1)]
[Nullable(0)]
public class RoleDevRoleViewItem : UiPanelBase
{
	// Token: 0x06012BA1 RID: 76705 RVA: 0x005820B0 File Offset: 0x005802B0
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

	// Token: 0x06012BA2 RID: 76706 RVA: 0x005821E0 File Offset: 0x005803E0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevRoleViewItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevRoleViewItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012BA3 RID: 76707 RVA: 0x00582223 File Offset: 0x00580423
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06012BA4 RID: 76708 RVA: 0x0058223D File Offset: 0x0058043D
	public void Refresh(RoleDevRoleViewItemDataBase data)
	{
		this.Data = data;
		this.RefreshRoleItemGrid(data);
		this.RefreshName(data);
		this.RefreshCallButton(data);
		this.RefreshGoalLevelAndPanel(data);
		this.RefreshDetailList(data);
	}

	// Token: 0x06012BA5 RID: 76709 RVA: 0x0058226C File Offset: 0x0058046C
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

	// Token: 0x06012BA6 RID: 76710 RVA: 0x00582370 File Offset: 0x00580570
	private void RefreshName(RoleDevRoleViewItemDataBase data)
	{
		base.GetText(1).SetText(data.RoleName, true);
	}

	// Token: 0x06012BA7 RID: 76711 RVA: 0x00582388 File Offset: 0x00580588
	private void RefreshCallButton(RoleDevRoleViewItemDataBase data)
	{
		base.GetButton(6).RootUIComp.Get().SetUIActive(data.IsCall);
	}

	// Token: 0x06012BA8 RID: 76712 RVA: 0x005823B4 File Offset: 0x005805B4
	private void RefreshGoalLevelAndPanel(RoleDevRoleViewItemDataBase data)
	{
		this.SetGoalLevelTextAndPanel(data);
	}

	// Token: 0x06012BA9 RID: 76713 RVA: 0x005823BD File Offset: 0x005805BD
	private void RefreshDetailList(RoleDevRoleViewItemDataBase data)
	{
		this.DetailVerticalLayout.RefreshByData(data.DetailItems, null, false);
	}

	// Token: 0x06012BAA RID: 76714 RVA: 0x005823D4 File Offset: 0x005805D4
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

	// Token: 0x06012BAB RID: 76715 RVA: 0x005825FC File Offset: 0x005807FC
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

	// Token: 0x06012BAC RID: 76716 RVA: 0x00582688 File Offset: 0x00580888
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

	// Token: 0x06012BAD RID: 76717 RVA: 0x00582706 File Offset: 0x00580906
	private RoleDevDetailItem CreateDetailItem()
	{
		return new RoleDevDetailItem();
	}

	// Token: 0x06012BAE RID: 76718 RVA: 0x00582710 File Offset: 0x00580910
	private void InitRoleItemGrid()
	{
		this.RoleItemGrid = new SmallItemGrid();
		this.RoleItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.RoleItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		this.RoleItemGrid.SetExtendToggleEnable(false, false);
		this.RoleItemGrid.SetToggleInteractive(false);
	}

	// Token: 0x06012BAF RID: 76719 RVA: 0x0058276F File Offset: 0x0058096F
	private void InitDetailVerticalLayout()
	{
		this.DetailVerticalLayout = new GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData>(base.GetVerticalLayout(8), new Func<RoleDevDetailItem>(this.CreateDetailItem), null, false, true);
	}

	// Token: 0x06012BB0 RID: 76720 RVA: 0x00582792 File Offset: 0x00580992
	private void InitBtnJumpItem()
	{
		this.NormalButtonItem = new ButtonItem(base.GetItem(4));
		this.NormalButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
		this.NormalButtonItem.SetFunction(delegate(int _)
		{
			this.OnClickJumpButton();
		});
	}

	// Token: 0x06012BB1 RID: 76721 RVA: 0x005827D2 File Offset: 0x005809D2
	private void InitBtnPerfectJumpItem()
	{
		this.HighLightButtonItem = new ButtonItem(base.GetItem(5));
		this.HighLightButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
		this.HighLightButtonItem.SetFunction(delegate(int _)
		{
			this.OnClickJumpButton();
		});
	}

	// Token: 0x06012BB2 RID: 76722 RVA: 0x00582814 File Offset: 0x00580A14
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

	// Token: 0x06012BB3 RID: 76723 RVA: 0x005828B3 File Offset: 0x00580AB3
	private void OnClickCallJumpButton()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaMainView, this.Data.GachaId, null);
	}

	// Token: 0x06012BB4 RID: 76724 RVA: 0x005828D5 File Offset: 0x00580AD5
	[NullableContext(2)]
	private bool CanExecuteChange(object _1, bool _2, EToggleState _3)
	{
		return false;
	}

	// Token: 0x0400A227 RID: 41511
	[Nullable(2)]
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x0400A228 RID: 41512
	[Nullable(2)]
	private SmallItemGrid RoleItemGrid;

	// Token: 0x0400A229 RID: 41513
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x0400A22A RID: 41514
	[Nullable(2)]
	public Func<int, bool> CanClickCallBack;

	// Token: 0x0400A22B RID: 41515
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevDetailItem, global::IRoleDevDetailItemData> DetailVerticalLayout;

	// Token: 0x0400A22C RID: 41516
	[Nullable(2)]
	private RoleDevRoleViewItemDataBase Data;

	// Token: 0x0400A22D RID: 41517
	[Nullable(2)]
	private ButtonItem NormalButtonItem;

	// Token: 0x0400A22E RID: 41518
	[Nullable(2)]
	private ButtonItem HighLightButtonItem;

	// Token: 0x020080AA RID: 32938
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040299D9 RID: 170457
		SmallRoleItem,
		// Token: 0x040299DA RID: 170458
		TxtRoleName,
		// Token: 0x040299DB RID: 170459
		TxtGoalLevel,
		// Token: 0x040299DC RID: 170460
		PanelItemRight,
		// Token: 0x040299DD RID: 170461
		NormalButtonItem,
		// Token: 0x040299DE RID: 170462
		HighLightButtonItem,
		// Token: 0x040299DF RID: 170463
		BtnCallJump,
		// Token: 0x040299E0 RID: 170464
		PanelItemNotObtained,
		// Token: 0x040299E1 RID: 170465
		PanelItemDetailLayout,
		// Token: 0x040299E2 RID: 170466
		PanelItemList,
		// Token: 0x040299E3 RID: 170467
		TxtNotObtained
	}
}

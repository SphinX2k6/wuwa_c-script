using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A37 RID: 10807
[NullableContext(1)]
[Nullable(0)]
public class SkinRootView : UiViewBase
{
	// Token: 0x060167FE RID: 92158 RVA: 0x005B423C File Offset: 0x005B243C
	public SkinRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060167FF RID: 92159 RVA: 0x005B4248 File Offset: 0x005B2448
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06016800 RID: 92160 RVA: 0x005B42D0 File Offset: 0x005B24D0
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as ISkinViewData);
		this.ViewModel = new SkinRootViewModel();
		this.ViewModel.Init(this.ViewData);
		this.ViewModel.SetGetDragItemFunc(new Func<UUIDraggableComponent>(this.GetDragItem));
		this.ViewModel.Bind(new Action<ESkinRootViewData>(this.OnViewModelUpdate));
		this.FadeAnimController = new SkinFadeAnimController();
		CommonTabComponentData<SkinTabItem> data = new CommonTabComponentData<SkinTabItem>(new Func<UUIItem, int?, SkinTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<SkinTabItem>(base.GetItem(0), data, new Action(this.CloseView), false);
		this.TabComponent.SetHelpButtonCallBack(new Action(this.OnClickHelpBtn));
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		AudioSystem.Instance.SetState("mute_nature_voice", ERoleMuteAudioState.Mute, true);
	}

	// Token: 0x06016801 RID: 92161 RVA: 0x005B43E8 File Offset: 0x005B25E8
	private void CloseView()
	{
		bool needLoadRole = this.ViewModel.NeedLoadRole;
		if (needLoadRole)
		{
			BlackScreenController.Instance.AddBlackScreenAsync("Start", "CloseRoleSkinView", "Black", "Default");
		}
		base.CloseMe(delegate(bool _)
		{
			if (needLoadRole)
			{
				BlackScreenController.Instance.RemoveBlackScreen("Close", "CloseRoleSkinView", "Default");
			}
		});
	}

	// Token: 0x06016802 RID: 92162 RVA: 0x005B4448 File Offset: 0x005B2648
	private void OnViewModelUpdate(ESkinRootViewData data)
	{
		switch (data)
		{
		case ESkinRootViewData.RootUiVisible:
			if (this.ViewModel.GetRootUiVisible())
			{
				this.ShowView();
				return;
			}
			this.HideView();
			return;
		case ESkinRootViewData.MoveGamepadKeyTipActive:
			if (this.ViewModel.GetMoveGamepadKeyTipActive())
			{
				this.SetMoveGamepadKeyTipActive(true);
				return;
			}
			this.SetMoveGamepadKeyTipActive(false);
			return;
		case ESkinRootViewData.GamePadKeyTipRefresh:
			this.RefreshGamePadKeyTip();
			return;
		case ESkinRootViewData.ModelState:
		{
			SkinFadeAnimController fadeAnimController = this.FadeAnimController;
			if (fadeAnimController != null)
			{
				fadeAnimController.ChangeModelState(this.ViewModel.GetModelState());
			}
			EModelStateInSkinView? modelState = this.ViewModel.GetModelState();
			EModelStateInSkinView emodelStateInSkinView = EModelStateInSkinView.ShowRole;
			if ((modelState.GetValueOrDefault() == emodelStateInSkinView & modelState != null) || this.ViewModel.GetModelState().GetValueOrDefault() == EModelStateInSkinView.ShowWeapon)
			{
				this.ViewModel.TryShowRoleSystemRoleActor();
				return;
			}
			break;
		}
		case ESkinRootViewData.SelectTabViewName:
			this.SelectTabView(this.ViewModel.GetSelectTabViewName().Value);
			break;
		default:
			return;
		}
	}

	// Token: 0x06016803 RID: 92163 RVA: 0x005B452C File Offset: 0x005B272C
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.ShowRoleSystemRoleActor();
		if (!this.ViewModel.NeedLoadRole && !this.NeedReloadRole)
		{
			return;
		}
		AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
		if (actorByTag != null)
		{
			this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleRootView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).Value;
		}
	}

	// Token: 0x06016804 RID: 92164 RVA: 0x005B45A4 File Offset: 0x005B27A4
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		SkinRootView.<OnHandlePostLoadSceneAsync>d__16 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<SkinRootView.<OnHandlePostLoadSceneAsync>d__16>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016805 RID: 92165 RVA: 0x005B45E8 File Offset: 0x005B27E8
	private UniTask TryLoadRoleActor()
	{
		SkinRootView.<TryLoadRoleActor>d__17 <TryLoadRoleActor>d__;
		<TryLoadRoleActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLoadRoleActor>d__.<>4__this = this;
		<TryLoadRoleActor>d__.<>1__state = -1;
		<TryLoadRoleActor>d__.<>t__builder.Start<SkinRootView.<TryLoadRoleActor>d__17>(ref <TryLoadRoleActor>d__);
		return <TryLoadRoleActor>d__.<>t__builder.Task;
	}

	// Token: 0x06016806 RID: 92166 RVA: 0x005B462C File Offset: 0x005B282C
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.HideRoleSystemRoleActor();
		if (EffectSystem.Instance.IsValid(this.FloorEffect))
		{
			EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleRootView.HandleReleaseScene]", false, null);
		}
		this.NeedReloadRole = true;
		this.ReleaseRoleActor();
	}

	// Token: 0x06016807 RID: 92167 RVA: 0x005B4682 File Offset: 0x005B2882
	protected override void OnBeforeShow()
	{
		this.UpdateDynamicTabComponent();
		this.RefreshGamePadKeyTip();
	}

	// Token: 0x06016808 RID: 92168 RVA: 0x005B4690 File Offset: 0x005B2890
	protected void UpdateDynamicTabComponent()
	{
		this.TabDataList = RoleSkinModel.Instance.GetSkinTabList(this.ViewModel.IsMainRole, this.ViewModel.RoleId).ToArray();
		int num = this.TabDataList.Length;
		List<CommonTabItemData> list = this.TabComponent.CreateTabItemDataByLength(num);
		for (int i = 0; i < num; i++)
		{
			EUiTabViewName tabViewName = (EUiTabViewName)this.TabDataList[i].ChildViewName;
			ERedDotName? tabRedDotName = this.ViewModel.GetTabRedDotName(tabViewName);
			int? tabRedDotUid = this.ViewModel.GetTabRedDotUid(tabViewName);
			list[i].RedDotName = tabRedDotName;
			list[i].RedDotUid = tabRedDotUid;
		}
		this.TabComponent.RefreshTabItem(list, delegate
		{
			this.SelectTabView(this.ViewModel.GetCurSelectTabViewName());
		});
	}

	// Token: 0x06016809 RID: 92169 RVA: 0x005B4754 File Offset: 0x005B2954
	private void SelectTabView(EUiTabViewName tabName)
	{
		int index = 0;
		for (int i = 0; i < this.TabDataList.Length; i++)
		{
			if ((EUiTabViewName)this.TabDataList[i].ChildViewName == tabName)
			{
				index = i;
				break;
			}
		}
		this.TabComponent.SelectToggleByIndex(index, true);
	}

	// Token: 0x0601680A RID: 92170 RVA: 0x005B47A5 File Offset: 0x005B29A5
	protected override void OnBeforeHide()
	{
		this.TabViewComponent.HideCurrentTabView();
		if (this.LastHide)
		{
			EventSystem.Instance.Emit(EEventName.OnSkinRootViewDestroy);
			this.ViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
		}
	}

	// Token: 0x0601680B RID: 92171 RVA: 0x005B47D8 File Offset: 0x005B29D8
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.UnBind(new Action<ESkinRootViewData>(this.OnViewModelUpdate));
		AudioSystem.Instance.SetState("mute_nature_voice", ERoleMuteAudioState.None, true);
		if (this.ViewModel.NeedLoadRole)
		{
			this.ReleaseRoleActor();
		}
	}

	// Token: 0x0601680C RID: 92172 RVA: 0x005B4829 File Offset: 0x005B2A29
	private void ReleaseRoleActor()
	{
		if (this.ViewModel.TsUiSceneRoleActor == null)
		{
			return;
		}
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.ViewModel.TsUiSceneRoleActor);
		this.ViewModel.TsUiSceneRoleActor = null;
		this.FadeAnimController.TsUiSceneRoleActor = null;
	}

	// Token: 0x0601680D RID: 92173 RVA: 0x005B4867 File Offset: 0x005B2A67
	public void HideView()
	{
		this.TabComponent.SetUiActive(false);
	}

	// Token: 0x0601680E RID: 92174 RVA: 0x005B4875 File Offset: 0x005B2A75
	public void ShowView()
	{
		this.TabComponent.SetUiActive(true);
	}

	// Token: 0x0601680F RID: 92175 RVA: 0x005B4884 File Offset: 0x005B2A84
	public void RefreshGamePadKeyTip()
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		EUiTabViewName curSelectTabViewName = this.ViewModel.GetCurSelectTabViewName();
		if (!(curSelectTabViewName == EUiTabViewName.RoleSkinTabView) && !(curSelectTabViewName == EUiTabViewName.RoleOrnamentTabView))
		{
			if (curSelectTabViewName == EUiTabViewName.FlySkinTabView)
			{
				bool uiactive = !this.TabComponent.IsUiActiveInHierarchy();
				UUIItem item3 = base.GetItem(4);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(uiactive);
			}
			return;
		}
		UUIItem item4 = base.GetItem(3);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(true);
	}

	// Token: 0x06016810 RID: 92176 RVA: 0x005B491E File Offset: 0x005B2B1E
	public void SetMoveGamepadKeyTipActive(bool isActive)
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isActive);
	}

	// Token: 0x06016811 RID: 92177 RVA: 0x005B4932 File Offset: 0x005B2B32
	private SkinTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new SkinTabItem();
	}

	// Token: 0x06016812 RID: 92178 RVA: 0x005B493C File Offset: 0x005B2B3C
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = TimeUtil.Instance.GetServerTimeStamp();
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
		SkinTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.ViewModel.SetCurSelectTabViewName(euiTabViewName, false);
		this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.ViewModel, null);
		this.TabComponent.SetHelpButtonShowState(this.ViewModel.IsShowHelpBtn(euiTabViewName));
		this.RefreshGamePadKeyTip();
	}

	// Token: 0x06016813 RID: 92179 RVA: 0x005B49C8 File Offset: 0x005B2BC8
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06016814 RID: 92180 RVA: 0x005B4A00 File Offset: 0x005B2C00
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		return intConfig == null || (this.LastClickTime == 0.0 || TimeUtil.Instance.GetServerTimeStamp() - this.LastClickTime >= (double)intConfig.Value);
	}

	// Token: 0x06016815 RID: 92181 RVA: 0x005B4A60 File Offset: 0x005B2C60
	private void OnClickHelpBtn()
	{
		EUiTabViewName? currentTabViewName = this.TabViewComponent.GetCurrentTabViewName(null);
		if (currentTabViewName == null)
		{
			return;
		}
		int? helpId = this.ViewModel.GetHelpId(currentTabViewName.Value);
		if (helpId != null)
		{
			HelpController.Instance.OpenHelpById(helpId.Value);
		}
	}

	// Token: 0x06016816 RID: 92182 RVA: 0x005B4AB9 File Offset: 0x005B2CB9
	private UUIDraggableComponent GetDragItem()
	{
		return base.GetDraggable(2);
	}

	// Token: 0x06016817 RID: 92183 RVA: 0x005B4AC4 File Offset: 0x005B2CC4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int param = int.Parse(configParams[0]);
		int num = Array.FindIndex<UiDynamicTab>(this.TabDataList, (UiDynamicTab data) => data.Id == param);
		if (num < 0)
		{
			return null;
		}
		TabComponentWithCaptionItem<SkinTabItem> tabComponent = this.TabComponent;
		UUIItem uuiitem;
		if (tabComponent == null)
		{
			uuiitem = null;
		}
		else
		{
			SkinTabItem tabItemByIndex = tabComponent.GetTabItemByIndex(num);
			uuiitem = ((tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null);
		}
		UUIItem uuiitem2 = uuiitem;
		if (uuiitem2 != null)
		{
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
		return null;
	}

	// Token: 0x0400A707 RID: 42759
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400A708 RID: 42760
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<SkinTabItem> TabComponent;

	// Token: 0x0400A709 RID: 42761
	[Nullable(2)]
	protected UiDynamicTab[] TabDataList;

	// Token: 0x0400A70A RID: 42762
	[Nullable(2)]
	private ISkinViewData ViewData;

	// Token: 0x0400A70B RID: 42763
	[Nullable(2)]
	private SkinRootViewModel ViewModel;

	// Token: 0x0400A70C RID: 42764
	[Nullable(2)]
	private SkinFadeAnimController FadeAnimController;

	// Token: 0x0400A70D RID: 42765
	private double LastClickTime;

	// Token: 0x0400A70E RID: 42766
	private bool NeedReloadRole;

	// Token: 0x0400A70F RID: 42767
	private int FloorEffect;

	// Token: 0x02009079 RID: 36985
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402ED35 RID: 191797
		CaptionItem,
		// Token: 0x0402ED36 RID: 191798
		ContentItem,
		// Token: 0x0402ED37 RID: 191799
		DragItem,
		// Token: 0x0402ED38 RID: 191800
		ItemGamePadKeyTipA,
		// Token: 0x0402ED39 RID: 191801
		ItemGamePadKeyTipB
	}
}

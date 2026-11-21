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

// Token: 0x02001FB2 RID: 8114
[NullableContext(1)]
[Nullable(0)]
public class SkinRootView : UiViewBase
{
	// Token: 0x06014207 RID: 82439 RVA: 0x005DF3B1 File Offset: 0x005DD5B1
	public SkinRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014208 RID: 82440 RVA: 0x005DF3BC File Offset: 0x005DD5BC
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

	// Token: 0x06014209 RID: 82441 RVA: 0x005DF444 File Offset: 0x005DD644
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

	// Token: 0x0601420A RID: 82442 RVA: 0x005DF55C File Offset: 0x005DD75C
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

	// Token: 0x0601420B RID: 82443 RVA: 0x005DF5BC File Offset: 0x005DD7BC
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

	// Token: 0x0601420C RID: 82444 RVA: 0x005DF6A0 File Offset: 0x005DD8A0
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

	// Token: 0x0601420D RID: 82445 RVA: 0x005DF718 File Offset: 0x005DD918
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		SkinRootView.<OnHandlePostLoadSceneAsync>d__16 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<SkinRootView.<OnHandlePostLoadSceneAsync>d__16>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601420E RID: 82446 RVA: 0x005DF75C File Offset: 0x005DD95C
	private UniTask TryLoadRoleActor()
	{
		SkinRootView.<TryLoadRoleActor>d__17 <TryLoadRoleActor>d__;
		<TryLoadRoleActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLoadRoleActor>d__.<>4__this = this;
		<TryLoadRoleActor>d__.<>1__state = -1;
		<TryLoadRoleActor>d__.<>t__builder.Start<SkinRootView.<TryLoadRoleActor>d__17>(ref <TryLoadRoleActor>d__);
		return <TryLoadRoleActor>d__.<>t__builder.Task;
	}

	// Token: 0x0601420F RID: 82447 RVA: 0x005DF7A0 File Offset: 0x005DD9A0
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

	// Token: 0x06014210 RID: 82448 RVA: 0x005DF7F6 File Offset: 0x005DD9F6
	protected override void OnBeforeShow()
	{
		this.UpdateDynamicTabComponent();
		this.RefreshGamePadKeyTip();
	}

	// Token: 0x06014211 RID: 82449 RVA: 0x005DF804 File Offset: 0x005DDA04
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

	// Token: 0x06014212 RID: 82450 RVA: 0x005DF8C8 File Offset: 0x005DDAC8
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

	// Token: 0x06014213 RID: 82451 RVA: 0x005DF919 File Offset: 0x005DDB19
	protected override void OnBeforeHide()
	{
		this.TabViewComponent.HideCurrentTabView();
		if (this.LastHide)
		{
			EventSystem.Instance.Emit(EEventName.OnSkinRootViewDestroy);
			this.ViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
		}
	}

	// Token: 0x06014214 RID: 82452 RVA: 0x005DF94C File Offset: 0x005DDB4C
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.UnBind(new Action<ESkinRootViewData>(this.OnViewModelUpdate));
		AudioSystem.Instance.SetState("mute_nature_voice", ERoleMuteAudioState.None, true);
		if (this.ViewModel.NeedLoadRole)
		{
			this.ReleaseRoleActor();
		}
	}

	// Token: 0x06014215 RID: 82453 RVA: 0x005DF99D File Offset: 0x005DDB9D
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

	// Token: 0x06014216 RID: 82454 RVA: 0x005DF9DB File Offset: 0x005DDBDB
	public void HideView()
	{
		this.TabComponent.SetUiActive(false);
	}

	// Token: 0x06014217 RID: 82455 RVA: 0x005DF9E9 File Offset: 0x005DDBE9
	public void ShowView()
	{
		this.TabComponent.SetUiActive(true);
	}

	// Token: 0x06014218 RID: 82456 RVA: 0x005DF9F8 File Offset: 0x005DDBF8
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

	// Token: 0x06014219 RID: 82457 RVA: 0x005DFA92 File Offset: 0x005DDC92
	public void SetMoveGamepadKeyTipActive(bool isActive)
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isActive);
	}

	// Token: 0x0601421A RID: 82458 RVA: 0x005DFAA6 File Offset: 0x005DDCA6
	private SkinTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new SkinTabItem();
	}

	// Token: 0x0601421B RID: 82459 RVA: 0x005DFAB0 File Offset: 0x005DDCB0
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

	// Token: 0x0601421C RID: 82460 RVA: 0x005DFB3C File Offset: 0x005DDD3C
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0601421D RID: 82461 RVA: 0x005DFB74 File Offset: 0x005DDD74
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		return intConfig == null || (this.LastClickTime == 0.0 || TimeUtil.Instance.GetServerTimeStamp() - this.LastClickTime >= (double)intConfig.Value);
	}

	// Token: 0x0601421E RID: 82462 RVA: 0x005DFBD4 File Offset: 0x005DDDD4
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

	// Token: 0x0601421F RID: 82463 RVA: 0x005DFC2D File Offset: 0x005DDE2D
	private UUIDraggableComponent GetDragItem()
	{
		return base.GetDraggable(2);
	}

	// Token: 0x06014220 RID: 82464 RVA: 0x005DFC38 File Offset: 0x005DDE38
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

	// Token: 0x0400AAF2 RID: 43762
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400AAF3 RID: 43763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<SkinTabItem> TabComponent;

	// Token: 0x0400AAF4 RID: 43764
	[Nullable(2)]
	protected UiDynamicTab[] TabDataList;

	// Token: 0x0400AAF5 RID: 43765
	[Nullable(2)]
	private ISkinViewData ViewData;

	// Token: 0x0400AAF6 RID: 43766
	[Nullable(2)]
	private SkinRootViewModel ViewModel;

	// Token: 0x0400AAF7 RID: 43767
	[Nullable(2)]
	private SkinFadeAnimController FadeAnimController;

	// Token: 0x0400AAF8 RID: 43768
	private double LastClickTime;

	// Token: 0x0400AAF9 RID: 43769
	private bool NeedReloadRole;

	// Token: 0x0400AAFA RID: 43770
	private int FloorEffect;

	// Token: 0x020082C0 RID: 33472
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402A42D RID: 173101
		CaptionItem,
		// Token: 0x0402A42E RID: 173102
		ContentItem,
		// Token: 0x0402A42F RID: 173103
		DragItem,
		// Token: 0x0402A430 RID: 173104
		ItemGamePadKeyTipA,
		// Token: 0x0402A431 RID: 173105
		ItemGamePadKeyTipB
	}
}

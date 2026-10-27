using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A53 RID: 10835
[NullableContext(1)]
[Nullable(0)]
public class FlySkinTabView : UiTabViewBase
{
	// Token: 0x0601691F RID: 92447 RVA: 0x005B8380 File Offset: 0x005B6580
	protected unsafe override void OnRegisterComponent()
	{
		this.RootViewModel = (this.ExtraParams as SkinRootViewModel);
		this.FlySkinTabViewModel = new FlySkinTabViewModel();
		this.FlySkinTabViewModel.Init(this.RootViewModel.ViewData);
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnApplyToAllHelpBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06016920 RID: 92448 RVA: 0x005B8610 File Offset: 0x005B6810
	protected override UniTask OnBeforeStartAsync()
	{
		FlySkinTabView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FlySkinTabView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016921 RID: 92449 RVA: 0x005B8654 File Offset: 0x005B6854
	protected override void OnStart()
	{
		this.ParaglidingTabItem.SetItemToggleState(EToggleState.ETT_UnChecked, new bool?(false));
		this.SoarWingTabItem.SetItemToggleState(EToggleState.ETT_UnChecked, new bool?(false));
		this.SelectedTabItem = null;
		this.FlySkinTabViewModel.ResetSelectedTab();
		this.ParaglidingTabItem.AddItemToggleStateChange(new Action<EToggleState>(this.OnParaglidingTabToggleStateChange));
		this.SoarWingTabItem.AddItemToggleStateChange(new Action<EToggleState>(this.OnSoarWingTabToggleStateChange));
		this.ParaglidingTabItem.SetCanItemToggleStateChange(new Func<bool>(this.CanTabToggleChange));
		this.SoarWingTabItem.SetCanItemToggleStateChange(new Func<bool>(this.CanTabToggleChange));
		base.GetExtendToggle(3).OnStateChange.Add(new Action<EToggleState>(this.OnSwitchShowToggleStateChange));
		base.GetExtendToggle(10).OnStateChange.Add(new Action<EToggleState>(this.OnApplyToAllToggleStateChange));
		this.GridLayout = new GenericLayout<FlySkinGridItem, FlySkinGridData>(base.GetLayoutBase(1), new Func<FlySkinGridItem>(this.InitGridItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		this.ObtainLayout = new GenericLayout<FlySkinObtainItem, IFlySkinGetWayData>(base.GetLayoutBase(5), new Func<FlySkinObtainItem>(this.InitObtainItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
		this.FlySkinTabViewModel.Bind(new Action<EFlySkinViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x06016922 RID: 92450 RVA: 0x005B87A7 File Offset: 0x005B69A7
	protected override void OnBeforeDestroy()
	{
		this.FlySkinTabViewModel.UnBind(new Action<EFlySkinViewData>(this.OnViewModelUpdate));
		this.DestroyGliderObserver();
	}

	// Token: 0x06016923 RID: 92451 RVA: 0x005B87C8 File Offset: 0x005B69C8
	protected override void OnBeforeShow()
	{
		this.InitGliderObserver();
		this.LastClickTimeStamp = 0.0;
		this.CanLoadModel = false;
		this.RootViewModel.SetModelState(EModelStateInSkinView.ShowGlider, false);
		int selectedFlySkinId = this.FlySkinTabViewModel.SelectedFlySkinId;
		int selectedSkinId = (selectedFlySkinId == -1) ? FlySkinModel.Instance.GetRoleEquipParaglidingSkinId(this.FlySkinTabViewModel.RoleDataId) : selectedFlySkinId;
		EFlySkinTab valueOrDefault = this.FlySkinTabViewModel.GetSelectedTab().GetValueOrDefault();
		UpdateViewContext context = new UpdateViewContext
		{
			Tab = valueOrDefault,
			SelectedSkinId = selectedSkinId,
			UiShowState = true,
			IsApplyToAll = false
		};
		this.UpdateView(context);
	}

	// Token: 0x06016924 RID: 92452 RVA: 0x005B8865 File Offset: 0x005B6A65
	protected override void OnAfterShow()
	{
		this.CanPushCamera = true;
		this.TryPushCamera();
		this.TryStartCameraInputComponent();
	}

	// Token: 0x06016925 RID: 92453 RVA: 0x005B887C File Offset: 0x005B6A7C
	private void HideModelWithEffect()
	{
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		UiModelBase uiModelBase = (gliderObserver != null) ? gliderObserver.Model : null;
		if (uiModelBase == null)
		{
			return;
		}
		UiModelUtil.Instance.SetVisible(uiModelBase, false);
		UiModelDataComponent uiModelDataComponent = (uiModelBase != null) ? uiModelBase.CheckGetComponent<UiModelDataComponent>() : null;
		if (uiModelDataComponent != null && uiModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete)
		{
			EFlySkinType selectedFlySkinType = this.FlySkinTabViewModel.SelectedFlySkinType;
			string flySkinSpawnEffectId = SkinConfig.Instance.GetFlySkinSpawnEffectId(selectedFlySkinType);
			UiModelUtil.Instance.PlayEffectOnRoot(uiModelBase, flySkinSpawnEffectId);
		}
	}

	// Token: 0x06016926 RID: 92454 RVA: 0x005B88EE File Offset: 0x005B6AEE
	protected override void OnBeforeHide()
	{
		this.ResetAll();
	}

	// Token: 0x06016927 RID: 92455 RVA: 0x005B88F6 File Offset: 0x005B6AF6
	private void OnSkinRootViewDestroy()
	{
		this.ResetAll();
	}

	// Token: 0x06016928 RID: 92456 RVA: 0x005B88FE File Offset: 0x005B6AFE
	private void ResetAll()
	{
		this.WaitCameraId = null;
		this.CanLoadModel = false;
		this.CanPushCamera = false;
		this.HideModelWithEffect();
		this.RootViewModel.EndCameraInput();
	}

	// Token: 0x06016929 RID: 92457 RVA: 0x005B8928 File Offset: 0x005B6B28
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRoleFlySkinChange, new Action<int, EFlySkinType, int, int>(this.OnRoleFlySkinChange));
		EventSystem.Instance.Add(EEventName.OnFlySkinEquipResponse, new Action<int, int>(this.OnFlySkinEquipResponse));
		EventSystem.Instance.Add(EEventName.OnFlySkinUnLoadResponse, new Action<int, int>(this.OnFlySkinUnLoadResponse));
		EventSystem.Instance.Add(EEventName.OnFlySkinEquipToAllRoleResponse, new Action<IReadOnlyList<RoleFlySkinChange>>(this.OnFlySkinEquipToAllRoleResponse));
		EventSystem.Instance.Add(EEventName.OnFlySkinAllUnLoadResponse, new Action<EFlySkinType>(this.OnFlySkinAllUnLoadResponse));
		EventSystem.Instance.Add(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Add(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
	}

	// Token: 0x0601692A RID: 92458 RVA: 0x005B89FC File Offset: 0x005B6BFC
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleFlySkinChange, new Action<int, EFlySkinType, int, int>(this.OnRoleFlySkinChange));
		EventSystem.Instance.Remove(EEventName.OnFlySkinEquipResponse, new Action<int, int>(this.OnFlySkinEquipResponse));
		EventSystem.Instance.Remove(EEventName.OnFlySkinUnLoadResponse, new Action<int, int>(this.OnFlySkinUnLoadResponse));
		EventSystem.Instance.Remove(EEventName.OnFlySkinEquipToAllRoleResponse, new Action<IReadOnlyList<RoleFlySkinChange>>(this.OnFlySkinEquipToAllRoleResponse));
		EventSystem.Instance.Remove(EEventName.OnFlySkinAllUnLoadResponse, new Action<EFlySkinType>(this.OnFlySkinAllUnLoadResponse));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		EventSystem.Instance.Remove(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
	}

	// Token: 0x0601692B RID: 92459 RVA: 0x005B8AD0 File Offset: 0x005B6CD0
	private void InitGliderObserver()
	{
		UiSceneManager.Instance.InitGliderSkeletalHandle();
		SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
		gliderSkeletalHandle.Model.CheckGetComponent<UiModelActorComponent>().SetTransformByTag(FlySkinDefine.DEFAULT_FLY_SKIN_CASE);
		this.GliderObserver = gliderSkeletalHandle;
	}

	// Token: 0x0601692C RID: 92460 RVA: 0x005B8B0E File Offset: 0x005B6D0E
	private void DestroyGliderObserver()
	{
		UiSceneManager.Instance.DestroyGliderSkeletalHandle();
		this.GliderObserver = null;
	}

	// Token: 0x0601692D RID: 92461 RVA: 0x005B8B21 File Offset: 0x005B6D21
	public void UpdateView(UpdateViewContext context)
	{
		this.UpdateIsApplyToAll(context.IsApplyToAll);
		this.UpdateUiShowState(context.UiShowState, false);
		this.SelectTab(context.Tab, context.SelectedSkinId);
	}

	// Token: 0x0601692E RID: 92462 RVA: 0x005B8B50 File Offset: 0x005B6D50
	public void SelectTab(EFlySkinTab tab, int skinId)
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		flySkinTabViewModel.SelectTab(tab);
		flySkinTabViewModel.SelectGridByIndex(this.FlySkinTabViewModel.GetGridIndexBySkinId(skinId).GetValueOrDefault());
	}

	// Token: 0x0601692F RID: 92463 RVA: 0x005B8B83 File Offset: 0x005B6D83
	public void SelectGridByIndex(int gridIndex)
	{
		this.FlySkinTabViewModel.SelectGridByIndex(gridIndex);
		this.GridLayout.SelectGridProxy(gridIndex, false);
		this.OnGridSelected();
	}

	// Token: 0x06016930 RID: 92464 RVA: 0x005B8BA4 File Offset: 0x005B6DA4
	public void OnGridSelected()
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		FlySkinGridData selectedGridData = flySkinTabViewModel.SelectedGridData;
		bool flag = selectedGridData == null || selectedGridData.GetIsLock();
		this.ObtainLayout.SetActive(flag);
		if (flag)
		{
			this.ObtainLayout.RefreshByData(flySkinTabViewModel.GetWayDataList, null, false);
		}
		this.RefreshConfirmBtnState();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), selectedGridData.GetName(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), selectedGridData.GetTypeDescription(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), selectedGridData.GetDescription(), Array.Empty<object>());
		this.TryLoadModel();
	}

	// Token: 0x06016931 RID: 92465 RVA: 0x005B8C50 File Offset: 0x005B6E50
	public void TryLoadModel()
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		UiModelBase uiModelBase = (gliderObserver != null) ? gliderObserver.Model : null;
		if (uiModelBase == null)
		{
			return;
		}
		if (!this.CanLoadModel)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
			uiModelBase.CheckGetComponent<UiModelActorComponent>().SetTransformByTag(flySkinTabViewModel.ModelCase);
			return;
		}
		SkinConfig instance = SkinConfig.Instance;
		EFlySkinType selectedFlySkinType = flySkinTabViewModel.SelectedFlySkinType;
		FlySkinGridData selectedGridData = flySkinTabViewModel.SelectedGridData;
		string standAnimPath = selectedGridData.GetStandAnimPath();
		string flySkinSpawnEffectId = instance.GetFlySkinSpawnEffectId(selectedFlySkinType);
		string flySkinSpawnMaterialController = instance.GetFlySkinSpawnMaterialController(selectedFlySkinType);
		string effectPath = EffectUtil.GetEffectPath(flySkinSpawnEffectId);
		string changeMaterialControllerPath = EffectUtil.GetEffectPath(flySkinSpawnMaterialController);
		List<string> extraResourceList = new List<string>
		{
			standAnimPath,
			effectPath,
			changeMaterialControllerPath
		};
		UiModelLoadComponent loadComponent = uiModelBase.CheckGetComponent<UiModelLoadComponent>();
		uiModelBase.CheckGetComponent<UiModelActorComponent>().SetTransformByTag(flySkinTabViewModel.ModelCase);
		Action loadFinishCallBack = delegate()
		{
			SkeletalObserverHandle gliderObserver2 = this.GliderObserver;
			UiModelBase uiModelBase2 = (gliderObserver2 != null) ? gliderObserver2.Model : null;
			if (uiModelBase2 == null)
			{
				return;
			}
			UiModelUtil.Instance.SetVisible(uiModelBase2, true);
			UiModelLoadComponent loadComponent = loadComponent;
			UAnimationAsset uanimationAsset = ((loadComponent != null) ? loadComponent.GetLoadedResource(standAnimPath) : null) as UAnimationAsset;
			if (uanimationAsset == null)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.LZK, "[FlySkin] 飞行皮肤待机动画预加载失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			uiModelBase2.CheckGetComponent<UiModelAnimationComponent>().PlayAnimation(uanimationAsset, true);
			UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = uiModelBase2.CheckGetComponent<UiModelRenderingMaterialComponent>();
			PD_CharacterControllerData_C pd_CharacterControllerData_C = loadComponent.GetLoadedResource(changeMaterialControllerPath) as PD_CharacterControllerData_C;
			if (pd_CharacterControllerData_C != null && uiModelRenderingMaterialComponent != null)
			{
				uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C);
			}
			UiModelUtil.Instance.PlayEffectOnRoot(uiModelBase2, "GliderEffect");
		};
		loadComponent.LoadModelByModelId(selectedGridData.GetModelId(), true, loadFinishCallBack, extraResourceList);
	}

	// Token: 0x06016932 RID: 92466 RVA: 0x005B8D60 File Offset: 0x005B6F60
	public void UpdateUiShowState(bool state, bool resetCamera)
	{
		this.FlySkinTabViewModel.SetUiShowState(state);
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(3).SetToggleState(state2, false, false, false);
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(state);
		}
		this.RootViewModel.SetCaptionItemActive(state);
		this.RootViewModel.NotifyGamePadKeyTipRefresh();
		this.RootViewModel.SetCameraInputCanInput(!state);
		if (state && resetCamera)
		{
			this.TryPushCamera();
		}
	}

	// Token: 0x06016933 RID: 92467 RVA: 0x005B8DD8 File Offset: 0x005B6FD8
	public void UpdateIsApplyToAll(bool isApplyToAll)
	{
		this.FlySkinTabViewModel.SetIsApplyToAll(isApplyToAll);
		EToggleState state = isApplyToAll ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(10);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x06016934 RID: 92468 RVA: 0x005B8E10 File Offset: 0x005B7010
	public void RefreshConfirmBtnState()
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		FlySkinGridData selectedGridData = flySkinTabViewModel.SelectedGridData;
		bool flag = selectedGridData == null || selectedGridData.GetIsLock();
		UUIItem item = base.GetItem(14);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		if (flag)
		{
			return;
		}
		int selectedFlySkinId = flySkinTabViewModel.SelectedFlySkinId;
		EFlySkinType selectedFlySkinType = flySkinTabViewModel.SelectedFlySkinType;
		int roleDataId = flySkinTabViewModel.RoleDataId;
		bool flag2 = flySkinTabViewModel.IsApplyToAll || !FlySkinModel.Instance.CheckRoleEquipFlySkin(roleDataId, selectedFlySkinId, selectedFlySkinType);
		this.ConfirmBtnItem.SetEnableClick(flag2);
		string flySkinEquipBtnTextId = SkinConfig.Instance.GetFlySkinEquipBtnTextId(selectedFlySkinType, flag2);
		this.ConfirmBtnItem.SetLocalTextNew(flySkinEquipBtnTextId, Array.Empty<object>());
	}

	// Token: 0x06016935 RID: 92469 RVA: 0x005B8EB4 File Offset: 0x005B70B4
	private void TryPushCamera()
	{
		if (!this.CanPushCamera)
		{
			return;
		}
		string flySkinModelCameraId = SkinConfig.Instance.GetFlySkinModelCameraId(this.FlySkinTabViewModel.SelectedFlySkinType);
		this.WaitCameraId = flySkinModelCameraId;
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(flySkinModelCameraId, true, true, "10010", false, null, null);
	}

	// Token: 0x06016936 RID: 92470 RVA: 0x005B8F08 File Offset: 0x005B7108
	private void TryStartCameraInputComponent()
	{
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		if (((gliderObserver != null) ? gliderObserver.Model : null) == null)
		{
			return;
		}
		IUiCameraInputComponentData flySkinTabCameraInputData = this.FlySkinTabViewModel.GetFlySkinTabCameraInputData(this.RootViewModel.GetDragItem());
		this.RootViewModel.StartCameraInput(flySkinTabCameraInputData, null, false);
	}

	// Token: 0x06016937 RID: 92471 RVA: 0x005B8F58 File Offset: 0x005B7158
	public void ChangeSelectedTab(EFlySkinTab tab)
	{
		int roleEquipFlySkinId = FlySkinModel.Instance.GetRoleEquipFlySkinId(this.FlySkinTabViewModel.RoleDataId, FlySkinDefine.flySkinTabToType[tab]);
		this.SelectTab(tab, roleEquipFlySkinId);
	}

	// Token: 0x06016938 RID: 92472 RVA: 0x005B8F90 File Offset: 0x005B7190
	protected bool CanTabToggleChange()
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		if (this.LastClickTimeStamp != 0.0)
		{
			double num = Time.Instance.Now - this.LastClickTimeStamp;
			int? num2 = intConfig;
			double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
			if (!(num >= num3.GetValueOrDefault() & num3 != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06016939 RID: 92473 RVA: 0x005B9015 File Offset: 0x005B7215
	private void OnParaglidingTabToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ChangeSelectedTab(EFlySkinTab.ParaglidingTab);
			this.LastClickTimeStamp = Time.Instance.Now;
		}
	}

	// Token: 0x0601693A RID: 92474 RVA: 0x005B9032 File Offset: 0x005B7232
	private void OnSoarWingTabToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ChangeSelectedTab(EFlySkinTab.SoarWingTab);
			this.LastClickTimeStamp = Time.Instance.Now;
		}
	}

	// Token: 0x0601693B RID: 92475 RVA: 0x005B904F File Offset: 0x005B724F
	public FlySkinChildTabItem GetTabItem(EFlySkinTab type)
	{
		if (type == EFlySkinTab.ParaglidingTab)
		{
			return this.ParaglidingTabItem;
		}
		if (type != EFlySkinTab.SoarWingTab)
		{
			return null;
		}
		return this.SoarWingTabItem;
	}

	// Token: 0x0601693C RID: 92476 RVA: 0x005B9069 File Offset: 0x005B7269
	private void OnSwitchShowToggleStateChange(EToggleState state)
	{
		this.UpdateUiShowState(state == EToggleState.ETT_Checked, true);
	}

	// Token: 0x0601693D RID: 92477 RVA: 0x005B9076 File Offset: 0x005B7276
	private void OnApplyToAllToggleStateChange(EToggleState state)
	{
		this.UpdateIsApplyToAll(state == EToggleState.ETT_Checked);
		this.RefreshConfirmBtnState();
	}

	// Token: 0x0601693E RID: 92478 RVA: 0x005B9088 File Offset: 0x005B7288
	private FlySkinGridItem InitGridItem()
	{
		FlySkinGridItem flySkinGridItem = new FlySkinGridItem();
		flySkinGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.GridItemClick));
		flySkinGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.GridItemCanExecuteChange));
		return flySkinGridItem;
	}

	// Token: 0x0601693F RID: 92479 RVA: 0x005B90B4 File Offset: 0x005B72B4
	private void GridItemClick(MediumItemGridExtendCallback parameters)
	{
		int skinId = (parameters.Data as FlySkinGridData).SkinId;
		int? gridIndexBySkinId = this.FlySkinTabViewModel.GetGridIndexBySkinId(skinId);
		if (gridIndexBySkinId != null)
		{
			this.SelectGridByIndex(gridIndexBySkinId.Value);
		}
	}

	// Token: 0x06016940 RID: 92480 RVA: 0x005B90F8 File Offset: 0x005B72F8
	private bool GridItemCanExecuteChange(object parameters, bool result, EToggleState state)
	{
		int skinId = (parameters as FlySkinGridData).SkinId;
		return this.FlySkinTabViewModel.SelectedFlySkinId != skinId;
	}

	// Token: 0x06016941 RID: 92481 RVA: 0x005B9122 File Offset: 0x005B7322
	private FlySkinObtainItem InitObtainItem()
	{
		return new FlySkinObtainItem();
	}

	// Token: 0x06016942 RID: 92482 RVA: 0x005B912C File Offset: 0x005B732C
	private void OnApplyToAllHelpBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FlySkinApplyHelp);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06016943 RID: 92483 RVA: 0x005B9150 File Offset: 0x005B7350
	private void OnConfirmBtnClick(int state)
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		int skinId = flySkinTabViewModel.SelectedFlySkinId;
		EFlySkinType skinType = flySkinTabViewModel.SelectedFlySkinType;
		int roleDataId = flySkinTabViewModel.RoleDataId;
		if (flySkinTabViewModel.IsApplyToAll)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FlySkinApplyToAll);
			Action value = delegate()
			{
				if (skinId == 0)
				{
					FlySkinController.Instance.FlySkinAllUnLoadRequest(skinType);
				}
				else
				{
					FlySkinController.Instance.FlySkinWearAllRoleRequest(skinId);
				}
				this.UpdateIsApplyToAll(false);
				this.RefreshConfirmBtnState();
			};
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (skinId == 0)
		{
			int roleEquipFlySkinId = FlySkinModel.Instance.GetRoleEquipFlySkinId(roleDataId, skinType);
			FlySkinController.Instance.FlySkinUnLoadRequest(roleDataId, roleEquipFlySkinId);
			return;
		}
		FlySkinController.Instance.FlySkinWearRequest(roleDataId, skinId);
	}

	// Token: 0x06016944 RID: 92484 RVA: 0x005B9208 File Offset: 0x005B7408
	private void OnRoleFlySkinChange(int roleDataId, EFlySkinType skinType, int oldSkinId, int newSkinId)
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		if (skinType != flySkinTabViewModel.SelectedFlySkinType || roleDataId != flySkinTabViewModel.RoleDataId)
		{
			return;
		}
		int? gridIndexBySkinId = flySkinTabViewModel.GetGridIndexBySkinId(oldSkinId);
		if (gridIndexBySkinId != null)
		{
			FlySkinGridItem layoutItemByIndex = this.GridLayout.GetLayoutItemByIndex(gridIndexBySkinId.Value);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.RefreshEquipState();
			}
		}
		int? gridIndexBySkinId2 = flySkinTabViewModel.GetGridIndexBySkinId(newSkinId);
		if (gridIndexBySkinId2 != null)
		{
			FlySkinGridItem layoutItemByIndex2 = this.GridLayout.GetLayoutItemByIndex(gridIndexBySkinId2.Value);
			if (layoutItemByIndex2 == null)
			{
				return;
			}
			layoutItemByIndex2.RefreshEquipState();
		}
	}

	// Token: 0x06016945 RID: 92485 RVA: 0x005B928B File Offset: 0x005B748B
	private void OnEquipSuccess()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("FlySkinReplaceTip", Array.Empty<object>());
		this.UpdateIsApplyToAll(false);
		this.RefreshConfirmBtnState();
	}

	// Token: 0x06016946 RID: 92486 RVA: 0x005B92AE File Offset: 0x005B74AE
	private void OnFlySkinEquipResponse(int roleDataId, int skinId)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x06016947 RID: 92487 RVA: 0x005B92B6 File Offset: 0x005B74B6
	private void OnFlySkinUnLoadResponse(int roleDataId, int skinId)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x06016948 RID: 92488 RVA: 0x005B92BE File Offset: 0x005B74BE
	private void OnFlySkinEquipToAllRoleResponse(IReadOnlyList<RoleFlySkinChange> skinChanges)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x06016949 RID: 92489 RVA: 0x005B92C6 File Offset: 0x005B74C6
	private void OnFlySkinAllUnLoadResponse(EFlySkinType skinType)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x0601694A RID: 92490 RVA: 0x005B92CE File Offset: 0x005B74CE
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.HandleName == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
				this.TryLoadModel();
			}
		}
	}

	// Token: 0x0601694B RID: 92491 RVA: 0x005B9300 File Offset: 0x005B7500
	private void OnViewModelUpdate(EFlySkinViewData data)
	{
		if (data == EFlySkinViewData.SelectedGridIndex)
		{
			FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
			this.TryPushCamera();
			this.GridLayout.RefreshByData(flySkinTabViewModel.GetGridDataList(), delegate
			{
				this.GridLayout.SelectGridProxy(flySkinTabViewModel.GetSelectedGridIndex(), false);
			}, false);
			this.OnGridSelected();
			return;
		}
		if (data == EFlySkinViewData.SelectedTab)
		{
			FlySkinChildTabItem tabItem = this.GetTabItem(this.FlySkinTabViewModel.GetSelectedTab().Value);
			FlySkinChildTabItem selectedTabItem = this.SelectedTabItem;
			if (selectedTabItem != null)
			{
				selectedTabItem.SetItemToggleState(EToggleState.ETT_UnChecked, new bool?(false));
			}
			this.SelectedTabItem = tabItem;
			tabItem.SetItemToggleState(EToggleState.ETT_Checked, new bool?(false));
		}
	}

	// Token: 0x0400A782 RID: 42882
	private SkinRootViewModel RootViewModel;

	// Token: 0x0400A783 RID: 42883
	private FlySkinTabViewModel FlySkinTabViewModel;

	// Token: 0x0400A784 RID: 42884
	protected GenericLayout<FlySkinGridItem, FlySkinGridData> GridLayout;

	// Token: 0x0400A785 RID: 42885
	protected GenericLayout<FlySkinObtainItem, IFlySkinGetWayData> ObtainLayout;

	// Token: 0x0400A786 RID: 42886
	private ButtonItem ConfirmBtnItem;

	// Token: 0x0400A787 RID: 42887
	private FlySkinChildTabItem ParaglidingTabItem;

	// Token: 0x0400A788 RID: 42888
	private FlySkinChildTabItem SoarWingTabItem;

	// Token: 0x0400A789 RID: 42889
	private FlySkinChildTabItem SelectedTabItem;

	// Token: 0x0400A78A RID: 42890
	private double LastClickTimeStamp;

	// Token: 0x0400A78B RID: 42891
	private bool CanPushCamera;

	// Token: 0x0400A78C RID: 42892
	private string WaitCameraId;

	// Token: 0x0400A78D RID: 42893
	private bool CanLoadModel;

	// Token: 0x0400A78E RID: 42894
	public SkeletalObserverHandle GliderObserver;

	// Token: 0x02009096 RID: 37014
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ED99 RID: 191897
		TopAndRightItem,
		// Token: 0x0402ED9A RID: 191898
		GridLayout,
		// Token: 0x0402ED9B RID: 191899
		GridItem,
		// Token: 0x0402ED9C RID: 191900
		SwitchShowToggle,
		// Token: 0x0402ED9D RID: 191901
		ConfirmBtnItem,
		// Token: 0x0402ED9E RID: 191902
		ObtainLayout,
		// Token: 0x0402ED9F RID: 191903
		ObtainItem,
		// Token: 0x0402EDA0 RID: 191904
		TitleText,
		// Token: 0x0402EDA1 RID: 191905
		SubTitleText,
		// Token: 0x0402EDA2 RID: 191906
		DescText,
		// Token: 0x0402EDA3 RID: 191907
		ApplyToAllToggle,
		// Token: 0x0402EDA4 RID: 191908
		ApplyToAllHelpBtn,
		// Token: 0x0402EDA5 RID: 191909
		ParaglidingTabItem,
		// Token: 0x0402EDA6 RID: 191910
		SoarWingTabItem,
		// Token: 0x0402EDA7 RID: 191911
		ConfirmBtnAndApplyItem
	}
}

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
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FCE RID: 8142
[NullableContext(1)]
[Nullable(0)]
public class FlySkinTabView : UiTabViewBase
{
	// Token: 0x06014340 RID: 82752 RVA: 0x005E44D8 File Offset: 0x005E26D8
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

	// Token: 0x06014341 RID: 82753 RVA: 0x005E4768 File Offset: 0x005E2968
	protected override UniTask OnBeforeStartAsync()
	{
		FlySkinTabView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FlySkinTabView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014342 RID: 82754 RVA: 0x005E47AC File Offset: 0x005E29AC
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

	// Token: 0x06014343 RID: 82755 RVA: 0x005E48FF File Offset: 0x005E2AFF
	protected override void OnBeforeDestroy()
	{
		this.FlySkinTabViewModel.UnBind(new Action<EFlySkinViewData>(this.OnViewModelUpdate));
		this.DestroyGliderObserver();
	}

	// Token: 0x06014344 RID: 82756 RVA: 0x005E4920 File Offset: 0x005E2B20
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

	// Token: 0x06014345 RID: 82757 RVA: 0x005E49BD File Offset: 0x005E2BBD
	protected override void OnAfterShow()
	{
		this.CanPushCamera = true;
		this.TryPushCamera();
		this.TryBindCameraInput();
	}

	// Token: 0x06014346 RID: 82758 RVA: 0x005E49D4 File Offset: 0x005E2BD4
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

	// Token: 0x06014347 RID: 82759 RVA: 0x005E4A46 File Offset: 0x005E2C46
	protected override void OnBeforeHide()
	{
		this.ResetAll();
	}

	// Token: 0x06014348 RID: 82760 RVA: 0x005E4A4E File Offset: 0x005E2C4E
	private void OnSkinRootViewDestroy()
	{
		this.ResetAll();
	}

	// Token: 0x06014349 RID: 82761 RVA: 0x005E4A56 File Offset: 0x005E2C56
	private void ResetAll()
	{
		this.WaitCameraId = null;
		this.CanLoadModel = false;
		this.CanPushCamera = false;
		this.HideModelWithEffect();
		this.RootViewModel.UnbindCameraInput();
	}

	// Token: 0x0601434A RID: 82762 RVA: 0x005E4A80 File Offset: 0x005E2C80
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

	// Token: 0x0601434B RID: 82763 RVA: 0x005E4B54 File Offset: 0x005E2D54
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

	// Token: 0x0601434C RID: 82764 RVA: 0x005E4C28 File Offset: 0x005E2E28
	private void InitGliderObserver()
	{
		UiSceneManager.Instance.InitGliderSkeletalHandle();
		SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
		gliderSkeletalHandle.Model.CheckGetComponent<UiModelActorComponent>().SetTransformByTag(FlySkinDefine.DEFAULT_FLY_SKIN_CASE);
		this.GliderObserver = gliderSkeletalHandle;
	}

	// Token: 0x0601434D RID: 82765 RVA: 0x005E4C66 File Offset: 0x005E2E66
	private void DestroyGliderObserver()
	{
		UiSceneManager.Instance.DestroyGliderSkeletalHandle();
		this.GliderObserver = null;
	}

	// Token: 0x0601434E RID: 82766 RVA: 0x005E4C79 File Offset: 0x005E2E79
	public void UpdateView(UpdateViewContext context)
	{
		this.UpdateIsApplyToAll(context.IsApplyToAll);
		this.UpdateUiShowState(context.UiShowState, false);
		this.SelectTab(context.Tab, context.SelectedSkinId);
	}

	// Token: 0x0601434F RID: 82767 RVA: 0x005E4CA8 File Offset: 0x005E2EA8
	public void SelectTab(EFlySkinTab tab, int skinId)
	{
		FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
		flySkinTabViewModel.SelectTab(tab);
		flySkinTabViewModel.SelectGridByIndex(this.FlySkinTabViewModel.GetGridIndexBySkinId(skinId).GetValueOrDefault());
	}

	// Token: 0x06014350 RID: 82768 RVA: 0x005E4CDB File Offset: 0x005E2EDB
	public void SelectGridByIndex(int gridIndex)
	{
		this.FlySkinTabViewModel.SelectGridByIndex(gridIndex);
		this.GridLayout.SelectGridProxy(gridIndex, false);
		this.OnGridSelected();
	}

	// Token: 0x06014351 RID: 82769 RVA: 0x005E4CFC File Offset: 0x005E2EFC
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

	// Token: 0x06014352 RID: 82770 RVA: 0x005E4DA8 File Offset: 0x005E2FA8
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

	// Token: 0x06014353 RID: 82771 RVA: 0x005E4EB8 File Offset: 0x005E30B8
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
		if (state)
		{
			this.RootViewModel.UnbindCameraInput();
		}
		else
		{
			this.RootViewModel.BindCameraInput();
		}
		if (state && resetCamera)
		{
			this.TryPushCamera();
		}
	}

	// Token: 0x06014354 RID: 82772 RVA: 0x005E4F3C File Offset: 0x005E313C
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

	// Token: 0x06014355 RID: 82773 RVA: 0x005E4F74 File Offset: 0x005E3174
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

	// Token: 0x06014356 RID: 82774 RVA: 0x005E5018 File Offset: 0x005E3218
	private void TryPushCamera()
	{
		if (!this.CanPushCamera)
		{
			return;
		}
		string flySkinModelCameraId = SkinConfig.Instance.GetFlySkinModelCameraId(this.FlySkinTabViewModel.SelectedFlySkinType);
		this.WaitCameraId = flySkinModelCameraId;
		UiCameraModel.Instance.PushCameraHandleByHandleName(flySkinModelCameraId, true, true, "10010", false, null);
	}

	// Token: 0x06014357 RID: 82775 RVA: 0x005E5060 File Offset: 0x005E3260
	private void TryBindCameraInput()
	{
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		if (((gliderObserver != null) ? gliderObserver.Model : null) == null)
		{
			return;
		}
		UiCameraInputBindingData flySkinTabCameraInputData = this.FlySkinTabViewModel.GetFlySkinTabCameraInputData(this.RootViewModel.GetDragItem());
		this.RootViewModel.ConfigureCameraInput(flySkinTabCameraInputData);
		this.RootViewModel.BindCameraInput();
	}

	// Token: 0x06014358 RID: 82776 RVA: 0x005E50B0 File Offset: 0x005E32B0
	public void ChangeSelectedTab(EFlySkinTab tab)
	{
		int roleEquipFlySkinId = FlySkinModel.Instance.GetRoleEquipFlySkinId(this.FlySkinTabViewModel.RoleDataId, FlySkinDefine.flySkinTabToType[tab]);
		this.SelectTab(tab, roleEquipFlySkinId);
	}

	// Token: 0x06014359 RID: 82777 RVA: 0x005E50E8 File Offset: 0x005E32E8
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

	// Token: 0x0601435A RID: 82778 RVA: 0x005E516D File Offset: 0x005E336D
	private void OnParaglidingTabToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ChangeSelectedTab(EFlySkinTab.ParaglidingTab);
			this.LastClickTimeStamp = Time.Instance.Now;
		}
	}

	// Token: 0x0601435B RID: 82779 RVA: 0x005E518A File Offset: 0x005E338A
	private void OnSoarWingTabToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ChangeSelectedTab(EFlySkinTab.SoarWingTab);
			this.LastClickTimeStamp = Time.Instance.Now;
		}
	}

	// Token: 0x0601435C RID: 82780 RVA: 0x005E51A7 File Offset: 0x005E33A7
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

	// Token: 0x0601435D RID: 82781 RVA: 0x005E51C1 File Offset: 0x005E33C1
	private void OnSwitchShowToggleStateChange(EToggleState state)
	{
		this.UpdateUiShowState(state == EToggleState.ETT_Checked, true);
	}

	// Token: 0x0601435E RID: 82782 RVA: 0x005E51CE File Offset: 0x005E33CE
	private void OnApplyToAllToggleStateChange(EToggleState state)
	{
		this.UpdateIsApplyToAll(state == EToggleState.ETT_Checked);
		this.RefreshConfirmBtnState();
	}

	// Token: 0x0601435F RID: 82783 RVA: 0x005E51E0 File Offset: 0x005E33E0
	private FlySkinGridItem InitGridItem()
	{
		FlySkinGridItem flySkinGridItem = new FlySkinGridItem();
		flySkinGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.GridItemClick));
		flySkinGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.GridItemCanExecuteChange));
		return flySkinGridItem;
	}

	// Token: 0x06014360 RID: 82784 RVA: 0x005E520C File Offset: 0x005E340C
	private void GridItemClick(MediumItemGridExtendCallback parameters)
	{
		int skinId = (parameters.Data as FlySkinGridData).SkinId;
		int? gridIndexBySkinId = this.FlySkinTabViewModel.GetGridIndexBySkinId(skinId);
		if (gridIndexBySkinId != null)
		{
			this.SelectGridByIndex(gridIndexBySkinId.Value);
		}
	}

	// Token: 0x06014361 RID: 82785 RVA: 0x005E5250 File Offset: 0x005E3450
	private bool GridItemCanExecuteChange(object parameters, bool result, EToggleState state)
	{
		int skinId = (parameters as FlySkinGridData).SkinId;
		return this.FlySkinTabViewModel.SelectedFlySkinId != skinId;
	}

	// Token: 0x06014362 RID: 82786 RVA: 0x005E527A File Offset: 0x005E347A
	private FlySkinObtainItem InitObtainItem()
	{
		return new FlySkinObtainItem();
	}

	// Token: 0x06014363 RID: 82787 RVA: 0x005E5284 File Offset: 0x005E3484
	private void OnApplyToAllHelpBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FlySkinApplyHelp);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06014364 RID: 82788 RVA: 0x005E52A8 File Offset: 0x005E34A8
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

	// Token: 0x06014365 RID: 82789 RVA: 0x005E5360 File Offset: 0x005E3560
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

	// Token: 0x06014366 RID: 82790 RVA: 0x005E53E3 File Offset: 0x005E35E3
	private void OnEquipSuccess()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("FlySkinReplaceTip", Array.Empty<object>());
		this.UpdateIsApplyToAll(false);
		this.RefreshConfirmBtnState();
	}

	// Token: 0x06014367 RID: 82791 RVA: 0x005E5406 File Offset: 0x005E3606
	private void OnFlySkinEquipResponse(int roleDataId, int skinId)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x06014368 RID: 82792 RVA: 0x005E540E File Offset: 0x005E360E
	private void OnFlySkinUnLoadResponse(int roleDataId, int skinId)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x06014369 RID: 82793 RVA: 0x005E5416 File Offset: 0x005E3616
	private void OnFlySkinEquipToAllRoleResponse(IReadOnlyList<RoleFlySkinChange> skinChanges)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x0601436A RID: 82794 RVA: 0x005E541E File Offset: 0x005E361E
	private void OnFlySkinAllUnLoadResponse(EFlySkinType skinType)
	{
		this.OnEquipSuccess();
	}

	// Token: 0x0601436B RID: 82795 RVA: 0x005E5426 File Offset: 0x005E3626
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetHandleName() == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
				this.TryLoadModel();
			}
		}
	}

	// Token: 0x0601436C RID: 82796 RVA: 0x005E5458 File Offset: 0x005E3658
	private void OnViewModelUpdate(EFlySkinViewData data)
	{
		if (data == EFlySkinViewData.SelectedGridIndex)
		{
			FlySkinTabViewModel flySkinTabViewModel = this.FlySkinTabViewModel;
			this.GridLayout.RefreshByData(flySkinTabViewModel.GetGridDataList(), delegate
			{
				this.GridLayout.SelectGridProxy(flySkinTabViewModel.GetSelectedGridIndex(), false);
			}, false);
			this.OnGridSelected();
			this.TryPushCamera();
			this.TryBindCameraInput();
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

	// Token: 0x0400AB86 RID: 43910
	private SkinRootViewModel RootViewModel;

	// Token: 0x0400AB87 RID: 43911
	private FlySkinTabViewModel FlySkinTabViewModel;

	// Token: 0x0400AB88 RID: 43912
	protected GenericLayout<FlySkinGridItem, FlySkinGridData> GridLayout;

	// Token: 0x0400AB89 RID: 43913
	protected GenericLayout<FlySkinObtainItem, IFlySkinGetWayData> ObtainLayout;

	// Token: 0x0400AB8A RID: 43914
	private ButtonItem ConfirmBtnItem;

	// Token: 0x0400AB8B RID: 43915
	private FlySkinChildTabItem ParaglidingTabItem;

	// Token: 0x0400AB8C RID: 43916
	private FlySkinChildTabItem SoarWingTabItem;

	// Token: 0x0400AB8D RID: 43917
	private FlySkinChildTabItem SelectedTabItem;

	// Token: 0x0400AB8E RID: 43918
	private double LastClickTimeStamp;

	// Token: 0x0400AB8F RID: 43919
	private bool CanPushCamera;

	// Token: 0x0400AB90 RID: 43920
	private string WaitCameraId;

	// Token: 0x0400AB91 RID: 43921
	private bool CanLoadModel;

	// Token: 0x0400AB92 RID: 43922
	public SkeletalObserverHandle GliderObserver;

	// Token: 0x020082DD RID: 33501
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A493 RID: 173203
		TopAndRightItem,
		// Token: 0x0402A494 RID: 173204
		GridLayout,
		// Token: 0x0402A495 RID: 173205
		GridItem,
		// Token: 0x0402A496 RID: 173206
		SwitchShowToggle,
		// Token: 0x0402A497 RID: 173207
		ConfirmBtnItem,
		// Token: 0x0402A498 RID: 173208
		ObtainLayout,
		// Token: 0x0402A499 RID: 173209
		ObtainItem,
		// Token: 0x0402A49A RID: 173210
		TitleText,
		// Token: 0x0402A49B RID: 173211
		SubTitleText,
		// Token: 0x0402A49C RID: 173212
		DescText,
		// Token: 0x0402A49D RID: 173213
		ApplyToAllToggle,
		// Token: 0x0402A49E RID: 173214
		ApplyToAllHelpBtn,
		// Token: 0x0402A49F RID: 173215
		ParaglidingTabItem,
		// Token: 0x0402A4A0 RID: 173216
		SoarWingTabItem,
		// Token: 0x0402A4A1 RID: 173217
		ConfirmBtnAndApplyItem
	}
}

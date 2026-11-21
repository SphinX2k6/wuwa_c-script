using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016E9 RID: 5865
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FilterSettingController : UiControllerBase
{
	// Token: 0x170015BA RID: 5562
	// (get) Token: 0x0600E38E RID: 58254 RVA: 0x0042B958 File Offset: 0x00429B58
	private float DeadZone
	{
		get
		{
			return ConfigCommonParamById.GetFloatConfig("FilterSettingLeftStickDeadZone").GetValueOrDefault();
		}
	}

	// Token: 0x170015BB RID: 5563
	// (get) Token: 0x0600E38F RID: 58255 RVA: 0x0042B978 File Offset: 0x00429B78
	private float MoveFactor
	{
		get
		{
			return ConfigCommonParamById.GetFloatConfig("FilterSettingLeftStickMoveFactor").GetValueOrDefault(1f);
		}
	}

	// Token: 0x0600E390 RID: 58256 RVA: 0x0042B99C File Offset: 0x00429B9C
	public override bool Clear()
	{
		FilterCameraComponent cameraComponent = this.CameraComponent;
		if (cameraComponent != null)
		{
			cameraComponent.ClosePhotograph();
		}
		return base.Clear();
	}

	// Token: 0x0600E391 RID: 58257 RVA: 0x0042B9B5 File Offset: 0x00429BB5
	protected override bool OnLeaveLevel()
	{
		FilterCameraComponent cameraComponent = this.CameraComponent;
		if (cameraComponent != null)
		{
			cameraComponent.ClosePhotograph();
		}
		this.SwitchFilter(true);
		return true;
	}

	// Token: 0x0600E392 RID: 58258 RVA: 0x0042B9D0 File Offset: 0x00429BD0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
		EventSystem.Instance.Add(EEventName.UiSceneLastStepInLoadScene, new Action(this.HandleUiSceneLastStepInLoadScene));
		EventSystem.Instance.Add(EEventName.UiSceneLastStepInExitScene, new Action(this.HandleUiSceneLastStepInExitScene));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(this.HandleBackLoginView));
		EventSystem.Instance.Add(EEventName.OnExecuteAfterSetPlotMode, new Action(this.HandlePlotNetworkStart));
		EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.HandlePlotNetworkEnd));
	}

	// Token: 0x0600E393 RID: 58259 RVA: 0x0042BA80 File Offset: 0x00429C80
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
		EventSystem.Instance.Remove(EEventName.UiSceneLastStepInLoadScene, new Action(this.HandleUiSceneLastStepInLoadScene));
		EventSystem.Instance.Remove(EEventName.UiSceneLastStepInExitScene, new Action(this.HandleUiSceneLastStepInExitScene));
		EventSystem.Instance.Remove(EEventName.LogOut, new Action(this.HandleBackLoginView));
		EventSystem.Instance.Remove(EEventName.OnExecuteAfterSetPlotMode, new Action(this.HandlePlotNetworkStart));
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.HandlePlotNetworkEnd));
		if (this.CameraComponent != null)
		{
			this.CameraComponent.RemoveEntityEvents();
		}
	}

	// Token: 0x0600E394 RID: 58260 RVA: 0x0042BB40 File Offset: 0x00429D40
	private void OnRoleDead(int charId)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.FilterSettingView))
		{
			UiManager.Instance.CloseView(EUiViewName.FilterSettingView, null);
		}
	}

	// Token: 0x0600E395 RID: 58261 RVA: 0x0042BB63 File Offset: 0x00429D63
	private void HandlePlotNetworkStart()
	{
		if (PlotModel.Instance.IsInOverLevel(EPlotLevel.LevelC))
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 1", null);
		}
	}

	// Token: 0x0600E396 RID: 58262 RVA: 0x0042BBA2 File Offset: 0x00429DA2
	private void HandlePlotNetworkEnd(PlotResultInfo plotResultInfo)
	{
		if (PlotModel.Instance.IsInOverLevel(EPlotLevel.LevelC))
		{
			this.SwitchFilter(true);
		}
	}

	// Token: 0x0600E397 RID: 58263 RVA: 0x0042BBB8 File Offset: 0x00429DB8
	private void HandleUiSceneLastStepInLoadScene()
	{
		this.DisableFilterTemporarily(true);
	}

	// Token: 0x0600E398 RID: 58264 RVA: 0x0042BBC1 File Offset: 0x00429DC1
	private void HandleUiSceneLastStepInExitScene()
	{
		this.DisableFilterTemporarily(false);
	}

	// Token: 0x0600E399 RID: 58265 RVA: 0x0042BBCA File Offset: 0x00429DCA
	private void HandleBackLoginView()
	{
		this.SwitchFilter(false);
	}

	// Token: 0x0600E39A RID: 58266 RVA: 0x0042BBD4 File Offset: 0x00429DD4
	[NullableContext(0)]
	public UniTask<bool> TryOpenExternalPreparedAsync()
	{
		FilterSettingController.<TryOpenExternalPreparedAsync>d__16 <TryOpenExternalPreparedAsync>d__;
		<TryOpenExternalPreparedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<TryOpenExternalPreparedAsync>d__.<>4__this = this;
		<TryOpenExternalPreparedAsync>d__.<>1__state = -1;
		<TryOpenExternalPreparedAsync>d__.<>t__builder.Start<FilterSettingController.<TryOpenExternalPreparedAsync>d__16>(ref <TryOpenExternalPreparedAsync>d__);
		return <TryOpenExternalPreparedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E39B RID: 58267 RVA: 0x0042BC18 File Offset: 0x00429E18
	[NullableContext(0)]
	private UniTask<bool> OpenFilterSettingView()
	{
		FilterSettingController.<OpenFilterSettingView>d__17 <OpenFilterSettingView>d__;
		<OpenFilterSettingView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenFilterSettingView>d__.<>4__this = this;
		<OpenFilterSettingView>d__.<>1__state = -1;
		<OpenFilterSettingView>d__.<>t__builder.Start<FilterSettingController.<OpenFilterSettingView>d__17>(ref <OpenFilterSettingView>d__);
		return <OpenFilterSettingView>d__.<>t__builder.Task;
	}

	// Token: 0x0600E39C RID: 58268 RVA: 0x0042BC5B File Offset: 0x00429E5B
	public FilterSettingViewModel CreatePhotoFilterViewModel()
	{
		this.ViewModel = this.BuildFilterSettingViewModel();
		this.ViewModel.OnIndexChanged = delegate(int filterId)
		{
			this.RefreshFilterSettingViewModel(filterId, this.ViewModel);
		};
		return this.ViewModel;
	}

	// Token: 0x0600E39D RID: 58269 RVA: 0x0042BC88 File Offset: 0x00429E88
	private FilterSettingViewModel BuildFilterSettingViewModel()
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		FilterSettingViewModel viewModel = new FilterSettingViewModel();
		viewModel.InitFilterIndex = MenuModel.Instance.GetFilterIndexByConfigId(filterSettingIdCache);
		this.RefreshFilterSettingViewModel(filterSettingIdCache, viewModel);
		viewModel.OnHideClick = delegate()
		{
			viewModel.IsHideByClick = !viewModel.IsHideByClick;
		};
		viewModel.OnResetClick = delegate()
		{
			bool flag = this.ResetFilterPoint(viewModel);
			bool flag2 = this.ResetFilterIntensity(viewModel);
			bool flag3 = this.ResetFilterSeniorParams(viewModel);
			if (flag || flag2 || flag3)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFilterFeatureResetTips", Array.Empty<object>());
			}
		};
		viewModel.OnResetAllSeniorParamClick = delegate()
		{
			this.ResetFilterSeniorParams(viewModel);
		};
		viewModel.OnResetPointClick = delegate()
		{
			this.ResetFilterPoint(viewModel);
		};
		viewModel.OnResetSingleParamClick = delegate(EFilterSettingValueIndex paramIndex)
		{
			int filterSettingIdCache2 = MenuModel.Instance.FilterSettingIdCache;
			Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
			float[] array;
			if (filterSettingValuesCache == null || !filterSettingValuesCache.TryGetValue(filterSettingIdCache2, out array) || array == null)
			{
				return;
			}
			float filterDefaultValue = this.GetFilterDefaultValue(filterSettingIdCache2, paramIndex);
			array[(int)paramIndex] = filterDefaultValue;
			if (paramIndex == EFilterSettingValueIndex.Intensity)
			{
				viewModel.IntensityNormalized = filterDefaultValue;
			}
			this.SetFilterValueImp(viewModel, filterSettingIdCache2, array[0], array[1], array[2]);
			viewModel.IsFilterChanged = true;
		};
		viewModel.OnConfirmClick = delegate()
		{
			LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.FilterSettingId, MenuModel.Instance.FilterSettingIdCache);
			LocalStorage.SetGlobal<Dictionary<int, float[]>>(ELocalStorageGlobalKey.FilterSettingValues, MenuModel.Instance.FilterSettingValuesCache);
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFilterFeatureUseTips", Array.Empty<object>());
			viewModel.IsApplyClicked = true;
			MenuModel.Instance.IsEdited = true;
		};
		Action <>9__26;
		viewModel.OnCloseClick = delegate()
		{
			if (viewModel.IsFilterChanged && !viewModel.IsApplyClicked)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FilterSettingChangingConfirm);
				Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
				int key = 2;
				Action value;
				if ((value = <>9__26) == null)
				{
					value = (<>9__26 = delegate()
					{
						this.CloseViewAndReturnWorld().Forget();
					});
				}
				functionMap.Add(key, value);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.CloseViewAndReturnWorld().Forget();
		};
		viewModel.OnPadChanged = delegate()
		{
			if (viewModel.PadLock)
			{
				return;
			}
			int filterSettingIdCache2 = MenuModel.Instance.FilterSettingIdCache;
			Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
			float[] array;
			if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterSettingIdCache2, out array) && array != null)
			{
				array[0] = viewModel.HorizontalNormalized;
				array[1] = viewModel.VerticalNormalized;
				this.SetFilterValueImp(viewModel, filterSettingIdCache2, array[0], array[1], array[2]);
				viewModel.IsHideByPad = true;
				viewModel.IsFilterChanged = true;
			}
		};
		viewModel.OnPadChangeStop = delegate()
		{
			if (Info.Instance.IsInGamepad())
			{
				return;
			}
			viewModel.IsHideByPad = false;
		};
		viewModel.OnSliderChanged = delegate()
		{
			int filterSettingIdCache2 = MenuModel.Instance.FilterSettingIdCache;
			Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
			float[] array;
			if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterSettingIdCache2, out array) && array != null)
			{
				array[2] = viewModel.IntensityNormalized;
				this.SetFilterValueImp(viewModel, filterSettingIdCache2, array[0], array[1], array[2]);
				viewModel.IsFilterChanged = true;
			}
		};
		viewModel.OnSeniorSliderChanged = delegate(EFilterSettingValueIndex param, float value)
		{
			int filterSettingIdCache2 = MenuModel.Instance.FilterSettingIdCache;
			Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
			float[] array;
			if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterSettingIdCache2, out array) && array != null)
			{
				array[(int)param] = value;
				this.SetFilterAllValueImp(viewModel, filterSettingIdCache2, array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12]);
				viewModel.IsFilterChanged = true;
			}
		};
		viewModel.OnViewBeforeCreate = delegate()
		{
		};
		viewModel.OnViewBeforeStart = delegate()
		{
		};
		viewModel.OnViewBeforeShow = delegate(string tag)
		{
		};
		viewModel.OnViewAfterHide = delegate(string tag)
		{
		};
		viewModel.OnViewDestroy = delegate()
		{
			MenuModel.Instance.CleanFilterCache();
		};
		viewModel.OnDragBegin = delegate()
		{
			FilterCameraComponent cameraComponent = this.CameraComponent;
			if (cameraComponent == null)
			{
				return;
			}
			cameraComponent.OnDragBegin();
		};
		viewModel.OnDragEnded = delegate()
		{
			FilterCameraComponent cameraComponent = this.CameraComponent;
			if (cameraComponent == null)
			{
				return;
			}
			cameraComponent.OnDragEnded();
		};
		viewModel.OnDragMoved = delegate(ULGUIPointerEventData eventData)
		{
			FilterCameraComponent cameraComponent = this.CameraComponent;
			if (cameraComponent == null)
			{
				return;
			}
			cameraComponent.OnDragMoved(eventData);
		};
		viewModel.OnInputUiMoveForward = delegate(string axisName, float value)
		{
			if (!Info.Instance.IsInGamepad() || MathUtils.Instance.InRangeArray((double)value, new double[]
			{
				(double)(-(double)this.DeadZone),
				(double)this.DeadZone
			}) || viewModel.VerticalReal == null || viewModel.IsHideByClick || viewModel.IsOtherViewOpen)
			{
				viewModel.IsLeftStickVerticalMoved = false;
				viewModel.IsHideByPad = viewModel.IsLeftStickHorizontalMoved;
				return;
			}
			viewModel.VerticalReal += value * this.MoveFactor;
			int filterSettingIdCache2 = MenuModel.Instance.FilterSettingIdCache;
			Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
			float[] array;
			if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterSettingIdCache2, out array) && array != null)
			{
				array[1] = viewModel.VerticalNormalized;
				this.SetFilterValueImp(viewModel, filterSettingIdCache2, array[0], array[1], array[2]);
				viewModel.IsFilterChanged = true;
			}
			viewModel.IsHideByPad = true;
			viewModel.IsLeftStickVerticalMoved = true;
		};
		viewModel.OnInputUiMoveRight = delegate(string axisName, float value)
		{
			if (!Info.Instance.IsInGamepad() || MathUtils.Instance.InRangeArray((double)value, new double[]
			{
				(double)(-(double)this.DeadZone),
				(double)this.DeadZone
			}) || viewModel.HorizontalReal == null || viewModel.IsHideByClick || viewModel.IsOtherViewOpen)
			{
				viewModel.IsLeftStickHorizontalMoved = false;
				viewModel.IsHideByPad = viewModel.IsLeftStickVerticalMoved;
				return;
			}
			viewModel.HorizontalReal += value * this.MoveFactor;
			int filterSettingIdCache2 = MenuModel.Instance.FilterSettingIdCache;
			Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
			float[] array;
			if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterSettingIdCache2, out array) && array != null)
			{
				array[0] = viewModel.HorizontalNormalized;
				this.SetFilterValueImp(viewModel, filterSettingIdCache2, array[0], array[1], array[2]);
				viewModel.IsFilterChanged = true;
			}
			viewModel.IsHideByPad = true;
			viewModel.IsLeftStickHorizontalMoved = true;
		};
		viewModel.OnInputUiLookUp = delegate(string axisName, float value)
		{
			FilterCameraComponent cameraComponent = this.CameraComponent;
			if (cameraComponent == null)
			{
				return;
			}
			cameraComponent.OnInputUiLookUp(axisName, value);
		};
		viewModel.OnInputUiTurn = delegate(string axisName, float value)
		{
			FilterCameraComponent cameraComponent = this.CameraComponent;
			if (cameraComponent == null)
			{
				return;
			}
			cameraComponent.OnInputUiTurn(axisName, value);
		};
		viewModel.OnIndexChanged = delegate(int index)
		{
			int filterConfigIdByIndex = MenuModel.Instance.GetFilterConfigIdByIndex(index);
			this.RefreshFilterSettingViewModel(filterConfigIdByIndex, viewModel);
		};
		viewModel.OnLeftArrowClick = delegate()
		{
			viewModel.IsFilterChanged = true;
		};
		viewModel.OnRightArrowClick = delegate()
		{
			viewModel.IsFilterChanged = true;
		};
		return viewModel;
	}

	// Token: 0x0600E39E RID: 58270 RVA: 0x0042BF98 File Offset: 0x0042A198
	private bool ResetFilterPoint(FilterSettingViewModel viewModel)
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		float[] array;
		if (filterSettingValuesCache == null || !filterSettingValuesCache.TryGetValue(filterSettingIdCache, out array) || array == null)
		{
			return false;
		}
		array[0] = this.GetFilterDefaultValue(filterSettingIdCache, EFilterSettingValueIndex.Horizontal);
		array[1] = this.GetFilterDefaultValue(filterSettingIdCache, EFilterSettingValueIndex.Vertical);
		viewModel.HorizontalNormalized = array[0];
		viewModel.VerticalNormalized = array[1];
		this.SetFilterValueImp(viewModel, filterSettingIdCache, array[0], array[1], array[2]);
		viewModel.IsFilterChanged = true;
		return true;
	}

	// Token: 0x0600E39F RID: 58271 RVA: 0x0042C010 File Offset: 0x0042A210
	private bool ResetFilterIntensity(FilterSettingViewModel viewModel)
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		float[] array;
		if (filterSettingValuesCache == null || !filterSettingValuesCache.TryGetValue(filterSettingIdCache, out array) || array == null)
		{
			return false;
		}
		array[2] = this.GetFilterDefaultValue(filterSettingIdCache, EFilterSettingValueIndex.Intensity);
		viewModel.IntensityNormalized = array[2];
		this.SetFilterValueImp(viewModel, filterSettingIdCache, array[0], array[1], array[2]);
		viewModel.IsFilterChanged = true;
		return true;
	}

	// Token: 0x0600E3A0 RID: 58272 RVA: 0x0042C074 File Offset: 0x0042A274
	private bool ResetFilterSeniorParams(FilterSettingViewModel viewModel)
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		float[] array;
		if (filterSettingValuesCache == null || !filterSettingValuesCache.TryGetValue(filterSettingIdCache, out array) || array == null)
		{
			return false;
		}
		for (int i = 0; i < array.Length; i++)
		{
			EFilterSettingValueIndex efilterSettingValueIndex = (EFilterSettingValueIndex)i;
			if (efilterSettingValueIndex > EFilterSettingValueIndex.Intensity)
			{
				array[i] = this.GetFilterDefaultValue(filterSettingIdCache, efilterSettingValueIndex);
			}
		}
		viewModel.IsSeniorParamRefresh = true;
		this.SetFilterAllValueImp(viewModel, filterSettingIdCache, array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12]);
		viewModel.IsFilterChanged = true;
		return true;
	}

	// Token: 0x0600E3A1 RID: 58273 RVA: 0x0042C110 File Offset: 0x0042A310
	public bool IsFilterParamChanged(EFilterSettingValueIndex typeIndex)
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		float[] array;
		return filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterSettingIdCache, out array) && array != null && typeIndex < (EFilterSettingValueIndex)array.Length && !MathUtils.Instance.IsNearlyEqual((double)array[(int)typeIndex], (double)this.GetFilterDefaultValue(filterSettingIdCache, typeIndex), null);
	}

	// Token: 0x0600E3A2 RID: 58274 RVA: 0x0042C172 File Offset: 0x0042A372
	public bool IsFilterPointChanged()
	{
		return this.IsFilterParamChanged(EFilterSettingValueIndex.Horizontal) || this.IsFilterParamChanged(EFilterSettingValueIndex.Vertical);
	}

	// Token: 0x0600E3A3 RID: 58275 RVA: 0x0042C188 File Offset: 0x0042A388
	public bool IsAnySeniorParamChanged()
	{
		int filterSettingIdCache = MenuModel.Instance.FilterSettingIdCache;
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		float[] array;
		if (filterSettingValuesCache == null || !filterSettingValuesCache.TryGetValue(filterSettingIdCache, out array) || array == null)
		{
			return false;
		}
		for (int i = 0; i < array.Length; i++)
		{
			EFilterSettingValueIndex efilterSettingValueIndex = (EFilterSettingValueIndex)i;
			if (efilterSettingValueIndex > EFilterSettingValueIndex.Intensity && this.IsFilterParamChanged(efilterSettingValueIndex))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E3A4 RID: 58276 RVA: 0x0042C1E4 File Offset: 0x0042A3E4
	private void RefreshFilterSettingViewModel(int filterId, FilterSettingViewModel viewModel)
	{
		MenuModel.Instance.FilterSettingIdCache = filterId;
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		if (ConfigFilterSettingAll.GetConfigList(true) == null)
		{
			return;
		}
		float[] array;
		if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterId, out array) && array != null)
		{
			viewModel.IntensityNormalized = array[2];
			viewModel.HorizontalNormalized = array[0];
			viewModel.VerticalNormalized = array[1];
			this.SetFilterValueImp(viewModel, filterId, array[0], array[1], array[2]);
		}
		FilterSetting? config = ConfigFilterSettingById.GetConfig(filterId, true);
		viewModel.FilterPadTexturePath = ((config != null) ? config.GetValueOrDefault().PadTexturePath : null);
		viewModel.FilterNameTextId = ((config != null) ? config.GetValueOrDefault().NameTextId : null);
		viewModel.IsSliderActive = (filterId != 1);
		viewModel.IsSeniorParamRefresh = true;
	}

	// Token: 0x0600E3A5 RID: 58277 RVA: 0x0042C2AC File Offset: 0x0042A4AC
	public void ApplyFilterSetting()
	{
		int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.FilterSettingId, 1);
		Dictionary<int, float[]> global2 = LocalStorage.GetGlobal<Dictionary<int, float[]>>(ELocalStorageGlobalKey.FilterSettingValues, null);
		float[] array;
		if (global2 != null && global2.TryGetValue(global, out array) && array != null)
		{
			UKuroGISystem.SetKuroAdvancedModeScreenFilter(GlobalData.World, ConfigFilterSettingById.GetConfig(global, true).Value.LogicIndex, array[0], array[1], array[2], (array.Length > 3) ? array[3] : 0f, (array.Length > 3) ? array[4] : 0f, (array.Length > 3) ? array[5] : 0f, (array.Length > 3) ? array[6] : 0f, (array.Length > 3) ? array[7] : 0f, (array.Length > 3) ? array[8] : 0f, (array.Length > 3) ? array[9] : 0f, (array.Length > 3) ? array[10] : 0f, (array.Length > 3) ? array[11] : 0f, (array.Length > 3) ? array[12] : 0f);
			return;
		}
		this.SetDefaultFilterSetting();
	}

	// Token: 0x0600E3A6 RID: 58278 RVA: 0x0042C3C4 File Offset: 0x0042A5C4
	public void SetDefaultFilterSetting()
	{
		UKuroGISystem.SetKuroAdvancedModeScreenFilter(GlobalData.World, ConfigFilterSettingById.GetConfig(1, true).Value.LogicIndex, 0.5f, 0.5f, 1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
	}

	// Token: 0x0600E3A7 RID: 58279 RVA: 0x0042C434 File Offset: 0x0042A634
	private void SetFilterValueImp(FilterSettingViewModel viewModel, int filterId, float horizontalNormalized, float verticalNormalized, float intensityNormalized)
	{
		Dictionary<int, float[]> filterSettingValuesCache = MenuModel.Instance.FilterSettingValuesCache;
		float[] array;
		if (filterSettingValuesCache != null && filterSettingValuesCache.TryGetValue(filterId, out array) && array != null)
		{
			this.SetFilterAllValueImp(viewModel, filterId, horizontalNormalized, verticalNormalized, intensityNormalized, array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12]);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "未找到当前滤镜id相关的参数值";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("filterId", filterId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600E3A8 RID: 58280 RVA: 0x0042C4BC File Offset: 0x0042A6BC
	private unsafe void SetFilterAllValueImp(FilterSettingViewModel viewModel, int filterId, float horizontalNormalized, float verticalNormalized, float intensityNormalized, float sharpenIntensity, float brightness, float contrast, float colorTemperature, float saturation, float bloom, float gamma, float shadowIntensity, float noiseIntensity, float halation)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "设置全局滤镜值";
		<>y__InlineArray14<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray14<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("filterId", filterId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("horizontalNormalized", horizontalNormalized);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("verticalNormalized", verticalNormalized);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("intensityNormalized", intensityNormalized);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("sharpenIntensity", sharpenIntensity);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("brightness", brightness);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("contrast", contrast);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("colorTemperature", colorTemperature);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("saturation", saturation);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("bloom", bloom);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("gamma", gamma);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("shadowIntensity", shadowIntensity);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("noiseIntensity", noiseIntensity);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 13) = new ValueTuple<string, object>("halation", halation);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray14<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 14));
		UKuroGISystem.SetKuroAdvancedModeScreenFilter(GlobalData.World, ConfigFilterSettingById.GetConfig(filterId, true).Value.LogicIndex, horizontalNormalized, verticalNormalized, intensityNormalized, sharpenIntensity, brightness, contrast, colorTemperature, saturation, bloom, gamma, shadowIntensity, noiseIntensity, halation);
	}

	// Token: 0x0600E3A9 RID: 58281 RVA: 0x0042C6D4 File Offset: 0x0042A8D4
	public UniTask CloseViewAndReturnWorld()
	{
		FilterSettingController.<CloseViewAndReturnWorld>d__31 <CloseViewAndReturnWorld>d__;
		<CloseViewAndReturnWorld>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseViewAndReturnWorld>d__.<>4__this = this;
		<CloseViewAndReturnWorld>d__.<>1__state = -1;
		<CloseViewAndReturnWorld>d__.<>t__builder.Start<FilterSettingController.<CloseViewAndReturnWorld>d__31>(ref <CloseViewAndReturnWorld>d__);
		return <CloseViewAndReturnWorld>d__.<>t__builder.Task;
	}

	// Token: 0x0600E3AA RID: 58282 RVA: 0x0042C718 File Offset: 0x0042A918
	public UniTask OpenBlackScreen()
	{
		FilterSettingController.<OpenBlackScreen>d__32 <OpenBlackScreen>d__;
		<OpenBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenBlackScreen>d__.<>1__state = -1;
		<OpenBlackScreen>d__.<>t__builder.Start<FilterSettingController.<OpenBlackScreen>d__32>(ref <OpenBlackScreen>d__);
		return <OpenBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x0600E3AB RID: 58283 RVA: 0x0042C754 File Offset: 0x0042A954
	public UniTask CloseBlackScreen()
	{
		FilterSettingController.<CloseBlackScreen>d__33 <CloseBlackScreen>d__;
		<CloseBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseBlackScreen>d__.<>1__state = -1;
		<CloseBlackScreen>d__.<>t__builder.Start<FilterSettingController.<CloseBlackScreen>d__33>(ref <CloseBlackScreen>d__);
		return <CloseBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x0600E3AC RID: 58284 RVA: 0x0042C78F File Offset: 0x0042A98F
	public float GetFilterDefaultValue(int filterId, EFilterSettingValueIndex typeIndex)
	{
		if (filterId == 1 && typeIndex == EFilterSettingValueIndex.Intensity)
		{
			return 1f;
		}
		if (typeIndex <= EFilterSettingValueIndex.Intensity)
		{
			return 0.5f;
		}
		return 0f;
	}

	// Token: 0x0600E3AD RID: 58285 RVA: 0x0042C7AE File Offset: 0x0042A9AE
	private void DisableFilterTemporarily(bool isEnter)
	{
		if (isEnter)
		{
			UKuroSequencePerformanceManager.ExecuteCommandInPerformance("r.Kuro.KuroEnableScreenFilter 0");
			UKuroSequencePerformanceManager.ExecuteCommandInPerformance("r.BlueLightFilter.Disable 1");
			UKuroSequencePerformanceManager.ExecuteCommandInPerformance("r.Tonemapper.BrightnessAndTextureDisable 1");
			return;
		}
		UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
	}

	// Token: 0x0600E3AE RID: 58286 RVA: 0x0042C7D8 File Offset: 0x0042A9D8
	public bool IsFilterSettingChange()
	{
		int? global = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.FilterSettingId, null);
		if (global != null)
		{
			int? num = global;
			int i = 0;
			if (!(num.GetValueOrDefault() == i & num != null))
			{
				if (global.GetValueOrDefault() != 1)
				{
					return true;
				}
				Dictionary<int, float[]> global2 = LocalStorage.GetGlobal<Dictionary<int, float[]>>(ELocalStorageGlobalKey.FilterSettingValues, null);
				if (global2 == null)
				{
					return false;
				}
				float[] array;
				if (!global2.TryGetValue(global.Value, out array) || array == null)
				{
					return false;
				}
				foreach (EFilterSettingValueIndex efilterSettingValueIndex in MenuDefine.filterSettingParams)
				{
					int num2 = (int)efilterSettingValueIndex;
					if (num2 < array.Length && array[num2] != 0f && array[num2] != this.GetFilterDefaultValue(global.Value, efilterSettingValueIndex))
					{
						return true;
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600E3AF RID: 58287 RVA: 0x0042C8A0 File Offset: 0x0042AAA0
	public void SwitchFilter(bool isOn)
	{
		if (isOn)
		{
			GameSettingsUtils.ApplyImageDisplayMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true));
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
	}

	// Token: 0x170015BC RID: 5564
	// (get) Token: 0x0600E3B0 RID: 58288 RVA: 0x0042C8CD File Offset: 0x0042AACD
	public static FilterSettingController Instance
	{
		get
		{
			return FilterSettingController._Instance;
		}
	}

	// Token: 0x0600E3B1 RID: 58289 RVA: 0x0042C8D4 File Offset: 0x0042AAD4
	public static FilterSettingController GetOrCreateInstance()
	{
		if (FilterSettingController._Instance == null)
		{
			FilterSettingController.CreateInstance();
		}
		return FilterSettingController._Instance;
	}

	// Token: 0x0600E3B2 RID: 58290 RVA: 0x0042C8E8 File Offset: 0x0042AAE8
	public static bool CreateInstance()
	{
		if (FilterSettingController._Instance != null)
		{
			return true;
		}
		FilterSettingController._Instance = new FilterSettingController();
		return true;
	}

	// Token: 0x0600E3B3 RID: 58291 RVA: 0x0042C8FE File Offset: 0x0042AAFE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E3B4 RID: 58292 RVA: 0x0042C900 File Offset: 0x0042AB00
	public static void ResetStaticDefaultValue()
	{
		FilterSettingController._Instance = null;
	}

	// Token: 0x0600E3B5 RID: 58293 RVA: 0x0042C908 File Offset: 0x0042AB08
	static FilterSettingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterSettingController.CreateStaticDefaultValue), new Action(FilterSettingController.ResetStaticDefaultValue));
	}

	// Token: 0x0400820C RID: 33292
	[Nullable(2)]
	public FilterCameraComponent CameraComponent;

	// Token: 0x0400820D RID: 33293
	[Nullable(2)]
	private FilterSettingViewModel ViewModel;

	// Token: 0x0400820E RID: 33294
	[Nullable(2)]
	private static FilterSettingController _Instance;
}

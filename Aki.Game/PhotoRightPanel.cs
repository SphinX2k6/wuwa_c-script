using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A66 RID: 6758
[NullableContext(1)]
[Nullable(0)]
public class PhotoRightPanel : UiPanelBase
{
	// Token: 0x06010B06 RID: 68358 RVA: 0x004E1A4C File Offset: 0x004DFC4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(11, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(12, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnChangeDroneModeStateChanged)),
			new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnStandStateChanged)),
			new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.OnSelfieStateChanged)),
			new ValueTuple<int, Delegate>(12, new Action<EToggleState>(this.OnHandheldStateChanged)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnCloseClick)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnPhotographClick)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnResetClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnVisibleClick))
		};
	}

	// Token: 0x06010B07 RID: 68359 RVA: 0x004E1C84 File Offset: 0x004DFE84
	protected override void OnStart()
	{
		base.GetExtendToggle(10).bLockStateOnSelect = true;
		base.GetExtendToggle(11).bLockStateOnSelect = true;
		base.GetExtendToggle(12).bLockStateOnSelect = true;
		base.GetSlider(0).OnValueChangeCb.Bind(new Action<float>(this.OnFovValueChanged));
		base.GetButton(2).OnPointDownCallBack.Bind(delegate()
		{
			this.ViewModel.FovInputValue = 0.1f;
		});
		base.GetButton(2).OnPointUpCallBack.Bind(new Action(this.OnFovButtonReleased));
		base.GetButton(2).OnPointCancelCallBack.Bind(new Action(this.OnFovButtonReleased));
		base.GetButton(3).OnPointDownCallBack.Bind(delegate()
		{
			this.ViewModel.FovInputValue = -0.1f;
		});
		base.GetButton(3).OnPointUpCallBack.Bind(new Action(this.OnFovButtonReleased));
		base.GetButton(3).OnPointCancelCallBack.Bind(new Action(this.OnFovButtonReleased));
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.SetModeChangedCallback(new Action(this.OnModeChanged));
		}
		this.SyncModeToggles(this.ViewModel.CurrentMode);
		this.InitFovSlider();
	}

	// Token: 0x06010B08 RID: 68360 RVA: 0x004E1DBC File Offset: 0x004DFFBC
	private void InitFovSlider()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		BP_PhotoCameraConfig_C bp_PhotoCameraConfig_C = (photoCamera != null) ? photoCamera.CurrentConfig : null;
		if (bp_PhotoCameraConfig_C == null)
		{
			return;
		}
		UUISliderComponent slider = base.GetSlider(0);
		slider.SetMinValue(bp_PhotoCameraConfig_C.CommonConfig.FovRange.X, false, false);
		slider.SetMaxValue(bp_PhotoCameraConfig_C.CommonConfig.FovRange.Y, false, false);
		slider.SetValue(this.ReverseFov(photoCamera.VirtualCamera.Fov), false);
		this.RefreshFovText(photoCamera.VirtualCamera.Fov);
	}

	// Token: 0x06010B09 RID: 68361 RVA: 0x004E1E40 File Offset: 0x004E0040
	private float ReverseFov(float value)
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		BP_PhotoCameraConfig_C bp_PhotoCameraConfig_C = (photoCamera != null) ? photoCamera.CurrentConfig : null;
		if (bp_PhotoCameraConfig_C == null)
		{
			return value;
		}
		return PhotoCameraUtil.ReverseFovByRange(value, bp_PhotoCameraConfig_C.CommonConfig.FovRange.X, bp_PhotoCameraConfig_C.CommonConfig.FovRange.Y);
	}

	// Token: 0x06010B0A RID: 68362 RVA: 0x004E1E8C File Offset: 0x004E008C
	private void RefreshFovText(float fov)
	{
		base.GetText(1).SetText(Math.Round((double)fov).ToString(), true);
	}

	// Token: 0x06010B0B RID: 68363 RVA: 0x004E1EB8 File Offset: 0x004E00B8
	protected override void OnBeforeDestroy()
	{
		UiLayer.Instance.SetShowMaskLayer("PhotoCameraModeSwitch", false);
		base.GetSlider(0).OnValueChangeCb.Unbind();
		base.GetButton(2).OnPointDownCallBack.Unbind();
		base.GetButton(2).OnPointUpCallBack.Unbind();
		base.GetButton(2).OnPointCancelCallBack.Unbind();
		base.GetButton(3).OnPointDownCallBack.Unbind();
		base.GetButton(3).OnPointUpCallBack.Unbind();
		base.GetButton(3).OnPointCancelCallBack.Unbind();
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.SetModeChangedCallback(null);
		}
		this.ViewModel.FovInputValue = 0f;
	}

	// Token: 0x06010B0C RID: 68364 RVA: 0x004E1F6E File Offset: 0x004E016E
	public void SetStickerEditing(bool editing)
	{
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(!editing);
		}
		UUIItem item2 = base.GetItem(14);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!editing);
	}

	// Token: 0x06010B0D RID: 68365 RVA: 0x004E1F9D File Offset: 0x004E019D
	public void ChangeFovByDelta(float delta)
	{
		UUISliderComponent slider = base.GetSlider(0);
		slider.SetValue(slider.GetValue() + delta, true);
	}

	// Token: 0x06010B0E RID: 68366 RVA: 0x004E1FB4 File Offset: 0x004E01B4
	private void OnFovValueChanged(float value)
	{
		float fov = this.ReverseFov(value);
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.VirtualCamera.Fov = fov;
		}
		this.RefreshFovText(fov);
	}

	// Token: 0x06010B0F RID: 68367 RVA: 0x004E1FE8 File Offset: 0x004E01E8
	private void OnFovButtonReleased()
	{
		this.ViewModel.FovInputValue = 0f;
		InputDistributeController.Instance.InputAxis("PhotoFov", 0f, false);
		PhotoCamera photoCamera = this.GetPhotoCamera();
		this.RefreshFovText((photoCamera != null) ? photoCamera.VirtualCamera.Fov : 0f);
	}

	// Token: 0x06010B10 RID: 68368 RVA: 0x004E203C File Offset: 0x004E023C
	public void SyncFovFromCamera()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera == null)
		{
			return;
		}
		float fov = photoCamera.VirtualCamera.Fov;
		float num = this.ReverseFov(fov);
		UUISliderComponent slider = base.GetSlider(0);
		if (Math.Abs(slider.GetValue() - num) < 0.01f)
		{
			return;
		}
		slider.SetValue(num, false);
		this.RefreshFovText(fov);
	}

	// Token: 0x06010B11 RID: 68369 RVA: 0x004E2094 File Offset: 0x004E0294
	private void SwitchModeByToggle(EToggleState state, PhotoCameraType target)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SwitchMode(target);
			return;
		}
		if (this.ViewModel.IsSwitchingMode)
		{
			return;
		}
		this.SyncModeToggles(this.ViewModel.CurrentMode);
	}

	// Token: 0x06010B12 RID: 68370 RVA: 0x004E20C1 File Offset: 0x004E02C1
	private void SwitchMode(PhotoCameraType target)
	{
		this.SwitchModeAsync(target).Forget();
	}

	// Token: 0x06010B13 RID: 68371 RVA: 0x004E20D0 File Offset: 0x004E02D0
	private UniTask SwitchModeAsync(PhotoCameraType target)
	{
		PhotoRightPanel.<SwitchModeAsync>d__19 <SwitchModeAsync>d__;
		<SwitchModeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchModeAsync>d__.<>4__this = this;
		<SwitchModeAsync>d__.target = target;
		<SwitchModeAsync>d__.<>1__state = -1;
		<SwitchModeAsync>d__.<>t__builder.Start<PhotoRightPanel.<SwitchModeAsync>d__19>(ref <SwitchModeAsync>d__);
		return <SwitchModeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B14 RID: 68372 RVA: 0x004E211C File Offset: 0x004E031C
	private void SetSwitchingModeInteractive(bool interactive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(10);
		if (extendToggle != null)
		{
			extendToggle.SetSelfInteractive(interactive);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(11);
		if (extendToggle2 != null)
		{
			extendToggle2.SetSelfInteractive(interactive);
		}
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(12);
		if (extendToggle3 != null)
		{
			extendToggle3.SetSelfInteractive(interactive);
		}
		UUIExtendToggle extendToggle4 = base.GetExtendToggle(4);
		if (extendToggle4 != null)
		{
			extendToggle4.SetSelfInteractive(interactive);
		}
		UUIButtonComponent button = base.GetButton(9);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(interactive);
	}

	// Token: 0x06010B15 RID: 68373 RVA: 0x004E218C File Offset: 0x004E038C
	[return: Nullable(2)]
	private string ApplyModeSwitch(PhotoCamera photoCamera, PhotoCameraType prev, PhotoCameraType target)
	{
		this.SaveCurrentToSession(photoCamera);
		PhotoCameraSnapshot sessionSnapshot = PhotoSnapshotController.Instance.GetSessionSnapshot(PhotographConfig.Instance.GetPhotoModeIdByType(target));
		photoCamera.SetPendingLens(this.IsInheritModeByType(target) ? null : ((sessionSnapshot != null) ? sessionSnapshot.GetPendingLens() : null));
		this.SyncModeToggles(target);
		PhotographController.Instance.ResetUnsupportedFunction(new PhotoCameraType?(prev), target);
		PhotographController.Instance.ApplyModeSetupOptions(target, (sessionSnapshot != null) ? sessionSnapshot.Options : null);
		if (sessionSnapshot != null)
		{
			sessionSnapshot.Apply();
		}
		this.ViewModel.SetMode(target);
		if (sessionSnapshot == null)
		{
			return null;
		}
		PhotoTemplatePart template = sessionSnapshot.Template;
		if (template == null)
		{
			return null;
		}
		return template.TemplateDaPath;
	}

	// Token: 0x06010B16 RID: 68374 RVA: 0x004E222E File Offset: 0x004E042E
	private bool IsInheritModeByType(PhotoCameraType mode)
	{
		return mode == PhotoCameraType.Drone;
	}

	// Token: 0x06010B17 RID: 68375 RVA: 0x004E2234 File Offset: 0x004E0434
	private void SaveCurrentToSession(PhotoCamera photoCamera)
	{
		PhotoCameraType? currentMode = photoCamera.CurrentMode;
		if (currentMode == null)
		{
			return;
		}
		if (photoCamera.IsInheritMode)
		{
			return;
		}
		int photoModeIdByType = PhotographConfig.Instance.GetPhotoModeIdByType(currentMode.Value);
		PhotoSnapshotController.Instance.GetOrCreateSessionSnapshot(photoModeIdByType).Capture();
	}

	// Token: 0x06010B18 RID: 68376 RVA: 0x004E2280 File Offset: 0x004E0480
	private void OnModeChanged()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		PhotoCameraType? photoCameraType = (photoCamera != null) ? photoCamera.CurrentMode : null;
		if (photoCameraType == null)
		{
			return;
		}
		this.SyncModeToggles(photoCameraType.Value);
		this.ViewModel.SetMode(photoCameraType.Value);
		this.InitFovSlider();
	}

	// Token: 0x06010B19 RID: 68377 RVA: 0x004E22D8 File Offset: 0x004E04D8
	private void SyncModeToggles(PhotoCameraType mode)
	{
		bool flag = mode == PhotoCameraType.Normal || mode == PhotoCameraType.Drone;
		UUIExtendToggle extendToggle = base.GetExtendToggle(10);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(this.GetToggleState(flag), false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(11);
		if (extendToggle2 != null)
		{
			extendToggle2.SetToggleState(this.GetToggleState(mode == PhotoCameraType.Selfie), false, false, false);
		}
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(12);
		if (extendToggle3 != null)
		{
			extendToggle3.SetToggleState(this.GetToggleState(mode == PhotoCameraType.FirstPerson), false, false, false);
		}
		UUIExtendToggle extendToggle4 = base.GetExtendToggle(4);
		if (extendToggle4 != null)
		{
			extendToggle4.SetToggleState(this.GetToggleState(mode == PhotoCameraType.Drone), false, false, false);
		}
		if (extendToggle4 != null)
		{
			extendToggle4.RootUIComp.Get().SetUIActive(flag);
		}
		UUIExtendToggle extendToggle5 = base.GetExtendToggle(5);
		if (extendToggle5 == null)
		{
			return;
		}
		extendToggle5.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06010B1A RID: 68378 RVA: 0x004E23A9 File Offset: 0x004E05A9
	private EToggleState GetToggleState(bool isChecked)
	{
		if (!isChecked)
		{
			return EToggleState.ETT_UnChecked;
		}
		return EToggleState.ETT_Checked;
	}

	// Token: 0x06010B1B RID: 68379 RVA: 0x004E23B1 File Offset: 0x004E05B1
	private void OnCloseClick()
	{
		Action onRequestClose = this.ViewModel.OnRequestClose;
		if (onRequestClose == null)
		{
			return;
		}
		onRequestClose();
	}

	// Token: 0x06010B1C RID: 68380 RVA: 0x004E23C8 File Offset: 0x004E05C8
	private void OnPhotographClick()
	{
		if (this.IsCapturing || this.ViewModel.IsSwitchingMode)
		{
			return;
		}
		this.IsCapturing = true;
		this.CapturePhotoAsync().Forget();
	}

	// Token: 0x06010B1D RID: 68381 RVA: 0x004E23F4 File Offset: 0x004E05F4
	private UniTask CapturePhotoAsync()
	{
		PhotoRightPanel.<CapturePhotoAsync>d__29 <CapturePhotoAsync>d__;
		<CapturePhotoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CapturePhotoAsync>d__.<>4__this = this;
		<CapturePhotoAsync>d__.<>1__state = -1;
		<CapturePhotoAsync>d__.<>t__builder.Start<PhotoRightPanel.<CapturePhotoAsync>d__29>(ref <CapturePhotoAsync>d__);
		return <CapturePhotoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B1E RID: 68382 RVA: 0x004E2438 File Offset: 0x004E0638
	private void ReportTakePhoto()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		CreatureDataComponent creatureDataComponent;
		if (getCurrentEntity == null)
		{
			creatureDataComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			creatureDataComponent = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
		}
		CreatureDataComponent creatureDataComponent2 = creatureDataComponent;
		if (creatureDataComponent2 == null)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		global::Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		global::Vector vector2 = vector;
		if (vector2 == null)
		{
			return;
		}
		Area? areaInfo = AreaModel.Instance.AreaInfo;
		PhotographTakePhotoLogData photographTakePhotoLogData = new PhotographTakePhotoLogData();
		photographTakePhotoLogData.i_area_id = ((areaInfo != null) ? areaInfo.GetValueOrDefault().AreaId : 0);
		photographTakePhotoLogData.i_father_area_id = ((areaInfo != null) ? areaInfo.GetValueOrDefault().Father : 0);
		photographTakePhotoLogData.f_pos_x = (float)vector2.X;
		photographTakePhotoLogData.f_pos_y = (float)vector2.Y;
		photographTakePhotoLogData.f_pos_z = (float)vector2.Z;
		photographTakePhotoLogData.i_role_id = creatureDataComponent2.GetRoleId();
		photographTakePhotoLogData.i_mode = PhotographConfig.Instance.GetPhotoModeIdByType(this.ViewModel.CurrentMode);
		photographTakePhotoLogData.i_rotate = this.GetSetupOption(EPhotoSetupValueType.TiltAngle);
		photographTakePhotoLogData.i_zoom = this.GetSetupOption(EPhotoSetupValueType.DepthOfFieldEnable);
		photographTakePhotoLogData.f_radius = PhotographModel.Instance.GetPhotographOption(EPhotoSetupValueType.DepthOfFieldRadius).GetValueOrDefault();
		photographTakePhotoLogData.f_focus_distance = PhotographModel.Instance.GetPhotographOption(EPhotoSetupValueType.DepthOfFieldDistance).GetValueOrDefault();
		photographTakePhotoLogData.i_line = this.GetSetupOption(EPhotoSetupValueType.AuxiliaryLine);
		photographTakePhotoLogData.i_hide = ((this.GetSetupOption(EPhotoSetupValueType.MeshVisible) <= 0) ? 1 : 0);
		photographTakePhotoLogData.i_face = this.GetSetupOption(EPhotoSetupValueType.PlayerLookAtCamera);
		photographTakePhotoLogData.i_camera = this.ViewModel.CurrentTemplateId;
		photographTakePhotoLogData.i_action = this.GetActionId();
		photographTakePhotoLogData.i_expression = this.ViewModel.CurrentExpressionId;
		photographTakePhotoLogData.i_filter = MenuModel.Instance.FilterSettingIdCache;
		photographTakePhotoLogData.i_filter_intensity = this.GetFilterIntensity(photographTakePhotoLogData.i_filter);
		photographTakePhotoLogData.i_light = this.ViewModel.CurrentLightId;
		photographTakePhotoLogData.i_light_direction = this.ViewModel.CurrentLightDirection;
		photographTakePhotoLogData.s_time = this.GetGameHourText();
		photographTakePhotoLogData.i_weather = this.ViewModel.CurrentWeatherId;
		photographTakePhotoLogData.i_wind = this.ViewModel.CurrentWindId;
		photographTakePhotoLogData.i_wind_intensity = this.ViewModel.CurrentWindStrength;
		photographTakePhotoLogData.i_vibe = this.ViewModel.CurrentAtmosphereId;
		photographTakePhotoLogData.i_frame = this.ViewModel.CurrentFrameId;
		photographTakePhotoLogData.i_watermark = this.ViewModel.CurrentStickerId;
		LogReportController.Instance.LogReport(photographTakePhotoLogData);
	}

	// Token: 0x06010B1F RID: 68383 RVA: 0x004E269C File Offset: 0x004E089C
	private int GetActionId()
	{
		PhotoMode? photoModeConfigByType = PhotographConfig.Instance.GetPhotoModeConfigByType((int)this.ViewModel.CurrentMode);
		if (photoModeConfigByType == null)
		{
			return 0;
		}
		if (photoModeConfigByType.Value.MotionSelectMode != 2)
		{
			return PhotographModel.Instance.MontageId;
		}
		return this.ViewModel.CurrentSelfieMotionId;
	}

	// Token: 0x06010B20 RID: 68384 RVA: 0x004E26F4 File Offset: 0x004E08F4
	private int GetSetupOption(EPhotoSetupValueType valueType)
	{
		return (int)PhotographModel.Instance.GetPhotographOption(valueType).GetValueOrDefault();
	}

	// Token: 0x06010B21 RID: 68385 RVA: 0x004E2718 File Offset: 0x004E0918
	private int GetFilterIntensity(int filterId)
	{
		float[] array;
		if (!MenuModel.Instance.FilterSettingValuesCache.TryGetValue(filterId, out array) || array == null || array.Length <= 2)
		{
			return 0;
		}
		return (int)Math.Round((double)(array[2] * 100f));
	}

	// Token: 0x06010B22 RID: 68386 RVA: 0x004E2754 File Offset: 0x004E0954
	private string GetGameHourText()
	{
		int value = (int)Math.Floor(TodDayTime.ConvertToHour(TimeOfDayModel.Instance.GameTime.Second));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":00");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06010B23 RID: 68387 RVA: 0x004E27A5 File Offset: 0x004E09A5
	private void OnResetClick()
	{
		PhotoCamera photoCamera = this.GetPhotoCamera();
		if (photoCamera != null)
		{
			photoCamera.ResetToModeDefault();
		}
		PhotographController.Instance.ResetDepthOfFieldToDefault();
		this.InitFovSlider();
		Action onCameraReset = this.ViewModel.OnCameraReset;
		if (onCameraReset == null)
		{
			return;
		}
		onCameraReset();
	}

	// Token: 0x06010B24 RID: 68388 RVA: 0x004E27DD File Offset: 0x004E09DD
	private void OnVisibleClick()
	{
		Action onRequestHideUi = this.ViewModel.OnRequestHideUi;
		if (onRequestHideUi == null)
		{
			return;
		}
		onRequestHideUi();
	}

	// Token: 0x06010B25 RID: 68389 RVA: 0x004E27F4 File Offset: 0x004E09F4
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06010B26 RID: 68390 RVA: 0x004E27FD File Offset: 0x004E09FD
	[NullableContext(2)]
	private PhotoCamera GetPhotoCamera()
	{
		return PhotographController.Instance.GetPhotoCamera();
	}

	// Token: 0x06010B27 RID: 68391 RVA: 0x004E2809 File Offset: 0x004E0A09
	private void OnStandStateChanged(EToggleState state)
	{
		this.SwitchModeByToggle(state, PhotoCameraType.Normal);
	}

	// Token: 0x06010B28 RID: 68392 RVA: 0x004E2814 File Offset: 0x004E0A14
	private void OnSelfieStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && !FunctionModel.Instance.IsOpen(EFunctionType.PhotoSelfie))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ConditionGroup_13000273_Description", Array.Empty<object>());
			this.SyncModeToggles(this.ViewModel.CurrentMode);
			return;
		}
		this.SwitchModeByToggle(state, PhotoCameraType.Selfie);
	}

	// Token: 0x06010B29 RID: 68393 RVA: 0x004E2864 File Offset: 0x004E0A64
	private void OnHandheldStateChanged(EToggleState state)
	{
		this.SwitchModeByToggle(state, PhotoCameraType.FirstPerson);
	}

	// Token: 0x06010B2A RID: 68394 RVA: 0x004E2870 File Offset: 0x004E0A70
	private void OnChangeDroneModeStateChanged(EToggleState state)
	{
		PhotoCameraType target = (state == EToggleState.ETT_Checked) ? PhotoCameraType.Drone : PhotoCameraType.Normal;
		this.SwitchMode(target);
	}

	// Token: 0x0400934A RID: 37706
	private PhotoMainViewModel ViewModel;

	// Token: 0x0400934B RID: 37707
	private bool IsCapturing;

	// Token: 0x0400934C RID: 37708
	private const float FOV_AXIS_VALUE = 0.1f;

	// Token: 0x0400934D RID: 37709
	private const float FOV_SYNC_TOLERANCE = 0.01f;

	// Token: 0x0400934E RID: 37710
	private const string MODE_SWITCH_MASK_TAG = "PhotoCameraModeSwitch";

	// Token: 0x02007CFA RID: 31994
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028790 RID: 165776
		SliderFov,
		// Token: 0x04028791 RID: 165777
		TextFovValue,
		// Token: 0x04028792 RID: 165778
		BtnAdd,
		// Token: 0x04028793 RID: 165779
		BtnReduce,
		// Token: 0x04028794 RID: 165780
		ToggleChangeDroneMode,
		// Token: 0x04028795 RID: 165781
		ToggleStopAnim,
		// Token: 0x04028796 RID: 165782
		BtnReset,
		// Token: 0x04028797 RID: 165783
		BtnVisible,
		// Token: 0x04028798 RID: 165784
		BtnClose,
		// Token: 0x04028799 RID: 165785
		BtnPhotograph,
		// Token: 0x0402879A RID: 165786
		ToggleStand,
		// Token: 0x0402879B RID: 165787
		ToggleSelfie,
		// Token: 0x0402879C RID: 165788
		ToggleHandheld,
		// Token: 0x0402879D RID: 165789
		ItemFovSliderPanel,
		// Token: 0x0402879E RID: 165790
		ItemBottomTogglePanel
	}
}

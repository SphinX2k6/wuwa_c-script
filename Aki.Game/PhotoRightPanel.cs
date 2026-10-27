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

// Token: 0x0200257B RID: 9595
[NullableContext(1)]
[Nullable(0)]
public class PhotoRightPanel : UiPanelBase
{
	// Token: 0x06013623 RID: 79395 RVA: 0x004D2DE4 File Offset: 0x004D0FE4
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

	// Token: 0x06013624 RID: 79396 RVA: 0x004D301C File Offset: 0x004D121C
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

	// Token: 0x06013625 RID: 79397 RVA: 0x004D3154 File Offset: 0x004D1354
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

	// Token: 0x06013626 RID: 79398 RVA: 0x004D31D8 File Offset: 0x004D13D8
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

	// Token: 0x06013627 RID: 79399 RVA: 0x004D3224 File Offset: 0x004D1424
	private void RefreshFovText(float fov)
	{
		base.GetText(1).SetText(Math.Round((double)fov).ToString(), true);
	}

	// Token: 0x06013628 RID: 79400 RVA: 0x004D3250 File Offset: 0x004D1450
	protected override void OnBeforeDestroy()
	{
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

	// Token: 0x06013629 RID: 79401 RVA: 0x004D32F6 File Offset: 0x004D14F6
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

	// Token: 0x0601362A RID: 79402 RVA: 0x004D3325 File Offset: 0x004D1525
	public void ChangeFovByDelta(float delta)
	{
		UUISliderComponent slider = base.GetSlider(0);
		slider.SetValue(slider.GetValue() + delta, true);
	}

	// Token: 0x0601362B RID: 79403 RVA: 0x004D333C File Offset: 0x004D153C
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

	// Token: 0x0601362C RID: 79404 RVA: 0x004D3370 File Offset: 0x004D1570
	private void OnFovButtonReleased()
	{
		this.ViewModel.FovInputValue = 0f;
		InputDistributeController.Instance.InputAxis("PhotoFov", 0f, false);
		PhotoCamera photoCamera = this.GetPhotoCamera();
		this.RefreshFovText((photoCamera != null) ? photoCamera.VirtualCamera.Fov : 0f);
	}

	// Token: 0x0601362D RID: 79405 RVA: 0x004D33C4 File Offset: 0x004D15C4
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

	// Token: 0x0601362E RID: 79406 RVA: 0x004D341C File Offset: 0x004D161C
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

	// Token: 0x0601362F RID: 79407 RVA: 0x004D3449 File Offset: 0x004D1649
	private void SwitchMode(PhotoCameraType target)
	{
		this.SwitchModeAsync(target).Forget();
	}

	// Token: 0x06013630 RID: 79408 RVA: 0x004D3458 File Offset: 0x004D1658
	private UniTask SwitchModeAsync(PhotoCameraType target)
	{
		PhotoRightPanel.<SwitchModeAsync>d__20 <SwitchModeAsync>d__;
		<SwitchModeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchModeAsync>d__.<>4__this = this;
		<SwitchModeAsync>d__.target = target;
		<SwitchModeAsync>d__.<>1__state = -1;
		<SwitchModeAsync>d__.<>t__builder.Start<PhotoRightPanel.<SwitchModeAsync>d__20>(ref <SwitchModeAsync>d__);
		return <SwitchModeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013631 RID: 79409 RVA: 0x004D34A4 File Offset: 0x004D16A4
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

	// Token: 0x06013632 RID: 79410 RVA: 0x004D3514 File Offset: 0x004D1714
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

	// Token: 0x06013633 RID: 79411 RVA: 0x004D35B6 File Offset: 0x004D17B6
	private bool IsInheritModeByType(PhotoCameraType mode)
	{
		return mode == PhotoCameraType.Drone;
	}

	// Token: 0x06013634 RID: 79412 RVA: 0x004D35BC File Offset: 0x004D17BC
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

	// Token: 0x06013635 RID: 79413 RVA: 0x004D3608 File Offset: 0x004D1808
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

	// Token: 0x06013636 RID: 79414 RVA: 0x004D3660 File Offset: 0x004D1860
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

	// Token: 0x06013637 RID: 79415 RVA: 0x004D3731 File Offset: 0x004D1931
	private EToggleState GetToggleState(bool isChecked)
	{
		if (!isChecked)
		{
			return EToggleState.ETT_UnChecked;
		}
		return EToggleState.ETT_Checked;
	}

	// Token: 0x06013638 RID: 79416 RVA: 0x004D3739 File Offset: 0x004D1939
	private void OnCloseClick()
	{
		Action onRequestClose = this.ViewModel.OnRequestClose;
		if (onRequestClose == null)
		{
			return;
		}
		onRequestClose();
	}

	// Token: 0x06013639 RID: 79417 RVA: 0x004D3750 File Offset: 0x004D1950
	private void OnPhotographClick()
	{
		if (this.IsCapturing || this.ViewModel.IsSwitchingMode)
		{
			return;
		}
		this.IsCapturing = true;
		this.CapturePhotoAsync().Forget();
	}

	// Token: 0x0601363A RID: 79418 RVA: 0x004D377C File Offset: 0x004D197C
	private UniTask CapturePhotoAsync()
	{
		PhotoRightPanel.<CapturePhotoAsync>d__30 <CapturePhotoAsync>d__;
		<CapturePhotoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CapturePhotoAsync>d__.<>4__this = this;
		<CapturePhotoAsync>d__.<>1__state = -1;
		<CapturePhotoAsync>d__.<>t__builder.Start<PhotoRightPanel.<CapturePhotoAsync>d__30>(ref <CapturePhotoAsync>d__);
		return <CapturePhotoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601363B RID: 79419 RVA: 0x004D37C0 File Offset: 0x004D19C0
	private unsafe void CacheAndApplyPsoCvars()
	{
		if (GlobalData.World == null || this.CachedPsoCvarValues.Count > 0)
		{
			return;
		}
		foreach (KeyValuePair<string, int> keyValuePair in this.PhotoPsoCvarOverrides)
		{
			int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue(keyValuePair.Key);
			this.CachedPsoCvarValues[keyValuePair.Key] = consoleVariableIntValue;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Key);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Photo;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "[拍照]截图前修改PSO CVar";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cvar", keyValuePair.Key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("origin", consoleVariableIntValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("target", keyValuePair.Value);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x0601363C RID: 79420 RVA: 0x004D391C File Offset: 0x004D1B1C
	private unsafe void RestorePsoCvars()
	{
		if (this.CachedPsoCvarValues.Count <= 0)
		{
			return;
		}
		if (GlobalData.World != null)
		{
			foreach (KeyValuePair<string, int> keyValuePair in this.CachedPsoCvarValues)
			{
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Key);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Photo;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "[拍照]截图后恢复PSO CVar";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cvar", keyValuePair.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("origin", keyValuePair.Value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		this.CachedPsoCvarValues.Clear();
	}

	// Token: 0x0601363D RID: 79421 RVA: 0x004D3A3C File Offset: 0x004D1C3C
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

	// Token: 0x0601363E RID: 79422 RVA: 0x004D3CA0 File Offset: 0x004D1EA0
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

	// Token: 0x0601363F RID: 79423 RVA: 0x004D3CF8 File Offset: 0x004D1EF8
	private int GetSetupOption(EPhotoSetupValueType valueType)
	{
		return (int)PhotographModel.Instance.GetPhotographOption(valueType).GetValueOrDefault();
	}

	// Token: 0x06013640 RID: 79424 RVA: 0x004D3D1C File Offset: 0x004D1F1C
	private int GetFilterIntensity(int filterId)
	{
		float[] array;
		if (!MenuModel.Instance.FilterSettingValuesCache.TryGetValue(filterId, out array) || array == null || array.Length <= 2)
		{
			return 0;
		}
		return (int)Math.Round((double)(array[2] * 100f));
	}

	// Token: 0x06013641 RID: 79425 RVA: 0x004D3D58 File Offset: 0x004D1F58
	private string GetGameHourText()
	{
		int value = (int)Math.Floor(TodDayTime.ConvertToHour(TimeOfDayModel.Instance.GameTime.Second));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":00");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06013642 RID: 79426 RVA: 0x004D3DA9 File Offset: 0x004D1FA9
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

	// Token: 0x06013643 RID: 79427 RVA: 0x004D3DE1 File Offset: 0x004D1FE1
	private void OnVisibleClick()
	{
		Action onRequestHideUi = this.ViewModel.OnRequestHideUi;
		if (onRequestHideUi == null)
		{
			return;
		}
		onRequestHideUi();
	}

	// Token: 0x06013644 RID: 79428 RVA: 0x004D3DF8 File Offset: 0x004D1FF8
	public void SetViewModel(PhotoMainViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06013645 RID: 79429 RVA: 0x004D3E01 File Offset: 0x004D2001
	[NullableContext(2)]
	private PhotoCamera GetPhotoCamera()
	{
		return PhotographController.Instance.GetPhotoCamera();
	}

	// Token: 0x06013646 RID: 79430 RVA: 0x004D3E0D File Offset: 0x004D200D
	private void OnStandStateChanged(EToggleState state)
	{
		this.SwitchModeByToggle(state, PhotoCameraType.Normal);
	}

	// Token: 0x06013647 RID: 79431 RVA: 0x004D3E18 File Offset: 0x004D2018
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

	// Token: 0x06013648 RID: 79432 RVA: 0x004D3E68 File Offset: 0x004D2068
	private void OnHandheldStateChanged(EToggleState state)
	{
		this.SwitchModeByToggle(state, PhotoCameraType.FirstPerson);
	}

	// Token: 0x06013649 RID: 79433 RVA: 0x004D3E74 File Offset: 0x004D2074
	private void OnChangeDroneModeStateChanged(EToggleState state)
	{
		PhotoCameraType target = (state == EToggleState.ETT_Checked) ? PhotoCameraType.Drone : PhotoCameraType.Normal;
		this.SwitchMode(target);
	}

	// Token: 0x040091F1 RID: 37361
	private PhotoMainViewModel ViewModel;

	// Token: 0x040091F2 RID: 37362
	private bool IsCapturing;

	// Token: 0x040091F3 RID: 37363
	private const float FOV_AXIS_VALUE = 0.1f;

	// Token: 0x040091F4 RID: 37364
	private const float FOV_SYNC_TOLERANCE = 0.01f;

	// Token: 0x040091F5 RID: 37365
	private readonly Dictionary<string, int> PhotoPsoCvarOverrides = new Dictionary<string, int>
	{
		{
			"r.PSO.IgnoreCreationHints",
			1
		},
		{
			"r.PSO.CompilationMode",
			1
		}
	};

	// Token: 0x040091F6 RID: 37366
	private readonly Dictionary<string, int> CachedPsoCvarValues = new Dictionary<string, int>();

	// Token: 0x02008B74 RID: 35700
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D483 RID: 185475
		SliderFov,
		// Token: 0x0402D484 RID: 185476
		TextFovValue,
		// Token: 0x0402D485 RID: 185477
		BtnAdd,
		// Token: 0x0402D486 RID: 185478
		BtnReduce,
		// Token: 0x0402D487 RID: 185479
		ToggleChangeDroneMode,
		// Token: 0x0402D488 RID: 185480
		ToggleStopAnim,
		// Token: 0x0402D489 RID: 185481
		BtnReset,
		// Token: 0x0402D48A RID: 185482
		BtnVisible,
		// Token: 0x0402D48B RID: 185483
		BtnClose,
		// Token: 0x0402D48C RID: 185484
		BtnPhotograph,
		// Token: 0x0402D48D RID: 185485
		ToggleStand,
		// Token: 0x0402D48E RID: 185486
		ToggleSelfie,
		// Token: 0x0402D48F RID: 185487
		ToggleHandheld,
		// Token: 0x0402D490 RID: 185488
		ItemFovSliderPanel,
		// Token: 0x0402D491 RID: 185489
		ItemBottomTogglePanel
	}
}

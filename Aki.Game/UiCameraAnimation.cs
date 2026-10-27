using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.UiCameraAnimation;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C31 RID: 11313
[NullableContext(2)]
[Nullable(0)]
public class UiCameraAnimation
{
	// Token: 0x0601792B RID: 96555 RVA: 0x005FEC5C File Offset: 0x005FCE5C
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<UiCameraAnimationDefine.IFinishData> AsyncPlayUiCameraAnimation(UiCameraHandleData fromHandleData, UiCameraHandleData toHandleData, string blendDataName)
	{
		UiCameraAnimation.<AsyncPlayUiCameraAnimation>d__19 <AsyncPlayUiCameraAnimation>d__;
		<AsyncPlayUiCameraAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiCameraAnimationDefine.IFinishData>.Create();
		<AsyncPlayUiCameraAnimation>d__.<>4__this = this;
		<AsyncPlayUiCameraAnimation>d__.fromHandleData = fromHandleData;
		<AsyncPlayUiCameraAnimation>d__.toHandleData = toHandleData;
		<AsyncPlayUiCameraAnimation>d__.blendDataName = blendDataName;
		<AsyncPlayUiCameraAnimation>d__.<>1__state = -1;
		<AsyncPlayUiCameraAnimation>d__.<>t__builder.Start<UiCameraAnimation.<AsyncPlayUiCameraAnimation>d__19>(ref <AsyncPlayUiCameraAnimation>d__);
		return <AsyncPlayUiCameraAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x0601792C RID: 96556 RVA: 0x005FECB7 File Offset: 0x005FCEB7
	private void NewWaitPromise()
	{
		if (this.WaitPromise == null)
		{
			this.WaitPromise = new CustomPromise<UiCameraAnimationDefine.IFinishData>();
		}
	}

	// Token: 0x0601792D RID: 96557 RVA: 0x005FECCC File Offset: 0x005FCECC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private CustomPromise<UiCameraAnimationDefine.IFinishData> GetWaitPromise()
	{
		return this.WaitPromise;
	}

	// Token: 0x0601792E RID: 96558 RVA: 0x005FECD4 File Offset: 0x005FCED4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<UiCameraAnimationDefine.IFinishData> WaitCameraAnimationFinished()
	{
		UiCameraAnimation.<WaitCameraAnimationFinished>d__22 <WaitCameraAnimationFinished>d__;
		<WaitCameraAnimationFinished>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiCameraAnimationDefine.IFinishData>.Create();
		<WaitCameraAnimationFinished>d__.<>4__this = this;
		<WaitCameraAnimationFinished>d__.<>1__state = -1;
		<WaitCameraAnimationFinished>d__.<>t__builder.Start<UiCameraAnimation.<WaitCameraAnimationFinished>d__22>(ref <WaitCameraAnimationFinished>d__);
		return <WaitCameraAnimationFinished>d__.<>t__builder.Task;
	}

	// Token: 0x0601792F RID: 96559 RVA: 0x005FED18 File Offset: 0x005FCF18
	[NullableContext(1)]
	public unsafe void PlayUiCameraAnimation(UiCameraHandleData fromHandleData, UiCameraHandleData toHandleData, string blendDataName)
	{
		this.ResetUiCameraBlendAnimation();
		if (!toHandleData.CanApplyAnimationHandle())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "无法播放镜头动画：原因是找不到对应插槽或骨骼模型为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("toHandleData", toHandleData.ToString());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (!this.RefreshAnimationSourceData(fromHandleData, blendDataName, toHandleData))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "刷新动画数据失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("fromHandleData", fromHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("toHandleData", toHandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendDataName", blendDataName);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.CameraAnimation;
		ELogAuthor author3 = ELogAuthor.BB;
		string message3 = "播放界面摄像机动画------开始";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("fromHandleName", fromHandleData.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("toHandleName", toHandleData.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("blendDataName", blendDataName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("timeLength", this.TimeLength);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		this.CurrentCameraHandle.Deactivate();
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetCameraActorRelativeLocation(Vector.ZeroVectorDouble);
		this.CurrentCameraHandle.SetWidgetCameraAttachToAnimationActor();
		if (this.TimeLength <= 0f)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.CameraAnimation;
			ELogAuthor author4 = ELogAuthor.BB;
			string message4 = "播放界面摄像机动画时间<=0，会立马结束动画";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("timeLength", this.TimeLength);
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.FinishUiCameraAnimation();
			return;
		}
		this.LoadCurveFloat();
		this.PlayUiCameraAnimationSequence(this.CurrentAnimationBlendData.LevelSequence, this.CurrentAnimationBlendData.PlayRate, this.CurrentAnimationBlendData.bReverse);
	}

	// Token: 0x06017930 RID: 96560 RVA: 0x005FEF14 File Offset: 0x005FD114
	[NullableContext(1)]
	private bool RefreshAnimationSourceData(UiCameraHandleData fromHandleData, string blendDataName, UiCameraHandleData toHandleData)
	{
		this.FromHandleData = fromHandleData;
		this.ToHandleData = toHandleData;
		this.CurrentCameraHandle = UiCameraAnimationManager.Instance.GetCurrentCameraHandle();
		this.CurrentAnimationBlendData = UiCameraAnimationConfig.Instance.GetUiCameraAnimationBlendData(blendDataName);
		if (this.CurrentCameraHandle == null || this.CurrentAnimationBlendData == null)
		{
			return false;
		}
		UiCameraSpringStructure uiCameraSpringStructure = UiCameraAnimationManager.Instance.UiCameraSpringStructure;
		UiCameraPostEffectComponent uiCameraPostEffectComponent = UiCameraAnimationManager.Instance.UiCameraPostEffectComponent;
		this.SetAnimationSourceData(uiCameraSpringStructure.GetActorLocation(), uiCameraSpringStructure.GetActorRotation(), uiCameraSpringStructure.GetSpringArmLength(), uiCameraSpringStructure.GetSpringRelativeLocation(), uiCameraSpringStructure.GetSpringRelativeRotation(), uiCameraPostEffectComponent.GetFieldOfView(), uiCameraPostEffectComponent.GetManualFocusDistance(), uiCameraPostEffectComponent.GetCurrentAperture(), uiCameraPostEffectComponent.GetPostProcessBlendWeight(), this.CurrentAnimationBlendData.Time);
		return true;
	}

	// Token: 0x06017931 RID: 96561 RVA: 0x005FEFC8 File Offset: 0x005FD1C8
	public void StopUiCameraAnimation()
	{
		if (this.ToHandleData == null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "播放界面摄像机动画------停止";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "fromHandleName";
		UiCameraHandleData fromHandleData = this.FromHandleData;
		ptr = new ValueTuple<string, object>(item, (fromHandleData != null) ? fromHandleData.ToString() : null);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "toHandleName";
		UiCameraHandleData toHandleData = this.ToHandleData;
		ptr2 = new ValueTuple<string, object>(item2, (toHandleData != null) ? toHandleData.ToString() : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.WaitPromise != null)
		{
			UiCameraAnimationDefine.FinishData result = new UiCameraAnimationDefine.FinishData
			{
				FinishType = UiCameraAnimationDefine.ECameraAnimationFinishType.Stop,
				FromHandleData = this.FromHandleData,
				ToHandleData = this.ToHandleData
			};
			this.WaitPromise.SetResult(result);
			this.WaitPromise = null;
		}
		this.DestroyUiCameraSequence(true, ERestoreStateType.NotRestore);
		this.ResetUiCameraBlendAnimation();
	}

	// Token: 0x06017932 RID: 96562 RVA: 0x005FF0A4 File Offset: 0x005FD2A4
	private unsafe void FinishUiCameraAnimation()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "播放界面摄像机动画------完成";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("fromHandleName", this.FromHandleData.ToString());
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "toHandleName";
		UiCameraHandleData toHandleData = this.ToHandleData;
		ptr = new ValueTuple<string, object>(item, (toHandleData != null) ? toHandleData.ToString() : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.WaitPromise != null)
		{
			UiCameraAnimationDefine.FinishData result = new UiCameraAnimationDefine.FinishData
			{
				FinishType = UiCameraAnimationDefine.ECameraAnimationFinishType.Finished,
				FromHandleData = this.FromHandleData,
				ToHandleData = this.ToHandleData
			};
			this.WaitPromise.SetResult(result);
			this.WaitPromise = null;
		}
		this.DestroyUiCameraSequence(true, ERestoreStateType.NotSet);
		this.ResetUiCameraBlendAnimation();
	}

	// Token: 0x06017933 RID: 96563 RVA: 0x005FF170 File Offset: 0x005FD370
	private void SetAnimationSourceData(FVectorDouble location, FRotator rotation, float armLength, FVectorDouble armRelativeLocation, FRotator armRelativeRotation, float fieldOfView, float focalDistance, float aperture, float processBlendWeight, float timeLength)
	{
		this.CurrentLocation = new FVectorDouble?(location);
		this.CurrentRotation = new FRotator?(rotation);
		this.CurrentArmLength = new float?(armLength);
		this.CurrentArmRelativeLocation = new FVectorDouble?(armRelativeLocation);
		this.CurrentArmRelativeRotation = new FRotator?(armRelativeRotation);
		this.CurrentFieldOfView = new float?(fieldOfView);
		this.CurrentFocalDistance = new float?(focalDistance);
		this.CurrentAperture = aperture;
		this.CurrentPostProcessBlendWeight = new float?(processBlendWeight);
		this.TimeLength = timeLength;
	}

	// Token: 0x06017934 RID: 96564 RVA: 0x005FF1F4 File Offset: 0x005FD3F4
	public void Tick(float delta)
	{
		if (this.CurrentAnimationBlendData == null || this.CurrentCameraHandle == null)
		{
			return;
		}
		this.CurrentTimeLength += delta / (float)TimeUtil.Instance.InverseMillisecond;
		if (this.CurrentTimeLength >= this.TimeLength)
		{
			this.FinishUiCameraAnimation();
			return;
		}
		if (this.ToHandleData == null)
		{
			return;
		}
		SUiCameraAnimationSettings uiCameraAnimationConfig = this.ToHandleData.GetUiCameraAnimationConfig();
		this.BlendLocationByAnimationSettings(uiCameraAnimationConfig.LocationType);
		this.BlendRotationByAnimationSettings();
		this.LerpArmLength(new float?(this.ToHandleData.GetTargetArmLength()));
		this.LerpArmOffsetLocation(new FVectorDouble?(this.ToHandleData.GetTargetArmOffsetLocation()));
		this.LerpArmOffsetRotation(new FRotator?(this.ToHandleData.GetTargetArmOffsetRotation()));
		this.LerpCameraFieldOfView(new float?(this.ToHandleData.GetTargetFieldOfView()));
		this.LerpFocalDistance(new float?(this.ToHandleData.GetTargetFocalDistance()));
		this.LerpAperture(new float?(this.ToHandleData.GetTargetAperture()));
		this.LerpFocalRegion(new float?(this.ToHandleData.GetTargetFocalRegion()));
		this.LerpPostProcessBlendWeight(new float?(this.ToHandleData.GetTargetPostProcessBlendWeight()));
	}

	// Token: 0x06017935 RID: 96565 RVA: 0x005FF323 File Offset: 0x005FD523
	public bool IsPlaying()
	{
		return this.CurrentTimeLength < this.TimeLength;
	}

	// Token: 0x06017936 RID: 96566 RVA: 0x005FF334 File Offset: 0x005FD534
	private void BlendLocationByAnimationSettings(EUiCameraAnimationLocationType targetLocationType)
	{
		FVectorDouble? targetLocation = this.ToHandleData.GetTargetLocation();
		if (targetLocation == null)
		{
			return;
		}
		this.LerpLocation(targetLocation, targetLocationType > EUiCameraAnimationLocationType.WorldLocation);
	}

	// Token: 0x06017937 RID: 96567 RVA: 0x005FF364 File Offset: 0x005FD564
	private void BlendRotationByAnimationSettings()
	{
		FRotator? targetRotation = this.ToHandleData.GetTargetRotation();
		if (targetRotation == null)
		{
			return;
		}
		this.LerpRotation(targetRotation);
	}

	// Token: 0x06017938 RID: 96568 RVA: 0x005FF390 File Offset: 0x005FD590
	private void LerpLocation(FVectorDouble? targetLocation, bool isRelativeLocation)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.Location);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = UKismetMathLibrary.D_VLerp(this.CurrentLocation.Value, targetLocation.Value, (double)currentCurveFloatValue.Value);
		if (isRelativeLocation)
		{
			this.CurrentCameraHandle.SetUiCameraAnimationRelativeLocation(fvectorDouble);
			return;
		}
		this.CurrentCameraHandle.SetUiCameraAnimationLocation(fvectorDouble);
	}

	// Token: 0x06017939 RID: 96569 RVA: 0x005FF3EC File Offset: 0x005FD5EC
	private void LerpRotation(FRotator? targetRotation)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.Rotation);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		FRotator uiCameraAnimationRotation = UKismetMathLibrary.RLerp(this.CurrentRotation.Value, targetRotation.Value, currentCurveFloatValue.Value, true);
		this.CurrentCameraHandle.SetUiCameraAnimationRotation(uiCameraAnimationRotation);
	}

	// Token: 0x0601793A RID: 96570 RVA: 0x005FF438 File Offset: 0x005FD638
	private void LerpArmLength(float? targetArmLength)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.ArmLength);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		float springArmLength = MathUtils.Instance.Lerp(this.CurrentArmLength.Value, targetArmLength.Value, currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetSpringArmLength(springArmLength);
	}

	// Token: 0x0601793B RID: 96571 RVA: 0x005FF488 File Offset: 0x005FD688
	private void LerpArmOffsetLocation(FVectorDouble? targetArmOffsetLocation)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.ArmOffsetLocation);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		FVectorDouble springArmRelativeLocation = UKismetMathLibrary.D_VLerp(this.CurrentArmRelativeLocation.Value, targetArmOffsetLocation.Value, (double)currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetSpringArmRelativeLocation(springArmRelativeLocation);
	}

	// Token: 0x0601793C RID: 96572 RVA: 0x005FF4D4 File Offset: 0x005FD6D4
	private void LerpArmOffsetRotation(FRotator? targetRotation)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.ArmOffsetRotation);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		FRotator sprintArmRelativeRotation = UKismetMathLibrary.RLerp(this.CurrentArmRelativeRotation.Value, targetRotation.Value, currentCurveFloatValue.Value, true);
		this.CurrentCameraHandle.SetSprintArmRelativeRotation(sprintArmRelativeRotation);
	}

	// Token: 0x0601793D RID: 96573 RVA: 0x005FF520 File Offset: 0x005FD720
	private void LerpCameraFieldOfView(float? targetFieldOfView)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.CameraFieldOfView);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		float cameraFieldOfView = MathUtils.Instance.Lerp(this.CurrentFieldOfView.Value, targetFieldOfView.Value, currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetCameraFieldOfView(cameraFieldOfView);
	}

	// Token: 0x0601793E RID: 96574 RVA: 0x005FF570 File Offset: 0x005FD770
	private void LerpFocalDistance(float? targetFocalDistance)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.FocalDistance);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		float cameraFocalDistance = MathUtils.Instance.Lerp(this.CurrentFocalDistance.Value, targetFocalDistance.Value, currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetCameraFocalDistance(cameraFocalDistance);
	}

	// Token: 0x0601793F RID: 96575 RVA: 0x005FF5C0 File Offset: 0x005FD7C0
	private void LerpAperture(float? targetAperture)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.Aperture);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		float cameraAperture = MathUtils.Instance.Lerp(this.CurrentAperture, targetAperture.Value, currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetCameraAperture(cameraAperture);
	}

	// Token: 0x06017940 RID: 96576 RVA: 0x005FF60C File Offset: 0x005FD80C
	private void LerpFocalRegion(float? targetFocalRegion)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.FocalRegion);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		float cameraFocalRegion = MathUtils.Instance.Lerp(this.CurrentFocalRegion, targetFocalRegion.Value, currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetCameraFocalRegion(cameraFocalRegion);
	}

	// Token: 0x06017941 RID: 96577 RVA: 0x005FF658 File Offset: 0x005FD858
	private void LerpPostProcessBlendWeight(float? targetPostProcessBlendWeight)
	{
		float? currentCurveFloatValue = this.GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType.PostProcessBlendWeight);
		if (currentCurveFloatValue == null)
		{
			return;
		}
		float cameraPostProcessBlendWeight = MathUtils.Instance.Lerp(this.CurrentPostProcessBlendWeight.Value, targetPostProcessBlendWeight.Value, currentCurveFloatValue.Value);
		this.CurrentCameraHandle.SetCameraPostProcessBlendWeight(cameraPostProcessBlendWeight);
	}

	// Token: 0x06017942 RID: 96578 RVA: 0x005FF6A7 File Offset: 0x005FD8A7
	private float? GetCurrentCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType type)
	{
		return this.GetCurveFloatValue(type, this.CurrentTimeLength);
	}

	// Token: 0x06017943 RID: 96579 RVA: 0x005FF6B8 File Offset: 0x005FD8B8
	public float? GetCurveFloatValue(UiCameraAnimationDefine.ECameraAnimationAttributeType type, float time)
	{
		if (time > this.TimeLength)
		{
			return new float?(1f);
		}
		UCurveFloat curveFloat = this.GetCurveFloat(type);
		if (curveFloat == null)
		{
			return null;
		}
		return new float?(Math.Min(curveFloat.GetFloatValue(time), 1f));
	}

	// Token: 0x06017944 RID: 96580 RVA: 0x005FF704 File Offset: 0x005FD904
	public UCurveFloat GetCurveFloat(UiCameraAnimationDefine.ECameraAnimationAttributeType attributeType)
	{
		UCurveFloat result;
		if (!this.CurveFloatMap.TryGetValue(attributeType, out result))
		{
			return this.CommonCurveFloat;
		}
		return result;
	}

	// Token: 0x06017945 RID: 96581 RVA: 0x005FF72C File Offset: 0x005FD92C
	private void LoadCurveFloat()
	{
		if (this.CommonCurveFloat == null || !this.CommonCurveFloat.IsValid())
		{
			TSoftObjectPtr<UCurveFloat> commonCurve = this.CurrentAnimationBlendData.CommonCurve;
			TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(commonCurve);
			if (UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
			{
				string text = commonCurve.ToAssetPathName();
				if (!StringUtils.IsEmpty(text))
				{
					ResourceSystem.Instance.LoadAsync<UCurveFloat>(text, delegate([Nullable(2)] UCurveFloat curveFloat, string _)
					{
						this.CommonCurveFloat = curveFloat;
					}, 100, "Ui.UiCamera");
				}
			}
		}
		if (this.CurveFloatMap.Count <= 0)
		{
			foreach (KeyValuePair<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>> keyValuePair in this.CurrentAnimationBlendData.CurveMap)
			{
				TEnumAsByte<EUiCameraAnimationAttributeType> key2;
				TSoftObjectPtr<UCurveFloat> tsoftObjectPtr2;
				keyValuePair.Deconstruct(out key2, out tsoftObjectPtr2);
				TEnumAsByte<EUiCameraAnimationAttributeType> key = key2;
				TSoftObjectPtr<UCurveFloat> tsoftObjectPtr3 = tsoftObjectPtr2;
				TSoftObjectPtr<UObject> tsoftObjectPtr4 = new TSoftObjectPtr<UObject>(tsoftObjectPtr3);
				if (UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr4))
				{
					string text2 = tsoftObjectPtr3.ToAssetPathName();
					if (!StringUtils.IsEmpty(text2))
					{
						ResourceSystem.Instance.LoadAsync<UCurveFloat>(text2, delegate([Nullable(2)] UCurveFloat curveFloat, string _)
						{
							this.CurveFloatMap[(UiCameraAnimationDefine.ECameraAnimationAttributeType)key] = curveFloat;
						}, 100, "Ui.UiCamera");
					}
				}
			}
		}
	}

	// Token: 0x17001FC5 RID: 8133
	// (get) Token: 0x06017946 RID: 96582 RVA: 0x005FF854 File Offset: 0x005FDA54
	public float GetTimeLength
	{
		get
		{
			return this.TimeLength;
		}
	}

	// Token: 0x06017947 RID: 96583 RVA: 0x005FF85C File Offset: 0x005FDA5C
	private void ResetUiCameraBlendAnimation()
	{
		this.CurrentAnimationBlendData = null;
		this.CurrentCameraHandle = null;
		this.FromHandleData = null;
		this.ToHandleData = null;
		this.CurrentLocation = null;
		this.CurrentRotation = null;
		this.CurrentArmLength = null;
		this.CurrentArmRelativeLocation = null;
		this.CurrentArmRelativeRotation = null;
		this.CurrentFieldOfView = null;
		this.CurrentFocalDistance = null;
		this.CurrentPostProcessBlendWeight = null;
		this.CurrentTimeLength = 0f;
		this.TimeLength = 0f;
		this.CommonCurveFloat = null;
		this.CurveFloatMap.Clear();
	}

	// Token: 0x06017948 RID: 96584 RVA: 0x005FF910 File Offset: 0x005FDB10
	[NullableContext(1)]
	private void PlayUiCameraAnimationSequence(TSoftObjectPtr<ULevelSequence> sequence, float playRate, bool reverse)
	{
		TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(sequence);
		if (!UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
		{
			return;
		}
		this.DestroyUiCameraSequence(true, ERestoreStateType.NotRestore);
		UiCameraSequenceComponent uiCameraSequenceComponent = UiCameraAnimationManager.Instance.UiCameraSequenceComponent;
		uiCameraSequenceComponent.AddUiCameraSequenceFinishedCallback(new Action(this.OnUiCameraAnimationSequenceFinished));
		uiCameraSequenceComponent.LoadAndPlayUiCameraSequence(sequence, playRate, reverse, null);
	}

	// Token: 0x06017949 RID: 96585 RVA: 0x005FF95C File Offset: 0x005FDB5C
	private void OnUiCameraAnimationSequenceFinished()
	{
		this.DestroyUiCameraSequence(true, ERestoreStateType.NotSet);
	}

	// Token: 0x0601794A RID: 96586 RVA: 0x005FF966 File Offset: 0x005FDB66
	private void DestroyUiCameraSequence(bool destroyBlackScreen = true, ERestoreStateType restoreStateType = ERestoreStateType.NotSet)
	{
		UiCameraSequenceComponent uiCameraSequenceComponent = UiCameraAnimationManager.Instance.UiCameraSequenceComponent;
		if (uiCameraSequenceComponent == null)
		{
			return;
		}
		uiCameraSequenceComponent.DestroyUiCameraSequence(destroyBlackScreen, restoreStateType);
	}

	// Token: 0x0400AFD8 RID: 45016
	private UiCameraAnimationHandle CurrentCameraHandle;

	// Token: 0x0400AFD9 RID: 45017
	private SUiCameraAnimationBlendSettings CurrentAnimationBlendData;

	// Token: 0x0400AFDA RID: 45018
	private float CurrentTimeLength;

	// Token: 0x0400AFDB RID: 45019
	private FVectorDouble? CurrentLocation;

	// Token: 0x0400AFDC RID: 45020
	private FRotator? CurrentRotation;

	// Token: 0x0400AFDD RID: 45021
	private float? CurrentArmLength;

	// Token: 0x0400AFDE RID: 45022
	private FVectorDouble? CurrentArmRelativeLocation;

	// Token: 0x0400AFDF RID: 45023
	private FRotator? CurrentArmRelativeRotation;

	// Token: 0x0400AFE0 RID: 45024
	private float? CurrentFieldOfView;

	// Token: 0x0400AFE1 RID: 45025
	private float? CurrentFocalDistance;

	// Token: 0x0400AFE2 RID: 45026
	private float CurrentAperture;

	// Token: 0x0400AFE3 RID: 45027
	private readonly float CurrentFocalRegion;

	// Token: 0x0400AFE4 RID: 45028
	private float? CurrentPostProcessBlendWeight;

	// Token: 0x0400AFE5 RID: 45029
	[Nullable(1)]
	private readonly Dictionary<UiCameraAnimationDefine.ECameraAnimationAttributeType, UCurveFloat> CurveFloatMap = new Dictionary<UiCameraAnimationDefine.ECameraAnimationAttributeType, UCurveFloat>();

	// Token: 0x0400AFE6 RID: 45030
	private float TimeLength;

	// Token: 0x0400AFE7 RID: 45031
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CustomPromise<UiCameraAnimationDefine.IFinishData> WaitPromise;

	// Token: 0x0400AFE8 RID: 45032
	private UiCameraHandleData FromHandleData;

	// Token: 0x0400AFE9 RID: 45033
	private UiCameraHandleData ToHandleData;

	// Token: 0x0400AFEA RID: 45034
	private UCurveFloat CommonCurveFloat;
}

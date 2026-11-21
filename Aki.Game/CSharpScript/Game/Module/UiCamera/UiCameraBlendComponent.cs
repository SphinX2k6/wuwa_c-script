using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200398B RID: 14731
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraBlendComponent : UiCameraComponent
	{
		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x06025E78 RID: 155256 RVA: 0x00AA4CC9 File Offset: 0x00AA2EC9
		// (set) Token: 0x06025E79 RID: 155257 RVA: 0x00AA4CD1 File Offset: 0x00AA2ED1
		public FVectorDouble CurrentLocation { get; private set; }

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x06025E7A RID: 155258 RVA: 0x00AA4CDA File Offset: 0x00AA2EDA
		// (set) Token: 0x06025E7B RID: 155259 RVA: 0x00AA4CE2 File Offset: 0x00AA2EE2
		public FRotator CurrentRotation { get; private set; }

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x06025E7C RID: 155260 RVA: 0x00AA4CEB File Offset: 0x00AA2EEB
		// (set) Token: 0x06025E7D RID: 155261 RVA: 0x00AA4CF3 File Offset: 0x00AA2EF3
		public float CurrentArmLength { get; private set; }

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x06025E7E RID: 155262 RVA: 0x00AA4CFC File Offset: 0x00AA2EFC
		// (set) Token: 0x06025E7F RID: 155263 RVA: 0x00AA4D04 File Offset: 0x00AA2F04
		public FVectorDouble CurrentArmOffsetLocation { get; private set; }

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x06025E80 RID: 155264 RVA: 0x00AA4D0D File Offset: 0x00AA2F0D
		// (set) Token: 0x06025E81 RID: 155265 RVA: 0x00AA4D15 File Offset: 0x00AA2F15
		public FRotator CurrentArmOffsetRotation { get; private set; }

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x06025E82 RID: 155266 RVA: 0x00AA4D1E File Offset: 0x00AA2F1E
		// (set) Token: 0x06025E83 RID: 155267 RVA: 0x00AA4D26 File Offset: 0x00AA2F26
		public bool CurrentArmCollisionTest { get; private set; }

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x06025E84 RID: 155268 RVA: 0x00AA4D2F File Offset: 0x00AA2F2F
		// (set) Token: 0x06025E85 RID: 155269 RVA: 0x00AA4D37 File Offset: 0x00AA2F37
		public float CurrentFieldOfView { get; private set; }

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x06025E86 RID: 155270 RVA: 0x00AA4D40 File Offset: 0x00AA2F40
		// (set) Token: 0x06025E87 RID: 155271 RVA: 0x00AA4D48 File Offset: 0x00AA2F48
		public float CurrentFocalDistance { get; private set; }

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x06025E88 RID: 155272 RVA: 0x00AA4D51 File Offset: 0x00AA2F51
		// (set) Token: 0x06025E89 RID: 155273 RVA: 0x00AA4D59 File Offset: 0x00AA2F59
		public float CurrentAperture { get; private set; }

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x06025E8A RID: 155274 RVA: 0x00AA4D62 File Offset: 0x00AA2F62
		// (set) Token: 0x06025E8B RID: 155275 RVA: 0x00AA4D6A File Offset: 0x00AA2F6A
		public float CurrentFocalRegion { get; private set; }

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x06025E8C RID: 155276 RVA: 0x00AA4D73 File Offset: 0x00AA2F73
		// (set) Token: 0x06025E8D RID: 155277 RVA: 0x00AA4D7B File Offset: 0x00AA2F7B
		public float CurrentPostProcessBlendWeight { get; private set; }

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x06025E8E RID: 155278 RVA: 0x00AA4D84 File Offset: 0x00AA2F84
		// (set) Token: 0x06025E8F RID: 155279 RVA: 0x00AA4D8C File Offset: 0x00AA2F8C
		public bool IsBlending { get; private set; }

		// Token: 0x06025E90 RID: 155280 RVA: 0x00AA4D95 File Offset: 0x00AA2F95
		public int GetOutputVersion()
		{
			return this.OutputVersion;
		}

		// Token: 0x06025E91 RID: 155281 RVA: 0x00AA4DA0 File Offset: 0x00AA2FA0
		public void BeginHandleBlend(SUiCameraAnimationBlendSettings settings, [Nullable(2)] Action<bool> onFinished = null)
		{
			this.UseAttributeCurves = true;
			this.PrepareBlend(settings.Time, null, true, true, true, true, true, onFinished);
			this.LoadBlendCurves(settings);
		}

		// Token: 0x06025E92 RID: 155282 RVA: 0x00AA4DD0 File Offset: 0x00AA2FD0
		[NullableContext(2)]
		public void BeginCameraModeBlend(float duration, Action<bool> onFinished = null)
		{
			this.UseAttributeCurves = false;
			this.PrepareBlend(duration, null, false, false, false, false, false, onFinished);
			this.StartPreparedBlend();
		}

		// Token: 0x06025E93 RID: 155283 RVA: 0x00AA4DF8 File Offset: 0x00AA2FF8
		public void StartFade(float duration, UCurveFloat curve, bool fadeArmLength = true, bool fadeArmRotationPitch = true, bool fadeArmRotationYaw = true, bool fadeArmRotationRoll = true)
		{
			this.UseAttributeCurves = false;
			this.PrepareBlend(duration / (float)TimeUtil.Instance.InverseMillisecond, curve, false, fadeArmLength, fadeArmRotationPitch, fadeArmRotationYaw, fadeArmRotationRoll, null);
			this.StartPreparedBlend();
		}

		// Token: 0x06025E94 RID: 155284 RVA: 0x00AA4E2F File Offset: 0x00AA302F
		public void DoMoveForward(float distance, float duration, UCurveFloat curve)
		{
			UiCameraLogicComponent component = base.Mode.GetComponent<UiCameraLogicComponent>();
			component.SetArmLength(component.DesiredArmLength - distance);
			this.StartFade(duration, curve, true, false, false, false);
		}

		// Token: 0x06025E95 RID: 155285 RVA: 0x00AA4E58 File Offset: 0x00AA3058
		public void CancelBlend()
		{
			Action<bool> finishedCallback = this.FinishedCallback;
			this.FinishedCallback = null;
			bool flag = this.IsBlending || this.PendingBlend;
			this.IsBlending = false;
			this.PendingBlend = false;
			this.Duration = 0f;
			this.Elapsed = 0f;
			this.Curve = null;
			this.CommonCurve = null;
			this.AttributeCurves.Clear();
			this.CurveLoadOperationId++;
			this.UseAttributeCurves = false;
			this.SetModeBlendBlocked(false);
			if (flag && finishedCallback != null)
			{
				finishedCallback(false);
			}
		}

		// Token: 0x06025E96 RID: 155286 RVA: 0x00AA4EE9 File Offset: 0x00AA30E9
		public void SnapToDesired()
		{
			this.CancelBlend();
			this.CopyDesired(base.Mode.GetComponent<UiCameraLogicComponent>());
			this.Initialized = true;
		}

		// Token: 0x06025E97 RID: 155287 RVA: 0x00AA4F0C File Offset: 0x00AA310C
		public override void Apply(UiCameraHandleData data)
		{
			UiCameraLogicComponent component = base.Mode.GetComponent<UiCameraLogicComponent>();
			if (!this.Initialized)
			{
				this.CopyDesired(component);
				this.Initialized = true;
				this.PendingBlend = false;
				return;
			}
			if (!this.PendingBlend || this.Duration <= 0f)
			{
				if (this.IsBlending)
				{
					this.CancelBlend();
				}
				this.CopyDesired(component);
				this.PendingBlend = false;
				return;
			}
			this.StartPreparedBlend();
		}

		// Token: 0x06025E98 RID: 155288 RVA: 0x00AA4F7C File Offset: 0x00AA317C
		public override void Tick(float deltaTime)
		{
			UiCameraLogicComponent component = base.Mode.GetComponent<UiCameraLogicComponent>();
			if (!this.IsBlending)
			{
				if (this.Initialized && this.AppliedLogicStateVersion != component.GetStateVersion())
				{
					this.CopyDesired(component);
				}
				return;
			}
			this.Elapsed = MathF.Min(this.Elapsed + deltaTime, this.Duration);
			float alpha = this.GetAlpha();
			if (this.BlendAll)
			{
				this.CurrentLocation = UKismetMathLibrary.D_VLerp(this.StartLocation, component.DesiredLocation, (double)this.GetAttributeAlpha(EUiCameraAnimationAttributeType.Location, alpha));
				this.CurrentArmOffsetLocation = UKismetMathLibrary.D_VLerp(this.StartArmOffsetLocation, component.DesiredArmOffsetLocation, (double)this.GetAttributeAlpha(EUiCameraAnimationAttributeType.ArmOffsetLocation, alpha));
				this.CurrentFieldOfView = UiCameraBlendComponent.Lerp(this.StartFieldOfView, component.DesiredFieldOfView, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.CameraFieldOfView, alpha));
				this.CurrentFocalDistance = UiCameraBlendComponent.Lerp(this.StartFocalDistance, component.DesiredFocalDistance, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.FocalDistance, alpha));
				this.CurrentAperture = UiCameraBlendComponent.Lerp(this.StartAperture, component.DesiredAperture, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.Aperture, alpha));
				this.CurrentFocalRegion = UiCameraBlendComponent.Lerp(this.StartFocalRegion, component.DesiredFocalRegion, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.EUiCameraAnimationAttributeType_MAX, alpha));
				this.CurrentPostProcessBlendWeight = UiCameraBlendComponent.Lerp(this.StartPostProcessBlendWeight, component.DesiredPostProcessBlendWeight, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.PostProcessBlendWeight, alpha));
			}
			this.CurrentArmLength = ((this.BlendAll || this.BlendArmLength) ? UiCameraBlendComponent.Lerp(this.StartArmLength, component.DesiredArmLength, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.ArmLength, alpha)) : component.DesiredArmLength);
			this.CurrentRotation = (this.BlendAll ? UKismetMathLibrary.RLerp(this.StartRotation, component.DesiredRotation, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.Rotation, alpha), true) : component.DesiredRotation);
			this.CurrentArmOffsetRotation = (this.BlendAll ? UKismetMathLibrary.RLerp(this.StartArmOffsetRotation, component.DesiredArmOffsetRotation, this.GetAttributeAlpha(EUiCameraAnimationAttributeType.ArmOffsetRotation, alpha), true) : UiCameraBlendComponent.LerpArmRotation(this.StartArmOffsetRotation, component.DesiredArmOffsetRotation, alpha, this.BlendArmRotationPitch, this.BlendArmRotationYaw, this.BlendArmRotationRoll));
			this.CurrentArmCollisionTest = component.DesiredArmCollisionTest;
			this.AppliedLogicStateVersion = component.GetStateVersion();
			this.OutputVersion++;
			if (this.Elapsed >= this.Duration)
			{
				this.CopyDesired(component);
				this.FinishBlend();
			}
		}

		// Token: 0x06025E99 RID: 155289 RVA: 0x00AA51B9 File Offset: 0x00AA33B9
		public override void Clear()
		{
			this.CancelBlend();
			this.Initialized = false;
			this.AppliedLogicStateVersion = -1;
			this.OutputVersion = 0;
		}

		// Token: 0x06025E9A RID: 155290 RVA: 0x00AA51D8 File Offset: 0x00AA33D8
		[NullableContext(2)]
		private void PrepareBlend(float duration, UCurveFloat curve, bool blendAll, bool blendArmLength, bool blendArmRotationPitch, bool blendArmRotationYaw, bool blendArmRotationRoll, Action<bool> onFinished)
		{
			this.Duration = MathF.Max(duration, 0f);
			this.Curve = curve;
			this.BlendAll = blendAll;
			this.BlendArmLength = blendArmLength;
			this.BlendArmRotationPitch = blendArmRotationPitch;
			this.BlendArmRotationYaw = blendArmRotationYaw;
			this.BlendArmRotationRoll = blendArmRotationRoll;
			this.FinishedCallback = onFinished;
			this.PendingBlend = (this.Duration > 0f);
		}

		// Token: 0x06025E9B RID: 155291 RVA: 0x00AA5240 File Offset: 0x00AA3440
		private void CaptureStart()
		{
			this.StartLocation = this.CurrentLocation;
			this.StartRotation = this.CurrentRotation;
			this.StartArmLength = this.CurrentArmLength;
			this.StartArmOffsetLocation = this.CurrentArmOffsetLocation;
			this.StartArmOffsetRotation = this.CurrentArmOffsetRotation;
			this.StartFieldOfView = this.CurrentFieldOfView;
			this.StartFocalDistance = this.CurrentFocalDistance;
			this.StartAperture = this.CurrentAperture;
			this.StartFocalRegion = this.CurrentFocalRegion;
			this.StartPostProcessBlendWeight = this.CurrentPostProcessBlendWeight;
		}

		// Token: 0x06025E9C RID: 155292 RVA: 0x00AA52C8 File Offset: 0x00AA34C8
		private void StartPreparedBlend()
		{
			UiCameraLogicComponent component = base.Mode.GetComponent<UiCameraLogicComponent>();
			if (this.Duration <= 0f)
			{
				this.CopyDesired(component);
				this.PendingBlend = false;
				this.FinishBlend();
				return;
			}
			this.CaptureStart();
			this.Elapsed = 0f;
			this.IsBlending = true;
			this.PendingBlend = false;
			this.SetModeBlendBlocked(true);
		}

		// Token: 0x06025E9D RID: 155293 RVA: 0x00AA532C File Offset: 0x00AA352C
		private void CopyDesired(UiCameraLogicComponent logic)
		{
			this.CurrentLocation = logic.DesiredLocation;
			this.CurrentRotation = logic.DesiredRotation;
			this.CurrentArmLength = logic.DesiredArmLength;
			this.CurrentArmOffsetLocation = logic.DesiredArmOffsetLocation;
			this.CurrentArmOffsetRotation = logic.DesiredArmOffsetRotation;
			this.CurrentArmCollisionTest = logic.DesiredArmCollisionTest;
			this.CurrentFieldOfView = logic.DesiredFieldOfView;
			this.CurrentFocalDistance = logic.DesiredFocalDistance;
			this.CurrentAperture = logic.DesiredAperture;
			this.CurrentFocalRegion = logic.DesiredFocalRegion;
			this.CurrentPostProcessBlendWeight = logic.DesiredPostProcessBlendWeight;
			this.AppliedLogicStateVersion = logic.GetStateVersion();
			this.OutputVersion++;
		}

		// Token: 0x06025E9E RID: 155294 RVA: 0x00AA53D8 File Offset: 0x00AA35D8
		private void FinishBlend()
		{
			Action<bool> finishedCallback = this.FinishedCallback;
			this.FinishedCallback = null;
			this.IsBlending = false;
			this.Duration = 0f;
			this.Elapsed = 0f;
			this.Curve = null;
			this.CommonCurve = null;
			this.AttributeCurves.Clear();
			this.CurveLoadOperationId++;
			this.UseAttributeCurves = false;
			this.SetModeBlendBlocked(false);
			if (finishedCallback == null)
			{
				return;
			}
			finishedCallback(true);
		}

		// Token: 0x06025E9F RID: 155295 RVA: 0x00AA5450 File Offset: 0x00AA3650
		private void SetModeBlendBlocked(bool blocked)
		{
			UiCameraNormalMode uiCameraNormalMode = base.Mode as UiCameraNormalMode;
			if (uiCameraNormalMode != null)
			{
				uiCameraNormalMode.SetInputBlocked(EUiCameraInputBlockReason.Blend, blocked);
			}
		}

		// Token: 0x06025EA0 RID: 155296 RVA: 0x00AA5474 File Offset: 0x00AA3674
		private float GetAlpha()
		{
			float num = (this.Duration > 0f) ? (this.Elapsed / this.Duration) : 1f;
			UCurveFloat curve = this.Curve;
			if (curve != null && curve.IsValid())
			{
				num = this.Curve.GetFloatValue(num);
			}
			return MathUtils.Instance.Clamp(num, 0f, 1f);
		}

		// Token: 0x06025EA1 RID: 155297 RVA: 0x00AA54DC File Offset: 0x00AA36DC
		private float GetAttributeAlpha(EUiCameraAnimationAttributeType attributeType, float defaultAlpha)
		{
			UCurveFloat ucurveFloat2;
			UCurveFloat ucurveFloat = this.AttributeCurves.TryGetValue(attributeType, out ucurveFloat2) ? ucurveFloat2 : this.CommonCurve;
			if (ucurveFloat != null && ucurveFloat.IsValid())
			{
				return MathUtils.Instance.Clamp(ucurveFloat.GetFloatValue(this.Elapsed), 0f, 1f);
			}
			if (!this.UseAttributeCurves)
			{
				return defaultAlpha;
			}
			return 0f;
		}

		// Token: 0x06025EA2 RID: 155298 RVA: 0x00AA5540 File Offset: 0x00AA3740
		private void LoadBlendCurves(SUiCameraAnimationBlendSettings settings)
		{
			int num = this.CurveLoadOperationId + 1;
			this.CurveLoadOperationId = num;
			int operationId = num;
			this.LoadCurve(settings.CommonCurve, delegate(UCurveFloat curve)
			{
				this.CommonCurve = curve;
			}, operationId);
			foreach (KeyValuePair<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>> keyValuePair in settings.CurveMap)
			{
				TEnumAsByte<EUiCameraAnimationAttributeType> tenumAsByte;
				TSoftObjectPtr<UCurveFloat> tsoftObjectPtr;
				keyValuePair.Deconstruct(out tenumAsByte, out tsoftObjectPtr);
				TEnumAsByte<EUiCameraAnimationAttributeType> value = tenumAsByte;
				TSoftObjectPtr<UCurveFloat> curveReference = tsoftObjectPtr;
				EUiCameraAnimationAttributeType attributeType = (EUiCameraAnimationAttributeType)value;
				this.LoadCurve(curveReference, delegate(UCurveFloat curve)
				{
					this.AttributeCurves[attributeType] = curve;
				}, operationId);
			}
		}

		// Token: 0x06025EA3 RID: 155299 RVA: 0x00AA55FC File Offset: 0x00AA37FC
		private void LoadCurve(TSoftObjectPtr<UCurveFloat> curveReference, Action<UCurveFloat> onLoaded, int operationId)
		{
			TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(curveReference);
			if (!UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
			{
				return;
			}
			string text = curveReference.ToAssetPathName();
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(text, delegate([Nullable(2)] UCurveFloat curve, string _)
			{
				if (operationId == this.CurveLoadOperationId && curve != null)
				{
					onLoaded(curve);
				}
			}, 100, "Ui.UiCamera");
		}

		// Token: 0x06025EA4 RID: 155300 RVA: 0x00AA5664 File Offset: 0x00AA3864
		private static float Lerp(float from, float to, float alpha)
		{
			return from + (to - from) * alpha;
		}

		// Token: 0x06025EA5 RID: 155301 RVA: 0x00AA5670 File Offset: 0x00AA3870
		private static FRotator LerpArmRotation(FRotator from, FRotator to, float alpha, bool pitch, bool yaw, bool roll)
		{
			return new FRotator(pitch ? UiCameraBlendComponent.Lerp(from.Pitch, to.Pitch, alpha) : to.Pitch, yaw ? UiCameraBlendComponent.Lerp(from.Yaw, to.Yaw, alpha) : to.Yaw, roll ? UiCameraBlendComponent.Lerp(from.Roll, to.Roll, alpha) : to.Roll);
		}

		// Token: 0x04014D85 RID: 85381
		private float Duration;

		// Token: 0x04014D86 RID: 85382
		private float Elapsed;

		// Token: 0x04014D87 RID: 85383
		[Nullable(2)]
		private UCurveFloat Curve;

		// Token: 0x04014D88 RID: 85384
		[Nullable(2)]
		private UCurveFloat CommonCurve;

		// Token: 0x04014D89 RID: 85385
		private readonly Dictionary<EUiCameraAnimationAttributeType, UCurveFloat> AttributeCurves = new Dictionary<EUiCameraAnimationAttributeType, UCurveFloat>();

		// Token: 0x04014D8A RID: 85386
		[Nullable(2)]
		private Action<bool> FinishedCallback;

		// Token: 0x04014D8B RID: 85387
		private bool PendingBlend;

		// Token: 0x04014D8C RID: 85388
		private bool BlendAll;

		// Token: 0x04014D8D RID: 85389
		private bool BlendArmLength;

		// Token: 0x04014D8E RID: 85390
		private bool BlendArmRotationPitch;

		// Token: 0x04014D8F RID: 85391
		private bool BlendArmRotationYaw;

		// Token: 0x04014D90 RID: 85392
		private bool BlendArmRotationRoll;

		// Token: 0x04014D91 RID: 85393
		private bool Initialized;

		// Token: 0x04014D92 RID: 85394
		private bool UseAttributeCurves;

		// Token: 0x04014D93 RID: 85395
		private int CurveLoadOperationId;

		// Token: 0x04014D94 RID: 85396
		private int AppliedLogicStateVersion = -1;

		// Token: 0x04014D95 RID: 85397
		private int OutputVersion;

		// Token: 0x04014D96 RID: 85398
		private FVectorDouble StartLocation;

		// Token: 0x04014D97 RID: 85399
		private FRotator StartRotation;

		// Token: 0x04014D98 RID: 85400
		private float StartArmLength;

		// Token: 0x04014D99 RID: 85401
		private FVectorDouble StartArmOffsetLocation;

		// Token: 0x04014D9A RID: 85402
		private FRotator StartArmOffsetRotation;

		// Token: 0x04014D9B RID: 85403
		private float StartFieldOfView;

		// Token: 0x04014D9C RID: 85404
		private float StartFocalDistance;

		// Token: 0x04014D9D RID: 85405
		private float StartAperture;

		// Token: 0x04014D9E RID: 85406
		private float StartFocalRegion;

		// Token: 0x04014D9F RID: 85407
		private float StartPostProcessBlendWeight;
	}
}

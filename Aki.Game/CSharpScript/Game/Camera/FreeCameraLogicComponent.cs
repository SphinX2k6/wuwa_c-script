using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D1 RID: 29393
	[NullableContext(1)]
	[Nullable(0)]
	public class FreeCameraLogicComponent : EntityComponent
	{
		// Token: 0x17009F38 RID: 40760
		// (get) Token: 0x06048218 RID: 295448 RVA: 0x01280854 File Offset: 0x0127EA54
		[Nullable(2)]
		private ACameraActor CameraActor
		{
			[NullableContext(2)]
			get
			{
				FreeCameraDisplayComponent displayComponent = this.DisplayComponent;
				if (displayComponent == null)
				{
					return null;
				}
				return displayComponent.CameraActor;
			}
		}

		// Token: 0x06048219 RID: 295449 RVA: 0x01280867 File Offset: 0x0127EA67
		protected override bool OnInit()
		{
			this.DisplayComponent = base.Entity.GetComponent<FreeCameraDisplayComponent>();
			return true;
		}

		// Token: 0x0604821A RID: 295450 RVA: 0x0128087C File Offset: 0x0127EA7C
		public void InitConfig(float[] configIdList)
		{
			bool flag = Info.Instance.IsMobileInputModel();
			SFreeCamera sfreeCamera = null;
			foreach (float num in configIdList)
			{
				SFreeCamera dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SFreeCamera>(EDataTable.FreeCameraConfig, num.ToString());
				if (!(dataTableRowFromName == null) && ((!flag && dataTableRowFromName.PC生效) || (flag && dataTableRowFromName.手机生效)))
				{
					sfreeCamera = dataTableRowFromName;
				}
			}
			if (sfreeCamera == null)
			{
				return;
			}
			Vector initLocation = this.InitLocation;
			FVector 初始位置 = sfreeCamera.初始位置;
			initLocation.FromUeVector(初始位置);
			Rotator initRotation = this.InitRotation;
			FRotator 初始旋转 = sfreeCamera.初始旋转;
			initRotation.FromUeRotator(初始旋转);
			this.LimitConfigs = FreeCameraLogicComponent.TMapToMap<EFreeCameraLimit>(sfreeCamera.限制);
			this.InitFov = sfreeCamera.初始FOV;
			this.ResetToInit(0f, null, null);
		}

		// Token: 0x0604821B RID: 295451 RVA: 0x0128093E File Offset: 0x0127EB3E
		[NullableContext(2)]
		public void ResetToInit(float blendTime = 0f, CurveBase blendCurve = null, Action callback = null)
		{
			this.ApplyCameraBlend(this.InitLocation, this.InitRotation, 0f, blendTime, blendCurve, this.InitFov, callback);
		}

		// Token: 0x0604821C RID: 295452 RVA: 0x01280960 File Offset: 0x0127EB60
		public void ReceiveCameraInput(FreeCameraLogicComponent.ICameraMoveData forwardData, FreeCameraLogicComponent.ICameraMoveData rightData, FreeCameraLogicComponent.ICameraMoveData upData, float deltaLookUp, float deltaTurn, float deltaFov, float blendTime = 0f, [Nullable(2)] CurveBase blendCurve = null, bool blendOnlyWhenExceedLimit = false)
		{
			this.HandleCameraInput(forwardData, rightData, upData, deltaLookUp, deltaTurn, deltaFov, blendTime, blendCurve, blendOnlyWhenExceedLimit, null);
		}

		// Token: 0x0604821D RID: 295453 RVA: 0x01280984 File Offset: 0x0127EB84
		public void HandleCameraInput(FreeCameraLogicComponent.ICameraMoveData forwardData, FreeCameraLogicComponent.ICameraMoveData rightData, FreeCameraLogicComponent.ICameraMoveData upData, float lookUp, float turn, float deltaFov, float blendTime, [Nullable(2)] CurveBase blendCurve = null, bool blendOnlyWhenExceedLimit = false, [Nullable(2)] Action callback = null)
		{
			if (this.CameraState == FreeCameraLogicComponent.ECameraState.Blending)
			{
				this.BlendFinish();
			}
			ACameraActor cameraActor = this.CameraActor;
			UCameraComponent ucameraComponent = (cameraActor != null) ? cameraActor.CameraComponent : null;
			if (cameraActor == null || !cameraActor.IsValid() || ucameraComponent == null || !ucameraComponent.IsValid())
			{
				if (callback != null)
				{
					callback();
				}
				return;
			}
			this.CameraRotation.Quaternion(this.TempQuat);
			if (forwardData.IsMoveBySelf)
			{
				this.TempQuat.RotateVector(Vector.ForwardVectorProxy, this.CameraForward);
			}
			else
			{
				this.TempCameraRotation.DeepCopy(this.CameraRotation);
				this.TempCameraRotation.Pitch = 0f;
				this.TempCameraRotation.Quaternion(this.TempQuat2);
				this.TempQuat2.RotateVector(Vector.ForwardVectorProxy, this.CameraForward);
			}
			if (rightData.IsMoveBySelf)
			{
				this.TempQuat.RotateVector(Vector.RightVectorProxy, this.CameraRight);
			}
			else
			{
				this.TempCameraRotation.DeepCopy(this.CameraRotation);
				this.TempCameraRotation.Roll = 0f;
				this.TempCameraRotation.Quaternion(this.TempQuat2);
				this.TempQuat2.RotateVector(Vector.RightVectorProxy, this.CameraRight);
			}
			if (upData.IsMoveBySelf)
			{
				this.TempQuat.RotateVector(Vector.UpVectorProxy, this.CameraUp);
			}
			else
			{
				this.TempCameraRotation.DeepCopy(this.CameraRotation);
				this.TempCameraRotation.Yaw = 0f;
				this.TempCameraRotation.Quaternion(this.TempQuat2);
				this.TempQuat2.RotateVector(Vector.UpVectorProxy, this.CameraUp);
			}
			this.CameraForward.Multiply((double)forwardData.Distance, this.TempForwardVector);
			this.CameraRight.Multiply((double)rightData.Distance, this.TempRightVector);
			this.CameraUp.Multiply((double)upData.Distance, this.TempUpVector);
			this.CameraLocation.Addition(this.TempForwardVector, this.DesiredCameraLocation);
			this.DesiredCameraLocation.Addition(this.TempRightVector, this.DesiredCameraLocation);
			this.DesiredCameraLocation.Addition(this.TempUpVector, this.DesiredCameraLocation);
			this.TempRotator.Set(lookUp, turn, 0f);
			this.TempRotator.AdditionEqual(this.CameraRotation);
			Rotator tempRotator = this.TempRotator;
			float num = this.CorrectFOV(this.CurrentFov - deltaFov);
			this.DesiredCameraRotation.DeepCopy(tempRotator);
			if (blendTime == 0f)
			{
				this.CorrectLocation(this.DesiredCameraLocation);
				this.CorrectRotation(tempRotator);
				this.CameraLocation.DeepCopy(this.DesiredCameraLocation);
				this.CameraRotation.DeepCopy(tempRotator);
				if (num > 0f)
				{
					ucameraComponent.FieldOfView = num;
					this.CurrentFov = num;
				}
				if (callback != null)
				{
					callback();
				}
				return;
			}
			this.BlendTime = blendTime;
			this.BlendElapsedTime = 0f;
			if (blendCurve != null)
			{
				this.BlendCurve = blendCurve;
			}
			else
			{
				this.BlendCurve = CurveUtils.CreateCurve(ECurveType.Linear, Array.Empty<float>());
			}
			this.StartFov = ucameraComponent.FieldOfView;
			if (num > 0f)
			{
				this.DesiredFov = num;
				this.IsBlendFov = true;
			}
			bool flag = this.CorrectLocation(this.CameraLocation);
			this.CorrectRotation(this.CameraRotation);
			this.BlendFinishCallback = callback;
			this.StartCameraLocation.DeepCopy(this.CameraLocation);
			this.StartCameraRotation.DeepCopy(this.CameraRotation);
			this.CameraState = ((!blendOnlyWhenExceedLimit || (blendOnlyWhenExceedLimit && flag)) ? FreeCameraLogicComponent.ECameraState.Blending : FreeCameraLogicComponent.ECameraState.None);
		}

		// Token: 0x0604821E RID: 295454 RVA: 0x01280D08 File Offset: 0x0127EF08
		[NullableContext(2)]
		public void ApplyCameraBlend([Nullable(1)] Vector lookAtPosition, Rotator lookAtRotation, float forwardDistance, float blendTime, CurveBase blendCurve = null, float fov = -1f, Action callback = null)
		{
			if (this.CameraState == FreeCameraLogicComponent.ECameraState.Blending)
			{
				this.BlendFinish();
			}
			ACameraActor cameraActor = this.CameraActor;
			UCameraComponent ucameraComponent = (cameraActor != null) ? cameraActor.CameraComponent : null;
			if (cameraActor == null || !cameraActor.IsValid() || ucameraComponent == null || !ucameraComponent.IsValid())
			{
				if (callback != null)
				{
					callback();
				}
				return;
			}
			this.CameraRotation.Quaternion(this.TempQuat);
			this.TempQuat.RotateVector(Vector.ForwardVectorProxy, this.CameraForward);
			this.TempQuat.RotateVector(Vector.RightVectorProxy, this.CameraRight);
			this.CameraForward.Multiply((double)(-(double)forwardDistance), this.TempForwardVector);
			lookAtPosition.Addition(this.TempForwardVector, this.DesiredCameraLocation);
			this.DesiredCameraLocation.Addition(this.TempRightVector, this.DesiredCameraLocation);
			Rotator rotator = lookAtRotation;
			if (rotator == null)
			{
				rotator = this.InitRotation;
			}
			float num = (fov > 0f) ? fov : this.InitFov;
			this.DesiredCameraRotation.DeepCopy(rotator);
			if (blendTime == 0f)
			{
				this.CameraLocation.DeepCopy(this.DesiredCameraLocation);
				this.CameraRotation.DeepCopy(rotator);
				if (num > 0f)
				{
					ucameraComponent.FieldOfView = num;
					this.CurrentFov = num;
				}
				if (callback != null)
				{
					callback();
				}
				return;
			}
			this.BlendTime = blendTime;
			this.BlendElapsedTime = 0f;
			if (blendCurve != null)
			{
				this.BlendCurve = blendCurve;
			}
			else
			{
				this.BlendCurve = CurveUtils.CreateCurve(ECurveType.Linear, Array.Empty<float>());
			}
			this.StartFov = ucameraComponent.FieldOfView;
			if (num > 0f)
			{
				this.DesiredFov = num;
				this.IsBlendFov = true;
			}
			this.BlendFinishCallback = callback;
			this.StartCameraLocation.DeepCopy(this.CameraLocation);
			this.StartCameraRotation.DeepCopy(this.CameraRotation);
			this.CameraState = FreeCameraLogicComponent.ECameraState.Blending;
		}

		// Token: 0x0604821F RID: 295455 RVA: 0x01280ED4 File Offset: 0x0127F0D4
		private void BlendFinish()
		{
			this.DesiredFov = -1f;
			this.IsBlendFov = false;
			this.BlendTime = 0f;
			this.BlendElapsedTime = 0f;
			this.BlendCurve = null;
			this.CameraState = FreeCameraLogicComponent.ECameraState.None;
			Action blendFinishCallback = this.BlendFinishCallback;
			if (blendFinishCallback != null)
			{
				blendFinishCallback();
			}
			this.BlendFinishCallback = null;
		}

		// Token: 0x06048220 RID: 295456 RVA: 0x01280F30 File Offset: 0x0127F130
		protected override void OnAfterTick(float deltaTime)
		{
			ACameraActor cameraActor = this.CameraActor;
			UCameraComponent ucameraComponent = (cameraActor != null) ? cameraActor.CameraComponent : null;
			if (cameraActor == null || !cameraActor.IsValid() || ucameraComponent == null || !ucameraComponent.IsValid())
			{
				return;
			}
			if (this.IsBlendFov)
			{
				ucameraComponent.FieldOfView = this.CurrentFov;
			}
			float deltaSeconds = deltaTime * 0.001f;
			this.UpdateBlending(deltaSeconds);
			ACameraActor cameraActor2 = this.CameraActor;
			if (cameraActor2 == null)
			{
				return;
			}
			cameraActor2.D_K2_SetActorLocationAndRotation(this.CameraLocation.ToUeVector(false), this.CameraRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, true);
		}

		// Token: 0x06048221 RID: 295457 RVA: 0x01280FBC File Offset: 0x0127F1BC
		private void UpdateBlending(float deltaSeconds)
		{
			if (this.CameraState == FreeCameraLogicComponent.ECameraState.None)
			{
				return;
			}
			if (this.BlendElapsedTime >= this.BlendTime)
			{
				this.BlendFinish();
				return;
			}
			this.BlendElapsedTime += deltaSeconds;
			float currentValue = this.BlendCurve.GetCurrentValue(this.BlendElapsedTime / this.BlendTime);
			Vector.Lerp(this.StartCameraLocation, this.DesiredCameraLocation, (double)currentValue, this.CameraLocation);
			Rotator.Lerp(this.StartCameraRotation, this.DesiredCameraRotation, currentValue, this.CameraRotation);
			if (this.IsBlendFov)
			{
				this.CurrentFov = MathUtils.Instance.Lerp(this.StartFov, this.DesiredFov, currentValue);
			}
		}

		// Token: 0x06048222 RID: 295458 RVA: 0x01281068 File Offset: 0x0127F268
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public static Dictionary<TEnumAsByte<T>, float> TMapToMap<T>([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<T>, float> tMap) where T : Enum
		{
			int num = tMap.Num();
			Dictionary<TEnumAsByte<T>, float> dictionary = new Dictionary<TEnumAsByte<T>, float>(num);
			if (num == 0)
			{
				return dictionary;
			}
			foreach (KeyValuePair<TEnumAsByte<T>, float> keyValuePair in tMap)
			{
				TEnumAsByte<T> tenumAsByte;
				float num2;
				keyValuePair.Deconstruct(out tenumAsByte, out num2);
				TEnumAsByte<T> key = tenumAsByte;
				float value = num2;
				dictionary[key] = value;
			}
			return dictionary;
		}

		// Token: 0x06048223 RID: 295459 RVA: 0x012810D8 File Offset: 0x0127F2D8
		protected bool CorrectLocation(Vector location)
		{
			bool flag = false;
			if (this.LimitConfigs.ContainsKey(EFreeCameraLimit.世界X轴偏移上界))
			{
				double num = this.InitLocation.X + (double)this.LimitConfigs[EFreeCameraLimit.世界X轴偏移上界];
				location.X = Math.Min(num, location.X);
				flag = (flag || location.X == num);
			}
			if (this.LimitConfigs.ContainsKey(EFreeCameraLimit.世界X轴偏移下界))
			{
				double num2 = this.InitLocation.X + (double)this.LimitConfigs[EFreeCameraLimit.世界X轴偏移下界];
				location.X = Math.Max(num2, location.X);
				flag = (flag || location.X == num2);
			}
			if (this.LimitConfigs.ContainsKey(EFreeCameraLimit.世界Y轴偏移上界))
			{
				double num3 = this.InitLocation.Y + (double)this.LimitConfigs[EFreeCameraLimit.世界Y轴偏移上界];
				location.Y = Math.Min(num3, location.Y);
				flag = (flag || location.Y == num3);
			}
			if (this.LimitConfigs.ContainsKey(EFreeCameraLimit.世界Y轴偏移下界))
			{
				double num4 = this.InitLocation.Y + (double)this.LimitConfigs[EFreeCameraLimit.世界Y轴偏移下界];
				location.Y = Math.Max(num4, location.Y);
				flag = (flag || location.Y == num4);
			}
			if (this.LimitConfigs.ContainsKey(EFreeCameraLimit.世界Z轴偏移上界))
			{
				double num5 = this.InitLocation.Z + (double)this.LimitConfigs[EFreeCameraLimit.世界Z轴偏移上界];
				location.Z = Math.Min(num5, location.Z);
				flag = (flag || location.Z == num5);
			}
			if (this.LimitConfigs.ContainsKey(EFreeCameraLimit.世界Z轴偏移下界))
			{
				double num6 = this.InitLocation.Z + (double)this.LimitConfigs[EFreeCameraLimit.世界Z轴偏移下界];
				location.Z = Math.Max(num6, location.Z);
				flag = (flag || location.Z == num6);
			}
			return flag;
		}

		// Token: 0x06048224 RID: 295460 RVA: 0x012812EC File Offset: 0x0127F4EC
		protected void CorrectRotation(Rotator Rotation)
		{
			float max = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Yaw限制Max) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Yaw限制Max]) : 180f;
			float min = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Yaw限制Min) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Yaw限制Min]) : -180f;
			Rotation.Yaw = MathUtils.Instance.Clamp(Rotation.Yaw, min, max);
			float max2 = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Pitch限制Max) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Pitch限制Max]) : 90f;
			float min2 = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Pitch限制Min) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Pitch限制Min]) : -90f;
			Rotation.Pitch = MathUtils.Instance.Clamp(Rotation.Pitch, min2, max2);
		}

		// Token: 0x06048225 RID: 295461 RVA: 0x0128140C File Offset: 0x0127F60C
		protected float CorrectFOV(float FoV)
		{
			float min = this.LimitConfigs.ContainsKey(EFreeCameraLimit.最小FOV) ? this.LimitConfigs[EFreeCameraLimit.最小FOV] : 0f;
			float max = this.LimitConfigs.ContainsKey(EFreeCameraLimit.最大FOV) ? this.LimitConfigs[EFreeCameraLimit.最大FOV] : 170f;
			return MathUtils.Instance.Clamp(FoV, min, max);
		}

		// Token: 0x06048226 RID: 295462 RVA: 0x01281480 File Offset: 0x0127F680
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FreeCameraLogicComponent freeCameraLogicComponent = (FreeCameraLogicComponent)componentTemplate;
			if (base.CanResetComponentProperty("DisplayComponent"))
			{
				if (freeCameraLogicComponent.DisplayComponent == null)
				{
					this.DisplayComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FreeCameraDisplayComponent>(this.DisplayComponent), "DisplayComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InitLocation") && freeCameraLogicComponent.InitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.InitLocation), "InitLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("InitRotation") && freeCameraLogicComponent.InitRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.InitRotation), "InitRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("InitFov"))
			{
				this.InitFov = freeCameraLogicComponent.InitFov;
			}
			if (base.CanResetComponentProperty("CameraState"))
			{
				this.CameraState = freeCameraLogicComponent.CameraState;
			}
			if (base.CanResetComponentProperty("BlendTime"))
			{
				this.BlendTime = freeCameraLogicComponent.BlendTime;
			}
			if (base.CanResetComponentProperty("BlendElapsedTime"))
			{
				this.BlendElapsedTime = freeCameraLogicComponent.BlendElapsedTime;
			}
			if (base.CanResetComponentProperty("BlendCurve"))
			{
				if (freeCameraLogicComponent.BlendCurve == null)
				{
					this.BlendCurve = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CurveBase>(this.BlendCurve), "BlendCurve"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BlendFinishCallback"))
			{
				if (freeCameraLogicComponent.BlendFinishCallback == null)
				{
					this.BlendFinishCallback = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.BlendFinishCallback), "BlendFinishCallback"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraRotation") && freeCameraLogicComponent.CameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.CameraRotation), "CameraRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("StartCameraRotation") && freeCameraLogicComponent.StartCameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.StartCameraRotation), "StartCameraRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DesiredCameraRotation") && freeCameraLogicComponent.DesiredCameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.DesiredCameraRotation), "DesiredCameraRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("IsBlendFov"))
			{
				this.IsBlendFov = freeCameraLogicComponent.IsBlendFov;
			}
			if (base.CanResetComponentProperty("StartFov"))
			{
				this.StartFov = freeCameraLogicComponent.StartFov;
			}
			if (base.CanResetComponentProperty("DesiredFov"))
			{
				this.DesiredFov = freeCameraLogicComponent.DesiredFov;
			}
			if (base.CanResetComponentProperty("CurrentFov"))
			{
				this.CurrentFov = freeCameraLogicComponent.CurrentFov;
			}
			if (base.CanResetComponentProperty("StartCameraLocation") && freeCameraLogicComponent.StartCameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.StartCameraLocation), "StartCameraLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DesiredCameraLocation") && freeCameraLogicComponent.DesiredCameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.DesiredCameraLocation), "DesiredCameraLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraLocation") && freeCameraLogicComponent.CameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CameraLocation), "CameraLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraForward") && freeCameraLogicComponent.CameraForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CameraForward), "CameraForward"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraRight") && freeCameraLogicComponent.CameraRight != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CameraRight), "CameraRight"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraUp") && freeCameraLogicComponent.CameraUp != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CameraUp), "CameraUp"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempForwardVector") && freeCameraLogicComponent.TempForwardVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempForwardVector), "TempForwardVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempRightVector") && freeCameraLogicComponent.TempRightVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempRightVector), "TempRightVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempUpVector") && freeCameraLogicComponent.TempUpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempUpVector), "TempUpVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempRotator") && freeCameraLogicComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TempRotator), "TempRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempQuat") && freeCameraLogicComponent.TempQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TempQuat), "TempQuat"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempCameraRotation") && freeCameraLogicComponent.TempCameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TempCameraRotation), "TempCameraRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempQuat2") && freeCameraLogicComponent.TempQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TempQuat2), "TempQuat2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("LimitConfigs"))
			{
				if (freeCameraLogicComponent.LimitConfigs == null)
				{
					this.LimitConfigs = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<TEnumAsByte<EFreeCameraLimit>, float>>(this.LimitConfigs), "LimitConfigs"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040260E0 RID: 155872
		private const int YAW_MAX = 180;

		// Token: 0x040260E1 RID: 155873
		private const int PITCH_MAX = 90;

		// Token: 0x040260E2 RID: 155874
		private const int FOV_MIN = 0;

		// Token: 0x040260E3 RID: 155875
		private const int FOV_MAX = 170;

		// Token: 0x040260E4 RID: 155876
		[Nullable(2)]
		private FreeCameraDisplayComponent DisplayComponent;

		// Token: 0x040260E5 RID: 155877
		private readonly Vector InitLocation = Vector.Create();

		// Token: 0x040260E6 RID: 155878
		private readonly Rotator InitRotation = Rotator.Create();

		// Token: 0x040260E7 RID: 155879
		private float InitFov;

		// Token: 0x040260E8 RID: 155880
		private FreeCameraLogicComponent.ECameraState CameraState;

		// Token: 0x040260E9 RID: 155881
		private float BlendTime;

		// Token: 0x040260EA RID: 155882
		private float BlendElapsedTime;

		// Token: 0x040260EB RID: 155883
		[Nullable(2)]
		private CurveBase BlendCurve;

		// Token: 0x040260EC RID: 155884
		[Nullable(2)]
		private Action BlendFinishCallback;

		// Token: 0x040260ED RID: 155885
		private readonly Rotator CameraRotation = Rotator.Create();

		// Token: 0x040260EE RID: 155886
		private readonly Rotator StartCameraRotation = Rotator.Create();

		// Token: 0x040260EF RID: 155887
		private readonly Rotator DesiredCameraRotation = Rotator.Create();

		// Token: 0x040260F0 RID: 155888
		private bool IsBlendFov;

		// Token: 0x040260F1 RID: 155889
		private float StartFov;

		// Token: 0x040260F2 RID: 155890
		private float DesiredFov;

		// Token: 0x040260F3 RID: 155891
		private float CurrentFov;

		// Token: 0x040260F4 RID: 155892
		private readonly Vector StartCameraLocation = Vector.Create();

		// Token: 0x040260F5 RID: 155893
		private readonly Vector DesiredCameraLocation = Vector.Create();

		// Token: 0x040260F6 RID: 155894
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x040260F7 RID: 155895
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x040260F8 RID: 155896
		private readonly Vector CameraRight = Vector.Create();

		// Token: 0x040260F9 RID: 155897
		private readonly Vector CameraUp = Vector.Create();

		// Token: 0x040260FA RID: 155898
		private readonly Vector TempForwardVector = Vector.Create();

		// Token: 0x040260FB RID: 155899
		private readonly Vector TempRightVector = Vector.Create();

		// Token: 0x040260FC RID: 155900
		private readonly Vector TempUpVector = Vector.Create();

		// Token: 0x040260FD RID: 155901
		private readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x040260FE RID: 155902
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040260FF RID: 155903
		private readonly Rotator TempCameraRotation = Rotator.Create();

		// Token: 0x04026100 RID: 155904
		private readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026101 RID: 155905
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public Dictionary<TEnumAsByte<EFreeCameraLimit>, float> LimitConfigs = new Dictionary<TEnumAsByte<EFreeCameraLimit>, float>();

		// Token: 0x0200CFCB RID: 53195
		[NullableContext(0)]
		public enum ECameraState
		{
			// Token: 0x0403E7C3 RID: 255939
			None,
			// Token: 0x0403E7C4 RID: 255940
			Blending
		}

		// Token: 0x0200CFCC RID: 53196
		public interface ICameraMoveData
		{
			// Token: 0x1700A2DE RID: 41694
			// (get) Token: 0x0605227C RID: 336508
			// (set) Token: 0x0605227D RID: 336509
			float Distance { get; set; }

			// Token: 0x1700A2DF RID: 41695
			// (get) Token: 0x0605227E RID: 336510
			// (set) Token: 0x0605227F RID: 336511
			bool IsMoveBySelf { get; set; }
		}

		// Token: 0x0200CFCD RID: 53197
		[NullableContext(0)]
		public class CameraMoveDataImpl : FreeCameraLogicComponent.ICameraMoveData
		{
			// Token: 0x1700A2E0 RID: 41696
			// (get) Token: 0x06052280 RID: 336512 RVA: 0x0164E743 File Offset: 0x0164C943
			// (set) Token: 0x06052281 RID: 336513 RVA: 0x0164E74B File Offset: 0x0164C94B
			public float Distance { get; set; }

			// Token: 0x1700A2E1 RID: 41697
			// (get) Token: 0x06052282 RID: 336514 RVA: 0x0164E754 File Offset: 0x0164C954
			// (set) Token: 0x06052283 RID: 336515 RVA: 0x0164E75C File Offset: 0x0164C95C
			public bool IsMoveBySelf { get; set; }
		}
	}
}

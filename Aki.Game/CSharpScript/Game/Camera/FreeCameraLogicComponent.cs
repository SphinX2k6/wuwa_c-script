using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006453 RID: 25683
	[NullableContext(1)]
	[Nullable(0)]
	public class FreeCameraLogicComponent : EntityComponent
	{
		// Token: 0x170076AB RID: 30379
		// (get) Token: 0x0603E625 RID: 255525 RVA: 0x01223284 File Offset: 0x01221484
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

		// Token: 0x0603E626 RID: 255526 RVA: 0x01223297 File Offset: 0x01221497
		protected override bool OnInit()
		{
			this.DisplayComponent = base.Entity.GetComponent<FreeCameraDisplayComponent>();
			return true;
		}

		// Token: 0x0603E627 RID: 255527 RVA: 0x012232AC File Offset: 0x012214AC
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

		// Token: 0x0603E628 RID: 255528 RVA: 0x0122336E File Offset: 0x0122156E
		[NullableContext(2)]
		public void ResetToInit(float blendTime = 0f, CurveBase blendCurve = null, Action callback = null)
		{
			this.ApplyCameraBlend(this.InitLocation, this.InitRotation, 0f, blendTime, blendCurve, this.InitFov, callback);
		}

		// Token: 0x0603E629 RID: 255529 RVA: 0x01223390 File Offset: 0x01221590
		public void ReceiveCameraInput(FreeCameraLogicComponent.ICameraMoveData forwardData, FreeCameraLogicComponent.ICameraMoveData rightData, FreeCameraLogicComponent.ICameraMoveData upData, float deltaLookUp, float deltaTurn, float deltaFov, float blendTime = 0f, [Nullable(2)] CurveBase blendCurve = null, bool blendOnlyWhenExceedLimit = false)
		{
			this.HandleCameraInput(forwardData, rightData, upData, deltaLookUp, deltaTurn, deltaFov, blendTime, blendCurve, blendOnlyWhenExceedLimit, null);
		}

		// Token: 0x0603E62A RID: 255530 RVA: 0x012233B4 File Offset: 0x012215B4
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

		// Token: 0x0603E62B RID: 255531 RVA: 0x01223738 File Offset: 0x01221938
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

		// Token: 0x0603E62C RID: 255532 RVA: 0x01223904 File Offset: 0x01221B04
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

		// Token: 0x0603E62D RID: 255533 RVA: 0x01223960 File Offset: 0x01221B60
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

		// Token: 0x0603E62E RID: 255534 RVA: 0x012239EC File Offset: 0x01221BEC
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

		// Token: 0x0603E62F RID: 255535 RVA: 0x01223A98 File Offset: 0x01221C98
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

		// Token: 0x0603E630 RID: 255536 RVA: 0x01223B0C File Offset: 0x01221D0C
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

		// Token: 0x0603E631 RID: 255537 RVA: 0x01223D20 File Offset: 0x01221F20
		protected void CorrectRotation(Rotator Rotation)
		{
			float max = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Yaw限制Max) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Yaw限制Max]) : 180f;
			float min = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Yaw限制Min) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Yaw限制Min]) : -180f;
			Rotation.Yaw = MathUtils.Instance.Clamp(Rotation.Yaw, min, max);
			float max2 = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Pitch限制Max) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Pitch限制Max]) : 90f;
			float min2 = this.LimitConfigs.ContainsKey(EFreeCameraLimit.Pitch限制Min) ? MathUtils.Instance.WrapAngle(this.LimitConfigs[EFreeCameraLimit.Pitch限制Min]) : -90f;
			Rotation.Pitch = MathUtils.Instance.Clamp(Rotation.Pitch, min2, max2);
		}

		// Token: 0x0603E632 RID: 255538 RVA: 0x01223E40 File Offset: 0x01222040
		protected float CorrectFOV(float FoV)
		{
			float min = this.LimitConfigs.ContainsKey(EFreeCameraLimit.最小FOV) ? this.LimitConfigs[EFreeCameraLimit.最小FOV] : 0f;
			float max = this.LimitConfigs.ContainsKey(EFreeCameraLimit.最大FOV) ? this.LimitConfigs[EFreeCameraLimit.最大FOV] : 170f;
			return MathUtils.Instance.Clamp(FoV, min, max);
		}

		// Token: 0x0603E633 RID: 255539 RVA: 0x01223EB4 File Offset: 0x012220B4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FreeCameraLogicComponent freeCameraLogicComponent = (FreeCameraLogicComponent)componentTemplate;
			if (freeCameraLogicComponent.DisplayComponent == null)
			{
				this.DisplayComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisplayComponent), "DisplayComponent"))
			{
				return false;
			}
			if (freeCameraLogicComponent.InitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InitLocation), "InitLocation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.InitRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InitRotation), "InitRotation"))
			{
				return false;
			}
			this.InitFov = freeCameraLogicComponent.InitFov;
			this.CameraState = freeCameraLogicComponent.CameraState;
			this.BlendTime = freeCameraLogicComponent.BlendTime;
			this.BlendElapsedTime = freeCameraLogicComponent.BlendElapsedTime;
			if (freeCameraLogicComponent.BlendCurve == null)
			{
				this.BlendCurve = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BlendCurve), "BlendCurve"))
			{
				return false;
			}
			if (freeCameraLogicComponent.BlendFinishCallback == null)
			{
				this.BlendFinishCallback = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BlendFinishCallback), "BlendFinishCallback"))
			{
				return false;
			}
			if (freeCameraLogicComponent.CameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraRotation), "CameraRotation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.StartCameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartCameraRotation), "StartCameraRotation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.DesiredCameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DesiredCameraRotation), "DesiredCameraRotation"))
			{
				return false;
			}
			this.IsBlendFov = freeCameraLogicComponent.IsBlendFov;
			this.StartFov = freeCameraLogicComponent.StartFov;
			this.DesiredFov = freeCameraLogicComponent.DesiredFov;
			this.CurrentFov = freeCameraLogicComponent.CurrentFov;
			if (freeCameraLogicComponent.StartCameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartCameraLocation), "StartCameraLocation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.DesiredCameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DesiredCameraLocation), "DesiredCameraLocation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.CameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraLocation), "CameraLocation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.CameraForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraForward), "CameraForward"))
			{
				return false;
			}
			if (freeCameraLogicComponent.CameraRight != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraRight), "CameraRight"))
			{
				return false;
			}
			if (freeCameraLogicComponent.CameraUp != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraUp), "CameraUp"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempForwardVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempForwardVector), "TempForwardVector"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempRightVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRightVector), "TempRightVector"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempUpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempUpVector), "TempUpVector"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempQuat), "TempQuat"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempCameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempCameraRotation), "TempCameraRotation"))
			{
				return false;
			}
			if (freeCameraLogicComponent.TempQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempQuat2), "TempQuat2"))
			{
				return false;
			}
			if (freeCameraLogicComponent.LimitConfigs == null)
			{
				this.LimitConfigs = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LimitConfigs), "LimitConfigs"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170076AC RID: 30380
		// (get) Token: 0x0603E634 RID: 255540 RVA: 0x01224244 File Offset: 0x01222444
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076AD RID: 30381
		// (get) Token: 0x0603E635 RID: 255541 RVA: 0x01224247 File Offset: 0x01222447
		public override bool NeedAfterTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040213C3 RID: 136131
		private const int YAW_MAX = 180;

		// Token: 0x040213C4 RID: 136132
		private const int PITCH_MAX = 90;

		// Token: 0x040213C5 RID: 136133
		private const int FOV_MIN = 0;

		// Token: 0x040213C6 RID: 136134
		private const int FOV_MAX = 170;

		// Token: 0x040213C7 RID: 136135
		[Nullable(2)]
		private FreeCameraDisplayComponent DisplayComponent;

		// Token: 0x040213C8 RID: 136136
		private readonly Vector InitLocation = Vector.Create();

		// Token: 0x040213C9 RID: 136137
		private readonly Rotator InitRotation = Rotator.Create();

		// Token: 0x040213CA RID: 136138
		private float InitFov;

		// Token: 0x040213CB RID: 136139
		private FreeCameraLogicComponent.ECameraState CameraState;

		// Token: 0x040213CC RID: 136140
		private float BlendTime;

		// Token: 0x040213CD RID: 136141
		private float BlendElapsedTime;

		// Token: 0x040213CE RID: 136142
		[Nullable(2)]
		private CurveBase BlendCurve;

		// Token: 0x040213CF RID: 136143
		[Nullable(2)]
		private Action BlendFinishCallback;

		// Token: 0x040213D0 RID: 136144
		private readonly Rotator CameraRotation = Rotator.Create();

		// Token: 0x040213D1 RID: 136145
		private readonly Rotator StartCameraRotation = Rotator.Create();

		// Token: 0x040213D2 RID: 136146
		private readonly Rotator DesiredCameraRotation = Rotator.Create();

		// Token: 0x040213D3 RID: 136147
		private bool IsBlendFov;

		// Token: 0x040213D4 RID: 136148
		private float StartFov;

		// Token: 0x040213D5 RID: 136149
		private float DesiredFov;

		// Token: 0x040213D6 RID: 136150
		private float CurrentFov;

		// Token: 0x040213D7 RID: 136151
		private readonly Vector StartCameraLocation = Vector.Create();

		// Token: 0x040213D8 RID: 136152
		private readonly Vector DesiredCameraLocation = Vector.Create();

		// Token: 0x040213D9 RID: 136153
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x040213DA RID: 136154
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x040213DB RID: 136155
		private readonly Vector CameraRight = Vector.Create();

		// Token: 0x040213DC RID: 136156
		private readonly Vector CameraUp = Vector.Create();

		// Token: 0x040213DD RID: 136157
		private readonly Vector TempForwardVector = Vector.Create();

		// Token: 0x040213DE RID: 136158
		private readonly Vector TempRightVector = Vector.Create();

		// Token: 0x040213DF RID: 136159
		private readonly Vector TempUpVector = Vector.Create();

		// Token: 0x040213E0 RID: 136160
		private readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x040213E1 RID: 136161
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040213E2 RID: 136162
		private readonly Rotator TempCameraRotation = Rotator.Create();

		// Token: 0x040213E3 RID: 136163
		private readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040213E4 RID: 136164
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public Dictionary<TEnumAsByte<EFreeCameraLimit>, float> LimitConfigs = new Dictionary<TEnumAsByte<EFreeCameraLimit>, float>();

		// Token: 0x0200BBA6 RID: 48038
		[NullableContext(0)]
		public enum ECameraState
		{
			// Token: 0x04039C00 RID: 236544
			None,
			// Token: 0x04039C01 RID: 236545
			Blending
		}

		// Token: 0x0200BBA7 RID: 48039
		public interface ICameraMoveData
		{
			// Token: 0x17007A84 RID: 31364
			// (get) Token: 0x06048B15 RID: 297749
			// (set) Token: 0x06048B16 RID: 297750
			float Distance { get; set; }

			// Token: 0x17007A85 RID: 31365
			// (get) Token: 0x06048B17 RID: 297751
			// (set) Token: 0x06048B18 RID: 297752
			bool IsMoveBySelf { get; set; }
		}

		// Token: 0x0200BBA8 RID: 48040
		[NullableContext(0)]
		public class CameraMoveDataImpl : FreeCameraLogicComponent.ICameraMoveData
		{
			// Token: 0x17007A86 RID: 31366
			// (get) Token: 0x06048B19 RID: 297753 RVA: 0x0162382B File Offset: 0x01621A2B
			// (set) Token: 0x06048B1A RID: 297754 RVA: 0x01623833 File Offset: 0x01621A33
			public float Distance { get; set; }

			// Token: 0x17007A87 RID: 31367
			// (get) Token: 0x06048B1B RID: 297755 RVA: 0x0162383C File Offset: 0x01621A3C
			// (set) Token: 0x06048B1C RID: 297756 RVA: 0x01623844 File Offset: 0x01621A44
			public bool IsMoveBySelf { get; set; }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C6 RID: 29382
	[NullableContext(2)]
	[Nullable(0)]
	public class CameraRotationZone
	{
		// Token: 0x06048141 RID: 295233 RVA: 0x0127B498 File Offset: 0x01279698
		[NullableContext(1)]
		public void Init(FightCameraLogicComponent camera)
		{
			this.Camera = camera;
			this.MotorStandByLargePitchAngle = ConfigCommonParamById.GetFloatConfig("MotorJumpPitchThreshold").GetValueOrDefault(100f);
			this.MotorStandByLargePitchTime = ConfigCommonParamById.GetFloatConfig("MotorJumpPitchTime").GetValueOrDefault(0.5f);
		}

		// Token: 0x06048142 RID: 295234 RVA: 0x0127B4E8 File Offset: 0x012796E8
		public void SetCharacter(EntityHandle characterEntityHandle)
		{
			this.CharacterEntityHandle = characterEntityHandle;
			EntityHandle characterEntityHandle2 = this.CharacterEntityHandle;
			if (characterEntityHandle2 == null || !characterEntityHandle2.Valid)
			{
				return;
			}
			this.CharacterInputComponent = this.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>();
			this.CharacterActorComponent = this.CharacterEntityHandle.Entity.GetComponent<CharacterActorComponent>();
			this.CharacterGlideComponent = this.CharacterEntityHandle.Entity.GetComponent<CharacterGlideComponent>();
			this.CharacterAnimationComponent = this.CharacterEntityHandle.Entity.GetComponent<CharacterAnimationComponent>();
		}

		// Token: 0x06048143 RID: 295235 RVA: 0x0127B56C File Offset: 0x0127976C
		public void SetVehicle(EntityHandle vehicleEntityHandle)
		{
			this.VehicleEntityHandle = vehicleEntityHandle;
			EntityHandle vehicleEntityHandle2 = this.VehicleEntityHandle;
			if (vehicleEntityHandle2 == null || !vehicleEntityHandle2.Valid)
			{
				this.VehicleActorComponent = null;
				this.VehicleTagComponent = null;
				return;
			}
			this.VehicleActorComponent = this.VehicleEntityHandle.Entity.GetComponent<VehicleActorComponent>();
			this.VehicleTagComponent = this.VehicleEntityHandle.Entity.GetComponent<VehicleTagComponent>();
		}

		// Token: 0x06048144 RID: 295236 RVA: 0x0127B5D4 File Offset: 0x012797D4
		public void UpdateInputState(float deltaTime)
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.None)
			{
				return;
			}
			if (this.BlockSet.Count > 0)
			{
				return;
			}
			this.Camera.GetCameraTargetInput(this.InputVector);
			if (this.IsHasPitchMovement())
			{
				this.PitchInputTime += deltaTime;
			}
			else
			{
				this.PitchInputTime = 0f;
			}
			ValueTuple<float, float> cameraInput = this.CharacterInputComponent.GetCameraInput();
			double num = (double)cameraInput.Item1;
			double num2 = (double)cameraInput.Item2;
			double value = num;
			double value2 = num2;
			if (!MathUtils.Instance.IsNearlyZero(value2, new double?(0.0001)))
			{
				this.PitchRollbackTime = 0f;
			}
			else
			{
				this.PitchRollbackTime += deltaTime;
			}
			if (!MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001)))
			{
				this.YawInputTime += deltaTime;
			}
			else
			{
				this.YawInputTime = 0f;
			}
			if (!MathUtils.Instance.IsNearlyZero(value, new double?(0.0001)))
			{
				this.YawRollbackTime = 0f;
			}
			else
			{
				this.YawRollbackTime += deltaTime;
			}
			if (this.Camera.PlayerRotatorInGravity.Pitch > this.GetLargePitchStandByAngle())
			{
				this.StandByLargePitchAngle = 0f;
				return;
			}
			this.StandByLargePitchAngle += deltaTime;
		}

		// Token: 0x06048145 RID: 295237 RVA: 0x0127B730 File Offset: 0x01279930
		public void UpdatePitchZone(float deltaTime)
		{
			if (!this.CheckValid())
			{
				return;
			}
			if (!this.IsPitchZoneEnable())
			{
				return;
			}
			this.UpdatePitchZoneLimit();
			float num = this.Camera.PlayerRotatorInGravity.Pitch;
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				global::Vector actorVelocityProxy = this.CharacterActorComponent.ActorVelocityProxy;
				if (this.Camera.IsInNormalGravityMode())
				{
					MathUtils.Instance.LookRotationForwardFirst(actorVelocityProxy, global::Vector.UpVectorProxy, this.TmpQuat);
					this.TmpQuat.Rotator(this.TmpRotator);
				}
				else
				{
					actorVelocityProxy.Rotation(this.TmpRotator);
					CameraUtility.GetRotatorInGravity(this.TmpRotator, this.TmpRotator);
				}
				num = this.TmpRotator.Pitch;
			}
			num += this.Camera.PitchBasis;
			float pitchInGravity = CameraUtility.GetPitchInGravity(this.Camera.DesiredCamera.ArmRotation);
			float deltaPitch = MathUtils.Instance.WrapAngle(num - pitchInGravity);
			this.UpdateZonePitchState(deltaPitch, pitchInGravity);
			float targetPitch = this.GetTargetPitch(num, pitchInGravity, deltaPitch, deltaTime);
			CameraUtility.SetPitchInGravity(this.Camera.DesiredCamera.ArmRotation, (double)targetPitch, this.Camera.DesiredCamera.ArmRotation);
		}

		// Token: 0x06048146 RID: 295238 RVA: 0x0127B854 File Offset: 0x01279A54
		private void UpdatePitchZoneLimit()
		{
			this.PitchSoftZoneMin = this.Camera.PitchSoftZoneMin;
			this.PitchSoftZoneMax = this.Camera.PitchSoftZoneMax;
			this.PitchDeadZoneMin = this.Camera.PitchDeadZoneMin;
			this.PitchDeadZoneMax = this.Camera.PitchDeadZoneMax;
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				this.PitchSoftZoneMin += Math.Max(0f, this.Camera.PlayerRotatorInGravity.Pitch);
			}
		}

		// Token: 0x06048147 RID: 295239 RVA: 0x0127B8DC File Offset: 0x01279ADC
		private void UpdateZonePitchState(float deltaPitch, float cameraPitch)
		{
			if (deltaPitch >= this.PitchSoftZoneMin && deltaPitch <= this.PitchSoftZoneMax)
			{
				this.CameraPitchZoneState = CameraRotationZone.ECameraZoneState.InSoftZone;
			}
			if (this.IsStandbyPitchEnable())
			{
				this.CameraPitchZoneState = CameraRotationZone.ECameraZoneState.Standby;
			}
			else if (this.CharacterInputComponent.HasCameraInput(0.0001f) || this.BlockSet.Count > 0)
			{
				this.CameraPitchZoneState = CameraRotationZone.ECameraZoneState.InDeadZone;
			}
			else if (this.IsSoftPitchEnable())
			{
				if (this.CameraPitchZoneState != CameraRotationZone.ECameraZoneState.InSoftZone && this.IsDeadZoneTransitionToSoftZoneEnable())
				{
					this.CameraPitchZoneState = CameraRotationZone.ECameraZoneState.DeadZoneTransitionToSoftZone;
				}
			}
			else if (this.IsPitchTransitionToForwardEnable())
			{
				this.CameraPitchZoneState = CameraRotationZone.ECameraZoneState.TransitionToForward;
			}
			bool enableDebug = this.EnableDebug;
		}

		// Token: 0x06048148 RID: 295240 RVA: 0x0127B974 File Offset: 0x01279B74
		private float GetTargetPitch(float actorPitch, float cameraPitch, float deltaPitch, float deltaTime)
		{
			if (this.CameraPitchZoneState == CameraRotationZone.ECameraZoneState.Standby && this.IsStandByPitchFreeLook())
			{
				return cameraPitch;
			}
			float num = MathUtils.Instance.Lerp(this.Camera.PitchZoneSpeedMin, this.Camera.PitchZoneSpeedMax, MathUtils.Instance.Clamp(Math.Abs(deltaPitch) / this.PitchSoftZoneMax, 0f, 1f));
			float targetDeltaPitch = deltaTime * num;
			float num2 = cameraPitch;
			if (this.CameraPitchZoneState != CameraRotationZone.ECameraZoneState.Standby && this.CameraPitchZoneState != CameraRotationZone.ECameraZoneState.InDeadZone)
			{
				num2 = this.GetTargetPitchTransitionToForward(cameraPitch, actorPitch, targetDeltaPitch, deltaPitch);
				float num3 = MathUtils.Instance.WrapAngle(actorPitch - num2);
				if (num3 >= this.PitchSoftZoneMin && num3 <= this.PitchSoftZoneMax)
				{
					this.CameraPitchZoneState = CameraRotationZone.ECameraZoneState.InSoftZone;
				}
			}
			bool enableDebug = this.EnableDebug;
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				num2 = this.ClampAxisAngle(this.CameraPitchZoneState == CameraRotationZone.ECameraZoneState.InSoftZone, actorPitch, num2, this.PitchSoftZoneMin, this.PitchSoftZoneMax, this.PitchDeadZoneMin, this.PitchDeadZoneMax);
			}
			else
			{
				num2 = this.ClampRelativePitchAngle(this.CameraPitchZoneState == CameraRotationZone.ECameraZoneState.InSoftZone, num2, this.PitchSoftZoneMin, this.PitchSoftZoneMax, this.PitchDeadZoneMin, this.PitchDeadZoneMax);
			}
			return num2;
		}

		// Token: 0x06048149 RID: 295241 RVA: 0x0127BA98 File Offset: 0x01279C98
		public void UpdateYawZone(float deltaTime)
		{
			if (!this.CheckValid())
			{
				return;
			}
			if (!this.IsYawZoneEnable())
			{
				return;
			}
			this.UpdateYawZoneLimit();
			this.UpdateZoneYawState();
			float targetYaw = this.GetTargetYaw(deltaTime);
			CameraUtility.SetYawInGravity(this.Camera.DesiredCamera.ArmRotation, (double)targetYaw, this.Camera.DesiredCamera.ArmRotation);
		}

		// Token: 0x0604814A RID: 295242 RVA: 0x0127BAF4 File Offset: 0x01279CF4
		private void UpdateYawZoneLimit()
		{
			this.YawSoftZoneMin = this.Camera.YawSoftZoneMin;
			this.YawSoftZoneMax = this.Camera.YawSoftZoneMax;
			this.YawDeadZoneMin = this.Camera.YawDeadZoneMin;
			this.YawDeadZoneMax = this.Camera.YawDeadZoneMax;
		}

		// Token: 0x0604814B RID: 295243 RVA: 0x0127BB48 File Offset: 0x01279D48
		private void UpdateZoneYawState()
		{
			float yaw = this.Camera.PlayerRotatorInGravity.Yaw;
			float yawInGravity = CameraUtility.GetYawInGravity(this.Camera.DesiredCamera.ArmRotation);
			float num = MathUtils.Instance.WrapAngle(yaw - yawInGravity);
			if (num >= this.YawSoftZoneMin && num <= this.YawSoftZoneMax)
			{
				this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.InSoftZone;
			}
			if (this.IsStandbyYawEnable())
			{
				this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.Standby;
			}
			else if ((this.IsDeadYawEnable() && this.CharacterInputComponent.HasCameraInput(0.0001f)) || this.BlockSet.Count > 0)
			{
				this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.InDeadZone;
			}
			else if (this.IsSoftYawEnable())
			{
				if (this.CameraYawZoneState != CameraRotationZone.ECameraZoneState.InSoftZone && this.IsDeadZoneTransitionToSoftZoneEnable())
				{
					this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.DeadZoneTransitionToSoftZone;
				}
			}
			else if (this.IsYawTransitionToForwardEnable())
			{
				if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone)
				{
					this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone;
				}
				else if (this.CameraYawZoneState != CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone)
				{
					this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.TransitionToForward;
				}
			}
			bool enableDebug = this.EnableDebug;
		}

		// Token: 0x0604814C RID: 295244 RVA: 0x0127BC38 File Offset: 0x01279E38
		private float GetTargetYaw(float deltaTime)
		{
			if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.Standby && this.IsStandByYawFreeLook())
			{
				return CameraUtility.GetYawInGravity(this.Camera.DesiredCamera.ArmRotation);
			}
			float yaw = this.Camera.PlayerRotatorInGravity.Yaw;
			float yawInGravity = CameraUtility.GetYawInGravity(this.Camera.DesiredCamera.ArmRotation);
			float num = MathUtils.Instance.WrapAngle(yaw - yawInGravity);
			float targetDeltaYaw = deltaTime * this.GetYawSpeed();
			float num2 = yawInGravity;
			if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone)
			{
				num2 = this.GetTargetYawInSoftZone(yawInGravity, targetDeltaYaw);
			}
			else if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.DeadZoneTransitionToSoftZone)
			{
				num2 = this.GetTargetYawDeadZoneTransitionToSoftZone(yawInGravity, targetDeltaYaw, num, num2);
				float num3 = this.IsSoftYawAddAngle() ? this.YawSoftZoneMin : this.YawSoftZoneMax;
				float num4 = MathUtils.Instance.WrapAngle(yaw - num2);
				if ((num < 0f && num4 > num3) || (num > 0f && num4 < num3))
				{
					this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.InSoftZone;
				}
			}
			else if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.TransitionToForward || this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone)
			{
				num2 = this.GetTargetYawTransitionToForward(yawInGravity, yaw, targetDeltaYaw, num);
				float num5 = MathUtils.Instance.WrapAngle(yaw - num2);
				if (num5 >= this.YawSoftZoneMin && num5 <= this.YawSoftZoneMax)
				{
					this.CameraYawZoneState = CameraRotationZone.ECameraZoneState.InSoftZone;
				}
			}
			bool enableDebug = this.EnableDebug;
			num2 = this.ClampAxisAngle(this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone || this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone, yaw, num2, this.YawSoftZoneMin, this.YawSoftZoneMax, this.YawDeadZoneMin, this.YawDeadZoneMax);
			bool enableDebug2 = this.EnableDebug;
			return num2;
		}

		// Token: 0x0604814D RID: 295245 RVA: 0x0127BDB8 File Offset: 0x01279FB8
		private float GetTargetYawInSoftZone(float cameraYaw, float targetDeltaYaw)
		{
			if (this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor || !this.IsEnableSoftYawAddAngle() || MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001)))
			{
				return MathUtils.Instance.WrapAngle(cameraYaw + (this.IsEnableSoftYawAddAngle() ? (this.IsSoftYawAddAngle() ? targetDeltaYaw : (-targetDeltaYaw)) : 0f));
			}
			if (this.IsSoftYawAddAngle())
			{
				return MathUtils.Instance.WrapAngle(cameraYaw + targetDeltaYaw * this.Camera.YawSoftZoneSpeedRatio);
			}
			return MathUtils.Instance.WrapAngle(cameraYaw - targetDeltaYaw * this.Camera.YawSoftZoneSpeedRatio);
		}

		// Token: 0x0604814E RID: 295246 RVA: 0x0127BE64 File Offset: 0x0127A064
		private float GetTargetYawDeadZoneTransitionToSoftZone(float cameraYaw, float targetDeltaYaw, float deltaYaw, float targetYaw)
		{
			if (this.IsDeadYawTransitionToSoftYawAddAngle(deltaYaw))
			{
				return MathUtils.Instance.WrapAngle(cameraYaw + targetDeltaYaw * this.Camera.YawDeadZoneTransToSoftZoneSpeedRatio);
			}
			if (this.IsDeadYawTransitionToSoftYawMinusAngle(deltaYaw))
			{
				return MathUtils.Instance.WrapAngle(cameraYaw - targetDeltaYaw * this.Camera.YawDeadZoneTransToSoftZoneSpeedRatio);
			}
			return targetYaw;
		}

		// Token: 0x0604814F RID: 295247 RVA: 0x0127BEBC File Offset: 0x0127A0BC
		private float GetTargetYawTransitionToForward(float cameraYaw, float actorYaw, float targetDeltaYaw, float deltaYaw)
		{
			if (deltaYaw < 0f)
			{
				float num = MathUtils.Instance.WrapAngle(cameraYaw - targetDeltaYaw * this.Camera.YawTransToForwardSpeedRatio);
				if (MathUtils.Instance.WrapAngle(actorYaw - num) <= 0f)
				{
					return num;
				}
				return actorYaw;
			}
			else
			{
				float num2 = MathUtils.Instance.WrapAngle(cameraYaw + targetDeltaYaw * this.Camera.YawTransToForwardSpeedRatio);
				if (MathUtils.Instance.WrapAngle(actorYaw - num2) >= 0f)
				{
					return num2;
				}
				return actorYaw;
			}
		}

		// Token: 0x06048150 RID: 295248 RVA: 0x0127BF38 File Offset: 0x0127A138
		private float GetTargetPitchTransitionToForward(float cameraPitch, float actorPitch, float targetDeltaPitch, float deltaPitch)
		{
			if (deltaPitch < 0f)
			{
				float num = MathUtils.Instance.WrapAngle(cameraPitch - targetDeltaPitch);
				if (MathUtils.Instance.WrapAngle(actorPitch - num) <= 0f)
				{
					return num;
				}
				return actorPitch;
			}
			else
			{
				float num2 = MathUtils.Instance.WrapAngle(cameraPitch + targetDeltaPitch);
				if (MathUtils.Instance.WrapAngle(actorPitch - num2) >= 0f)
				{
					return num2;
				}
				return actorPitch;
			}
		}

		// Token: 0x06048151 RID: 295249 RVA: 0x0127BF9C File Offset: 0x0127A19C
		private float ClampAxisAngle(bool isInSoftZone, float actorAngle, float targetAngle, float softZoneMinAngle, float softZoneMaxAngle, float deadZoneMinAngle, float deadZoneMaxAngle)
		{
			float num = MathUtils.Instance.WrapAngle(actorAngle - targetAngle);
			float num2 = isInSoftZone ? softZoneMinAngle : deadZoneMinAngle;
			float num3 = isInSoftZone ? softZoneMaxAngle : deadZoneMaxAngle;
			if (num < num2)
			{
				return MathUtils.Instance.WrapAngle(actorAngle - num2);
			}
			if (num > num3)
			{
				return MathUtils.Instance.WrapAngle(actorAngle - num3);
			}
			return targetAngle;
		}

		// Token: 0x06048152 RID: 295250 RVA: 0x0127BFF0 File Offset: 0x0127A1F0
		private float ClampRelativePitchAngle(bool isInSoftZone, float targetPitch, float softZoneMinAngle, float softZoneMaxAngle, float deadZoneMinAngle, float deadZoneMaxAngle)
		{
			Rotator tmpRotator = this.TmpRotator;
			global::Vector tmpVector = this.TmpVector;
			CameraUtility.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
			tmpRotator.Pitch = targetPitch;
			tmpRotator.Vector(tmpVector);
			Rotator tmpRotator2 = this.TmpRotator1;
			tmpRotator2.DeepCopy(this.Camera.PlayerRotatorInGravity);
			tmpRotator2.Roll = 0f;
			tmpRotator2.Quaternion(this.TmpQuat);
			this.TmpQuat.UnRotateVector(tmpVector, tmpVector);
			tmpVector.Rotation(tmpRotator);
			tmpRotator.Pitch = this.ClampRelativeAxisAngle(isInSoftZone, tmpRotator.Pitch, softZoneMinAngle, softZoneMaxAngle, deadZoneMinAngle, deadZoneMaxAngle);
			tmpRotator.Vector(tmpVector);
			this.TmpQuat.RotateVector(tmpVector, tmpVector);
			tmpVector.Rotation(tmpRotator);
			return tmpRotator.Pitch;
		}

		// Token: 0x06048153 RID: 295251 RVA: 0x0127C0B4 File Offset: 0x0127A2B4
		private float ClampRelativeAxisAngle(bool isInSoftZone, float targetAngle, float softZoneMinAngle, float softZoneMaxAngle, float deadZoneMinAngle, float deadZoneMaxAngle)
		{
			float num = isInSoftZone ? softZoneMinAngle : deadZoneMinAngle;
			float num2 = isInSoftZone ? softZoneMaxAngle : deadZoneMaxAngle;
			if (targetAngle < -num2)
			{
				return -num2;
			}
			if (targetAngle > -num)
			{
				return -num;
			}
			return targetAngle;
		}

		// Token: 0x06048154 RID: 295252 RVA: 0x0127C0E5 File Offset: 0x0127A2E5
		private bool IsPitchZoneEnable()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.None && this.Camera.CameraZoneMode != EFightCameraZoneMode.Horizontal;
		}

		// Token: 0x06048155 RID: 295253 RVA: 0x0127C107 File Offset: 0x0127A307
		private bool IsYawZoneEnable()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.None && this.Camera.CameraZoneMode != EFightCameraZoneMode.Horizontal;
		}

		// Token: 0x06048156 RID: 295254 RVA: 0x0127C12C File Offset: 0x0127A32C
		private bool IsStandbyYawEnable()
		{
			if (this.BlockSet.Count > 0)
			{
				return false;
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.Camera.CharacterMoveEnterState == ECharMoveState.Soar || this.CharacterAnimationComponent.HasKuroRootMotion || this.CharacterInputComponent.IsInCameraDrivenAutoFlightMode() || (this.YawInputTime > 0f && this.YawRollbackTime > 0f && !this.IsYawRollback());
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.YawInputTime > 0f && this.YawRollbackTime > 0f && !this.IsYawRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && (!this.IsStandByLargePitchAngle() || this.VehicleTagComponent.HasAnyTag(this.VehicleStandbyZone) || this.VehicleActorComponent.ActorVelocityProxy.Size() <= 5.0 || (this.YawInputTime > 0f && this.YawRollbackTime > 0f && !this.IsYawRollback()));
		}

		// Token: 0x06048157 RID: 295255 RVA: 0x0127C24C File Offset: 0x0127A44C
		private bool IsStandbyPitchEnable()
		{
			if (this.BlockSet.Count > 0)
			{
				return false;
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.Camera.CharacterMoveEnterState == ECharMoveState.Soar || this.CharacterAnimationComponent.HasKuroRootMotion || this.CharacterInputComponent.IsInCameraDrivenAutoFlightMode() || (this.PitchRollbackTime > 0f && !this.IsPitchRollback());
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.PitchRollbackTime > 0f && !this.IsPitchRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && (!this.IsStandByLargePitchAngle() || this.VehicleTagComponent.HasAnyTag(this.VehicleStandbyZone) || this.VehicleActorComponent.ActorVelocityProxy.Size() <= 5.0 || (this.PitchRollbackTime > 0f && !this.IsPitchRollback()));
		}

		// Token: 0x06048158 RID: 295256 RVA: 0x0127C342 File Offset: 0x0127A542
		private bool IsDeadYawEnable()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.Soar || !this.CharacterInputComponent.IsInCameraDrivenAutoFlightMode();
		}

		// Token: 0x06048159 RID: 295257 RVA: 0x0127C362 File Offset: 0x0127A562
		private bool IsSoftYawEnable()
		{
			return (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor) && this.IsYawInputEnable() && this.IsYawRollback();
		}

		// Token: 0x0604815A RID: 295258 RVA: 0x0127C394 File Offset: 0x0127A594
		private bool IsSoftPitchEnable()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return !this.CharacterAnimationComponent.HasKuroRootMotion && this.IsPitchInputEnable() && this.IsPitchRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && this.IsPitchInputEnable() && this.IsPitchRollback();
		}

		// Token: 0x0604815B RID: 295259 RVA: 0x0127C3ED File Offset: 0x0127A5ED
		private bool IsEnableSoftYawAddAngle()
		{
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor;
		}

		// Token: 0x0604815C RID: 295260 RVA: 0x0127C410 File Offset: 0x0127A610
		private bool IsSoftYawAddAngle()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.InputVector.Y < 0.0;
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && this.InputVector.Y > 0.0;
		}

		// Token: 0x0604815D RID: 295261 RVA: 0x0127C468 File Offset: 0x0127A668
		private bool IsDeadZoneTransitionToSoftZoneEnable()
		{
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor;
		}

		// Token: 0x0604815E RID: 295262 RVA: 0x0127C489 File Offset: 0x0127A689
		private bool IsDeadYawTransitionToSoftYawAddAngle(float deltaYaw)
		{
			return (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor) && this.InputVector.Y > 0.0 && deltaYaw > 0f;
		}

		// Token: 0x0604815F RID: 295263 RVA: 0x0127C4C9 File Offset: 0x0127A6C9
		private bool IsDeadYawTransitionToSoftYawMinusAngle(float deltaYaw)
		{
			return (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor) && this.InputVector.Y < 0.0 && deltaYaw < 0f;
		}

		// Token: 0x06048160 RID: 295264 RVA: 0x0127C50C File Offset: 0x0127A70C
		private bool IsYawTransitionToForwardEnable()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.IsYawRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && (this.IsYawRollback() || (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone && !MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001))));
		}

		// Token: 0x06048161 RID: 295265 RVA: 0x0127C588 File Offset: 0x0127A788
		private bool IsPitchTransitionToForwardEnable()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.CharacterAnimationComponent.HasKuroRootMotion || this.IsPitchRollback();
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.IsPitchRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && (this.IsPitchRollback() || (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone && !MathUtils.Instance.IsNearlyZero(this.InputVector.X, new double?(0.0001))));
		}

		// Token: 0x06048162 RID: 295266 RVA: 0x0127C61C File Offset: 0x0127A81C
		private float GetYawSpeed()
		{
			float yaw = this.Camera.PlayerRotatorInGravity.Yaw;
			float yawInGravity = CameraUtility.GetYawInGravity(this.Camera.DesiredCamera.ArmRotation);
			float value = MathUtils.Instance.WrapAngle(yaw - yawInGravity);
			return MathUtils.Instance.Lerp(this.Camera.YawZoneSpeedMin, this.Camera.YawZoneSpeedMax, MathUtils.Instance.Clamp(Math.Abs(value) / this.YawDeadZoneMax, 0f, 1f));
		}

		// Token: 0x06048163 RID: 295267 RVA: 0x0127C69F File Offset: 0x0127A89F
		private bool IsStandByPitchFreeLook()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor;
		}

		// Token: 0x06048164 RID: 295268 RVA: 0x0127C6B2 File Offset: 0x0127A8B2
		private bool IsStandByYawFreeLook()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor;
		}

		// Token: 0x06048165 RID: 295269 RVA: 0x0127C6C8 File Offset: 0x0127A8C8
		private bool CheckValid()
		{
			EntityHandle characterEntityHandle = this.CharacterEntityHandle;
			if (characterEntityHandle == null || !characterEntityHandle.Valid)
			{
				return false;
			}
			CharacterInputComponent characterInputComponent = this.CharacterInputComponent;
			if (characterInputComponent == null || !characterInputComponent.Valid)
			{
				return false;
			}
			CharacterActorComponent characterActorComponent = this.CharacterActorComponent;
			if (characterActorComponent == null || !characterActorComponent.Valid)
			{
				return false;
			}
			CharacterGlideComponent characterGlideComponent = this.CharacterGlideComponent;
			if (characterGlideComponent == null || !characterGlideComponent.Valid)
			{
				return false;
			}
			CharacterAnimationComponent characterAnimationComponent = this.CharacterAnimationComponent;
			return characterAnimationComponent != null && characterAnimationComponent.Valid && (this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor || this.IsVehicleValid());
		}

		// Token: 0x06048166 RID: 295270 RVA: 0x0127C76B File Offset: 0x0127A96B
		private float GetLargePitchStandByAngle()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				return this.MotorStandByLargePitchAngle;
			}
			return 100f;
		}

		// Token: 0x06048167 RID: 295271 RVA: 0x0127C787 File Offset: 0x0127A987
		public float GetLargePitchStandByTime()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				return this.MotorStandByLargePitchTime;
			}
			return 0.5f;
		}

		// Token: 0x06048168 RID: 295272 RVA: 0x0127C7A3 File Offset: 0x0127A9A3
		public bool IsPitchRollback()
		{
			return this.PitchRollbackTime >= this.Camera.PitchRollbackEnableTime;
		}

		// Token: 0x06048169 RID: 295273 RVA: 0x0127C7BB File Offset: 0x0127A9BB
		private bool IsPitchInputEnable()
		{
			return this.PitchInputTime >= this.Camera.PitchInputEnableTime;
		}

		// Token: 0x0604816A RID: 295274 RVA: 0x0127C7D3 File Offset: 0x0127A9D3
		private bool IsYawRollback()
		{
			return this.YawRollbackTime >= this.Camera.YawRollbackEnableTime;
		}

		// Token: 0x0604816B RID: 295275 RVA: 0x0127C7EB File Offset: 0x0127A9EB
		public bool IsYawInputEnable()
		{
			return this.YawInputTime >= this.Camera.YawInputEnableTime;
		}

		// Token: 0x0604816C RID: 295276 RVA: 0x0127C803 File Offset: 0x0127AA03
		private bool IsStandByLargePitchAngle()
		{
			return this.StandByLargePitchAngle >= this.GetLargePitchStandByTime();
		}

		// Token: 0x0604816D RID: 295277 RVA: 0x0127C818 File Offset: 0x0127AA18
		private bool IsHasPitchMovement()
		{
			CharacterGlideComponent characterGlideComponent = this.CharacterGlideComponent;
			if (characterGlideComponent != null && characterGlideComponent.Valid)
			{
				CharacterActorComponent characterActorComponent = this.CharacterActorComponent;
				if (characterActorComponent != null && characterActorComponent.Valid)
				{
					return this.CharacterGlideComponent.SoarBoostOn || !this.InputVector.IsNearlyZero(9.999999747378752E-05);
				}
			}
			return false;
		}

		// Token: 0x0604816E RID: 295278 RVA: 0x0127C87B File Offset: 0x0127AA7B
		public bool IsHasPitchUpMovement()
		{
			CharacterGlideComponent characterGlideComponent = this.CharacterGlideComponent;
			return characterGlideComponent != null && characterGlideComponent.Valid && this.InputVector.X < 0.0;
		}

		// Token: 0x0604816F RID: 295279 RVA: 0x0127C8AC File Offset: 0x0127AAAC
		public bool IsHasPitchHorizontalMovement()
		{
			CharacterGlideComponent characterGlideComponent = this.CharacterGlideComponent;
			if (characterGlideComponent != null && characterGlideComponent.Valid)
			{
				CharacterActorComponent characterActorComponent = this.CharacterActorComponent;
				if (characterActorComponent != null && characterActorComponent.Valid)
				{
					return this.CharacterGlideComponent.SoarBalanceOn;
				}
			}
			return false;
		}

		// Token: 0x06048170 RID: 295280 RVA: 0x0127C8EC File Offset: 0x0127AAEC
		public bool IsHasYawHorizontalMovement()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && this.IsVehicleValid())
			{
				return !MathUtils.Instance.IsNearlyZero(this.VehicleActorComponent.ActorVelocityProxy.Size(), new double?((double)5)) && !MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001));
			}
			return !MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001));
		}

		// Token: 0x06048171 RID: 295281 RVA: 0x0127C981 File Offset: 0x0127AB81
		[NullableContext(1)]
		public void Lock(object control)
		{
			this.BlockSet.Add(control);
		}

		// Token: 0x06048172 RID: 295282 RVA: 0x0127C990 File Offset: 0x0127AB90
		[NullableContext(1)]
		public void Unlock(object control)
		{
			this.BlockSet.Remove(control);
		}

		// Token: 0x06048173 RID: 295283 RVA: 0x0127C99F File Offset: 0x0127AB9F
		private bool IsVehicleValid()
		{
			EntityHandle vehicleEntityHandle = this.VehicleEntityHandle;
			return vehicleEntityHandle != null && vehicleEntityHandle.Valid;
		}

		// Token: 0x06048174 RID: 295284 RVA: 0x0127C9B2 File Offset: 0x0127ABB2
		[Conditional("DEBUG")]
		public void DebugDrawZone()
		{
		}

		// Token: 0x06048175 RID: 295285 RVA: 0x0127C9B4 File Offset: 0x0127ABB4
		[Conditional("DEBUG")]
		private void DebugDrawYawSoftZone(float leftAngle, float rightAngle, float playerPitch, float playerYaw, FLinearColor color)
		{
		}

		// Token: 0x06048176 RID: 295286 RVA: 0x0127C9B6 File Offset: 0x0127ABB6
		[Conditional("DEBUG")]
		private void DrawCamera()
		{
		}

		// Token: 0x06048177 RID: 295287 RVA: 0x0127C9B8 File Offset: 0x0127ABB8
		public void Clear()
		{
			this.Camera = null;
			this.CharacterEntityHandle = null;
			this.CharacterInputComponent = null;
			this.CharacterActorComponent = null;
			this.CharacterGlideComponent = null;
			this.CharacterAnimationComponent = null;
			this.VehicleEntityHandle = null;
			this.VehicleActorComponent = null;
			this.VehicleTagComponent = null;
		}

		// Token: 0x04026076 RID: 155766
		private const int CAMERA_DIRECTION_LENGTH = 500;

		// Token: 0x04026077 RID: 155767
		private const int CAMERA_DIRECTION_ARROW_SIZE = 2000;

		// Token: 0x04026078 RID: 155768
		private const int INVALID_PITCH_THRESHOLD = 100;

		// Token: 0x04026079 RID: 155769
		private const float INVALID_PITCH_TIME = 0.5f;

		// Token: 0x0402607A RID: 155770
		[Nullable(1)]
		private readonly int[] VehicleStandbyZone = new int[]
		{
			GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.镜头保持"]
		};

		// Token: 0x0402607B RID: 155771
		private float MotorStandByLargePitchAngle = 85f;

		// Token: 0x0402607C RID: 155772
		private float MotorStandByLargePitchTime = 2f;

		// Token: 0x0402607D RID: 155773
		private FightCameraLogicComponent Camera;

		// Token: 0x0402607E RID: 155774
		private EntityHandle CharacterEntityHandle;

		// Token: 0x0402607F RID: 155775
		private CharacterInputComponent CharacterInputComponent;

		// Token: 0x04026080 RID: 155776
		private CharacterActorComponent CharacterActorComponent;

		// Token: 0x04026081 RID: 155777
		private CharacterGlideComponent CharacterGlideComponent;

		// Token: 0x04026082 RID: 155778
		private CharacterAnimationComponent CharacterAnimationComponent;

		// Token: 0x04026083 RID: 155779
		private EntityHandle VehicleEntityHandle;

		// Token: 0x04026084 RID: 155780
		private VehicleActorComponent VehicleActorComponent;

		// Token: 0x04026085 RID: 155781
		private VehicleTagComponent VehicleTagComponent;

		// Token: 0x04026086 RID: 155782
		private CameraRotationZone.ECameraZoneState CameraPitchZoneState;

		// Token: 0x04026087 RID: 155783
		private CameraRotationZone.ECameraZoneState CameraYawZoneState;

		// Token: 0x04026088 RID: 155784
		private float StandByLargePitchAngle;

		// Token: 0x04026089 RID: 155785
		private float YawInputTime;

		// Token: 0x0402608A RID: 155786
		private float YawRollbackTime;

		// Token: 0x0402608B RID: 155787
		private float YawSoftZoneMin;

		// Token: 0x0402608C RID: 155788
		private float YawSoftZoneMax;

		// Token: 0x0402608D RID: 155789
		private float YawDeadZoneMin;

		// Token: 0x0402608E RID: 155790
		private float YawDeadZoneMax;

		// Token: 0x0402608F RID: 155791
		private float PitchInputTime;

		// Token: 0x04026090 RID: 155792
		private float PitchRollbackTime;

		// Token: 0x04026091 RID: 155793
		private float PitchSoftZoneMin;

		// Token: 0x04026092 RID: 155794
		private float PitchSoftZoneMax;

		// Token: 0x04026093 RID: 155795
		private float PitchDeadZoneMin;

		// Token: 0x04026094 RID: 155796
		private float PitchDeadZoneMax;

		// Token: 0x04026095 RID: 155797
		[Nullable(1)]
		private readonly global::Vector InputVector = global::Vector.Create();

		// Token: 0x04026096 RID: 155798
		[Nullable(1)]
		private readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x04026097 RID: 155799
		[Nullable(1)]
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026098 RID: 155800
		[Nullable(1)]
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x04026099 RID: 155801
		[Nullable(1)]
		private readonly Rotator TmpRotator1 = Rotator.Create();

		// Token: 0x0402609A RID: 155802
		[Nullable(1)]
		private readonly HashSet<object> BlockSet = new HashSet<object>();

		// Token: 0x0402609B RID: 155803
		private readonly bool EnableDebug;

		// Token: 0x0200CFCA RID: 53194
		[NullableContext(0)]
		private enum ECameraZoneState
		{
			// Token: 0x0403E7BC RID: 255932
			Standby,
			// Token: 0x0403E7BD RID: 255933
			InDeadZone,
			// Token: 0x0403E7BE RID: 255934
			InSoftZone,
			// Token: 0x0403E7BF RID: 255935
			DeadZoneTransitionToSoftZone,
			// Token: 0x0403E7C0 RID: 255936
			TransitionToForward,
			// Token: 0x0403E7C1 RID: 255937
			TransitionToForwardWithSoftZone
		}
	}
}

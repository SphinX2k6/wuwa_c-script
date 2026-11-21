using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006448 RID: 25672
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraRotationZone
	{
		// Token: 0x17007697 RID: 30359
		// (get) Token: 0x0603E535 RID: 255285 RVA: 0x0121D82E File Offset: 0x0121BA2E
		public string DebugPitchZoneState
		{
			get
			{
				return this.CameraPitchZoneState.ToString();
			}
		}

		// Token: 0x17007698 RID: 30360
		// (get) Token: 0x0603E536 RID: 255286 RVA: 0x0121D841 File Offset: 0x0121BA41
		public string DebugYawZoneState
		{
			get
			{
				return this.CameraYawZoneState.ToString();
			}
		}

		// Token: 0x0603E537 RID: 255287 RVA: 0x0121D854 File Offset: 0x0121BA54
		public void Init(FightCameraLogicComponent camera)
		{
			this.Camera = camera;
			this.MotorStandByLargePitchAngle = ConfigCommonParamById.GetFloatConfig("MotorJumpPitchThreshold").GetValueOrDefault(100f);
			this.MotorStandByLargePitchTime = ConfigCommonParamById.GetFloatConfig("MotorJumpPitchTime").GetValueOrDefault(0.5f);
		}

		// Token: 0x0603E538 RID: 255288 RVA: 0x0121D8A4 File Offset: 0x0121BAA4
		[NullableContext(2)]
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
			this.CharacterFlowerFlyingComponent = this.CharacterEntityHandle.Entity.GetComponent<CharacterFlowerFlyingComponent>();
		}

		// Token: 0x0603E539 RID: 255289 RVA: 0x0121D940 File Offset: 0x0121BB40
		[NullableContext(2)]
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

		// Token: 0x0603E53A RID: 255290 RVA: 0x0121D9A8 File Offset: 0x0121BBA8
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
			if (!MathUtils.Instance.IsNearlyZero(this.InputVector.X, new double?(0.0001)))
			{
				this.PitchMovementRollbackTime = 0f;
			}
			else
			{
				this.PitchMovementRollbackTime += deltaTime;
			}
			if (!MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001)))
			{
				this.YawMovementRollbackTime = 0f;
			}
			else
			{
				this.YawMovementRollbackTime += deltaTime;
			}
			if (this.Camera.PlayerRotatorInGravity.Pitch > this.GetLargePitchStandByAngle())
			{
				this.StandByLargePitchAngle = 0f;
				return;
			}
			this.StandByLargePitchAngle += deltaTime;
		}

		// Token: 0x0603E53B RID: 255291 RVA: 0x0121DB84 File Offset: 0x0121BD84
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
			if ((this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower) && !this.CharacterActorComponent.ActorVelocityProxy.IsNearlyZero(9.999999747378752E-05))
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
			float num2;
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower)
			{
				num2 = this.GetTargetFlowerPitch(num, pitchInGravity, deltaPitch, deltaTime);
			}
			else
			{
				this.UpdateZonePitchState(deltaPitch, pitchInGravity);
				num2 = this.GetTargetPitch(num, pitchInGravity, deltaPitch, deltaTime);
			}
			CameraUtility.SetPitchInGravity(this.Camera.DesiredCamera.ArmRotation, (double)num2, this.Camera.DesiredCamera.ArmRotation);
		}

		// Token: 0x0603E53C RID: 255292 RVA: 0x0121DCEC File Offset: 0x0121BEEC
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

		// Token: 0x0603E53D RID: 255293 RVA: 0x0121DD74 File Offset: 0x0121BF74
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

		// Token: 0x0603E53E RID: 255294 RVA: 0x0121DE0C File Offset: 0x0121C00C
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

		// Token: 0x0603E53F RID: 255295 RVA: 0x0121DF30 File Offset: 0x0121C130
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
			float num;
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower)
			{
				num = this.GetTargetFlowerYaw(deltaTime);
			}
			else
			{
				this.UpdateZoneYawState();
				num = this.GetTargetYaw(deltaTime);
			}
			CameraUtility.SetYawInGravity(this.Camera.DesiredCamera.ArmRotation, (double)num, this.Camera.DesiredCamera.ArmRotation);
		}

		// Token: 0x0603E540 RID: 255296 RVA: 0x0121DFA4 File Offset: 0x0121C1A4
		private void UpdateYawZoneLimit()
		{
			this.YawSoftZoneMin = this.Camera.YawSoftZoneMin;
			this.YawSoftZoneMax = this.Camera.YawSoftZoneMax;
			this.YawDeadZoneMin = this.Camera.YawDeadZoneMin;
			this.YawDeadZoneMax = this.Camera.YawDeadZoneMax;
		}

		// Token: 0x0603E541 RID: 255297 RVA: 0x0121DFF8 File Offset: 0x0121C1F8
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

		// Token: 0x0603E542 RID: 255298 RVA: 0x0121E0E8 File Offset: 0x0121C2E8
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

		// Token: 0x0603E543 RID: 255299 RVA: 0x0121E268 File Offset: 0x0121C468
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

		// Token: 0x0603E544 RID: 255300 RVA: 0x0121E314 File Offset: 0x0121C514
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

		// Token: 0x0603E545 RID: 255301 RVA: 0x0121E36C File Offset: 0x0121C56C
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

		// Token: 0x0603E546 RID: 255302 RVA: 0x0121E3E8 File Offset: 0x0121C5E8
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

		// Token: 0x0603E547 RID: 255303 RVA: 0x0121E44C File Offset: 0x0121C64C
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

		// Token: 0x0603E548 RID: 255304 RVA: 0x0121E4A0 File Offset: 0x0121C6A0
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

		// Token: 0x0603E549 RID: 255305 RVA: 0x0121E564 File Offset: 0x0121C764
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

		// Token: 0x0603E54A RID: 255306 RVA: 0x0121E595 File Offset: 0x0121C795
		private bool IsPitchZoneEnable()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.None && this.Camera.CameraZoneMode != EFightCameraZoneMode.Horizontal;
		}

		// Token: 0x0603E54B RID: 255307 RVA: 0x0121E5B7 File Offset: 0x0121C7B7
		private bool IsYawZoneEnable()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.None && this.Camera.CameraZoneMode != EFightCameraZoneMode.Horizontal;
		}

		// Token: 0x0603E54C RID: 255308 RVA: 0x0121E5DC File Offset: 0x0121C7DC
		private bool IsStandbyYawEnable()
		{
			if (this.BlockSet.Count > 0)
			{
				return false;
			}
			bool flag = this.IsInCameraDrivenMove();
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.Camera.CharacterMoveEnterState == ECharMoveState.Soar || this.CharacterAnimationComponent.HasKuroRootMotion || flag || (this.YawInputTime > 0f && this.YawRollbackTime > 0f && !this.IsYawRollback());
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.YawInputTime > 0f && this.YawRollbackTime > 0f && !this.IsYawRollback();
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				return !this.IsStandByLargePitchAngle() || this.VehicleTagComponent.HasAnyTag(this.VehicleStandbyZone) || this.VehicleActorComponent.ActorVelocityProxy.Size() <= 5.0 || (this.YawInputTime > 0f && this.YawRollbackTime > 0f && !this.IsYawRollback());
			}
			return flag;
		}

		// Token: 0x0603E54D RID: 255309 RVA: 0x0121E6F8 File Offset: 0x0121C8F8
		private bool IsInCameraDrivenMove()
		{
			bool flag = false;
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				flag |= this.CharacterInputComponent.IsInCameraDrivenAutoFlightMode();
			}
			return flag;
		}

		// Token: 0x0603E54E RID: 255310 RVA: 0x0121E724 File Offset: 0x0121C924
		private bool IsStandbyPitchEnable()
		{
			if (this.BlockSet.Count > 0)
			{
				return false;
			}
			bool flag = this.IsInCameraDrivenMove();
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.Camera.CharacterMoveEnterState == ECharMoveState.Soar || this.CharacterAnimationComponent.HasKuroRootMotion || flag || (this.PitchRollbackTime > 0f && !this.IsPitchRollback());
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.PitchRollbackTime > 0f && !this.IsPitchRollback();
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				return !this.IsStandByLargePitchAngle() || this.VehicleTagComponent.HasAnyTag(this.VehicleStandbyZone) || this.VehicleActorComponent.ActorVelocityProxy.Size() <= 5.0 || (this.PitchRollbackTime > 0f && !this.IsPitchRollback());
			}
			return flag;
		}

		// Token: 0x0603E54F RID: 255311 RVA: 0x0121E819 File Offset: 0x0121CA19
		private bool IsDeadYawEnable()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.Soar || !this.IsInCameraDrivenMove();
		}

		// Token: 0x0603E550 RID: 255312 RVA: 0x0121E834 File Offset: 0x0121CA34
		private bool IsSoftYawEnable()
		{
			return (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor) && this.IsYawInputEnable() && this.IsYawRollback();
		}

		// Token: 0x0603E551 RID: 255313 RVA: 0x0121E864 File Offset: 0x0121CA64
		private bool IsSoftPitchEnable()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return !this.CharacterAnimationComponent.HasKuroRootMotion && this.IsPitchInputEnable() && this.IsPitchRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && this.IsPitchInputEnable() && this.IsPitchRollback();
		}

		// Token: 0x0603E552 RID: 255314 RVA: 0x0121E8BD File Offset: 0x0121CABD
		private bool IsEnableSoftYawAddAngle()
		{
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor;
		}

		// Token: 0x0603E553 RID: 255315 RVA: 0x0121E8E0 File Offset: 0x0121CAE0
		private bool IsSoftYawAddAngle()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar)
			{
				return this.InputVector.Y < 0.0;
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && this.InputVector.Y > 0.0;
		}

		// Token: 0x0603E554 RID: 255316 RVA: 0x0121E938 File Offset: 0x0121CB38
		private bool IsDeadZoneTransitionToSoftZoneEnable()
		{
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor;
		}

		// Token: 0x0603E555 RID: 255317 RVA: 0x0121E959 File Offset: 0x0121CB59
		private bool IsDeadYawTransitionToSoftYawAddAngle(float deltaYaw)
		{
			return (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor) && this.InputVector.Y > 0.0 && deltaYaw > 0f;
		}

		// Token: 0x0603E556 RID: 255318 RVA: 0x0121E999 File Offset: 0x0121CB99
		private bool IsDeadYawTransitionToSoftYawMinusAngle(float deltaYaw)
		{
			return (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor) && this.InputVector.Y < 0.0 && deltaYaw < 0f;
		}

		// Token: 0x0603E557 RID: 255319 RVA: 0x0121E9DC File Offset: 0x0121CBDC
		private bool IsYawTransitionToForwardEnable()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Soar || this.Camera.CameraZoneMode == EFightCameraZoneMode.Vehicle)
			{
				return this.IsYawRollback();
			}
			return this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && (this.IsYawRollback() || (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone && !MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001))));
		}

		// Token: 0x0603E558 RID: 255320 RVA: 0x0121EA58 File Offset: 0x0121CC58
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

		// Token: 0x0603E559 RID: 255321 RVA: 0x0121EAEC File Offset: 0x0121CCEC
		private float GetYawSpeed()
		{
			float yaw = this.Camera.PlayerRotatorInGravity.Yaw;
			float yawInGravity = CameraUtility.GetYawInGravity(this.Camera.DesiredCamera.ArmRotation);
			float value = MathUtils.Instance.WrapAngle(yaw - yawInGravity);
			return MathUtils.Instance.Lerp(this.Camera.YawZoneSpeedMin, this.Camera.YawZoneSpeedMax, MathUtils.Instance.Clamp(Math.Abs(value) / this.YawDeadZoneMax, 0f, 1f));
		}

		// Token: 0x0603E55A RID: 255322 RVA: 0x0121EB6F File Offset: 0x0121CD6F
		private bool IsStandByPitchFreeLook()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor;
		}

		// Token: 0x0603E55B RID: 255323 RVA: 0x0121EB82 File Offset: 0x0121CD82
		private bool IsStandByYawFreeLook()
		{
			return this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor;
		}

		// Token: 0x0603E55C RID: 255324 RVA: 0x0121EB98 File Offset: 0x0121CD98
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
			CharacterAnimationComponent characterAnimationComponent = this.CharacterAnimationComponent;
			if (characterAnimationComponent == null || !characterAnimationComponent.Valid)
			{
				return false;
			}
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower)
			{
				return this.CheckFlowerValid();
			}
			CharacterGlideComponent characterGlideComponent = this.CharacterGlideComponent;
			return characterGlideComponent != null && characterGlideComponent.Valid && (this.Camera.CameraZoneMode != EFightCameraZoneMode.Motor || this.IsVehicleValid());
		}

		// Token: 0x0603E55D RID: 255325 RVA: 0x0121EC50 File Offset: 0x0121CE50
		private float GetLargePitchStandByAngle()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				return this.MotorStandByLargePitchAngle;
			}
			return 100f;
		}

		// Token: 0x0603E55E RID: 255326 RVA: 0x0121EC6C File Offset: 0x0121CE6C
		public float GetLargePitchStandByTime()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor)
			{
				return this.MotorStandByLargePitchTime;
			}
			return 0.5f;
		}

		// Token: 0x0603E55F RID: 255327 RVA: 0x0121EC88 File Offset: 0x0121CE88
		public bool IsPitchRollback()
		{
			return this.PitchRollbackTime >= this.Camera.PitchRollbackEnableTime;
		}

		// Token: 0x0603E560 RID: 255328 RVA: 0x0121ECA0 File Offset: 0x0121CEA0
		private bool IsPitchInputEnable()
		{
			return this.PitchInputTime >= this.Camera.PitchInputEnableTime;
		}

		// Token: 0x0603E561 RID: 255329 RVA: 0x0121ECB8 File Offset: 0x0121CEB8
		private bool IsYawRollback()
		{
			return this.YawRollbackTime >= this.Camera.YawRollbackEnableTime;
		}

		// Token: 0x0603E562 RID: 255330 RVA: 0x0121ECD0 File Offset: 0x0121CED0
		public bool IsYawInputEnable()
		{
			return this.YawInputTime >= this.Camera.YawInputEnableTime;
		}

		// Token: 0x0603E563 RID: 255331 RVA: 0x0121ECE8 File Offset: 0x0121CEE8
		private bool IsStandByLargePitchAngle()
		{
			return this.StandByLargePitchAngle >= this.GetLargePitchStandByTime();
		}

		// Token: 0x0603E564 RID: 255332 RVA: 0x0121ECFC File Offset: 0x0121CEFC
		private bool IsHasPitchMovement()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower)
			{
				return this.IsHasFlowerPitchMovement();
			}
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

		// Token: 0x0603E565 RID: 255333 RVA: 0x0121ED74 File Offset: 0x0121CF74
		public bool IsHasPitchUpMovement()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower)
			{
				return this.IsHasFlowerPitchUpMovement();
			}
			CharacterGlideComponent characterGlideComponent = this.CharacterGlideComponent;
			return characterGlideComponent != null && characterGlideComponent.Valid && this.InputVector.X < 0.0;
		}

		// Token: 0x0603E566 RID: 255334 RVA: 0x0121EDC8 File Offset: 0x0121CFC8
		public bool IsHasPitchHorizontalMovement()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Flower)
			{
				return this.IsHasFlowerPitchHorizontalMovement();
			}
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

		// Token: 0x0603E567 RID: 255335 RVA: 0x0121EE28 File Offset: 0x0121D028
		public bool IsHasYawHorizontalMovement()
		{
			if (this.Camera.CameraZoneMode == EFightCameraZoneMode.Motor && this.IsVehicleValid())
			{
				return !MathUtils.Instance.IsNearlyZero(this.VehicleActorComponent.ActorVelocityProxy.Size(), new double?((double)5)) && !MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001));
			}
			return !MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001));
		}

		// Token: 0x0603E568 RID: 255336 RVA: 0x0121EEBD File Offset: 0x0121D0BD
		public void Lock(object control)
		{
			this.BlockSet.Add(control);
		}

		// Token: 0x0603E569 RID: 255337 RVA: 0x0121EECC File Offset: 0x0121D0CC
		public void Unlock(object control)
		{
			this.BlockSet.Remove(control);
		}

		// Token: 0x0603E56A RID: 255338 RVA: 0x0121EEDB File Offset: 0x0121D0DB
		private bool IsVehicleValid()
		{
			EntityHandle vehicleEntityHandle = this.VehicleEntityHandle;
			return vehicleEntityHandle != null && vehicleEntityHandle.Valid;
		}

		// Token: 0x0603E56B RID: 255339 RVA: 0x0121EEEE File Offset: 0x0121D0EE
		[Conditional("DEBUG")]
		public void DebugDrawZone()
		{
		}

		// Token: 0x0603E56C RID: 255340 RVA: 0x0121EEF0 File Offset: 0x0121D0F0
		[Conditional("DEBUG")]
		private void DebugDrawYawSoftZone(float leftAngle, float rightAngle, float playerPitch, float playerYaw, FLinearColor color)
		{
		}

		// Token: 0x0603E56D RID: 255341 RVA: 0x0121EEF2 File Offset: 0x0121D0F2
		[Conditional("DEBUG")]
		private void DrawCamera()
		{
		}

		// Token: 0x0603E56E RID: 255342 RVA: 0x0121EEF4 File Offset: 0x0121D0F4
		public void Clear()
		{
			this.Camera = null;
			this.CharacterEntityHandle = null;
			this.CharacterInputComponent = null;
			this.CharacterActorComponent = null;
			this.CharacterGlideComponent = null;
			this.CharacterFlowerFlyingComponent = null;
			this.InputVector.Reset();
			this.YawInputTime = 0f;
			this.PitchInputTime = 0f;
			this.YawRollbackTime = 0f;
			this.PitchRollbackTime = 0f;
			this.YawMovementRollbackTime = 0f;
			this.PitchMovementRollbackTime = 0f;
			this.CharacterAnimationComponent = null;
			this.VehicleEntityHandle = null;
			this.VehicleActorComponent = null;
			this.VehicleTagComponent = null;
		}

		// Token: 0x0603E56F RID: 255343 RVA: 0x0121EF94 File Offset: 0x0121D194
		private bool CheckFlowerValid()
		{
			CharacterFlowerFlyingComponent characterFlowerFlyingComponent = this.CharacterFlowerFlyingComponent;
			return characterFlowerFlyingComponent != null && characterFlowerFlyingComponent.Valid && this.CharacterFlowerFlyingComponent.FlowerFlyingExtension != null;
		}

		// Token: 0x0603E570 RID: 255344 RVA: 0x0121EFBC File Offset: 0x0121D1BC
		private float GetTargetFlowerPitch(float actorPitch, float cameraPitch, float deltaPitch, float deltaTime)
		{
			this.CameraPitchZoneState = this.GetFlowerPitchZoneState(deltaPitch);
			float num = MathUtils.Instance.Lerp(this.Camera.PitchZoneSpeedMin, this.Camera.PitchZoneSpeedMax, MathUtils.Instance.Clamp(Math.Abs(deltaPitch) / this.PitchSoftZoneMax, 0f, 1f));
			float targetDeltaPitch = deltaTime * num;
			float num2 = cameraPitch;
			if (this.CameraPitchZoneState != CameraRotationZone.ECameraZoneState.Standby && this.CameraPitchZoneState != CameraRotationZone.ECameraZoneState.InDeadZone)
			{
				num2 = this.GetTargetPitchTransitionToForward(cameraPitch, actorPitch, targetDeltaPitch, deltaPitch);
				this.CameraPitchZoneState = this.GetFlowerPitchZoneState(MathUtils.Instance.WrapAngle(actorPitch - num2));
			}
			bool enableDebug = this.EnableDebug;
			return this.ClampAxisAngle(this.CameraPitchZoneState == CameraRotationZone.ECameraZoneState.InSoftZone || this.CameraPitchZoneState == CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone, actorPitch, num2, this.PitchSoftZoneMin, this.PitchSoftZoneMax, this.PitchDeadZoneMin, this.PitchDeadZoneMax);
		}

		// Token: 0x0603E571 RID: 255345 RVA: 0x0121F090 File Offset: 0x0121D290
		private float GetTargetFlowerYaw(float deltaTime)
		{
			float yaw = this.Camera.PlayerRotatorInGravity.Yaw;
			float yawInGravity = CameraUtility.GetYawInGravity(this.Camera.DesiredCamera.ArmRotation);
			float deltaYaw = MathUtils.Instance.WrapAngle(yaw - yawInGravity);
			this.CameraYawZoneState = this.GetFlowerYawZoneState(deltaYaw);
			float targetDeltaYaw = deltaTime * this.GetFlowerYawSpeed(deltaYaw);
			float num = yawInGravity;
			if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone)
			{
				num = this.GetTargetFlowerYawInSoftZone(yawInGravity, targetDeltaYaw);
			}
			else if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.DeadZoneTransitionToSoftZone)
			{
				num = this.GetTargetFlowerYawDeadZoneTransitionToSoftZone(yawInGravity, targetDeltaYaw, deltaYaw);
				this.CameraYawZoneState = this.GetFlowerYawZoneState(MathUtils.Instance.WrapAngle(yaw - num));
			}
			else if (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone)
			{
				num = this.GetTargetYawTransitionToForward(yawInGravity, yaw, targetDeltaYaw, deltaYaw);
			}
			bool enableDebug = this.EnableDebug;
			num = this.ClampAxisAngle(this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone || this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone, yaw, num, this.YawSoftZoneMin, this.YawSoftZoneMax, this.YawDeadZoneMin, this.YawDeadZoneMax);
			bool enableDebug2 = this.EnableDebug;
			return num;
		}

		// Token: 0x0603E572 RID: 255346 RVA: 0x0121F190 File Offset: 0x0121D390
		private float GetTargetFlowerYawInSoftZone(float cameraYaw, float targetDeltaYaw)
		{
			if (MathUtils.Instance.IsNearlyZero(this.InputVector.Y, new double?(0.0001)))
			{
				return cameraYaw;
			}
			float num = targetDeltaYaw * this.Camera.YawSoftZoneSpeedRatio;
			return MathUtils.Instance.WrapAngle(cameraYaw + ((this.InputVector.Y > 0.0) ? num : (-num)));
		}

		// Token: 0x0603E573 RID: 255347 RVA: 0x0121F1FC File Offset: 0x0121D3FC
		private float GetTargetFlowerYawDeadZoneTransitionToSoftZone(float cameraYaw, float targetDeltaYaw, float deltaYaw)
		{
			float num = MathUtils.Instance.WrapAngle(deltaYaw - this.YawSoftZoneMin);
			float num2 = MathUtils.Instance.WrapAngle(deltaYaw - this.YawSoftZoneMax);
			float currentValue = (Math.Abs(num) < Math.Abs(num2)) ? num : num2;
			float num3 = Math.Max(0f, targetDeltaYaw * this.Camera.YawDeadZoneTransToSoftZoneSpeedRatio);
			return MathUtils.Instance.WrapAngle(cameraYaw + MathUtils.Instance.Clamp(currentValue, -num3, num3));
		}

		// Token: 0x0603E574 RID: 255348 RVA: 0x0121F274 File Offset: 0x0121D474
		private float GetFlowerYawSpeed(float deltaYaw)
		{
			float num = (this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.InSoftZone || this.CameraYawZoneState == CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone) ? this.YawSoftZoneMax : this.YawDeadZoneMax;
			num = Math.Max(0.0001f, num);
			return MathUtils.Instance.Lerp(this.Camera.YawZoneSpeedMin, this.Camera.YawZoneSpeedMax, MathUtils.Instance.Clamp(Math.Abs(deltaYaw) / num, 0f, 1f));
		}

		// Token: 0x0603E575 RID: 255349 RVA: 0x0121F2EC File Offset: 0x0121D4EC
		private CameraRotationZone.ECameraZoneState GetFlowerPitchZoneState(float deltaPitch)
		{
			float item = this.CharacterInputComponent.GetCameraInput().Item2;
			return this.GetFlowerZoneState(this.CameraPitchZoneState, deltaPitch, this.PitchSoftZoneMin, this.PitchSoftZoneMax, this.PitchRollbackTime, this.PitchMovementRollbackTime, this.Camera.PitchRollbackEnableTime, this.Camera.PitchRollbackEnableTime, !MathUtils.Instance.IsNearlyZero((double)item, new double?(0.0001)));
		}

		// Token: 0x0603E576 RID: 255350 RVA: 0x0121F364 File Offset: 0x0121D564
		private CameraRotationZone.ECameraZoneState GetFlowerYawZoneState(float deltaYaw)
		{
			float item = this.CharacterInputComponent.GetCameraInput().Item1;
			return this.GetFlowerZoneState(this.CameraYawZoneState, deltaYaw, this.YawSoftZoneMin, this.YawSoftZoneMax, this.YawRollbackTime, this.YawMovementRollbackTime, this.Camera.YawRollbackEnableTime, this.Camera.YawSoftZoneRollbackEnableTime, !MathUtils.Instance.IsNearlyZero((double)item, new double?(0.0001)));
		}

		// Token: 0x0603E577 RID: 255351 RVA: 0x0121F3DC File Offset: 0x0121D5DC
		private CameraRotationZone.ECameraZoneState GetFlowerZoneState(CameraRotationZone.ECameraZoneState currentState, float deltaAngle, float softZoneMin, float softZoneMax, float rollbackTime, float movementRollbackTime, float rollbackEnableTime, float movementRollbackEnableTime, bool hasCameraInput)
		{
			if (hasCameraInput || this.BlockSet.Count > 0)
			{
				return CameraRotationZone.ECameraZoneState.InDeadZone;
			}
			if (rollbackTime < rollbackEnableTime)
			{
				return CameraRotationZone.ECameraZoneState.Standby;
			}
			if (currentState != CameraRotationZone.ECameraZoneState.InSoftZone && currentState != CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone && ((double)deltaAngle < (double)softZoneMin - 0.0001 || (double)deltaAngle > (double)softZoneMax + 0.0001))
			{
				return CameraRotationZone.ECameraZoneState.DeadZoneTransitionToSoftZone;
			}
			if (movementRollbackTime < movementRollbackEnableTime)
			{
				return CameraRotationZone.ECameraZoneState.InSoftZone;
			}
			return CameraRotationZone.ECameraZoneState.TransitionToForwardWithSoftZone;
		}

		// Token: 0x0603E578 RID: 255352 RVA: 0x0121F439 File Offset: 0x0121D639
		private bool IsHasFlowerPitchMovement()
		{
			return !MathUtils.Instance.IsNearlyZero(this.InputVector.X, new double?(0.0001));
		}

		// Token: 0x0603E579 RID: 255353 RVA: 0x0121F461 File Offset: 0x0121D661
		private bool IsHasFlowerPitchUpMovement()
		{
			return this.InputVector.X > 0.0;
		}

		// Token: 0x0603E57A RID: 255354 RVA: 0x0121F47C File Offset: 0x0121D67C
		private bool IsHasFlowerPitchHorizontalMovement()
		{
			CharacterFlowerFlyingComponent characterFlowerFlyingComponent = this.CharacterFlowerFlyingComponent;
			UKuroCustomMovementFlowerFlying ukuroCustomMovementFlowerFlying = (characterFlowerFlyingComponent != null) ? characterFlowerFlyingComponent.FlowerFlyingExtension : null;
			float value = (ukuroCustomMovementFlowerFlying != null) ? ukuroCustomMovementFlowerFlying.GetDirectionInput().X : 0f;
			float value2 = (ukuroCustomMovementFlowerFlying != null) ? ukuroCustomMovementFlowerFlying.GetCurrentPitch() : 0f;
			return MathUtils.Instance.IsNearlyZero((double)Math.Abs(value), new double?((double)0.001f)) && MathUtils.Instance.IsNearlyZero((double)Math.Abs(value2), new double?((double)0.001f));
		}

		// Token: 0x04021356 RID: 136022
		private const int CAMERA_DIRECTION_LENGTH = 500;

		// Token: 0x04021357 RID: 136023
		private const int CAMERA_DIRECTION_ARROW_SIZE = 2000;

		// Token: 0x04021358 RID: 136024
		private const int INVALID_PITCH_THRESHOLD = 100;

		// Token: 0x04021359 RID: 136025
		private const float INVALID_PITCH_TIME = 0.5f;

		// Token: 0x0402135A RID: 136026
		private readonly int[] VehicleStandbyZone = new int[]
		{
			GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.镜头保持"]
		};

		// Token: 0x0402135B RID: 136027
		private float MotorStandByLargePitchAngle = 85f;

		// Token: 0x0402135C RID: 136028
		private float MotorStandByLargePitchTime = 2f;

		// Token: 0x0402135D RID: 136029
		[Nullable(2)]
		private FightCameraLogicComponent Camera;

		// Token: 0x0402135E RID: 136030
		[Nullable(2)]
		private EntityHandle CharacterEntityHandle;

		// Token: 0x0402135F RID: 136031
		[Nullable(2)]
		private CharacterInputComponent CharacterInputComponent;

		// Token: 0x04021360 RID: 136032
		[Nullable(2)]
		private CharacterActorComponent CharacterActorComponent;

		// Token: 0x04021361 RID: 136033
		[Nullable(2)]
		private CharacterGlideComponent CharacterGlideComponent;

		// Token: 0x04021362 RID: 136034
		[Nullable(2)]
		private CharacterAnimationComponent CharacterAnimationComponent;

		// Token: 0x04021363 RID: 136035
		[Nullable(2)]
		private CharacterFlowerFlyingComponent CharacterFlowerFlyingComponent;

		// Token: 0x04021364 RID: 136036
		[Nullable(2)]
		private EntityHandle VehicleEntityHandle;

		// Token: 0x04021365 RID: 136037
		[Nullable(2)]
		private VehicleActorComponent VehicleActorComponent;

		// Token: 0x04021366 RID: 136038
		[Nullable(2)]
		private VehicleTagComponent VehicleTagComponent;

		// Token: 0x04021367 RID: 136039
		private CameraRotationZone.ECameraZoneState CameraPitchZoneState;

		// Token: 0x04021368 RID: 136040
		private CameraRotationZone.ECameraZoneState CameraYawZoneState;

		// Token: 0x04021369 RID: 136041
		private float StandByLargePitchAngle;

		// Token: 0x0402136A RID: 136042
		private float YawInputTime;

		// Token: 0x0402136B RID: 136043
		private float YawRollbackTime;

		// Token: 0x0402136C RID: 136044
		private float YawMovementRollbackTime;

		// Token: 0x0402136D RID: 136045
		private float YawSoftZoneMin;

		// Token: 0x0402136E RID: 136046
		private float YawSoftZoneMax;

		// Token: 0x0402136F RID: 136047
		private float YawDeadZoneMin;

		// Token: 0x04021370 RID: 136048
		private float YawDeadZoneMax;

		// Token: 0x04021371 RID: 136049
		private float PitchInputTime;

		// Token: 0x04021372 RID: 136050
		private float PitchRollbackTime;

		// Token: 0x04021373 RID: 136051
		private float PitchMovementRollbackTime;

		// Token: 0x04021374 RID: 136052
		private float PitchSoftZoneMin;

		// Token: 0x04021375 RID: 136053
		private float PitchSoftZoneMax;

		// Token: 0x04021376 RID: 136054
		private float PitchDeadZoneMin;

		// Token: 0x04021377 RID: 136055
		private float PitchDeadZoneMax;

		// Token: 0x04021378 RID: 136056
		private readonly global::Vector InputVector = global::Vector.Create();

		// Token: 0x04021379 RID: 136057
		private readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x0402137A RID: 136058
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402137B RID: 136059
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x0402137C RID: 136060
		private readonly Rotator TmpRotator1 = Rotator.Create();

		// Token: 0x0402137D RID: 136061
		private readonly HashSet<object> BlockSet = new HashSet<object>();

		// Token: 0x0402137E RID: 136062
		private readonly bool EnableDebug;

		// Token: 0x0200BBA5 RID: 48037
		[NullableContext(0)]
		private enum ECameraZoneState
		{
			// Token: 0x04039BF9 RID: 236537
			Standby,
			// Token: 0x04039BFA RID: 236538
			InDeadZone,
			// Token: 0x04039BFB RID: 236539
			InSoftZone,
			// Token: 0x04039BFC RID: 236540
			DeadZoneTransitionToSoftZone,
			// Token: 0x04039BFD RID: 236541
			TransitionToForward,
			// Token: 0x04039BFE RID: 236542
			TransitionToForwardWithSoftZone
		}
	}
}

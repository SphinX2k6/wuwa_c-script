using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061A4 RID: 24996
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleAudioComponent : VehicleAudioComponent, IStaticVariableResetter
	{
		// Token: 0x0603BF9B RID: 245659 RVA: 0x01109833 File Offset: 0x01107A33
		static MotorcycleAudioComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleAudioComponent.CreateStaticDefaultValue), new Action(MotorcycleAudioComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0603BF9C RID: 245660 RVA: 0x01109852 File Offset: 0x01107A52
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BF9D RID: 245661 RVA: 0x01109854 File Offset: 0x01107A54
		public static void ResetStaticDefaultValue()
		{
			MotorcycleAudioComponent.StackStatInternal = null;
		}

		// Token: 0x17007109 RID: 28937
		// (get) Token: 0x0603BF9E RID: 245662 RVA: 0x0110985C File Offset: 0x01107A5C
		// (set) Token: 0x0603BF9F RID: 245663 RVA: 0x0110987D File Offset: 0x01107A7D
		private FHitResult CacheHitResult
		{
			get
			{
				if (this.CacheHitResultInternal == null)
				{
					this.CacheHitResultInternal = new FHitResult();
				}
				return this.CacheHitResultInternal;
			}
			set
			{
				this.CacheHitResultInternal = value;
			}
		}

		// Token: 0x1700710A RID: 28938
		// (get) Token: 0x0603BFA0 RID: 245664 RVA: 0x01109886 File Offset: 0x01107A86
		private static Stat StackStat
		{
			get
			{
				if (MotorcycleAudioComponent.StackStatInternal == null)
				{
					MotorcycleAudioComponent.StackStatInternal = Stat.Create("MotorcycleAudioComponent.DetectFloorHandle", "", "");
				}
				return MotorcycleAudioComponent.StackStatInternal;
			}
		}

		// Token: 0x0603BFA1 RID: 245665 RVA: 0x011098B0 File Offset: 0x01107AB0
		protected override bool OnStart()
		{
			this.MoveComp = base.Entity.GetComponent<MotorcycleMoveComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.WaterComp = base.Entity.GetComponent<MotorcycleWaterComponent>();
			MotorcycleMoveComponent moveComp = this.MoveComp;
			float? num;
			if (moveComp == null)
			{
				num = null;
			}
			else
			{
				UKuroVehicleMovementComponent vehicleMovement = moveComp.VehicleMovement;
				num = ((vehicleMovement != null) ? new float?(vehicleMovement.MotorFrontWheelHang.GPerCm) : null);
			}
			float? num2 = num;
			this.FrontWheelHangG = num2.GetValueOrDefault(0.07f);
			MotorcycleMoveComponent moveComp2 = this.MoveComp;
			float? num3;
			if (moveComp2 == null)
			{
				num3 = null;
			}
			else
			{
				UKuroVehicleMovementComponent vehicleMovement2 = moveComp2.VehicleMovement;
				num3 = ((vehicleMovement2 != null) ? new float?(vehicleMovement2.MotorBackWheelHang.GPerCm) : null);
			}
			num2 = num3;
			this.RearWheelHangG = num2.GetValueOrDefault(0.07f);
			return true;
		}

		// Token: 0x0603BFA2 RID: 245666 RVA: 0x01109988 File Offset: 0x01107B88
		protected override void OnTick(float delta)
		{
			if (this.MoveComp == null || !this.IsPlayerDriving)
			{
				return;
			}
			int num = (base.ActorComp.ActorVelocityProxy.DotProduct(base.ActorComp.ActorForwardProxy) < 0.0) ? -1 : 1;
			float speed = this.MoveComp.Speed * (float)num;
			this.UpdateMotorHangsAudio((double)delta);
			this.UpdateMotorWheelTexture();
			this.SetMotorAcceleration(delta, speed);
			this.SetMotorSpeed(delta, speed);
			this.SetMotorInAirDurationRtpc(delta);
		}

		// Token: 0x0603BFA3 RID: 245667 RVA: 0x01109A05 File Offset: 0x01107C05
		protected override bool OnEnd()
		{
			this.ChangeEventListener(true);
			this.LeaveMotorClearAudio();
			this.IsPlayerDriving = false;
			return base.OnEnd();
		}

		// Token: 0x0603BFA4 RID: 245668 RVA: 0x01109A24 File Offset: 0x01107C24
		protected override void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (info.IsNpcPassenger())
			{
				GameAudioModel instance = GameAudioModel.Instance;
				if (instance != null && instance.CheckMotorState())
				{
					GameAudioModel instance2 = GameAudioModel.Instance;
					if (instance2 != null)
					{
						instance2.PlayMotorPlotAudio(EGondolaVoiceTriggeredType.InviteRole);
					}
				}
			}
			if (!info.IsRolePassenger(true))
			{
				return;
			}
			this.IsPlayerDriving = true;
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.MotorEngine, false);
			this.ChangeEventListener(false);
			this.MotorStrength = FormationAttributeController.Instance.GetValue(EFormationAttributeId.MotorcycleStrength);
			this.MaxMotorStrength = FormationAttributeController.Instance.GetMax(EFormationAttributeId.MotorcycleStrength);
			this.SetMotorStrengthRtpc(this.MotorStrength, this.MaxMotorStrength);
		}

		// Token: 0x0603BFA5 RID: 245669 RVA: 0x01109AB8 File Offset: 0x01107CB8
		protected override void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsRolePassenger(true))
			{
				return;
			}
			this.IsPlayerDriving = false;
			this.ChangeEventListener(true);
			this.LeaveMotorClearAudio();
		}

		// Token: 0x0603BFA6 RID: 245670 RVA: 0x01109AD8 File Offset: 0x01107CD8
		private void ChangeEventListener(bool remove = false)
		{
			if (!remove && !this.HasEventListener)
			{
				this.HasEventListener = true;
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.漂移"], new BaseTagComponent.TTagSwitchedCallback(this.MotorDriftingStateChange), null);
				}
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.MotorNitroStateChange), null);
				}
				BaseTagComponent tagComp3 = this.TagComp;
				if (tagComp3 != null)
				{
					tagComp3.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"], new BaseTagComponent.TTagSwitchedCallback(this.MotorGlideStateChange), null);
				}
				BaseTagComponent tagComp4 = this.TagComp;
				if (tagComp4 != null)
				{
					tagComp4.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.MotorGlideStateChange), null);
				}
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.MotorOnHit, new Action<EMotorPart, FHitResult>(this.MotorOnHit));
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateModeChange));
				FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged), null);
				FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthMaxChanged), null);
				return;
			}
			if (remove && this.HasEventListener)
			{
				this.HasEventListener = false;
				BaseTagComponent tagComp5 = this.TagComp;
				if (tagComp5 != null)
				{
					tagComp5.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.漂移"], new BaseTagComponent.TTagSwitchedCallback(this.MotorDriftingStateChange));
				}
				BaseTagComponent tagComp6 = this.TagComp;
				if (tagComp6 != null)
				{
					tagComp6.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.MotorNitroStateChange));
				}
				BaseTagComponent tagComp7 = this.TagComp;
				if (tagComp7 != null)
				{
					tagComp7.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"], new BaseTagComponent.TTagSwitchedCallback(this.MotorGlideStateChange));
				}
				BaseTagComponent tagComp8 = this.TagComp;
				if (tagComp8 != null)
				{
					tagComp8.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.MotorGlideStateChange));
				}
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.MotorOnHit, new Action<EMotorPart, FHitResult>(this.MotorOnHit));
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateModeChange));
				FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged));
				FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthMaxChanged));
			}
		}

		// Token: 0x0603BFA7 RID: 245671 RVA: 0x01109D64 File Offset: 0x01107F64
		private void LeaveMotorClearAudio()
		{
			if (base.ActorComp == null)
			{
				return;
			}
			AudioSystem.Instance.SetRtpcValue("motor_speed", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?(200)
			}));
			AudioSystem.Instance.SetRtpcValue("motor_nos_energe", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?(200)
			}));
			AudioSystem.Instance.SetRtpcValue("motor_nos_energe_percent", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?(200)
			}));
			AudioSystem.Instance.SetRtpcValue("motor_engine_speed", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?(200)
			}));
			AudioSystem.Instance.SetRtpcValue("motor_crash_strength", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?(200)
			}));
			AudioSystem.Instance.SetRtpcValue("motor_air_land_time_seconds", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?(200)
			}));
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.NitroAcceleration, true);
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.MotorEngine, true);
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.WheelRoll, true);
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.BrakingTurn, true);
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.DriftingState, true);
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.Glide, true);
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.GlideSprint, true);
		}

		// Token: 0x0603BFA8 RID: 245672 RVA: 0x01109F6C File Offset: 0x0110816C
		private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			if ((double)Math.Abs(newValue - this.MotorStrength) < 5.0 && newValue != 0f)
			{
				return;
			}
			if ((double)newValue < 5.0)
			{
				this.MotorStrength = 0f;
			}
			else
			{
				this.MotorStrength = newValue;
			}
			this.SetMotorStrengthRtpc(this.MotorStrength, this.MaxMotorStrength);
		}

		// Token: 0x0603BFA9 RID: 245673 RVA: 0x01109FCE File Offset: 0x011081CE
		private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			this.MaxMotorStrength = newValue;
		}

		// Token: 0x0603BFAA RID: 245674 RVA: 0x01109FD8 File Offset: 0x011081D8
		private void SetMotorStrengthRtpc(float value, float maxValue)
		{
			if (base.ActorComp == null || value > maxValue)
			{
				return;
			}
			AudioSystem.Instance.SetRtpcValue("motor_nos_energe", value, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner
			}));
			float value2 = value / maxValue;
			AudioSystem.Instance.SetRtpcValue("motor_nos_energe_percent", value2, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner
			}));
		}

		// Token: 0x0603BFAB RID: 245675 RVA: 0x0110A058 File Offset: 0x01108258
		private void MotorOnHit(EMotorPart part, FHitResult hitResult)
		{
			if (base.ActorComp == null || (double)Math.Abs(this.LastMotorOnHitSpeed - this.LastMotorSpeed) < 20.0)
			{
				return;
			}
			this.LastMotorOnHitSpeed = this.LastMotorSpeed;
			this.TempVector.DeepCopy(hitResult.Normal);
			this.LastMotorOnHitStrength = (float)Math.Abs(this.MotorSpeedDirection.DotProduct(this.TempVector));
			AudioSystem.Instance.SetRtpcValue("motor_crash_strength", this.LastMotorOnHitStrength, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner
			}));
			AudioSystem.Instance.PostEvent("play_sfx_motor_crash", base.ActorComp.Owner, null);
		}

		// Token: 0x0603BFAC RID: 245676 RVA: 0x0110A124 File Offset: 0x01108324
		private void MotorDriftingStateChange(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.DriftingState, false);
				return;
			}
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.DriftingState, true);
		}

		// Token: 0x0603BFAD RID: 245677 RVA: 0x0110A144 File Offset: 0x01108344
		private void MotorGlideStateChange(int tagId, bool tagExist)
		{
			if (base.ActorComp == null)
			{
				return;
			}
			if (tagId == GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"])
			{
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.Glide, !tagExist);
				return;
			}
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.GlideSprint, !tagExist);
			if (tagExist)
			{
				AudioSystem.Instance.PostEvent("play_sfx_motor_gliding_nos_start", base.ActorComp.Owner, null);
				return;
			}
			AudioSystem.Instance.PostEvent("play_sfx_motor_gliding_nos_end", base.ActorComp.Owner, null);
		}

		// Token: 0x0603BFAE RID: 245678 RVA: 0x0110A1D7 File Offset: 0x011083D7
		private void MotorNitroStateChange(int tagId, bool tagExist)
		{
			this.MotorNitroAcceleration(tagExist);
		}

		// Token: 0x0603BFAF RID: 245679 RVA: 0x0110A1E0 File Offset: 0x011083E0
		private void MotorSubStateModeChange(EMotorSubState newValue, EMotorSubState oldValue)
		{
			if (base.ActorComp == null)
			{
				return;
			}
			bool flag = this.CheckMotorAirState(oldValue);
			bool flag2 = this.CheckMotorAirState(newValue);
			if (!flag && flag2)
			{
				this.InAirDuration = 0f;
				AudioSystem.Instance.PostEvent("play_sfx_motor_takeoff", base.ActorComp.Owner, null);
			}
			if (flag && !flag2)
			{
				this.InAirDuration = 0f;
				AudioSystem.Instance.PostEvent("play_sfx_motor_touchdown", base.ActorComp.Owner, null);
			}
			if (newValue == EMotorSubState.BrakingTurn)
			{
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.BrakingTurn, false);
			}
			if (oldValue == EMotorSubState.BrakingTurn)
			{
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.BrakingTurn, true);
			}
			this.LastMotorSubState = newValue;
		}

		// Token: 0x0603BFB0 RID: 245680 RVA: 0x0110A298 File Offset: 0x01108498
		private void SetMotorInAirDurationRtpc(float delta)
		{
			if (base.ActorComp == null)
			{
				return;
			}
			float num = MathUtils.Instance.Clamp(this.InAirDuration + delta * (float)(this.CheckMotorAirState(this.LastMotorSubState) ? 1 : -1) * 0.001f, -10f, 10f);
			if (this.InAirDuration == num)
			{
				return;
			}
			this.InAirDuration = num;
			AudioSystem.Instance.SetRtpcValue("motor_air_land_time_seconds", this.InAirDuration, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?((int)delta)
			}));
		}

		// Token: 0x0603BFB1 RID: 245681 RVA: 0x0110A33C File Offset: 0x0110853C
		private void SetMotorSpeed(float delta, float speed)
		{
			VehicleActorComponent actorComp = base.ActorComp;
			if (((actorComp != null) ? actorComp.Owner : null) == null || (speed == 0f && this.LastMotorSpeed == 0f) || ((double)Math.Abs(this.LastMotorSpeed - speed) < 20.0 && this.LastMotorSpeed != 0f))
			{
				return;
			}
			this.LastMotorSpeed = speed;
			this.MotorSpeedDirection.DeepCopy(base.ActorComp.ActorVelocityProxy);
			AudioSystem.Instance.SetRtpcValue("motor_speed", speed, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?((int)delta)
			}));
			if ((double)Math.Abs(speed) < 20.0 || this.CheckMotorAirState(this.LastMotorSubState))
			{
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.WheelRoll, true);
				return;
			}
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.WheelRoll, false);
		}

		// Token: 0x0603BFB2 RID: 245682 RVA: 0x0110A430 File Offset: 0x01108630
		private void SetMotorAcceleration(float delta, float speed)
		{
			MotorcycleMoveComponent moveComp = this.MoveComp;
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (moveComp != null) ? moveComp.VehicleMovement : null;
			VehicleActorComponent actorComp = base.ActorComp;
			if (((actorComp != null) ? actorComp.Owner : null) == null || ukuroVehicleMovementComponent == null)
			{
				return;
			}
			float currentMotorPower = ukuroVehicleMovementComponent.GetCurrentMotorPower();
			float toMax = ukuroVehicleMovementComponent.MotorAccelConfig.PowerAccel.ToMax;
			float toMax2 = ukuroVehicleMovementComponent.MotorAccelConfig.PowerAccel.ToMax;
			float num = this.CheckMotorAirState(this.LastMotorSubState) ? 1.6f : 1f;
			float num2 = MathUtils.Instance.Clamp(Math.Abs(speed) / toMax2, 0f, 1f);
			float num3 = MathUtils.Instance.Clamp(-2500f * num2 * (num2 - 2f) + 3000f * (currentMotorPower / toMax) * num, 0f, 6000f);
			if ((num3 == 0f && this.LastEngineSpeed == 0f) || ((double)Math.Abs(this.LastEngineSpeed - num3) < 10.0 && this.LastEngineSpeed != 0f))
			{
				return;
			}
			this.LastEngineSpeed = num3;
			AudioSystem.Instance.SetRtpcValue("motor_engine_speed", num3, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = base.ActorComp.Owner,
				TransitionDuration = new int?((int)delta)
			}));
		}

		// Token: 0x0603BFB3 RID: 245683 RVA: 0x0110A588 File Offset: 0x01108788
		private void MotorNitroAcceleration(bool change)
		{
			VehicleActorComponent actorComp = base.ActorComp;
			if (((actorComp != null) ? actorComp.Owner : null) == null)
			{
				return;
			}
			if (change)
			{
				AudioSystem.Instance.PostEvent("play_sfx_motor_nos_start", base.ActorComp.Owner, null);
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.NitroAcceleration, false);
				return;
			}
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.NitroAcceleration, true);
			if (!this.MoveComp.BackBraking)
			{
				AudioSystem.Instance.PostEvent("play_sfx_motor_nos_end", base.ActorComp.Owner, null);
			}
		}

		// Token: 0x0603BFB4 RID: 245684 RVA: 0x0110A61C File Offset: 0x0110881C
		public void MotorNitroAccelerationFailure(bool banned, bool sprint, bool input)
		{
			VehicleActorComponent actorComp = base.ActorComp;
			if (((actorComp != null) ? actorComp.Owner : null) == null)
			{
				return;
			}
			if (banned && (this.LastNitroSprint != sprint || (!this.LastNitroInput && input)))
			{
				AudioSystem.Instance.PostEvent("play_sfx_motor_nos_failed", base.ActorComp.Owner, null);
			}
			this.LastNitroInput = input;
			this.LastNitroSprint = sprint;
		}

		// Token: 0x0603BFB5 RID: 245685 RVA: 0x0110A68C File Offset: 0x0110888C
		private void UpdateMotorHangsAudio(double delta)
		{
			if (base.ActorComp != null)
			{
				MotorcycleMoveComponent moveComp = this.MoveComp;
				if (((moveComp != null) ? moveComp.VehicleMovement : null) != null)
				{
					Vector tempVector = this.TempVector;
					FVector fvector = this.MoveComp.VehicleMovement.GetCurrentMotorFrontPulling();
					tempVector.FromUeVector(fvector);
					double num = this.FrontWheelPulling.SubtractionEqual(this.TempVector).Size() * (double)this.FrontWheelHangG / (delta * 0.0010000000474974513);
					this.FrontWheelPulling.DeepCopy(this.TempVector);
					Vector tempVector2 = this.TempVector;
					fvector = this.MoveComp.VehicleMovement.GetCurrentMotorRearPulling();
					tempVector2.FromUeVector(fvector);
					double num2 = this.RearWheelPulling.SubtractionEqual(this.TempVector).Size() * (double)this.RearWheelHangG / (delta * 0.0010000000474974513);
					this.RearWheelPulling.DeepCopy(this.TempVector);
					if ((num > 25.0 || num2 > 25.0) && Time.Instance.Now - this.HangsAudioLastTime > 100.0)
					{
						this.HangsAudioLastTime = Time.Instance.Now;
						AudioSystem.Instance.PostEvent("play_sfx_motor_suspension", base.ActorComp.Owner, null);
					}
					return;
				}
			}
		}

		// Token: 0x0603BFB6 RID: 245686 RVA: 0x0110A7D0 File Offset: 0x011089D0
		private void ChangeMoveAudioEvent(EMotorMoveAudioEvent eventType, bool stop = false)
		{
			if (base.ActorComp == null)
			{
				return;
			}
			bool flag = this.AudioEventHandleMap.ContainsKey(eventType);
			if (!stop && !flag)
			{
				string text;
				string @event = this.AudioEventOverrideMap.TryGetValue(eventType, out text) ? text : eventType.Value;
				int value = AudioSystem.Instance.PostEvent(@event, base.ActorComp.Owner, null);
				this.AudioEventHandleMap[eventType] = value;
				return;
			}
			if (stop && flag)
			{
				int handle = this.AudioEventHandleMap[eventType];
				AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, null);
				this.AudioEventHandleMap.Remove(eventType);
			}
		}

		// Token: 0x0603BFB7 RID: 245687 RVA: 0x0110A87C File Offset: 0x01108A7C
		private string GetMoveAudioEventName(EMotorMoveAudioEvent eventType)
		{
			if (eventType == EMotorMoveAudioEvent.WheelRoll)
			{
				return "轮胎音效";
			}
			if (eventType == EMotorMoveAudioEvent.BrakingTurn)
			{
				return "烧胎音效";
			}
			if (eventType == EMotorMoveAudioEvent.DriftingState)
			{
				return "漂移音效";
			}
			if (eventType == EMotorMoveAudioEvent.MotorEngine)
			{
				return "引擎音效";
			}
			if (eventType == EMotorMoveAudioEvent.NitroAcceleration)
			{
				return "氮气音效";
			}
			if (eventType == EMotorMoveAudioEvent.Glide)
			{
				return "翱翔音效";
			}
			if (eventType == EMotorMoveAudioEvent.GlideSprint)
			{
				return "翱翔冲刺音效";
			}
			return "未知音效";
		}

		// Token: 0x0603BFB8 RID: 245688 RVA: 0x0110A914 File Offset: 0x01108B14
		private void UpdateMotorWheelTexture()
		{
			VehicleActorComponent actorComp = base.ActorComp;
			if (((actorComp != null) ? actorComp.Owner : null) == null)
			{
				return;
			}
			CharacterFootEffectComponent.EFootstepTexture motorWheelTexture = this.GetMotorWheelTexture();
			if (this.LastTexture != motorWheelTexture)
			{
				this.LastTexture = motorWheelTexture;
				AudioSystem.Instance.SetSwitch("motor_wheel_texture", motorWheelTexture.ToEnumString(), base.ActorComp.Owner);
			}
		}

		// Token: 0x0603BFB9 RID: 245689 RVA: 0x0110A970 File Offset: 0x01108B70
		private CharacterFootEffectComponent.EFootstepTexture GetMotorWheelTexture()
		{
			VehicleActorComponent actorComp = base.ActorComp;
			TsBaseVehicle tsBaseVehicle = (actorComp != null) ? actorComp.Actor : null;
			MotorcycleMoveComponent moveComp = this.MoveComp;
			if (((moveComp != null) ? moveComp.VehicleMovement : null) == null || tsBaseVehicle == null)
			{
				return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
			}
			if (this.CheckMotorAirState(this.LastMotorSubState))
			{
				return this.LastTexture;
			}
			MotorcycleWaterComponent waterComp = this.WaterComp;
			if (waterComp != null && waterComp.InSwimArea)
			{
				return this.CheckWaterSurfaceType();
			}
			if (!this.GetHitResult())
			{
				return this.LastTexture;
			}
			this.TempVector.DeepCopy(this.CacheHitResult.Location);
			FoliageAudioInfo foliageAudioInfo = AudioUtils.Instance.QueryFoliageAudioPhysicalMaterial(this.TempVector.ToUeVector(false), base.Entity);
			if (foliageAudioInfo.IsHitFoliage && foliageAudioInfo.PhysicalMaterial != null)
			{
				return this.GetMaterialTexture(foliageAudioInfo.PhysicalMaterial);
			}
			TWeakObjectPtr<UPhysicalMaterial> physMaterial = this.CacheHitResult.PhysMaterial;
			return this.GetMaterialTexture(physMaterial);
		}

		// Token: 0x0603BFBA RID: 245690 RVA: 0x0110AA58 File Offset: 0x01108C58
		private void CacheMotorHitResult(bool forward)
		{
			FHitResult cacheHitResult = this.CacheHitResult;
			if (forward)
			{
				MotorcycleMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					UKuroVehicleMovementComponent vehicleMovement = moveComp.VehicleMovement;
					if (vehicleMovement != null)
					{
						vehicleMovement.GetFrontMotorHitResult(ref cacheHitResult);
					}
				}
			}
			else
			{
				MotorcycleMoveComponent moveComp2 = this.MoveComp;
				if (moveComp2 != null)
				{
					UKuroVehicleMovementComponent vehicleMovement2 = moveComp2.VehicleMovement;
					if (vehicleMovement2 != null)
					{
						vehicleMovement2.GetBackMotorHitResult(ref cacheHitResult);
					}
				}
			}
			this.CacheHitResult = cacheHitResult;
		}

		// Token: 0x0603BFBB RID: 245691 RVA: 0x0110AAB8 File Offset: 0x01108CB8
		private bool GetHitResult()
		{
			bool flag = base.ActorComp.ActorVelocityProxy.DotProduct(base.ActorComp.ActorForwardProxy) > 0.0;
			this.CacheMotorHitResult(flag);
			if (!this.CacheHitResult.bBlockingHit)
			{
				this.CacheMotorHitResult(!flag);
			}
			return this.CacheHitResult.bBlockingHit;
		}

		// Token: 0x0603BFBC RID: 245692 RVA: 0x0110AB18 File Offset: 0x01108D18
		[NullableContext(2)]
		private CharacterFootEffectComponent.EFootstepTexture GetMaterialTexture(UPhysicalMaterial material)
		{
			if (material != null && material.IsValid())
			{
				if (material.SurfaceType == EPhysicalSurface.SurfaceType6 || material.SurfaceType == EPhysicalSurface.SurfaceType14)
				{
					return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
				}
				string text = UKuroAudioMaterialSettings.GetFootstepTextureName(material.SurfaceType).ToString();
				CharacterFootEffectComponent.EFootstepTexture result;
				if (text.Length > 0 && Enum.TryParse<CharacterFootEffectComponent.EFootstepTexture>(text, out result))
				{
					return result;
				}
			}
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}

		// Token: 0x0603BFBD RID: 245693 RVA: 0x0110AB90 File Offset: 0x01108D90
		private CharacterFootEffectComponent.EFootstepTexture CheckWaterSurfaceType()
		{
			if (base.ActorComp == null)
			{
				return CharacterFootEffectComponent.EFootstepTexture.WaterSurface;
			}
			AActor owner = base.ActorComp.Owner;
			TWeakObjectPtr<UKuroEnviInteractionComponent> key = new TWeakObjectPtr<UKuroEnviInteractionComponent>(((owner != null) ? owner.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) : null) as UKuroEnviInteractionComponent);
			if (base.ActorComp.Owner != null)
			{
				UKuroInteractionEffectSystem kuroInteractionEffectSystem = UKuroInteractionEffectSystem.GetKuroInteractionEffectSystem(base.ActorComp.Owner.GetWorld());
				if (kuroInteractionEffectSystem != null)
				{
					FKuroEnviInteractionData fkuroEnviInteractionData = kuroInteractionEffectSystem.EnviInteractionCollections.Get(key);
					if (fkuroEnviInteractionData != null && fkuroEnviInteractionData.WaterType == 1)
					{
						return CharacterFootEffectComponent.EFootstepTexture.VoicelessSurface;
					}
				}
			}
			return CharacterFootEffectComponent.EFootstepTexture.WaterSurface;
		}

		// Token: 0x0603BFBE RID: 245694 RVA: 0x0110AC1C File Offset: 0x01108E1C
		private bool CheckMotorAirState(EMotorSubState state)
		{
			return state == EMotorSubState.AirMoving || state == EMotorSubState.Soaring;
		}

		// Token: 0x0603BFBF RID: 245695 RVA: 0x0110AC28 File Offset: 0x01108E28
		[NullableContext(2)]
		public void SetAudioEventOverride(EMotorMoveAudioEvent eventType, string eventName = null)
		{
			if (!string.IsNullOrEmpty(eventName))
			{
				this.AudioEventOverrideMap[eventType] = eventName;
			}
			else
			{
				this.AudioEventOverrideMap.Remove(eventType);
			}
			int handle;
			if (!this.AudioEventHandleMap.TryGetValue(eventType, out handle) || base.ActorComp == null)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, null);
			this.AudioEventHandleMap.Remove(eventType);
			string text;
			string @event = this.AudioEventOverrideMap.TryGetValue(eventType, out text) ? text : eventType.Value;
			int value = AudioSystem.Instance.PostEvent(@event, base.ActorComp.Owner, null);
			this.AudioEventHandleMap[eventType] = value;
		}

		// Token: 0x0603BFC0 RID: 245696 RVA: 0x0110ACDD File Offset: 0x01108EDD
		public void ClearAudioEventOverrides()
		{
			this.AudioEventOverrideMap.Clear();
		}

		// Token: 0x0603BFC1 RID: 245697 RVA: 0x0110ACEC File Offset: 0x01108EEC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleAudioComponent motorcycleAudioComponent = (MotorcycleAudioComponent)componentTemplate;
			if (motorcycleAudioComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
			{
				return false;
			}
			if (motorcycleAudioComponent.MotorSpeedDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MotorSpeedDirection), "MotorSpeedDirection"))
			{
				return false;
			}
			this.FrontWheelHangG = motorcycleAudioComponent.FrontWheelHangG;
			if (motorcycleAudioComponent.FrontWheelPulling != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FrontWheelPulling), "FrontWheelPulling"))
			{
				return false;
			}
			this.RearWheelHangG = motorcycleAudioComponent.RearWheelHangG;
			if (motorcycleAudioComponent.RearWheelPulling != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.RearWheelPulling), "RearWheelPulling"))
			{
				return false;
			}
			if (motorcycleAudioComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (motorcycleAudioComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (motorcycleAudioComponent.WaterComp == null)
			{
				this.WaterComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterComp), "WaterComp"))
			{
				return false;
			}
			if (motorcycleAudioComponent.AudioEventHandleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AudioEventHandleMap), "AudioEventHandleMap"))
			{
				return false;
			}
			if (motorcycleAudioComponent.CacheHitResultInternal == null)
			{
				this.CacheHitResultInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheHitResultInternal), "CacheHitResultInternal"))
			{
				return false;
			}
			this.LastTexture = motorcycleAudioComponent.LastTexture;
			if (motorcycleAudioComponent.AudioEventOverrideMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AudioEventOverrideMap), "AudioEventOverrideMap"))
			{
				return false;
			}
			this.IsPlayerDriving = motorcycleAudioComponent.IsPlayerDriving;
			this.HasEventListener = motorcycleAudioComponent.HasEventListener;
			this.MotorStrength = motorcycleAudioComponent.MotorStrength;
			this.MaxMotorStrength = motorcycleAudioComponent.MaxMotorStrength;
			this.LastMotorOnHitSpeed = motorcycleAudioComponent.LastMotorOnHitSpeed;
			this.LastMotorOnHitStrength = motorcycleAudioComponent.LastMotorOnHitStrength;
			this.InAirDuration = motorcycleAudioComponent.InAirDuration;
			this.LastMotorSubState = motorcycleAudioComponent.LastMotorSubState;
			this.LastMotorSpeed = motorcycleAudioComponent.LastMotorSpeed;
			this.LastEngineSpeed = motorcycleAudioComponent.LastEngineSpeed;
			this.LastNitroInput = motorcycleAudioComponent.LastNitroInput;
			this.LastNitroSprint = motorcycleAudioComponent.LastNitroSprint;
			this.HangsAudioLastTime = motorcycleAudioComponent.HangsAudioLastTime;
			return true;
		}

		// Token: 0x1700710B RID: 28939
		// (get) Token: 0x0603BFC2 RID: 245698 RVA: 0x0110AF4A File Offset: 0x0110914A
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700710C RID: 28940
		// (get) Token: 0x0603BFC3 RID: 245699 RVA: 0x0110AF4D File Offset: 0x0110914D
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700710D RID: 28941
		// (get) Token: 0x0603BFC4 RID: 245700 RVA: 0x0110AF50 File Offset: 0x01109150
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700710E RID: 28942
		// (get) Token: 0x0603BFC5 RID: 245701 RVA: 0x0110AF53 File Offset: 0x01109153
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700710F RID: 28943
		// (get) Token: 0x0603BFC6 RID: 245702 RVA: 0x0110AF56 File Offset: 0x01109156
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FB0C RID: 129804
		private const int MATERIAL_ID_WAT = 6;

		// Token: 0x0401FB0D RID: 129805
		private const int MATERIAL_ID_SHR = 14;

		// Token: 0x0401FB0E RID: 129806
		private const double SPEED_TOLERANCE = 20.0;

		// Token: 0x0401FB0F RID: 129807
		private const double ACC_CHANGE_TOLERANCE = 10.0;

		// Token: 0x0401FB10 RID: 129808
		private const double STRENGTH_TOLERANCE = 5.0;

		// Token: 0x0401FB11 RID: 129809
		private const float MS_TO_SECOND = 0.001f;

		// Token: 0x0401FB12 RID: 129810
		private const float IN_AIR_MAX_DURATION = 10f;

		// Token: 0x0401FB13 RID: 129811
		private const int LEAVE_MOTOR_TIME = 200;

		// Token: 0x0401FB14 RID: 129812
		private const double HANG_CHANGE_SPEED_TOLERANCE = 25.0;

		// Token: 0x0401FB15 RID: 129813
		private const int HANG_AUDIO_INTERVAL_TIME = 100;

		// Token: 0x0401FB16 RID: 129814
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401FB17 RID: 129815
		private readonly Vector MotorSpeedDirection = Vector.Create();

		// Token: 0x0401FB18 RID: 129816
		private float FrontWheelHangG;

		// Token: 0x0401FB19 RID: 129817
		private readonly Vector FrontWheelPulling = Vector.Create();

		// Token: 0x0401FB1A RID: 129818
		private float RearWheelHangG;

		// Token: 0x0401FB1B RID: 129819
		private readonly Vector RearWheelPulling = Vector.Create();

		// Token: 0x0401FB1C RID: 129820
		[Nullable(2)]
		private MotorcycleMoveComponent MoveComp;

		// Token: 0x0401FB1D RID: 129821
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x0401FB1E RID: 129822
		[Nullable(2)]
		private MotorcycleWaterComponent WaterComp;

		// Token: 0x0401FB1F RID: 129823
		private readonly Dictionary<EMotorMoveAudioEvent, int> AudioEventHandleMap = new Dictionary<EMotorMoveAudioEvent, int>();

		// Token: 0x0401FB20 RID: 129824
		[Nullable(2)]
		private FHitResult CacheHitResultInternal;

		// Token: 0x0401FB21 RID: 129825
		private CharacterFootEffectComponent.EFootstepTexture LastTexture;

		// Token: 0x0401FB22 RID: 129826
		private readonly Dictionary<EMotorMoveAudioEvent, string> AudioEventOverrideMap = new Dictionary<EMotorMoveAudioEvent, string>();

		// Token: 0x0401FB23 RID: 129827
		[Nullable(2)]
		private static Stat StackStatInternal;

		// Token: 0x0401FB24 RID: 129828
		private bool IsPlayerDriving;

		// Token: 0x0401FB25 RID: 129829
		private bool HasEventListener;

		// Token: 0x0401FB26 RID: 129830
		private float MotorStrength;

		// Token: 0x0401FB27 RID: 129831
		private float MaxMotorStrength;

		// Token: 0x0401FB28 RID: 129832
		private float LastMotorOnHitSpeed;

		// Token: 0x0401FB29 RID: 129833
		private float LastMotorOnHitStrength;

		// Token: 0x0401FB2A RID: 129834
		private float InAirDuration;

		// Token: 0x0401FB2B RID: 129835
		private EMotorSubState LastMotorSubState = EMotorSubState.EMotorSubState_MAX;

		// Token: 0x0401FB2C RID: 129836
		private float LastMotorSpeed;

		// Token: 0x0401FB2D RID: 129837
		private float LastEngineSpeed;

		// Token: 0x0401FB2E RID: 129838
		private bool LastNitroInput;

		// Token: 0x0401FB2F RID: 129839
		private bool LastNitroSprint;

		// Token: 0x0401FB30 RID: 129840
		private double HangsAudioLastTime;
	}
}

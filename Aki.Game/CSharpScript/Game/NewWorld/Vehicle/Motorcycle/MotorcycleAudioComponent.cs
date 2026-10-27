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
	// Token: 0x02007023 RID: 28707
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleAudioComponent : VehicleAudioComponent, IStaticVariableResetter
	{
		// Token: 0x06045DDB RID: 286171 RVA: 0x0115F483 File Offset: 0x0115D683
		static MotorcycleAudioComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleAudioComponent.CreateStaticDefaultValue), new Action(MotorcycleAudioComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06045DDC RID: 286172 RVA: 0x0115F4A2 File Offset: 0x0115D6A2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045DDD RID: 286173 RVA: 0x0115F4A4 File Offset: 0x0115D6A4
		public static void ResetStaticDefaultValue()
		{
			MotorcycleAudioComponent.StackStatInternal = null;
		}

		// Token: 0x17009BBE RID: 39870
		// (get) Token: 0x06045DDE RID: 286174 RVA: 0x0115F4AC File Offset: 0x0115D6AC
		// (set) Token: 0x06045DDF RID: 286175 RVA: 0x0115F4CD File Offset: 0x0115D6CD
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

		// Token: 0x17009BBF RID: 39871
		// (get) Token: 0x06045DE0 RID: 286176 RVA: 0x0115F4D6 File Offset: 0x0115D6D6
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

		// Token: 0x06045DE1 RID: 286177 RVA: 0x0115F500 File Offset: 0x0115D700
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

		// Token: 0x06045DE2 RID: 286178 RVA: 0x0115F5D8 File Offset: 0x0115D7D8
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

		// Token: 0x06045DE3 RID: 286179 RVA: 0x0115F655 File Offset: 0x0115D855
		protected override bool OnEnd()
		{
			this.ChangeEventListener(true);
			this.LeaveMotorClearAudio();
			this.IsPlayerDriving = false;
			return base.OnEnd();
		}

		// Token: 0x06045DE4 RID: 286180 RVA: 0x0115F674 File Offset: 0x0115D874
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

		// Token: 0x06045DE5 RID: 286181 RVA: 0x0115F708 File Offset: 0x0115D908
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

		// Token: 0x06045DE6 RID: 286182 RVA: 0x0115F728 File Offset: 0x0115D928
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

		// Token: 0x06045DE7 RID: 286183 RVA: 0x0115F9B4 File Offset: 0x0115DBB4
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

		// Token: 0x06045DE8 RID: 286184 RVA: 0x0115FBBC File Offset: 0x0115DDBC
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

		// Token: 0x06045DE9 RID: 286185 RVA: 0x0115FC1E File Offset: 0x0115DE1E
		private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			this.MaxMotorStrength = newValue;
		}

		// Token: 0x06045DEA RID: 286186 RVA: 0x0115FC28 File Offset: 0x0115DE28
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

		// Token: 0x06045DEB RID: 286187 RVA: 0x0115FCA8 File Offset: 0x0115DEA8
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

		// Token: 0x06045DEC RID: 286188 RVA: 0x0115FD74 File Offset: 0x0115DF74
		private void MotorDriftingStateChange(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.DriftingState, false);
				return;
			}
			this.ChangeMoveAudioEvent(EMotorMoveAudioEvent.DriftingState, true);
		}

		// Token: 0x06045DED RID: 286189 RVA: 0x0115FD94 File Offset: 0x0115DF94
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

		// Token: 0x06045DEE RID: 286190 RVA: 0x0115FE27 File Offset: 0x0115E027
		private void MotorNitroStateChange(int tagId, bool tagExist)
		{
			this.MotorNitroAcceleration(tagExist);
		}

		// Token: 0x06045DEF RID: 286191 RVA: 0x0115FE30 File Offset: 0x0115E030
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

		// Token: 0x06045DF0 RID: 286192 RVA: 0x0115FEE8 File Offset: 0x0115E0E8
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

		// Token: 0x06045DF1 RID: 286193 RVA: 0x0115FF8C File Offset: 0x0115E18C
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

		// Token: 0x06045DF2 RID: 286194 RVA: 0x01160080 File Offset: 0x0115E280
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

		// Token: 0x06045DF3 RID: 286195 RVA: 0x011601D8 File Offset: 0x0115E3D8
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

		// Token: 0x06045DF4 RID: 286196 RVA: 0x0116026C File Offset: 0x0115E46C
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

		// Token: 0x06045DF5 RID: 286197 RVA: 0x011602DC File Offset: 0x0115E4DC
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

		// Token: 0x06045DF6 RID: 286198 RVA: 0x01160420 File Offset: 0x0115E620
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

		// Token: 0x06045DF7 RID: 286199 RVA: 0x011604CC File Offset: 0x0115E6CC
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

		// Token: 0x06045DF8 RID: 286200 RVA: 0x01160564 File Offset: 0x0115E764
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

		// Token: 0x06045DF9 RID: 286201 RVA: 0x011605C0 File Offset: 0x0115E7C0
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

		// Token: 0x06045DFA RID: 286202 RVA: 0x011606A8 File Offset: 0x0115E8A8
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

		// Token: 0x06045DFB RID: 286203 RVA: 0x01160708 File Offset: 0x0115E908
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

		// Token: 0x06045DFC RID: 286204 RVA: 0x01160768 File Offset: 0x0115E968
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

		// Token: 0x06045DFD RID: 286205 RVA: 0x011607E0 File Offset: 0x0115E9E0
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

		// Token: 0x06045DFE RID: 286206 RVA: 0x0116086C File Offset: 0x0115EA6C
		private bool CheckMotorAirState(EMotorSubState state)
		{
			return state == EMotorSubState.AirMoving || state == EMotorSubState.Soaring;
		}

		// Token: 0x06045DFF RID: 286207 RVA: 0x01160878 File Offset: 0x0115EA78
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

		// Token: 0x06045E00 RID: 286208 RVA: 0x0116092D File Offset: 0x0115EB2D
		public void ClearAudioEventOverrides()
		{
			this.AudioEventOverrideMap.Clear();
		}

		// Token: 0x06045E01 RID: 286209 RVA: 0x0116093C File Offset: 0x0115EB3C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleAudioComponent motorcycleAudioComponent = (MotorcycleAudioComponent)componentTemplate;
			if (base.CanResetComponentProperty("TempVector") && motorcycleAudioComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector), "TempVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("MotorSpeedDirection") && motorcycleAudioComponent.MotorSpeedDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MotorSpeedDirection), "MotorSpeedDirection"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("FrontWheelHangG"))
			{
				this.FrontWheelHangG = motorcycleAudioComponent.FrontWheelHangG;
			}
			if (base.CanResetComponentProperty("FrontWheelPulling") && motorcycleAudioComponent.FrontWheelPulling != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.FrontWheelPulling), "FrontWheelPulling"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("RearWheelHangG"))
			{
				this.RearWheelHangG = motorcycleAudioComponent.RearWheelHangG;
			}
			if (base.CanResetComponentProperty("RearWheelPulling") && motorcycleAudioComponent.RearWheelPulling != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.RearWheelPulling), "RearWheelPulling"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (motorcycleAudioComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MotorcycleMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (motorcycleAudioComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("WaterComp"))
			{
				if (motorcycleAudioComponent.WaterComp == null)
				{
					this.WaterComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MotorcycleWaterComponent>(this.WaterComp), "WaterComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AudioEventHandleMap") && motorcycleAudioComponent.AudioEventHandleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EMotorMoveAudioEvent, int>>(this.AudioEventHandleMap), "AudioEventHandleMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CacheHitResultInternal"))
			{
				if (motorcycleAudioComponent.CacheHitResultInternal == null)
				{
					this.CacheHitResultInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FHitResult>(this.CacheHitResultInternal), "CacheHitResultInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastTexture"))
			{
				this.LastTexture = motorcycleAudioComponent.LastTexture;
			}
			if (base.CanResetComponentProperty("AudioEventOverrideMap") && motorcycleAudioComponent.AudioEventOverrideMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EMotorMoveAudioEvent, string>>(this.AudioEventOverrideMap), "AudioEventOverrideMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("IsPlayerDriving"))
			{
				this.IsPlayerDriving = motorcycleAudioComponent.IsPlayerDriving;
			}
			if (base.CanResetComponentProperty("HasEventListener"))
			{
				this.HasEventListener = motorcycleAudioComponent.HasEventListener;
			}
			if (base.CanResetComponentProperty("MotorStrength"))
			{
				this.MotorStrength = motorcycleAudioComponent.MotorStrength;
			}
			if (base.CanResetComponentProperty("MaxMotorStrength"))
			{
				this.MaxMotorStrength = motorcycleAudioComponent.MaxMotorStrength;
			}
			if (base.CanResetComponentProperty("LastMotorOnHitSpeed"))
			{
				this.LastMotorOnHitSpeed = motorcycleAudioComponent.LastMotorOnHitSpeed;
			}
			if (base.CanResetComponentProperty("LastMotorOnHitStrength"))
			{
				this.LastMotorOnHitStrength = motorcycleAudioComponent.LastMotorOnHitStrength;
			}
			if (base.CanResetComponentProperty("InAirDuration"))
			{
				this.InAirDuration = motorcycleAudioComponent.InAirDuration;
			}
			if (base.CanResetComponentProperty("LastMotorSubState"))
			{
				this.LastMotorSubState = motorcycleAudioComponent.LastMotorSubState;
			}
			if (base.CanResetComponentProperty("LastMotorSpeed"))
			{
				this.LastMotorSpeed = motorcycleAudioComponent.LastMotorSpeed;
			}
			if (base.CanResetComponentProperty("LastEngineSpeed"))
			{
				this.LastEngineSpeed = motorcycleAudioComponent.LastEngineSpeed;
			}
			if (base.CanResetComponentProperty("LastNitroInput"))
			{
				this.LastNitroInput = motorcycleAudioComponent.LastNitroInput;
			}
			if (base.CanResetComponentProperty("LastNitroSprint"))
			{
				this.LastNitroSprint = motorcycleAudioComponent.LastNitroSprint;
			}
			if (base.CanResetComponentProperty("HangsAudioLastTime"))
			{
				this.HangsAudioLastTime = motorcycleAudioComponent.HangsAudioLastTime;
			}
			return true;
		}

		// Token: 0x04024856 RID: 149590
		private const int MATERIAL_ID_WAT = 6;

		// Token: 0x04024857 RID: 149591
		private const int MATERIAL_ID_SHR = 14;

		// Token: 0x04024858 RID: 149592
		private const double SPEED_TOLERANCE = 20.0;

		// Token: 0x04024859 RID: 149593
		private const double ACC_CHANGE_TOLERANCE = 10.0;

		// Token: 0x0402485A RID: 149594
		private const double STRENGTH_TOLERANCE = 5.0;

		// Token: 0x0402485B RID: 149595
		private const float MS_TO_SECOND = 0.001f;

		// Token: 0x0402485C RID: 149596
		private const float IN_AIR_MAX_DURATION = 10f;

		// Token: 0x0402485D RID: 149597
		private const int LEAVE_MOTOR_TIME = 200;

		// Token: 0x0402485E RID: 149598
		private const double HANG_CHANGE_SPEED_TOLERANCE = 25.0;

		// Token: 0x0402485F RID: 149599
		private const int HANG_AUDIO_INTERVAL_TIME = 100;

		// Token: 0x04024860 RID: 149600
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04024861 RID: 149601
		private readonly Vector MotorSpeedDirection = Vector.Create();

		// Token: 0x04024862 RID: 149602
		private float FrontWheelHangG;

		// Token: 0x04024863 RID: 149603
		private readonly Vector FrontWheelPulling = Vector.Create();

		// Token: 0x04024864 RID: 149604
		private float RearWheelHangG;

		// Token: 0x04024865 RID: 149605
		private readonly Vector RearWheelPulling = Vector.Create();

		// Token: 0x04024866 RID: 149606
		[Nullable(2)]
		private MotorcycleMoveComponent MoveComp;

		// Token: 0x04024867 RID: 149607
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04024868 RID: 149608
		[Nullable(2)]
		private MotorcycleWaterComponent WaterComp;

		// Token: 0x04024869 RID: 149609
		private readonly Dictionary<EMotorMoveAudioEvent, int> AudioEventHandleMap = new Dictionary<EMotorMoveAudioEvent, int>();

		// Token: 0x0402486A RID: 149610
		[Nullable(2)]
		private FHitResult CacheHitResultInternal;

		// Token: 0x0402486B RID: 149611
		private CharacterFootEffectComponent.EFootstepTexture LastTexture;

		// Token: 0x0402486C RID: 149612
		private readonly Dictionary<EMotorMoveAudioEvent, string> AudioEventOverrideMap = new Dictionary<EMotorMoveAudioEvent, string>();

		// Token: 0x0402486D RID: 149613
		[Nullable(2)]
		private static Stat StackStatInternal;

		// Token: 0x0402486E RID: 149614
		private bool IsPlayerDriving;

		// Token: 0x0402486F RID: 149615
		private bool HasEventListener;

		// Token: 0x04024870 RID: 149616
		private float MotorStrength;

		// Token: 0x04024871 RID: 149617
		private float MaxMotorStrength;

		// Token: 0x04024872 RID: 149618
		private float LastMotorOnHitSpeed;

		// Token: 0x04024873 RID: 149619
		private float LastMotorOnHitStrength;

		// Token: 0x04024874 RID: 149620
		private float InAirDuration;

		// Token: 0x04024875 RID: 149621
		private EMotorSubState LastMotorSubState = EMotorSubState.EMotorSubState_MAX;

		// Token: 0x04024876 RID: 149622
		private float LastMotorSpeed;

		// Token: 0x04024877 RID: 149623
		private float LastEngineSpeed;

		// Token: 0x04024878 RID: 149624
		private bool LastNitroInput;

		// Token: 0x04024879 RID: 149625
		private bool LastNitroSprint;

		// Token: 0x0402487A RID: 149626
		private double HangsAudioLastTime;
	}
}

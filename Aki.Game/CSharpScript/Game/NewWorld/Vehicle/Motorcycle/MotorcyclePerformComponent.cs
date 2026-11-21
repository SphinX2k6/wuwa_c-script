using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.Vehicle.Motor;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061A7 RID: 24999
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcyclePerformComponent : VehiclePerformComponent, IStaticVariableResetter
	{
		// Token: 0x0603BFFA RID: 245754 RVA: 0x0110CDCE File Offset: 0x0110AFCE
		static MotorcyclePerformComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcyclePerformComponent.CreateStaticDefaultValue), new Action(MotorcyclePerformComponent.ResetStaticDefaultValue));
		}

		// Token: 0x1700711C RID: 28956
		// (get) Token: 0x0603BFFB RID: 245755 RVA: 0x0110CDFC File Offset: 0x0110AFFC
		// (set) Token: 0x0603BFFC RID: 245756 RVA: 0x0110CE04 File Offset: 0x0110B004
		protected bool DrivingBuffActivating
		{
			get
			{
				return this.DrivingBuffActivatingInternal;
			}
			set
			{
				if (this.DrivingBuffActivatingInternal == value)
				{
					return;
				}
				this.DrivingBuffActivatingInternal = value;
				VehicleActorComponent actorComp = this.ActorComp;
				if (actorComp == null || !actorComp.IsAutonomousProxy)
				{
					return;
				}
				if (value)
				{
					using (List<long>.Enumerator enumerator = this.DrivingBuffs.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							long buffId = enumerator.Current;
							VehicleBuffComponent buffComp = this.BuffComp;
							if (buffComp != null)
							{
								buffComp.AddBuff(buffId, new AddBuffParam
								{
									InstigatorId = this.BuffComp.CreatureDataId,
									Reason = "常驻buffs"
								});
							}
						}
						return;
					}
				}
				foreach (long buffId2 in this.DrivingBuffs)
				{
					VehicleBuffComponent buffComp2 = this.BuffComp;
					if (buffComp2 != null)
					{
						buffComp2.RemoveBuff(buffId2, -1, "常驻buffs", null, null, null);
					}
				}
			}
		}

		// Token: 0x1700711D RID: 28957
		// (get) Token: 0x0603BFFD RID: 245757 RVA: 0x0110CF20 File Offset: 0x0110B120
		// (set) Token: 0x0603BFFE RID: 245758 RVA: 0x0110CF28 File Offset: 0x0110B128
		protected int Hour
		{
			get
			{
				return this.HourInternal;
			}
			set
			{
				if (this.HourInternal == value)
				{
					return;
				}
				this.HourInternal = value;
				if (value < 0)
				{
					this.CurrentHourEffect = 0L;
					return;
				}
				foreach (ValueTuple<float, long> valueTuple in this.DayTimeBuffs)
				{
					float item = valueTuple.Item1;
					long item2 = valueTuple.Item2;
					if ((float)value < item)
					{
						this.CurrentHourEffect = item2;
						break;
					}
				}
			}
		}

		// Token: 0x1700711E RID: 28958
		// (get) Token: 0x0603BFFF RID: 245759 RVA: 0x0110CFAC File Offset: 0x0110B1AC
		// (set) Token: 0x0603C000 RID: 245760 RVA: 0x0110CFB4 File Offset: 0x0110B1B4
		protected long CurrentHourEffect
		{
			get
			{
				return this.CurrentHourEffectInternal;
			}
			set
			{
				if (this.CurrentHourEffectInternal == value)
				{
					return;
				}
				if (this.CurrentHourEffectInternal > 0L)
				{
					VehicleBuffComponent buffComp = this.BuffComp;
					if (buffComp != null)
					{
						buffComp.RemoveBuff(this.CurrentHourEffectInternal, -1, "时间buff", null, null, null);
					}
				}
				this.CurrentHourEffectInternal = value;
				if (this.CurrentHourEffectInternal > 0L)
				{
					VehicleBuffComponent buffComp2 = this.BuffComp;
					if (buffComp2 == null)
					{
						return;
					}
					buffComp2.AddBuff(this.CurrentHourEffectInternal, new AddBuffParam
					{
						InstigatorId = this.BuffComp.CreatureDataId,
						Reason = "时间buff"
					});
				}
			}
		}

		// Token: 0x1700711F RID: 28959
		// (get) Token: 0x0603C001 RID: 245761 RVA: 0x0110D055 File Offset: 0x0110B255
		public float LaunchSpeedFadeTime
		{
			get
			{
				return this.LaunchSpeedFadeTimeInternal;
			}
		}

		// Token: 0x17007120 RID: 28960
		// (get) Token: 0x0603C002 RID: 245762 RVA: 0x0110D05D File Offset: 0x0110B25D
		public float LaunchVehicleSpeedAddRatio
		{
			get
			{
				return this.LaunchVehicleSpeedAddRatioInternal;
			}
		}

		// Token: 0x17007121 RID: 28961
		// (get) Token: 0x0603C003 RID: 245763 RVA: 0x0110D065 File Offset: 0x0110B265
		[Nullable(2)]
		public UCurveFloat LaunchSpeedFadeCurve
		{
			[NullableContext(2)]
			get
			{
				return this.LaunchSpeedFadeCurveInternal;
			}
		}

		// Token: 0x0603C004 RID: 245764 RVA: 0x0110D070 File Offset: 0x0110B270
		protected override bool OnStart()
		{
			bool result = base.OnStart();
			this.BuffComp = base.Entity.GetComponent<VehicleBuffComponent>();
			this.InitMotorcycleDither();
			BaseVehiclePerformComponent component = base.Entity.GetComponent<BaseVehiclePerformComponent>();
			object obj;
			if (component == null)
			{
				obj = null;
			}
			else
			{
				VehicleConfig config = component.Config;
				obj = ((config != null) ? config.Asset : null);
			}
			BP_MotorConfig_C bp_MotorConfig_C = obj as BP_MotorConfig_C;
			if (bp_MotorConfig_C == null)
			{
				return result;
			}
			TArray<long> 常驻buffs = bp_MotorConfig_C.常驻buffs;
			this.DrivingBuffs.Clear();
			for (int i = 常驻buffs.Num() - 1; i >= 0; i--)
			{
				this.DrivingBuffs.Add(常驻buffs.Get(i));
			}
			this.HitBuffMap.Clear();
			foreach (KeyValuePair<EMotorPart, long> keyValuePair in bp_MotorConfig_C.撞击buff)
			{
				EMotorPart emotorPart;
				long num;
				keyValuePair.Deconstruct(out emotorPart, out num);
				EMotorPart key = emotorPart;
				long value = num;
				this.HitBuffMap[key] = value;
			}
			this.DayTimeBuffs.Clear();
			foreach (SFloatThresholdAndBuff sfloatThresholdAndBuff in bp_MotorConfig_C.时段buff)
			{
				this.DayTimeBuffs.Add(new ValueTuple<float, long>(sfloatThresholdAndBuff.Threshold, sfloatThresholdAndBuff.BuffId));
			}
			this.OverlapSmallObjectEffectBuff = bp_MotorConfig_C.和小物件重合时的特效Buff;
			this.LaunchSpeedFadeTimeInternal = bp_MotorConfig_C.叠加速度衰减时间;
			this.LaunchSpeedFadeCurveInternal = bp_MotorConfig_C.叠加速度衰减曲线;
			this.LaunchVehicleSpeedAddRatioInternal = bp_MotorConfig_C.载具速度叠加比例;
			EventSystem.Instance.AddWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
			return result;
		}

		// Token: 0x0603C005 RID: 245765 RVA: 0x0110D228 File Offset: 0x0110B428
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
			return base.OnEnd();
		}

		// Token: 0x0603C006 RID: 245766 RVA: 0x0110D252 File Offset: 0x0110B452
		[NullableContext(2)]
		private void OnVehicleDriverChange(Entity oldDriver, Entity newDriver)
		{
			if (newDriver != null)
			{
				this.DrivingBuffActivating = true;
				return;
			}
			this.DrivingBuffActivating = false;
			this.Hour = -1;
		}

		// Token: 0x0603C007 RID: 245767 RVA: 0x0110D270 File Offset: 0x0110B470
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			if (base.Driver != null && TimeOfDayModel.Instance != null)
			{
				this.Hour = (int)Math.Floor(TimeOfDayModel.Instance.GameTime.Hour);
			}
			else
			{
				this.Hour = -1;
			}
			this.HandlePendingDitherActor();
			this.HandleSmallItemTrace();
			if (this.NextResetSeatTransTime < Time.Instance.Now)
			{
				this.NextResetSeatTransTime = Time.Instance.Now + 3000.0;
				foreach (KeyValuePair<int, VehiclePassengerInfo> keyValuePair in this.PassengerInfoMap)
				{
					int num;
					VehiclePassengerInfo vehiclePassengerInfo;
					keyValuePair.Deconstruct(out num, out vehiclePassengerInfo);
					VehiclePassengerInfo vehiclePassengerInfo2 = vehiclePassengerInfo;
					Entity passengerEntity = vehiclePassengerInfo2.PassengerEntity;
					UeMovementTickManageComponent ueMovementTickManageComponent = (passengerEntity != null) ? passengerEntity.GetComponent<UeMovementTickManageComponent>() : null;
					if (ueMovementTickManageComponent == null || !ueMovementTickManageComponent.Active)
					{
						Entity passengerEntity2 = vehiclePassengerInfo2.PassengerEntity;
						CharacterDriveVehicleComponent characterDriveVehicleComponent = (passengerEntity2 != null) ? passengerEntity2.GetComponent<CharacterDriveVehicleComponent>() : null;
						if (characterDriveVehicleComponent != null)
						{
							characterDriveVehicleComponent.MotorCheckAndResetRelativeTransform();
						}
					}
				}
			}
		}

		// Token: 0x0603C008 RID: 245768 RVA: 0x0110D380 File Offset: 0x0110B580
		protected override void OnSetDriver()
		{
			base.OnSetDriver();
			VehicleAnimationComponent animComp = this.AnimComp;
			if (((animComp != null) ? animComp.MainAnimInstance : null) != null && this.AnimComp.MainAnimInstance is UKuroAnimInstanceVehicle)
			{
				Entity driverInternal = this.DriverInternal;
				CharacterActorComponent characterActorComponent = (driverInternal != null) ? driverInternal.GetComponent<CharacterActorComponent>() : null;
				((UKuroAnimInstanceVehicle)this.AnimComp.MainAnimInstance).SetDriver((characterActorComponent != null) ? characterActorComponent.Actor : null);
				((UKuroAnimInstanceVehicle)this.AnimComp.MainAnimInstance).ConsumeExtractedRootMotion(1f);
			}
			if (base.Driver == null)
			{
				this.SetNoDriverFrame = Time.Instance.Frame;
				return;
			}
			if (Time.Instance.Frame == this.SetNoDriverFrame)
			{
				return;
			}
			VehicleActorComponent actorComp = this.ActorComp;
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (actorComp != null) ? actorComp.Actor.VehicleMovementComponent : null;
			if (ukuroVehicleMovementComponent != null)
			{
				ukuroVehicleMovementComponent.Velocity = global::Vector.ZeroVector;
				ukuroVehicleMovementComponent.SetMotorRotateSpeed(global::Vector.ZeroVector, 0f);
			}
			VehicleActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 == null)
			{
				return;
			}
			UKuroVehicleMovementComponent vehicleMovementComponent = actorComp2.Actor.VehicleMovementComponent;
			if (vehicleMovementComponent == null)
			{
				return;
			}
			vehicleMovementComponent.ResetMotorcycle();
		}

		// Token: 0x0603C009 RID: 245769 RVA: 0x0110D48C File Offset: 0x0110B68C
		protected void RefreshSummonedEntity(VehiclePassengerInfo info, bool isEnter)
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantMotorcycle, 1);
			if (summonedEntity == null)
			{
				return;
			}
			Entity passengerEntity = info.PassengerEntity;
			int? num;
			if (passengerEntity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureDataComponent = passengerEntity.CheckGetComponent<CreatureDataComponent>();
				num = ((creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null);
			}
			int? num2 = num;
			if (num2 != null)
			{
				int? num3 = num2;
				int num4 = 0;
				if (!(num3.GetValueOrDefault() <= num4 & num3 != null))
				{
					WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(num2.Value);
					PlayerFollowableComponent playerFollowableComponent = (playerEntity != null) ? playerEntity.CheckGetComponent<PlayerFollowableComponent>() : null;
					if (playerFollowableComponent == null)
					{
						return;
					}
					playerFollowableComponent.UpdatePlayerFollowers(new PlayerFollowerItemInfo[]
					{
						new PlayerFollowerItemInfo
						{
							Type = 666,
							EntityId = (isEnter ? summonedEntity.CreatureDataId : 0L)
						}
					});
					return;
				}
			}
		}

		// Token: 0x0603C00A RID: 245770 RVA: 0x0110D557 File Offset: 0x0110B757
		protected override void EnterVehiclePerform(VehiclePassengerInfo info)
		{
			base.EnterVehiclePerform(info);
			this.RefreshSummonedEntity(info, true);
			this.SetDitherEnable(info, true);
		}

		// Token: 0x0603C00B RID: 245771 RVA: 0x0110D570 File Offset: 0x0110B770
		protected override void LeaveVehiclePerform(VehiclePassengerInfo info)
		{
			base.LeaveVehiclePerform(info);
			this.SetDitherEnable(info, false);
			this.RefreshSummonedEntity(info, false);
		}

		// Token: 0x0603C00C RID: 245772 RVA: 0x0110D58C File Offset: 0x0110B78C
		protected override void OnHit(FHitResult hitResult)
		{
			base.OnHit(hitResult);
			VehicleActorComponent actorComp = this.ActorComp;
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (actorComp != null) ? actorComp.Actor.VehicleMovementComponent : null;
			if (ukuroVehicleMovementComponent == null)
			{
				return;
			}
			EMotorPart lastMotorHitPart = ukuroVehicleMovementComponent.LastMotorHitPart;
			long num2;
			long num = this.HitBuffMap.TryGetValue(ukuroVehicleMovementComponent.LastMotorHitPart, out num2) ? num2 : 0L;
			if (num > 0L)
			{
				VehicleBuffComponent buffComp = this.BuffComp;
				if (buffComp != null)
				{
					buffComp.AddBuff(num, new AddBuffParam
					{
						InstigatorId = this.BuffComp.CreatureDataId,
						Reason = "撞击buff"
					});
				}
				EventSystem.Instance.EmitWithTarget<EMotorPart, FHitResult>(base.Entity, EEventName.MotorOnHit, ukuroVehicleMovementComponent.LastMotorHitPart, hitResult);
			}
		}

		// Token: 0x0603C00D RID: 245773 RVA: 0x0110D634 File Offset: 0x0110B834
		protected unsafe void SetDitherEnable(VehiclePassengerInfo info, bool enable)
		{
			if (this.EnableDither == enable)
			{
				return;
			}
			this.EnableDither = enable;
			this.SetDitherCollisionEnable(enable);
			if (!enable)
			{
				this.ResetAllPendingDitherActor();
				this.PendingSmallItemComponents.Clear();
				this.ApplySmallItemComponents();
			}
			CreatureDataComponent creatureData = this.CreatureData;
			long? num = (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null;
			Entity passengerEntity = info.PassengerEntity;
			long? num2;
			if (passengerEntity == null)
			{
				num2 = null;
			}
			else
			{
				CreatureDataComponent creatureDataComponent = passengerEntity.CheckGetComponent<CreatureDataComponent>();
				num2 = ((creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
			}
			long? num3 = num2;
			if (num != null)
			{
				long? num4 = num;
				long num5 = 0L;
				if ((num4.GetValueOrDefault() > num5 & num4 != null) && num3 != null)
				{
					num4 = num3;
					num5 = 0L;
					if (num4.GetValueOrDefault() > num5 & num4 != null)
					{
						if (enable)
						{
							CameraModel.Instance.MainModel.DitherEntityGroups.Union(num.Value, num3.Value);
							VehicleActorComponent vehicleActorComponent = base.Entity.CheckGetComponent<VehicleActorComponent>();
							double? num6;
							if (vehicleActorComponent == null)
							{
								num6 = null;
							}
							else
							{
								TsBaseVehicle actor = vehicleActorComponent.Actor;
								if (actor == null)
								{
									num6 = null;
								}
								else
								{
									CharacterDitherEffectController ditherEffectController = actor.DitherEffectController;
									num6 = ((ditherEffectController != null) ? new double?(ditherEffectController.CurrentDitherValue) : null);
								}
							}
							double? num7 = num6;
							if (num7 == null)
							{
								return;
							}
							Entity passengerEntity2 = info.PassengerEntity;
							if (passengerEntity2 == null)
							{
								return;
							}
							CharacterActorComponent characterActorComponent = passengerEntity2.CheckGetComponent<CharacterActorComponent>();
							if (characterActorComponent == null)
							{
								return;
							}
							TsBaseCharacter actor2 = characterActorComponent.Actor;
							if (actor2 == null)
							{
								return;
							}
							actor2.SetDitherEffect((float)num7.Value, ECharacterDitherType.Fight);
							return;
						}
						else
						{
							DisjointSet<long> ditherEntityGroups = CameraModel.Instance.MainModel.DitherEntityGroups;
							if (ditherEntityGroups != null)
							{
								ditherEntityGroups.Delete(num.Value);
							}
							DisjointSet<long> ditherEntityGroups2 = CameraModel.Instance.MainModel.DitherEntityGroups;
							if (ditherEntityGroups2 == null)
							{
								return;
							}
							ditherEntityGroups2.Delete(num3.Value);
							return;
						}
					}
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "MotorcyclePerformComponent.SetDitherEnable: 载具或乘客不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("vehicleCreatureDataId", ((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "null");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("passengerCreatureDataId", ((num3 != null) ? num3.GetValueOrDefault().ToString() : null) ?? "null");
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603C00E RID: 245774 RVA: 0x0110D8B0 File Offset: 0x0110BAB0
		protected void SetDitherCollisionEnable(bool enable)
		{
			VehicleActorComponent actorComp = this.ActorComp;
			BP_Motor_BaseVehicle_C bp_Motor_BaseVehicle_C = ((actorComp != null) ? actorComp.Owner : null) as BP_Motor_BaseVehicle_C;
			if (bp_Motor_BaseVehicle_C == null)
			{
				return;
			}
			ECollisionEnabled collisionEnabled = enable ? ECollisionEnabled.QueryOnly : ECollisionEnabled.NoCollision;
			UCapsuleComponent capsuleForDither = bp_Motor_BaseVehicle_C.CapsuleForDither;
			if (capsuleForDither != null)
			{
				capsuleForDither.SetCollisionEnabled(collisionEnabled);
			}
			UCapsuleComponent capsuleForDither2 = bp_Motor_BaseVehicle_C.CapsuleForDither;
			if (capsuleForDither2 == null)
			{
				return;
			}
			capsuleForDither2.SetGenerateOverlapEvents(enable);
		}

		// Token: 0x0603C00F RID: 245775 RVA: 0x0110D904 File Offset: 0x0110BB04
		protected void InitMotorcycleDither()
		{
			VehicleActorComponent actorComp = this.ActorComp;
			BP_Motor_BaseVehicle_C bp_Motor_BaseVehicle_C = ((actorComp != null) ? actorComp.Owner : null) as BP_Motor_BaseVehicle_C;
			if (bp_Motor_BaseVehicle_C == null)
			{
				return;
			}
			UCapsuleComponent capsuleForDither = bp_Motor_BaseVehicle_C.CapsuleForDither;
			if (capsuleForDither != null)
			{
				capsuleForDither.OnComponentBeginOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnComponentBeginOverlap));
			}
			this.DitherCapsuleHalfHeight = bp_Motor_BaseVehicle_C.CapsuleForDither.CapsuleHalfHeight;
			this.DitherCapsuleRadius = bp_Motor_BaseVehicle_C.CapsuleForDither.CapsuleRadius;
			this.DitherDepthCurve = bp_Motor_BaseVehicle_C.深度虚化值曲线;
			this.DitherNpcRadius = Math.Max(20f, Math.Min(bp_Motor_BaseVehicle_C.虚化碰撞NPC半径, 200f));
			Transform tmpTrans = this.TmpTrans1;
			FTransformDouble ftransformDouble = this.ActorComp.ActorTransform;
			tmpTrans.FromUeTransform(ftransformDouble);
			Transform tmpTrans2 = this.TmpTrans2;
			ftransformDouble = bp_Motor_BaseVehicle_C.CapsuleForDither.D_K2_GetComponentToWorld();
			tmpTrans2.FromUeTransform(ftransformDouble);
			Transform ditherCapsuleRelativeTrans = this.DitherCapsuleRelativeTrans;
			ftransformDouble = this.TmpTrans2.ToUeTransform();
			FTransformDouble ftransformDouble2 = this.TmpTrans1.ToUeTransform();
			ftransformDouble = ftransformDouble.GetRelativeTransform(ftransformDouble2);
			ditherCapsuleRelativeTrans.FromUeTransform(ftransformDouble);
			double num = (double)(this.DitherNpcRadius + this.DitherCapsuleHalfHeight) / (double)this.DitherCapsuleHalfHeight;
			double num2 = (double)(this.DitherNpcRadius + this.DitherCapsuleRadius) / (double)this.DitherCapsuleRadius;
			this.TmpVector1.Set((double)((float)num2), (double)((float)num2), (double)((float)num));
			bp_Motor_BaseVehicle_C.CapsuleForDither.SetWorldScale3D(this.TmpVector1.ToUeVectorOld());
			float num3 = this.DitherCapsuleHalfHeight + this.DitherNpcRadius + 100f;
			this.DitherRemoveDistSquared = Math.Max(this.DitherRemoveDistSquared, num3 * num3);
		}

		// Token: 0x0603C010 RID: 245776 RVA: 0x0110DA84 File Offset: 0x0110BC84
		[NullableContext(2)]
		protected void OnComponentBeginOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, [Nullable(1)] FHitResult sweepResult)
		{
			TsBaseCharacter tsBaseCharacter = otherActor as TsBaseCharacter;
			if (tsBaseCharacter == null)
			{
				return;
			}
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			CreatureDataComponent creatureDataComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CreatureDataComponent>() : null;
			if ((creatureDataComponent == null || !creatureDataComponent.IsNpc()) && (creatureDataComponent == null || !creatureDataComponent.IsAnimal()))
			{
				return;
			}
			this.PendingDitherActorSet.Add(tsBaseCharacter);
		}

		// Token: 0x0603C011 RID: 245777 RVA: 0x0110DAE0 File Offset: 0x0110BCE0
		private void InitSmallItemTraceElement()
		{
			if (this.SmallItemTraceElement != null)
			{
				return;
			}
			this.SmallItemTraceElement = new UTraceCapsuleElement();
			this.SmallItemTraceElement.bIsSingle = false;
			this.SmallItemTraceElement.bIgnoreSelf = true;
			this.SmallItemTraceElement.WorldContextObject = this.ActorComp.Owner;
			this.SmallItemTraceElement.ActorsToIgnore.Add(this.ActorComp.Actor);
			this.SmallItemTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
			this.SmallItemTraceElement.Radius = this.DitherCapsuleRadius;
			this.SmallItemTraceElement.HalfHeight = this.DitherCapsuleHalfHeight;
		}

		// Token: 0x0603C012 RID: 245778 RVA: 0x0110DB7C File Offset: 0x0110BD7C
		private void HandleSmallItemTrace()
		{
			if (this.OverlapSmallObjectEffectBuff <= 0L || !this.EnableDither)
			{
				return;
			}
			VehicleMoveComponent moveComp = this.MoveComp;
			if (((moveComp != null) ? moveComp.Speed : 0f) >= 1000f)
			{
				this.PendingSmallItemComponents.Clear();
				this.ApplySmallItemComponents();
				return;
			}
			if (Time.Instance.Now < this.NextSmallItemTraceTime)
			{
				return;
			}
			this.NextSmallItemTraceTime = Time.Instance.Now + 500.0;
			this.InitSmallItemTraceElement();
			this.CalculateCapsuleTransform();
			global::Vector location = this.TmpTrans2.GetLocation();
			TraceElementCommon.Instance.SetStartLocation(this.SmallItemTraceElement, location);
			TraceElementCommon.Instance.SetEndLocation(this.SmallItemTraceElement, location);
			TraceElementCommon.Instance.SetCapsuleOrientation(this.SmallItemTraceElement, this.TmpTrans2.GetRotation().Rotator(null));
			bool flag = TraceElementCommon.Instance.CapsuleTrace(this.SmallItemTraceElement, "MotorcycleSmallItemTrace");
			this.PendingSmallItemComponents.Clear();
			if (flag)
			{
				UKuroHitResult hitResult = this.SmallItemTraceElement.HitResult;
				int hitCount = hitResult.GetHitCount();
				for (int i = 0; i < hitCount; i++)
				{
					UPrimitiveComponent uprimitiveComponent = hitResult.Components.Get(i).Get();
					bool flag2 = uprimitiveComponent != null && uprimitiveComponent.IsValid() && uprimitiveComponent.ComponentHasTag(MotorcyclePerformComponent.SmallItemTag);
					if (!flag2 && uprimitiveComponent != null && uprimitiveComponent.IsValid() && uprimitiveComponent is UCollisionClusterComponent)
					{
						flag2 = UKuroCollisionLibrary.ActorHasTag(uprimitiveComponent.GetOwner(), MotorcyclePerformComponent.SmallItemTag, hitResult.ItemArray.Get(i));
					}
					if (flag2 && uprimitiveComponent != null && uprimitiveComponent.IsA(UStaticMeshComponent.StaticClass()))
					{
						this.PendingSmallItemComponents.Add(uprimitiveComponent as UStaticMeshComponent);
					}
				}
			}
			this.ApplySmallItemComponents();
		}

		// Token: 0x0603C013 RID: 245779 RVA: 0x0110DD3C File Offset: 0x0110BF3C
		private void ApplySmallItemComponents()
		{
			foreach (UStaticMeshComponent ustaticMeshComponent in this.PendingSmallItemComponents)
			{
				if (!this.DetectedSmallItemComponents.Contains(ustaticMeshComponent))
				{
					SceneOpacityController.Instance.SetOpacity(ustaticMeshComponent, base.Entity.Id, true);
				}
			}
			foreach (UStaticMeshComponent ustaticMeshComponent2 in this.DetectedSmallItemComponents)
			{
				if (!this.PendingSmallItemComponents.Contains(ustaticMeshComponent2))
				{
					SceneOpacityController.Instance.SetOpacity(ustaticMeshComponent2, base.Entity.Id, false);
				}
			}
			HashSet<UStaticMeshComponent> detectedSmallItemComponents = this.DetectedSmallItemComponents;
			this.DetectedSmallItemComponents = this.PendingSmallItemComponents;
			this.PendingSmallItemComponents = detectedSmallItemComponents;
		}

		// Token: 0x0603C014 RID: 245780 RVA: 0x0110DE28 File Offset: 0x0110C028
		protected void HandlePendingDitherActor()
		{
			if (this.PendingDitherActorSet.Count <= 0)
			{
				return;
			}
			this.CalculateCapsuleTransform();
			List<TsBaseCharacter> list = new List<TsBaseCharacter>();
			foreach (TsBaseCharacter tsBaseCharacter in this.PendingDitherActorSet)
			{
				if (!tsBaseCharacter.IsValid())
				{
					list.Add(tsBaseCharacter);
				}
				else
				{
					Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
					BaseCharacterComponent baseCharacterComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseCharacterComponent>() : null;
					if (baseCharacterComponent == null || !baseCharacterComponent.Valid)
					{
						list.Add(tsBaseCharacter);
					}
					else
					{
						CharacterDriveVehicleComponent component = entityNoBlueprint.GetComponent<CharacterDriveVehicleComponent>();
						int? num;
						if (component == null)
						{
							num = null;
						}
						else
						{
							Entity vehicleEntity = component.VehicleEntity;
							num = ((vehicleEntity != null) ? new int?(vehicleEntity.Id) : null);
						}
						int? num2 = num;
						int id = base.Entity.Id;
						if (num2.GetValueOrDefault() == id & num2 != null)
						{
							list.Add(tsBaseCharacter);
							tsBaseCharacter.SetDitherEffect(1f, ECharacterDitherType.Fight);
						}
						else if (global::Vector.DistSquared(baseCharacterComponent.ActorLocationProxy, this.ActorComp.ActorLocationProxy) > (double)this.DitherRemoveDistSquared)
						{
							list.Add(tsBaseCharacter);
							tsBaseCharacter.SetDitherEffect(1f, ECharacterDitherType.Fight);
						}
						else
						{
							double num3 = this.CalcDitherValue(baseCharacterComponent);
							tsBaseCharacter.SetDitherEffect((float)num3, ECharacterDitherType.Fight);
						}
					}
				}
			}
			foreach (TsBaseCharacter item in list)
			{
				this.PendingDitherActorSet.Remove(item);
			}
		}

		// Token: 0x0603C015 RID: 245781 RVA: 0x0110DFF4 File Offset: 0x0110C1F4
		protected double CalcDitherValue(BaseCharacterComponent otherActorComp)
		{
			double val = this.GetMinDistFromPointToCapsule(otherActorComp.ActorLocationProxy) - (double)this.DitherCapsuleRadius;
			double num = MathUtils.Instance.Clamp(Math.Max(0.0, val) / (double)this.DitherNpcRadius, 0.0, 1.0);
			if (this.DitherDepthCurve != null)
			{
				return (double)MathUtils.Instance.Clamp(this.DitherDepthCurve.GetFloatValue((float)num), 0f, 1f);
			}
			return num;
		}

		// Token: 0x0603C016 RID: 245782 RVA: 0x0110E078 File Offset: 0x0110C278
		protected void ResetAllPendingDitherActor()
		{
			foreach (TsBaseCharacter tsBaseCharacter in this.PendingDitherActorSet)
			{
				if (tsBaseCharacter.IsValid())
				{
					Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
					BaseCharacterComponent baseCharacterComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseCharacterComponent>() : null;
					if (baseCharacterComponent != null && baseCharacterComponent.Valid)
					{
						tsBaseCharacter.SetDitherEffect(1f, ECharacterDitherType.Fight);
					}
				}
			}
			this.PendingDitherActorSet.Clear();
		}

		// Token: 0x0603C017 RID: 245783 RVA: 0x0110E108 File Offset: 0x0110C308
		protected void CalculateCapsuleTransform()
		{
			Transform tmpTrans = this.TmpTrans1;
			FTransformDouble actorTransform = this.ActorComp.ActorTransform;
			tmpTrans.FromUeTransform(actorTransform);
			this.DitherCapsuleRelativeTrans.ComposeTransforms(this.TmpTrans1, this.TmpTrans2);
			this.TmpVector2.DeepCopy(this.TmpTrans2.GetLocation());
			this.TmpTrans2.GetRotation().GetUpVector(this.TmpVector3);
			this.TmpVector3.MultiplyEqual((double)(this.DitherCapsuleHalfHeight - this.DitherCapsuleRadius));
			this.TmpVector2.Addition(this.TmpVector3, this.CapsulePointA);
			this.TmpVector2.Subtraction(this.TmpVector3, this.CapsulePointB);
			this.TryDebugDraw();
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.CapsulePointA);
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.CapsulePointB);
		}

		// Token: 0x0603C018 RID: 245784 RVA: 0x0110E1F0 File Offset: 0x0110C3F0
		protected double GetMinDistFromPointToCapsule(global::Vector otherLocation)
		{
			this.TmpVector1.DeepCopy(otherLocation);
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector1);
			if (this.CapsulePointA.Equals(this.CapsulePointB, 9.999999747378752E-05))
			{
				return global::Vector.Dist(this.TmpVector1, this.CapsulePointA);
			}
			this.CapsulePointB.Subtraction(this.CapsulePointA, this.TmpVector3);
			this.TmpVector1.Subtraction(this.CapsulePointA, this.TmpVector5);
			double num = global::Vector.DotProduct(this.TmpVector3, this.TmpVector5) / this.TmpVector3.SizeSquared();
			if (num > 0.0 && num < 1.0)
			{
				this.TmpVector3.MultiplyEqual(num);
				this.TmpVector3.SubtractionEqual(this.TmpVector5);
				return this.TmpVector3.Size();
			}
			if (num > 0.0)
			{
				return global::Vector.Dist(this.TmpVector1, this.CapsulePointB);
			}
			return global::Vector.Dist(this.TmpVector1, this.CapsulePointA);
		}

		// Token: 0x0603C019 RID: 245785 RVA: 0x0110E310 File Offset: 0x0110C510
		protected void TryDebugDraw()
		{
			if (!MotorcyclePerformComponent.DitherDebugMode)
			{
				return;
			}
			double num = (double)(this.DitherNpcRadius + this.DitherCapsuleHalfHeight) / (double)this.DitherCapsuleHalfHeight;
			double num2 = (double)(this.DitherNpcRadius + this.DitherCapsuleRadius) / (double)this.DitherCapsuleRadius;
			this.CapsulePointA.Addition(this.CapsulePointB, MathUtils.Instance.CommonTempVector);
			MathUtils.Instance.CommonTempVector.MultiplyEqual(0.5);
			VehicleActorComponent actorComp = this.ActorComp;
			UKismetSystemLibrary.D_DrawDebugCapsule((actorComp != null) ? actorComp.Actor : null, MathUtils.Instance.CommonTempVector.ToUeVector(false), this.DitherCapsuleHalfHeight, this.DitherCapsuleRadius, this.TmpTrans2.GetRotation().Rotator(null).ToUeRotator(), new FLinearColor?(new FLinearColor(1f, 0f, 0f, 1f)), 0f, 5f);
			VehicleActorComponent actorComp2 = this.ActorComp;
			UKismetSystemLibrary.D_DrawDebugCapsule((actorComp2 != null) ? actorComp2.Actor : null, MathUtils.Instance.CommonTempVector.ToUeVector(false), (float)((double)this.DitherCapsuleHalfHeight * num), (float)((double)this.DitherCapsuleRadius * num2), this.TmpTrans2.GetRotation().Rotator(null).ToUeRotator(), new FLinearColor?(new FLinearColor(0f, 1f, 0f, 1f)), 0f, 5f);
		}

		// Token: 0x0603C01A RID: 245786 RVA: 0x0110E474 File Offset: 0x0110C674
		protected override void OnAddTrialAttributeModifier(VehiclePassengerInfo info)
		{
			TrialMotor? trialMotorConfig = MotorConfig.Instance.GetTrialMotorConfig(this.TrialAttributeId.Value);
			if (trialMotorConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "无效的试用属性";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.TrialAttributeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (trialMotorConfig.Value.TechTreeType == 1)
			{
				MotorcycleFreezeWaterComponent component = base.Entity.GetComponent<MotorcycleFreezeWaterComponent>();
				if (component != null)
				{
					component.SetIsFunctionOpenOverride(new bool?(true));
				}
				MotorcycleMoveComponent component2 = base.Entity.GetComponent<MotorcycleMoveComponent>();
				if (component2 != null)
				{
					component2.SetIsFunctionOpenOverride(new bool?(true));
				}
				BaseTagComponent component3 = base.Entity.GetComponent<BaseTagComponent>();
				if (component3 != null)
				{
					component3.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.科技树.战斗相关.科技树3节点8"]));
				}
				if (component3 != null)
				{
					component3.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.科技树.战斗相关.科技树3节点7"]));
				}
			}
			if (trialMotorConfig.Value.Level == 0)
			{
				return;
			}
			MotorLvl? motorLevelConfig = MotorConfig.Instance.GetMotorLevelConfig(trialMotorConfig.Value.Level);
			if (motorLevelConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Vehicle;
				ELogAuthor author2 = ELogAuthor.TZQ;
				string message2 = "无效的等级";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Level", trialMotorConfig.Value.Level);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Vehicle;
			ELogAuthor author3 = ELogAuthor.TZQ;
			string message3 = "添加试用属性Modifier";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Level", this.TrialAttributeId);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			FormationAttributeController.Instance.AddSpeedModifier(this.ModifierKey, EFormationAttributeId.MotorcycleStrength, EModifierType.Override, (float)motorLevelConfig.Value.NitrogenRecoverRate, 1);
		}

		// Token: 0x0603C01B RID: 245787 RVA: 0x0110E63C File Offset: 0x0110C83C
		protected override void OnRemoveTrialAttributeModifier(VehiclePassengerInfo info)
		{
			TrialMotor? trialMotorConfig = MotorConfig.Instance.GetTrialMotorConfig(this.TrialAttributeId.Value);
			if (trialMotorConfig != null && trialMotorConfig.GetValueOrDefault().TechTreeType == 1)
			{
				MotorcycleFreezeWaterComponent component = base.Entity.GetComponent<MotorcycleFreezeWaterComponent>();
				if (component != null)
				{
					component.SetIsFunctionOpenOverride(null);
				}
				MotorcycleMoveComponent component2 = base.Entity.GetComponent<MotorcycleMoveComponent>();
				if (component2 != null)
				{
					component2.SetIsFunctionOpenOverride(null);
				}
				BaseTagComponent component3 = base.Entity.GetComponent<BaseTagComponent>();
				if (component3 != null)
				{
					component3.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.科技树.战斗相关.科技树3节点8"]));
				}
				if (component3 != null)
				{
					component3.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.科技树.战斗相关.科技树3节点7"]));
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "移除试用属性Modifier";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.TrialAttributeId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			FormationAttributeController.Instance.RemoveSpeedModifier(this.ModifierKey, EFormationAttributeId.MotorcycleStrength);
		}

		// Token: 0x0603C01C RID: 245788 RVA: 0x0110E752 File Offset: 0x0110C952
		[NullableContext(2)]
		public override void FixBornLocation(global::Vector target = null, string context = null)
		{
			base.FixBornLocation(null, "FixBornLocation");
			VehicleActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.SetActorLocation(target.ToUeVector(false), context, false);
		}

		// Token: 0x0603C01D RID: 245789 RVA: 0x0110E77C File Offset: 0x0110C97C
		public override bool TryEnter(Entity entity, int seat)
		{
			bool flag = base.TryEnter(entity, seat);
			if (flag)
			{
				int id = entity.Id;
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
				if (id == num.GetValueOrDefault() & num != null)
				{
					this.SendGetOnLogEvent(entity);
				}
			}
			return flag;
		}

		// Token: 0x0603C01E RID: 245790 RVA: 0x0110E7D4 File Offset: 0x0110C9D4
		public override int TryEnterAtOnce(Entity entity, int seat, string reason = "", bool notSync = false)
		{
			int num = base.TryEnterAtOnce(entity, seat, reason, notSync);
			if (num > 0)
			{
				int id = entity.Id;
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				int? num2 = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
				if (id == num2.GetValueOrDefault() & num2 != null)
				{
					this.SendGetOnLogEvent(entity);
				}
			}
			return num;
		}

		// Token: 0x0603C01F RID: 245791 RVA: 0x0110E830 File Offset: 0x0110CA30
		protected void SendGetOnLogEvent(Entity entity)
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			if (component != null)
			{
				MotorSummonGetOnLogEvent motorSummonGetOnLogEvent = new MotorSummonGetOnLogEvent();
				motorSummonGetOnLogEvent.pos_x = (float)component.ActorLocationProxy.X;
				motorSummonGetOnLogEvent.pos_y = (float)component.ActorLocationProxy.Y;
				motorSummonGetOnLogEvent.pos_z = (float)component.ActorLocationProxy.Z;
				motorSummonGetOnLogEvent.operation_type = 2;
				LogReportController.Instance.LogReport(motorSummonGetOnLogEvent);
			}
		}

		// Token: 0x0603C020 RID: 245792 RVA: 0x0110E895 File Offset: 0x0110CA95
		public static void CreateStaticDefaultValue()
		{
			MotorcyclePerformComponent.DitherDebugMode = false;
		}

		// Token: 0x0603C021 RID: 245793 RVA: 0x0110E89D File Offset: 0x0110CA9D
		public static void ResetStaticDefaultValue()
		{
			MotorcyclePerformComponent.DitherDebugMode = false;
		}

		// Token: 0x0603C022 RID: 245794 RVA: 0x0110E8A8 File Offset: 0x0110CAA8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcyclePerformComponent motorcyclePerformComponent = (MotorcyclePerformComponent)componentTemplate;
			if (motorcyclePerformComponent.BuffComp == null)
			{
				this.BuffComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComp), "BuffComp"))
			{
				return false;
			}
			this.SetNoDriverFrame = motorcyclePerformComponent.SetNoDriverFrame;
			if (motorcyclePerformComponent.DrivingBuffs != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DrivingBuffs), "DrivingBuffs"))
			{
				return false;
			}
			this.DrivingBuffActivatingInternal = motorcyclePerformComponent.DrivingBuffActivatingInternal;
			if (motorcyclePerformComponent.HitBuffMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitBuffMap), "HitBuffMap"))
			{
				return false;
			}
			if (motorcyclePerformComponent.DayTimeBuffs != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DayTimeBuffs), "DayTimeBuffs"))
			{
				return false;
			}
			this.OverlapSmallObjectEffectBuff = motorcyclePerformComponent.OverlapSmallObjectEffectBuff;
			if (motorcyclePerformComponent.DetectedSmallItemComponents == null)
			{
				this.DetectedSmallItemComponents = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UStaticMeshComponent>(this.DetectedSmallItemComponents), "DetectedSmallItemComponents"))
			{
				return false;
			}
			if (motorcyclePerformComponent.PendingSmallItemComponents == null)
			{
				this.PendingSmallItemComponents = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UStaticMeshComponent>(this.PendingSmallItemComponents), "PendingSmallItemComponents"))
			{
				return false;
			}
			if (motorcyclePerformComponent.SmallItemTraceElement == null)
			{
				this.SmallItemTraceElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SmallItemTraceElement), "SmallItemTraceElement"))
			{
				return false;
			}
			this.NextSmallItemTraceTime = motorcyclePerformComponent.NextSmallItemTraceTime;
			this.HourInternal = motorcyclePerformComponent.HourInternal;
			this.CurrentHourEffectInternal = motorcyclePerformComponent.CurrentHourEffectInternal;
			this.LaunchSpeedFadeTimeInternal = motorcyclePerformComponent.LaunchSpeedFadeTimeInternal;
			this.LaunchVehicleSpeedAddRatioInternal = motorcyclePerformComponent.LaunchVehicleSpeedAddRatioInternal;
			if (motorcyclePerformComponent.LaunchSpeedFadeCurveInternal == null)
			{
				this.LaunchSpeedFadeCurveInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LaunchSpeedFadeCurveInternal), "LaunchSpeedFadeCurveInternal"))
			{
				return false;
			}
			this.NextResetSeatTransTime = motorcyclePerformComponent.NextResetSeatTransTime;
			this.DitherNpcRadius = motorcyclePerformComponent.DitherNpcRadius;
			if (motorcyclePerformComponent.DitherDepthCurve == null)
			{
				this.DitherDepthCurve = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DitherDepthCurve), "DitherDepthCurve"))
			{
				return false;
			}
			this.DitherCapsuleHalfHeight = motorcyclePerformComponent.DitherCapsuleHalfHeight;
			this.DitherCapsuleRadius = motorcyclePerformComponent.DitherCapsuleRadius;
			if (motorcyclePerformComponent.DitherCapsuleRelativeTrans == null)
			{
				this.DitherCapsuleRelativeTrans = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DitherCapsuleRelativeTrans), "DitherCapsuleRelativeTrans"))
			{
				return false;
			}
			if (motorcyclePerformComponent.CapsulePointA == null)
			{
				this.CapsulePointA = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CapsulePointA), "CapsulePointA"))
			{
				return false;
			}
			if (motorcyclePerformComponent.CapsulePointB == null)
			{
				this.CapsulePointB = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CapsulePointB), "CapsulePointB"))
			{
				return false;
			}
			this.DitherRemoveDistSquared = motorcyclePerformComponent.DitherRemoveDistSquared;
			if (motorcyclePerformComponent.PendingDitherActorSet == null)
			{
				this.PendingDitherActorSet = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.PendingDitherActorSet), "PendingDitherActorSet"))
			{
				return false;
			}
			this.EnableDither = motorcyclePerformComponent.EnableDither;
			return true;
		}

		// Token: 0x17007122 RID: 28962
		// (get) Token: 0x0603C023 RID: 245795 RVA: 0x0110EB84 File Offset: 0x0110CD84
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007123 RID: 28963
		// (get) Token: 0x0603C024 RID: 245796 RVA: 0x0110EB87 File Offset: 0x0110CD87
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007124 RID: 28964
		// (get) Token: 0x0603C025 RID: 245797 RVA: 0x0110EB8A File Offset: 0x0110CD8A
		public override bool NeedPostActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007125 RID: 28965
		// (get) Token: 0x0603C026 RID: 245798 RVA: 0x0110EB8D File Offset: 0x0110CD8D
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007126 RID: 28966
		// (get) Token: 0x0603C027 RID: 245799 RVA: 0x0110EB90 File Offset: 0x0110CD90
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007127 RID: 28967
		// (get) Token: 0x0603C028 RID: 245800 RVA: 0x0110EB93 File Offset: 0x0110CD93
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007128 RID: 28968
		// (get) Token: 0x0603C029 RID: 245801 RVA: 0x0110EB96 File Offset: 0x0110CD96
		public override bool NeedAfterTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FB51 RID: 129873
		private const float MIN_NPC_DITHER_RADIUS = 20f;

		// Token: 0x0401FB52 RID: 129874
		private const float MAX_NPC_DITHER_RADIUS = 200f;

		// Token: 0x0401FB53 RID: 129875
		private const float REMOVE_DITHER_ENTITY_DIST_SQUARED = 250000f;

		// Token: 0x0401FB54 RID: 129876
		private static readonly FName SmallItemTag = new FName("SMALL_ITEM");

		// Token: 0x0401FB55 RID: 129877
		private const double SMALL_ITEM_TRACE_INTERVAL = 500.0;

		// Token: 0x0401FB56 RID: 129878
		private const float SMALL_ITEM_TRACE_SPEED_THRESHOLD = 1000f;

		// Token: 0x0401FB57 RID: 129879
		[Nullable(2)]
		private VehicleBuffComponent BuffComp;

		// Token: 0x0401FB58 RID: 129880
		protected int SetNoDriverFrame;

		// Token: 0x0401FB59 RID: 129881
		private readonly List<long> DrivingBuffs = new List<long>();

		// Token: 0x0401FB5A RID: 129882
		private bool DrivingBuffActivatingInternal;

		// Token: 0x0401FB5B RID: 129883
		private readonly Dictionary<EMotorPart, long> HitBuffMap = new Dictionary<EMotorPart, long>();

		// Token: 0x0401FB5C RID: 129884
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<float, long>> DayTimeBuffs = new List<ValueTuple<float, long>>();

		// Token: 0x0401FB5D RID: 129885
		private long OverlapSmallObjectEffectBuff;

		// Token: 0x0401FB5E RID: 129886
		private HashSet<UStaticMeshComponent> DetectedSmallItemComponents = new HashSet<UStaticMeshComponent>();

		// Token: 0x0401FB5F RID: 129887
		private HashSet<UStaticMeshComponent> PendingSmallItemComponents = new HashSet<UStaticMeshComponent>();

		// Token: 0x0401FB60 RID: 129888
		[Nullable(2)]
		private UTraceCapsuleElement SmallItemTraceElement;

		// Token: 0x0401FB61 RID: 129889
		private double NextSmallItemTraceTime;

		// Token: 0x0401FB62 RID: 129890
		private int HourInternal = -1;

		// Token: 0x0401FB63 RID: 129891
		private long CurrentHourEffectInternal;

		// Token: 0x0401FB64 RID: 129892
		private float LaunchSpeedFadeTimeInternal;

		// Token: 0x0401FB65 RID: 129893
		private float LaunchVehicleSpeedAddRatioInternal = 1f;

		// Token: 0x0401FB66 RID: 129894
		[Nullable(2)]
		private UCurveFloat LaunchSpeedFadeCurveInternal;

		// Token: 0x0401FB67 RID: 129895
		private double NextResetSeatTransTime;

		// Token: 0x0401FB68 RID: 129896
		protected float DitherNpcRadius = 20f;

		// Token: 0x0401FB69 RID: 129897
		[Nullable(2)]
		protected UCurveFloat DitherDepthCurve;

		// Token: 0x0401FB6A RID: 129898
		protected float DitherCapsuleHalfHeight;

		// Token: 0x0401FB6B RID: 129899
		protected float DitherCapsuleRadius;

		// Token: 0x0401FB6C RID: 129900
		protected Transform DitherCapsuleRelativeTrans = Transform.Create();

		// Token: 0x0401FB6D RID: 129901
		protected global::Vector CapsulePointA = global::Vector.Create();

		// Token: 0x0401FB6E RID: 129902
		protected global::Vector CapsulePointB = global::Vector.Create();

		// Token: 0x0401FB6F RID: 129903
		protected float DitherRemoveDistSquared = 250000f;

		// Token: 0x0401FB70 RID: 129904
		protected HashSet<TsBaseCharacter> PendingDitherActorSet = new HashSet<TsBaseCharacter>();

		// Token: 0x0401FB71 RID: 129905
		public bool EnableDither;

		// Token: 0x0401FB72 RID: 129906
		public static bool DitherDebugMode;
	}
}

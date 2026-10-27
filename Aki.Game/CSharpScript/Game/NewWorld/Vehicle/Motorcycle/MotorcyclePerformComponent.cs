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
	// Token: 0x02007026 RID: 28710
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcyclePerformComponent : VehiclePerformComponent, IStaticVariableResetter
	{
		// Token: 0x06045E2D RID: 286253 RVA: 0x01162C9D File Offset: 0x01160E9D
		static MotorcyclePerformComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcyclePerformComponent.CreateStaticDefaultValue), new Action(MotorcyclePerformComponent.ResetStaticDefaultValue));
		}

		// Token: 0x17009BC3 RID: 39875
		// (get) Token: 0x06045E2E RID: 286254 RVA: 0x01162CCB File Offset: 0x01160ECB
		// (set) Token: 0x06045E2F RID: 286255 RVA: 0x01162CD4 File Offset: 0x01160ED4
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

		// Token: 0x17009BC4 RID: 39876
		// (get) Token: 0x06045E30 RID: 286256 RVA: 0x01162DF0 File Offset: 0x01160FF0
		// (set) Token: 0x06045E31 RID: 286257 RVA: 0x01162DF8 File Offset: 0x01160FF8
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

		// Token: 0x17009BC5 RID: 39877
		// (get) Token: 0x06045E32 RID: 286258 RVA: 0x01162E7C File Offset: 0x0116107C
		// (set) Token: 0x06045E33 RID: 286259 RVA: 0x01162E84 File Offset: 0x01161084
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

		// Token: 0x17009BC6 RID: 39878
		// (get) Token: 0x06045E34 RID: 286260 RVA: 0x01162F25 File Offset: 0x01161125
		public float LaunchSpeedFadeTime
		{
			get
			{
				return this.LaunchSpeedFadeTimeInternal;
			}
		}

		// Token: 0x17009BC7 RID: 39879
		// (get) Token: 0x06045E35 RID: 286261 RVA: 0x01162F2D File Offset: 0x0116112D
		public float LaunchVehicleSpeedAddRatio
		{
			get
			{
				return this.LaunchVehicleSpeedAddRatioInternal;
			}
		}

		// Token: 0x17009BC8 RID: 39880
		// (get) Token: 0x06045E36 RID: 286262 RVA: 0x01162F35 File Offset: 0x01161135
		[Nullable(2)]
		public UCurveFloat LaunchSpeedFadeCurve
		{
			[NullableContext(2)]
			get
			{
				return this.LaunchSpeedFadeCurveInternal;
			}
		}

		// Token: 0x06045E37 RID: 286263 RVA: 0x01162F40 File Offset: 0x01161140
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

		// Token: 0x06045E38 RID: 286264 RVA: 0x011630F4 File Offset: 0x011612F4
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
			return base.OnEnd();
		}

		// Token: 0x06045E39 RID: 286265 RVA: 0x0116311E File Offset: 0x0116131E
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

		// Token: 0x06045E3A RID: 286266 RVA: 0x0116313C File Offset: 0x0116133C
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

		// Token: 0x06045E3B RID: 286267 RVA: 0x0116324C File Offset: 0x0116144C
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

		// Token: 0x06045E3C RID: 286268 RVA: 0x01163358 File Offset: 0x01161558
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

		// Token: 0x06045E3D RID: 286269 RVA: 0x01163423 File Offset: 0x01161623
		protected override void EnterVehiclePerform(VehiclePassengerInfo info)
		{
			base.EnterVehiclePerform(info);
			this.RefreshSummonedEntity(info, true);
			this.SetDitherEnable(info, true);
		}

		// Token: 0x06045E3E RID: 286270 RVA: 0x0116343C File Offset: 0x0116163C
		protected override void LeaveVehiclePerform(VehiclePassengerInfo info)
		{
			base.LeaveVehiclePerform(info);
			this.SetDitherEnable(info, false);
			this.RefreshSummonedEntity(info, false);
		}

		// Token: 0x06045E3F RID: 286271 RVA: 0x01163458 File Offset: 0x01161658
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

		// Token: 0x06045E40 RID: 286272 RVA: 0x01163500 File Offset: 0x01161700
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

		// Token: 0x06045E41 RID: 286273 RVA: 0x0116377C File Offset: 0x0116197C
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

		// Token: 0x06045E42 RID: 286274 RVA: 0x011637D0 File Offset: 0x011619D0
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

		// Token: 0x06045E43 RID: 286275 RVA: 0x01163950 File Offset: 0x01161B50
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

		// Token: 0x06045E44 RID: 286276 RVA: 0x011639AC File Offset: 0x01161BAC
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

		// Token: 0x06045E45 RID: 286277 RVA: 0x01163A48 File Offset: 0x01161C48
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

		// Token: 0x06045E46 RID: 286278 RVA: 0x01163C08 File Offset: 0x01161E08
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

		// Token: 0x06045E47 RID: 286279 RVA: 0x01163CF4 File Offset: 0x01161EF4
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

		// Token: 0x06045E48 RID: 286280 RVA: 0x01163EC0 File Offset: 0x011620C0
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

		// Token: 0x06045E49 RID: 286281 RVA: 0x01163F44 File Offset: 0x01162144
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

		// Token: 0x06045E4A RID: 286282 RVA: 0x01163FD4 File Offset: 0x011621D4
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

		// Token: 0x06045E4B RID: 286283 RVA: 0x011640BC File Offset: 0x011622BC
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

		// Token: 0x06045E4C RID: 286284 RVA: 0x011641DC File Offset: 0x011623DC
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

		// Token: 0x06045E4D RID: 286285 RVA: 0x01164340 File Offset: 0x01162540
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

		// Token: 0x06045E4E RID: 286286 RVA: 0x01164508 File Offset: 0x01162708
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

		// Token: 0x06045E4F RID: 286287 RVA: 0x0116461E File Offset: 0x0116281E
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

		// Token: 0x06045E50 RID: 286288 RVA: 0x01164648 File Offset: 0x01162848
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

		// Token: 0x06045E51 RID: 286289 RVA: 0x011646A0 File Offset: 0x011628A0
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

		// Token: 0x06045E52 RID: 286290 RVA: 0x011646FC File Offset: 0x011628FC
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

		// Token: 0x06045E53 RID: 286291 RVA: 0x01164761 File Offset: 0x01162961
		public static void CreateStaticDefaultValue()
		{
			MotorcyclePerformComponent.DitherDebugMode = false;
		}

		// Token: 0x06045E54 RID: 286292 RVA: 0x01164769 File Offset: 0x01162969
		public static void ResetStaticDefaultValue()
		{
			MotorcyclePerformComponent.DitherDebugMode = false;
		}

		// Token: 0x06045E55 RID: 286293 RVA: 0x01164774 File Offset: 0x01162974
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcyclePerformComponent motorcyclePerformComponent = (MotorcyclePerformComponent)componentTemplate;
			if (base.CanResetComponentProperty("BuffComp"))
			{
				if (motorcyclePerformComponent.BuffComp == null)
				{
					this.BuffComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleBuffComponent>(this.BuffComp), "BuffComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SetNoDriverFrame"))
			{
				this.SetNoDriverFrame = motorcyclePerformComponent.SetNoDriverFrame;
			}
			if (base.CanResetComponentProperty("DrivingBuffs") && motorcyclePerformComponent.DrivingBuffs != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<long>>(this.DrivingBuffs), "DrivingBuffs"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DrivingBuffActivatingInternal"))
			{
				this.DrivingBuffActivatingInternal = motorcyclePerformComponent.DrivingBuffActivatingInternal;
			}
			if (base.CanResetComponentProperty("HitBuffMap") && motorcyclePerformComponent.HitBuffMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EMotorPart, long>>(this.HitBuffMap), "HitBuffMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DayTimeBuffs") && motorcyclePerformComponent.DayTimeBuffs != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ValueTuple<float, long>>>(this.DayTimeBuffs), "DayTimeBuffs"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("OverlapSmallObjectEffectBuff"))
			{
				this.OverlapSmallObjectEffectBuff = motorcyclePerformComponent.OverlapSmallObjectEffectBuff;
			}
			if (base.CanResetComponentProperty("DetectedSmallItemComponents"))
			{
				if (motorcyclePerformComponent.DetectedSmallItemComponents == null)
				{
					this.DetectedSmallItemComponents = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UStaticMeshComponent>(this.DetectedSmallItemComponents), "DetectedSmallItemComponents"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PendingSmallItemComponents"))
			{
				if (motorcyclePerformComponent.PendingSmallItemComponents == null)
				{
					this.PendingSmallItemComponents = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UStaticMeshComponent>(this.PendingSmallItemComponents), "PendingSmallItemComponents"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SmallItemTraceElement"))
			{
				if (motorcyclePerformComponent.SmallItemTraceElement == null)
				{
					this.SmallItemTraceElement = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceCapsuleElement>(this.SmallItemTraceElement), "SmallItemTraceElement"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NextSmallItemTraceTime"))
			{
				this.NextSmallItemTraceTime = motorcyclePerformComponent.NextSmallItemTraceTime;
			}
			if (base.CanResetComponentProperty("HourInternal"))
			{
				this.HourInternal = motorcyclePerformComponent.HourInternal;
			}
			if (base.CanResetComponentProperty("CurrentHourEffectInternal"))
			{
				this.CurrentHourEffectInternal = motorcyclePerformComponent.CurrentHourEffectInternal;
			}
			if (base.CanResetComponentProperty("LaunchSpeedFadeTimeInternal"))
			{
				this.LaunchSpeedFadeTimeInternal = motorcyclePerformComponent.LaunchSpeedFadeTimeInternal;
			}
			if (base.CanResetComponentProperty("LaunchVehicleSpeedAddRatioInternal"))
			{
				this.LaunchVehicleSpeedAddRatioInternal = motorcyclePerformComponent.LaunchVehicleSpeedAddRatioInternal;
			}
			if (base.CanResetComponentProperty("LaunchSpeedFadeCurveInternal"))
			{
				if (motorcyclePerformComponent.LaunchSpeedFadeCurveInternal == null)
				{
					this.LaunchSpeedFadeCurveInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCurveFloat>(this.LaunchSpeedFadeCurveInternal), "LaunchSpeedFadeCurveInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NextResetSeatTransTime"))
			{
				this.NextResetSeatTransTime = motorcyclePerformComponent.NextResetSeatTransTime;
			}
			if (base.CanResetComponentProperty("DitherNpcRadius"))
			{
				this.DitherNpcRadius = motorcyclePerformComponent.DitherNpcRadius;
			}
			if (base.CanResetComponentProperty("DitherDepthCurve"))
			{
				if (motorcyclePerformComponent.DitherDepthCurve == null)
				{
					this.DitherDepthCurve = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCurveFloat>(this.DitherDepthCurve), "DitherDepthCurve"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DitherCapsuleHalfHeight"))
			{
				this.DitherCapsuleHalfHeight = motorcyclePerformComponent.DitherCapsuleHalfHeight;
			}
			if (base.CanResetComponentProperty("DitherCapsuleRadius"))
			{
				this.DitherCapsuleRadius = motorcyclePerformComponent.DitherCapsuleRadius;
			}
			if (base.CanResetComponentProperty("DitherCapsuleRelativeTrans"))
			{
				if (motorcyclePerformComponent.DitherCapsuleRelativeTrans == null)
				{
					this.DitherCapsuleRelativeTrans = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Transform>(this.DitherCapsuleRelativeTrans), "DitherCapsuleRelativeTrans"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CapsulePointA"))
			{
				if (motorcyclePerformComponent.CapsulePointA == null)
				{
					this.CapsulePointA = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CapsulePointA), "CapsulePointA"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CapsulePointB"))
			{
				if (motorcyclePerformComponent.CapsulePointB == null)
				{
					this.CapsulePointB = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CapsulePointB), "CapsulePointB"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DitherRemoveDistSquared"))
			{
				this.DitherRemoveDistSquared = motorcyclePerformComponent.DitherRemoveDistSquared;
			}
			if (base.CanResetComponentProperty("PendingDitherActorSet"))
			{
				if (motorcyclePerformComponent.PendingDitherActorSet == null)
				{
					this.PendingDitherActorSet = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.PendingDitherActorSet), "PendingDitherActorSet"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EnableDither"))
			{
				this.EnableDither = motorcyclePerformComponent.EnableDither;
			}
			return true;
		}

		// Token: 0x0402489B RID: 149659
		private const float MIN_NPC_DITHER_RADIUS = 20f;

		// Token: 0x0402489C RID: 149660
		private const float MAX_NPC_DITHER_RADIUS = 200f;

		// Token: 0x0402489D RID: 149661
		private const float REMOVE_DITHER_ENTITY_DIST_SQUARED = 250000f;

		// Token: 0x0402489E RID: 149662
		private static readonly FName SmallItemTag = new FName("SMALL_ITEM");

		// Token: 0x0402489F RID: 149663
		private const double SMALL_ITEM_TRACE_INTERVAL = 500.0;

		// Token: 0x040248A0 RID: 149664
		private const float SMALL_ITEM_TRACE_SPEED_THRESHOLD = 1000f;

		// Token: 0x040248A1 RID: 149665
		[Nullable(2)]
		private VehicleBuffComponent BuffComp;

		// Token: 0x040248A2 RID: 149666
		protected int SetNoDriverFrame;

		// Token: 0x040248A3 RID: 149667
		private readonly List<long> DrivingBuffs = new List<long>();

		// Token: 0x040248A4 RID: 149668
		private bool DrivingBuffActivatingInternal;

		// Token: 0x040248A5 RID: 149669
		private readonly Dictionary<EMotorPart, long> HitBuffMap = new Dictionary<EMotorPart, long>();

		// Token: 0x040248A6 RID: 149670
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<float, long>> DayTimeBuffs = new List<ValueTuple<float, long>>();

		// Token: 0x040248A7 RID: 149671
		private long OverlapSmallObjectEffectBuff;

		// Token: 0x040248A8 RID: 149672
		private HashSet<UStaticMeshComponent> DetectedSmallItemComponents = new HashSet<UStaticMeshComponent>();

		// Token: 0x040248A9 RID: 149673
		private HashSet<UStaticMeshComponent> PendingSmallItemComponents = new HashSet<UStaticMeshComponent>();

		// Token: 0x040248AA RID: 149674
		[Nullable(2)]
		private UTraceCapsuleElement SmallItemTraceElement;

		// Token: 0x040248AB RID: 149675
		private double NextSmallItemTraceTime;

		// Token: 0x040248AC RID: 149676
		private int HourInternal = -1;

		// Token: 0x040248AD RID: 149677
		private long CurrentHourEffectInternal;

		// Token: 0x040248AE RID: 149678
		private float LaunchSpeedFadeTimeInternal;

		// Token: 0x040248AF RID: 149679
		private float LaunchVehicleSpeedAddRatioInternal = 1f;

		// Token: 0x040248B0 RID: 149680
		[Nullable(2)]
		private UCurveFloat LaunchSpeedFadeCurveInternal;

		// Token: 0x040248B1 RID: 149681
		private double NextResetSeatTransTime;

		// Token: 0x040248B2 RID: 149682
		protected float DitherNpcRadius = 20f;

		// Token: 0x040248B3 RID: 149683
		[Nullable(2)]
		protected UCurveFloat DitherDepthCurve;

		// Token: 0x040248B4 RID: 149684
		protected float DitherCapsuleHalfHeight;

		// Token: 0x040248B5 RID: 149685
		protected float DitherCapsuleRadius;

		// Token: 0x040248B6 RID: 149686
		protected Transform DitherCapsuleRelativeTrans = Transform.Create();

		// Token: 0x040248B7 RID: 149687
		protected global::Vector CapsulePointA = global::Vector.Create();

		// Token: 0x040248B8 RID: 149688
		protected global::Vector CapsulePointB = global::Vector.Create();

		// Token: 0x040248B9 RID: 149689
		protected float DitherRemoveDistSquared = 250000f;

		// Token: 0x040248BA RID: 149690
		protected HashSet<TsBaseCharacter> PendingDitherActorSet = new HashSet<TsBaseCharacter>();

		// Token: 0x040248BB RID: 149691
		public bool EnableDither;

		// Token: 0x040248BC RID: 149692
		public static bool DitherDebugMode;
	}
}

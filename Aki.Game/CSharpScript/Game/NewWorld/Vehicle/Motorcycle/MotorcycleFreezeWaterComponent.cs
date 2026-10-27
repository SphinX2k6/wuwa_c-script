using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Data.Fight.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Common.Capability;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using CSharpScript.Game.Utils.Priority;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007024 RID: 28708
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleFreezeWaterComponent : EntityComponent
	{
		// Token: 0x17009BC0 RID: 39872
		// (get) Token: 0x06045E03 RID: 286211 RVA: 0x01160D48 File Offset: 0x0115EF48
		// (set) Token: 0x06045E04 RID: 286212 RVA: 0x01160D50 File Offset: 0x0115EF50
		private bool InNavWaterArea
		{
			get
			{
				return this.InNavWaterAreaInternal;
			}
			set
			{
				if (this.InNavWaterAreaInternal == value)
				{
					return;
				}
				this.InNavWaterAreaInternal = value;
				if (!this.IsFunctionOpen())
				{
					return;
				}
				if (!value)
				{
					if (this.OriginMotorcycleToKuroWaterCollisionResponse != null)
					{
						ECollisionResponse? originMotorcycleToKuroWaterCollisionResponse = this.OriginMotorcycleToKuroWaterCollisionResponse;
						ECollisionResponse ecollisionResponse = ECollisionResponse.ECR_Ignore;
						if (!(originMotorcycleToKuroWaterCollisionResponse.GetValueOrDefault() == ecollisionResponse & originMotorcycleToKuroWaterCollisionResponse != null))
						{
							MotorcycleMoveComponent moveComp = this.MoveComp;
							if (moveComp != null)
							{
								UKuroVehicleMovementComponent vehicleMovement = moveComp.VehicleMovement;
								if (vehicleMovement != null)
								{
									UPrimitiveComponent updatedPrimitive = vehicleMovement.UpdatedPrimitive;
									if (updatedPrimitive != null)
									{
										updatedPrimitive.SetCollisionResponseToChannel(KuroCollisionChannel.KuroWater, this.OriginMotorcycleToKuroWaterCollisionResponse.Value);
									}
								}
							}
							MotorcycleMoveComponent moveComp2 = this.MoveComp;
							if (moveComp2 != null)
							{
								UKuroVehicleMovementComponent vehicleMovement2 = moveComp2.VehicleMovement;
								if (vehicleMovement2 != null)
								{
									vehicleMovement2.InitVehicleShapes();
								}
							}
							this.OriginMotorcycleToKuroWaterCollisionResponse = null;
						}
					}
					return;
				}
				MotorcycleMoveComponent moveComp3 = this.MoveComp;
				TEnumAsByte<ECollisionResponse>? tenumAsByte;
				if (moveComp3 == null)
				{
					tenumAsByte = null;
				}
				else
				{
					UKuroVehicleMovementComponent vehicleMovement3 = moveComp3.VehicleMovement;
					if (vehicleMovement3 == null)
					{
						tenumAsByte = null;
					}
					else
					{
						UPrimitiveComponent updatedPrimitive2 = vehicleMovement3.UpdatedPrimitive;
						tenumAsByte = ((updatedPrimitive2 != null) ? new TEnumAsByte<ECollisionResponse>?(updatedPrimitive2.GetCollisionResponseToChannel(KuroCollisionChannel.KuroWater)) : null);
					}
				}
				TEnumAsByte<ECollisionResponse>? tenumAsByte2 = tenumAsByte;
				this.OriginMotorcycleToKuroWaterCollisionResponse = ((tenumAsByte2 != null) ? new ECollisionResponse?(tenumAsByte2.GetValueOrDefault()) : null);
				if (this.OriginMotorcycleToKuroWaterCollisionResponse.GetValueOrDefault() == ECollisionResponse.ECR_Block)
				{
					this.OriginMotorcycleToKuroWaterCollisionResponse = null;
					return;
				}
				MotorcycleMoveComponent moveComp4 = this.MoveComp;
				if (moveComp4 != null)
				{
					UKuroVehicleMovementComponent vehicleMovement4 = moveComp4.VehicleMovement;
					if (vehicleMovement4 != null)
					{
						UPrimitiveComponent updatedPrimitive3 = vehicleMovement4.UpdatedPrimitive;
						if (updatedPrimitive3 != null)
						{
							updatedPrimitive3.SetCollisionResponseToChannel(KuroCollisionChannel.KuroWater, ECollisionResponse.ECR_Block);
						}
					}
				}
				MotorcycleMoveComponent moveComp5 = this.MoveComp;
				if (moveComp5 == null)
				{
					return;
				}
				UKuroVehicleMovementComponent vehicleMovement5 = moveComp5.VehicleMovement;
				if (vehicleMovement5 == null)
				{
					return;
				}
				vehicleMovement5.InitVehicleShapes();
			}
		}

		// Token: 0x17009BC1 RID: 39873
		// (get) Token: 0x06045E05 RID: 286213 RVA: 0x01160EE1 File Offset: 0x0115F0E1
		// (set) Token: 0x06045E06 RID: 286214 RVA: 0x01160EEC File Offset: 0x0115F0EC
		private bool DetectedWater
		{
			get
			{
				return this.DetectedWaterInternal;
			}
			set
			{
				if (this.DetectedWaterInternal == value)
				{
					return;
				}
				this.DetectedWaterInternal = value;
				if (!this.IsFunctionOpen())
				{
					return;
				}
				EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantMotorcycle, 1);
				if (summonedEntity != null && summonedEntity.Valid)
				{
					WorldEntity entity = summonedEntity.Entity;
					if (entity != null && entity.Valid)
					{
						FollowShooterComponent component = summonedEntity.Entity.GetComponent<FollowShooterComponent>();
						if (component != null)
						{
							component.SetEnable(value, BPEEnableFollowShooter.AutoDetectedFreezeWater, "");
						}
					}
				}
				if (value)
				{
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp == null || !tagComp.HasTag(MotorcycleFreezeWaterComponent.freezeWaterEffectTag))
					{
						BaseTagComponent tagComp2 = this.TagComp;
						if (tagComp2 != null)
						{
							tagComp2.AddTag(new int?(MotorcycleFreezeWaterComponent.freezeWaterEffectTag));
						}
					}
					if (FormationDataController.Instance.HasPlayerTag(CreatureModel.Instance.GetPlayerId(), MotorcycleFreezeWaterComponent.freezeRunningWaterTag, false))
					{
						CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager = this.FreezeWaterPriorityManager;
						if (freezeWaterPriorityManager != null)
						{
							freezeWaterPriorityManager.TryEnter(MotorcycleFreezeWaterComponent.EFreezeWaterType.SetPositionByMaterialParameterCollection, "DetectedWater");
						}
					}
					else
					{
						CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager2 = this.FreezeWaterPriorityManager;
						if (freezeWaterPriorityManager2 != null)
						{
							freezeWaterPriorityManager2.TryEnter(MotorcycleFreezeWaterComponent.EFreezeWaterType.MovementTrailCollision, "DetectedWater");
						}
					}
					Action<bool> freezeWaterEnterExitHandler = this.FreezeWaterEnterExitHandler;
					if (freezeWaterEnterExitHandler == null)
					{
						return;
					}
					freezeWaterEnterExitHandler(value);
					return;
				}
				else
				{
					BaseTagComponent tagComp3 = this.TagComp;
					if (tagComp3 != null)
					{
						tagComp3.RemoveTag(new int?(MotorcycleFreezeWaterComponent.freezeWaterEffectTag));
					}
					CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager3 = this.FreezeWaterPriorityManager;
					if (freezeWaterPriorityManager3 == null)
					{
						return;
					}
					freezeWaterPriorityManager3.TryExitAll("Not DetectedWater");
					return;
				}
			}
		}

		// Token: 0x17009BC2 RID: 39874
		// (get) Token: 0x06045E07 RID: 286215 RVA: 0x0116102C File Offset: 0x0115F22C
		public new static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CreatureDataComponent),
					typeof(VehicleActorComponent),
					typeof(BaseTagComponent),
					typeof(MotorcycleMoveComponent),
					typeof(MotorcycleWaterComponent)
				};
			}
		}

		// Token: 0x06045E08 RID: 286216 RVA: 0x01161080 File Offset: 0x0115F280
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.KuroTrailCollisionAssetPath = (ConfigCommonParamById.GetStringConfig("KuroTrailCollisionAsset") ?? "");
			IEnumerable<string> enumerable = ConfigCommonParamById.GetStringArrayConfig("FreezeWaterEffectComponentNames") ?? Array.Empty<string>();
			this.FreezeWaterEffectTagToContexts.Clear();
			foreach (string text in enumerable)
			{
				foreach (KeyValuePair<string, string> keyValuePair in StringUtils.ParseCSVStringToMap(text))
				{
					string key = keyValuePair.Key;
					string value = keyValuePair.Value;
					if (StringUtils.IsBlank(key) || StringUtils.IsBlank(value))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Motor;
						ELogAuthor author = ELogAuthor.XDW;
						string message = "FreezeWaterEffectComponentNames 配置错误, 格式为 ComponentName:SocketName";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Content", text);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						foreach (MotorcycleFreezeWaterComponent.IEffectConfig effectConfig in MotorcycleFreezeWaterComponent.FreezeWaterEffectConfigs)
						{
							if (effectConfig.EffectPath == null)
							{
								effectConfig.EffectPath = (ConfigCommonParamById.GetStringConfig(effectConfig.Config) ?? "");
							}
							if (!this.FreezeWaterEffectTagToContexts.ContainsKey(effectConfig.TagId))
							{
								this.FreezeWaterEffectTagToContexts[effectConfig.TagId] = new List<MotorcycleFreezeWaterComponent.IEffectContext>();
							}
							this.FreezeWaterEffectTagToContexts[effectConfig.TagId].Add(new MotorcycleFreezeWaterComponent.EffectContextImpl
							{
								AssetPath = effectConfig.EffectPath,
								ComponentName = key,
								Socket = FNameUtil.GetDynamicFName(value).Value
							});
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06045E09 RID: 286217 RVA: 0x01161268 File Offset: 0x0115F468
		protected override bool OnStart()
		{
			CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
			this.ActorComp = base.Entity.CheckGetComponent<MotorcycleActorComponent>();
			this.TagComp = base.Entity.CheckGetComponent<BaseTagComponent>();
			this.MoveComp = base.Entity.CheckGetComponent<MotorcycleMoveComponent>();
			int num = (creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0;
			this.IsAutonomousProxy = (num == CreatureModel.Instance.GetPlayerId());
			MotorcycleWaterComponent motorcycleWaterComponent = base.Entity.CheckGetComponent<MotorcycleWaterComponent>();
			this.TraceWaterCapability = ((motorcycleWaterComponent != null) ? motorcycleWaterComponent.TraceWaterCapability : null);
			this.TempWheelHitResults = new Dictionary<int, FHitResult>
			{
				{
					0,
					new FHitResult()
				},
				{
					1,
					new FHitResult()
				}
			};
			this.WheelHitResults = new Dictionary<int, FHitResult>
			{
				{
					0,
					null
				},
				{
					1,
					null
				}
			};
			foreach (int value in this.FreezeWaterEffectTagToContexts.Keys)
			{
				BaseTagComponent tagComp = this.TagComp;
				ITagTask tagTask = (tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(value), new BaseTagComponent.TTagSwitchedCallback(this.OnFreezeWaterEffectTagAddOrRemove), null) : null;
				if (tagTask != null)
				{
					this.TagTasks.Add(tagTask);
				}
			}
			this.EffectSystemContext = new EffectContext(new int?(base.Entity.Id), null, false);
			MotorcycleActorComponent actorComp = this.ActorComp;
			this.InteractionComp = FreezeWaterRenderCapability.CheckKuroWaterDetectedInterface((actorComp != null) ? actorComp.Owner : null);
			EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.MotorcycleWaterAreaChange, new Action<bool>(this.OnMotorcycleWaterAreaChange));
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("MotorcycleFreezeWaterComponent ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(base.Entity.Id);
			this.FreezeWaterPriorityManager = new CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType>(defaultInterpolatedStringHandler.ToStringAndClear());
			this.FreezeWaterPriorityManager.Register(MotorcycleFreezeWaterComponent.EFreezeWaterType.MovementTrailCollision, new CustomPriorityConfig<MotorcycleFreezeWaterComponent.EFreezeWaterType>
			{
				Enable = false,
				EnterCallback = new Func<ICustomPriorityCallbackParam, bool>(this.MovementTrailCollisionEnterCallback),
				ExitCallback = new Func<ICustomPriorityCallbackParam, bool>(this.MovementTrailCollisionExitCallback)
			});
			this.FreezeWaterPriorityManager.Register(MotorcycleFreezeWaterComponent.EFreezeWaterType.SetPositionByMaterialParameterCollection, new CustomPriorityConfig<MotorcycleFreezeWaterComponent.EFreezeWaterType>
			{
				Enable = false,
				EnterCallback = new Func<ICustomPriorityCallbackParam, bool>(this.SetPositionByMaterialParameterCollectionEnterCallback),
				ExitCallback = new Func<ICustomPriorityCallbackParam, bool>(this.SetPositionByMaterialParameterCollectionExitCallback)
			});
			return true;
		}

		// Token: 0x06045E0A RID: 286218 RVA: 0x011614FC File Offset: 0x0115F6FC
		protected override bool OnEnd()
		{
			this.FreezeWaterEnterExitHandler = null;
			this.FreezeWaterTickHandler = null;
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.MotorcycleWaterAreaChange, new Action<bool>(this.OnMotorcycleWaterAreaChange));
			this.EffectSystemContext = null;
			foreach (ITagTask tagTask in this.TagTasks)
			{
				tagTask.EndTask();
			}
			this.TagTasks.Clear();
			this.InNavWaterArea = false;
			this.DetectedWater = false;
			this.TraceWaterCapability = null;
			this.MoveComp = null;
			this.TagComp = null;
			this.ActorComp = null;
			this.InteractionComp = null;
			Dictionary<int, FHitResult> tempWheelHitResults = this.TempWheelHitResults;
			if (tempWheelHitResults != null)
			{
				tempWheelHitResults.Clear();
			}
			this.TempWheelHitResults = null;
			Dictionary<int, FHitResult> wheelHitResults = this.WheelHitResults;
			if (wheelHitResults != null)
			{
				wheelHitResults.Clear();
			}
			this.WheelHitResults = null;
			this.ClearFreezeWaterEffect();
			foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
			{
				waterDetectedCapability.Deactivate();
			}
			this.GameCapabilities.Clear();
			CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager = this.FreezeWaterPriorityManager;
			if (freezeWaterPriorityManager != null)
			{
				freezeWaterPriorityManager.TryExitAll("OnEnd");
			}
			CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager2 = this.FreezeWaterPriorityManager;
			if (freezeWaterPriorityManager2 != null)
			{
				freezeWaterPriorityManager2.ClearObject();
			}
			this.FreezeWaterPriorityManager = null;
			return true;
		}

		// Token: 0x06045E0B RID: 286219 RVA: 0x011616B4 File Offset: 0x0115F8B4
		protected override void OnTick(float delta)
		{
			if (!this.IsFunctionOpen())
			{
				return;
			}
			if (!this.InNavWaterArea)
			{
				return;
			}
			MotorcycleActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.Valid)
			{
				TsBaseVehicle vehicleOwner = this.ActorComp.VehicleOwner;
				if (vehicleOwner != null && vehicleOwner.IsValid())
				{
					if (this.TraceWaterCapability == null)
					{
						return;
					}
					bool flag = false;
					TraceWaterResult traceWaterResult = null;
					if (this.IsAutonomousProxy)
					{
						if (this.WheelHitResults == null)
						{
							return;
						}
						foreach (int wheelIndex in this.WheelHitResults.Keys)
						{
							flag = (this.CheckWheelHitResultIsWater(wheelIndex) || flag);
						}
						int num = 0;
						MathUtils.Instance.CommonTempVector.Set(0.0, 0.0, 0.0);
						MathUtils.Instance.CommonTempVector2.Set(0.0, 0.0, 0.0);
						foreach (FHitResult fhitResult in this.WheelHitResults.Values)
						{
							if (!(fhitResult == null))
							{
								num++;
								global::Vector impactPoint = this.TraceWaterCapability.ImpactPoint;
								FVector_NetQuantize impactPoint2 = fhitResult.ImpactPoint;
								impactPoint.FromUeVector(impactPoint2);
								global::Vector impactNormal = this.TraceWaterCapability.ImpactNormal;
								FVector_NetQuantizeNormal impactNormal2 = fhitResult.ImpactNormal;
								impactNormal.FromUeVector(impactNormal2);
								if (SundryModel.Instance.GetModuleDebugLevel("MotorcycleFreezeWaterComponent") >= 1)
								{
									this.TmpVector.Set((double)fhitResult.ImpactPoint.X, (double)fhitResult.ImpactPoint.Y, (double)fhitResult.ImpactPoint.Z);
									this.TmpVector.MultiplyEqual(101.0);
									UObject vehicleOwner2 = this.ActorComp.VehicleOwner;
									impactPoint2 = fhitResult.ImpactPoint;
									FVector lineStart = impactPoint2;
									FVectorDouble fvectorDouble = this.TmpVector.ToUeVector(false);
									UKismetSystemLibrary.DrawDebugArrow(vehicleOwner2, lineStart, fvectorDouble, 100f, ColorUtils.LinearGreen, 0f, 0f);
								}
								MathUtils.Instance.CommonTempVector.AdditionEqual(this.TraceWaterCapability.ImpactPoint);
								MathUtils.Instance.CommonTempVector2.AdditionEqual(this.TraceWaterCapability.ImpactNormal);
							}
						}
						if (num > 0)
						{
							MathUtils.Instance.CommonTempVector.DivisionEqual((double)num);
							MathUtils.Instance.CommonTempVector2.DivisionEqual((double)num);
							FIntVector worldOriginLocation = UGameplayStatics.GetWorldOriginLocation(this.ActorComp.VehicleOwner);
							global::Vector inB = global::Vector.Create((double)worldOriginLocation.X, (double)worldOriginLocation.Y, (double)worldOriginLocation.Z);
							traceWaterResult = new TraceWaterResult
							{
								FoundWater = true,
								MinWaterHeight = (float)MathUtils.Instance.CommonTempVector.Z,
								ImpactPoint = MathUtils.Instance.CommonTempVector.Addition(inB, global::Vector.Create()),
								ImpactNormal = global::Vector.Create(MathUtils.Instance.CommonTempVector2)
							};
						}
					}
					else
					{
						traceWaterResult = this.TraceWaterCapability.TraceWater(100.0, -100.0);
						if (traceWaterResult.FoundWater && !this.TraceWaterCapability.CeilingCheck((double)traceWaterResult.MinWaterHeight))
						{
							flag = true;
						}
					}
					this.DetectedWater = flag;
					if (this.DetectedWater && ((traceWaterResult != null) ? traceWaterResult.ImpactNormal : null) != null && ((traceWaterResult != null) ? traceWaterResult.ImpactPoint : null) != null)
					{
						Action<float, global::Vector, global::Vector> freezeWaterTickHandler = this.FreezeWaterTickHandler;
						if (freezeWaterTickHandler == null)
						{
							return;
						}
						freezeWaterTickHandler(delta, traceWaterResult.ImpactPoint, traceWaterResult.ImpactNormal);
					}
					return;
				}
			}
		}

		// Token: 0x06045E0C RID: 286220 RVA: 0x01161A88 File Offset: 0x0115FC88
		private void MovementTrailCollisionHandler(bool value)
		{
			MotorcycleActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.Valid)
			{
				TsBaseVehicle vehicleOwner = this.ActorComp.VehicleOwner;
				if (vehicleOwner != null && vehicleOwner.IsValid())
				{
					UKuroEnviInteractionComponent interactionComp = this.InteractionComp;
					if (interactionComp == null || !interactionComp.IsValid())
					{
						return;
					}
					if (value)
					{
						this.CreateFreezeWaterDependency();
						foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
						{
							waterDetectedCapability.OnWaterDetectedStart();
						}
						FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedStart(this.InteractionComp);
						return;
					}
					foreach (WaterDetectedCapability waterDetectedCapability2 in this.GameCapabilities)
					{
						waterDetectedCapability2.OnWaterDetectedEnd();
					}
					FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedEnd(this.InteractionComp);
					return;
				}
			}
		}

		// Token: 0x06045E0D RID: 286221 RVA: 0x01161B84 File Offset: 0x0115FD84
		private void MovementTrailCollisionTickHandler(float delta, global::Vector impactPoint, global::Vector impactNormal)
		{
			UKuroEnviInteractionComponent interactionComp = this.InteractionComp;
			if (interactionComp == null || !interactionComp.IsValid())
			{
				return;
			}
			foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
			{
				waterDetectedCapability.OnWaterDetectedTick(delta, impactPoint, impactNormal);
			}
			UObject interactionComp2 = this.InteractionComp;
			float waterSurface = (float)impactPoint.Z;
			FVectorDouble fvectorDouble = impactPoint.ToUeVector(false);
			FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedTick(interactionComp2, delta, waterSurface, fvectorDouble);
		}

		// Token: 0x06045E0E RID: 286222 RVA: 0x01161C14 File Offset: 0x0115FE14
		private void SetPositionByMaterialParameterCollectionHandler(bool value)
		{
			if (!value)
			{
				MotorcycleActorComponent actorComp = this.ActorComp;
				bool flag;
				if (actorComp == null)
				{
					flag = true;
				}
				else
				{
					TsBaseVehicle vehicleOwner = actorComp.VehicleOwner;
					flag = !((vehicleOwner != null) ? new bool?(vehicleOwner.IsValid()) : null).GetValueOrDefault();
				}
				if (flag)
				{
					return;
				}
				if (!this.IsAutonomousProxy)
				{
					return;
				}
				UKismetMaterialLibrary.SetVectorParameterValue(this.ActorComp.VehicleOwner, RenderDataManager.Instance.GetGlobalShaderParameters(), MovementTrailCollisionCapability.iceRiderPositionName, ColorUtils.LinearClear);
			}
		}

		// Token: 0x06045E0F RID: 286223 RVA: 0x01161C8C File Offset: 0x0115FE8C
		private void SetPositionByMaterialParameterCollectionTickHandler(float delta, global::Vector impactPoint, global::Vector impactNormal)
		{
			MotorcycleActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				TsBaseVehicle vehicleOwner = actorComp.VehicleOwner;
				flag = !((vehicleOwner != null) ? new bool?(vehicleOwner.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			FVector fvector = this.ActorComp.VehicleOwner.K2_GetActorLocation();
			UObject vehicleOwner2 = this.ActorComp.VehicleOwner;
			UMaterialParameterCollection globalShaderParameters = RenderDataManager.Instance.GetGlobalShaderParameters();
			FName iceRiderPositionName = MovementTrailCollisionCapability.iceRiderPositionName;
			FLinearColor flinearColor = new FLinearColor(fvector.X, fvector.Y, fvector.Z, 2f);
			UKismetMaterialLibrary.SetVectorParameterValue(vehicleOwner2, globalShaderParameters, iceRiderPositionName, flinearColor);
		}

		// Token: 0x06045E10 RID: 286224 RVA: 0x01161D2A File Offset: 0x0115FF2A
		public void SetIsFunctionOpenOverride(bool? value)
		{
			this.IsFunctionOpenOverride = value;
		}

		// Token: 0x06045E11 RID: 286225 RVA: 0x01161D33 File Offset: 0x0115FF33
		private bool IsFunctionOpen()
		{
			if (this.IsFunctionOpenOverride != null)
			{
				return this.IsFunctionOpenOverride.Value;
			}
			return FunctionModel.Instance.IsOpen(EFunctionType.MotorFreezeWater);
		}

		// Token: 0x06045E12 RID: 286226 RVA: 0x01161D60 File Offset: 0x0115FF60
		private bool CheckWheelHitResultIsWater(int wheelIndex)
		{
			this.WheelHitResults[wheelIndex] = null;
			FHitResult fhitResult;
			if (this.TempWheelHitResults == null || !this.TempWheelHitResults.TryGetValue(wheelIndex, out fhitResult))
			{
				return false;
			}
			MotorcycleMoveComponent moveComp = this.MoveComp;
			bool flag;
			if (moveComp == null)
			{
				flag = true;
			}
			else
			{
				UKuroVehicleMovementComponent vehicleMovement = moveComp.VehicleMovement;
				flag = !((vehicleMovement != null) ? new bool?(vehicleMovement.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return false;
			}
			bool flag2;
			if (wheelIndex != 0)
			{
				if (wheelIndex != 1)
				{
					return false;
				}
				flag2 = this.MoveComp.VehicleMovement.GetBackMotorHitResult(ref fhitResult);
			}
			else
			{
				flag2 = this.MoveComp.VehicleMovement.GetFrontMotorHitResult(ref fhitResult);
			}
			if (!flag2)
			{
				return false;
			}
			FHitResult fhitResult2 = fhitResult;
			if (!fhitResult2.bBlockingHit)
			{
				return false;
			}
			if (!fhitResult2.Component.IsValid(false, false))
			{
				return false;
			}
			if (UKuroCollisionLibrary.GetCollisionProfileName(fhitResult2.Component, fhitResult2.Item) != MotorcycleTraceWaterCapability.waterCollisionProfileName)
			{
				return false;
			}
			this.WheelHitResults[wheelIndex] = fhitResult2;
			return true;
		}

		// Token: 0x06045E13 RID: 286227 RVA: 0x01161E5D File Offset: 0x0116005D
		private void OnFreezeWaterEffectTagAddOrRemove(int tagId, bool tagExist)
		{
			if (!this.IsFunctionOpen())
			{
				return;
			}
			if (tagExist)
			{
				this.StartSummonedEntityFreezeWaterEffect(tagId);
				return;
			}
			this.EndSummonedEntityFreezeWaterEffect(tagId);
		}

		// Token: 0x06045E14 RID: 286228 RVA: 0x01161E7C File Offset: 0x0116007C
		private void StartSummonedEntityFreezeWaterEffect(int tagId)
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(base.Entity, ESummonType.ConcomitantMotorcycle, 1);
			if (summonedEntity != null && summonedEntity.Valid)
			{
				WorldEntity entity = summonedEntity.Entity;
				if (entity != null && entity.Valid)
				{
					CharacterActorComponent characterActorComponent = summonedEntity.Entity.CheckGetComponent<CharacterActorComponent>();
					if (characterActorComponent == null || !characterActorComponent.IsAutonomousProxy)
					{
						return;
					}
					BaseActorComponent component = summonedEntity.Entity.GetComponent<BaseActorComponent>();
					bool flag;
					if (component == null)
					{
						flag = true;
					}
					else
					{
						AActor owner = component.Owner;
						flag = !((owner != null) ? new bool?(owner.IsValid()) : null).GetValueOrDefault();
					}
					if (flag)
					{
						return;
					}
					TArray<UActorComponent> tarray = component.Owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
					Dictionary<string, USkeletalMeshComponent> dictionary = new Dictionary<string, USkeletalMeshComponent>();
					for (int i = 0; i < tarray.Num(); i++)
					{
						UActorComponent uactorComponent = tarray.Get(i);
						dictionary[uactorComponent.GetName()] = (uactorComponent as USkeletalMeshComponent);
					}
					List<MotorcycleFreezeWaterComponent.IEffectContext> valueOrDefault = this.FreezeWaterEffectTagToContexts.GetValueOrDefault(tagId);
					if (valueOrDefault == null || valueOrDefault.Count == 0)
					{
						return;
					}
					foreach (MotorcycleFreezeWaterComponent.IEffectContext effectContext in valueOrDefault)
					{
						USkeletalMeshComponent uskeletalMeshComponent;
						dictionary.TryGetValue(effectContext.ComponentName, out uskeletalMeshComponent);
						if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid())
						{
							EffectSystem instance = EffectSystem.Instance;
							UObject owner2 = component.Owner;
							FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
							int num = instance.SpawnEffect(owner2, ftransformDouble, effectContext.AssetPath, "[OnMotorcycleWaterDetectedStart]", this.EffectSystemContext, EEffectType.Fight, null, null, null, false, false);
							effectContext.EffectHandleId = new int?(num);
							EffectSystem.Instance.GetEffectActor(num).K2_AttachToComponent(uskeletalMeshComponent, new FName?(effectContext.Socket), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
						}
					}
					return;
				}
			}
		}

		// Token: 0x06045E15 RID: 286229 RVA: 0x01162060 File Offset: 0x01160260
		private void EndSummonedEntityFreezeWaterEffect(int tagId)
		{
			List<MotorcycleFreezeWaterComponent.IEffectContext> list;
			this.FreezeWaterEffectTagToContexts.TryGetValue(tagId, out list);
			if (list == null || list.Count == 0)
			{
				return;
			}
			foreach (MotorcycleFreezeWaterComponent.IEffectContext effectContext in list)
			{
				int? effectHandleId = effectContext.EffectHandleId;
				if (effectHandleId != null)
				{
					EffectSystem instance = EffectSystem.Instance;
					int value = effectHandleId.Value;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
					defaultInterpolatedStringHandler.AppendLiteral("EndSummonedEntityFreezeWaterEffect:");
					defaultInterpolatedStringHandler.AppendFormatted<int>(tagId);
					instance.StopEffectById(value, defaultInterpolatedStringHandler.ToStringAndClear(), false, null);
					effectContext.EffectHandleId = null;
				}
			}
		}

		// Token: 0x06045E16 RID: 286230 RVA: 0x01162124 File Offset: 0x01160324
		protected UniTask CreateFreezeWaterDependencyByTaskGraph()
		{
			MotorcycleFreezeWaterComponent.<CreateFreezeWaterDependencyByTaskGraph>d__59 <CreateFreezeWaterDependencyByTaskGraph>d__;
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>4__this = this;
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>1__state = -1;
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>t__builder.Start<MotorcycleFreezeWaterComponent.<CreateFreezeWaterDependencyByTaskGraph>d__59>(ref <CreateFreezeWaterDependencyByTaskGraph>d__);
			return <CreateFreezeWaterDependencyByTaskGraph>d__.<>t__builder.Task;
		}

		// Token: 0x06045E17 RID: 286231 RVA: 0x01162168 File Offset: 0x01160368
		private static UniTask LoadBlueprintTypeAsync()
		{
			MotorcycleFreezeWaterComponent.<LoadBlueprintTypeAsync>d__60 <LoadBlueprintTypeAsync>d__;
			<LoadBlueprintTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBlueprintTypeAsync>d__.<>1__state = -1;
			<LoadBlueprintTypeAsync>d__.<>t__builder.Start<MotorcycleFreezeWaterComponent.<LoadBlueprintTypeAsync>d__60>(ref <LoadBlueprintTypeAsync>d__);
			return <LoadBlueprintTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045E18 RID: 286232 RVA: 0x011621A4 File Offset: 0x011603A4
		private UniTask LoadKuroTrailCollisionAsset<[Nullable(0)] T>(string path) where T : UKuroTrailCollisionAsset
		{
			MotorcycleFreezeWaterComponent.<LoadKuroTrailCollisionAsset>d__61<T> <LoadKuroTrailCollisionAsset>d__;
			<LoadKuroTrailCollisionAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadKuroTrailCollisionAsset>d__.<>4__this = this;
			<LoadKuroTrailCollisionAsset>d__.path = path;
			<LoadKuroTrailCollisionAsset>d__.<>1__state = -1;
			<LoadKuroTrailCollisionAsset>d__.<>t__builder.Start<MotorcycleFreezeWaterComponent.<LoadKuroTrailCollisionAsset>d__61<T>>(ref <LoadKuroTrailCollisionAsset>d__);
			return <LoadKuroTrailCollisionAsset>d__.<>t__builder.Task;
		}

		// Token: 0x06045E19 RID: 286233 RVA: 0x011621F0 File Offset: 0x011603F0
		private void CreateFreezeWaterDependency()
		{
			if (!this.IsFunctionOpen())
			{
				return;
			}
			if (this.GameCapabilities.Count > 0)
			{
				return;
			}
			MotorcycleActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				AActor owner = actorComp.Owner;
				flag = !((owner != null) ? new bool?(owner.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			string text = ConfigCommonParamById.GetStringConfig("KuroTrailCollisionAsset") ?? "";
			UKuroTrailCollisionAsset ukuroTrailCollisionAsset = ResourceSystem.Instance.Load<UKuroTrailCollisionAsset>(text, "js_undefined");
			if (ukuroTrailCollisionAsset == null || !ukuroTrailCollisionAsset.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Motor;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "MotorcycleFreezeWaterComponent: kuroTrailCollisionAsset is invalid";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.FreezeWaterRenderCapability1 = new FreezeWaterRenderCapability(this.ActorComp.Owner, ukuroTrailCollisionAsset);
			this.MovementTrailCollisionCapability = new MovementTrailCollisionCapability(this.ActorComp.Owner, this.FreezeWaterRenderCapability1.Actor, ukuroTrailCollisionAsset);
			this.GameCapabilities.Add(this.FreezeWaterRenderCapability1);
			this.GameCapabilities.Add(this.MovementTrailCollisionCapability);
			foreach (WaterDetectedCapability waterDetectedCapability in this.GameCapabilities)
			{
				waterDetectedCapability.Activate();
			}
		}

		// Token: 0x06045E1A RID: 286234 RVA: 0x01162350 File Offset: 0x01160550
		private void ClearFreezeWaterEffect()
		{
			foreach (int tagId in this.FreezeWaterEffectTagToContexts.Keys)
			{
				this.EndSummonedEntityFreezeWaterEffect(tagId);
			}
		}

		// Token: 0x06045E1B RID: 286235 RVA: 0x011623A8 File Offset: 0x011605A8
		private void OnMotorcycleWaterAreaChange(bool inArea)
		{
			this.InNavWaterArea = inArea;
		}

		// Token: 0x06045E1C RID: 286236 RVA: 0x011623B4 File Offset: 0x011605B4
		private void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsDriver)
			{
				return;
			}
			this.ClearFreezeWaterEffect();
			this.InNavWaterArea = false;
			this.DetectedWater = false;
			ITagTask freezeRunningWaterTagTask = this.FreezeRunningWaterTagTask;
			if (freezeRunningWaterTagTask != null)
			{
				freezeRunningWaterTagTask.EndTask();
			}
			this.FreezeRunningWaterTagTask = null;
			CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager = this.FreezeWaterPriorityManager;
			if (freezeWaterPriorityManager == null)
			{
				return;
			}
			freezeWaterPriorityManager.TryExitAll("");
		}

		// Token: 0x06045E1D RID: 286237 RVA: 0x0116240C File Offset: 0x0116060C
		private void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsDriver)
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
			int valueOrDefault = num2.GetValueOrDefault();
			if (valueOrDefault != CreatureModel.Instance.GetPlayerId())
			{
				return;
			}
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(valueOrDefault);
			PlayerTagComponent playerTagComponent = (playerEntity != null) ? playerEntity.CheckGetComponent<PlayerTagComponent>() : null;
			if (playerTagComponent == null)
			{
				return;
			}
			this.FreezeRunningWaterTagTask = playerTagComponent.ListenForTagAddOrRemove(new int?(MotorcycleFreezeWaterComponent.freezeRunningWaterTag), new BaseTagComponent.TTagSwitchedCallback(this.OnFreezeRunningWaterTagChanged), null);
		}

		// Token: 0x06045E1E RID: 286238 RVA: 0x011624AC File Offset: 0x011606AC
		private void OnFreezeRunningWaterTagChanged(int tagId, bool tagExist)
		{
			if (tagId != MotorcycleFreezeWaterComponent.freezeRunningWaterTag)
			{
				return;
			}
			if (!this.IsFunctionOpen())
			{
				return;
			}
			if (tagExist)
			{
				CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager = this.FreezeWaterPriorityManager;
				if (freezeWaterPriorityManager == null)
				{
					return;
				}
				freezeWaterPriorityManager.TryEnter(MotorcycleFreezeWaterComponent.EFreezeWaterType.SetPositionByMaterialParameterCollection, "OnFreezeRunningWaterTagChanged");
				return;
			}
			else
			{
				CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager2 = this.FreezeWaterPriorityManager;
				if (freezeWaterPriorityManager2 != null)
				{
					freezeWaterPriorityManager2.TryExit(MotorcycleFreezeWaterComponent.EFreezeWaterType.SetPositionByMaterialParameterCollection, "OnFreezeRunningWaterTagChanged");
				}
				CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> freezeWaterPriorityManager3 = this.FreezeWaterPriorityManager;
				if (freezeWaterPriorityManager3 == null)
				{
					return;
				}
				freezeWaterPriorityManager3.TryEnter(MotorcycleFreezeWaterComponent.EFreezeWaterType.MovementTrailCollision, "OnFreezeRunningWaterTagChanged");
				return;
			}
		}

		// Token: 0x06045E1F RID: 286239 RVA: 0x01162515 File Offset: 0x01160715
		private bool MovementTrailCollisionEnterCallback(ICustomPriorityCallbackParam param)
		{
			if (this.IsFunctionOpen() && this.DetectedWater)
			{
				this.MovementTrailCollisionHandler(true);
			}
			this.FreezeWaterEnterExitHandler = new Action<bool>(this.MovementTrailCollisionHandler);
			this.FreezeWaterTickHandler = new Action<float, global::Vector, global::Vector>(this.MovementTrailCollisionTickHandler);
			return true;
		}

		// Token: 0x06045E20 RID: 286240 RVA: 0x01162553 File Offset: 0x01160753
		private bool MovementTrailCollisionExitCallback(ICustomPriorityCallbackParam param)
		{
			this.MovementTrailCollisionHandler(false);
			this.FreezeWaterEnterExitHandler = null;
			this.FreezeWaterTickHandler = null;
			return true;
		}

		// Token: 0x06045E21 RID: 286241 RVA: 0x0116256C File Offset: 0x0116076C
		private bool SetPositionByMaterialParameterCollectionEnterCallback(ICustomPriorityCallbackParam param)
		{
			if (this.IsFunctionOpen() && FormationDataController.Instance.HasPlayerTag(CreatureModel.Instance.GetPlayerId(), MotorcycleFreezeWaterComponent.freezeRunningWaterTag, false) && this.DetectedWater)
			{
				this.SetPositionByMaterialParameterCollectionHandler(true);
			}
			this.FreezeWaterEnterExitHandler = new Action<bool>(this.SetPositionByMaterialParameterCollectionHandler);
			this.FreezeWaterTickHandler = new Action<float, global::Vector, global::Vector>(this.SetPositionByMaterialParameterCollectionTickHandler);
			return true;
		}

		// Token: 0x06045E22 RID: 286242 RVA: 0x011625D1 File Offset: 0x011607D1
		private bool SetPositionByMaterialParameterCollectionExitCallback(ICustomPriorityCallbackParam param)
		{
			this.SetPositionByMaterialParameterCollectionHandler(false);
			this.FreezeWaterEnterExitHandler = null;
			this.FreezeWaterTickHandler = null;
			return true;
		}

		// Token: 0x06045E23 RID: 286243 RVA: 0x011625EC File Offset: 0x011607EC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleFreezeWaterComponent motorcycleFreezeWaterComponent = (MotorcycleFreezeWaterComponent)componentTemplate;
			if (base.CanResetComponentProperty("TraceWaterCapability"))
			{
				if (motorcycleFreezeWaterComponent.TraceWaterCapability == null)
				{
					this.TraceWaterCapability = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MotorcycleTraceWaterCapability>(this.TraceWaterCapability), "TraceWaterCapability"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FreezeWaterRenderCapability1"))
			{
				if (motorcycleFreezeWaterComponent.FreezeWaterRenderCapability1 == null)
				{
					this.FreezeWaterRenderCapability1 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FreezeWaterRenderCapability>(this.FreezeWaterRenderCapability1), "FreezeWaterRenderCapability1"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MovementTrailCollisionCapability"))
			{
				if (motorcycleFreezeWaterComponent.MovementTrailCollisionCapability == null)
				{
					this.MovementTrailCollisionCapability = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MovementTrailCollisionCapability>(this.MovementTrailCollisionCapability), "MovementTrailCollisionCapability"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("GameCapabilities") && motorcycleFreezeWaterComponent.GameCapabilities != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<WaterDetectedCapability>>(this.GameCapabilities), "GameCapabilities"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (motorcycleFreezeWaterComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MotorcycleActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (motorcycleFreezeWaterComponent.MoveComp == null)
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
				if (motorcycleFreezeWaterComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InteractionComp"))
			{
				if (motorcycleFreezeWaterComponent.InteractionComp == null)
				{
					this.InteractionComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroEnviInteractionComponent>(this.InteractionComp), "InteractionComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OriginMotorcycleToKuroWaterCollisionResponse"))
			{
				this.OriginMotorcycleToKuroWaterCollisionResponse = motorcycleFreezeWaterComponent.OriginMotorcycleToKuroWaterCollisionResponse;
			}
			if (base.CanResetComponentProperty("KuroTrailCollisionAsset"))
			{
				if (motorcycleFreezeWaterComponent.KuroTrailCollisionAsset == null)
				{
					this.KuroTrailCollisionAsset = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroTrailCollisionAsset>(this.KuroTrailCollisionAsset), "KuroTrailCollisionAsset"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InNavWaterAreaInternal"))
			{
				this.InNavWaterAreaInternal = motorcycleFreezeWaterComponent.InNavWaterAreaInternal;
			}
			if (base.CanResetComponentProperty("DetectedWaterInternal"))
			{
				this.DetectedWaterInternal = motorcycleFreezeWaterComponent.DetectedWaterInternal;
			}
			if (base.CanResetComponentProperty("TempWheelHitResults"))
			{
				if (motorcycleFreezeWaterComponent.TempWheelHitResults == null)
				{
					this.TempWheelHitResults = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, FHitResult>>(this.TempWheelHitResults), "TempWheelHitResults"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("WheelHitResults"))
			{
				if (motorcycleFreezeWaterComponent.WheelHitResults == null)
				{
					this.WheelHitResults = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, FHitResult>>(this.WheelHitResults), "WheelHitResults"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsAutonomousProxy"))
			{
				this.IsAutonomousProxy = motorcycleFreezeWaterComponent.IsAutonomousProxy;
			}
			if (base.CanResetComponentProperty("KuroTrailCollisionAssetPath"))
			{
				this.KuroTrailCollisionAssetPath = motorcycleFreezeWaterComponent.KuroTrailCollisionAssetPath;
			}
			if (base.CanResetComponentProperty("FreezeWaterEffectTagToContexts") && motorcycleFreezeWaterComponent.FreezeWaterEffectTagToContexts != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, List<MotorcycleFreezeWaterComponent.IEffectContext>>>(this.FreezeWaterEffectTagToContexts), "FreezeWaterEffectTagToContexts"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TagTasks") && motorcycleFreezeWaterComponent.TagTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagTasks), "TagTasks"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("FreezeRunningWaterTagTask"))
			{
				if (motorcycleFreezeWaterComponent.FreezeRunningWaterTagTask == null)
				{
					this.FreezeRunningWaterTagTask = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.FreezeRunningWaterTagTask), "FreezeRunningWaterTagTask"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FreezeWaterPriorityManager"))
			{
				if (motorcycleFreezeWaterComponent.FreezeWaterPriorityManager == null)
				{
					this.FreezeWaterPriorityManager = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType>>(this.FreezeWaterPriorityManager), "FreezeWaterPriorityManager"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsFunctionOpenOverride"))
			{
				this.IsFunctionOpenOverride = motorcycleFreezeWaterComponent.IsFunctionOpenOverride;
			}
			if (base.CanResetComponentProperty("FreezeWaterEnterExitHandler"))
			{
				if (motorcycleFreezeWaterComponent.FreezeWaterEnterExitHandler == null)
				{
					this.FreezeWaterEnterExitHandler = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<bool>>(this.FreezeWaterEnterExitHandler), "FreezeWaterEnterExitHandler"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FreezeWaterTickHandler"))
			{
				if (motorcycleFreezeWaterComponent.FreezeWaterTickHandler == null)
				{
					this.FreezeWaterTickHandler = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action<float, global::Vector, global::Vector>>(this.FreezeWaterTickHandler), "FreezeWaterTickHandler"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EffectSystemContext"))
			{
				if (motorcycleFreezeWaterComponent.EffectSystemContext == null)
				{
					this.EffectSystemContext = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EffectContext>(this.EffectSystemContext), "EffectSystemContext"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpVector"))
			{
				if (motorcycleFreezeWaterComponent.TmpVector == null)
				{
					this.TmpVector = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector), "TmpVector"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0402487B RID: 149627
		private const string LOAD_BP_TYPE = "LoadBPType";

		// Token: 0x0402487C RID: 149628
		private const string LOAD_KURO_TRAIL_COLLISION_ASSET = "LoadKuroTrailCollisionAsset";

		// Token: 0x0402487D RID: 149629
		private const string CREATE_DEPENDENCY = "CreateDependency";

		// Token: 0x0402487E RID: 149630
		[StaticVariableRuleIgnore]
		private static int freezeWaterEffectTag = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冻结水面.特效1"];

		// Token: 0x0402487F RID: 149631
		[StaticVariableRuleIgnore]
		private static int freezeMotorSlideEffectTag = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冻结水面.特效2"];

		// Token: 0x04024880 RID: 149632
		[StaticVariableRuleIgnore]
		private static int freezeRunningWaterTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冰面行驶.启用流体冰面"];

		// Token: 0x04024881 RID: 149633
		[Nullable(2)]
		private MotorcycleTraceWaterCapability TraceWaterCapability;

		// Token: 0x04024882 RID: 149634
		[Nullable(2)]
		private FreezeWaterRenderCapability FreezeWaterRenderCapability1;

		// Token: 0x04024883 RID: 149635
		[Nullable(2)]
		private MovementTrailCollisionCapability MovementTrailCollisionCapability;

		// Token: 0x04024884 RID: 149636
		private readonly List<WaterDetectedCapability> GameCapabilities = new List<WaterDetectedCapability>();

		// Token: 0x04024885 RID: 149637
		[Nullable(2)]
		private MotorcycleActorComponent ActorComp;

		// Token: 0x04024886 RID: 149638
		[Nullable(2)]
		private MotorcycleMoveComponent MoveComp;

		// Token: 0x04024887 RID: 149639
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04024888 RID: 149640
		[Nullable(2)]
		private UKuroEnviInteractionComponent InteractionComp;

		// Token: 0x04024889 RID: 149641
		private ECollisionResponse? OriginMotorcycleToKuroWaterCollisionResponse;

		// Token: 0x0402488A RID: 149642
		[Nullable(2)]
		protected UKuroTrailCollisionAsset KuroTrailCollisionAsset;

		// Token: 0x0402488B RID: 149643
		private bool InNavWaterAreaInternal;

		// Token: 0x0402488C RID: 149644
		private bool DetectedWaterInternal;

		// Token: 0x0402488D RID: 149645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, FHitResult> TempWheelHitResults;

		// Token: 0x0402488E RID: 149646
		[Nullable(2)]
		private Dictionary<int, FHitResult> WheelHitResults;

		// Token: 0x0402488F RID: 149647
		private bool IsAutonomousProxy;

		// Token: 0x04024890 RID: 149648
		[StaticVariableRuleIgnore]
		private static readonly MotorcycleFreezeWaterComponent.IEffectConfig[] FreezeWaterEffectConfigs = new MotorcycleFreezeWaterComponent.IEffectConfig[]
		{
			new MotorcycleFreezeWaterComponent.EffectConfigImpl
			{
				Config = "FreezeWaterEffect",
				TagId = MotorcycleFreezeWaterComponent.freezeWaterEffectTag
			},
			new MotorcycleFreezeWaterComponent.EffectConfigImpl
			{
				Config = "FreezeMotorSlideEffect",
				TagId = MotorcycleFreezeWaterComponent.freezeMotorSlideEffectTag
			}
		};

		// Token: 0x04024891 RID: 149649
		private string KuroTrailCollisionAssetPath = "";

		// Token: 0x04024892 RID: 149650
		private readonly Dictionary<int, List<MotorcycleFreezeWaterComponent.IEffectContext>> FreezeWaterEffectTagToContexts = new Dictionary<int, List<MotorcycleFreezeWaterComponent.IEffectContext>>();

		// Token: 0x04024893 RID: 149651
		private readonly List<ITagTask> TagTasks = new List<ITagTask>();

		// Token: 0x04024894 RID: 149652
		[Nullable(2)]
		private ITagTask FreezeRunningWaterTagTask;

		// Token: 0x04024895 RID: 149653
		[Nullable(2)]
		private CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> FreezeWaterPriorityManager;

		// Token: 0x04024896 RID: 149654
		private bool? IsFunctionOpenOverride;

		// Token: 0x04024897 RID: 149655
		[Nullable(2)]
		private Action<bool> FreezeWaterEnterExitHandler;

		// Token: 0x04024898 RID: 149656
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<float, global::Vector, global::Vector> FreezeWaterTickHandler;

		// Token: 0x04024899 RID: 149657
		[Nullable(2)]
		private EffectContext EffectSystemContext;

		// Token: 0x0402489A RID: 149658
		[StaticVariableRuleIgnore]
		private global::Vector TmpVector = global::Vector.Create();

		// Token: 0x0200CE13 RID: 52755
		public interface IEffectContext
		{
			// Token: 0x1700A2A7 RID: 41639
			// (get) Token: 0x06051DAB RID: 335275
			// (set) Token: 0x06051DAC RID: 335276
			string AssetPath { get; set; }

			// Token: 0x1700A2A8 RID: 41640
			// (get) Token: 0x06051DAD RID: 335277
			// (set) Token: 0x06051DAE RID: 335278
			string ComponentName { get; set; }

			// Token: 0x1700A2A9 RID: 41641
			// (get) Token: 0x06051DAF RID: 335279
			// (set) Token: 0x06051DB0 RID: 335280
			FName Socket { get; set; }

			// Token: 0x1700A2AA RID: 41642
			// (get) Token: 0x06051DB1 RID: 335281
			// (set) Token: 0x06051DB2 RID: 335282
			int? EffectHandleId { get; set; }
		}

		// Token: 0x0200CE14 RID: 52756
		[Nullable(0)]
		public class EffectContextImpl : MotorcycleFreezeWaterComponent.IEffectContext
		{
			// Token: 0x1700A2AB RID: 41643
			// (get) Token: 0x06051DB3 RID: 335283 RVA: 0x0163E91C File Offset: 0x0163CB1C
			// (set) Token: 0x06051DB4 RID: 335284 RVA: 0x0163E924 File Offset: 0x0163CB24
			public string AssetPath { get; set; }

			// Token: 0x1700A2AC RID: 41644
			// (get) Token: 0x06051DB5 RID: 335285 RVA: 0x0163E92D File Offset: 0x0163CB2D
			// (set) Token: 0x06051DB6 RID: 335286 RVA: 0x0163E935 File Offset: 0x0163CB35
			public string ComponentName { get; set; }

			// Token: 0x1700A2AD RID: 41645
			// (get) Token: 0x06051DB7 RID: 335287 RVA: 0x0163E93E File Offset: 0x0163CB3E
			// (set) Token: 0x06051DB8 RID: 335288 RVA: 0x0163E946 File Offset: 0x0163CB46
			public FName Socket { get; set; }

			// Token: 0x1700A2AE RID: 41646
			// (get) Token: 0x06051DB9 RID: 335289 RVA: 0x0163E94F File Offset: 0x0163CB4F
			// (set) Token: 0x06051DBA RID: 335290 RVA: 0x0163E957 File Offset: 0x0163CB57
			public int? EffectHandleId { get; set; }
		}

		// Token: 0x0200CE15 RID: 52757
		public interface IEffectConfig
		{
			// Token: 0x1700A2AF RID: 41647
			// (get) Token: 0x06051DBC RID: 335292
			// (set) Token: 0x06051DBD RID: 335293
			string Config { get; set; }

			// Token: 0x1700A2B0 RID: 41648
			// (get) Token: 0x06051DBE RID: 335294
			// (set) Token: 0x06051DBF RID: 335295
			int TagId { get; set; }

			// Token: 0x1700A2B1 RID: 41649
			// (get) Token: 0x06051DC0 RID: 335296
			// (set) Token: 0x06051DC1 RID: 335297
			[Nullable(2)]
			string EffectPath { [NullableContext(2)] get; [NullableContext(2)] set; }
		}

		// Token: 0x0200CE16 RID: 52758
		[Nullable(0)]
		public class EffectConfigImpl : MotorcycleFreezeWaterComponent.IEffectConfig
		{
			// Token: 0x1700A2B2 RID: 41650
			// (get) Token: 0x06051DC2 RID: 335298 RVA: 0x0163E968 File Offset: 0x0163CB68
			// (set) Token: 0x06051DC3 RID: 335299 RVA: 0x0163E970 File Offset: 0x0163CB70
			public string Config { get; set; }

			// Token: 0x1700A2B3 RID: 41651
			// (get) Token: 0x06051DC4 RID: 335300 RVA: 0x0163E979 File Offset: 0x0163CB79
			// (set) Token: 0x06051DC5 RID: 335301 RVA: 0x0163E981 File Offset: 0x0163CB81
			public int TagId { get; set; }

			// Token: 0x1700A2B4 RID: 41652
			// (get) Token: 0x06051DC6 RID: 335302 RVA: 0x0163E98A File Offset: 0x0163CB8A
			// (set) Token: 0x06051DC7 RID: 335303 RVA: 0x0163E992 File Offset: 0x0163CB92
			[Nullable(2)]
			public string EffectPath { [NullableContext(2)] get; [NullableContext(2)] set; }
		}

		// Token: 0x0200CE17 RID: 52759
		[NullableContext(0)]
		public enum EFreezeWaterType
		{
			// Token: 0x0403E13B RID: 254267
			SetPositionByMaterialParameterCollection,
			// Token: 0x0403E13C RID: 254268
			MovementTrailCollision
		}

		// Token: 0x0200CE19 RID: 52761
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E140 RID: 254272
			[Nullable(0)]
			public static Func<UniTask> <0>__LoadBlueprintTypeAsync;
		}
	}
}

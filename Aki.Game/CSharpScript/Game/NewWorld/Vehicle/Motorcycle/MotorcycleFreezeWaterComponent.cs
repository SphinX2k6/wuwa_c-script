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
	// Token: 0x020061A5 RID: 24997
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleFreezeWaterComponent : EntityComponent
	{
		// Token: 0x17007110 RID: 28944
		// (get) Token: 0x0603BFC8 RID: 245704 RVA: 0x0110AFB8 File Offset: 0x011091B8
		// (set) Token: 0x0603BFC9 RID: 245705 RVA: 0x0110AFC0 File Offset: 0x011091C0
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

		// Token: 0x17007111 RID: 28945
		// (get) Token: 0x0603BFCA RID: 245706 RVA: 0x0110B151 File Offset: 0x01109351
		// (set) Token: 0x0603BFCB RID: 245707 RVA: 0x0110B15C File Offset: 0x0110935C
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

		// Token: 0x17007112 RID: 28946
		// (get) Token: 0x0603BFCC RID: 245708 RVA: 0x0110B29C File Offset: 0x0110949C
		public override Type[] Dependencies
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

		// Token: 0x0603BFCD RID: 245709 RVA: 0x0110B2F0 File Offset: 0x011094F0
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

		// Token: 0x0603BFCE RID: 245710 RVA: 0x0110B4D8 File Offset: 0x011096D8
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

		// Token: 0x0603BFCF RID: 245711 RVA: 0x0110B76C File Offset: 0x0110996C
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

		// Token: 0x0603BFD0 RID: 245712 RVA: 0x0110B924 File Offset: 0x01109B24
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

		// Token: 0x0603BFD1 RID: 245713 RVA: 0x0110BCF8 File Offset: 0x01109EF8
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

		// Token: 0x0603BFD2 RID: 245714 RVA: 0x0110BDF4 File Offset: 0x01109FF4
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

		// Token: 0x0603BFD3 RID: 245715 RVA: 0x0110BE84 File Offset: 0x0110A084
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

		// Token: 0x0603BFD4 RID: 245716 RVA: 0x0110BEFC File Offset: 0x0110A0FC
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

		// Token: 0x0603BFD5 RID: 245717 RVA: 0x0110BF9A File Offset: 0x0110A19A
		public void SetIsFunctionOpenOverride(bool? value)
		{
			this.IsFunctionOpenOverride = value;
		}

		// Token: 0x0603BFD6 RID: 245718 RVA: 0x0110BFA3 File Offset: 0x0110A1A3
		private bool IsFunctionOpen()
		{
			if (this.IsFunctionOpenOverride != null)
			{
				return this.IsFunctionOpenOverride.Value;
			}
			return FunctionModel.Instance.IsOpen(EFunctionType.MotorFreezeWater);
		}

		// Token: 0x0603BFD7 RID: 245719 RVA: 0x0110BFD0 File Offset: 0x0110A1D0
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

		// Token: 0x0603BFD8 RID: 245720 RVA: 0x0110C0CD File Offset: 0x0110A2CD
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

		// Token: 0x0603BFD9 RID: 245721 RVA: 0x0110C0EC File Offset: 0x0110A2EC
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

		// Token: 0x0603BFDA RID: 245722 RVA: 0x0110C2D0 File Offset: 0x0110A4D0
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

		// Token: 0x0603BFDB RID: 245723 RVA: 0x0110C394 File Offset: 0x0110A594
		protected UniTask CreateFreezeWaterDependencyByTaskGraph()
		{
			MotorcycleFreezeWaterComponent.<CreateFreezeWaterDependencyByTaskGraph>d__59 <CreateFreezeWaterDependencyByTaskGraph>d__;
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>4__this = this;
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>1__state = -1;
			<CreateFreezeWaterDependencyByTaskGraph>d__.<>t__builder.Start<MotorcycleFreezeWaterComponent.<CreateFreezeWaterDependencyByTaskGraph>d__59>(ref <CreateFreezeWaterDependencyByTaskGraph>d__);
			return <CreateFreezeWaterDependencyByTaskGraph>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFDC RID: 245724 RVA: 0x0110C3D8 File Offset: 0x0110A5D8
		private static UniTask LoadBlueprintTypeAsync()
		{
			MotorcycleFreezeWaterComponent.<LoadBlueprintTypeAsync>d__60 <LoadBlueprintTypeAsync>d__;
			<LoadBlueprintTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBlueprintTypeAsync>d__.<>1__state = -1;
			<LoadBlueprintTypeAsync>d__.<>t__builder.Start<MotorcycleFreezeWaterComponent.<LoadBlueprintTypeAsync>d__60>(ref <LoadBlueprintTypeAsync>d__);
			return <LoadBlueprintTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFDD RID: 245725 RVA: 0x0110C414 File Offset: 0x0110A614
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

		// Token: 0x0603BFDE RID: 245726 RVA: 0x0110C460 File Offset: 0x0110A660
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

		// Token: 0x0603BFDF RID: 245727 RVA: 0x0110C5C0 File Offset: 0x0110A7C0
		private void ClearFreezeWaterEffect()
		{
			foreach (int tagId in this.FreezeWaterEffectTagToContexts.Keys)
			{
				this.EndSummonedEntityFreezeWaterEffect(tagId);
			}
		}

		// Token: 0x0603BFE0 RID: 245728 RVA: 0x0110C618 File Offset: 0x0110A818
		private void OnMotorcycleWaterAreaChange(bool inArea)
		{
			this.InNavWaterArea = inArea;
		}

		// Token: 0x0603BFE1 RID: 245729 RVA: 0x0110C624 File Offset: 0x0110A824
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

		// Token: 0x0603BFE2 RID: 245730 RVA: 0x0110C67C File Offset: 0x0110A87C
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

		// Token: 0x0603BFE3 RID: 245731 RVA: 0x0110C71C File Offset: 0x0110A91C
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

		// Token: 0x0603BFE4 RID: 245732 RVA: 0x0110C785 File Offset: 0x0110A985
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

		// Token: 0x0603BFE5 RID: 245733 RVA: 0x0110C7C3 File Offset: 0x0110A9C3
		private bool MovementTrailCollisionExitCallback(ICustomPriorityCallbackParam param)
		{
			this.MovementTrailCollisionHandler(false);
			this.FreezeWaterEnterExitHandler = null;
			this.FreezeWaterTickHandler = null;
			return true;
		}

		// Token: 0x0603BFE6 RID: 245734 RVA: 0x0110C7DC File Offset: 0x0110A9DC
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

		// Token: 0x0603BFE7 RID: 245735 RVA: 0x0110C841 File Offset: 0x0110AA41
		private bool SetPositionByMaterialParameterCollectionExitCallback(ICustomPriorityCallbackParam param)
		{
			this.SetPositionByMaterialParameterCollectionHandler(false);
			this.FreezeWaterEnterExitHandler = null;
			this.FreezeWaterTickHandler = null;
			return true;
		}

		// Token: 0x0603BFE8 RID: 245736 RVA: 0x0110C85C File Offset: 0x0110AA5C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleFreezeWaterComponent motorcycleFreezeWaterComponent = (MotorcycleFreezeWaterComponent)componentTemplate;
			if (motorcycleFreezeWaterComponent.TraceWaterCapability == null)
			{
				this.TraceWaterCapability = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceWaterCapability), "TraceWaterCapability"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.FreezeWaterRenderCapability1 == null)
			{
				this.FreezeWaterRenderCapability1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeWaterRenderCapability1), "FreezeWaterRenderCapability1"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.MovementTrailCollisionCapability == null)
			{
				this.MovementTrailCollisionCapability = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MovementTrailCollisionCapability), "MovementTrailCollisionCapability"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.GameCapabilities != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameCapabilities), "GameCapabilities"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.InteractionComp == null)
			{
				this.InteractionComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractionComp), "InteractionComp"))
			{
				return false;
			}
			this.OriginMotorcycleToKuroWaterCollisionResponse = motorcycleFreezeWaterComponent.OriginMotorcycleToKuroWaterCollisionResponse;
			if (motorcycleFreezeWaterComponent.KuroTrailCollisionAsset == null)
			{
				this.KuroTrailCollisionAsset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.KuroTrailCollisionAsset), "KuroTrailCollisionAsset"))
			{
				return false;
			}
			this.InNavWaterAreaInternal = motorcycleFreezeWaterComponent.InNavWaterAreaInternal;
			this.DetectedWaterInternal = motorcycleFreezeWaterComponent.DetectedWaterInternal;
			if (motorcycleFreezeWaterComponent.TempWheelHitResults == null)
			{
				this.TempWheelHitResults = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempWheelHitResults), "TempWheelHitResults"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.WheelHitResults == null)
			{
				this.WheelHitResults = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WheelHitResults), "WheelHitResults"))
			{
				return false;
			}
			this.IsAutonomousProxy = motorcycleFreezeWaterComponent.IsAutonomousProxy;
			this.KuroTrailCollisionAssetPath = motorcycleFreezeWaterComponent.KuroTrailCollisionAssetPath;
			if (motorcycleFreezeWaterComponent.FreezeWaterEffectTagToContexts != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeWaterEffectTagToContexts), "FreezeWaterEffectTagToContexts"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.TagTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagTasks), "TagTasks"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.FreezeRunningWaterTagTask == null)
			{
				this.FreezeRunningWaterTagTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeRunningWaterTagTask), "FreezeRunningWaterTagTask"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.FreezeWaterPriorityManager == null)
			{
				this.FreezeWaterPriorityManager = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeWaterPriorityManager), "FreezeWaterPriorityManager"))
			{
				return false;
			}
			this.IsFunctionOpenOverride = motorcycleFreezeWaterComponent.IsFunctionOpenOverride;
			if (motorcycleFreezeWaterComponent.FreezeWaterEnterExitHandler == null)
			{
				this.FreezeWaterEnterExitHandler = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeWaterEnterExitHandler), "FreezeWaterEnterExitHandler"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.FreezeWaterTickHandler == null)
			{
				this.FreezeWaterTickHandler = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FreezeWaterTickHandler), "FreezeWaterTickHandler"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.EffectSystemContext == null)
			{
				this.EffectSystemContext = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EffectSystemContext), "EffectSystemContext"))
			{
				return false;
			}
			if (motorcycleFreezeWaterComponent.TmpVector == null)
			{
				this.TmpVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007113 RID: 28947
		// (get) Token: 0x0603BFE9 RID: 245737 RVA: 0x0110CBDA File Offset: 0x0110ADDA
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007114 RID: 28948
		// (get) Token: 0x0603BFEA RID: 245738 RVA: 0x0110CBDD File Offset: 0x0110ADDD
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007115 RID: 28949
		// (get) Token: 0x0603BFEB RID: 245739 RVA: 0x0110CBE0 File Offset: 0x0110ADE0
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FB31 RID: 129841
		private const string LOAD_BP_TYPE = "LoadBPType";

		// Token: 0x0401FB32 RID: 129842
		private const string LOAD_KURO_TRAIL_COLLISION_ASSET = "LoadKuroTrailCollisionAsset";

		// Token: 0x0401FB33 RID: 129843
		private const string CREATE_DEPENDENCY = "CreateDependency";

		// Token: 0x0401FB34 RID: 129844
		[StaticVariableRuleIgnore]
		private static int freezeWaterEffectTag = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冻结水面.特效1"];

		// Token: 0x0401FB35 RID: 129845
		[StaticVariableRuleIgnore]
		private static int freezeMotorSlideEffectTag = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冻结水面.特效2"];

		// Token: 0x0401FB36 RID: 129846
		[StaticVariableRuleIgnore]
		private static int freezeRunningWaterTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冰面行驶.启用流体冰面"];

		// Token: 0x0401FB37 RID: 129847
		[Nullable(2)]
		private MotorcycleTraceWaterCapability TraceWaterCapability;

		// Token: 0x0401FB38 RID: 129848
		[Nullable(2)]
		private FreezeWaterRenderCapability FreezeWaterRenderCapability1;

		// Token: 0x0401FB39 RID: 129849
		[Nullable(2)]
		private MovementTrailCollisionCapability MovementTrailCollisionCapability;

		// Token: 0x0401FB3A RID: 129850
		private readonly List<WaterDetectedCapability> GameCapabilities = new List<WaterDetectedCapability>();

		// Token: 0x0401FB3B RID: 129851
		[Nullable(2)]
		private MotorcycleActorComponent ActorComp;

		// Token: 0x0401FB3C RID: 129852
		[Nullable(2)]
		private MotorcycleMoveComponent MoveComp;

		// Token: 0x0401FB3D RID: 129853
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x0401FB3E RID: 129854
		[Nullable(2)]
		private UKuroEnviInteractionComponent InteractionComp;

		// Token: 0x0401FB3F RID: 129855
		private ECollisionResponse? OriginMotorcycleToKuroWaterCollisionResponse;

		// Token: 0x0401FB40 RID: 129856
		[Nullable(2)]
		protected UKuroTrailCollisionAsset KuroTrailCollisionAsset;

		// Token: 0x0401FB41 RID: 129857
		private bool InNavWaterAreaInternal;

		// Token: 0x0401FB42 RID: 129858
		private bool DetectedWaterInternal;

		// Token: 0x0401FB43 RID: 129859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, FHitResult> TempWheelHitResults;

		// Token: 0x0401FB44 RID: 129860
		[Nullable(2)]
		private Dictionary<int, FHitResult> WheelHitResults;

		// Token: 0x0401FB45 RID: 129861
		private bool IsAutonomousProxy;

		// Token: 0x0401FB46 RID: 129862
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

		// Token: 0x0401FB47 RID: 129863
		private string KuroTrailCollisionAssetPath = "";

		// Token: 0x0401FB48 RID: 129864
		private readonly Dictionary<int, List<MotorcycleFreezeWaterComponent.IEffectContext>> FreezeWaterEffectTagToContexts = new Dictionary<int, List<MotorcycleFreezeWaterComponent.IEffectContext>>();

		// Token: 0x0401FB49 RID: 129865
		private readonly List<ITagTask> TagTasks = new List<ITagTask>();

		// Token: 0x0401FB4A RID: 129866
		[Nullable(2)]
		private ITagTask FreezeRunningWaterTagTask;

		// Token: 0x0401FB4B RID: 129867
		[Nullable(2)]
		private CustomPriorityManager<MotorcycleFreezeWaterComponent.EFreezeWaterType> FreezeWaterPriorityManager;

		// Token: 0x0401FB4C RID: 129868
		private bool? IsFunctionOpenOverride;

		// Token: 0x0401FB4D RID: 129869
		[Nullable(2)]
		private Action<bool> FreezeWaterEnterExitHandler;

		// Token: 0x0401FB4E RID: 129870
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<float, global::Vector, global::Vector> FreezeWaterTickHandler;

		// Token: 0x0401FB4F RID: 129871
		[Nullable(2)]
		private EffectContext EffectSystemContext;

		// Token: 0x0401FB50 RID: 129872
		[StaticVariableRuleIgnore]
		private global::Vector TmpVector = global::Vector.Create();

		// Token: 0x0200BA04 RID: 47620
		public interface IEffectContext
		{
			// Token: 0x17007A4B RID: 31307
			// (get) Token: 0x06048614 RID: 296468
			// (set) Token: 0x06048615 RID: 296469
			string AssetPath { get; set; }

			// Token: 0x17007A4C RID: 31308
			// (get) Token: 0x06048616 RID: 296470
			// (set) Token: 0x06048617 RID: 296471
			string ComponentName { get; set; }

			// Token: 0x17007A4D RID: 31309
			// (get) Token: 0x06048618 RID: 296472
			// (set) Token: 0x06048619 RID: 296473
			FName Socket { get; set; }

			// Token: 0x17007A4E RID: 31310
			// (get) Token: 0x0604861A RID: 296474
			// (set) Token: 0x0604861B RID: 296475
			int? EffectHandleId { get; set; }
		}

		// Token: 0x0200BA05 RID: 47621
		[Nullable(0)]
		public class EffectContextImpl : MotorcycleFreezeWaterComponent.IEffectContext
		{
			// Token: 0x17007A4F RID: 31311
			// (get) Token: 0x0604861C RID: 296476 RVA: 0x01613C3C File Offset: 0x01611E3C
			// (set) Token: 0x0604861D RID: 296477 RVA: 0x01613C44 File Offset: 0x01611E44
			public string AssetPath { get; set; }

			// Token: 0x17007A50 RID: 31312
			// (get) Token: 0x0604861E RID: 296478 RVA: 0x01613C4D File Offset: 0x01611E4D
			// (set) Token: 0x0604861F RID: 296479 RVA: 0x01613C55 File Offset: 0x01611E55
			public string ComponentName { get; set; }

			// Token: 0x17007A51 RID: 31313
			// (get) Token: 0x06048620 RID: 296480 RVA: 0x01613C5E File Offset: 0x01611E5E
			// (set) Token: 0x06048621 RID: 296481 RVA: 0x01613C66 File Offset: 0x01611E66
			public FName Socket { get; set; }

			// Token: 0x17007A52 RID: 31314
			// (get) Token: 0x06048622 RID: 296482 RVA: 0x01613C6F File Offset: 0x01611E6F
			// (set) Token: 0x06048623 RID: 296483 RVA: 0x01613C77 File Offset: 0x01611E77
			public int? EffectHandleId { get; set; }
		}

		// Token: 0x0200BA06 RID: 47622
		public interface IEffectConfig
		{
			// Token: 0x17007A53 RID: 31315
			// (get) Token: 0x06048625 RID: 296485
			// (set) Token: 0x06048626 RID: 296486
			string Config { get; set; }

			// Token: 0x17007A54 RID: 31316
			// (get) Token: 0x06048627 RID: 296487
			// (set) Token: 0x06048628 RID: 296488
			int TagId { get; set; }

			// Token: 0x17007A55 RID: 31317
			// (get) Token: 0x06048629 RID: 296489
			// (set) Token: 0x0604862A RID: 296490
			[Nullable(2)]
			string EffectPath { [NullableContext(2)] get; [NullableContext(2)] set; }
		}

		// Token: 0x0200BA07 RID: 47623
		[Nullable(0)]
		public class EffectConfigImpl : MotorcycleFreezeWaterComponent.IEffectConfig
		{
			// Token: 0x17007A56 RID: 31318
			// (get) Token: 0x0604862B RID: 296491 RVA: 0x01613C88 File Offset: 0x01611E88
			// (set) Token: 0x0604862C RID: 296492 RVA: 0x01613C90 File Offset: 0x01611E90
			public string Config { get; set; }

			// Token: 0x17007A57 RID: 31319
			// (get) Token: 0x0604862D RID: 296493 RVA: 0x01613C99 File Offset: 0x01611E99
			// (set) Token: 0x0604862E RID: 296494 RVA: 0x01613CA1 File Offset: 0x01611EA1
			public int TagId { get; set; }

			// Token: 0x17007A58 RID: 31320
			// (get) Token: 0x0604862F RID: 296495 RVA: 0x01613CAA File Offset: 0x01611EAA
			// (set) Token: 0x06048630 RID: 296496 RVA: 0x01613CB2 File Offset: 0x01611EB2
			[Nullable(2)]
			public string EffectPath { [NullableContext(2)] get; [NullableContext(2)] set; }
		}

		// Token: 0x0200BA08 RID: 47624
		[NullableContext(0)]
		public enum EFreezeWaterType
		{
			// Token: 0x04039566 RID: 234854
			SetPositionByMaterialParameterCollection,
			// Token: 0x04039567 RID: 234855
			MovementTrailCollision
		}

		// Token: 0x0200BA0A RID: 47626
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403956B RID: 234859
			[Nullable(0)]
			public static Func<UniTask> <0>__LoadBlueprintTypeAsync;
		}
	}
}

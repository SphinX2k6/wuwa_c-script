using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools.RippleSwim;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045E4 RID: 17892
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCharacterWaterEffect
	{
		// Token: 0x0602E20A RID: 188938 RVA: 0x00AA5D90 File Offset: 0x00AA3F90
		public void Start(TsBaseCharacter owner)
		{
			if (this.Config == null || !this.Config.IsValid() || !owner.IsValid())
			{
				return;
			}
			this.Owner = owner;
			this.OwnerHeight = ((this.Owner.CapsuleComponent != null) ? (this.Owner.CapsuleComponent.CapsuleHalfHeight * 2f) : 0f);
			this.InWaterSubConfig.Init(this.Config.WaterEffectConfig);
			this.SwimIdleEffect = this.Config.SwimIdleEffectRef;
			this.SwimNormalEffect = this.Config.SwimNormalEffectRef;
			this.SwimFastEffect = this.Config.SwimFastEffectRef;
			this.VehicleEffect = new SceneCharacterVehicleEffect();
			this.VehicleEffect.Start(owner);
			this.VehicleEffect.Enable();
			int num = this.Config.MaterialEffectConfig.Num();
			for (int i = 0; i < num; i++)
			{
				UPhysicalMaterial key = this.Config.MaterialEffectConfig.GetKey(i);
				SWaterEffectSubConfig swaterEffectSubConfig = this.Config.MaterialEffectConfig.Get(key);
				if (swaterEffectSubConfig != null)
				{
					WaterEffectSubConfig waterEffectSubConfig = new WaterEffectSubConfig();
					waterEffectSubConfig.Init(swaterEffectSubConfig);
					this.OnMaterialSubConfig[key] = waterEffectSubConfig;
				}
			}
			int size = 12;
			this.VelocityHistory.Initialize(size);
			this.IsReady = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "WaterEffect Start";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E20B RID: 188939 RVA: 0x00AA5F08 File Offset: 0x00AA4108
		public void Enable()
		{
			if (!this.IsReady)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterUnifiedStateComponent ownerStateComponent;
			if (characterActorComponent == null)
			{
				ownerStateComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				ownerStateComponent = ((entity != null) ? entity.GetComponent<CharacterUnifiedStateComponent>() : null);
			}
			this.OwnerStateComponent = ownerStateComponent;
			this.WetController = (this.Owner.GetComponentByClass(UKuroCharWetControllerComponent.StaticClass()) as UKuroCharWetControllerComponent);
			this.WetStateTagId = GameplayTagUtils.GetTagIdByName("TA.表现.角色.状态效果.湿身");
			this.LastWetStateTagActive = false;
			this.BlackRainTagId = GameplayTagUtils.GetTagIdByName("TA.表现.角色.状态效果.下黑雨");
			this.LastBlackRainActive = false;
			this.CharWetMPC = ResourceSystem.Instance.Load<UMaterialParameterCollection>("/Game/Aki/Render/Data/MPC_GlobalShaderParameters.MPC_GlobalShaderParameters", "js_undefined");
			this.BlackRainParamName = new FName("CharWetRenderBlackRainInt");
			this.IsEnabled = true;
			this.ShoreTraceElement = new UTraceSphereElement();
			this.ShoreTraceElement.bIsSingle = true;
			this.ShoreTraceElement.bTraceComplex = false;
			this.ShoreTraceElement.bIgnoreSelf = true;
			this.ShoreTraceElement.WorldContextObject = this.Owner;
			this.ShoreTraceElement.Radius = 50f;
			this.ShoreTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
			if (UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.InteractionEffect.IESystemDebugDraw") > 0f)
			{
				this.ShoreTraceElement.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				TraceElementCommon.Instance.SetTraceColor(this.ShoreTraceElement, new FLinearColor(255f, 255f, 0f, 1f));
				TraceElementCommon.Instance.SetTraceHitColor(this.ShoreTraceElement, new FLinearColor(0f, 255f, 0f, 1f));
			}
			this.ShoreTraceDelegate = new FAsyncTraceDelegate();
			this.ShoreTraceDelegate.Bind(new Action<bool, UTraceBaseElement, double, double>(this.SetShoreTraceState));
			CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
			Entity entity2 = (characterActorComponent2 != null) ? characterActorComponent2.Entity : null;
			if (entity2 != null)
			{
				EventSystem.Instance.AddWithTarget<bool>(entity2, EEventName.OnCharFootOnTheGround, new Action<bool>(this.OnOwnerCharFootOnTheGround));
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "WaterEffect Enabled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E20C RID: 188940 RVA: 0x00AA6120 File Offset: 0x00AA4320
		public void Disable()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			TsBaseCharacter owner = this.Owner;
			Entity entity;
			if (owner == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			if (entity2 != null)
			{
				EventSystem.Instance.RemoveWithTarget<bool>(entity2, EEventName.OnCharFootOnTheGround, new Action<bool>(this.OnOwnerCharFootOnTheGround));
			}
			if (EffectSystem.Instance.IsValid(this.Handle))
			{
				EffectSystem.Instance.StopEffectById(this.Handle, "[SceneCharacterWaterEffect.Disable]", true, null);
				this.Handle = 0;
			}
			if (EffectSystem.Instance.IsValid(this.AudioEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.AudioEffectHandle, "[SceneCharacterWaterEffect.Disable]", true, null);
				this.AudioEffectHandle = 0;
			}
			if (this.VehicleEffect != null)
			{
				this.VehicleEffect.Disable();
			}
			if (this.LastWetStateTagActive)
			{
				TsBaseCharacter owner2 = this.Owner;
				object obj;
				if (owner2 == null)
				{
					obj = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent2 = owner2.CharacterActorComponent;
					if (characterActorComponent2 == null)
					{
						obj = null;
					}
					else
					{
						Entity entity3 = characterActorComponent2.Entity;
						obj = ((entity3 != null) ? entity3.GetComponent<BaseTagComponent>() : null);
					}
				}
				object obj2 = obj;
				if (obj2 != null)
				{
					obj2.RemoveTag(new int?(this.WetStateTagId));
				}
				this.LastWetStateTagActive = false;
			}
			if (this.LastBlackRainActive)
			{
				if (this.CharWetMPC != null && this.BlackRainParamName != FName.NAME_None)
				{
					UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.CharWetMPC, this.BlackRainParamName, 0f);
				}
				this.LastBlackRainActive = false;
			}
			this.WetController = null;
			this.CharWetMPC = null;
			this.BlackRainParamName = FName.NAME_None;
			this.IsEnabled = false;
			UTraceSphereElement shoreTraceElement = this.ShoreTraceElement;
			if (shoreTraceElement != null)
			{
				shoreTraceElement.Dispose();
			}
			this.ShoreTraceElement = null;
			this.ShoreTraceDelegate = null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "WaterEffect Disabled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E20D RID: 188941 RVA: 0x00AA62FC File Offset: 0x00AA44FC
		public void Tick()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.UpdateWetStateTag();
			this.UpdateBlackRainMaterial();
			if (this.VehicleEffect != null)
			{
				this.VehicleEffect.Tick();
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterMoveComponent characterMoveComponent;
			if (characterActorComponent == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (characterMoveComponent2 != null)
			{
				Vector inB = Vector.Create(this.CurrentWaterNormal.X, this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z);
				if (characterMoveComponent2.GravityDirect.DotProduct(inB) < 0.20000000298023224)
				{
					return;
				}
			}
			CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
			object obj;
			if (characterActorComponent2 == null)
			{
				obj = null;
			}
			else
			{
				Entity entity2 = characterActorComponent2.Entity;
				obj = ((entity2 != null) ? entity2.GetComponent<CharacterBuffComponent>() : null);
			}
			object obj2 = obj;
			if (((obj2 != null) ? obj2.GetBuffById(640003011L) : null) != null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent3 = this.Owner.CharacterActorComponent;
			object obj3;
			if (characterActorComponent3 == null)
			{
				obj3 = null;
			}
			else
			{
				Entity entity3 = characterActorComponent3.Entity;
				obj3 = ((entity3 != null) ? entity3.GetComponent<BaseTagComponent>() : null);
			}
			object obj4 = obj3;
			if (obj4 != null && obj4.HasTag(GameplayTagDefine.EGameplayTagId["GameplayEffect.ShieldWaterMoveEffect"]))
			{
				return;
			}
			if (EffectSystem.Instance.IsValid(this.Handle) && !this.IsBlackWave && !this.FindNoWaterPhysicalMaterial)
			{
				EffectSystem.Instance.HandleSeekToTime(this.Handle, (float)this.CurrentSpeed, false, false);
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.Handle);
				Vector currentWaterLocation = this.CurrentWaterLocation;
				currentWaterLocation.X = this.Owner.D_K2_GetActorLocation().X;
				currentWaterLocation.Y = this.Owner.D_K2_GetActorLocation().Y;
				FVectorDouble fvectorDouble = currentWaterLocation.ToUeVector(false);
				effectActor.D_K2_SetActorLocation(fvectorDouble, false, ref PhysicsUtils.Instance.DefaultHitResult, true);
				FVectorDouble fvectorDouble2 = this.CurrentWaterNormal.ToUeVector(false);
				FVectorDouble fvectorDouble3 = this.Owner.D_GetActorForwardVector();
				FVectorDouble fvectorDouble4 = UKismetMathLibrary.D_Cross_VectorVector(fvectorDouble2, fvectorDouble3);
				fvectorDouble3 = UKismetMathLibrary.D_Cross_VectorVector(fvectorDouble4, fvectorDouble2);
				FRotator frotator = UKismetMathLibrary.D_MakeRotationFromAxes(fvectorDouble3, fvectorDouble4, fvectorDouble2);
				effectActor.K2_SetActorRotation(frotator, true);
				if (EffectSystem.Instance.IsValid(this.AudioEffectHandle))
				{
					OneOf<KuroEffectActorHandle, AActor> effectActor2 = EffectSystem.Instance.GetEffectActor(this.AudioEffectHandle);
					fvectorDouble = this.CurrentWaterLocation.ToUeVector(false);
					effectActor2.D_K2_SetActorLocation(fvectorDouble, false, ref PhysicsUtils.Instance.DefaultHitResult, true);
				}
			}
			if (this.OwnerHeight > 0f)
			{
				float value = MathUtils.Instance.Clamp((float)(this.CurrentWaterDepth / (double)this.OwnerHeight), 0f, 1f);
				AudioSystem.Instance.SetRtpcValue("amb_water_depth", value, new SetRtpcValueArgs?(new SetRtpcValueArgs
				{
					Actor = this.Owner
				}));
			}
		}

		// Token: 0x0602E20E RID: 188942 RVA: 0x00AA65A0 File Offset: 0x00AA47A0
		protected void UpdateWetStateTag()
		{
			if (this.WetController == null || !this.WetController.IsValid() || this.WetStateTagId == 0)
			{
				return;
			}
			bool bWetStateTagActive = this.WetController.bWetStateTagActive;
			if (bWetStateTagActive == this.LastWetStateTagActive)
			{
				return;
			}
			this.LastWetStateTagActive = bWetStateTagActive;
			TsBaseCharacter owner = this.Owner;
			BaseTagComponent baseTagComponent;
			if (owner == null)
			{
				baseTagComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					baseTagComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				return;
			}
			if (bWetStateTagActive)
			{
				baseTagComponent2.AddTag(new int?(this.WetStateTagId));
				return;
			}
			baseTagComponent2.RemoveTag(new int?(this.WetStateTagId));
		}

		// Token: 0x0602E20F RID: 188943 RVA: 0x00AA6640 File Offset: 0x00AA4840
		protected void UpdateBlackRainMaterial()
		{
			if (this.CharWetMPC == null || this.BlackRainParamName == FName.NAME_None || this.BlackRainTagId == 0)
			{
				return;
			}
			TsBaseCharacter owner = this.Owner;
			object obj;
			if (owner == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					obj = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
			}
			object obj2 = obj;
			bool flag = obj2 != null && obj2.HasTag(this.BlackRainTagId);
			if (flag == this.LastBlackRainActive)
			{
				return;
			}
			this.LastBlackRainActive = flag;
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.CharWetMPC, this.BlackRainParamName, flag ? 1f : 0f);
		}

		// Token: 0x0602E210 RID: 188944 RVA: 0x00AA66E4 File Offset: 0x00AA48E4
		public bool IsMaterialInUse(UPhysicalMaterial physicalMaterial)
		{
			WaterEffectSubConfig waterEffectSubConfig;
			return this.OnMaterialSubConfig.TryGetValue(physicalMaterial, out waterEffectSubConfig) && (!waterEffectSubConfig.TriggerInGrass || RenderDataManager.Instance.GetPlayerInGrass());
		}

		// Token: 0x0602E211 RID: 188945 RVA: 0x00AA6718 File Offset: 0x00AA4918
		public void SetStateNone(Vector velocity)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.VelocityHistory.AddVelocity(velocity);
			this.CurrentSpeed = velocity.Size();
			this.CurrentVelocity.Set(velocity.X, velocity.Y, velocity.Z);
			if (this.State != EWaterEffectState.None)
			{
				if (this.CurrentSubConfig != null)
				{
					this.OnCharacterJumpOutWater(velocity, this.CurrentWaterLocation, this.CurrentWaterNormal, this.CurrentSubConfig, this.CurrentWaterDepth);
				}
				this.StopEffect();
				this.CurrentSubConfig = null;
				this.State = EWaterEffectState.None;
			}
			if (this.VehicleEffect != null)
			{
				this.VehicleEffect.IsVehicleWaterState = false;
			}
		}

		// Token: 0x0602E212 RID: 188946 RVA: 0x00AA67BC File Offset: 0x00AA49BC
		public void SetStateInWater(double waterDepth, Vector waterNormal, Vector velocity, Vector location, double waterHeight)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterDriveVehicleComponent characterDriveVehicleComponent;
			if (characterActorComponent == null)
			{
				characterDriveVehicleComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterDriveVehicleComponent = ((entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null);
			}
			CharacterDriveVehicleComponent characterDriveVehicleComponent2 = characterDriveVehicleComponent;
			if (characterDriveVehicleComponent2 != null && characterDriveVehicleComponent2.IsOnVehicle)
			{
				this.SetStateNone(velocity);
				return;
			}
			this.CurrentWaterDepth = waterDepth;
			this.CurrentWaterLocation.Set(location.X, location.Y, waterHeight);
			this.CurrentWaterNormal = waterNormal;
			this.VelocityHistory.AddVelocity(velocity);
			this.CurrentSpeed = velocity.Size();
			this.CurrentVelocity.Set(velocity.X, velocity.Y, velocity.Z);
			if (this.State == EWaterEffectState.None)
			{
				this.OnCharacterFallInWater(velocity, this.CurrentWaterLocation, waterNormal, this.InWaterSubConfig, waterDepth);
			}
			CharacterUnifiedStateComponent ownerStateComponent = this.OwnerStateComponent;
			ECharMoveState? echarMoveState = (ownerStateComponent != null) ? new ECharMoveState?(ownerStateComponent.MoveState) : null;
			if (echarMoveState.GetValueOrDefault() == ECharMoveState.NormalSwim)
			{
				this.SpawnEffect(this.SwimNormalEffect, null, location, false);
			}
			else if (echarMoveState.GetValueOrDefault() == ECharMoveState.FastSwim)
			{
				this.SpawnEffect(this.SwimFastEffect, null, location, false);
			}
			else
			{
				this.WadeMoveSearchSpeed = this.CurrentSpeed;
				bool flag = this.ShouldUseShallowFootSplashes(this.InWaterSubConfig, waterDepth);
				WaterEffectItem waterEffectItem = this.InWaterSubConfig.FindWadeMoveEffect(waterDepth, this.WadeMoveSearchSpeed, flag);
				if (waterEffectItem != null)
				{
					this.SpawnEffect(waterEffectItem.EffectDataPath, waterEffectItem.AudioEffectDataPath, location, false);
				}
				else if (flag)
				{
					this.StopEffect();
				}
				else
				{
					if (waterDepth > (double)this.InWaterSubConfig.FallJumpDepthThreshold)
					{
						ECharMoveState? echarMoveState2 = echarMoveState;
						ECharMoveState echarMoveState3 = ECharMoveState.Other;
						if (echarMoveState2.GetValueOrDefault() == echarMoveState3 & echarMoveState2 != null)
						{
							this.SpawnEffect(this.SwimIdleEffect, null, location, false);
							goto IL_1B3;
						}
					}
					this.StopEffect();
				}
			}
			IL_1B3:
			this.CurrentSubConfig = this.InWaterSubConfig;
			this.State = EWaterEffectState.InWater;
		}

		// Token: 0x0602E213 RID: 188947 RVA: 0x00AA6990 File Offset: 0x00AA4B90
		public void SetStateInWaterEnviData([Nullable(2)] FKuroEnviInteractionData enviData, Vector velocity, Vector location)
		{
			if (!this.IsEnabled || enviData == null)
			{
				return;
			}
			this.EIData = enviData;
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterDriveVehicleComponent characterDriveVehicleComponent;
			if (characterActorComponent == null)
			{
				characterDriveVehicleComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterDriveVehicleComponent = ((entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null);
			}
			CharacterDriveVehicleComponent characterDriveVehicleComponent2 = characterDriveVehicleComponent;
			if (characterDriveVehicleComponent2 != null && characterDriveVehicleComponent2.IsOnVehicle && !this.IsMotorState)
			{
				this.SetStateNone(velocity);
				return;
			}
			this.CurrentWaterDepth = (double)enviData.WaterDepth;
			this.CurrentWaterLocation.Set(location.X, location.Y, (double)enviData.HitWaterLocation.Z);
			this.CurrentWaterNormal.Set((double)enviData.HitWaterNormal.X, (double)enviData.HitWaterNormal.Y, (double)enviData.HitWaterNormal.Z);
			this.VelocityHistory.AddVelocity(velocity);
			this.CurrentSpeed = velocity.Size();
			this.CurrentVelocity.Set(velocity.X, velocity.Y, velocity.Z);
			if (this.State == EWaterEffectState.None)
			{
				this.OnCharacterFallInWater(velocity, this.CurrentWaterLocation, this.CurrentWaterNormal, this.InWaterSubConfig, this.CurrentWaterDepth);
			}
			if (this.IsMotorState)
			{
				if (this.VehicleEffect != null)
				{
					this.VehicleEffect.IsVehicleWaterState = true;
					this.VehicleEffect.SetStateInWaterEnviData(enviData);
				}
				this.StopEffect();
			}
			else
			{
				CharacterUnifiedStateComponent ownerStateComponent = this.OwnerStateComponent;
				ECharMoveState? echarMoveState = (ownerStateComponent != null) ? new ECharMoveState?(ownerStateComponent.MoveState) : null;
				if (echarMoveState.GetValueOrDefault() == ECharMoveState.NormalSwim)
				{
					this.SpawnEffect(this.SwimNormalEffect, null, location, false);
				}
				else if (echarMoveState.GetValueOrDefault() == ECharMoveState.FastSwim)
				{
					this.SpawnEffect(this.SwimFastEffect, null, location, false);
				}
				else
				{
					Vector currentWaterNormal = this.CurrentWaterNormal;
					currentWaterNormal.GetSafeNormal(currentWaterNormal, 9.99999993922529E-09);
					double num = velocity.DotProduct(currentWaterNormal);
					double num2 = Math.Sqrt(this.CurrentSpeed * this.CurrentSpeed - num * num);
					this.WadeMoveSearchSpeed = num2;
					bool flag = this.ShouldUseShallowFootSplashes(this.InWaterSubConfig, this.CurrentWaterDepth);
					WaterEffectItem waterEffectItem = this.InWaterSubConfig.FindWadeMoveEffect(this.CurrentWaterDepth, num2, flag);
					if (waterEffectItem != null)
					{
						this.SpawnEffect(waterEffectItem.EffectDataPath, waterEffectItem.AudioEffectDataPath, location, false);
					}
					else if (flag)
					{
						this.StopEffect();
					}
					else
					{
						if (this.CurrentWaterDepth > (double)this.InWaterSubConfig.FallJumpDepthThreshold)
						{
							ECharMoveState? echarMoveState2 = echarMoveState;
							ECharMoveState echarMoveState3 = ECharMoveState.Other;
							if (echarMoveState2.GetValueOrDefault() == echarMoveState3 & echarMoveState2 != null)
							{
								this.SpawnEffect(this.SwimIdleEffect, null, location, false);
								goto IL_27E;
							}
						}
						this.StopEffect();
					}
				}
				IL_27E:
				if (this.VehicleEffect != null)
				{
					this.VehicleEffect.IsVehicleWaterState = false;
				}
				this.CurrentSubConfig = this.InWaterSubConfig;
			}
			this.State = EWaterEffectState.InWater;
		}

		// Token: 0x0602E214 RID: 188948 RVA: 0x00AA6C44 File Offset: 0x00AA4E44
		public void SetStateOnMaterialEnviData(UPhysicalMaterial material, Vector velocity, Vector location, [Nullable(2)] FKuroEnviInteractionData enviData)
		{
			this.EIData = enviData;
			WaterEffectSubConfig valueOrDefault = this.OnMaterialSubConfig.GetValueOrDefault(material);
			if (valueOrDefault == null)
			{
				this.SetStateNone(velocity);
				return;
			}
			if (this.VehicleEffect != null)
			{
				this.VehicleEffect.IsVehicleWaterState = false;
			}
			CharacterUnifiedStateComponent ownerStateComponent = this.OwnerStateComponent;
			if (((ownerStateComponent != null) ? new ECharMoveState?(ownerStateComponent.MoveState) : null).GetValueOrDefault() == ECharMoveState.Soar)
			{
				return;
			}
			this.CurrentWaterDepth = (double)enviData.WaterDepth;
			this.CurrentWaterLocation.Set(location.X, location.Y, (double)enviData.HitWaterLocationWithOffset.Z);
			this.CurrentWaterNormal.Set((double)enviData.HitWaterNormal.X, (double)enviData.HitWaterNormal.Y, (double)enviData.HitWaterNormal.Z);
			this.VelocityHistory.AddVelocity(velocity);
			this.CurrentSpeed = velocity.Size();
			this.CurrentVelocity.Set(velocity.X, velocity.Y, velocity.Z);
			if (this.State == EWaterEffectState.None)
			{
				this.OnCharacterFallInWater(velocity, this.CurrentWaterLocation, this.CurrentWaterNormal, valueOrDefault, this.CurrentWaterDepth);
			}
			Vector currentWaterNormal = this.CurrentWaterNormal;
			currentWaterNormal.GetSafeNormal(currentWaterNormal, 9.99999993922529E-09);
			double num = velocity.DotProduct(currentWaterNormal);
			double num2 = Math.Sqrt(this.CurrentSpeed * this.CurrentSpeed - num * num);
			this.WadeMoveSearchSpeed = num2;
			bool flag = this.ShouldUseShallowFootSplashes(valueOrDefault, this.CurrentWaterDepth);
			WaterEffectItem waterEffectItem = valueOrDefault.FindWadeMoveEffect(this.CurrentWaterDepth, num2, flag);
			if (waterEffectItem != null)
			{
				this.SpawnEffect(waterEffectItem.EffectDataPath, waterEffectItem.AudioEffectDataPath, location, true);
			}
			else if (flag)
			{
				this.StopEffect();
			}
			this.CurrentSubConfig = valueOrDefault;
			this.State = EWaterEffectState.OnMaterial;
		}

		// Token: 0x0602E215 RID: 188949 RVA: 0x00AA6E04 File Offset: 0x00AA5004
		public void SetWaterDataEnviDataCheckFly([Nullable(2)] FKuroEnviInteractionData enviData, Vector location, Vector velocity)
		{
			if (!this.IsEnabled || enviData == null || this.Owner == null)
			{
				return;
			}
			this.CurrentWaterDepth = (double)enviData.WaterDepth;
			this.CurrentWaterNormal.Set((double)enviData.HitWaterNormal.X, (double)enviData.HitWaterNormal.Y, (double)enviData.HitWaterNormal.Z);
			this.CurrentToWaterHeight = enviData.CapsuleToWater;
			this.CurrentWaterLocation.Set(location.X, location.Y, (double)enviData.HitWaterLocation.Z);
			this.IsTraceWater = enviData.bTraceWater;
			this.IsBlackWave = enviData.bTouchBlackWave;
			this.VelocityHistory.AddVelocity(velocity);
			this.CurrentSpeed = velocity.Size();
			this.CurrentVelocity.Set(velocity.X, velocity.Y, velocity.Z);
			if (this.Owner.CharacterMovement != null && !this.IsBlackWave)
			{
				CharacterUnifiedStateComponent ownerStateComponent = this.OwnerStateComponent;
				ECharMoveState? echarMoveState = (ownerStateComponent != null) ? new ECharMoveState?(ownerStateComponent.MoveState) : null;
				this.IsMotorState = false;
				CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
				BaseTagComponent baseTagComponent;
				if (characterActorComponent == null)
				{
					baseTagComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
				BaseTagComponent baseTagComponent2 = baseTagComponent;
				if (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]))
				{
					this.IsMotorState = true;
				}
				bool flag = echarMoveState.GetValueOrDefault() == ECharMoveState.Soar && !enviData.bInWater;
				bool flag2 = this.IsMotorState && this.CurrentSpeed > 100.0 && (baseTagComponent2 == null || !baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态"]));
				bool flag3 = baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.冲刺移动"]) && baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"]);
				bool flag4 = baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态.翱翔"]);
				if ((flag || flag2 || flag3 || flag4) && this.IsTraceWater)
				{
					int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true);
					if (currentValue != null)
					{
						int? num = currentValue;
						int num2 = 2;
						if (!(num.GetValueOrDefault() < num2 & num != null) && !Info.Instance.IsMobilePlatform())
						{
							EFlyWaterEffectState flyWaterType = EFlyWaterEffectState.Default;
							if (flag4)
							{
								flyWaterType = EFlyWaterEffectState.MotorSoaring;
							}
							this.OnCharacterFlyOnWater(velocity, this.InWaterSubConfig, flyWaterType);
							goto IL_26E;
						}
					}
					return;
				}
			}
			IL_26E:
			this.FindNoWaterPhysicalMaterial = enviData.HitPhysicMaterialArray.Contains("DynamicWater");
			if (this.VehicleEffect != null)
			{
				this.VehicleEffect.UpdateVehicleEffectData(enviData, this.IsMotorState, this.VelocityHistory.GetMaxVelocity(), this.IsBlackWave);
			}
		}

		// Token: 0x0602E216 RID: 188950 RVA: 0x00AA70C0 File Offset: 0x00AA52C0
		public void SetStateOnMaterial(UPhysicalMaterial material, double waterDepth, Vector waterNormal, Vector velocity, Vector location, double waterHeight)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			WaterEffectSubConfig valueOrDefault = this.OnMaterialSubConfig.GetValueOrDefault(material);
			if (valueOrDefault == null)
			{
				this.SetStateNone(velocity);
				return;
			}
			this.CurrentWaterDepth = waterDepth;
			this.CurrentWaterLocation.Set(location.X, location.Y, waterHeight);
			this.CurrentWaterNormal = waterNormal;
			this.VelocityHistory.AddVelocity(velocity);
			this.CurrentSpeed = velocity.Size();
			this.CurrentVelocity.Set(velocity.X, velocity.Y, velocity.Z);
			if (this.State == EWaterEffectState.None)
			{
				this.OnCharacterFallInWater(velocity, this.CurrentWaterLocation, waterNormal, valueOrDefault, waterDepth);
			}
			this.WadeMoveSearchSpeed = this.CurrentSpeed;
			bool flag = this.ShouldUseShallowFootSplashes(valueOrDefault, waterDepth);
			WaterEffectItem waterEffectItem = valueOrDefault.FindWadeMoveEffect(waterDepth, this.WadeMoveSearchSpeed, flag);
			if (waterEffectItem != null)
			{
				this.SpawnEffect(waterEffectItem.EffectDataPath, waterEffectItem.AudioEffectDataPath, location, true);
			}
			else if (flag)
			{
				this.StopEffect();
			}
			this.CurrentSubConfig = valueOrDefault;
			this.State = EWaterEffectState.OnMaterial;
		}

		// Token: 0x0602E217 RID: 188951 RVA: 0x00AA71C0 File Offset: 0x00AA53C0
		protected unsafe void OnCharacterFallInWater(Vector speed, Vector location, Vector normal, WaterEffectSubConfig subConfig, double waterDepth)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (waterDepth < (double)subConfig.FallJumpDepthThreshold)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "WaterEffect Spawn Fall In Water";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", this.Owner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("vel", this.VelocityHistory.GetMaxVelocityDirection(Vector.Create(-this.CurrentWaterNormal.X, -this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z)));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			WaterEffectItem waterEffectItem = subConfig.FindFallEffectAtSpeed((float)this.VelocityHistory.GetMaxVelocityDirection(Vector.Create(-this.CurrentWaterNormal.X, -this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z)));
			if (waterEffectItem == null)
			{
				return;
			}
			Vector location2 = Vector.Create(location.X + speed.X * (double)this.Config.FallJumpPositionFix, location.Y + speed.Y * (double)this.Config.FallJumpPositionFix, location.Z);
			this.SpawnFallEffect(waterEffectItem.EffectDataPath, waterEffectItem.AudioEffectDataPath, location2, normal);
		}

		// Token: 0x0602E218 RID: 188952 RVA: 0x00AA730C File Offset: 0x00AA550C
		protected void OnCharacterJumpOutWater(Vector speed, Vector location, Vector normal, WaterEffectSubConfig subConfig, double waterDepth)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (waterDepth < (double)subConfig.FallJumpDepthThreshold)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "WaterEffect Spawn Jump Out of Water";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", this.Owner);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			WaterEffectItem waterEffectItem = subConfig.FindJumpEffectAtSpeed((float)this.VelocityHistory.GetMaxVelocityDirection(this.CurrentWaterNormal));
			if (waterEffectItem == null)
			{
				return;
			}
			Vector location2 = Vector.Create(location.X + speed.X * (double)this.Config.FallJumpPositionFix, location.Y + speed.Y * (double)this.Config.FallJumpPositionFix, location.Z);
			this.SpawnFallEffect(waterEffectItem.EffectDataPath, waterEffectItem.AudioEffectDataPath, location2, normal);
		}

		// Token: 0x0602E219 RID: 188953 RVA: 0x00AA73D0 File Offset: 0x00AA55D0
		protected void StopEffect()
		{
			int effectHandle = this.Handle;
			if (effectHandle != 0 && EffectSystem.Instance.IsValid(effectHandle))
			{
				EffectSystem.Instance.HandleSeekToTime(effectHandle, -1f, false, false);
				float num = this.Config.TimeExistAfterDead * 1000f;
				if (num > 20f)
				{
					TimerSystem.Instance.Delay(delegate(float deltaTime)
					{
						if (EffectSystem.Instance.IsValid(effectHandle))
						{
							EffectSystem.Instance.StopEffectById(effectHandle, "[SceneCharacterWaterEffect.StopEffect]", true, null);
						}
					}, (float)((int)num), null, null, true, 1f);
				}
				else
				{
					TimerSystem.Instance.Next(delegate(float deltaTime)
					{
						if (EffectSystem.Instance.IsValid(effectHandle))
						{
							EffectSystem.Instance.StopEffectById(effectHandle, "[SceneCharacterWaterEffect.StopEffect]", true, null);
						}
					}, null, null);
				}
			}
			this.Handle = 0;
			if (EffectSystem.Instance.IsValid(this.AudioEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.AudioEffectHandle, "[SceneCharacterWaterEffect.StopEffect]", true, null);
			}
			this.AudioEffectHandle = 0;
		}

		// Token: 0x0602E21A RID: 188954 RVA: 0x00AA74BC File Offset: 0x00AA56BC
		protected void SpawnEffect([Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataPath, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> audioEffectDataPath, Vector location, bool physicsMaterialWater)
		{
			if (!EffectSystem.Instance.IsValid(this.Handle) || this.HandlePath != effectDataPath)
			{
				this.StopEffect();
				if (effectDataPath == null || this.IsBlackWave || this.EIData == null || this.FindNoWaterPhysicalMaterial)
				{
					return;
				}
				if (!physicsMaterialWater && this.EIData.CapsuleToBlock < this.EIData.CapsuleToWater)
				{
					return;
				}
				FVectorDouble fvectorDouble = location.ToUeVector(false);
				this.EmptyUeTransform.SetLocation(fvectorDouble);
				EffectSystem instance = EffectSystem.Instance;
				UObject owner = this.Owner;
				FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
				this.Handle = instance.SpawnEffect(owner, ftransformDouble, effectDataPath.ToAssetPathName(), "[SceneCharacterWaterEffect.SpawnEffect]", new EffectContext(null, this.Owner, false), EEffectType.Fight, null, null, null, false, false);
				EffectSystem.Instance.FreezeHandle(this.Handle, true, false);
				if (EffectSystem.Instance.IsValid(this.Handle))
				{
					this.HandlePath = effectDataPath;
				}
				if (audioEffectDataPath != null)
				{
					string text = audioEffectDataPath.ToAssetPathName();
					if (!string.IsNullOrEmpty(text))
					{
						EffectSystem instance2 = EffectSystem.Instance;
						UObject owner2 = this.Owner;
						ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
						this.AudioEffectHandle = instance2.SpawnEffect(owner2, ftransformDouble, text, "[SceneCharacterWaterEffect.SpawnEffect(Audio)]", new EffectContext(null, this.Owner, false), EEffectType.Fight, null, null, null, false, false);
					}
				}
			}
		}

		// Token: 0x0602E21B RID: 188955 RVA: 0x00AA7620 File Offset: 0x00AA5820
		protected int SpawnFallEffect([Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataPath, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> audioEffectDataPath, Vector location, Vector normal)
		{
			if (effectDataPath == null || this.IsBlackWave || this.FindNoWaterPhysicalMaterial)
			{
				return -1;
			}
			TsBaseCharacter owner = this.Owner;
			CharacterMoveComponent characterMoveComponent;
			if (owner == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterMoveComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
				}
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (characterMoveComponent2 != null)
			{
				Vector inB = Vector.Create(this.CurrentWaterNormal.X, this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z);
				if (characterMoveComponent2.GravityDirect.DotProduct(inB) < 0.20000000298023224)
				{
					return -1;
				}
				if (Math.Abs(characterMoveComponent2.GravityDirect.Z) < 0.8999999761581421)
				{
					return -1;
				}
			}
			if (this.IsMotorState && this.VehicleEffect != null)
			{
				this.VehicleEffect.OnFallInWater(location, normal);
				return -1;
			}
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			this.EmptyUeTransform.SetLocation(fvectorDouble);
			fvectorDouble = normal.ToUeVector(false);
			FQuat fquat = UKismetMathLibrary.D_MakeRotFromZ(fvectorDouble).Quaternion();
			this.EmptyUeTransform.SetRotation(fquat);
			string path = effectDataPath.ToAssetPathName();
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
			int result = instance.SpawnUnloopedEffect(world, ftransformDouble, path, "[SceneCharacterWaterEffect.SpawnFallEffect]", new EffectContext(null, this.Owner, false), EEffectType.Scene, null, null, null, false, false);
			if (audioEffectDataPath != null)
			{
				string text = audioEffectDataPath.ToAssetPathName();
				if (!string.IsNullOrEmpty(text))
				{
					EffectSystem instance2 = EffectSystem.Instance;
					UObject world2 = GlobalData.World;
					ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
					instance2.SpawnUnloopedEffect(world2, ftransformDouble, text, "[SceneCharacterWaterEffect.SpawnFallEffect(Audio)]", null, EEffectType.Fight, null, null, null, false, false);
				}
			}
			return result;
		}

		// Token: 0x0602E21C RID: 188956 RVA: 0x00AA77C0 File Offset: 0x00AA59C0
		protected void OnCharacterFlyOnWater(Vector speed, WaterEffectSubConfig subConfig, EFlyWaterEffectState flyWaterType)
		{
			if (!this.IsEnabled || this.FindNoWaterPhysicalMaterial)
			{
				return;
			}
			if (this.CurrentToWaterHeight > subConfig.FlyEffectHeightThreshold)
			{
				return;
			}
			WaterEffectItem waterEffectItem = subConfig.FindFlyEffectAtSpeed((float)this.VelocityHistory.GetMaxVelocity());
			if (waterEffectItem == null)
			{
				return;
			}
			TsBaseCharacter owner = this.Owner;
			CharacterMoveComponent characterMoveComponent;
			if (owner == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterMoveComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
				}
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (characterMoveComponent2 != null)
			{
				Vector inB = Vector.Create(this.CurrentWaterNormal.X, this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z);
				if (characterMoveComponent2.GravityDirect.DotProduct(inB) < 0.20000000298023224)
				{
					return;
				}
			}
			Vector vector = Vector.Create(this.CurrentWaterLocation.X + speed.X * 0.30000001192092896, this.CurrentWaterLocation.Y + speed.Y * 0.30000001192092896, this.CurrentWaterLocation.Z);
			if (this.RippleSwim == null && this.Owner != null)
			{
				this.RippleSwim = (UKuroRenderingRuntimeBPPluginBPLibrary.GetActorOfClass(this.Owner, BP_RippleSwim_C.StaticClass()) as BP_RippleSwim_C);
			}
			if (this.RippleSwim != null && flyWaterType != EFlyWaterEffectState.MotorSoaring)
			{
				FVector2D currentRippleCenter = this.RippleSwim.CurrentRippleCenter;
				FVector2D safeNormal = currentRippleCenter.GetSafeNormal(1E-08f);
				vector.X = this.CurrentWaterLocation.X + (double)currentRippleCenter.X + (double)(this.IsMotorState ? 0f : (safeNormal.X * this.RippleSwim.PlayerSize * 1.1f));
				vector.Y = this.CurrentWaterLocation.Y + (double)currentRippleCenter.Y + (double)(this.IsMotorState ? 0f : (safeNormal.Y * this.RippleSwim.PlayerSize * 1.1f));
			}
			else if (flyWaterType == EFlyWaterEffectState.MotorSoaring)
			{
				vector.X = this.CurrentWaterLocation.X + speed.X * 0.15000000596046448;
				vector.Y = this.CurrentWaterLocation.Y + speed.Y * 0.15000000596046448;
			}
			this.ShoreTraceTicker++;
			if (this.ShoreTraceTicker >= 3 && characterMoveComponent2 != null)
			{
				this.ShoreTraceTicker = 0;
				Vector vector2 = vector;
				vector2.AdditionEqual(speed.MultiplyEqual(0.10000000149011612));
				this.ShoreTraceHandle = this.DetectShoreForFlyEffect(vector2);
			}
			Rotator rotator = Rotator.Create();
			if (characterMoveComponent2 != null)
			{
				Vector up = Vector.Create(-characterMoveComponent2.GravityDirect.X, -characterMoveComponent2.GravityDirect.Y, -characterMoveComponent2.GravityDirect.Z);
				MathUtils.Instance.LookRotationUpFirst(speed, up, rotator);
			}
			rotator.Yaw += 90f;
			FVectorDouble fvectorDouble = vector.ToUeVector(false);
			this.EmptyUeTransform.SetLocation(fvectorDouble);
			FQuat fquat = rotator.ToUeRotator().Quaternion();
			this.EmptyUeTransform.SetRotation(fquat);
			string text = "";
			if (flyWaterType != EFlyWaterEffectState.Default)
			{
				if (flyWaterType == EFlyWaterEffectState.MotorSoaring)
				{
					text = "/Game/Aki/Effect/EffectGroup/Common/Water/DA_Fx_Group_SI3_FlyWater_Gliding.DA_Fx_Group_SI3_FlyWater_Gliding";
				}
			}
			else if (waterEffectItem.EffectDataPath != null)
			{
				text = waterEffectItem.EffectDataPath.ToAssetPathName();
			}
			if (!EffectSystem.Instance.IsValid(this.FlyWaterHandle) || text != this.FlyWaterEffectPath)
			{
				if (EffectSystem.Instance.IsValid(this.FlyWaterHandle))
				{
					int oldFlyHandle = this.FlyWaterHandle;
					TimerSystem.Instance.Delay(delegate(float deltaTime)
					{
						if (EffectSystem.Instance.IsValid(oldFlyHandle))
						{
							EffectSystem.Instance.StopEffectById(oldFlyHandle, "[SceneCharacterWaterEffect.StopEffect]", true, null);
						}
					}, 1000f, null, null, true, 1f);
				}
				if (!string.IsNullOrEmpty(text))
				{
					EffectSystem instance = EffectSystem.Instance;
					UObject owner2 = this.Owner;
					FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
					this.FlyWaterHandle = instance.SpawnEffect(owner2, ftransformDouble, text, "[SceneCharacterWaterEffect.SpawnEffect(FlyWaterEffect)]", new EffectContext(null, this.Owner, false), EEffectType.Scene, null, null, null, false, false);
					OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.FlyWaterHandle);
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LLX;
					string message = "WaterEffect Spawn Fly on Water";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WaterEffectActor", effectActor.D_K2_GetActorLocation());
					instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.FlyWaterEffectPath = text;
				}
			}
			OneOf<KuroEffectActorHandle, AActor> effectActor2 = EffectSystem.Instance.GetEffectActor(this.FlyWaterHandle);
			if (effectActor2.HasValue && this.IsTraceWater && !this.IsTracedShore)
			{
				FHitResult fhitResult = new FHitResult();
				effectActor2.D_K2_SetActorTransform(this.EmptyUeTransform, false, ref fhitResult, false);
				EffectParameterNiagara effectParameterNiagara = new EffectParameterNiagara();
				effectParameterNiagara.UserParameterFloat = new List<ValueTuple<FName, float>>();
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("DistanceToWater").Value, this.CurrentToWaterHeight));
				double num = 1.0;
				if (subConfig.FallJumpDepthThreshold > 0f)
				{
					num = Math.Min(0.8, this.CurrentWaterDepth / (double)subConfig.FallJumpDepthThreshold);
				}
				effectParameterNiagara.UserParameterFloat.Add(new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("SpriteScale").Value, (float)num));
				EffectSystem.Instance.SetEffectParameterNiagara(this.FlyWaterHandle, effectParameterNiagara);
			}
		}

		// Token: 0x0602E21D RID: 188957 RVA: 0x00AA7D00 File Offset: 0x00AA5F00
		private void OnOwnerCharFootOnTheGround(bool isLeftFoot)
		{
			if (!this.IsEnabled || this.Owner == null || this.IsMotorState)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterMoveComponent characterMoveComponent;
			if (characterActorComponent == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (characterMoveComponent2 != null)
			{
				Vector inB = Vector.Create(this.CurrentWaterNormal.X, this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z);
				if (characterMoveComponent2.GravityDirect.DotProduct(inB) < 0.20000000298023224)
				{
					return;
				}
			}
			CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
			object obj;
			if (characterActorComponent2 == null)
			{
				obj = null;
			}
			else
			{
				Entity entity2 = characterActorComponent2.Entity;
				obj = ((entity2 != null) ? entity2.GetComponent<CharacterBuffComponent>() : null);
			}
			object obj2 = obj;
			if (((obj2 != null) ? obj2.GetBuffById(640003011L) : null) != null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent3 = this.Owner.CharacterActorComponent;
			object obj3;
			if (characterActorComponent3 == null)
			{
				obj3 = null;
			}
			else
			{
				Entity entity3 = characterActorComponent3.Entity;
				obj3 = ((entity3 != null) ? entity3.GetComponent<BaseTagComponent>() : null);
			}
			object obj4 = obj3;
			if (obj4 != null && obj4.HasTag(GameplayTagDefine.EGameplayTagId["GameplayEffect.ShieldWaterMoveEffect"]))
			{
				return;
			}
			if (this.State != EWaterEffectState.InWater && this.State != EWaterEffectState.OnMaterial)
			{
				return;
			}
			WaterEffectSubConfig currentSubConfig = this.CurrentSubConfig;
			if (currentSubConfig == null || !this.ShouldUseShallowFootSplashes(currentSubConfig, this.CurrentWaterDepth))
			{
				return;
			}
			CharacterUnifiedStateComponent ownerStateComponent = this.OwnerStateComponent;
			ECharMoveState? echarMoveState = (ownerStateComponent != null) ? new ECharMoveState?(ownerStateComponent.MoveState) : null;
			if (echarMoveState.GetValueOrDefault() == ECharMoveState.NormalSwim || echarMoveState.GetValueOrDefault() == ECharMoveState.FastSwim)
			{
				return;
			}
			WaterEffectItem waterEffectItem = currentSubConfig.FindShallowMoveEffect(this.CurrentWaterDepth, this.WadeMoveSearchSpeed);
			if (waterEffectItem == null)
			{
				return;
			}
			this.TrySpawnShallowMoveFootSplash(waterEffectItem, isLeftFoot);
		}

		// Token: 0x0602E21E RID: 188958 RVA: 0x00AA7E8C File Offset: 0x00AA608C
		private void TrySpawnShallowMoveFootSplash(WaterEffectItem item, bool isLeftFoot)
		{
			if (item.EffectDataPath == null || this.IsBlackWave || this.EIData == null || this.FindNoWaterPhysicalMaterial)
			{
				return;
			}
			TsBaseCharacter owner = this.Owner;
			if (owner == null)
			{
				return;
			}
			USkeletalMeshComponent mesh = owner.Mesh;
			if (mesh == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
			CharacterMoveComponent characterMoveComponent;
			if (characterActorComponent == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			if (characterMoveComponent2 != null)
			{
				Vector inB = Vector.Create(this.CurrentWaterNormal.X, this.CurrentWaterNormal.Y, -this.CurrentWaterNormal.Z);
				if (characterMoveComponent2.GravityDirect.DotProduct(inB) < 0.20000000298023224)
				{
					return;
				}
				if (Math.Abs(characterMoveComponent2.GravityDirect.Z) < 0.8999999761581421)
				{
					return;
				}
			}
			if (this.IsMotorState && this.VehicleEffect != null)
			{
				return;
			}
			FName inSocketName = isLeftFoot ? CharacterFootEffectComponent.LeftFootSocketName : CharacterFootEffectComponent.RightFootSocketName;
			FVectorDouble fvectorDouble = mesh.D_GetSocketLocation(inSocketName);
			double num = this.CurrentWaterNormal.SizeSquared();
			double num2 = this.CurrentVelocity.X;
			double num3 = this.CurrentVelocity.Y;
			if (num > 9.99999993922529E-09)
			{
				double num4 = this.CurrentVelocity.DotProduct(this.CurrentWaterNormal) / num;
				num2 -= this.CurrentWaterNormal.X * num4;
				num3 -= this.CurrentWaterNormal.Y * num4;
			}
			double num5 = Math.Sqrt(num2 * num2 + num3 * num3);
			double num6 = (num5 > 9.99999993922529E-09) ? Math.Min(0.05, 50.0 / num5) : 0.0;
			Vector vector = Vector.Create(fvectorDouble.X + num2 * num6, fvectorDouble.Y + num3 * num6, this.CurrentWaterLocation.Z);
			FVectorDouble fvectorDouble2 = vector.ToUeVector(false);
			this.EmptyUeTransform.SetLocation(fvectorDouble2);
			fvectorDouble2 = this.CurrentWaterNormal.ToUeVector(false);
			FQuat fquat = UKismetMathLibrary.D_MakeRotFromZ(fvectorDouble2).Quaternion();
			this.EmptyUeTransform.SetRotation(fquat);
			string path = item.EffectDataPath.ToAssetPathName();
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
			instance.SpawnUnloopedEffect(world, ftransformDouble, path, "[SceneCharacterWaterEffect.TrySpawnShallowMoveFootSplash]", new EffectContext(null, owner, false), EEffectType.Scene, null, null, null, false, false);
			if (item.AudioEffectDataPath != null)
			{
				string text = item.AudioEffectDataPath.ToAssetPathName();
				if (!string.IsNullOrEmpty(text))
				{
					EffectSystem instance2 = EffectSystem.Instance;
					UObject world2 = GlobalData.World;
					ftransformDouble = new FTransformDouble?(this.EmptyUeTransform);
					instance2.SpawnUnloopedEffect(world2, ftransformDouble, text, "[SceneCharacterWaterEffect.TrySpawnShallowMoveFootSplash(Audio)]", null, EEffectType.Fight, null, null, null, false, false);
				}
			}
		}

		// Token: 0x0602E21F RID: 188959 RVA: 0x00AA8148 File Offset: 0x00AA6348
		private bool ShouldUseShallowFootSplashes(WaterEffectSubConfig subConfig, double depth)
		{
			if (Info.Instance.IsMobilePlatform() || !subConfig.ShouldUseShallowFootSplashes(depth))
			{
				return false;
			}
			FGameplayTagContainer shallowFallbackTag = subConfig.ShallowFallbackTag;
			if (shallowFallbackTag == null || shallowFallbackTag.GameplayTags.Num() == 0)
			{
				return true;
			}
			TsBaseCharacter owner = this.Owner;
			object obj;
			if (owner == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					obj = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
			}
			object obj2 = obj;
			return obj2 == null || !obj2.HasAnyTagContainer(shallowFallbackTag);
		}

		// Token: 0x0602E220 RID: 188960 RVA: 0x00AA81C8 File Offset: 0x00AA63C8
		private TraceHandle DetectShoreForFlyEffect(Vector shoreTraceLocation)
		{
			TsBaseCharacter owner = this.Owner;
			CharacterMoveComponent characterMoveComponent;
			if (owner == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterMoveComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
				}
			}
			CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
			Vector location = Vector.Create(-500.0 * characterMoveComponent2.GravityDirect.X + shoreTraceLocation.X, -500.0 * characterMoveComponent2.GravityDirect.Y + shoreTraceLocation.Y, -500.0 * characterMoveComponent2.GravityDirect.Z + shoreTraceLocation.Z);
			Vector location2 = Vector.Create(3000.0 * characterMoveComponent2.GravityDirect.X + shoreTraceLocation.X, 3000.0 * characterMoveComponent2.GravityDirect.Y + shoreTraceLocation.Y, 3000.0 * characterMoveComponent2.GravityDirect.Z + shoreTraceLocation.Z);
			TraceElementCommon.Instance.SetStartLocation(this.ShoreTraceElement, location);
			TraceElementCommon.Instance.SetEndLocation(this.ShoreTraceElement, location2);
			return TraceElementCommon.Instance.AsyncSphereTrace(this.ShoreTraceElement, "WaterEffect_ShoreTrace", this.ShoreTraceDelegate);
		}

		// Token: 0x0602E221 RID: 188961 RVA: 0x00AA82F4 File Offset: 0x00AA64F4
		[NullableContext(2)]
		private void SetShoreTraceState(bool hitResult, UTraceBaseElement element, double frame, double index)
		{
			if (this.ShoreTraceHandle != null && (double)this.ShoreTraceHandle.Frame > frame)
			{
				return;
			}
			if (this.ShoreTraceHandle != null && MathUtils.Instance.IsNearlyEqual((double)this.ShoreTraceHandle.Frame, frame, null) && (double)this.ShoreTraceHandle.Index > index)
			{
				return;
			}
			if (hitResult)
			{
				if (this.IsTracedShore)
				{
					Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.LLX, "LLX  TraceChange True to False", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.IsTracedShore = false;
				return;
			}
			if (!this.IsTracedShore)
			{
				Log.Instance.Info(ELogModule.RenderEffect, ELogAuthor.LLX, "LLX  TraceChange False to True", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.IsTracedShore = true;
		}

		// Token: 0x04018BDE RID: 101342
		private const int ONE_SECOND = 1000;

		// Token: 0x04018BDF RID: 101343
		private const float FLYEFFECT_VELOCITY_XY_OFFSET_SCALE = 0.3f;

		// Token: 0x04018BE0 RID: 101344
		private const float FLYEFFECT_VELOCITY_XY_OFFSET_SCALE_MOTOR = 0.15f;

		// Token: 0x04018BE1 RID: 101345
		private const float FLYEFFECT_RIPPLEWATER_XY_OFFSET_SCALE = 1.1f;

		// Token: 0x04018BE2 RID: 101346
		private const float FLYEFFECT_SHORE_TRACE_START_OFFSET = 500f;

		// Token: 0x04018BE3 RID: 101347
		private const float FLYEFFECT_SHORE_TRACE_END_OFFSET = -3000f;

		// Token: 0x04018BE4 RID: 101348
		private const float WATER_NORMAL_DOT_CHECK = 0.2f;

		// Token: 0x04018BE5 RID: 101349
		private const float MOTOR_EFFECT_SPEED_CLAMP = 100f;

		// Token: 0x04018BE6 RID: 101350
		private const double SHALLOW_SPLASH_VELOCITY_LEAD_TIME = 0.05;

		// Token: 0x04018BE7 RID: 101351
		private const double SHALLOW_SPLASH_MAX_FORWARD_OFFSET = 50.0;

		// Token: 0x04018BE8 RID: 101352
		private const string FLYWATER_MOTOR_SOARING = "/Game/Aki/Effect/EffectGroup/Common/Water/DA_Fx_Group_SI3_FlyWater_Gliding.DA_Fx_Group_SI3_FlyWater_Gliding";

		// Token: 0x04018BE9 RID: 101353
		[Nullable(2)]
		public PDA_WaterEffectConfigs_C Config;

		// Token: 0x04018BEA RID: 101354
		[Nullable(2)]
		public TsBaseCharacter Owner;

		// Token: 0x04018BEB RID: 101355
		[Nullable(2)]
		public CharacterUnifiedStateComponent OwnerStateComponent;

		// Token: 0x04018BEC RID: 101356
		protected float OwnerHeight;

		// Token: 0x04018BED RID: 101357
		public bool IsReady;

		// Token: 0x04018BEE RID: 101358
		protected EWaterEffectState State;

		// Token: 0x04018BEF RID: 101359
		[Nullable(2)]
		protected WaterEffectSubConfig CurrentSubConfig;

		// Token: 0x04018BF0 RID: 101360
		protected WaterEffectSubConfig InWaterSubConfig = new WaterEffectSubConfig();

		// Token: 0x04018BF1 RID: 101361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TSoftObjectPtr<UEffectModelBase> SwimIdleEffect;

		// Token: 0x04018BF2 RID: 101362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TSoftObjectPtr<UEffectModelBase> SwimNormalEffect;

		// Token: 0x04018BF3 RID: 101363
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TSoftObjectPtr<UEffectModelBase> SwimFastEffect;

		// Token: 0x04018BF4 RID: 101364
		protected Dictionary<UPhysicalMaterial, WaterEffectSubConfig> OnMaterialSubConfig = new Dictionary<UPhysicalMaterial, WaterEffectSubConfig>();

		// Token: 0x04018BF5 RID: 101365
		protected int Handle;

		// Token: 0x04018BF6 RID: 101366
		protected int AudioEffectHandle;

		// Token: 0x04018BF7 RID: 101367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TSoftObjectPtr<UEffectModelBase> HandlePath;

		// Token: 0x04018BF8 RID: 101368
		protected double CurrentSpeed;

		// Token: 0x04018BF9 RID: 101369
		protected Vector CurrentVelocity = Vector.Create();

		// Token: 0x04018BFA RID: 101370
		protected double WadeMoveSearchSpeed;

		// Token: 0x04018BFB RID: 101371
		protected Vector CurrentWaterLocation = Vector.Create();

		// Token: 0x04018BFC RID: 101372
		protected Vector CurrentWaterNormal = Vector.Create();

		// Token: 0x04018BFD RID: 101373
		protected double CurrentWaterDepth;

		// Token: 0x04018BFE RID: 101374
		protected VelocityHistoryCache VelocityHistory = new VelocityHistoryCache();

		// Token: 0x04018BFF RID: 101375
		protected float CurrentToWaterHeight;

		// Token: 0x04018C00 RID: 101376
		protected int FlyWaterHandle;

		// Token: 0x04018C01 RID: 101377
		protected string FlyWaterEffectPath = "";

		// Token: 0x04018C02 RID: 101378
		protected bool IsTraceWater;

		// Token: 0x04018C03 RID: 101379
		protected bool IsBlackWave;

		// Token: 0x04018C04 RID: 101380
		protected FTransformDouble EmptyUeTransform = new FTransformDouble();

		// Token: 0x04018C05 RID: 101381
		[Nullable(2)]
		protected BP_RippleSwim_C RippleSwim;

		// Token: 0x04018C06 RID: 101382
		[Nullable(2)]
		protected UTraceSphereElement ShoreTraceElement;

		// Token: 0x04018C07 RID: 101383
		[Nullable(2)]
		protected TraceHandle ShoreTraceHandle;

		// Token: 0x04018C08 RID: 101384
		[Nullable(2)]
		protected FAsyncTraceDelegate ShoreTraceDelegate;

		// Token: 0x04018C09 RID: 101385
		protected int ShoreTraceTicker;

		// Token: 0x04018C0A RID: 101386
		protected bool IsTracedShore;

		// Token: 0x04018C0B RID: 101387
		protected bool IsMotorState;

		// Token: 0x04018C0C RID: 101388
		protected bool FindNoWaterPhysicalMaterial;

		// Token: 0x04018C0D RID: 101389
		[Nullable(2)]
		protected FKuroEnviInteractionData EIData;

		// Token: 0x04018C0E RID: 101390
		[Nullable(2)]
		protected SceneCharacterVehicleEffect VehicleEffect;

		// Token: 0x04018C0F RID: 101391
		private const string WET_STATE_TAG_NAME = "TA.表现.角色.状态效果.湿身";

		// Token: 0x04018C10 RID: 101392
		private const string BLACK_RAIN_TAG_NAME = "TA.表现.角色.状态效果.下黑雨";

		// Token: 0x04018C11 RID: 101393
		private const string GLOBAL_SHADER_PARAMETERS_MPC_PATH = "/Game/Aki/Render/Data/MPC_GlobalShaderParameters.MPC_GlobalShaderParameters";

		// Token: 0x04018C12 RID: 101394
		private const string BLACK_RAIN_MPC_PARAM_NAME = "CharWetRenderBlackRainInt";

		// Token: 0x04018C13 RID: 101395
		[Nullable(2)]
		protected UKuroCharWetControllerComponent WetController;

		// Token: 0x04018C14 RID: 101396
		protected int WetStateTagId;

		// Token: 0x04018C15 RID: 101397
		protected bool LastWetStateTagActive;

		// Token: 0x04018C16 RID: 101398
		protected int BlackRainTagId;

		// Token: 0x04018C17 RID: 101399
		protected bool LastBlackRainActive;

		// Token: 0x04018C18 RID: 101400
		[Nullable(2)]
		protected UMaterialParameterCollection CharWetMPC;

		// Token: 0x04018C19 RID: 101401
		protected FName BlackRainParamName = FName.NAME_None;

		// Token: 0x04018C1A RID: 101402
		public bool IsEnabled;
	}
}

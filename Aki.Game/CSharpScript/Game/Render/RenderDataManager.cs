using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.DecalShadow;
using AkiClient.Game.Aki.Render.RuntimeBP.RenderData;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.LensFlare;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C1 RID: 17857
	[NullableContext(2)]
	[Nullable(0)]
	public class RenderDataManager : Singleton
	{
		// Token: 0x0602E0A3 RID: 188579 RVA: 0x00A9CBDC File Offset: 0x00A9ADDC
		private void OnGlobalFootstepMaterialChange(UPhysicalMaterial material)
		{
			this.GlobalFootstepMaterial = material;
			EventSystem.Instance.Emit<UPhysicalMaterial>(EEventName.OnGlobalFootstepMaterialChange, material);
		}

		// Token: 0x0602E0A4 RID: 188580 RVA: 0x00A9CBF8 File Offset: 0x00A9ADF8
		private void OnForbidWeatherStateChange(bool bForbidWeather)
		{
			this.ForbidWeather = bForbidWeather;
			WeatherModel.Instance.GetWorldWeatherActor().SetWeatherForbidden(bForbidWeather);
			EventSystem.Instance.Emit<bool>(EEventName.OnForbidWeatherStateChange, bForbidWeather);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "随机天气状态变化";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("状态", bForbidWeather ? "禁用" : "启用");
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602E0A5 RID: 188581 RVA: 0x00A9CC62 File Offset: 0x00A9AE62
		protected override bool OnInit()
		{
			this.Init();
			return true;
		}

		// Token: 0x0602E0A6 RID: 188582 RVA: 0x00A9CC6C File Offset: 0x00A9AE6C
		private void Init()
		{
			this.Valid = false;
			this.LoadAssets();
			this.PreviousCharacterPosition = global::Vector.Create();
			this.CurrentCharacterPosition = global::Vector.Create();
			this.PreviousCharacterPositionWithOffset = global::Vector.Create();
			this.CurrentCharacterPositionWithOffset = global::Vector.Create();
			this.CurrentCharacterWeaponPositionWithOffset = global::Vector.Create();
			this.CurrentCharacterForward = global::Vector.Create();
			this.CurrentCameraPosition = global::Vector.Create();
			this.CurrentCameraPositionWithOffset = global::Vector.Create();
			this.CurrentCameraForward = global::Vector.Create();
			this.TempColor = new FLinearColor?(new FLinearColor());
			this.WriteTimeToCollection = true;
			AKuroGlobalGI.BindEventGlobalFootstepMaterialUpdate(DelegateUtils.ToManualReleaseDelegate<FOnGlobalFootstepMaterialUpdateDelegate>(new Action<UPhysicalMaterial>(this.OnGlobalFootstepMaterialChange)));
			AKuroGlobalGI.BindEventForbidWeatherStateChanged(DelegateUtils.ToManualReleaseDelegate<FOnForbidWeatherStateChangedDelegate>(new Action<bool>(this.OnForbidWeatherStateChange)));
		}

		// Token: 0x0602E0A7 RID: 188583 RVA: 0x00A9CD2C File Offset: 0x00A9AF2C
		public float GetRainIntensity()
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				return UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalRainIntensity);
			}
			return 0f;
		}

		// Token: 0x0602E0A8 RID: 188584 RVA: 0x00A9CD58 File Offset: 0x00A9AF58
		public float GetSnowIntensity()
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				return UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalSnowIntensity);
			}
			return 0f;
		}

		// Token: 0x0602E0A9 RID: 188585 RVA: 0x00A9CD84 File Offset: 0x00A9AF84
		public float GetWindIntensity()
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				return UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalWindSpeed);
			}
			return 0f;
		}

		// Token: 0x0602E0AA RID: 188586 RVA: 0x00A9CDB0 File Offset: 0x00A9AFB0
		public void SetGrassAo(float strength)
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalGrassAO, strength);
			}
		}

		// Token: 0x0602E0AB RID: 188587 RVA: 0x00A9CDD8 File Offset: 0x00A9AFD8
		public global::Vector GetMainLightVector(UObject worldContextObject = null)
		{
			UObject uobject = worldContextObject ?? GlobalData.World;
			if (uobject != null && this.GlobalShaderParameters != null)
			{
				FLinearColor vectorParameterValue = UKismetMaterialLibrary.GetVectorParameterValue(uobject, this.GlobalShaderParameters, RenderConfig.GlobalMainLightVector);
				return global::Vector.Create((double)vectorParameterValue.R, (double)vectorParameterValue.G, (double)vectorParameterValue.B);
			}
			return null;
		}

		// Token: 0x0602E0AC RID: 188588 RVA: 0x00A9CE29 File Offset: 0x00A9B029
		public PDA_ModelLensFlareConfig_C GetGlobalLensFlareConfig()
		{
			if (!this.Valid)
			{
				return null;
			}
			return this.GlobalLensFlareConfig;
		}

		// Token: 0x0602E0AD RID: 188589 RVA: 0x00A9CE3B File Offset: 0x00A9B03B
		public PDA_DecalShadowConfig_C GetGlobalDecalShadowConfig()
		{
			if (!this.Valid)
			{
				return null;
			}
			return this.GlobalDecalShadowConfig;
		}

		// Token: 0x0602E0AE RID: 188590 RVA: 0x00A9CE4D File Offset: 0x00A9B04D
		public global::Vector GetCurrentCharacterPosition()
		{
			return this.CurrentCharacterPosition;
		}

		// Token: 0x0602E0AF RID: 188591 RVA: 0x00A9CE55 File Offset: 0x00A9B055
		public global::Vector GetPreviousCharacterPosition()
		{
			return this.PreviousCharacterPosition;
		}

		// Token: 0x0602E0B0 RID: 188592 RVA: 0x00A9CE5D File Offset: 0x00A9B05D
		public global::Vector GetCurrentCharacterPositionWithOffset()
		{
			return this.CurrentCharacterPositionWithOffset;
		}

		// Token: 0x0602E0B1 RID: 188593 RVA: 0x00A9CE65 File Offset: 0x00A9B065
		public global::Vector GetCurrentCharacterWeaponPositionWithOffset()
		{
			return this.CurrentCharacterWeaponPositionWithOffset;
		}

		// Token: 0x0602E0B2 RID: 188594 RVA: 0x00A9CE6D File Offset: 0x00A9B06D
		public global::Vector GetPreviousCharacterPositionWithOffset()
		{
			return this.PreviousCharacterPositionWithOffset;
		}

		// Token: 0x0602E0B3 RID: 188595 RVA: 0x00A9CE75 File Offset: 0x00A9B075
		public global::Vector GetCurrentCharacterForward()
		{
			return this.CurrentCharacterForward;
		}

		// Token: 0x0602E0B4 RID: 188596 RVA: 0x00A9CE7D File Offset: 0x00A9B07D
		public global::Vector GetCurrentCameraPosition()
		{
			return this.CurrentCameraPosition;
		}

		// Token: 0x0602E0B5 RID: 188597 RVA: 0x00A9CE85 File Offset: 0x00A9B085
		public global::Vector GetCurrentCameraPositionWithOffset()
		{
			return this.CurrentCameraPosition;
		}

		// Token: 0x0602E0B6 RID: 188598 RVA: 0x00A9CE8D File Offset: 0x00A9B08D
		public global::Vector GetCurrentCameraForward()
		{
			return this.CurrentCameraForward;
		}

		// Token: 0x0602E0B7 RID: 188599 RVA: 0x00A9CE95 File Offset: 0x00A9B095
		public UMaterialParameterCollection GetGlobalShaderParameters()
		{
			return this.GlobalShaderParameters;
		}

		// Token: 0x0602E0B8 RID: 188600 RVA: 0x00A9CE9D File Offset: 0x00A9B09D
		public UMaterialParameterCollection GetSceneInteractionMaterialParameterCollection()
		{
			return this.SceneInteractionMaterialParameterCollection;
		}

		// Token: 0x0602E0B9 RID: 188601 RVA: 0x00A9CEA5 File Offset: 0x00A9B0A5
		public UMaterialParameterCollection GetUiShowBrightnessMaterialParameterCollection()
		{
			return this.UiShowBrightnessMaterialParameterCollection;
		}

		// Token: 0x0602E0BA RID: 188602 RVA: 0x00A9CEAD File Offset: 0x00A9B0AD
		public UMaterialParameterCollection GetUiShowColorSettingMaterialParameterCollection()
		{
			return this.UiShowColorSettingMaterialParameterCollection;
		}

		// Token: 0x0602E0BB RID: 188603 RVA: 0x00A9CEB5 File Offset: 0x00A9B0B5
		public UMaterialParameterCollection GetEyesParameterMaterialParameterCollection()
		{
			return this.EyesParameterMaterialParameterCollection;
		}

		// Token: 0x0602E0BC RID: 188604 RVA: 0x00A9CEBD File Offset: 0x00A9B0BD
		public UMaterialParameterCollection GetGroundFogMaskMaterialParameterCollection()
		{
			return this.GroundFogMaskMaterialParameterCollection;
		}

		// Token: 0x0602E0BD RID: 188605 RVA: 0x00A9CEC5 File Offset: 0x00A9B0C5
		public UMaterialParameterCollection GetSceneCaptureParameterCollection()
		{
			return this.SceneCaptureParameterCollection;
		}

		// Token: 0x0602E0BE RID: 188606 RVA: 0x00A9CECD File Offset: 0x00A9B0CD
		public UMaterialParameterCollection GetMpcForGameplayParameterCollection()
		{
			return this.MpcForGameplayParameterCollection;
		}

		// Token: 0x0602E0BF RID: 188607 RVA: 0x00A9CED5 File Offset: 0x00A9B0D5
		public bool GetPlayerInGrass()
		{
			this.UpdateVoxelState();
			return this.PlayerInGrass;
		}

		// Token: 0x0602E0C0 RID: 188608 RVA: 0x00A9CEE3 File Offset: 0x00A9B0E3
		public bool GetPlayerInCave()
		{
			this.UpdateVoxelState();
			return this.PlayerInCave;
		}

		// Token: 0x0602E0C1 RID: 188609 RVA: 0x00A9CEF4 File Offset: 0x00A9B0F4
		private void UpdateVoxelState()
		{
			if (this.PlayerVoxelStateDirty)
			{
				AKuroGlobalGI akuroGlobalGI = UKuroRenderingRuntimeBPPluginBPLibrary.GetGlobalGIActor(GlobalData.World) as AKuroGlobalGI;
				if (akuroGlobalGI != null)
				{
					this.PlayerInGrass = akuroGlobalGI.bPlayerInGrass;
					this.PlayerInCave = akuroGlobalGI.bPlayerInCave;
					this.PlayerVoxelStateDirty = false;
				}
			}
		}

		// Token: 0x0602E0C2 RID: 188610 RVA: 0x00A9CF3B File Offset: 0x00A9B13B
		public double GetSceneTime()
		{
			return this.SceneTime;
		}

		// Token: 0x0602E0C3 RID: 188611 RVA: 0x00A9CF43 File Offset: 0x00A9B143
		public UPhysicalMaterial GetGlobalFootstepMaterial()
		{
			return this.GlobalFootstepMaterial;
		}

		// Token: 0x0602E0C4 RID: 188612 RVA: 0x00A9CF4B File Offset: 0x00A9B14B
		public UMaterialInterface GetEmptyMaterial()
		{
			return this.EmptyMaterial;
		}

		// Token: 0x0602E0C5 RID: 188613 RVA: 0x00A9CF53 File Offset: 0x00A9B153
		public void SetWriteTime(bool enable)
		{
			this.WriteTimeToCollection = enable;
		}

		// Token: 0x0602E0C6 RID: 188614 RVA: 0x00A9CF5C File Offset: 0x00A9B15C
		public void SetIsPlayerMale(bool isMale)
		{
			if (this.SceneInteractionMaterialParameterCollection != null && GlobalData.World != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.SceneInteractionMaterialParameterCollection, RenderConfig.IsPlayerMale, isMale ? 1f : 0f);
			}
		}

		// Token: 0x0602E0C7 RID: 188615 RVA: 0x00A9CF94 File Offset: 0x00A9B194
		public void TickForce(float delta)
		{
			if (!this.Valid)
			{
				return;
			}
			this.PlayerVoxelStateDirty = true;
			UWorld world = GlobalData.World;
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (characterCameraManager == null || !characterCameraManager.IsValid())
			{
				return;
			}
			FVectorDouble fvectorDouble = characterCameraManager.D_K2_GetActorLocation();
			FVector fvector = characterCameraManager.K2_GetActorLocation();
			FVector actorForwardVector = characterCameraManager.GetActorForwardVector();
			global::Vector currentCameraPosition = this.CurrentCameraPosition;
			if (currentCameraPosition != null)
			{
				currentCameraPosition.FromUeVector(fvectorDouble);
			}
			global::Vector currentCameraPositionWithOffset = this.CurrentCameraPositionWithOffset;
			if (currentCameraPositionWithOffset != null)
			{
				currentCameraPositionWithOffset.FromUeVector(fvector);
			}
			global::Vector currentCameraForward = this.CurrentCameraForward;
			if (currentCameraForward != null)
			{
				currentCameraForward.FromUeVector(actorForwardVector);
			}
			if (world != null && this.GlobalShaderParameters != null)
			{
				UObject worldContextObject = world;
				UMaterialParameterCollection globalShaderParameters = this.GlobalShaderParameters;
				FName globalCameraPosAndRadius = RenderConfig.GlobalCameraPosAndRadius;
				FLinearColor flinearColor = new FLinearColor(fvector.X, fvector.Y, fvector.Z, 0f);
				UKismetMaterialLibrary.SetVectorParameterValue(worldContextObject, globalShaderParameters, globalCameraPosAndRadius, flinearColor);
			}
			bool flag = Info.Instance.IsGameRunning() && (GlobalData.IsUiSceneOpen || GlobalData.IsUiSceneLoading);
			if (flag != this.IsInUiScene)
			{
				this.IsInUiScene = flag;
				this.OnUiSceneStateChange();
			}
		}

		// Token: 0x0602E0C8 RID: 188616 RVA: 0x00A9D094 File Offset: 0x00A9B294
		public void Tick(float delta)
		{
			if (!this.Valid)
			{
				return;
			}
			double audioParameters = (double)delta * TimeUtil.Instance.Millisecond;
			UWorld world = GlobalData.World;
			APawn pawnOrSpectator = Global.PawnOrSpectator;
			if (pawnOrSpectator == null || !pawnOrSpectator.IsValid())
			{
				return;
			}
			FVectorDouble fvectorDouble = pawnOrSpectator.D_K2_GetActorLocation();
			FVector fvector = pawnOrSpectator.K2_GetActorLocation();
			FVector actorForwardVector = pawnOrSpectator.GetActorForwardVector();
			TArray<UActorComponent> tarray = pawnOrSpectator.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			if (tarray.Num() > 0)
			{
				USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(0) as USkeletalMeshComponent;
				if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
				{
					goto IL_D3;
				}
				try
				{
					FName inSocketName = new FName("WeaponProp05");
					FVector socketLocation = uskeletalMeshComponent.GetSocketLocation(inSocketName);
					global::Vector currentCharacterWeaponPositionWithOffset = this.CurrentCharacterWeaponPositionWithOffset;
					if (currentCharacterWeaponPositionWithOffset != null)
					{
						currentCharacterWeaponPositionWithOffset.FromUeVector(socketLocation);
					}
					goto IL_D3;
				}
				catch
				{
					global::Vector currentCharacterWeaponPositionWithOffset2 = this.CurrentCharacterWeaponPositionWithOffset;
					if (currentCharacterWeaponPositionWithOffset2 != null)
					{
						currentCharacterWeaponPositionWithOffset2.FromUeVector(fvector);
					}
					goto IL_D3;
				}
			}
			global::Vector currentCharacterWeaponPositionWithOffset3 = this.CurrentCharacterWeaponPositionWithOffset;
			if (currentCharacterWeaponPositionWithOffset3 != null)
			{
				currentCharacterWeaponPositionWithOffset3.FromUeVector(fvector);
			}
			IL_D3:
			global::Vector previousCharacterPosition = this.PreviousCharacterPosition;
			if (previousCharacterPosition != null)
			{
				global::Vector currentCharacterPosition = this.CurrentCharacterPosition;
				double inX = (currentCharacterPosition != null) ? currentCharacterPosition.X : 0.0;
				global::Vector currentCharacterPosition2 = this.CurrentCharacterPosition;
				double inY = (currentCharacterPosition2 != null) ? currentCharacterPosition2.Y : 0.0;
				global::Vector currentCharacterPosition3 = this.CurrentCharacterPosition;
				previousCharacterPosition.Set(inX, inY, (currentCharacterPosition3 != null) ? currentCharacterPosition3.Z : 0.0);
			}
			global::Vector previousCharacterPositionWithOffset = this.PreviousCharacterPositionWithOffset;
			if (previousCharacterPositionWithOffset != null)
			{
				global::Vector currentCharacterPositionWithOffset = this.CurrentCharacterPositionWithOffset;
				double inX2 = (currentCharacterPositionWithOffset != null) ? currentCharacterPositionWithOffset.X : 0.0;
				global::Vector currentCharacterPositionWithOffset2 = this.CurrentCharacterPositionWithOffset;
				double inY2 = (currentCharacterPositionWithOffset2 != null) ? currentCharacterPositionWithOffset2.Y : 0.0;
				global::Vector currentCharacterPositionWithOffset3 = this.CurrentCharacterPositionWithOffset;
				previousCharacterPositionWithOffset.Set(inX2, inY2, (currentCharacterPositionWithOffset3 != null) ? currentCharacterPositionWithOffset3.Z : 0.0);
			}
			global::Vector currentCharacterPosition4 = this.CurrentCharacterPosition;
			if (currentCharacterPosition4 != null)
			{
				currentCharacterPosition4.FromUeVector(fvectorDouble);
			}
			global::Vector currentCharacterPositionWithOffset4 = this.CurrentCharacterPositionWithOffset;
			if (currentCharacterPositionWithOffset4 != null)
			{
				currentCharacterPositionWithOffset4.FromUeVector(fvector);
			}
			global::Vector currentCharacterForward = this.CurrentCharacterForward;
			if (currentCharacterForward != null)
			{
				currentCharacterForward.FromUeVector(actorForwardVector);
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterUnifiedStateComponent characterUnifiedStateComponent;
			if (baseCharacter == null)
			{
				characterUnifiedStateComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					characterUnifiedStateComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					characterUnifiedStateComponent = ((entity != null) ? entity.GetComponent<CharacterUnifiedStateComponent>() : null);
				}
			}
			CharacterUnifiedStateComponent characterUnifiedStateComponent2 = characterUnifiedStateComponent;
			this.CurrentPlayerMoveState = ((characterUnifiedStateComponent2 != null) ? new global::ECharMoveState?(characterUnifiedStateComponent2.MoveState) : null);
			bool flag;
			if (this.CurrentPlayerMoveState != null)
			{
				global::ECharMoveState? currentPlayerMoveState = this.CurrentPlayerMoveState;
				global::ECharMoveState echarMoveState = global::ECharMoveState.NormalClimb;
				flag = (currentPlayerMoveState.GetValueOrDefault() < echarMoveState & currentPlayerMoveState != null);
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (world != null && this.GlobalShaderParameters != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(world, this.GlobalShaderParameters, RenderConfig.GlobalCharacterOnGround, flag2 ? 1f : 0f);
			}
			this.SetTempColor(this.PreviousCharacterPositionWithOffset);
			if (world != null && this.GlobalShaderParameters != null && this.TempColor != null)
			{
				UObject worldContextObject = world;
				UMaterialParameterCollection globalShaderParameters = this.GlobalShaderParameters;
				FName globalCharacterPreviousWP = RenderConfig.GlobalCharacterPreviousWP;
				FLinearColor value = this.TempColor.Value;
				UKismetMaterialLibrary.SetVectorParameterValue(worldContextObject, globalShaderParameters, globalCharacterPreviousWP, value);
			}
			this.SetTempColor(this.CurrentCharacterForward);
			if (world != null && this.GlobalShaderParameters != null && this.TempColor != null)
			{
				UObject worldContextObject2 = world;
				UMaterialParameterCollection globalShaderParameters2 = this.GlobalShaderParameters;
				FName globalCharacterWorldForwardDirection = RenderConfig.GlobalCharacterWorldForwardDirection;
				FLinearColor value = this.TempColor.Value;
				UKismetMaterialLibrary.SetVectorParameterValue(worldContextObject2, globalShaderParameters2, globalCharacterWorldForwardDirection, value);
			}
			this.SetTempColor(this.CurrentCharacterWeaponPositionWithOffset);
			if (world != null && this.GlobalShaderParameters != null && this.TempColor != null)
			{
				UObject worldContextObject3 = world;
				UMaterialParameterCollection globalShaderParameters3 = this.GlobalShaderParameters;
				FName globalCharacterWeaponPosition = RenderConfig.GlobalCharacterWeaponPosition;
				FLinearColor value = this.TempColor.Value;
				UKismetMaterialLibrary.SetVectorParameterValue(worldContextObject3, globalShaderParameters3, globalCharacterWeaponPosition, value);
			}
			if (GameModeModel.Instance.InstanceType == InstanceType.BigWorldInstance)
			{
				this.SceneTime = TimeOfDayModel.Instance.GameTime.Minute;
			}
			if (this.WriteTimeToCollection)
			{
				int num = (int)Math.Floor(this.SceneTime / 60.0);
				if (world != null && this.GlobalShaderParameters != null)
				{
					UKismetMaterialLibrary.SetScalarParameterValue(world, this.GlobalShaderParameters, RenderConfig.GlobalTimeHour, (float)num);
					UKismetMaterialLibrary.SetScalarParameterValue(world, this.GlobalShaderParameters, RenderConfig.GlobalTimeMinutes, (float)this.SceneTime - (float)(num * 60));
				}
			}
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			BaseMoveComponent baseMoveComponent;
			if (baseCharacter2 == null)
			{
				baseMoveComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent2 = baseCharacter2.CharacterActorComponent;
				if (characterActorComponent2 == null)
				{
					baseMoveComponent = null;
				}
				else
				{
					Entity entity2 = characterActorComponent2.Entity;
					baseMoveComponent = ((entity2 != null) ? entity2.GetComponent<BaseMoveComponent>() : null);
				}
			}
			BaseMoveComponent baseMoveComponent2 = baseMoveComponent;
			if (baseMoveComponent2 != null)
			{
				global::Vector gravityDirect = baseMoveComponent2.GravityDirect;
				if (!gravityDirect.Equals(this.CachedGravityDirect, 9.999999747378752E-05))
				{
					this.SetTempColor(gravityDirect);
					if (world != null && this.GlobalShaderParameters != null && this.TempColor != null)
					{
						UObject worldContextObject4 = world;
						UMaterialParameterCollection globalShaderParameters4 = this.GlobalShaderParameters;
						FName gravityDirection = RenderConfig.GravityDirection;
						FLinearColor value = this.TempColor.Value;
						UKismetMaterialLibrary.SetVectorParameterValue(worldContextObject4, globalShaderParameters4, gravityDirection, value);
					}
					this.CachedGravityDirect.DeepCopy(gravityDirect);
				}
			}
			this.SetAudioParameters(audioParameters);
		}

		// Token: 0x0602E0C9 RID: 188617 RVA: 0x00A9D518 File Offset: 0x00A9B718
		protected void LoadAssets()
		{
			ResourceSystem.Instance.LoadAsync<PDA_GlobalRenderDataReference_C>("/Game/Aki/Render/Data/DA_GlobalRenderDataReference.DA_GlobalRenderDataReference", delegate([Nullable(2)] PDA_GlobalRenderDataReference_C result, string _)
			{
				if (result == null || !result.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "RenderDataManager缺失全局配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.Valid = true;
				this.GlobalShaderParameters = result.GlobalShaderParameters;
				UMaterialParameterCollection globalShaderParameters = this.GlobalShaderParameters;
				if (globalShaderParameters == null || !globalShaderParameters.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LJY, "缺失全局材质参数文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.SceneInteractionMaterialParameterCollection = result.SceneInteractionShaderParameters;
				UMaterialParameterCollection sceneInteractionMaterialParameterCollection = this.SceneInteractionMaterialParameterCollection;
				if (sceneInteractionMaterialParameterCollection == null || !sceneInteractionMaterialParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LJY, "缺失交互物着色器参数文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.GlobalLensFlareConfig = result.GlobalLensFlareConfig;
				PDA_ModelLensFlareConfig_C globalLensFlareConfig = this.GlobalLensFlareConfig;
				if (globalLensFlareConfig == null || !globalLensFlareConfig.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LJY, "缺失LensFlare配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.UiShowBrightnessMaterialParameterCollection = result.MPC_ShowBrightness;
				UMaterialParameterCollection uiShowBrightnessMaterialParameterCollection = this.UiShowBrightnessMaterialParameterCollection;
				if (uiShowBrightnessMaterialParameterCollection == null || !uiShowBrightnessMaterialParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LJY, "缺失UI_ShowBrightness配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.UiShowColorSettingMaterialParameterCollection = result.MPC_ShowColorSetting;
				UMaterialParameterCollection uiShowColorSettingMaterialParameterCollection = this.UiShowColorSettingMaterialParameterCollection;
				if (uiShowColorSettingMaterialParameterCollection == null || !uiShowColorSettingMaterialParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.HYF, "缺失UI_ShowColorSetting配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.GlobalDecalShadowConfig = result.DefaultDecalShadow;
				PDA_DecalShadowConfig_C globalDecalShadowConfig = this.GlobalDecalShadowConfig;
				if (globalDecalShadowConfig == null || !globalDecalShadowConfig.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "缺失DecalShadow配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.EyesParameterMaterialParameterCollection = result.EyesParameters;
				UMaterialParameterCollection eyesParameterMaterialParameterCollection = this.EyesParameterMaterialParameterCollection;
				if (eyesParameterMaterialParameterCollection == null || !eyesParameterMaterialParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "缺失EyesParameters配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.GroundFogMaskMaterialParameterCollection = result.MPC_GroundFogMask;
				UMaterialParameterCollection groundFogMaskMaterialParameterCollection = this.GroundFogMaskMaterialParameterCollection;
				if (groundFogMaskMaterialParameterCollection == null || !groundFogMaskMaterialParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.ZYL, "缺失GroundFogMask配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.EmptyMaterial = result.EmptyMaterial;
				UMaterialInterface emptyMaterial = this.EmptyMaterial;
				if (emptyMaterial == null || !emptyMaterial.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "缺失EmptyMaterial", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.SceneCaptureParameterCollection = result.MPC_SceneCaptureParameter;
				UMaterialParameterCollection sceneCaptureParameterCollection = this.SceneCaptureParameterCollection;
				if (sceneCaptureParameterCollection == null || !sceneCaptureParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "缺失SceneCaptureParameter配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.MpcForGameplayParameterCollection = result.MPC_ForGameplayParameter;
				UMaterialParameterCollection mpcForGameplayParameterCollection = this.MpcForGameplayParameterCollection;
				if (mpcForGameplayParameterCollection == null || !mpcForGameplayParameterCollection.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.WRY, "缺失MPC_ForGameplayParameter配置文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}, 100, "js_undefined");
		}

		// Token: 0x0602E0CA RID: 188618 RVA: 0x00A9D53D File Offset: 0x00A9B73D
		public void Destroy()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<UPhysicalMaterial>(this.OnGlobalFootstepMaterialChange));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool>(this.OnForbidWeatherStateChange));
		}

		// Token: 0x0602E0CB RID: 188619 RVA: 0x00A9D564 File Offset: 0x00A9B764
		protected void SetAudioParameters(double deltaSeconds)
		{
			this.AudioParameterUpdateCounter -= deltaSeconds;
			if (this.AudioParameterUpdateCounter > 0.0)
			{
				return;
			}
			this.AudioParameterUpdateCounter = 1.0;
			float rainIntensity = this.GetRainIntensity();
			float snowIntensity = this.GetSnowIntensity();
			float windIntensity = this.GetWindIntensity();
			if (!MathUtils.Instance.IsNearlyEqual((double)this.CachedAudioParameterRainIntensity, (double)rainIntensity, null))
			{
				AudioSystem.Instance.SetRtpcValue("amb_rain_intensity", rainIntensity / 5f, null);
				this.CachedAudioParameterRainIntensity = rainIntensity;
			}
			if (!MathUtils.Instance.IsNearlyEqual((double)this.CachedAudioParameterSnowIntensity, (double)snowIntensity, null))
			{
				AudioSystem.Instance.SetRtpcValue("amb_snow_intensity", snowIntensity / 5f, null);
				this.CachedAudioParameterSnowIntensity = snowIntensity;
			}
			if (!MathUtils.Instance.IsNearlyEqual((double)this.CachedAudioParameterWindIntensity, (double)windIntensity, null))
			{
				AudioSystem.Instance.SetRtpcValue("amb_wind_intensity", windIntensity / 10f, null);
				this.CachedAudioParameterWindIntensity = windIntensity;
			}
		}

		// Token: 0x0602E0CC RID: 188620 RVA: 0x00A9D684 File Offset: 0x00A9B884
		private void SetTempColor(global::Vector vector)
		{
			if (this.TempColor == null || vector == null)
			{
				return;
			}
			this.TempColor = new FLinearColor?(new FLinearColor((float)vector.X, (float)vector.Y, (float)vector.Z, this.TempColor.Value.A));
		}

		// Token: 0x0602E0CD RID: 188621 RVA: 0x00A9D6D7 File Offset: 0x00A9B8D7
		private void OnUiSceneStateChange()
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetClusteredStuffVisible(GlobalData.World, !this.IsInUiScene);
		}

		// Token: 0x1700759F RID: 30111
		// (get) Token: 0x0602E0CE RID: 188622 RVA: 0x00A9D6EC File Offset: 0x00A9B8EC
		[Nullable(1)]
		public static RenderDataManager Instance
		{
			[NullableContext(1)]
			get
			{
				if (RenderDataManager._instance == null)
				{
					RenderDataManager._instance = new RenderDataManager();
					RenderDataManager._instance.OnInit();
				}
				return RenderDataManager._instance;
			}
		}

		// Token: 0x0602E0CF RID: 188623 RVA: 0x00A9D70F File Offset: 0x00A9B90F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E0D0 RID: 188624 RVA: 0x00A9D711 File Offset: 0x00A9B911
		public static void ResetStaticDefaultValue()
		{
			RenderDataManager instance = RenderDataManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			RenderDataManager._instance = null;
		}

		// Token: 0x0602E0D1 RID: 188625 RVA: 0x00A9D72A File Offset: 0x00A9B92A
		static RenderDataManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderDataManager.CreateStaticDefaultValue), new Action(RenderDataManager.ResetStaticDefaultValue));
		}

		// Token: 0x04018A7D RID: 100989
		public bool Valid;

		// Token: 0x04018A7E RID: 100990
		protected UMaterialParameterCollection GlobalShaderParameters;

		// Token: 0x04018A7F RID: 100991
		protected UMaterialParameterCollection SceneInteractionMaterialParameterCollection;

		// Token: 0x04018A80 RID: 100992
		protected UMaterialParameterCollection UiShowBrightnessMaterialParameterCollection;

		// Token: 0x04018A81 RID: 100993
		protected UMaterialParameterCollection UiShowColorSettingMaterialParameterCollection;

		// Token: 0x04018A82 RID: 100994
		protected UMaterialParameterCollection EyesParameterMaterialParameterCollection;

		// Token: 0x04018A83 RID: 100995
		protected UMaterialParameterCollection GroundFogMaskMaterialParameterCollection;

		// Token: 0x04018A84 RID: 100996
		protected UMaterialParameterCollection SceneCaptureParameterCollection;

		// Token: 0x04018A85 RID: 100997
		protected UMaterialParameterCollection MpcForGameplayParameterCollection;

		// Token: 0x04018A86 RID: 100998
		protected PDA_ModelLensFlareConfig_C GlobalLensFlareConfig;

		// Token: 0x04018A87 RID: 100999
		protected PDA_DecalShadowConfig_C GlobalDecalShadowConfig;

		// Token: 0x04018A88 RID: 101000
		protected global::Vector PreviousCharacterPosition;

		// Token: 0x04018A89 RID: 101001
		protected global::Vector CurrentCharacterPosition;

		// Token: 0x04018A8A RID: 101002
		protected global::Vector PreviousCharacterPositionWithOffset;

		// Token: 0x04018A8B RID: 101003
		protected global::Vector CurrentCharacterPositionWithOffset;

		// Token: 0x04018A8C RID: 101004
		protected global::Vector CurrentCharacterWeaponPositionWithOffset;

		// Token: 0x04018A8D RID: 101005
		protected global::Vector CurrentCharacterForward;

		// Token: 0x04018A8E RID: 101006
		protected global::Vector CurrentCameraPosition;

		// Token: 0x04018A8F RID: 101007
		protected global::Vector CurrentCameraPositionWithOffset;

		// Token: 0x04018A90 RID: 101008
		protected global::Vector CurrentCameraForward;

		// Token: 0x04018A91 RID: 101009
		protected global::ECharMoveState? CurrentPlayerMoveState;

		// Token: 0x04018A92 RID: 101010
		protected double SceneTime;

		// Token: 0x04018A93 RID: 101011
		protected FLinearColor? TempColor;

		// Token: 0x04018A94 RID: 101012
		protected bool WriteTimeToCollection = true;

		// Token: 0x04018A95 RID: 101013
		protected bool IsInUiScene;

		// Token: 0x04018A96 RID: 101014
		protected UPhysicalMaterial GlobalFootstepMaterial;

		// Token: 0x04018A97 RID: 101015
		protected bool PlayerInGrass;

		// Token: 0x04018A98 RID: 101016
		protected UMaterialInterface EmptyMaterial;

		// Token: 0x04018A99 RID: 101017
		protected bool PlayerInCave;

		// Token: 0x04018A9A RID: 101018
		protected bool PlayerVoxelStateDirty = true;

		// Token: 0x04018A9B RID: 101019
		protected bool ForbidWeather;

		// Token: 0x04018A9C RID: 101020
		[Nullable(1)]
		protected global::Vector CachedGravityDirect = global::Vector.Create(0.0, 0.0, -1.0);

		// Token: 0x04018A9D RID: 101021
		private const int MinutesInHour = 60;

		// Token: 0x04018A9E RID: 101022
		private const float AudioParameterUpdateInterval = 1f;

		// Token: 0x04018A9F RID: 101023
		private double AudioParameterUpdateCounter;

		// Token: 0x04018AA0 RID: 101024
		private float CachedAudioParameterRainIntensity;

		// Token: 0x04018AA1 RID: 101025
		private float CachedAudioParameterSnowIntensity;

		// Token: 0x04018AA2 RID: 101026
		private float CachedAudioParameterWindIntensity;

		// Token: 0x04018AA3 RID: 101027
		private static RenderDataManager _instance;
	}
}

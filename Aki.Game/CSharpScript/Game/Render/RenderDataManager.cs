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
	// Token: 0x020034E9 RID: 13545
	[NullableContext(2)]
	[Nullable(0)]
	public class RenderDataManager : Singleton
	{
		// Token: 0x0602278D RID: 141197 RVA: 0x009C8E24 File Offset: 0x009C7024
		private void OnGlobalFootstepMaterialChange(UPhysicalMaterial material)
		{
			this.GlobalFootstepMaterial = material;
			EventSystem.Instance.Emit<UPhysicalMaterial>(EEventName.OnGlobalFootstepMaterialChange, material);
		}

		// Token: 0x0602278E RID: 141198 RVA: 0x009C8E40 File Offset: 0x009C7040
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

		// Token: 0x0602278F RID: 141199 RVA: 0x009C8EAC File Offset: 0x009C70AC
		public void SyncForbidWeather()
		{
			AKuroGlobalGI akuroGlobalGI = UKuroRenderingRuntimeBPPluginBPLibrary.GetGlobalGIActor(GlobalData.World) as AKuroGlobalGI;
			if (akuroGlobalGI == null)
			{
				return;
			}
			this.ForbidWeather = akuroGlobalGI.bForbidWeather;
			WeatherModel.Instance.GetWorldWeatherActor().SetWeatherForbiddenImmediately(this.ForbidWeather);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.LJ;
			string message = "切图同步随机天气状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("状态", this.ForbidWeather ? "禁用" : "启用");
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06022790 RID: 141200 RVA: 0x009C8F28 File Offset: 0x009C7128
		protected override bool OnInit()
		{
			this.Init();
			return true;
		}

		// Token: 0x06022791 RID: 141201 RVA: 0x009C8F34 File Offset: 0x009C7134
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

		// Token: 0x06022792 RID: 141202 RVA: 0x009C8FF4 File Offset: 0x009C71F4
		public float GetRainIntensity()
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				return UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalRainIntensity);
			}
			return 0f;
		}

		// Token: 0x06022793 RID: 141203 RVA: 0x009C9020 File Offset: 0x009C7220
		public float GetSnowIntensity()
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				return UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalSnowIntensity);
			}
			return 0f;
		}

		// Token: 0x06022794 RID: 141204 RVA: 0x009C904C File Offset: 0x009C724C
		public float GetWindIntensity()
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				return UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalWindSpeed);
			}
			return 0f;
		}

		// Token: 0x06022795 RID: 141205 RVA: 0x009C9078 File Offset: 0x009C7278
		public void SetGrassAo(float strength)
		{
			if (GlobalData.World != null && this.GlobalShaderParameters != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.GlobalShaderParameters, RenderConfig.GlobalGrassAO, strength);
			}
		}

		// Token: 0x06022796 RID: 141206 RVA: 0x009C90A0 File Offset: 0x009C72A0
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

		// Token: 0x06022797 RID: 141207 RVA: 0x009C90F1 File Offset: 0x009C72F1
		public PDA_ModelLensFlareConfig_C GetGlobalLensFlareConfig()
		{
			if (!this.Valid)
			{
				return null;
			}
			return this.GlobalLensFlareConfig;
		}

		// Token: 0x06022798 RID: 141208 RVA: 0x009C9103 File Offset: 0x009C7303
		public PDA_DecalShadowConfig_C GetGlobalDecalShadowConfig()
		{
			if (!this.Valid)
			{
				return null;
			}
			return this.GlobalDecalShadowConfig;
		}

		// Token: 0x06022799 RID: 141209 RVA: 0x009C9115 File Offset: 0x009C7315
		public global::Vector GetCurrentCharacterPosition()
		{
			return this.CurrentCharacterPosition;
		}

		// Token: 0x0602279A RID: 141210 RVA: 0x009C911D File Offset: 0x009C731D
		public global::Vector GetPreviousCharacterPosition()
		{
			return this.PreviousCharacterPosition;
		}

		// Token: 0x0602279B RID: 141211 RVA: 0x009C9125 File Offset: 0x009C7325
		public global::Vector GetCurrentCharacterPositionWithOffset()
		{
			return this.CurrentCharacterPositionWithOffset;
		}

		// Token: 0x0602279C RID: 141212 RVA: 0x009C912D File Offset: 0x009C732D
		public global::Vector GetCurrentCharacterWeaponPositionWithOffset()
		{
			return this.CurrentCharacterWeaponPositionWithOffset;
		}

		// Token: 0x0602279D RID: 141213 RVA: 0x009C9135 File Offset: 0x009C7335
		public global::Vector GetPreviousCharacterPositionWithOffset()
		{
			return this.PreviousCharacterPositionWithOffset;
		}

		// Token: 0x0602279E RID: 141214 RVA: 0x009C913D File Offset: 0x009C733D
		public global::Vector GetCurrentCharacterForward()
		{
			return this.CurrentCharacterForward;
		}

		// Token: 0x0602279F RID: 141215 RVA: 0x009C9145 File Offset: 0x009C7345
		public global::Vector GetCurrentCameraPosition()
		{
			return this.CurrentCameraPosition;
		}

		// Token: 0x060227A0 RID: 141216 RVA: 0x009C914D File Offset: 0x009C734D
		public global::Vector GetCurrentCameraPositionWithOffset()
		{
			return this.CurrentCameraPosition;
		}

		// Token: 0x060227A1 RID: 141217 RVA: 0x009C9155 File Offset: 0x009C7355
		public global::Vector GetCurrentCameraForward()
		{
			return this.CurrentCameraForward;
		}

		// Token: 0x060227A2 RID: 141218 RVA: 0x009C915D File Offset: 0x009C735D
		public UMaterialParameterCollection GetGlobalShaderParameters()
		{
			return this.GlobalShaderParameters;
		}

		// Token: 0x060227A3 RID: 141219 RVA: 0x009C9165 File Offset: 0x009C7365
		public UMaterialParameterCollection GetSceneInteractionMaterialParameterCollection()
		{
			return this.SceneInteractionMaterialParameterCollection;
		}

		// Token: 0x060227A4 RID: 141220 RVA: 0x009C916D File Offset: 0x009C736D
		public UMaterialParameterCollection GetUiShowBrightnessMaterialParameterCollection()
		{
			return this.UiShowBrightnessMaterialParameterCollection;
		}

		// Token: 0x060227A5 RID: 141221 RVA: 0x009C9175 File Offset: 0x009C7375
		public UMaterialParameterCollection GetUiShowColorSettingMaterialParameterCollection()
		{
			return this.UiShowColorSettingMaterialParameterCollection;
		}

		// Token: 0x060227A6 RID: 141222 RVA: 0x009C917D File Offset: 0x009C737D
		public UMaterialParameterCollection GetEyesParameterMaterialParameterCollection()
		{
			return this.EyesParameterMaterialParameterCollection;
		}

		// Token: 0x060227A7 RID: 141223 RVA: 0x009C9185 File Offset: 0x009C7385
		public UMaterialParameterCollection GetGroundFogMaskMaterialParameterCollection()
		{
			return this.GroundFogMaskMaterialParameterCollection;
		}

		// Token: 0x060227A8 RID: 141224 RVA: 0x009C918D File Offset: 0x009C738D
		public UMaterialParameterCollection GetSceneCaptureParameterCollection()
		{
			return this.SceneCaptureParameterCollection;
		}

		// Token: 0x060227A9 RID: 141225 RVA: 0x009C9195 File Offset: 0x009C7395
		public UMaterialParameterCollection GetMpcForGameplayParameterCollection()
		{
			return this.MpcForGameplayParameterCollection;
		}

		// Token: 0x060227AA RID: 141226 RVA: 0x009C919D File Offset: 0x009C739D
		public bool GetPlayerInGrass()
		{
			this.UpdateVoxelState();
			return this.PlayerInGrass;
		}

		// Token: 0x060227AB RID: 141227 RVA: 0x009C91AB File Offset: 0x009C73AB
		public bool GetPlayerInCave()
		{
			this.UpdateVoxelState();
			return this.PlayerInCave;
		}

		// Token: 0x060227AC RID: 141228 RVA: 0x009C91BC File Offset: 0x009C73BC
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

		// Token: 0x060227AD RID: 141229 RVA: 0x009C9203 File Offset: 0x009C7403
		public double GetSceneTime()
		{
			return this.SceneTime;
		}

		// Token: 0x060227AE RID: 141230 RVA: 0x009C920B File Offset: 0x009C740B
		public UPhysicalMaterial GetGlobalFootstepMaterial()
		{
			return this.GlobalFootstepMaterial;
		}

		// Token: 0x060227AF RID: 141231 RVA: 0x009C9213 File Offset: 0x009C7413
		public UMaterialInterface GetEmptyMaterial()
		{
			return this.EmptyMaterial;
		}

		// Token: 0x060227B0 RID: 141232 RVA: 0x009C921B File Offset: 0x009C741B
		public void SetWriteTime(bool enable)
		{
			this.WriteTimeToCollection = enable;
		}

		// Token: 0x060227B1 RID: 141233 RVA: 0x009C9224 File Offset: 0x009C7424
		public void SetIsPlayerMale(bool isMale)
		{
			if (this.SceneInteractionMaterialParameterCollection != null && GlobalData.World != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.SceneInteractionMaterialParameterCollection, RenderConfig.IsPlayerMale, isMale ? 1f : 0f);
			}
		}

		// Token: 0x060227B2 RID: 141234 RVA: 0x009C925C File Offset: 0x009C745C
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

		// Token: 0x060227B3 RID: 141235 RVA: 0x009C935C File Offset: 0x009C755C
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

		// Token: 0x060227B4 RID: 141236 RVA: 0x009C97E0 File Offset: 0x009C79E0
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

		// Token: 0x060227B5 RID: 141237 RVA: 0x009C9805 File Offset: 0x009C7A05
		public void Destroy()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<UPhysicalMaterial>(this.OnGlobalFootstepMaterialChange));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool>(this.OnForbidWeatherStateChange));
		}

		// Token: 0x060227B6 RID: 141238 RVA: 0x009C982C File Offset: 0x009C7A2C
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

		// Token: 0x060227B7 RID: 141239 RVA: 0x009C994C File Offset: 0x009C7B4C
		private void SetTempColor(global::Vector vector)
		{
			if (this.TempColor == null || vector == null)
			{
				return;
			}
			this.TempColor = new FLinearColor?(new FLinearColor((float)vector.X, (float)vector.Y, (float)vector.Z, this.TempColor.Value.A));
		}

		// Token: 0x060227B8 RID: 141240 RVA: 0x009C999F File Offset: 0x009C7B9F
		private void OnUiSceneStateChange()
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetClusteredStuffVisible(GlobalData.World, !this.IsInUiScene);
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x060227B9 RID: 141241 RVA: 0x009C99B4 File Offset: 0x009C7BB4
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

		// Token: 0x060227BA RID: 141242 RVA: 0x009C99D7 File Offset: 0x009C7BD7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060227BB RID: 141243 RVA: 0x009C99D9 File Offset: 0x009C7BD9
		public static void ResetStaticDefaultValue()
		{
			RenderDataManager instance = RenderDataManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			RenderDataManager._instance = null;
		}

		// Token: 0x060227BC RID: 141244 RVA: 0x009C99F2 File Offset: 0x009C7BF2
		static RenderDataManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderDataManager.CreateStaticDefaultValue), new Action(RenderDataManager.ResetStaticDefaultValue));
		}

		// Token: 0x040130B8 RID: 78008
		public bool Valid;

		// Token: 0x040130B9 RID: 78009
		protected UMaterialParameterCollection GlobalShaderParameters;

		// Token: 0x040130BA RID: 78010
		protected UMaterialParameterCollection SceneInteractionMaterialParameterCollection;

		// Token: 0x040130BB RID: 78011
		protected UMaterialParameterCollection UiShowBrightnessMaterialParameterCollection;

		// Token: 0x040130BC RID: 78012
		protected UMaterialParameterCollection UiShowColorSettingMaterialParameterCollection;

		// Token: 0x040130BD RID: 78013
		protected UMaterialParameterCollection EyesParameterMaterialParameterCollection;

		// Token: 0x040130BE RID: 78014
		protected UMaterialParameterCollection GroundFogMaskMaterialParameterCollection;

		// Token: 0x040130BF RID: 78015
		protected UMaterialParameterCollection SceneCaptureParameterCollection;

		// Token: 0x040130C0 RID: 78016
		protected UMaterialParameterCollection MpcForGameplayParameterCollection;

		// Token: 0x040130C1 RID: 78017
		protected PDA_ModelLensFlareConfig_C GlobalLensFlareConfig;

		// Token: 0x040130C2 RID: 78018
		protected PDA_DecalShadowConfig_C GlobalDecalShadowConfig;

		// Token: 0x040130C3 RID: 78019
		protected global::Vector PreviousCharacterPosition;

		// Token: 0x040130C4 RID: 78020
		protected global::Vector CurrentCharacterPosition;

		// Token: 0x040130C5 RID: 78021
		protected global::Vector PreviousCharacterPositionWithOffset;

		// Token: 0x040130C6 RID: 78022
		protected global::Vector CurrentCharacterPositionWithOffset;

		// Token: 0x040130C7 RID: 78023
		protected global::Vector CurrentCharacterWeaponPositionWithOffset;

		// Token: 0x040130C8 RID: 78024
		protected global::Vector CurrentCharacterForward;

		// Token: 0x040130C9 RID: 78025
		protected global::Vector CurrentCameraPosition;

		// Token: 0x040130CA RID: 78026
		protected global::Vector CurrentCameraPositionWithOffset;

		// Token: 0x040130CB RID: 78027
		protected global::Vector CurrentCameraForward;

		// Token: 0x040130CC RID: 78028
		protected global::ECharMoveState? CurrentPlayerMoveState;

		// Token: 0x040130CD RID: 78029
		protected double SceneTime;

		// Token: 0x040130CE RID: 78030
		protected FLinearColor? TempColor;

		// Token: 0x040130CF RID: 78031
		protected bool WriteTimeToCollection = true;

		// Token: 0x040130D0 RID: 78032
		protected bool IsInUiScene;

		// Token: 0x040130D1 RID: 78033
		protected UPhysicalMaterial GlobalFootstepMaterial;

		// Token: 0x040130D2 RID: 78034
		protected bool PlayerInGrass;

		// Token: 0x040130D3 RID: 78035
		protected UMaterialInterface EmptyMaterial;

		// Token: 0x040130D4 RID: 78036
		protected bool PlayerInCave;

		// Token: 0x040130D5 RID: 78037
		protected bool PlayerVoxelStateDirty = true;

		// Token: 0x040130D6 RID: 78038
		protected bool ForbidWeather;

		// Token: 0x040130D7 RID: 78039
		[Nullable(1)]
		protected global::Vector CachedGravityDirect = global::Vector.Create(0.0, 0.0, -1.0);

		// Token: 0x040130D8 RID: 78040
		private const int MinutesInHour = 60;

		// Token: 0x040130D9 RID: 78041
		private const float AudioParameterUpdateInterval = 1f;

		// Token: 0x040130DA RID: 78042
		private double AudioParameterUpdateCounter;

		// Token: 0x040130DB RID: 78043
		private float CachedAudioParameterRainIntensity;

		// Token: 0x040130DC RID: 78044
		private float CachedAudioParameterSnowIntensity;

		// Token: 0x040130DD RID: 78045
		private float CachedAudioParameterWindIntensity;

		// Token: 0x040130DE RID: 78046
		private static RenderDataManager _instance;
	}
}

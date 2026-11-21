using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006484 RID: 25732
	[NullableContext(2)]
	[Nullable(0)]
	public class PhotoCamera : ISpecialGameplayCamera, IPhotoCameraHost
	{
		// Token: 0x17007700 RID: 30464
		// (get) Token: 0x0603E865 RID: 256101 RVA: 0x0123411A File Offset: 0x0123231A
		// (set) Token: 0x0603E866 RID: 256102 RVA: 0x01234122 File Offset: 0x01232322
		public bool IsDebugEnable { get; private set; }

		// Token: 0x17007701 RID: 30465
		// (get) Token: 0x0603E867 RID: 256103 RVA: 0x0123412B File Offset: 0x0123232B
		[Nullable(1)]
		public VirtualPhotoCamera VirtualCamera { [NullableContext(1)] get; } = new VirtualPhotoCamera();

		// Token: 0x17007702 RID: 30466
		// (get) Token: 0x0603E868 RID: 256104 RVA: 0x01234133 File Offset: 0x01232333
		public ACameraActor CameraActor
		{
			get
			{
				return this.CameraActorInternal;
			}
		}

		// Token: 0x17007703 RID: 30467
		// (get) Token: 0x0603E869 RID: 256105 RVA: 0x0123413B File Offset: 0x0123233B
		public CameraModelInstance CameraModel
		{
			get
			{
				return this.CameraModelInternal;
			}
		}

		// Token: 0x17007704 RID: 30468
		// (get) Token: 0x0603E86A RID: 256106 RVA: 0x01234143 File Offset: 0x01232343
		public TsBaseCharacter Character
		{
			get
			{
				return this.CharacterInternal;
			}
		}

		// Token: 0x17007705 RID: 30469
		// (get) Token: 0x0603E86B RID: 256107 RVA: 0x0123414B File Offset: 0x0123234B
		public PhotoCameraType? DefaultMode
		{
			get
			{
				return this.DefaultModeInternal;
			}
		}

		// Token: 0x17007706 RID: 30470
		// (get) Token: 0x0603E86C RID: 256108 RVA: 0x01234153 File Offset: 0x01232353
		public PhotoCameraType? CurrentMode
		{
			get
			{
				return this.CurrentModeInternal;
			}
		}

		// Token: 0x17007707 RID: 30471
		// (get) Token: 0x0603E86D RID: 256109 RVA: 0x0123415B File Offset: 0x0123235B
		public BP_PhotoCameraConfig_C CurrentConfig
		{
			get
			{
				return this.CurrentConfigInternal;
			}
		}

		// Token: 0x17007708 RID: 30472
		// (get) Token: 0x0603E86E RID: 256110 RVA: 0x01234163 File Offset: 0x01232363
		public PhotoCameraLensState PendingLens
		{
			get
			{
				return this.PendingLensInternal;
			}
		}

		// Token: 0x17007709 RID: 30473
		// (get) Token: 0x0603E86F RID: 256111 RVA: 0x0123416B File Offset: 0x0123236B
		public PhotoCameraEntryPose InheritedEntryPose
		{
			get
			{
				return this.InheritedEntryPoseInternal;
			}
		}

		// Token: 0x1700770A RID: 30474
		// (get) Token: 0x0603E870 RID: 256112 RVA: 0x01234173 File Offset: 0x01232373
		public bool IsInheritMode
		{
			get
			{
				BP_PhotoCameraConfig_C currentConfigInternal = this.CurrentConfigInternal;
				return currentConfigInternal != null && currentConfigInternal.CommonConfig.IsInheritPrevModeCamera;
			}
		}

		// Token: 0x1700770B RID: 30475
		// (get) Token: 0x0603E871 RID: 256113 RVA: 0x0123418B File Offset: 0x0123238B
		public PhotoCameraType? InheritedFromMode
		{
			get
			{
				return this.InheritedFromModeInternal;
			}
		}

		// Token: 0x1700770C RID: 30476
		// (get) Token: 0x0603E872 RID: 256114 RVA: 0x01234193 File Offset: 0x01232393
		public global::Vector PendingInheritWorldLocation
		{
			get
			{
				if (!this.HasPendingInheritWorldLocation)
				{
					return null;
				}
				return this.PendingInheritWorldLocationInternal;
			}
		}

		// Token: 0x0603E873 RID: 256115 RVA: 0x012341A5 File Offset: 0x012323A5
		[NullableContext(1)]
		public void SetInheritedEntryPose(PhotoCameraEntryPose pose)
		{
			this.InheritedEntryPoseInternal = pose;
			this.HasPendingInheritWorldLocation = false;
		}

		// Token: 0x0603E874 RID: 256116 RVA: 0x012341B5 File Offset: 0x012323B5
		public void SetCharacter(TsBaseCharacter character)
		{
			this.CharacterInternal = character;
		}

		// Token: 0x0603E875 RID: 256117 RVA: 0x012341C0 File Offset: 0x012323C0
		public void ChangeCharacter(TsBaseCharacter character)
		{
			if (this.IsDestroyed || this.CharacterInternal == character)
			{
				return;
			}
			this.SetCharacterPhotoCameraInput(false);
			this.SetCharacterInvertMoveForward(false);
			this.SetCharacterInvertMoveRight(false);
			this.SetCharacterCameraDirection(false);
			this.CharacterInternal = character;
			this.SetCharacterPhotoCameraInput(true);
			if (this.CurrentModeInternal != null)
			{
				this.ApplyInputDistribute(this.CurrentModeInternal.Value);
			}
			this.DispatchCharacterChanged(character);
			this.RebuildConfigForCurrentBodyType();
		}

		// Token: 0x0603E876 RID: 256118 RVA: 0x01234234 File Offset: 0x01232434
		private void DispatchCharacterChanged(TsBaseCharacter character)
		{
			foreach (EPhotoCameraComponent key in this.TickOrder)
			{
				PhotoCameraComponentBase photoCameraComponentBase;
				if (this.Components.TryGetValue(key, out photoCameraComponentBase))
				{
					photoCameraComponentBase.CharacterChanged(character);
				}
			}
		}

		// Token: 0x0603E877 RID: 256119 RVA: 0x01234271 File Offset: 0x01232471
		public void SetPendingLens(PhotoCameraLensState lens)
		{
			this.PendingLensInternal = lens;
		}

		// Token: 0x0603E878 RID: 256120 RVA: 0x0123427A File Offset: 0x0123247A
		public void SetDefaultMode(PhotoCameraType mode)
		{
			this.DefaultModeInternal = new PhotoCameraType?(mode);
		}

		// Token: 0x0603E879 RID: 256121 RVA: 0x01234288 File Offset: 0x01232488
		[NullableContext(0)]
		[return: Nullable(2)]
		public T GetComponent<T>(EPhotoCameraComponent id) where T : PhotoCameraComponentBase
		{
			PhotoCameraComponentBase photoCameraComponentBase;
			if (!this.Components.TryGetValue(id, out photoCameraComponentBase))
			{
				return default(T);
			}
			return photoCameraComponentBase as T;
		}

		// Token: 0x0603E87A RID: 256122 RVA: 0x012342BA File Offset: 0x012324BA
		public bool ToggleDebug()
		{
			this.IsDebugEnable = !this.IsDebugEnable;
			return this.IsDebugEnable;
		}

		// Token: 0x0603E87B RID: 256123 RVA: 0x012342D4 File Offset: 0x012324D4
		[NullableContext(1)]
		public void OnInit(ACameraActor camera, CameraModelInstance cameraModel)
		{
			this.CameraActorInternal = camera;
			this.CameraModelInternal = cameraModel;
			this.RegisterComponent(new PhotoCameraLogicComponent());
			this.RegisterComponent(new PhotoCameraInputComponent());
			this.RegisterComponent(new PhotoCameraCollisionComponent());
			this.RegisterComponent(new PhotoCameraCharacterComponent());
			this.RegisterComponent(new PhotoCameraDisplayComponent());
			this.RegisterComponent(new PhotoCameraBlendComponent());
			this.RegisterComponent(new PhotoCameraDebugComponent());
			this.RegisterComponent(new PhotoCameraSelfieComponent());
			this.RegisterComponent(new PhotoCameraEffectComponent());
			foreach (PhotoCameraComponentBase photoCameraComponentBase in this.Components.Values)
			{
				photoCameraComponentBase.Activate();
			}
			this.SetCharacterPhotoCameraInput(true);
			this.EnableNearClip();
			if (this.DefaultModeInternal != null)
			{
				this.SwitchMode(this.DefaultModeInternal.Value, null).Forget<bool>();
			}
		}

		// Token: 0x0603E87C RID: 256124 RVA: 0x012343CC File Offset: 0x012325CC
		public void Update(float deltaTime)
		{
			foreach (EPhotoCameraComponent key in this.IsBlending ? this.BlendTickOrder : this.TickOrder)
			{
				PhotoCameraComponentBase photoCameraComponentBase;
				if (this.Components.TryGetValue(key, out photoCameraComponentBase))
				{
					photoCameraComponentBase.Tick(deltaTime);
				}
			}
			PhotoCameraComponentBase photoCameraComponentBase2;
			if (this.Components.TryGetValue(EPhotoCameraComponent.Effect, out photoCameraComponentBase2))
			{
				photoCameraComponentBase2.Tick(deltaTime);
			}
		}

		// Token: 0x0603E87D RID: 256125 RVA: 0x01234434 File Offset: 0x01232634
		public void OnDestroy()
		{
			this.IsDestroyed = true;
			this.IsBlending = false;
			this.DisableNearClip();
			this.SetCharacterPhotoCameraInput(false);
			this.SetCharacterInvertMoveForward(false);
			this.SetCharacterInvertMoveRight(false);
			this.SetCharacterCameraDirection(false);
			for (int i = this.TickOrder.Length - 1; i >= 0; i--)
			{
				PhotoCameraComponentBase photoCameraComponentBase;
				if (this.Components.TryGetValue(this.TickOrder[i], out photoCameraComponentBase))
				{
					photoCameraComponentBase.Destroy();
				}
			}
			PhotoCameraComponentBase photoCameraComponentBase2;
			if (this.Components.TryGetValue(EPhotoCameraComponent.Blend, out photoCameraComponentBase2))
			{
				photoCameraComponentBase2.Destroy();
			}
			PhotoCameraComponentBase photoCameraComponentBase3;
			if (this.Components.TryGetValue(EPhotoCameraComponent.Effect, out photoCameraComponentBase3))
			{
				photoCameraComponentBase3.Destroy();
			}
			this.Components.Clear();
			this.CameraActorInternal = null;
			this.CameraModelInternal = null;
			this.CharacterInternal = null;
			this.DefaultModeInternal = null;
			this.PendingLensInternal = null;
			this.InheritedEntryPoseInternal = null;
			this.HasPendingInheritWorldLocation = false;
			this.CurrentModeInternal = null;
			this.AppliedBodyType = EPhotoCameraBodyType.None;
			this.SourceConfigInternal = null;
			this.CurrentConfigInternal = null;
			this.IsModeLoading = false;
			this.ModeChangedCallback = null;
			this.ConfigLoadRequestId = 0;
			this.OnTiltRollChanged = null;
			this.OnTemplateDepthOfFieldChanged = null;
			this.IsDebugEnable = false;
		}

		// Token: 0x0603E87E RID: 256126 RVA: 0x0123455C File Offset: 0x0123275C
		[NullableContext(1)]
		private void RegisterComponent(PhotoCameraComponentBase component)
		{
			EPhotoCameraComponent id = PhotoCameraComponentBase.GetId(component.GetType());
			this.Components[id] = component;
			component.Init(this);
		}

		// Token: 0x0603E87F RID: 256127 RVA: 0x0123458C File Offset: 0x0123278C
		private void EnableNearClip()
		{
			this.DisableNearClip();
			this.NearClipId = CameraNearClipController.Instance.EnableAbsoluteNearClip(250, ConfigCommonParamById.GetFloatConfig("PhotoCameraNearClipPlane").GetValueOrDefault(2f));
		}

		// Token: 0x0603E880 RID: 256128 RVA: 0x012345CB File Offset: 0x012327CB
		private void DisableNearClip()
		{
			if (this.NearClipId <= 0)
			{
				return;
			}
			CameraNearClipController.Instance.DisableCameraNearClip(this.NearClipId);
			this.NearClipId = 0;
		}

		// Token: 0x0603E881 RID: 256129 RVA: 0x012345EE File Offset: 0x012327EE
		private void SetCharacterPhotoCameraInput(bool active)
		{
			TsBaseCharacter characterInternal = this.CharacterInternal;
			if (characterInternal == null)
			{
				return;
			}
			Entity entityNoBlueprint = characterInternal.GetEntityNoBlueprint();
			if (entityNoBlueprint == null)
			{
				return;
			}
			CharacterInputComponent component = entityNoBlueprint.GetComponent<CharacterInputComponent>();
			if (component == null)
			{
				return;
			}
			component.SetUseActorRelativeMoveInput(active);
		}

		// Token: 0x0603E882 RID: 256130 RVA: 0x01234615 File Offset: 0x01232815
		private void SetCharacterInvertMoveForward(bool invert)
		{
			TsBaseCharacter characterInternal = this.CharacterInternal;
			if (characterInternal == null)
			{
				return;
			}
			Entity entityNoBlueprint = characterInternal.GetEntityNoBlueprint();
			if (entityNoBlueprint == null)
			{
				return;
			}
			CharacterInputComponent component = entityNoBlueprint.GetComponent<CharacterInputComponent>();
			if (component == null)
			{
				return;
			}
			component.SetInvertMoveForward(invert);
		}

		// Token: 0x0603E883 RID: 256131 RVA: 0x0123463C File Offset: 0x0123283C
		private void SetCharacterInvertMoveRight(bool invert)
		{
			TsBaseCharacter characterInternal = this.CharacterInternal;
			if (characterInternal == null)
			{
				return;
			}
			Entity entityNoBlueprint = characterInternal.GetEntityNoBlueprint();
			if (entityNoBlueprint == null)
			{
				return;
			}
			CharacterInputComponent component = entityNoBlueprint.GetComponent<CharacterInputComponent>();
			if (component == null)
			{
				return;
			}
			component.SetInvertMoveRight(invert);
		}

		// Token: 0x0603E884 RID: 256132 RVA: 0x01234664 File Offset: 0x01232864
		private void SetCharacterCameraDirection(bool active)
		{
			TsBaseCharacter characterInternal = this.CharacterInternal;
			CharacterUnifiedStateComponent characterUnifiedStateComponent;
			if (characterInternal == null)
			{
				characterUnifiedStateComponent = null;
			}
			else
			{
				Entity entityNoBlueprint = characterInternal.GetEntityNoBlueprint();
				characterUnifiedStateComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterUnifiedStateComponent>() : null);
			}
			CharacterUnifiedStateComponent characterUnifiedStateComponent2 = characterUnifiedStateComponent;
			if (characterUnifiedStateComponent2 == null)
			{
				this.IsCameraDirectionApplied = false;
				return;
			}
			if (active)
			{
				if (this.IsCameraDirectionApplied || characterUnifiedStateComponent2.DirectionState == ECharDirectionState.CameraDirection)
				{
					return;
				}
				this.PrevDirectionState = characterUnifiedStateComponent2.DirectionState;
				characterUnifiedStateComponent2.SetDirectionState(ECharDirectionState.CameraDirection);
				this.IsCameraDirectionApplied = true;
				return;
			}
			else
			{
				if (!this.IsCameraDirectionApplied)
				{
					return;
				}
				this.IsCameraDirectionApplied = false;
				if (characterUnifiedStateComponent2.DirectionState == ECharDirectionState.CameraDirection)
				{
					characterUnifiedStateComponent2.SetDirectionState(this.PrevDirectionState);
				}
				return;
			}
		}

		// Token: 0x0603E885 RID: 256133 RVA: 0x012346F0 File Offset: 0x012328F0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_PhotoCameraConfig_C> LoadConfig(PhotoCameraType mode)
		{
			PhotoCamera.<LoadConfig>d__75 <LoadConfig>d__;
			<LoadConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_PhotoCameraConfig_C>.Create();
			<LoadConfig>d__.<>4__this = this;
			<LoadConfig>d__.mode = mode;
			<LoadConfig>d__.<>1__state = -1;
			<LoadConfig>d__.<>t__builder.Start<PhotoCamera.<LoadConfig>d__75>(ref <LoadConfig>d__);
			return <LoadConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0603E886 RID: 256134 RVA: 0x0123473C File Offset: 0x0123293C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_PhotoCameraConfig_C> LoadConfigByPath(string path)
		{
			PhotoCamera.<LoadConfigByPath>d__76 <LoadConfigByPath>d__;
			<LoadConfigByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_PhotoCameraConfig_C>.Create();
			<LoadConfigByPath>d__.path = path;
			<LoadConfigByPath>d__.<>1__state = -1;
			<LoadConfigByPath>d__.<>t__builder.Start<PhotoCamera.<LoadConfigByPath>d__76>(ref <LoadConfigByPath>d__);
			return <LoadConfigByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0603E887 RID: 256135 RVA: 0x01234780 File Offset: 0x01232980
		[NullableContext(1)]
		private static BP_PhotoCameraConfig_C CloneConfig(BP_PhotoCameraConfig_C source)
		{
			BP_PhotoCameraConfig_C bp_PhotoCameraConfig_C = UE.NewObject<BP_PhotoCameraConfig_C>(GlobalData.World, null, EObjectFlags.RF_NoFlags);
			bp_PhotoCameraConfig_C.Type = source.Type;
			bp_PhotoCameraConfig_C.CommonConfig = source.CommonConfig;
			bp_PhotoCameraConfig_C.MoveConfig = source.MoveConfig;
			bp_PhotoCameraConfig_C.SelfieIkConfig = source.SelfieIkConfig;
			bp_PhotoCameraConfig_C.CompositionConfig = source.CompositionConfig;
			bp_PhotoCameraConfig_C.IsTemplate = source.IsTemplate;
			bp_PhotoCameraConfig_C.IsOpenDebugChangeConfigPreview = source.IsOpenDebugChangeConfigPreview;
			bp_PhotoCameraConfig_C.CharacterMoveSpeed = source.CharacterMoveSpeed;
			bp_PhotoCameraConfig_C.Tags = source.Tags;
			bp_PhotoCameraConfig_C.NeedLeaveSitDownBeforeEnter = source.NeedLeaveSitDownBeforeEnter;
			return bp_PhotoCameraConfig_C;
		}

		// Token: 0x0603E888 RID: 256136 RVA: 0x01234814 File Offset: 0x01232A14
		private EMorphType GetCurrentMorphType()
		{
			TsBaseCharacter characterInternal = this.CharacterInternal;
			EMorphType? emorphType;
			if (characterInternal == null)
			{
				emorphType = null;
			}
			else
			{
				Entity entityNoBlueprint = characterInternal.GetEntityNoBlueprint();
				if (entityNoBlueprint == null)
				{
					emorphType = null;
				}
				else
				{
					CharacterMorphComponent component = entityNoBlueprint.GetComponent<CharacterMorphComponent>();
					emorphType = ((component != null) ? new EMorphType?(component.GetMorphType()) : null);
				}
			}
			EMorphType? emorphType2 = emorphType;
			return emorphType2.GetValueOrDefault();
		}

		// Token: 0x0603E889 RID: 256137 RVA: 0x01234870 File Offset: 0x01232A70
		private EPhotoCameraBodyType GetCurrentBodyType()
		{
			TsBaseCharacter characterInternal = this.CharacterInternal;
			Entity entity = (characterInternal != null) ? characterInternal.GetEntityNoBlueprint() : null;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return EPhotoCameraBodyType.None;
			}
			return PhotoCameraUtil.GetBodyType(creatureDataComponent.GetRoleId(), this.GetCurrentMorphType());
		}

		// Token: 0x0603E88A RID: 256138 RVA: 0x012348B4 File Offset: 0x01232AB4
		private void ApplyBodyTypeDelta(BP_PhotoCameraConfig_C target, BP_PhotoCameraConfig_C deltaSource)
		{
			if (target == null || deltaSource == null)
			{
				return;
			}
			EPhotoCameraBodyType currentBodyType = this.GetCurrentBodyType();
			this.AppliedBodyType = currentBodyType;
			if (currentBodyType == EPhotoCameraBodyType.None)
			{
				return;
			}
			SPhotoCameraMorphDeltaConfig sphotoCameraMorphDeltaConfig;
			if (!deltaSource.BodyTypeDeltaConfig.TryGetValue(currentBodyType, out sphotoCameraMorphDeltaConfig) || sphotoCameraMorphDeltaConfig == null)
			{
				return;
			}
			PhotoCamera.ApplyCommonDelta(target.CommonConfig, sphotoCameraMorphDeltaConfig, currentBodyType);
			PhotoCamera.ApplyMoveDelta(target.MoveConfig, sphotoCameraMorphDeltaConfig);
		}

		// Token: 0x0603E88B RID: 256139 RVA: 0x01234914 File Offset: 0x01232B14
		private bool HasBodyTypeDelta(EPhotoCameraBodyType bodyType)
		{
			SPhotoCameraMorphDeltaConfig self;
			return bodyType != EPhotoCameraBodyType.None && this.SourceConfigInternal != null && this.SourceConfigInternal.BodyTypeDeltaConfig.TryGetValue(bodyType, out self) && self != null;
		}

		// Token: 0x0603E88C RID: 256140 RVA: 0x01234954 File Offset: 0x01232B54
		private void RebuildConfigForCurrentBodyType()
		{
			EPhotoCameraBodyType currentBodyType = this.GetCurrentBodyType();
			if (this.SourceConfigInternal == null || currentBodyType == this.AppliedBodyType)
			{
				return;
			}
			if (!this.HasBodyTypeDelta(this.AppliedBodyType) && !this.HasBodyTypeDelta(currentBodyType))
			{
				this.AppliedBodyType = currentBodyType;
				return;
			}
			this.CurrentConfigInternal = PhotoCamera.CloneConfig(this.SourceConfigInternal);
			this.ApplyBodyTypeDelta(this.CurrentConfigInternal, this.SourceConfigInternal);
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component != null)
			{
				component.RefreshFromCurrentConfig();
			}
			Action modeChangedCallback = this.ModeChangedCallback;
			if (modeChangedCallback == null)
			{
				return;
			}
			modeChangedCallback();
		}

		// Token: 0x0603E88D RID: 256141 RVA: 0x012349E0 File Offset: 0x01232BE0
		[NullableContext(1)]
		private static void ApplyCommonDelta(SPhotoCameraCommonConfig common, SPhotoCameraMorphDeltaConfig delta, EPhotoCameraBodyType bodyType)
		{
			if (!string.IsNullOrEmpty(delta.CenterLocationSocketNameOverride))
			{
				common.CenterLocationSocketName = delta.CenterLocationSocketNameOverride;
			}
			FVector fvector = common.InitCenterOffset;
			FVector fvector2 = delta.InitCenterOffsetDelta;
			common.InitCenterOffset = fvector + fvector2;
			fvector = common.InitPosition;
			fvector2 = delta.InitPositionDelta;
			common.InitPosition = fvector + fvector2;
			common.InitFocusDistance += delta.InitFocusDistanceDelta;
			common.InitAperture += delta.InitApertureDelta;
			fvector = common.InitRotation;
			fvector2 = delta.InitRotationDelta;
			FVector fvector3 = fvector + fvector2;
			common.InitRotation = new FVector(PhotoCamera.ClampInitAngle(fvector3.X, common.PitchRange, "Pitch", bodyType), PhotoCamera.ClampInitYaw(fvector3.Y, common.YawRange, bodyType), PhotoCamera.ClampInitAngle(fvector3.Z, common.RollRange, "Roll", bodyType));
		}

		// Token: 0x0603E88E RID: 256142 RVA: 0x01234ACC File Offset: 0x01232CCC
		[NullableContext(1)]
		private static void ApplyMoveDelta(SPhotoCameraMoveConfig move, SPhotoCameraMorphDeltaConfig delta)
		{
			FVector2D fvector2D = move.ForwardAndBackDistanceRange;
			FVector2D fvector2D2 = delta.ForwardAndBackDistanceRangeDelta;
			move.ForwardAndBackDistanceRange = fvector2D + fvector2D2;
			fvector2D = move.LeftAndRightDistanceRange;
			fvector2D2 = delta.LeftAndRightDistanceRangeDelta;
			move.LeftAndRightDistanceRange = fvector2D + fvector2D2;
			fvector2D = move.UpAndDownDistanceRange;
			fvector2D2 = delta.UpAndDownDistanceRangeDelta;
			move.UpAndDownDistanceRange = fvector2D + fvector2D2;
		}

		// Token: 0x0603E88F RID: 256143 RVA: 0x01234B30 File Offset: 0x01232D30
		[NullableContext(1)]
		private unsafe static float ClampInitAngle(float value, FVector2D range, string axis, EPhotoCameraBodyType bodyType)
		{
			float num = MathUtils.Instance.Clamp(value, range.X, range.Y);
			if (!MathUtils.Instance.IsNearlyEqual((double)num, (double)value, null))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照体型增量:初始角度超出可旋转范围,已钳制";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BodyType", bodyType.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Axis", axis);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Value", value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Min", range.X);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Max", range.Y);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
			return num;
		}

		// Token: 0x0603E890 RID: 256144 RVA: 0x01234C38 File Offset: 0x01232E38
		private static float ClampInitYaw(float value, FVector2D range, EPhotoCameraBodyType bodyType)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)(range.Y - range.X), 360.0, null))
			{
				return value;
			}
			return PhotoCamera.ClampInitAngle(value, range, "Yaw", bodyType);
		}

		// Token: 0x0603E891 RID: 256145 RVA: 0x01234C80 File Offset: 0x01232E80
		public void ResetToModeDefault()
		{
			if (this.IsDestroyed || this.SourceConfigInternal == null)
			{
				return;
			}
			this.ConfigLoadRequestId++;
			this.CurrentConfigInternal = PhotoCamera.CloneConfig(this.SourceConfigInternal);
			this.ApplyBodyTypeDelta(this.CurrentConfigInternal, this.SourceConfigInternal);
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component != null)
			{
				component.RefreshFromCurrentConfig();
			}
			Action modeChangedCallback = this.ModeChangedCallback;
			if (modeChangedCallback == null)
			{
				return;
			}
			modeChangedCallback();
		}

		// Token: 0x0603E892 RID: 256146 RVA: 0x01234CF4 File Offset: 0x01232EF4
		[NullableContext(0)]
		public UniTask<bool> ApplyTemplate([Nullable(1)] string daPath)
		{
			PhotoCamera.<ApplyTemplate>d__88 <ApplyTemplate>d__;
			<ApplyTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ApplyTemplate>d__.<>4__this = this;
			<ApplyTemplate>d__.daPath = daPath;
			<ApplyTemplate>d__.<>1__state = -1;
			<ApplyTemplate>d__.<>t__builder.Start<PhotoCamera.<ApplyTemplate>d__88>(ref <ApplyTemplate>d__);
			return <ApplyTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x0603E893 RID: 256147 RVA: 0x01234D40 File Offset: 0x01232F40
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_PhotoCameraConfig_C> OverrideSpecifiedConfigFromTemplate(string daPath, int? requestId = null)
		{
			PhotoCamera.<OverrideSpecifiedConfigFromTemplate>d__89 <OverrideSpecifiedConfigFromTemplate>d__;
			<OverrideSpecifiedConfigFromTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_PhotoCameraConfig_C>.Create();
			<OverrideSpecifiedConfigFromTemplate>d__.<>4__this = this;
			<OverrideSpecifiedConfigFromTemplate>d__.daPath = daPath;
			<OverrideSpecifiedConfigFromTemplate>d__.requestId = requestId;
			<OverrideSpecifiedConfigFromTemplate>d__.<>1__state = -1;
			<OverrideSpecifiedConfigFromTemplate>d__.<>t__builder.Start<PhotoCamera.<OverrideSpecifiedConfigFromTemplate>d__89>(ref <OverrideSpecifiedConfigFromTemplate>d__);
			return <OverrideSpecifiedConfigFromTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x0603E894 RID: 256148 RVA: 0x01234D94 File Offset: 0x01232F94
		public void ApplyDefaultTemplate(PhotoCameraLensState lens)
		{
			if (this.IsDestroyed || this.SourceConfigInternal == null)
			{
				return;
			}
			this.ConfigLoadRequestId++;
			this.CurrentConfigInternal = PhotoCamera.CloneConfig(this.SourceConfigInternal);
			this.ApplyBodyTypeDelta(this.CurrentConfigInternal, this.SourceConfigInternal);
			this.PendingLensInternal = lens;
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component != null)
			{
				component.RefreshFromCurrentConfig();
			}
			this.PendingLensInternal = null;
			Action modeChangedCallback = this.ModeChangedCallback;
			if (modeChangedCallback == null)
			{
				return;
			}
			modeChangedCallback();
		}

		// Token: 0x0603E895 RID: 256149 RVA: 0x01234E14 File Offset: 0x01233014
		public void ApplyDepthOfField(float? fStop = null, float? distance = null)
		{
			ACameraActor cameraActorInternal = this.CameraActorInternal;
			FPostProcessSettings fpostProcessSettings;
			if (cameraActorInternal == null)
			{
				fpostProcessSettings = null;
			}
			else
			{
				UCameraComponent cameraComponent = cameraActorInternal.CameraComponent;
				fpostProcessSettings = ((cameraComponent != null) ? cameraComponent.PostProcessSettings : null);
			}
			FPostProcessSettings fpostProcessSettings2 = fpostProcessSettings;
			if (fpostProcessSettings2 == null)
			{
				return;
			}
			if (fStop != null)
			{
				fpostProcessSettings2.bOverride_DepthOfFieldFstop = true;
				fpostProcessSettings2.DepthOfFieldFstop = fStop.Value;
			}
			if (distance != null)
			{
				fpostProcessSettings2.bOverride_DepthOfFieldFocalDistance = true;
				fpostProcessSettings2.DepthOfFieldFocalDistance = distance.Value;
			}
		}

		// Token: 0x0603E896 RID: 256150 RVA: 0x01234E84 File Offset: 0x01233084
		public void ClearDepthOfField()
		{
			ACameraActor cameraActorInternal = this.CameraActorInternal;
			FPostProcessSettings fpostProcessSettings;
			if (cameraActorInternal == null)
			{
				fpostProcessSettings = null;
			}
			else
			{
				UCameraComponent cameraComponent = cameraActorInternal.CameraComponent;
				fpostProcessSettings = ((cameraComponent != null) ? cameraComponent.PostProcessSettings : null);
			}
			FPostProcessSettings fpostProcessSettings2 = fpostProcessSettings;
			if (fpostProcessSettings2 == null)
			{
				return;
			}
			fpostProcessSettings2.bOverride_DepthOfFieldFstop = false;
			fpostProcessSettings2.bOverride_DepthOfFieldFocalDistance = false;
		}

		// Token: 0x0603E897 RID: 256151 RVA: 0x01234EC8 File Offset: 0x012330C8
		public void SetTiltRoll(float roll)
		{
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component == null)
			{
				return;
			}
			component.SetTiltRoll(roll);
		}

		// Token: 0x0603E898 RID: 256152 RVA: 0x01234EDC File Offset: 0x012330DC
		public void ResetTiltRoll()
		{
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component == null)
			{
				return;
			}
			component.ResetTiltRoll();
		}

		// Token: 0x0603E899 RID: 256153 RVA: 0x01234EF0 File Offset: 0x012330F0
		[NullableContext(1)]
		private void CaptureInheritWorldLocation(BP_PhotoCameraConfig_C config, PhotoCameraType? prev)
		{
			this.InheritedEntryPoseInternal = null;
			this.InheritedFromModeInternal = null;
			this.HasPendingInheritWorldLocation = false;
			if (!config.CommonConfig.IsInheritPrevModeCamera)
			{
				return;
			}
			this.InheritedFromModeInternal = prev;
			global::Vector inheritOffsetTmp = this.InheritOffsetTmp;
			FVector inheritCameraLocalOffset = config.CommonConfig.InheritCameraLocalOffset;
			inheritOffsetTmp.FromUeVector(inheritCameraLocalOffset);
			this.VirtualCamera.WorldRotation.Quaternion(this.InheritQuatTmp);
			this.InheritQuatTmp.RotateVector(this.InheritOffsetTmp, this.PendingInheritWorldLocationInternal);
			this.PendingInheritWorldLocationInternal.AdditionEqual(this.VirtualCamera.WorldLocation);
			this.HasPendingInheritWorldLocation = true;
		}

		// Token: 0x0603E89A RID: 256154 RVA: 0x01234F94 File Offset: 0x01233194
		[NullableContext(0)]
		public UniTask<bool> SwitchMode(PhotoCameraType target, [Nullable(2)] string templateDaPath = null)
		{
			PhotoCamera.<SwitchMode>d__96 <SwitchMode>d__;
			<SwitchMode>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SwitchMode>d__.<>4__this = this;
			<SwitchMode>d__.target = target;
			<SwitchMode>d__.templateDaPath = templateDaPath;
			<SwitchMode>d__.<>1__state = -1;
			<SwitchMode>d__.<>t__builder.Start<PhotoCamera.<SwitchMode>d__96>(ref <SwitchMode>d__);
			return <SwitchMode>d__.<>t__builder.Task;
		}

		// Token: 0x0603E89B RID: 256155 RVA: 0x01234FE8 File Offset: 0x012331E8
		private UniTask WaitLeaveSitDown()
		{
			PhotoCamera.<WaitLeaveSitDown>d__97 <WaitLeaveSitDown>d__;
			<WaitLeaveSitDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitLeaveSitDown>d__.<>4__this = this;
			<WaitLeaveSitDown>d__.<>1__state = -1;
			<WaitLeaveSitDown>d__.<>t__builder.Start<PhotoCamera.<WaitLeaveSitDown>d__97>(ref <WaitLeaveSitDown>d__);
			return <WaitLeaveSitDown>d__.<>t__builder.Task;
		}

		// Token: 0x0603E89C RID: 256156 RVA: 0x0123502B File Offset: 0x0123322B
		public void SetModeChangedCallback(Action callback)
		{
			this.ModeChangedCallback = callback;
		}

		// Token: 0x0603E89D RID: 256157 RVA: 0x01235034 File Offset: 0x01233234
		public void NotifyTiltRollChanged(float roll)
		{
			Action<float> onTiltRollChanged = this.OnTiltRollChanged;
			if (onTiltRollChanged == null)
			{
				return;
			}
			onTiltRollChanged(roll);
		}

		// Token: 0x0603E89E RID: 256158 RVA: 0x01235048 File Offset: 0x01233248
		private bool NeedBlend(PhotoCameraType? prev, PhotoCameraType next)
		{
			PhotoCameraType? photoCameraType = prev;
			PhotoCameraType photoCameraType2 = PhotoCameraType.Normal;
			return (photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null) && next == PhotoCameraType.Drone;
		}

		// Token: 0x0603E89F RID: 256159 RVA: 0x01235074 File Offset: 0x01233274
		private void DispatchModeChangeStart(PhotoCameraType? prev, PhotoCameraType target)
		{
			PhotoCameraComponentBase photoCameraComponentBase;
			PhotoCameraBlendComponent photoCameraBlendComponent = this.Components.TryGetValue(EPhotoCameraComponent.Blend, out photoCameraComponentBase) ? (photoCameraComponentBase as PhotoCameraBlendComponent) : null;
			if (photoCameraBlendComponent != null)
			{
				photoCameraBlendComponent.CaptureStart();
			}
			foreach (EPhotoCameraComponent key in this.TickOrder)
			{
				PhotoCameraComponentBase photoCameraComponentBase2;
				if (this.Components.TryGetValue(key, out photoCameraComponentBase2))
				{
					photoCameraComponentBase2.ModeChangeStart(prev, target);
				}
			}
		}

		// Token: 0x0603E8A0 RID: 256160 RVA: 0x012350D8 File Offset: 0x012332D8
		private void DispatchModeChangeFinish(PhotoCameraType? prev, PhotoCameraType target)
		{
			foreach (EPhotoCameraComponent key in this.TickOrder)
			{
				PhotoCameraComponentBase photoCameraComponentBase;
				if (this.Components.TryGetValue(key, out photoCameraComponentBase))
				{
					photoCameraComponentBase.ModeChangeFinish(prev, target);
				}
			}
		}

		// Token: 0x0603E8A1 RID: 256161 RVA: 0x01235116 File Offset: 0x01233316
		private void ApplyInputDistribute(PhotoCameraType target)
		{
			this.SetCharacterInvertMoveForward(target == PhotoCameraType.Selfie);
			this.SetCharacterInvertMoveRight(target == PhotoCameraType.Selfie);
			this.SetCharacterCameraDirection(target == PhotoCameraType.FirstPerson);
			InputDistributeModel.Instance.RefreshInputDistributeTag();
		}

		// Token: 0x040215C0 RID: 136640
		private ACameraActor CameraActorInternal;

		// Token: 0x040215C1 RID: 136641
		private CameraModelInstance CameraModelInternal;

		// Token: 0x040215C2 RID: 136642
		private TsBaseCharacter CharacterInternal;

		// Token: 0x040215C3 RID: 136643
		private PhotoCameraType? DefaultModeInternal;

		// Token: 0x040215C4 RID: 136644
		private PhotoCameraLensState PendingLensInternal;

		// Token: 0x040215C5 RID: 136645
		private PhotoCameraEntryPose InheritedEntryPoseInternal;

		// Token: 0x040215C6 RID: 136646
		private PhotoCameraType? InheritedFromModeInternal;

		// Token: 0x040215C7 RID: 136647
		[Nullable(1)]
		private readonly global::Vector PendingInheritWorldLocationInternal = global::Vector.Create();

		// Token: 0x040215C8 RID: 136648
		private bool HasPendingInheritWorldLocation;

		// Token: 0x040215C9 RID: 136649
		[Nullable(1)]
		private readonly global::Vector InheritOffsetTmp = global::Vector.Create();

		// Token: 0x040215CA RID: 136650
		[Nullable(1)]
		private readonly Quat InheritQuatTmp = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040215CB RID: 136651
		private PhotoCameraType? CurrentModeInternal;

		// Token: 0x040215CC RID: 136652
		private EPhotoCameraBodyType AppliedBodyType;

		// Token: 0x040215CD RID: 136653
		private BP_PhotoCameraConfig_C SourceConfigInternal;

		// Token: 0x040215CE RID: 136654
		private BP_PhotoCameraConfig_C CurrentConfigInternal;

		// Token: 0x040215CF RID: 136655
		private bool IsModeLoading;

		// Token: 0x040215D0 RID: 136656
		private bool IsDestroyed;

		// Token: 0x040215D1 RID: 136657
		private bool IsBlending;

		// Token: 0x040215D2 RID: 136658
		private int ConfigLoadRequestId;

		// Token: 0x040215D3 RID: 136659
		private int NearClipId;

		// Token: 0x040215D4 RID: 136660
		private Action ModeChangedCallback;

		// Token: 0x040215D5 RID: 136661
		private bool IsCameraDirectionApplied;

		// Token: 0x040215D6 RID: 136662
		private ECharDirectionState PrevDirectionState = ECharDirectionState.FaceDirection;

		// Token: 0x040215D7 RID: 136663
		public Action<float> OnTiltRollChanged;

		// Token: 0x040215D8 RID: 136664
		public Action<float, float> OnTemplateDepthOfFieldChanged;

		// Token: 0x040215DB RID: 136667
		[Nullable(1)]
		private readonly Dictionary<EPhotoCameraComponent, PhotoCameraComponentBase> Components = new Dictionary<EPhotoCameraComponent, PhotoCameraComponentBase>();

		// Token: 0x040215DC RID: 136668
		[Nullable(1)]
		private readonly EPhotoCameraComponent[] TickOrder = new EPhotoCameraComponent[]
		{
			EPhotoCameraComponent.Input,
			EPhotoCameraComponent.Logic,
			EPhotoCameraComponent.Selfie,
			EPhotoCameraComponent.Collision,
			EPhotoCameraComponent.Character,
			EPhotoCameraComponent.Display,
			EPhotoCameraComponent.Debug
		};

		// Token: 0x040215DD RID: 136669
		[Nullable(1)]
		private readonly EPhotoCameraComponent[] BlendTickOrder = new EPhotoCameraComponent[]
		{
			EPhotoCameraComponent.Blend,
			EPhotoCameraComponent.Collision,
			EPhotoCameraComponent.Display,
			EPhotoCameraComponent.Debug
		};
	}
}

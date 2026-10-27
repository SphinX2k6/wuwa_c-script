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
	// Token: 0x02007301 RID: 29441
	[NullableContext(2)]
	[Nullable(0)]
	public class PhotoCamera : ISpecialGameplayCamera, IPhotoCameraHost
	{
		// Token: 0x17009F62 RID: 40802
		// (get) Token: 0x06048419 RID: 295961 RVA: 0x0129173E File Offset: 0x0128F93E
		// (set) Token: 0x0604841A RID: 295962 RVA: 0x01291746 File Offset: 0x0128F946
		public bool IsDebugEnable { get; private set; }

		// Token: 0x17009F63 RID: 40803
		// (get) Token: 0x0604841B RID: 295963 RVA: 0x0129174F File Offset: 0x0128F94F
		[Nullable(1)]
		public VirtualPhotoCamera VirtualCamera { [NullableContext(1)] get; } = new VirtualPhotoCamera();

		// Token: 0x17009F64 RID: 40804
		// (get) Token: 0x0604841C RID: 295964 RVA: 0x01291757 File Offset: 0x0128F957
		public ACameraActor CameraActor
		{
			get
			{
				return this.CameraActorInternal;
			}
		}

		// Token: 0x17009F65 RID: 40805
		// (get) Token: 0x0604841D RID: 295965 RVA: 0x0129175F File Offset: 0x0128F95F
		public CameraModelInstance CameraModel
		{
			get
			{
				return this.CameraModelInternal;
			}
		}

		// Token: 0x17009F66 RID: 40806
		// (get) Token: 0x0604841E RID: 295966 RVA: 0x01291767 File Offset: 0x0128F967
		public TsBaseCharacter Character
		{
			get
			{
				return this.CharacterInternal;
			}
		}

		// Token: 0x17009F67 RID: 40807
		// (get) Token: 0x0604841F RID: 295967 RVA: 0x0129176F File Offset: 0x0128F96F
		public PhotoCameraType? DefaultMode
		{
			get
			{
				return this.DefaultModeInternal;
			}
		}

		// Token: 0x17009F68 RID: 40808
		// (get) Token: 0x06048420 RID: 295968 RVA: 0x01291777 File Offset: 0x0128F977
		public PhotoCameraType? CurrentMode
		{
			get
			{
				return this.CurrentModeInternal;
			}
		}

		// Token: 0x17009F69 RID: 40809
		// (get) Token: 0x06048421 RID: 295969 RVA: 0x0129177F File Offset: 0x0128F97F
		public BP_PhotoCameraConfig_C CurrentConfig
		{
			get
			{
				return this.CurrentConfigInternal;
			}
		}

		// Token: 0x17009F6A RID: 40810
		// (get) Token: 0x06048422 RID: 295970 RVA: 0x01291787 File Offset: 0x0128F987
		public PhotoCameraLensState PendingLens
		{
			get
			{
				return this.PendingLensInternal;
			}
		}

		// Token: 0x17009F6B RID: 40811
		// (get) Token: 0x06048423 RID: 295971 RVA: 0x0129178F File Offset: 0x0128F98F
		public PhotoCameraEntryPose InheritedEntryPose
		{
			get
			{
				return this.InheritedEntryPoseInternal;
			}
		}

		// Token: 0x17009F6C RID: 40812
		// (get) Token: 0x06048424 RID: 295972 RVA: 0x01291797 File Offset: 0x0128F997
		public bool IsInheritMode
		{
			get
			{
				BP_PhotoCameraConfig_C currentConfigInternal = this.CurrentConfigInternal;
				return currentConfigInternal != null && currentConfigInternal.CommonConfig.IsInheritPrevModeCamera;
			}
		}

		// Token: 0x17009F6D RID: 40813
		// (get) Token: 0x06048425 RID: 295973 RVA: 0x012917AF File Offset: 0x0128F9AF
		public PhotoCameraType? InheritedFromMode
		{
			get
			{
				return this.InheritedFromModeInternal;
			}
		}

		// Token: 0x17009F6E RID: 40814
		// (get) Token: 0x06048426 RID: 295974 RVA: 0x012917B7 File Offset: 0x0128F9B7
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

		// Token: 0x06048427 RID: 295975 RVA: 0x012917C9 File Offset: 0x0128F9C9
		[NullableContext(1)]
		public void SetInheritedEntryPose(PhotoCameraEntryPose pose)
		{
			this.InheritedEntryPoseInternal = pose;
			this.HasPendingInheritWorldLocation = false;
		}

		// Token: 0x06048428 RID: 295976 RVA: 0x012917D9 File Offset: 0x0128F9D9
		public void SetCharacter(TsBaseCharacter character)
		{
			this.CharacterInternal = character;
		}

		// Token: 0x06048429 RID: 295977 RVA: 0x012917E4 File Offset: 0x0128F9E4
		public void ChangeCharacter(TsBaseCharacter character)
		{
			if (this.IsDestroyed || this.CharacterInternal == character)
			{
				return;
			}
			this.SetCharacterPhotoCameraInput(false);
			this.SetCharacterInvertMoveForward(false);
			this.SetCharacterInvertMoveRight(false);
			this.CharacterInternal = character;
			this.SetCharacterPhotoCameraInput(true);
			if (this.CurrentModeInternal != null)
			{
				this.ApplyInputDistribute(this.CurrentModeInternal.Value);
			}
			this.DispatchCharacterChanged(character);
			this.RebuildConfigForCurrentBodyType();
		}

		// Token: 0x0604842A RID: 295978 RVA: 0x01291854 File Offset: 0x0128FA54
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

		// Token: 0x0604842B RID: 295979 RVA: 0x01291891 File Offset: 0x0128FA91
		public void SetPendingLens(PhotoCameraLensState lens)
		{
			this.PendingLensInternal = lens;
		}

		// Token: 0x0604842C RID: 295980 RVA: 0x0129189A File Offset: 0x0128FA9A
		public void SetDefaultMode(PhotoCameraType mode)
		{
			this.DefaultModeInternal = new PhotoCameraType?(mode);
		}

		// Token: 0x0604842D RID: 295981 RVA: 0x012918A8 File Offset: 0x0128FAA8
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

		// Token: 0x0604842E RID: 295982 RVA: 0x012918DA File Offset: 0x0128FADA
		public bool ToggleDebug()
		{
			this.IsDebugEnable = !this.IsDebugEnable;
			return this.IsDebugEnable;
		}

		// Token: 0x0604842F RID: 295983 RVA: 0x012918F4 File Offset: 0x0128FAF4
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

		// Token: 0x06048430 RID: 295984 RVA: 0x012919EC File Offset: 0x0128FBEC
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

		// Token: 0x06048431 RID: 295985 RVA: 0x01291A54 File Offset: 0x0128FC54
		public void OnDestroy()
		{
			this.IsDestroyed = true;
			this.IsBlending = false;
			this.DisableNearClip();
			this.SetCharacterPhotoCameraInput(false);
			this.SetCharacterInvertMoveForward(false);
			this.SetCharacterInvertMoveRight(false);
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

		// Token: 0x06048432 RID: 295986 RVA: 0x01291B74 File Offset: 0x0128FD74
		[NullableContext(1)]
		private void RegisterComponent(PhotoCameraComponentBase component)
		{
			EPhotoCameraComponent id = PhotoCameraComponentBase.GetId(component.GetType());
			this.Components[id] = component;
			component.Init(this);
		}

		// Token: 0x06048433 RID: 295987 RVA: 0x01291BA4 File Offset: 0x0128FDA4
		private void EnableNearClip()
		{
			this.DisableNearClip();
			this.NearClipId = CameraNearClipController.Instance.EnableAbsoluteNearClip(250, ConfigCommonParamById.GetFloatConfig("PhotoCameraNearClipPlane").GetValueOrDefault(2f));
		}

		// Token: 0x06048434 RID: 295988 RVA: 0x01291BE3 File Offset: 0x0128FDE3
		private void DisableNearClip()
		{
			if (this.NearClipId <= 0)
			{
				return;
			}
			CameraNearClipController.Instance.DisableCameraNearClip(this.NearClipId);
			this.NearClipId = 0;
		}

		// Token: 0x06048435 RID: 295989 RVA: 0x01291C06 File Offset: 0x0128FE06
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

		// Token: 0x06048436 RID: 295990 RVA: 0x01291C2D File Offset: 0x0128FE2D
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

		// Token: 0x06048437 RID: 295991 RVA: 0x01291C54 File Offset: 0x0128FE54
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

		// Token: 0x06048438 RID: 295992 RVA: 0x01291C7C File Offset: 0x0128FE7C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_PhotoCameraConfig_C> LoadConfig(PhotoCameraType mode)
		{
			PhotoCamera.<LoadConfig>d__72 <LoadConfig>d__;
			<LoadConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_PhotoCameraConfig_C>.Create();
			<LoadConfig>d__.<>4__this = this;
			<LoadConfig>d__.mode = mode;
			<LoadConfig>d__.<>1__state = -1;
			<LoadConfig>d__.<>t__builder.Start<PhotoCamera.<LoadConfig>d__72>(ref <LoadConfig>d__);
			return <LoadConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06048439 RID: 295993 RVA: 0x01291CC8 File Offset: 0x0128FEC8
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_PhotoCameraConfig_C> LoadConfigByPath(string path)
		{
			PhotoCamera.<LoadConfigByPath>d__73 <LoadConfigByPath>d__;
			<LoadConfigByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_PhotoCameraConfig_C>.Create();
			<LoadConfigByPath>d__.path = path;
			<LoadConfigByPath>d__.<>1__state = -1;
			<LoadConfigByPath>d__.<>t__builder.Start<PhotoCamera.<LoadConfigByPath>d__73>(ref <LoadConfigByPath>d__);
			return <LoadConfigByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0604843A RID: 295994 RVA: 0x01291D0C File Offset: 0x0128FF0C
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

		// Token: 0x0604843B RID: 295995 RVA: 0x01291DA0 File Offset: 0x0128FFA0
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

		// Token: 0x0604843C RID: 295996 RVA: 0x01291DFC File Offset: 0x0128FFFC
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

		// Token: 0x0604843D RID: 295997 RVA: 0x01291E40 File Offset: 0x01290040
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

		// Token: 0x0604843E RID: 295998 RVA: 0x01291EA0 File Offset: 0x012900A0
		private bool HasBodyTypeDelta(EPhotoCameraBodyType bodyType)
		{
			SPhotoCameraMorphDeltaConfig self;
			return bodyType != EPhotoCameraBodyType.None && this.SourceConfigInternal != null && this.SourceConfigInternal.BodyTypeDeltaConfig.TryGetValue(bodyType, out self) && self != null;
		}

		// Token: 0x0604843F RID: 295999 RVA: 0x01291EE0 File Offset: 0x012900E0
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

		// Token: 0x06048440 RID: 296000 RVA: 0x01291F6C File Offset: 0x0129016C
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

		// Token: 0x06048441 RID: 296001 RVA: 0x01292058 File Offset: 0x01290258
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

		// Token: 0x06048442 RID: 296002 RVA: 0x012920BC File Offset: 0x012902BC
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

		// Token: 0x06048443 RID: 296003 RVA: 0x012921C4 File Offset: 0x012903C4
		private static float ClampInitYaw(float value, FVector2D range, EPhotoCameraBodyType bodyType)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)(range.Y - range.X), 360.0, null))
			{
				return value;
			}
			return PhotoCamera.ClampInitAngle(value, range, "Yaw", bodyType);
		}

		// Token: 0x06048444 RID: 296004 RVA: 0x0129220C File Offset: 0x0129040C
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

		// Token: 0x06048445 RID: 296005 RVA: 0x01292280 File Offset: 0x01290480
		[NullableContext(0)]
		public UniTask<bool> ApplyTemplate([Nullable(1)] string daPath)
		{
			PhotoCamera.<ApplyTemplate>d__85 <ApplyTemplate>d__;
			<ApplyTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ApplyTemplate>d__.<>4__this = this;
			<ApplyTemplate>d__.daPath = daPath;
			<ApplyTemplate>d__.<>1__state = -1;
			<ApplyTemplate>d__.<>t__builder.Start<PhotoCamera.<ApplyTemplate>d__85>(ref <ApplyTemplate>d__);
			return <ApplyTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x06048446 RID: 296006 RVA: 0x012922CC File Offset: 0x012904CC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<BP_PhotoCameraConfig_C> OverrideSpecifiedConfigFromTemplate(string daPath, int? requestId = null)
		{
			PhotoCamera.<OverrideSpecifiedConfigFromTemplate>d__86 <OverrideSpecifiedConfigFromTemplate>d__;
			<OverrideSpecifiedConfigFromTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_PhotoCameraConfig_C>.Create();
			<OverrideSpecifiedConfigFromTemplate>d__.<>4__this = this;
			<OverrideSpecifiedConfigFromTemplate>d__.daPath = daPath;
			<OverrideSpecifiedConfigFromTemplate>d__.requestId = requestId;
			<OverrideSpecifiedConfigFromTemplate>d__.<>1__state = -1;
			<OverrideSpecifiedConfigFromTemplate>d__.<>t__builder.Start<PhotoCamera.<OverrideSpecifiedConfigFromTemplate>d__86>(ref <OverrideSpecifiedConfigFromTemplate>d__);
			return <OverrideSpecifiedConfigFromTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x06048447 RID: 296007 RVA: 0x01292320 File Offset: 0x01290520
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

		// Token: 0x06048448 RID: 296008 RVA: 0x012923A0 File Offset: 0x012905A0
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

		// Token: 0x06048449 RID: 296009 RVA: 0x01292410 File Offset: 0x01290610
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

		// Token: 0x0604844A RID: 296010 RVA: 0x01292454 File Offset: 0x01290654
		public void SetTiltRoll(float roll)
		{
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component == null)
			{
				return;
			}
			component.SetTiltRoll(roll);
		}

		// Token: 0x0604844B RID: 296011 RVA: 0x01292468 File Offset: 0x01290668
		public void ResetTiltRoll()
		{
			PhotoCameraLogicComponent component = this.GetComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
			if (component == null)
			{
				return;
			}
			component.ResetTiltRoll();
		}

		// Token: 0x0604844C RID: 296012 RVA: 0x0129247C File Offset: 0x0129067C
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

		// Token: 0x0604844D RID: 296013 RVA: 0x01292520 File Offset: 0x01290720
		[NullableContext(0)]
		public UniTask<bool> SwitchMode(PhotoCameraType target, [Nullable(2)] string templateDaPath = null)
		{
			PhotoCamera.<SwitchMode>d__93 <SwitchMode>d__;
			<SwitchMode>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SwitchMode>d__.<>4__this = this;
			<SwitchMode>d__.target = target;
			<SwitchMode>d__.templateDaPath = templateDaPath;
			<SwitchMode>d__.<>1__state = -1;
			<SwitchMode>d__.<>t__builder.Start<PhotoCamera.<SwitchMode>d__93>(ref <SwitchMode>d__);
			return <SwitchMode>d__.<>t__builder.Task;
		}

		// Token: 0x0604844E RID: 296014 RVA: 0x01292574 File Offset: 0x01290774
		private UniTask WaitLeaveSitDown()
		{
			PhotoCamera.<WaitLeaveSitDown>d__94 <WaitLeaveSitDown>d__;
			<WaitLeaveSitDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitLeaveSitDown>d__.<>4__this = this;
			<WaitLeaveSitDown>d__.<>1__state = -1;
			<WaitLeaveSitDown>d__.<>t__builder.Start<PhotoCamera.<WaitLeaveSitDown>d__94>(ref <WaitLeaveSitDown>d__);
			return <WaitLeaveSitDown>d__.<>t__builder.Task;
		}

		// Token: 0x0604844F RID: 296015 RVA: 0x012925B7 File Offset: 0x012907B7
		public void SetModeChangedCallback(Action callback)
		{
			this.ModeChangedCallback = callback;
		}

		// Token: 0x06048450 RID: 296016 RVA: 0x012925C0 File Offset: 0x012907C0
		public void NotifyTiltRollChanged(float roll)
		{
			Action<float> onTiltRollChanged = this.OnTiltRollChanged;
			if (onTiltRollChanged == null)
			{
				return;
			}
			onTiltRollChanged(roll);
		}

		// Token: 0x06048451 RID: 296017 RVA: 0x012925D4 File Offset: 0x012907D4
		private bool NeedBlend(PhotoCameraType? prev, PhotoCameraType next)
		{
			PhotoCameraType? photoCameraType = prev;
			PhotoCameraType photoCameraType2 = PhotoCameraType.Normal;
			return (photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null) && next == PhotoCameraType.Drone;
		}

		// Token: 0x06048452 RID: 296018 RVA: 0x01292600 File Offset: 0x01290800
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

		// Token: 0x06048453 RID: 296019 RVA: 0x01292664 File Offset: 0x01290864
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

		// Token: 0x06048454 RID: 296020 RVA: 0x012926A2 File Offset: 0x012908A2
		private void ApplyInputDistribute(PhotoCameraType target)
		{
			this.SetCharacterInvertMoveForward(target == PhotoCameraType.Selfie);
			this.SetCharacterInvertMoveRight(target == PhotoCameraType.Selfie);
			InputDistributeModel.Instance.RefreshInputDistributeTag();
		}

		// Token: 0x040262D5 RID: 156373
		private ACameraActor CameraActorInternal;

		// Token: 0x040262D6 RID: 156374
		private CameraModelInstance CameraModelInternal;

		// Token: 0x040262D7 RID: 156375
		private TsBaseCharacter CharacterInternal;

		// Token: 0x040262D8 RID: 156376
		private PhotoCameraType? DefaultModeInternal;

		// Token: 0x040262D9 RID: 156377
		private PhotoCameraLensState PendingLensInternal;

		// Token: 0x040262DA RID: 156378
		private PhotoCameraEntryPose InheritedEntryPoseInternal;

		// Token: 0x040262DB RID: 156379
		private PhotoCameraType? InheritedFromModeInternal;

		// Token: 0x040262DC RID: 156380
		[Nullable(1)]
		private readonly global::Vector PendingInheritWorldLocationInternal = global::Vector.Create();

		// Token: 0x040262DD RID: 156381
		private bool HasPendingInheritWorldLocation;

		// Token: 0x040262DE RID: 156382
		[Nullable(1)]
		private readonly global::Vector InheritOffsetTmp = global::Vector.Create();

		// Token: 0x040262DF RID: 156383
		[Nullable(1)]
		private readonly Quat InheritQuatTmp = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262E0 RID: 156384
		private PhotoCameraType? CurrentModeInternal;

		// Token: 0x040262E1 RID: 156385
		private EPhotoCameraBodyType AppliedBodyType;

		// Token: 0x040262E2 RID: 156386
		private BP_PhotoCameraConfig_C SourceConfigInternal;

		// Token: 0x040262E3 RID: 156387
		private BP_PhotoCameraConfig_C CurrentConfigInternal;

		// Token: 0x040262E4 RID: 156388
		private bool IsModeLoading;

		// Token: 0x040262E5 RID: 156389
		private bool IsDestroyed;

		// Token: 0x040262E6 RID: 156390
		private bool IsBlending;

		// Token: 0x040262E7 RID: 156391
		private int ConfigLoadRequestId;

		// Token: 0x040262E8 RID: 156392
		private int NearClipId;

		// Token: 0x040262E9 RID: 156393
		private Action ModeChangedCallback;

		// Token: 0x040262EA RID: 156394
		public Action<float> OnTiltRollChanged;

		// Token: 0x040262EB RID: 156395
		public Action<float, float> OnTemplateDepthOfFieldChanged;

		// Token: 0x040262EE RID: 156398
		[Nullable(1)]
		private readonly Dictionary<EPhotoCameraComponent, PhotoCameraComponentBase> Components = new Dictionary<EPhotoCameraComponent, PhotoCameraComponentBase>();

		// Token: 0x040262EF RID: 156399
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

		// Token: 0x040262F0 RID: 156400
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

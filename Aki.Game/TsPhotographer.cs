using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Camera;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001A98 RID: 6808
[UClass("/Game/Aki/TypeScript/Game/Module/Photograph/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographer.TsPhotographer_C")]
public class TsPhotographer : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17001955 RID: 6485
	// (get) Token: 0x06010D4D RID: 68941 RVA: 0x004EF6FB File Offset: 0x004ED8FB
	// (set) Token: 0x06010D4E RID: 68942 RVA: 0x004EF70F File Offset: 0x004ED90F
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCapsuleComponent CapsuleCollision
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographer.__PropertyOffset_CapsuleCollision);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographer.__PropertyOffset_CapsuleCollision, value);
		}
	}

	// Token: 0x17001956 RID: 6486
	// (get) Token: 0x06010D4F RID: 68943 RVA: 0x004EF724 File Offset: 0x004ED924
	// (set) Token: 0x06010D50 RID: 68944 RVA: 0x004EF738 File Offset: 0x004ED938
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe USpringArmComponent CameraArm
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USpringArmComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographer.__PropertyOffset_CameraArm);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographer.__PropertyOffset_CameraArm, value);
		}
	}

	// Token: 0x17001957 RID: 6487
	// (get) Token: 0x06010D51 RID: 68945 RVA: 0x004EF74D File Offset: 0x004ED94D
	// (set) Token: 0x06010D52 RID: 68946 RVA: 0x004EF75D File Offset: 0x004ED95D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraInitializeFov
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraInitializeFov);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraInitializeFov) = value;
		}
	}

	// Token: 0x17001958 RID: 6488
	// (get) Token: 0x06010D53 RID: 68947 RVA: 0x004EF76E File Offset: 0x004ED96E
	// (set) Token: 0x06010D54 RID: 68948 RVA: 0x004EF782 File Offset: 0x004ED982
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector CameraArmInitializeSocketOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraArmInitializeSocketOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraArmInitializeSocketOffset) = value;
		}
	}

	// Token: 0x17001959 RID: 6489
	// (get) Token: 0x06010D55 RID: 68949 RVA: 0x004EF797 File Offset: 0x004ED997
	// (set) Token: 0x06010D56 RID: 68950 RVA: 0x004EF7A7 File Offset: 0x004ED9A7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraUpAndDownMaxDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraUpAndDownMaxDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraUpAndDownMaxDistance) = value;
		}
	}

	// Token: 0x1700195A RID: 6490
	// (get) Token: 0x06010D57 RID: 68951 RVA: 0x004EF7B8 File Offset: 0x004ED9B8
	// (set) Token: 0x06010D58 RID: 68952 RVA: 0x004EF7C8 File Offset: 0x004ED9C8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraLeftAndRightMaxDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraLeftAndRightMaxDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraLeftAndRightMaxDistance) = value;
		}
	}

	// Token: 0x1700195B RID: 6491
	// (get) Token: 0x06010D59 RID: 68953 RVA: 0x004EF7D9 File Offset: 0x004ED9D9
	// (set) Token: 0x06010D5A RID: 68954 RVA: 0x004EF7E9 File Offset: 0x004ED9E9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraForwardAndBackMaxDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraForwardAndBackMaxDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraForwardAndBackMaxDistance) = value;
		}
	}

	// Token: 0x1700195C RID: 6492
	// (get) Token: 0x06010D5B RID: 68955 RVA: 0x004EF7FA File Offset: 0x004ED9FA
	// (set) Token: 0x06010D5C RID: 68956 RVA: 0x004EF80A File Offset: 0x004EDA0A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraUpAndDownSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraUpAndDownSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraUpAndDownSpeed) = value;
		}
	}

	// Token: 0x1700195D RID: 6493
	// (get) Token: 0x06010D5D RID: 68957 RVA: 0x004EF81B File Offset: 0x004EDA1B
	// (set) Token: 0x06010D5E RID: 68958 RVA: 0x004EF82B File Offset: 0x004EDA2B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraLeftAndRightSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraLeftAndRightSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraLeftAndRightSpeed) = value;
		}
	}

	// Token: 0x1700195E RID: 6494
	// (get) Token: 0x06010D5F RID: 68959 RVA: 0x004EF83C File Offset: 0x004EDA3C
	// (set) Token: 0x06010D60 RID: 68960 RVA: 0x004EF84C File Offset: 0x004EDA4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CameraForwardAndBackSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraForwardAndBackSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CameraForwardAndBackSpeed) = value;
		}
	}

	// Token: 0x1700195F RID: 6495
	// (get) Token: 0x06010D61 RID: 68961 RVA: 0x004EF85D File Offset: 0x004EDA5D
	// (set) Token: 0x06010D62 RID: 68962 RVA: 0x004EF86D File Offset: 0x004EDA6D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinFov
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_MinFov);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_MinFov) = value;
		}
	}

	// Token: 0x17001960 RID: 6496
	// (get) Token: 0x06010D63 RID: 68963 RVA: 0x004EF87E File Offset: 0x004EDA7E
	// (set) Token: 0x06010D64 RID: 68964 RVA: 0x004EF88E File Offset: 0x004EDA8E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxFov
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_MaxFov);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_MaxFov) = value;
		}
	}

	// Token: 0x17001961 RID: 6497
	// (get) Token: 0x06010D65 RID: 68965 RVA: 0x004EF89F File Offset: 0x004EDA9F
	// (set) Token: 0x06010D66 RID: 68966 RVA: 0x004EF8AF File Offset: 0x004EDAAF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CurCameraUpAndDownDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CurCameraUpAndDownDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CurCameraUpAndDownDistance) = value;
		}
	}

	// Token: 0x17001962 RID: 6498
	// (get) Token: 0x06010D67 RID: 68967 RVA: 0x004EF8C0 File Offset: 0x004EDAC0
	// (set) Token: 0x06010D68 RID: 68968 RVA: 0x004EF8D0 File Offset: 0x004EDAD0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CurCameraLeftAndRightDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CurCameraLeftAndRightDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CurCameraLeftAndRightDistance) = value;
		}
	}

	// Token: 0x17001963 RID: 6499
	// (get) Token: 0x06010D69 RID: 68969 RVA: 0x004EF8E1 File Offset: 0x004EDAE1
	// (set) Token: 0x06010D6A RID: 68970 RVA: 0x004EF8F1 File Offset: 0x004EDAF1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CurCameraForwardAndBackDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CurCameraForwardAndBackDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_CurCameraForwardAndBackDistance) = value;
		}
	}

	// Token: 0x06010D6B RID: 68971 RVA: 0x004EF904 File Offset: 0x004EDB04
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Initialize()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Initialize"), TsPhotographer.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Initialize_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06010D6C RID: 68972 RVA: 0x004EF960 File Offset: 0x004EDB60
	protected void Initialize_Implementation()
	{
		this.RelativeVectorCache = new FVector?(new FVector());
		this.DefaultRotation = new FRotator?(new FRotator(0f, 0f, 0f));
		this.InitialCapsuleRoll = this.CapsuleCollision.K2_GetComponentRotation().Roll;
		this.CameraLocation = global::Vector.Create();
		this.PlayerLocation = global::Vector.Create();
		this.SourceMaxPitch = (float)ConfigCommonParamById.GetIntConfig("CameraSourceMaxPitch").Value;
		this.SourceMinPitch = (float)ConfigCommonParamById.GetIntConfig("CameraSourceMinPitch").Value;
		this.CameraUpAndDownSpeed = 1f;
		this.CameraLeftAndRightSpeed = 1f;
		this.MaxFov = 90f;
		this.MinFov = 30f;
		this.CameraUpAndDownSpeed = 1f;
		this.CameraLeftAndRightSpeed = 1f;
		this.CameraForwardAndBackSpeed = (float)ConfigCommonParamById.GetIntConfig("CameraForwardAndBackSpeed").Value;
		this.CameraInitializeFov = -1f;
		bool isFightPhotoCamera = PhotographController.Instance.CheckIfInFightPhotographCamera();
		this.CameraUpAndDownMaxDistance = (float)(isFightPhotoCamera ? ConfigCommonParamById.GetIntConfig("FightCameraUpAndDownDistance").Value : ConfigCommonParamById.GetIntConfig("CameraUpAndDownDistance").Value);
		this.CameraLeftAndRightMaxDistance = (float)(isFightPhotoCamera ? ConfigCommonParamById.GetIntConfig("FightCameraLeftAndRightDistance").Value : ConfigCommonParamById.GetIntConfig("CameraLeftAndRightDistance").Value);
		this.CameraForwardAndBackMaxDistance = (float)ConfigCommonParamById.GetIntConfig("CameraForwardAndDownDistance").GetValueOrDefault(50);
		if (isFightPhotoCamera)
		{
			this.MinFov = (float)ConfigCommonParamById.GetIntConfig("FightCameraMinFov").Value;
			this.MaxFov = (float)ConfigCommonParamById.GetIntConfig("FightCameraMaxFov").Value;
			this.CameraUpAndDownSpeed = (float)ConfigCommonParamById.GetIntConfig("FightCameraUpAndDownSpeed").Value;
			this.CameraLeftAndRightSpeed = (float)ConfigCommonParamById.GetIntConfig("FightCameraLeftAndRightSpeed").Value;
		}
		else
		{
			this.MinFov = (float)ConfigCommonParamById.GetIntConfig("CameraMinFov").Value;
			this.MaxFov = (float)ConfigCommonParamById.GetIntConfig("CameraMaxFov").Value;
			this.CameraUpAndDownSpeed = (float)ConfigCommonParamById.GetIntConfig("CameraUpAndDownSpeed").Value;
			this.CameraLeftAndRightSpeed = (float)ConfigCommonParamById.GetIntConfig("CameraLeftAndRightSpeed").Value;
		}
		this.CurCameraUpAndDownDistance = 0f;
		this.CurCameraLeftAndRightDistance = 0f;
		this.CurCameraForwardAndBackDistance = 0f;
		this.CurrentDither = 0.0;
		this.Character = Global.BaseCharacter;
		global::Vector playerLocation = this.PlayerLocation;
		FVectorDouble fvectorDouble = this.Character.D_K2_GetActorLocation();
		playerLocation.FromUeVector(fvectorDouble);
		GravityUtils.Instance.GetBaseQuatInGravityForActor(this.Character.CharacterActorComponent, this.GravityQuat);
		this.GravityQuat.Inverse(this.InverseGravityQuat);
		this.CurrentCameraDitherFov = 0f;
		this.CameraCollisionRadius = 0.0;
		this.DitheredNpcSet = new HashSet<TsBaseCharacter>();
		this.DitheredNpcDistanceMap = new Dictionary<TsBaseCharacter, double>();
		this.TeamMemberDitherMap = new Dictionary<TsBaseCharacter, double>();
		this.InitCameraNpcSphereTrace();
		this.IsLoadingConfigCompleted = false;
		string path = Info.Instance.IsMobilePlatform() ? "/Game/Aki/Data/Camera/DA_PhotographCameraConfig_Mobile.DA_PhotographCameraConfig_Mobile" : "/Game/Aki/Data/Camera/DA_PhotographCameraConfig.DA_PhotographCameraConfig";
		ResourceSystem.Instance.LoadAsync<BP_PhotographCameraConfig_C>(path, delegate([Nullable(2)] BP_PhotographCameraConfig_C cameraConfig, string _)
		{
			TMap<TEnumAsByte<EPhotographCamera>, float> 基础 = cameraConfig.基础;
			this.StartHidePitch = (isFightPhotoCamera ? 基础.Get(EPhotographCamera.战斗拍照角色开始虚化仰视角) : 基础.Get(EPhotographCamera.角色开始虚化仰视角));
			float val = isFightPhotoCamera ? 基础.Get(EPhotographCamera.战斗拍照角色开始虚化距离) : 基础.Get(EPhotographCamera.角色开始虚化距离);
			float val2 = isFightPhotoCamera ? 基础.Get(EPhotographCamera.战斗拍照角色最大虚化距离) : 基础.Get(EPhotographCamera.角色最大虚化距离);
			this.StartHideDistance = Math.Max(val, val2) + 50f;
			this.CompleteHideDistance = Math.Min(val, val2) + 50f;
			float val3 = 基础.Get(EPhotographCamera.拍照界面npc开始虚化距离);
			float val4 = 基础.Get(EPhotographCamera.拍照界面npc最大虚化距离);
			this.NpcStartHideDistance = Math.Max(val3, val4) + 50f;
			this.NpcCompleteHideDistance = Math.Min(val3, val4) + 50f;
			this.NpcStartDitherValue = 基础.Get(EPhotographCamera.拍照界面npc虚化不透明度);
			this.CompleteHidePitch = (isFightPhotoCamera ? 基础.Get(EPhotographCamera.战斗拍照角色最大虚化仰视角) : 基础.Get(EPhotographCamera.角色最大虚化仰视角));
			this.StartHideSizeInFrame = 基础.Get(EPhotographCamera.角色开始虚化屏幕占比);
			this.CompleteHideSizeInFrame = 基础.Get(EPhotographCamera.角色最大虚化屏幕占比);
			this.StartDitherValue = (isFightPhotoCamera ? 基础.Get(EPhotographCamera.战斗拍照角色虚化不透明度) : 基础.Get(EPhotographCamera.角色虚化不透明度));
			this.IsLoadingConfigCompleted = true;
		}, 100, "Ui.PhotographUi");
		this.RefreshDitherEffect();
	}

	// Token: 0x06010D6D RID: 68973 RVA: 0x004EFCDC File Offset: 0x004EDEDC
	private void InitCameraNpcSphereTrace()
	{
		this.CameraNpcSphereTrace = new UTraceSphereElement();
		this.CameraNpcSphereTrace.bIsSingle = false;
		this.CameraNpcSphereTrace.bTraceComplex = false;
		this.CameraNpcSphereTrace.bIgnoreSelf = true;
		this.CameraNpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
		this.CameraNpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
		this.CameraNpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
		this.CameraNpcSphereTrace.ActorsToIgnore.Add(this.Character);
	}

	// Token: 0x06010D6E RID: 68974 RVA: 0x004EFD60 File Offset: 0x004EDF60
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveDestroyed()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveDestroyed"), TsPhotographer.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveDestroyed_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06010D6F RID: 68975 RVA: 0x004EFDB9 File Offset: 0x004EDFB9
	protected virtual void ReceiveDestroyed_Implementation()
	{
		this.Character = null;
		this.IsLoadingConfigCompleted = false;
		if (this.CameraNpcSphereTrace != null)
		{
			this.CameraNpcSphereTrace.Dispose();
			this.CameraNpcSphereTrace = null;
		}
	}

	// Token: 0x06010D70 RID: 68976 RVA: 0x004EFDE4 File Offset: 0x004EDFE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D71 RID: 68977 RVA: 0x004EFE70 File Offset: 0x004EE070
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		this.RefreshPlayerLocation();
		if (PhotographController.Instance.CheckIfInFightPhotographCamera())
		{
			this.RefreshTeamDither();
			this.UpdateNpcDither();
			this.RefreshCameraPosition();
		}
		else
		{
			this.RefreshDitherEffect();
		}
		this.RefreshCameraArm();
	}

	// Token: 0x06010D72 RID: 68978 RVA: 0x004EFEA4 File Offset: 0x004EE0A4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void RefreshPlayerLocation()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RefreshPlayerLocation"), TsPhotographer.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RefreshPlayerLocation_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06010D73 RID: 68979 RVA: 0x004EFF00 File Offset: 0x004EE100
	protected void RefreshPlayerLocation_Implementation()
	{
		if (this.PlayerLocation == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = this.PlayerLocation.ToUeVector(false);
		FVectorDouble fvectorDouble2 = this.Character.D_K2_GetActorLocation();
		if (fvectorDouble.Equals(fvectorDouble2, 0.009999999776482582))
		{
			global::Vector playerLocation = this.PlayerLocation;
			fvectorDouble2 = this.Character.D_K2_GetActorLocation();
			playerLocation.FromUeVector(fvectorDouble2);
		}
	}

	// Token: 0x06010D74 RID: 68980 RVA: 0x004EFF5C File Offset: 0x004EE15C
	private void RefreshDitherEffect()
	{
		if (!this.IsLoadingConfigCompleted)
		{
			return;
		}
		if (this.CameraActor == null)
		{
			return;
		}
		if (this.CameraArm == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = this.CameraActor.D_K2_GetActorLocation();
		FVector fvector = fvectorDouble;
		this.CameraLocation.FromUeVector(fvector);
		double distance = global::Vector.Dist(this.PlayerLocation, this.CameraLocation);
		double characterDither = this.GetCharacterDither(this.Character, distance, this.GetArmPitch());
		if (this.CurrentDither == characterDither)
		{
			return;
		}
		this.CurrentDither = characterDither;
		this.Character.SetDitherEffect((float)characterDither, ECharacterDitherType.Fight);
	}

	// Token: 0x06010D75 RID: 68981 RVA: 0x004EFFEC File Offset: 0x004EE1EC
	private void RefreshTeamDither()
	{
		if (!this.IsLoadingConfigCompleted)
		{
			return;
		}
		if (this.CameraActor == null)
		{
			return;
		}
		if (this.CameraArm == null)
		{
			return;
		}
		global::Vector cameraLocation = this.CameraLocation;
		FVectorDouble fvectorDouble = this.CameraActor.D_K2_GetActorLocation();
		cameraLocation.FromUeVector(fvectorDouble);
		float armPitch = this.GetArmPitch();
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
		{
			WorldEntity entity = entityHandle.Entity;
			TsBaseCharacter tsBaseCharacter;
			if (entity == null)
			{
				tsBaseCharacter = null;
			}
			else
			{
				CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
				tsBaseCharacter = ((component != null) ? component.Actor : null);
			}
			TsBaseCharacter tsBaseCharacter2 = tsBaseCharacter;
			if (tsBaseCharacter2 != null && tsBaseCharacter2.IsValid())
			{
				global::Vector tmpVector = this.TmpVector;
				fvectorDouble = tsBaseCharacter2.D_K2_GetActorLocation();
				tmpVector.FromUeVector(fvectorDouble);
				double distance = global::Vector.Dist(this.TmpVector, this.CameraLocation);
				double characterDither = this.GetCharacterDither(tsBaseCharacter2, distance, armPitch);
				double num;
				if (!this.TeamMemberDitherMap.TryGetValue(tsBaseCharacter2, out num) || num != characterDither)
				{
					this.TeamMemberDitherMap[tsBaseCharacter2] = characterDither;
					tsBaseCharacter2.SetDitherEffect((float)characterDither, ECharacterDitherType.Fight);
				}
			}
		}
	}

	// Token: 0x06010D76 RID: 68982 RVA: 0x004F0110 File Offset: 0x004EE310
	private void RefreshCameraArm()
	{
		if (this.PitchInput == 0f && this.YawInput == 0f)
		{
			return;
		}
		Rotator tmpRotator = this.TmpRotator;
		FRotator frotator = this.CapsuleCollision.K2_GetComponentRotation();
		tmpRotator.DeepCopy(frotator);
		this.TmpRotator.Quaternion(this.TmpQuat);
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Quat.ConstructorByAxisAngle(instance.GetGravityUpForActor((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null), this.YawInput * 0.017453292f, this.TmpQuat2);
		this.TmpQuat2.Multiply(this.TmpQuat, this.TmpQuat3);
		this.TmpQuat.DeepCopy(this.TmpQuat3);
		float armPitch = this.GetArmPitch();
		float num = MathUtils.Instance.Clamp(this.PitchInput + armPitch, this.SourceMinPitch, this.SourceMaxPitch) - armPitch;
		if ((double)Math.Abs(num) > 1E-08)
		{
			this.TmpRotator2.Set(num, 0f, 0f);
			this.TmpRotator2.Quaternion(this.TmpQuat2);
			this.TmpQuat.Multiply(this.TmpQuat2, this.TmpQuat3);
			this.TmpQuat.DeepCopy(this.TmpQuat3);
		}
		this.TmpQuat.Rotator(this.TmpRotator);
		FHitResult fhitResult = new FHitResult();
		this.CapsuleCollision.K2_SetRelativeRotation(this.TmpRotator.ToUeRotator(), false, ref fhitResult, false);
		this.PitchInput = 0f;
		this.YawInput = 0f;
	}

	// Token: 0x06010D77 RID: 68983 RVA: 0x004F0290 File Offset: 0x004EE490
	private void RefreshCameraPosition()
	{
		float rightValue = PhotographModel.Instance.RightValue;
		float upValue = PhotographModel.Instance.UpValue;
		float forwardValue = PhotographModel.Instance.ForwardValue;
		if (rightValue == 0f && upValue == 0f && forwardValue == 0f)
		{
			return;
		}
		this.MoveRight(rightValue);
		this.MoveUp(upValue);
		this.MoveForward(forwardValue);
	}

	// Token: 0x06010D78 RID: 68984 RVA: 0x004F02EC File Offset: 0x004EE4EC
	private float GetArmPitch()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		global::Vector gravityUpForActor = instance.GetGravityUpForActor((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
		global::Vector tmpVector = this.TmpVector;
		FVector forwardVector = this.CapsuleCollision.GetForwardVector();
		FVectorDouble fvectorDouble = forwardVector;
		tmpVector.DeepCopy(fvectorDouble);
		return (float)(Math.Asin(this.TmpVector.DotProduct(gravityUpForActor)) * 57.295780181884766);
	}

	// Token: 0x06010D79 RID: 68985 RVA: 0x004F0354 File Offset: 0x004EE554
	[NullableContext(1)]
	private double GetCharacterDither(TsBaseCharacter character, double distance, float cameraPitch)
	{
		List<double> list = new List<double>
		{
			1.0
		};
		if ((PhotographController.Instance.CheckIfInFightPhotographCamera() || PhotographController.Instance.CheckIfInNormalCamera()) && ((character != null) ? character.CharacterActorComponent : null) != null)
		{
			float num = (float)Math.Atan((double)character.CharacterActorComponent.HalfHeight / distance) * 57.29578f * 2f / this.GetFov();
			if (num > this.StartHideSizeInFrame)
			{
				list.Add((double)MathUtils.Instance.RangeClamp(num, this.StartHideSizeInFrame, this.CompleteHideSizeInFrame, this.StartDitherValue, 0.01f));
			}
		}
		if (distance < (double)this.StartHideDistance)
		{
			list.Add(MathUtils.Instance.RangeClamp(distance, (double)this.StartHideDistance, (double)this.CompleteHideDistance, (double)this.StartDitherValue, 0.009999999776482582));
		}
		float num2 = MathUtils.Instance.WrapAngle(cameraPitch);
		if (num2 > this.StartHidePitch)
		{
			list.Add((double)MathUtils.Instance.RangeClamp(num2, this.StartHidePitch, this.CompleteHidePitch, this.StartDitherValue, 0.01f));
		}
		double num3 = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i] < num3)
			{
				num3 = list[i];
			}
		}
		return num3;
	}

	// Token: 0x06010D7A RID: 68986 RVA: 0x004F04A0 File Offset: 0x004EE6A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetPlayerSourceLocation(FVectorDouble location)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetPlayerSourceLocation"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.SetPlayerSourceLocation_Implementation(location);
			return;
		}
		TsPhotographer.__SetPlayerSourceLocation_FunctionParams* ptr = stackalloc TsPhotographer.__SetPlayerSourceLocation_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__SetPlayerSourceLocation_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->location = location;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D7B RID: 68987 RVA: 0x004F052C File Offset: 0x004EE72C
	protected void SetPlayerSourceLocation_Implementation(FVectorDouble location)
	{
		this.PlayerSourceLocation = new FVectorDouble?(location);
	}

	// Token: 0x06010D7C RID: 68988 RVA: 0x004F053C File Offset: 0x004EE73C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraInitializeTransform(FTransformDouble transform)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetCameraInitializeTransform"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.SetCameraInitializeTransform_Implementation(transform);
			return;
		}
		TsPhotographer.__SetCameraInitializeTransform_FunctionParams* ptr = stackalloc TsPhotographer.__SetCameraInitializeTransform_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__SetCameraInitializeTransform_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->transform = transform;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D7D RID: 68989 RVA: 0x004F05C8 File Offset: 0x004EE7C8
	protected void SetCameraInitializeTransform_Implementation(FTransformDouble transform)
	{
		this.CameraInitializeTransform = new FTransformDouble?(transform);
	}

	// Token: 0x06010D7E RID: 68990 RVA: 0x004F05D8 File Offset: 0x004EE7D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual FTransformDouble GetCameraInitializeTransform()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetCameraInitializeTransform"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			return this.GetCameraInitializeTransform_Implementation();
		}
		TsPhotographer.__GetCameraInitializeTransform_FunctionParams* ptr = stackalloc TsPhotographer.__GetCameraInitializeTransform_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__GetCameraInitializeTransform_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		FTransformDouble _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06010D7F RID: 68991 RVA: 0x004F0662 File Offset: 0x004EE862
	protected FTransformDouble GetCameraInitializeTransform_Implementation()
	{
		return this.CameraInitializeTransform.Value;
	}

	// Token: 0x06010D80 RID: 68992 RVA: 0x004F0670 File Offset: 0x004EE870
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraInitializeFov(float fov)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetCameraInitializeFov"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.SetCameraInitializeFov_Implementation(fov);
			return;
		}
		TsPhotographer.__SetCameraInitializeFov_FunctionParams* ptr = stackalloc TsPhotographer.__SetCameraInitializeFov_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__SetCameraInitializeFov_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->fov = fov;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D81 RID: 68993 RVA: 0x004F06FC File Offset: 0x004EE8FC
	protected void SetCameraInitializeFov_Implementation(float fov)
	{
		this.CameraInitializeFov = fov;
	}

	// Token: 0x06010D82 RID: 68994 RVA: 0x004F0708 File Offset: 0x004EE908
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetCameraInitializeFov()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetCameraInitializeFov"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			return this.GetCameraInitializeFov_Implementation();
		}
		TsPhotographer.__GetCameraInitializeFov_FunctionParams* ptr = stackalloc TsPhotographer.__GetCameraInitializeFov_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__GetCameraInitializeFov_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06010D83 RID: 68995 RVA: 0x004F0792 File Offset: 0x004EE992
	protected float GetCameraInitializeFov_Implementation()
	{
		if (this.CameraInitializeFov != -1f)
		{
			return this.CameraInitializeFov;
		}
		return 60f;
	}

	// Token: 0x06010D84 RID: 68996 RVA: 0x004F07AD File Offset: 0x004EE9AD
	[NullableContext(1)]
	public void ActivateCamera(ACineCameraActor cameraActor)
	{
		cameraActor.K2_AttachToComponent(this.CameraArm, FNameUtil.NONE, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
		this.CameraActor = cameraActor;
		if (!PhotographController.Instance.CheckIfInFightPhotographCamera())
		{
			this.SetFov(60f);
		}
	}

	// Token: 0x06010D85 RID: 68997 RVA: 0x004F07E3 File Offset: 0x004EE9E3
	public void DeactivateCamera()
	{
		ACineCameraActor cameraActor = this.CameraActor;
		if (cameraActor != null && cameraActor.IsValid())
		{
			this.CameraActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}
		this.CameraActor = null;
	}

	// Token: 0x06010D86 RID: 68998 RVA: 0x004F0810 File Offset: 0x004EEA10
	public void SetCameraTransform(FTransform transform)
	{
		FVector translation = transform.GetTranslation();
		FVectorDouble fvectorDouble = this.CameraActor.D_K2_GetActorLocation();
		FVector fvector = fvectorDouble;
		this.RelativeVectorCache = new FVector?(new FVector(translation.X - fvector.X, translation.Y - fvector.Y, translation.Z - fvector.Z));
		FHitResult fhitResult = null;
		base.K2_AddActorWorldOffset(this.RelativeVectorCache.Value, false, ref fhitResult, false);
	}

	// Token: 0x06010D87 RID: 68999 RVA: 0x004F0888 File Offset: 0x004EEA88
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraArmTargetOffset(FVectorDouble cameraLocation, bool isInit = false)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetCameraArmTargetOffset"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.SetCameraArmTargetOffset_Implementation(cameraLocation, isInit);
			return;
		}
		TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* ptr = stackalloc TsPhotographer.__SetCameraArmTargetOffset_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->cameraLocation = cameraLocation;
		ptr->isInit = isInit;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D88 RID: 69000 RVA: 0x004F091C File Offset: 0x004EEB1C
	protected void SetCameraArmTargetOffset_Implementation(FVectorDouble cameraLocation, bool isInit = false)
	{
		FRotator frotator = this.CameraArm.K2_GetComponentRotation();
		FVectorDouble fvectorDouble = base.D_K2_GetActorLocation();
		FVectorDouble fvectorDouble2 = new FVectorDouble((double)(-(double)this.CameraArm.TargetArmLength), 0.0, 0.0);
		FVectorDouble fvectorDouble3 = frotator.RotateVectorDouble(fvectorDouble2);
		FVectorDouble fvectorDouble4 = fvectorDouble + fvectorDouble3;
		FVectorDouble fvectorDouble5 = cameraLocation - fvectorDouble4;
		FQuat fquat = frotator.Quaternion();
		FQuat fquat2 = new FQuat(-fquat.X, -fquat.Y, -fquat.Z, fquat.W);
		fvectorDouble2 = fquat2.RotateVectorDouble(fvectorDouble5);
		FVector fvector = fvectorDouble2.ToVector();
		this.CameraArm.SocketOffset = fvector;
		if (isInit)
		{
			this.CameraArmInitializeSocketOffset = fvector;
		}
	}

	// Token: 0x06010D89 RID: 69001 RVA: 0x004F09DC File Offset: 0x004EEBDC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MoveUp(float addValue)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MoveUp"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.MoveUp_Implementation(addValue);
			return;
		}
		TsPhotographer.__MoveUp_FunctionParams* ptr = stackalloc TsPhotographer.__MoveUp_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__MoveUp_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->addValue = addValue;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D8A RID: 69002 RVA: 0x004F0A68 File Offset: 0x004EEC68
	protected void MoveUp_Implementation(float addValue)
	{
		float num = addValue * this.CameraUpAndDownSpeed;
		if (Math.Abs(this.CurCameraUpAndDownDistance + num) < this.CameraUpAndDownMaxDistance)
		{
			global::Vector vectorInGravity = GravityUtils.Instance.GetVectorInGravity(global::Vector.UpVectorProxy, this.GravityQuat, this.TmpVector);
			this.CurCameraUpAndDownDistance += num;
			global::Vector vector = vectorInGravity.Multiply((double)num, this.TmpVector);
			GravityUtils.Instance.GetVectorInNormal(vector, this.InverseGravityQuat, this.TmpVector2);
			USpringArmComponent cameraArm = this.CameraArm;
			FVector socketOffset = this.CameraArm.SocketOffset;
			FVector fvector = this.TmpVector2.ToUeVectorOld();
			cameraArm.SocketOffset = socketOffset + fvector;
		}
	}

	// Token: 0x06010D8B RID: 69003 RVA: 0x004F0B10 File Offset: 0x004EED10
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MoveRight(float addValue)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MoveRight"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.MoveRight_Implementation(addValue);
			return;
		}
		TsPhotographer.__MoveRight_FunctionParams* ptr = stackalloc TsPhotographer.__MoveRight_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__MoveRight_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->addValue = addValue;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D8C RID: 69004 RVA: 0x004F0B9C File Offset: 0x004EED9C
	protected void MoveRight_Implementation(float addValue)
	{
		float num = addValue * this.CameraLeftAndRightSpeed;
		if (Math.Abs(this.CurCameraLeftAndRightDistance + num) < this.CameraLeftAndRightMaxDistance)
		{
			global::Vector vectorInGravity = GravityUtils.Instance.GetVectorInGravity(global::Vector.RightVectorProxy, this.GravityQuat, this.TmpVector);
			this.CurCameraLeftAndRightDistance += num;
			global::Vector vector = vectorInGravity.Multiply((double)num, this.TmpVector);
			GravityUtils.Instance.GetVectorInNormal(vector, this.InverseGravityQuat, this.TmpVector2);
			USpringArmComponent cameraArm = this.CameraArm;
			FVector socketOffset = this.CameraArm.SocketOffset;
			FVector fvector = this.TmpVector2.ToUeVectorOld();
			cameraArm.SocketOffset = socketOffset + fvector;
		}
	}

	// Token: 0x06010D8D RID: 69005 RVA: 0x004F0C44 File Offset: 0x004EEE44
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MoveForward(float addValue)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("MoveForward"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.MoveForward_Implementation(addValue);
			return;
		}
		TsPhotographer.__MoveForward_FunctionParams* ptr = stackalloc TsPhotographer.__MoveForward_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__MoveForward_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->addValue = addValue;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D8E RID: 69006 RVA: 0x004F0CD0 File Offset: 0x004EEED0
	protected void MoveForward_Implementation(float addValue)
	{
		float num = addValue * this.CameraForwardAndBackSpeed;
		if (Math.Abs(this.CurCameraForwardAndBackDistance + num) < this.CameraForwardAndBackMaxDistance)
		{
			global::Vector vectorInGravity = GravityUtils.Instance.GetVectorInGravity(global::Vector.ForwardVectorProxy, this.GravityQuat, this.TmpVector);
			this.CurCameraForwardAndBackDistance += num;
			global::Vector vector = vectorInGravity.Multiply((double)num, this.TmpVector);
			GravityUtils.Instance.GetVectorInNormal(vector, this.InverseGravityQuat, this.TmpVector2);
			USpringArmComponent cameraArm = this.CameraArm;
			FVector socketOffset = this.CameraArm.SocketOffset;
			FVector fvector = this.TmpVector2.ToUeVectorOld();
			cameraArm.SocketOffset = socketOffset + fvector;
		}
	}

	// Token: 0x06010D8F RID: 69007 RVA: 0x004F0D78 File Offset: 0x004EEF78
	public void AddCameraArmPitchInput(float pitch)
	{
		if (pitch == 0f)
		{
			return;
		}
		float pitch2 = this.CameraArm.GetTargetRotation().Pitch;
		if (pitch > 0f && pitch2 <= this.SourceMinPitch)
		{
			return;
		}
		if (pitch < 0f && pitch2 >= this.SourceMaxPitch)
		{
			return;
		}
		this.PitchInput = pitch;
	}

	// Token: 0x06010D90 RID: 69008 RVA: 0x004F0DCA File Offset: 0x004EEFCA
	public void AddCameraArmYawInput(float yaw)
	{
		if (yaw == 0f)
		{
			return;
		}
		this.YawInput = yaw;
	}

	// Token: 0x06010D91 RID: 69009 RVA: 0x004F0DDC File Offset: 0x004EEFDC
	public void SetCameraArmRoll(float roll)
	{
		Rotator tmpRotator = this.TmpRotator;
		FRotator frotator = this.CapsuleCollision.K2_GetComponentRotation();
		tmpRotator.DeepCopy(frotator);
		this.TmpRotator.Roll = this.InitialCapsuleRoll + roll;
		FHitResult fhitResult = new FHitResult();
		this.CapsuleCollision.K2_SetRelativeRotation(this.TmpRotator.ToUeRotator(), true, ref fhitResult, false);
	}

	// Token: 0x06010D92 RID: 69010 RVA: 0x004F0E38 File Offset: 0x004EF038
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetFov(float fov)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetFov"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.SetFov_Implementation(fov);
			return;
		}
		TsPhotographer.__SetFov_FunctionParams* ptr = stackalloc TsPhotographer.__SetFov_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__SetFov_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->fov = fov;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D93 RID: 69011 RVA: 0x004F0EC4 File Offset: 0x004EF0C4
	protected void SetFov_Implementation(float fov)
	{
		double num;
		if (PhotographController.Instance.CheckIfInEntityCamera())
		{
			num = MathUtils.Instance.Clamp((double)fov, (PhotographController.Instance.MinFov != null) ? double.Parse(PhotographController.Instance.MinFov.Value.Value) : 30.0, (PhotographController.Instance.MaxFov != null) ? double.Parse(PhotographController.Instance.MaxFov.Value.Value) : 90.0);
		}
		else
		{
			num = (double)MathUtils.Instance.Clamp(fov, this.MinFov, this.MaxFov);
		}
		this.CameraActor.CameraComponent.SetFieldOfView((float)num);
	}

	// Token: 0x06010D94 RID: 69012 RVA: 0x004F0F94 File Offset: 0x004EF194
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetFov()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetFov"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			return this.GetFov_Implementation();
		}
		TsPhotographer.__GetFov_FunctionParams* ptr = stackalloc TsPhotographer.__GetFov_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__GetFov_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06010D95 RID: 69013 RVA: 0x004F101E File Offset: 0x004EF21E
	protected float GetFov_Implementation()
	{
		return this.CameraActor.CameraComponent.FieldOfView;
	}

	// Token: 0x06010D96 RID: 69014 RVA: 0x004F1030 File Offset: 0x004EF230
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ResetCamera()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ResetCamera"), TsPhotographer.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ResetCamera_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06010D97 RID: 69015 RVA: 0x004F108C File Offset: 0x004EF28C
	protected void ResetCamera_Implementation()
	{
		FHitResult fhitResult = new FHitResult();
		this.CapsuleCollision.K2_SetRelativeRotation(this.DefaultRotation.Value, true, ref fhitResult, false);
		FTransformDouble value = this.CameraInitializeTransform.Value;
		this.D_K2_SetActorTransform(value, true, null, false);
		base.D_K2_SetActorLocation(this.PlayerSourceLocation.Value, true, ref fhitResult, false);
		float cameraInitializeFov = this.GetCameraInitializeFov();
		this.SetFov(cameraInitializeFov);
		this.CameraArm.SocketOffset = this.CameraArmInitializeSocketOffset;
		this.CurCameraUpAndDownDistance = 0f;
		this.CurCameraLeftAndRightDistance = 0f;
		this.CurCameraForwardAndBackDistance = 0f;
		this.CurrentDither = 0.0;
		this.TeamMemberDitherMap.Clear();
		this.PitchInput = 0f;
		this.YawInput = 0f;
	}

	// Token: 0x06010D98 RID: 69016 RVA: 0x004F1158 File Offset: 0x004EF358
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraLUT(string texturePath)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsPhotographer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetCameraLUT"), TsPhotographer.StaticClass(), out intPtr, out num))
		{
			this.SetCameraLUT_Implementation(texturePath);
			return;
		}
		TsPhotographer.__SetCameraLUT_FunctionParams* ptr = stackalloc TsPhotographer.__SetCameraLUT_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsPhotographer.__SetCameraLUT_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->texturePath), texturePath);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06010D99 RID: 69017 RVA: 0x004F11EC File Offset: 0x004EF3EC
	[NullableContext(1)]
	protected void SetCameraLUT_Implementation(string texturePath)
	{
		if (this.CameraActor == null)
		{
			return;
		}
		if (texturePath.Length == 0)
		{
			this.CameraActor.CameraComponent.PostProcessSettings.bOverride_ColorGradingLUT = false;
			return;
		}
		this.CameraActor.CameraComponent.PostProcessSettings.bOverride_ColorGradingLUT = true;
		ResourceSystem.Instance.LoadAsync<UTexture>(texturePath, delegate([Nullable(2)] UTexture image, string _)
		{
			this.CameraActor.CameraComponent.PostProcessSettings.ColorGradingLUT = image;
		}, 100, "Ui.PhotographUi");
	}

	// Token: 0x06010D9A RID: 69018 RVA: 0x004F1258 File Offset: 0x004EF458
	private void UpdateNpcDither()
	{
		this.UpdateCameraCollisionRadius();
		this.UpdateCameraCollisionLocation();
		UKuroHitResult hitResult = this.CameraNpcSphereTrace.HitResult;
		if (hitResult != null)
		{
			hitResult.Clear();
		}
		this.CameraNpcSphereTrace.WorldContextObject = GlobalData.World;
		this.CameraNpcSphereTrace.Radius = (float)this.CameraCollisionRadius;
		TraceElementCommon.Instance.SetStartLocation(this.CameraNpcSphereTrace, this.CameraLocation);
		TraceElementCommon.Instance.SetEndLocation(this.CameraNpcSphereTrace, this.CameraCollisionLocation);
		bool flag = TraceElementCommon.Instance.SphereTrace(this.CameraNpcSphereTrace, "TsPhotographer_CheckCollision_Npc");
		int hitCount = this.CameraNpcSphereTrace.HitResult.GetHitCount();
		if (flag)
		{
			this.UpdateDitheredNpcDistance(this.CameraNpcSphereTrace.HitResult);
			foreach (KeyValuePair<TsBaseCharacter, double> keyValuePair in this.DitheredNpcDistanceMap)
			{
				TsBaseCharacter key = keyValuePair.Key;
				double value = keyValuePair.Value;
				if (this.IsCharacterIgnoreNpcDither(key))
				{
					key.SetDitherEffect(1f, ECharacterDitherType.Temporary);
				}
				else
				{
					key.SetDitherEffect((float)this.GetNpcDitherValue(key, value), ECharacterDitherType.Temporary);
					if (this.DitheredNpcSet.Contains(key))
					{
						this.DitheredNpcSet.Remove(key);
					}
					this.DitheredNpcSet.Add(key);
				}
			}
		}
		List<TsBaseCharacter> list = new List<TsBaseCharacter>(this.DitheredNpcSet);
		for (int i = 0; i < this.DitheredNpcSet.Count - hitCount; i++)
		{
			TsBaseCharacter tsBaseCharacter = list[i];
			if (this.IsCharacterRenderingType(tsBaseCharacter))
			{
				tsBaseCharacter.SetDitherEffect(1f, ECharacterDitherType.Temporary);
			}
			this.DitheredNpcSet.Remove(tsBaseCharacter);
		}
	}

	// Token: 0x06010D9B RID: 69019 RVA: 0x004F1414 File Offset: 0x004EF614
	private void UpdateCameraCollisionRadius()
	{
		if (MathUtils.Instance.IsNearlyEqual((double)this.CurrentCameraDitherFov, (double)this.GetFov(), null))
		{
			return;
		}
		this.CurrentCameraDitherFov = this.GetFov();
		float startHideDistance = this.StartHideDistance;
		float aspectRatio = this.CameraActor.CameraComponent.AspectRatio;
		float num = (float)(Math.Sin(MathUtils.Instance.VerticalFovToHorizontally((double)this.CurrentCameraDitherFov, (double)aspectRatio) / 2.0 * 0.01745329238474369) * (double)startHideDistance * 2.0);
		this.CameraCollisionRadius = MathUtils.Instance.GetTriangleCircumradius((double)startHideDistance, (double)startHideDistance, (double)num);
	}

	// Token: 0x06010D9C RID: 69020 RVA: 0x004F14BC File Offset: 0x004EF6BC
	private void UpdateCameraCollisionLocation()
	{
		FVectorDouble fvectorDouble = this.CameraActor.D_GetActorForwardVector();
		FVector fvector = fvectorDouble;
		fvector.Normalize(1E-08f);
		fvector.Set(fvector.X * (float)this.CameraCollisionRadius, fvector.Y * (float)this.CameraCollisionRadius, fvector.Z * (float)this.CameraCollisionRadius);
		this.CameraLocation.Addition(this.TmpVector, this.CameraCollisionLocation);
	}

	// Token: 0x06010D9D RID: 69021 RVA: 0x004F1534 File Offset: 0x004EF734
	[NullableContext(1)]
	private bool IsCharacterIgnoreNpcDither(TsBaseCharacter character)
	{
		Entity entityNoBlueprint = character.GetEntityNoBlueprint();
		if (entityNoBlueprint == null)
		{
			return false;
		}
		BaseTagComponent component = entityNoBlueprint.GetComponent<BaseTagComponent>();
		return ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.忽略碰撞隐藏"])) : null).GetValueOrDefault();
	}

	// Token: 0x06010D9E RID: 69022 RVA: 0x004F1584 File Offset: 0x004EF784
	[NullableContext(1)]
	private void UpdateDitheredNpcDistance(UKuroHitResult hitResult)
	{
		int hitCount = hitResult.GetHitCount();
		this.DitheredNpcDistanceMap.Clear();
		for (int i = 0; i < hitCount; i++)
		{
			TsBaseCharacter tsBaseCharacter = hitResult.Actors.Get(i).Get() as TsBaseCharacter;
			if (tsBaseCharacter != null && tsBaseCharacter != null && tsBaseCharacter.IsValid() && this.IsCharacterRenderingType(tsBaseCharacter))
			{
				TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TmpVector);
				double num2;
				double num = this.DitheredNpcDistanceMap.TryGetValue(tsBaseCharacter, out num2) ? num2 : 9999999.0;
				double num3 = global::Vector.Dist(this.TmpVector, this.CameraLocation);
				if (num3 < num)
				{
					this.DitheredNpcDistanceMap[tsBaseCharacter] = num3;
				}
			}
		}
	}

	// Token: 0x06010D9F RID: 69023 RVA: 0x004F163D File Offset: 0x004EF83D
	[NullableContext(1)]
	private bool IsCharacterRenderingType(AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return false;
		}
		if (actor is TsBaseCharacter)
		{
			EntityHandle handle = CharacterModel.Instance.GetHandle((actor as TsBaseCharacter).GetEntityIdNoBlueprint());
			return handle != null && handle.Valid;
		}
		return false;
	}

	// Token: 0x06010DA0 RID: 69024 RVA: 0x004F167C File Offset: 0x004EF87C
	[NullableContext(1)]
	private double GetNpcDitherValue(TsBaseCharacter actor, double distance)
	{
		if (actor == null || !actor.IsValid() || actor.CapsuleComponent == null)
		{
			return 1.0;
		}
		double num = 1.0;
		if (distance < (double)this.NpcStartHideDistance)
		{
			num = MathUtils.Instance.RangeClamp(distance, (double)this.NpcStartHideDistance, (double)this.NpcCompleteHideDistance, (double)this.NpcStartDitherValue, 0.009999999776482582);
		}
		return num;
	}

	// Token: 0x06010DA1 RID: 69025 RVA: 0x004F16EC File Offset: 0x004EF8EC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsPhotographer._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographer.TsPhotographer_C");
		}
		return TsPhotographer._ClassPtr;
	}

	// Token: 0x06010DA2 RID: 69026 RVA: 0x004F1710 File Offset: 0x004EF910
	public TsPhotographer() : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06010DA3 RID: 69027 RVA: 0x004F1738 File Offset: 0x004EF938
	[NullableContext(1)]
	public TsPhotographer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06010DA4 RID: 69028 RVA: 0x004F176C File Offset: 0x004EF96C
	protected TsPhotographer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001964 RID: 6500
	// (get) Token: 0x06010DA5 RID: 69029 RVA: 0x004F18C3 File Offset: 0x004EFAC3
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographer.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06010DA6 RID: 69030 RVA: 0x004F18D7 File Offset: 0x004EFAD7
	protected virtual void __CPPCALL_Initialize_Implementation()
	{
		this.Initialize_Implementation();
	}

	// Token: 0x06010DA7 RID: 69031 RVA: 0x004F18DF File Offset: 0x004EFADF
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x06010DA8 RID: 69032 RVA: 0x004F18E7 File Offset: 0x004EFAE7
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06010DA9 RID: 69033 RVA: 0x004F18F5 File Offset: 0x004EFAF5
	protected virtual void __CPPCALL_RefreshPlayerLocation_Implementation()
	{
		this.RefreshPlayerLocation_Implementation();
	}

	// Token: 0x06010DAA RID: 69034 RVA: 0x004F18FD File Offset: 0x004EFAFD
	protected unsafe virtual void __CPPCALL_SetPlayerSourceLocation_Implementation(TsPhotographer.__SetPlayerSourceLocation_FunctionParams* __Params)
	{
		this.SetPlayerSourceLocation_Implementation(__Params->location);
	}

	// Token: 0x06010DAB RID: 69035 RVA: 0x004F190B File Offset: 0x004EFB0B
	protected unsafe virtual void __CPPCALL_SetCameraInitializeTransform_Implementation(TsPhotographer.__SetCameraInitializeTransform_FunctionParams* __Params)
	{
		this.SetCameraInitializeTransform_Implementation(__Params->transform);
	}

	// Token: 0x06010DAC RID: 69036 RVA: 0x004F1919 File Offset: 0x004EFB19
	protected unsafe virtual void __CPPCALL_GetCameraInitializeTransform_Implementation(TsPhotographer.__GetCameraInitializeTransform_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCameraInitializeTransform_Implementation();
	}

	// Token: 0x06010DAD RID: 69037 RVA: 0x004F1927 File Offset: 0x004EFB27
	protected unsafe virtual void __CPPCALL_SetCameraInitializeFov_Implementation(TsPhotographer.__SetCameraInitializeFov_FunctionParams* __Params)
	{
		this.SetCameraInitializeFov_Implementation(__Params->fov);
	}

	// Token: 0x06010DAE RID: 69038 RVA: 0x004F1935 File Offset: 0x004EFB35
	protected unsafe virtual void __CPPCALL_GetCameraInitializeFov_Implementation(TsPhotographer.__GetCameraInitializeFov_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCameraInitializeFov_Implementation();
	}

	// Token: 0x06010DAF RID: 69039 RVA: 0x004F1943 File Offset: 0x004EFB43
	protected unsafe virtual void __CPPCALL_SetCameraArmTargetOffset_Implementation(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* __Params)
	{
		this.SetCameraArmTargetOffset_Implementation(__Params->cameraLocation, __Params->isInit);
	}

	// Token: 0x06010DB0 RID: 69040 RVA: 0x004F1957 File Offset: 0x004EFB57
	protected unsafe virtual void __CPPCALL_MoveUp_Implementation(TsPhotographer.__MoveUp_FunctionParams* __Params)
	{
		this.MoveUp_Implementation(__Params->addValue);
	}

	// Token: 0x06010DB1 RID: 69041 RVA: 0x004F1965 File Offset: 0x004EFB65
	protected unsafe virtual void __CPPCALL_MoveRight_Implementation(TsPhotographer.__MoveRight_FunctionParams* __Params)
	{
		this.MoveRight_Implementation(__Params->addValue);
	}

	// Token: 0x06010DB2 RID: 69042 RVA: 0x004F1973 File Offset: 0x004EFB73
	protected unsafe virtual void __CPPCALL_MoveForward_Implementation(TsPhotographer.__MoveForward_FunctionParams* __Params)
	{
		this.MoveForward_Implementation(__Params->addValue);
	}

	// Token: 0x06010DB3 RID: 69043 RVA: 0x004F1981 File Offset: 0x004EFB81
	protected unsafe virtual void __CPPCALL_SetFov_Implementation(TsPhotographer.__SetFov_FunctionParams* __Params)
	{
		this.SetFov_Implementation(__Params->fov);
	}

	// Token: 0x06010DB4 RID: 69044 RVA: 0x004F198F File Offset: 0x004EFB8F
	protected unsafe virtual void __CPPCALL_GetFov_Implementation(TsPhotographer.__GetFov_FunctionParams* __Params)
	{
		__Params->__Result = this.GetFov_Implementation();
	}

	// Token: 0x06010DB5 RID: 69045 RVA: 0x004F199D File Offset: 0x004EFB9D
	protected virtual void __CPPCALL_ResetCamera_Implementation()
	{
		this.ResetCamera_Implementation();
	}

	// Token: 0x06010DB6 RID: 69046 RVA: 0x004F19A8 File Offset: 0x004EFBA8
	protected unsafe virtual void __CPPCALL_SetCameraLUT_Implementation(TsPhotographer.__SetCameraLUT_FunctionParams* __Params)
	{
		string cameraLUT_Implementation = FString.ToString((void*)(&__Params->texturePath));
		this.SetCameraLUT_Implementation(cameraLUT_Implementation);
	}

	// Token: 0x040094C5 RID: 38085
	[Nullable(1)]
	private const string CONFIG_PATH = "/Game/Aki/Data/Camera/DA_PhotographCameraConfig.DA_PhotographCameraConfig";

	// Token: 0x040094C6 RID: 38086
	[Nullable(1)]
	private const string MOBILE_CONFIG_PATH = "/Game/Aki/Data/Camera/DA_PhotographCameraConfig_Mobile.DA_PhotographCameraConfig_Mobile";

	// Token: 0x040094C7 RID: 38087
	private const float MIN_DITHER = 0.01f;

	// Token: 0x040094C8 RID: 38088
	private const int HIDE_DISTANCE_OFFSET = 50;

	// Token: 0x040094C9 RID: 38089
	[Nullable(2)]
	private ACineCameraActor CameraActor;

	// Token: 0x040094CA RID: 38090
	private FVector? RelativeVectorCache;

	// Token: 0x040094CB RID: 38091
	private FVectorDouble? PlayerSourceLocation;

	// Token: 0x040094CC RID: 38092
	private FTransformDouble? CameraInitializeTransform;

	// Token: 0x040094CD RID: 38093
	private FRotator? DefaultRotation;

	// Token: 0x040094CE RID: 38094
	private float InitialCapsuleRoll;

	// Token: 0x040094CF RID: 38095
	private float SourceMaxPitch;

	// Token: 0x040094D0 RID: 38096
	private float SourceMinPitch;

	// Token: 0x040094D1 RID: 38097
	[Nullable(2)]
	private TsBaseCharacter Character;

	// Token: 0x040094D2 RID: 38098
	private float StartDitherValue;

	// Token: 0x040094D3 RID: 38099
	private float NpcStartDitherValue;

	// Token: 0x040094D4 RID: 38100
	private float StartHidePitch;

	// Token: 0x040094D5 RID: 38101
	private float CompleteHidePitch;

	// Token: 0x040094D6 RID: 38102
	private bool IsLoadingConfigCompleted;

	// Token: 0x040094D7 RID: 38103
	private double CurrentDither;

	// Token: 0x040094D8 RID: 38104
	[Nullable(2)]
	private global::Vector PlayerLocation;

	// Token: 0x040094D9 RID: 38105
	[Nullable(2)]
	private global::Vector CameraLocation;

	// Token: 0x040094DA RID: 38106
	private float StartHideDistance;

	// Token: 0x040094DB RID: 38107
	private float CompleteHideDistance;

	// Token: 0x040094DC RID: 38108
	private float StartHideSizeInFrame;

	// Token: 0x040094DD RID: 38109
	private float CompleteHideSizeInFrame;

	// Token: 0x040094DE RID: 38110
	private float NpcStartHideDistance;

	// Token: 0x040094DF RID: 38111
	private float NpcCompleteHideDistance;

	// Token: 0x040094E0 RID: 38112
	private float PitchInput;

	// Token: 0x040094E1 RID: 38113
	private float YawInput;

	// Token: 0x040094E2 RID: 38114
	[Nullable(1)]
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x040094E3 RID: 38115
	[Nullable(1)]
	private readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x040094E4 RID: 38116
	[Nullable(1)]
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x040094E5 RID: 38117
	[Nullable(1)]
	private readonly Rotator TmpRotator2 = Rotator.Create();

	// Token: 0x040094E6 RID: 38118
	[Nullable(1)]
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040094E7 RID: 38119
	[Nullable(1)]
	private readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040094E8 RID: 38120
	[Nullable(1)]
	private readonly Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040094E9 RID: 38121
	[Nullable(1)]
	public readonly Quat GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040094EA RID: 38122
	[Nullable(1)]
	public readonly Quat InverseGravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040094EB RID: 38123
	[Nullable(2)]
	private UTraceSphereElement CameraNpcSphereTrace;

	// Token: 0x040094EC RID: 38124
	[Nullable(1)]
	private Dictionary<TsBaseCharacter, double> DitheredNpcDistanceMap = new Dictionary<TsBaseCharacter, double>();

	// Token: 0x040094ED RID: 38125
	private float CurrentCameraDitherFov;

	// Token: 0x040094EE RID: 38126
	private double CameraCollisionRadius;

	// Token: 0x040094EF RID: 38127
	[Nullable(1)]
	private readonly global::Vector CameraCollisionLocation = global::Vector.Create();

	// Token: 0x040094F0 RID: 38128
	[Nullable(1)]
	private HashSet<TsBaseCharacter> DitheredNpcSet = new HashSet<TsBaseCharacter>();

	// Token: 0x040094F1 RID: 38129
	[Nullable(1)]
	private Dictionary<TsBaseCharacter, double> TeamMemberDitherMap = new Dictionary<TsBaseCharacter, double>();

	// Token: 0x040094F2 RID: 38130
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographer.TsPhotographer_C";

	// Token: 0x040094F3 RID: 38131
	private static IntPtr _ClassPtr;

	// Token: 0x040094F4 RID: 38132
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040094F5 RID: 38133
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x040094F6 RID: 38134
	private static int __PropertyOffset_CapsuleCollision;

	// Token: 0x040094F7 RID: 38135
	private static int __PropertyOffset_CameraArm;

	// Token: 0x040094F8 RID: 38136
	private static int __PropertyOffset_CameraInitializeFov;

	// Token: 0x040094F9 RID: 38137
	private static int __PropertyOffset_CameraArmInitializeSocketOffset;

	// Token: 0x040094FA RID: 38138
	private static int __PropertyOffset_CameraUpAndDownMaxDistance;

	// Token: 0x040094FB RID: 38139
	private static int __PropertyOffset_CameraLeftAndRightMaxDistance;

	// Token: 0x040094FC RID: 38140
	private static int __PropertyOffset_CameraForwardAndBackMaxDistance;

	// Token: 0x040094FD RID: 38141
	private static int __PropertyOffset_CameraUpAndDownSpeed;

	// Token: 0x040094FE RID: 38142
	private static int __PropertyOffset_CameraLeftAndRightSpeed;

	// Token: 0x040094FF RID: 38143
	private static int __PropertyOffset_CameraForwardAndBackSpeed;

	// Token: 0x04009500 RID: 38144
	private static int __PropertyOffset_MinFov;

	// Token: 0x04009501 RID: 38145
	private static int __PropertyOffset_MaxFov;

	// Token: 0x04009502 RID: 38146
	private static int __PropertyOffset_CurCameraUpAndDownDistance;

	// Token: 0x04009503 RID: 38147
	private static int __PropertyOffset_CurCameraLeftAndRightDistance;

	// Token: 0x04009504 RID: 38148
	private static int __PropertyOffset_CurCameraForwardAndBackDistance;

	// Token: 0x02007D2A RID: 32042
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetPlayerSourceLocation_FunctionParams
	{
		// Token: 0x04028865 RID: 165989
		[FieldOffset(0)]
		public FVectorDouble location;
	}

	// Token: 0x02007D2B RID: 32043
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetCameraInitializeTransform_FunctionParams
	{
		// Token: 0x04028866 RID: 165990
		[FieldOffset(0)]
		public FTransformDouble transform;
	}

	// Token: 0x02007D2C RID: 32044
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __GetCameraInitializeTransform_FunctionParams
	{
		// Token: 0x04028867 RID: 165991
		[FieldOffset(0)]
		public FTransformDouble __Result;
	}

	// Token: 0x02007D2D RID: 32045
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetCameraInitializeFov_FunctionParams
	{
		// Token: 0x04028868 RID: 165992
		[FieldOffset(0)]
		public float fov;
	}

	// Token: 0x02007D2E RID: 32046
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetCameraInitializeFov_FunctionParams
	{
		// Token: 0x04028869 RID: 165993
		[FieldOffset(0)]
		public float __Result;
	}

	// Token: 0x02007D2F RID: 32047
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetCameraArmTargetOffset_FunctionParams
	{
		// Token: 0x0402886A RID: 165994
		[FieldOffset(0)]
		public FVectorDouble cameraLocation;

		// Token: 0x0402886B RID: 165995
		[FieldOffset(24)]
		public bool isInit;
	}

	// Token: 0x02007D30 RID: 32048
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __MoveUp_FunctionParams
	{
		// Token: 0x0402886C RID: 165996
		[FieldOffset(0)]
		public float addValue;
	}

	// Token: 0x02007D31 RID: 32049
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __MoveRight_FunctionParams
	{
		// Token: 0x0402886D RID: 165997
		[FieldOffset(0)]
		public float addValue;
	}

	// Token: 0x02007D32 RID: 32050
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __MoveForward_FunctionParams
	{
		// Token: 0x0402886E RID: 165998
		[FieldOffset(0)]
		public float addValue;
	}

	// Token: 0x02007D33 RID: 32051
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetFov_FunctionParams
	{
		// Token: 0x0402886F RID: 165999
		[FieldOffset(0)]
		public float fov;
	}

	// Token: 0x02007D34 RID: 32052
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetFov_FunctionParams
	{
		// Token: 0x04028870 RID: 166000
		[FieldOffset(0)]
		public float __Result;
	}

	// Token: 0x02007D35 RID: 32053
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCameraLUT_FunctionParams
	{
		// Token: 0x04028871 RID: 166001
		[FieldOffset(0)]
		public FString texturePath;
	}
}

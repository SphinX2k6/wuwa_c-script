using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x020025AD RID: 9645
[UClass("/Game/Aki/TypeScript/Game/Module/Photograph/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographer.TsPhotographer_C")]
public class TsPhotographer : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700191B RID: 6427
	// (get) Token: 0x0601386B RID: 79979 RVA: 0x004E0BC7 File Offset: 0x004DEDC7
	// (set) Token: 0x0601386C RID: 79980 RVA: 0x004E0BDB File Offset: 0x004DEDDB
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

	// Token: 0x1700191C RID: 6428
	// (get) Token: 0x0601386D RID: 79981 RVA: 0x004E0BF0 File Offset: 0x004DEDF0
	// (set) Token: 0x0601386E RID: 79982 RVA: 0x004E0C04 File Offset: 0x004DEE04
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

	// Token: 0x1700191D RID: 6429
	// (get) Token: 0x0601386F RID: 79983 RVA: 0x004E0C19 File Offset: 0x004DEE19
	// (set) Token: 0x06013870 RID: 79984 RVA: 0x004E0C29 File Offset: 0x004DEE29
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

	// Token: 0x1700191E RID: 6430
	// (get) Token: 0x06013871 RID: 79985 RVA: 0x004E0C3A File Offset: 0x004DEE3A
	// (set) Token: 0x06013872 RID: 79986 RVA: 0x004E0C4E File Offset: 0x004DEE4E
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

	// Token: 0x1700191F RID: 6431
	// (get) Token: 0x06013873 RID: 79987 RVA: 0x004E0C63 File Offset: 0x004DEE63
	// (set) Token: 0x06013874 RID: 79988 RVA: 0x004E0C73 File Offset: 0x004DEE73
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

	// Token: 0x17001920 RID: 6432
	// (get) Token: 0x06013875 RID: 79989 RVA: 0x004E0C84 File Offset: 0x004DEE84
	// (set) Token: 0x06013876 RID: 79990 RVA: 0x004E0C94 File Offset: 0x004DEE94
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

	// Token: 0x17001921 RID: 6433
	// (get) Token: 0x06013877 RID: 79991 RVA: 0x004E0CA5 File Offset: 0x004DEEA5
	// (set) Token: 0x06013878 RID: 79992 RVA: 0x004E0CB5 File Offset: 0x004DEEB5
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

	// Token: 0x17001922 RID: 6434
	// (get) Token: 0x06013879 RID: 79993 RVA: 0x004E0CC6 File Offset: 0x004DEEC6
	// (set) Token: 0x0601387A RID: 79994 RVA: 0x004E0CD6 File Offset: 0x004DEED6
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

	// Token: 0x17001923 RID: 6435
	// (get) Token: 0x0601387B RID: 79995 RVA: 0x004E0CE7 File Offset: 0x004DEEE7
	// (set) Token: 0x0601387C RID: 79996 RVA: 0x004E0CF7 File Offset: 0x004DEEF7
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

	// Token: 0x17001924 RID: 6436
	// (get) Token: 0x0601387D RID: 79997 RVA: 0x004E0D08 File Offset: 0x004DEF08
	// (set) Token: 0x0601387E RID: 79998 RVA: 0x004E0D18 File Offset: 0x004DEF18
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

	// Token: 0x17001925 RID: 6437
	// (get) Token: 0x0601387F RID: 79999 RVA: 0x004E0D29 File Offset: 0x004DEF29
	// (set) Token: 0x06013880 RID: 80000 RVA: 0x004E0D39 File Offset: 0x004DEF39
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

	// Token: 0x17001926 RID: 6438
	// (get) Token: 0x06013881 RID: 80001 RVA: 0x004E0D4A File Offset: 0x004DEF4A
	// (set) Token: 0x06013882 RID: 80002 RVA: 0x004E0D5A File Offset: 0x004DEF5A
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

	// Token: 0x17001927 RID: 6439
	// (get) Token: 0x06013883 RID: 80003 RVA: 0x004E0D6B File Offset: 0x004DEF6B
	// (set) Token: 0x06013884 RID: 80004 RVA: 0x004E0D7B File Offset: 0x004DEF7B
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

	// Token: 0x17001928 RID: 6440
	// (get) Token: 0x06013885 RID: 80005 RVA: 0x004E0D8C File Offset: 0x004DEF8C
	// (set) Token: 0x06013886 RID: 80006 RVA: 0x004E0D9C File Offset: 0x004DEF9C
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

	// Token: 0x17001929 RID: 6441
	// (get) Token: 0x06013887 RID: 80007 RVA: 0x004E0DAD File Offset: 0x004DEFAD
	// (set) Token: 0x06013888 RID: 80008 RVA: 0x004E0DBD File Offset: 0x004DEFBD
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

	// Token: 0x06013889 RID: 80009 RVA: 0x004E0DD0 File Offset: 0x004DEFD0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Initialize()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Initialize"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601388A RID: 80010 RVA: 0x004E0E40 File Offset: 0x004DF040
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

	// Token: 0x0601388B RID: 80011 RVA: 0x004E11BC File Offset: 0x004DF3BC
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

	// Token: 0x0601388C RID: 80012 RVA: 0x004E1240 File Offset: 0x004DF440
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveDestroyed()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveDestroyed"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0601388D RID: 80013 RVA: 0x004E12B0 File Offset: 0x004DF4B0
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

	// Token: 0x0601388E RID: 80014 RVA: 0x004E12DC File Offset: 0x004DF4DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601388F RID: 80015 RVA: 0x004E1352 File Offset: 0x004DF552
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

	// Token: 0x06013890 RID: 80016 RVA: 0x004E1388 File Offset: 0x004DF588
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RefreshPlayerLocation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RefreshPlayerLocation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06013891 RID: 80017 RVA: 0x004E13F8 File Offset: 0x004DF5F8
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

	// Token: 0x06013892 RID: 80018 RVA: 0x004E1454 File Offset: 0x004DF654
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

	// Token: 0x06013893 RID: 80019 RVA: 0x004E14E4 File Offset: 0x004DF6E4
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

	// Token: 0x06013894 RID: 80020 RVA: 0x004E1608 File Offset: 0x004DF808
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

	// Token: 0x06013895 RID: 80021 RVA: 0x004E1788 File Offset: 0x004DF988
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

	// Token: 0x06013896 RID: 80022 RVA: 0x004E17E4 File Offset: 0x004DF9E4
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

	// Token: 0x06013897 RID: 80023 RVA: 0x004E184C File Offset: 0x004DFA4C
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
		return list.Min();
	}

	// Token: 0x06013898 RID: 80024 RVA: 0x004E196C File Offset: 0x004DFB6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetPlayerSourceLocation(FVectorDouble location)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetPlayerSourceLocation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetPlayerSourceLocation_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetPlayerSourceLocation_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetPlayerSourceLocation_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->location = location;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06013899 RID: 80025 RVA: 0x004E19E2 File Offset: 0x004DFBE2
	protected void SetPlayerSourceLocation_Implementation(FVectorDouble location)
	{
		this.PlayerSourceLocation = new FVectorDouble?(location);
	}

	// Token: 0x0601389A RID: 80026 RVA: 0x004E19F0 File Offset: 0x004DFBF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraInitializeTransform(FTransformDouble transform)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraInitializeTransform"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraInitializeTransform_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraInitializeTransform_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraInitializeTransform_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->transform = transform;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601389B RID: 80027 RVA: 0x004E1A66 File Offset: 0x004DFC66
	protected void SetCameraInitializeTransform_Implementation(FTransformDouble transform)
	{
		this.CameraInitializeTransform = new FTransformDouble?(transform);
	}

	// Token: 0x0601389C RID: 80028 RVA: 0x004E1A74 File Offset: 0x004DFC74
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual FTransformDouble GetCameraInitializeTransform()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetCameraInitializeTransform"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__GetCameraInitializeTransform_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__GetCameraInitializeTransform_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__GetCameraInitializeTransform_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		FTransformDouble _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601389D RID: 80029 RVA: 0x004E1AE9 File Offset: 0x004DFCE9
	protected FTransformDouble GetCameraInitializeTransform_Implementation()
	{
		return this.CameraInitializeTransform.Value;
	}

	// Token: 0x0601389E RID: 80030 RVA: 0x004E1AF8 File Offset: 0x004DFCF8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraInitializeFov(float fov)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraInitializeFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraInitializeFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraInitializeFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraInitializeFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->fov = fov;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601389F RID: 80031 RVA: 0x004E1B6E File Offset: 0x004DFD6E
	protected void SetCameraInitializeFov_Implementation(float fov)
	{
		this.CameraInitializeFov = fov;
	}

	// Token: 0x060138A0 RID: 80032 RVA: 0x004E1B78 File Offset: 0x004DFD78
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetCameraInitializeFov()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetCameraInitializeFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__GetCameraInitializeFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__GetCameraInitializeFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__GetCameraInitializeFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060138A1 RID: 80033 RVA: 0x004E1BED File Offset: 0x004DFDED
	protected float GetCameraInitializeFov_Implementation()
	{
		if (this.CameraInitializeFov != -1f)
		{
			return this.CameraInitializeFov;
		}
		return 60f;
	}

	// Token: 0x060138A2 RID: 80034 RVA: 0x004E1C08 File Offset: 0x004DFE08
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

	// Token: 0x060138A3 RID: 80035 RVA: 0x004E1C3E File Offset: 0x004DFE3E
	public void DeactivateCamera()
	{
		ACineCameraActor cameraActor = this.CameraActor;
		if (cameraActor != null && cameraActor.IsValid())
		{
			this.CameraActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}
		this.CameraActor = null;
	}

	// Token: 0x060138A4 RID: 80036 RVA: 0x004E1C6C File Offset: 0x004DFE6C
	public void SetCameraTransform(FTransform transform)
	{
		FVector translation = transform.GetTranslation();
		FVectorDouble fvectorDouble = this.CameraActor.D_K2_GetActorLocation();
		FVector fvector = fvectorDouble;
		this.RelativeVectorCache = new FVector?(new FVector(translation.X - fvector.X, translation.Y - fvector.Y, translation.Z - fvector.Z));
		FHitResult fhitResult = null;
		base.K2_AddActorWorldOffset(this.RelativeVectorCache.Value, false, ref fhitResult, false);
	}

	// Token: 0x060138A5 RID: 80037 RVA: 0x004E1CE4 File Offset: 0x004DFEE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraArmTargetOffset(FVectorDouble cameraLocation, bool isInit = false)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraArmTargetOffset"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraArmTargetOffset_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->cameraLocation = cameraLocation;
			ptr2->isInit = isInit;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060138A6 RID: 80038 RVA: 0x004E1D64 File Offset: 0x004DFF64
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

	// Token: 0x060138A7 RID: 80039 RVA: 0x004E1E24 File Offset: 0x004E0024
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MoveUp(float addValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MoveUp"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__MoveUp_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__MoveUp_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__MoveUp_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addValue = addValue;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060138A8 RID: 80040 RVA: 0x004E1E9C File Offset: 0x004E009C
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

	// Token: 0x060138A9 RID: 80041 RVA: 0x004E1F44 File Offset: 0x004E0144
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MoveRight(float addValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MoveRight"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__MoveRight_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__MoveRight_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__MoveRight_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addValue = addValue;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060138AA RID: 80042 RVA: 0x004E1FBC File Offset: 0x004E01BC
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

	// Token: 0x060138AB RID: 80043 RVA: 0x004E2064 File Offset: 0x004E0264
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void MoveForward(float addValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MoveForward"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__MoveForward_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__MoveForward_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__MoveForward_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addValue = addValue;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060138AC RID: 80044 RVA: 0x004E20DC File Offset: 0x004E02DC
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

	// Token: 0x060138AD RID: 80045 RVA: 0x004E2184 File Offset: 0x004E0384
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

	// Token: 0x060138AE RID: 80046 RVA: 0x004E21D6 File Offset: 0x004E03D6
	public void AddCameraArmYawInput(float yaw)
	{
		if (yaw == 0f)
		{
			return;
		}
		this.YawInput = yaw;
	}

	// Token: 0x060138AF RID: 80047 RVA: 0x004E21E8 File Offset: 0x004E03E8
	public void SetCameraArmRoll(float roll)
	{
		Rotator tmpRotator = this.TmpRotator;
		FRotator frotator = this.CapsuleCollision.K2_GetComponentRotation();
		tmpRotator.DeepCopy(frotator);
		this.TmpRotator.Roll = this.InitialCapsuleRoll + roll;
		FHitResult fhitResult = new FHitResult();
		this.CapsuleCollision.K2_SetRelativeRotation(this.TmpRotator.ToUeRotator(), true, ref fhitResult, false);
	}

	// Token: 0x060138B0 RID: 80048 RVA: 0x004E2244 File Offset: 0x004E0444
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetFov(float fov)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->fov = fov;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060138B1 RID: 80049 RVA: 0x004E22BC File Offset: 0x004E04BC
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

	// Token: 0x060138B2 RID: 80050 RVA: 0x004E238C File Offset: 0x004E058C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetFov()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__GetFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__GetFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__GetFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060138B3 RID: 80051 RVA: 0x004E2401 File Offset: 0x004E0601
	protected float GetFov_Implementation()
	{
		return this.CameraActor.CameraComponent.FieldOfView;
	}

	// Token: 0x060138B4 RID: 80052 RVA: 0x004E2414 File Offset: 0x004E0614
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ResetCamera()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ResetCamera"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060138B5 RID: 80053 RVA: 0x004E2484 File Offset: 0x004E0684
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

	// Token: 0x060138B6 RID: 80054 RVA: 0x004E2550 File Offset: 0x004E0750
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCameraLUT(string texturePath)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraLUT"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraLUT_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraLUT_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraLUT_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->texturePath), texturePath);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060138B7 RID: 80055 RVA: 0x004E25CC File Offset: 0x004E07CC
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

	// Token: 0x060138B8 RID: 80056 RVA: 0x004E2638 File Offset: 0x004E0838
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
		List<TsBaseCharacter> list = this.DitheredNpcSet.ToList<TsBaseCharacter>();
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

	// Token: 0x060138B9 RID: 80057 RVA: 0x004E27F4 File Offset: 0x004E09F4
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

	// Token: 0x060138BA RID: 80058 RVA: 0x004E289C File Offset: 0x004E0A9C
	private void UpdateCameraCollisionLocation()
	{
		FVectorDouble fvectorDouble = this.CameraActor.D_GetActorForwardVector();
		FVector fvector = fvectorDouble;
		fvector.Normalize(1E-08f);
		fvector.Set(fvector.X * (float)this.CameraCollisionRadius, fvector.Y * (float)this.CameraCollisionRadius, fvector.Z * (float)this.CameraCollisionRadius);
		this.CameraLocation.Addition(this.TmpVector, this.CameraCollisionLocation);
	}

	// Token: 0x060138BB RID: 80059 RVA: 0x004E2914 File Offset: 0x004E0B14
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

	// Token: 0x060138BC RID: 80060 RVA: 0x004E2964 File Offset: 0x004E0B64
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

	// Token: 0x060138BD RID: 80061 RVA: 0x004E2A1D File Offset: 0x004E0C1D
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

	// Token: 0x060138BE RID: 80062 RVA: 0x004E2A5C File Offset: 0x004E0C5C
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

	// Token: 0x060138BF RID: 80063 RVA: 0x004E2ACC File Offset: 0x004E0CCC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsPhotographer._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographer.TsPhotographer_C");
		}
		return TsPhotographer._ClassPtr;
	}

	// Token: 0x060138C0 RID: 80064 RVA: 0x004E2AF0 File Offset: 0x004E0CF0
	public TsPhotographer() : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060138C1 RID: 80065 RVA: 0x004E2B18 File Offset: 0x004E0D18
	[NullableContext(1)]
	public TsPhotographer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060138C2 RID: 80066 RVA: 0x004E2B4C File Offset: 0x004E0D4C
	protected TsPhotographer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x1700192A RID: 6442
	// (get) Token: 0x060138C3 RID: 80067 RVA: 0x004E2CA3 File Offset: 0x004E0EA3
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographer.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x1700192B RID: 6443
	// (get) Token: 0x060138C4 RID: 80068 RVA: 0x004E2CB3 File Offset: 0x004E0EB3
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographer.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x060138C5 RID: 80069 RVA: 0x004E2CC7 File Offset: 0x004E0EC7
	protected virtual void __CPPCALL_Initialize_Implementation()
	{
		this.Initialize_Implementation();
	}

	// Token: 0x060138C6 RID: 80070 RVA: 0x004E2CCF File Offset: 0x004E0ECF
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x060138C7 RID: 80071 RVA: 0x004E2CD7 File Offset: 0x004E0ED7
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x060138C8 RID: 80072 RVA: 0x004E2CE5 File Offset: 0x004E0EE5
	protected virtual void __CPPCALL_RefreshPlayerLocation_Implementation()
	{
		this.RefreshPlayerLocation_Implementation();
	}

	// Token: 0x060138C9 RID: 80073 RVA: 0x004E2CED File Offset: 0x004E0EED
	protected unsafe virtual void __CPPCALL_SetPlayerSourceLocation_Implementation(TsPhotographer.__SetPlayerSourceLocation_FunctionParams* __Params)
	{
		this.SetPlayerSourceLocation_Implementation(__Params->location);
	}

	// Token: 0x060138CA RID: 80074 RVA: 0x004E2CFB File Offset: 0x004E0EFB
	protected unsafe virtual void __CPPCALL_SetCameraInitializeTransform_Implementation(TsPhotographer.__SetCameraInitializeTransform_FunctionParams* __Params)
	{
		this.SetCameraInitializeTransform_Implementation(__Params->transform);
	}

	// Token: 0x060138CB RID: 80075 RVA: 0x004E2D09 File Offset: 0x004E0F09
	protected unsafe virtual void __CPPCALL_GetCameraInitializeTransform_Implementation(TsPhotographer.__GetCameraInitializeTransform_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCameraInitializeTransform_Implementation();
	}

	// Token: 0x060138CC RID: 80076 RVA: 0x004E2D17 File Offset: 0x004E0F17
	protected unsafe virtual void __CPPCALL_SetCameraInitializeFov_Implementation(TsPhotographer.__SetCameraInitializeFov_FunctionParams* __Params)
	{
		this.SetCameraInitializeFov_Implementation(__Params->fov);
	}

	// Token: 0x060138CD RID: 80077 RVA: 0x004E2D25 File Offset: 0x004E0F25
	protected unsafe virtual void __CPPCALL_GetCameraInitializeFov_Implementation(TsPhotographer.__GetCameraInitializeFov_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCameraInitializeFov_Implementation();
	}

	// Token: 0x060138CE RID: 80078 RVA: 0x004E2D33 File Offset: 0x004E0F33
	protected unsafe virtual void __CPPCALL_SetCameraArmTargetOffset_Implementation(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* __Params)
	{
		this.SetCameraArmTargetOffset_Implementation(__Params->cameraLocation, __Params->isInit);
	}

	// Token: 0x060138CF RID: 80079 RVA: 0x004E2D47 File Offset: 0x004E0F47
	protected unsafe virtual void __CPPCALL_MoveUp_Implementation(TsPhotographer.__MoveUp_FunctionParams* __Params)
	{
		this.MoveUp_Implementation(__Params->addValue);
	}

	// Token: 0x060138D0 RID: 80080 RVA: 0x004E2D55 File Offset: 0x004E0F55
	protected unsafe virtual void __CPPCALL_MoveRight_Implementation(TsPhotographer.__MoveRight_FunctionParams* __Params)
	{
		this.MoveRight_Implementation(__Params->addValue);
	}

	// Token: 0x060138D1 RID: 80081 RVA: 0x004E2D63 File Offset: 0x004E0F63
	protected unsafe virtual void __CPPCALL_MoveForward_Implementation(TsPhotographer.__MoveForward_FunctionParams* __Params)
	{
		this.MoveForward_Implementation(__Params->addValue);
	}

	// Token: 0x060138D2 RID: 80082 RVA: 0x004E2D71 File Offset: 0x004E0F71
	protected unsafe virtual void __CPPCALL_SetFov_Implementation(TsPhotographer.__SetFov_FunctionParams* __Params)
	{
		this.SetFov_Implementation(__Params->fov);
	}

	// Token: 0x060138D3 RID: 80083 RVA: 0x004E2D7F File Offset: 0x004E0F7F
	protected unsafe virtual void __CPPCALL_GetFov_Implementation(TsPhotographer.__GetFov_FunctionParams* __Params)
	{
		__Params->__Result = this.GetFov_Implementation();
	}

	// Token: 0x060138D4 RID: 80084 RVA: 0x004E2D8D File Offset: 0x004E0F8D
	protected virtual void __CPPCALL_ResetCamera_Implementation()
	{
		this.ResetCamera_Implementation();
	}

	// Token: 0x060138D5 RID: 80085 RVA: 0x004E2D98 File Offset: 0x004E0F98
	protected unsafe virtual void __CPPCALL_SetCameraLUT_Implementation(TsPhotographer.__SetCameraLUT_FunctionParams* __Params)
	{
		string cameraLUT_Implementation = FString.ToString((void*)(&__Params->texturePath));
		this.SetCameraLUT_Implementation(cameraLUT_Implementation);
	}

	// Token: 0x0400936D RID: 37741
	[Nullable(1)]
	private const string CONFIG_PATH = "/Game/Aki/Data/Camera/DA_PhotographCameraConfig.DA_PhotographCameraConfig";

	// Token: 0x0400936E RID: 37742
	[Nullable(1)]
	private const string MOBILE_CONFIG_PATH = "/Game/Aki/Data/Camera/DA_PhotographCameraConfig_Mobile.DA_PhotographCameraConfig_Mobile";

	// Token: 0x0400936F RID: 37743
	private const float MIN_DITHER = 0.01f;

	// Token: 0x04009370 RID: 37744
	private const int HIDE_DISTANCE_OFFSET = 50;

	// Token: 0x04009371 RID: 37745
	[Nullable(2)]
	private ACineCameraActor CameraActor;

	// Token: 0x04009372 RID: 37746
	private FVector? RelativeVectorCache;

	// Token: 0x04009373 RID: 37747
	private FVectorDouble? PlayerSourceLocation;

	// Token: 0x04009374 RID: 37748
	private FTransformDouble? CameraInitializeTransform;

	// Token: 0x04009375 RID: 37749
	private FRotator? DefaultRotation;

	// Token: 0x04009376 RID: 37750
	private float InitialCapsuleRoll;

	// Token: 0x04009377 RID: 37751
	private float SourceMaxPitch;

	// Token: 0x04009378 RID: 37752
	private float SourceMinPitch;

	// Token: 0x04009379 RID: 37753
	[Nullable(2)]
	private TsBaseCharacter Character;

	// Token: 0x0400937A RID: 37754
	private float StartDitherValue;

	// Token: 0x0400937B RID: 37755
	private float NpcStartDitherValue;

	// Token: 0x0400937C RID: 37756
	private float StartHidePitch;

	// Token: 0x0400937D RID: 37757
	private float CompleteHidePitch;

	// Token: 0x0400937E RID: 37758
	private bool IsLoadingConfigCompleted;

	// Token: 0x0400937F RID: 37759
	private double CurrentDither;

	// Token: 0x04009380 RID: 37760
	[Nullable(2)]
	private global::Vector PlayerLocation;

	// Token: 0x04009381 RID: 37761
	[Nullable(2)]
	private global::Vector CameraLocation;

	// Token: 0x04009382 RID: 37762
	private float StartHideDistance;

	// Token: 0x04009383 RID: 37763
	private float CompleteHideDistance;

	// Token: 0x04009384 RID: 37764
	private float StartHideSizeInFrame;

	// Token: 0x04009385 RID: 37765
	private float CompleteHideSizeInFrame;

	// Token: 0x04009386 RID: 37766
	private float NpcStartHideDistance;

	// Token: 0x04009387 RID: 37767
	private float NpcCompleteHideDistance;

	// Token: 0x04009388 RID: 37768
	private float PitchInput;

	// Token: 0x04009389 RID: 37769
	private float YawInput;

	// Token: 0x0400938A RID: 37770
	[Nullable(1)]
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400938B RID: 37771
	[Nullable(1)]
	private readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400938C RID: 37772
	[Nullable(1)]
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400938D RID: 37773
	[Nullable(1)]
	private readonly Rotator TmpRotator2 = Rotator.Create();

	// Token: 0x0400938E RID: 37774
	[Nullable(1)]
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400938F RID: 37775
	[Nullable(1)]
	private readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04009390 RID: 37776
	[Nullable(1)]
	private readonly Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04009391 RID: 37777
	[Nullable(1)]
	public readonly Quat GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04009392 RID: 37778
	[Nullable(1)]
	public readonly Quat InverseGravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04009393 RID: 37779
	[Nullable(2)]
	private UTraceSphereElement CameraNpcSphereTrace;

	// Token: 0x04009394 RID: 37780
	[Nullable(1)]
	private Dictionary<TsBaseCharacter, double> DitheredNpcDistanceMap = new Dictionary<TsBaseCharacter, double>();

	// Token: 0x04009395 RID: 37781
	private float CurrentCameraDitherFov;

	// Token: 0x04009396 RID: 37782
	private double CameraCollisionRadius;

	// Token: 0x04009397 RID: 37783
	[Nullable(1)]
	private readonly global::Vector CameraCollisionLocation = global::Vector.Create();

	// Token: 0x04009398 RID: 37784
	[Nullable(1)]
	private HashSet<TsBaseCharacter> DitheredNpcSet = new HashSet<TsBaseCharacter>();

	// Token: 0x04009399 RID: 37785
	[Nullable(1)]
	private Dictionary<TsBaseCharacter, double> TeamMemberDitherMap = new Dictionary<TsBaseCharacter, double>();

	// Token: 0x0400939A RID: 37786
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographer.TsPhotographer_C";

	// Token: 0x0400939B RID: 37787
	private static IntPtr _ClassPtr;

	// Token: 0x0400939C RID: 37788
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400939D RID: 37789
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400939E RID: 37790
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0400939F RID: 37791
	private static int __PropertyOffset_CapsuleCollision;

	// Token: 0x040093A0 RID: 37792
	private static int __PropertyOffset_CameraArm;

	// Token: 0x040093A1 RID: 37793
	private static int __PropertyOffset_CameraInitializeFov;

	// Token: 0x040093A2 RID: 37794
	private static int __PropertyOffset_CameraArmInitializeSocketOffset;

	// Token: 0x040093A3 RID: 37795
	private static int __PropertyOffset_CameraUpAndDownMaxDistance;

	// Token: 0x040093A4 RID: 37796
	private static int __PropertyOffset_CameraLeftAndRightMaxDistance;

	// Token: 0x040093A5 RID: 37797
	private static int __PropertyOffset_CameraForwardAndBackMaxDistance;

	// Token: 0x040093A6 RID: 37798
	private static int __PropertyOffset_CameraUpAndDownSpeed;

	// Token: 0x040093A7 RID: 37799
	private static int __PropertyOffset_CameraLeftAndRightSpeed;

	// Token: 0x040093A8 RID: 37800
	private static int __PropertyOffset_CameraForwardAndBackSpeed;

	// Token: 0x040093A9 RID: 37801
	private static int __PropertyOffset_MinFov;

	// Token: 0x040093AA RID: 37802
	private static int __PropertyOffset_MaxFov;

	// Token: 0x040093AB RID: 37803
	private static int __PropertyOffset_CurCameraUpAndDownDistance;

	// Token: 0x040093AC RID: 37804
	private static int __PropertyOffset_CurCameraLeftAndRightDistance;

	// Token: 0x040093AD RID: 37805
	private static int __PropertyOffset_CurCameraForwardAndBackDistance;

	// Token: 0x02008BA2 RID: 35746
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetPlayerSourceLocation_FunctionParams
	{
		// Token: 0x0402D550 RID: 185680
		[FieldOffset(0)]
		public FVectorDouble location;
	}

	// Token: 0x02008BA3 RID: 35747
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __SetCameraInitializeTransform_FunctionParams
	{
		// Token: 0x0402D551 RID: 185681
		[FieldOffset(0)]
		public FTransformDouble transform;
	}

	// Token: 0x02008BA4 RID: 35748
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __GetCameraInitializeTransform_FunctionParams
	{
		// Token: 0x0402D552 RID: 185682
		[FieldOffset(0)]
		public FTransformDouble __Result;
	}

	// Token: 0x02008BA5 RID: 35749
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetCameraInitializeFov_FunctionParams
	{
		// Token: 0x0402D553 RID: 185683
		[FieldOffset(0)]
		public float fov;
	}

	// Token: 0x02008BA6 RID: 35750
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetCameraInitializeFov_FunctionParams
	{
		// Token: 0x0402D554 RID: 185684
		[FieldOffset(0)]
		public float __Result;
	}

	// Token: 0x02008BA7 RID: 35751
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetCameraArmTargetOffset_FunctionParams
	{
		// Token: 0x0402D555 RID: 185685
		[FieldOffset(0)]
		public FVectorDouble cameraLocation;

		// Token: 0x0402D556 RID: 185686
		[FieldOffset(24)]
		public bool isInit;
	}

	// Token: 0x02008BA8 RID: 35752
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __MoveUp_FunctionParams
	{
		// Token: 0x0402D557 RID: 185687
		[FieldOffset(0)]
		public float addValue;
	}

	// Token: 0x02008BA9 RID: 35753
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __MoveRight_FunctionParams
	{
		// Token: 0x0402D558 RID: 185688
		[FieldOffset(0)]
		public float addValue;
	}

	// Token: 0x02008BAA RID: 35754
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __MoveForward_FunctionParams
	{
		// Token: 0x0402D559 RID: 185689
		[FieldOffset(0)]
		public float addValue;
	}

	// Token: 0x02008BAB RID: 35755
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetFov_FunctionParams
	{
		// Token: 0x0402D55A RID: 185690
		[FieldOffset(0)]
		public float fov;
	}

	// Token: 0x02008BAC RID: 35756
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetFov_FunctionParams
	{
		// Token: 0x0402D55B RID: 185691
		[FieldOffset(0)]
		public float __Result;
	}

	// Token: 0x02008BAD RID: 35757
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCameraLUT_FunctionParams
	{
		// Token: 0x0402D55C RID: 185692
		[FieldOffset(0)]
		public FString texturePath;
	}
}

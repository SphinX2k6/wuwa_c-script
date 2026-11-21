using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000118 RID: 280
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraSensitivity.TsAnimNotifyStateCameraSensitivity_C")]
public class TsAnimNotifyStateCameraSensitivity : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00060233 File Offset: 0x0005E433
	// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00060243 File Offset: 0x0005E443
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 水平视角灵敏度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_水平视角灵敏度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_水平视角灵敏度) = value;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00060254 File Offset: 0x0005E454
	// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00060264 File Offset: 0x0005E464
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 垂直视角灵敏度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_垂直视角灵敏度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_垂直视角灵敏度) = value;
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00060275 File Offset: 0x0005E475
	// (set) Token: 0x060010BA RID: 4282 RVA: 0x00060285 File Offset: 0x0005E485
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 瞄准水平视角灵敏度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_瞄准水平视角灵敏度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_瞄准水平视角灵敏度) = value;
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x060010BB RID: 4283 RVA: 0x00060296 File Offset: 0x0005E496
	// (set) Token: 0x060010BC RID: 4284 RVA: 0x000602A6 File Offset: 0x0005E4A6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 瞄准垂直视角灵敏度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_瞄准垂直视角灵敏度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraSensitivity.__PropertyOffset_瞄准垂直视角灵敏度) = value;
		}
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x000602B8 File Offset: 0x0005E4B8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraSensitivity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCameraSensitivity.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00060378 File Offset: 0x0005E578
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		if (CameraModel.Instance == null)
		{
			return false;
		}
		CameraModel.Instance.MainModel.IsEnableSpecificCameraSensitivity = true;
		CameraModel.Instance.MainModel.SpecificCameraBaseYawSensitivity = this.水平视角灵敏度;
		CameraModel.Instance.MainModel.SpecificCameraBasePitchSensitivity = this.垂直视角灵敏度;
		CameraModel.Instance.MainModel.SpecificCameraAimingYawSensitivity = this.瞄准水平视角灵敏度;
		CameraModel.Instance.MainModel.SpecificCameraAimingPitchSensitivity = this.瞄准垂直视角灵敏度;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[CameraSensitivity Ans Start]";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("水平视角灵敏度", this.水平视角灵敏度);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("垂直视角灵敏度", this.垂直视角灵敏度);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("瞄准水平视角灵敏度", this.瞄准水平视角灵敏度);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("瞄准垂直视角灵敏度", this.瞄准垂直视角灵敏度);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		return true;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x000604D8 File Offset: 0x0005E6D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraSensitivity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCameraSensitivity.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00060590 File Offset: 0x0005E790
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		if (CameraModel.Instance == null)
		{
			return false;
		}
		CameraModel.Instance.MainModel.IsEnableSpecificCameraSensitivity = false;
		Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraSensitivity Ans Stop]", default(ReadOnlySpan<ValueTuple<string, object>>));
		return true;
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0006060C File Offset: 0x0005E80C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraSensitivity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCameraSensitivity.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0006069C File Offset: 0x0005E89C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置镜头灵敏度";
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x000606A3 File Offset: 0x0005E8A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraSensitivity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraSensitivity.TsAnimNotifyStateCameraSensitivity_C");
		}
		return TsAnimNotifyStateCameraSensitivity._ClassPtr;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x000606C8 File Offset: 0x0005E8C8
	public TsAnimNotifyStateCameraSensitivity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraSensitivity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x000606F0 File Offset: 0x0005E8F0
	[NullableContext(1)]
	public TsAnimNotifyStateCameraSensitivity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraSensitivity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00060723 File Offset: 0x0005E923
	protected TsAnimNotifyStateCameraSensitivity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0006072C File Offset: 0x0005E92C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00060768 File Offset: 0x0005E968
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0006079B File Offset: 0x0005E99B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CC7 RID: 3271
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraSensitivity.TsAnimNotifyStateCameraSensitivity_C";

	// Token: 0x04000CC8 RID: 3272
	private static IntPtr _ClassPtr;

	// Token: 0x04000CC9 RID: 3273
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CCA RID: 3274
	private static int __PropertyOffset_水平视角灵敏度;

	// Token: 0x04000CCB RID: 3275
	private static int __PropertyOffset_垂直视角灵敏度;

	// Token: 0x04000CCC RID: 3276
	private static int __PropertyOffset_瞄准水平视角灵敏度;

	// Token: 0x04000CCD RID: 3277
	private static int __PropertyOffset_瞄准垂直视角灵敏度;
}

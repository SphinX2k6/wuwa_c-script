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
	// Token: 0x170002AF RID: 687
	// (get) Token: 0x060010AF RID: 4271 RVA: 0x0005EE9B File Offset: 0x0005D09B
	// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0005EEAB File Offset: 0x0005D0AB
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

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0005EEBC File Offset: 0x0005D0BC
	// (set) Token: 0x060010B2 RID: 4274 RVA: 0x0005EECC File Offset: 0x0005D0CC
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

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0005EEDD File Offset: 0x0005D0DD
	// (set) Token: 0x060010B4 RID: 4276 RVA: 0x0005EEED File Offset: 0x0005D0ED
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

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0005EEFE File Offset: 0x0005D0FE
	// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0005EF0E File Offset: 0x0005D10E
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

	// Token: 0x060010B7 RID: 4279 RVA: 0x0005EF20 File Offset: 0x0005D120
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x0005EFC8 File Offset: 0x0005D1C8
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

	// Token: 0x060010B9 RID: 4281 RVA: 0x0005F128 File Offset: 0x0005D328
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
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

	// Token: 0x060010BB RID: 4283 RVA: 0x0005F244 File Offset: 0x0005D444
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0005F2BF File Offset: 0x0005D4BF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置镜头灵敏度";
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x0005F2C6 File Offset: 0x0005D4C6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraSensitivity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraSensitivity.TsAnimNotifyStateCameraSensitivity_C");
		}
		return TsAnimNotifyStateCameraSensitivity._ClassPtr;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0005F2EC File Offset: 0x0005D4EC
	public TsAnimNotifyStateCameraSensitivity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraSensitivity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0005F314 File Offset: 0x0005D514
	[NullableContext(1)]
	public TsAnimNotifyStateCameraSensitivity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraSensitivity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0005F347 File Offset: 0x0005D547
	protected TsAnimNotifyStateCameraSensitivity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0005F350 File Offset: 0x0005D550
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0005F38C File Offset: 0x0005D58C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x0005F3BF File Offset: 0x0005D5BF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CBF RID: 3263
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraSensitivity.TsAnimNotifyStateCameraSensitivity_C";

	// Token: 0x04000CC0 RID: 3264
	private static IntPtr _ClassPtr;

	// Token: 0x04000CC1 RID: 3265
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CC2 RID: 3266
	private static int __PropertyOffset_水平视角灵敏度;

	// Token: 0x04000CC3 RID: 3267
	private static int __PropertyOffset_垂直视角灵敏度;

	// Token: 0x04000CC4 RID: 3268
	private static int __PropertyOffset_瞄准水平视角灵敏度;

	// Token: 0x04000CC5 RID: 3269
	private static int __PropertyOffset_瞄准垂直视角灵敏度;
}

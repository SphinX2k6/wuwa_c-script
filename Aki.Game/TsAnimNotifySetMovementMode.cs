using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DB RID: 475
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMovementMode.TsAnimNotifySetMovementMode_C")]
public class TsAnimNotifySetMovementMode : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0009B04B File Offset: 0x0009924B
	// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x0009B05F File Offset: 0x0009925F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EMovementMode> MovementMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySetMovementMode.__PropertyOffset_MovementMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySetMovementMode.__PropertyOffset_MovementMode) = value;
		}
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x0009B074 File Offset: 0x00099274
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySetMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySetMovementMode.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x0009B12C File Offset: 0x0009932C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			tsBaseCharacter.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = this.MovementMode,
				Context = "[TsAnimNotifySetMovementMode.K2_Notify]"
			});
		}
		return true;
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x0009B170 File Offset: 0x00099370
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySetMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySetMovementMode.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x0009B200 File Offset: 0x00099400
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置移动模式";
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x0009B207 File Offset: 0x00099407
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetMovementMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMovementMode.TsAnimNotifySetMovementMode_C");
		}
		return TsAnimNotifySetMovementMode._ClassPtr;
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x0009B22C File Offset: 0x0009942C
	public TsAnimNotifySetMovementMode() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMovementMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x0009B254 File Offset: 0x00099454
	[NullableContext(1)]
	public TsAnimNotifySetMovementMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x0009B287 File Offset: 0x00099487
	protected TsAnimNotifySetMovementMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x0009B290 File Offset: 0x00099490
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x0009B2C3 File Offset: 0x000994C3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001286 RID: 4742
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetMovementMode.TsAnimNotifySetMovementMode_C";

	// Token: 0x04001287 RID: 4743
	private static IntPtr _ClassPtr;

	// Token: 0x04001288 RID: 4744
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001289 RID: 4745
	private static int __PropertyOffset_MovementMode;
}

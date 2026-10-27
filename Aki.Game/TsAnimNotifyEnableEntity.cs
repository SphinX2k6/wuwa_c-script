using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B5 RID: 437
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEnableEntity.TsAnimNotifyEnableEntity_C")]
public class TsAnimNotifyEnableEntity : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000470 RID: 1136
	// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0008D9BF File Offset: 0x0008BBBF
	// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0008D9CF File Offset: 0x0008BBCF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyEnableEntity.__PropertyOffset_IsEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyEnableEntity.__PropertyOffset_IsEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x0008D9E0 File Offset: 0x0008BBE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001B86 RID: 7046 RVA: 0x0008DA7F File Offset: 0x0008BC7F
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		return true;
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x0008DA84 File Offset: 0x0008BC84
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001B88 RID: 7048 RVA: 0x0008DAFF File Offset: 0x0008BCFF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "启用实体";
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x0008DB06 File Offset: 0x0008BD06
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyEnableEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEnableEntity.TsAnimNotifyEnableEntity_C");
		}
		return TsAnimNotifyEnableEntity._ClassPtr;
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x0008DB2C File Offset: 0x0008BD2C
	public TsAnimNotifyEnableEntity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEnableEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x0008DB54 File Offset: 0x0008BD54
	[NullableContext(1)]
	public TsAnimNotifyEnableEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEnableEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x0008DB87 File Offset: 0x0008BD87
	protected TsAnimNotifyEnableEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x0008DB90 File Offset: 0x0008BD90
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x0008DBC3 File Offset: 0x0008BDC3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001191 RID: 4497
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEnableEntity.TsAnimNotifyEnableEntity_C";

	// Token: 0x04001192 RID: 4498
	private static IntPtr _ClassPtr;

	// Token: 0x04001193 RID: 4499
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001194 RID: 4500
	private static int __PropertyOffset_IsEnable;
}

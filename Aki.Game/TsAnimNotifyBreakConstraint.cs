using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000199 RID: 409
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakConstraint.TsAnimNotifyBreakConstraint_C")]
public class TsAnimNotifyBreakConstraint : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00088B8F File Offset: 0x00086D8F
	// (set) Token: 0x06001A06 RID: 6662 RVA: 0x00088BA3 File Offset: 0x00086DA3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 分离骨骼名
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_分离骨骼名);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_分离骨骼名) = value;
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00088BB8 File Offset: 0x00086DB8
	// (set) Token: 0x06001A08 RID: 6664 RVA: 0x00088BCC File Offset: 0x00086DCC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Impulse
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_Impulse);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_Impulse) = value;
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00088BE1 File Offset: 0x00086DE1
	// (set) Token: 0x06001A0A RID: 6666 RVA: 0x00088BF5 File Offset: 0x00086DF5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector HitLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_HitLocation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBreakConstraint.__PropertyOffset_HitLocation) = value;
		}
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x00088C0C File Offset: 0x00086E0C
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

	// Token: 0x06001A0C RID: 6668 RVA: 0x00088CAB File Offset: 0x00086EAB
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp.GetOwner() is TsBaseCharacter)
		{
			meshComp.BreakConstraint(this.Impulse, this.HitLocation, this.分离骨骼名);
		}
		return true;
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x00088CD4 File Offset: 0x00086ED4
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

	// Token: 0x06001A0E RID: 6670 RVA: 0x00088D4F File Offset: 0x00086F4F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "分离骨骼网格体";
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00088D56 File Offset: 0x00086F56
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBreakConstraint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakConstraint.TsAnimNotifyBreakConstraint_C");
		}
		return TsAnimNotifyBreakConstraint._ClassPtr;
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00088D7C File Offset: 0x00086F7C
	public TsAnimNotifyBreakConstraint() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakConstraint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00088DA4 File Offset: 0x00086FA4
	[NullableContext(1)]
	public TsAnimNotifyBreakConstraint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakConstraint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x00088DD7 File Offset: 0x00086FD7
	protected TsAnimNotifyBreakConstraint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x00088DE0 File Offset: 0x00086FE0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x00088E13 File Offset: 0x00087013
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010FC RID: 4348
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakConstraint.TsAnimNotifyBreakConstraint_C";

	// Token: 0x040010FD RID: 4349
	private static IntPtr _ClassPtr;

	// Token: 0x040010FE RID: 4350
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010FF RID: 4351
	private static int __PropertyOffset_分离骨骼名;

	// Token: 0x04001100 RID: 4352
	private static int __PropertyOffset_Impulse;

	// Token: 0x04001101 RID: 4353
	private static int __PropertyOffset_HitLocation;
}

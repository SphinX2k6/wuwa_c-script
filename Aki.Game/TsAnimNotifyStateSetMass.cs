using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016B RID: 363
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMass.TsAnimNotifyStateSetMass_C")]
public class TsAnimNotifyStateSetMass : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x0600173B RID: 5947 RVA: 0x00080B8F File Offset: 0x0007ED8F
	// (set) Token: 0x0600173C RID: 5948 RVA: 0x00080B9F File Offset: 0x0007ED9F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NewMass
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMass.__PropertyOffset_NewMass);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetMass.__PropertyOffset_NewMass) = value;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x0600173D RID: 5949 RVA: 0x00080BB0 File Offset: 0x0007EDB0
	// (set) Token: 0x0600173E RID: 5950 RVA: 0x00080BB8 File Offset: 0x0007EDB8
	private float OldMass { get; set; }

	// Token: 0x0600173F RID: 5951 RVA: 0x00080BC4 File Offset: 0x0007EDC4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetMass) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetMass.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001740 RID: 5952 RVA: 0x00080C84 File Offset: 0x0007EE84
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			this.OldMass = (owner as TsBaseCharacter).CharacterMovement.Mass;
			(owner as TsBaseCharacter).CharacterMovement.Mass = this.NewMass;
			return true;
		}
		return false;
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00080CD0 File Offset: 0x0007EED0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetMass) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetMass.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001742 RID: 5954 RVA: 0x00080D88 File Offset: 0x0007EF88
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			(owner as TsBaseCharacter).CharacterMovement.Mass = this.OldMass;
			return true;
		}
		return false;
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00080DC0 File Offset: 0x0007EFC0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetMass) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetMass.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001744 RID: 5956 RVA: 0x00080E50 File Offset: 0x0007F050
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置质量";
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00080E57 File Offset: 0x0007F057
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetMass._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMass.TsAnimNotifyStateSetMass_C");
		}
		return TsAnimNotifyStateSetMass._ClassPtr;
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00080E7C File Offset: 0x0007F07C
	public TsAnimNotifyStateSetMass() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x00080EA4 File Offset: 0x0007F0A4
	[NullableContext(1)]
	public TsAnimNotifyStateSetMass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x00080ED7 File Offset: 0x0007F0D7
	protected TsAnimNotifyStateSetMass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x00080EE0 File Offset: 0x0007F0E0
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00080F1C File Offset: 0x0007F11C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00080F4F File Offset: 0x0007F14F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FE7 RID: 4071
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMass.TsAnimNotifyStateSetMass_C";

	// Token: 0x04000FE8 RID: 4072
	private static IntPtr _ClassPtr;

	// Token: 0x04000FE9 RID: 4073
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FEA RID: 4074
	private static int __PropertyOffset_NewMass;
}

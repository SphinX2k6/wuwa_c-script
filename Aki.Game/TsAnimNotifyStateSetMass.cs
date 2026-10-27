using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000167 RID: 359
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMass.TsAnimNotifyStateSetMass_C")]
public class TsAnimNotifyStateSetMass : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x0600169E RID: 5790 RVA: 0x0007B173 File Offset: 0x00079373
	// (set) Token: 0x0600169F RID: 5791 RVA: 0x0007B183 File Offset: 0x00079383
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

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0007B194 File Offset: 0x00079394
	// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0007B19C File Offset: 0x0007939C
	private float OldMass { get; set; }

	// Token: 0x060016A2 RID: 5794 RVA: 0x0007B1A8 File Offset: 0x000793A8
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

	// Token: 0x060016A3 RID: 5795 RVA: 0x0007B250 File Offset: 0x00079450
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

	// Token: 0x060016A4 RID: 5796 RVA: 0x0007B29C File Offset: 0x0007949C
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

	// Token: 0x060016A5 RID: 5797 RVA: 0x0007B33C File Offset: 0x0007953C
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

	// Token: 0x060016A6 RID: 5798 RVA: 0x0007B374 File Offset: 0x00079574
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

	// Token: 0x060016A7 RID: 5799 RVA: 0x0007B3EF File Offset: 0x000795EF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置质量";
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x0007B3F6 File Offset: 0x000795F6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetMass._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMass.TsAnimNotifyStateSetMass_C");
		}
		return TsAnimNotifyStateSetMass._ClassPtr;
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x0007B41C File Offset: 0x0007961C
	public TsAnimNotifyStateSetMass() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x0007B444 File Offset: 0x00079644
	[NullableContext(1)]
	public TsAnimNotifyStateSetMass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetMass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x0007B477 File Offset: 0x00079677
	protected TsAnimNotifyStateSetMass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x0007B480 File Offset: 0x00079680
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x0007B4BC File Offset: 0x000796BC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x0007B4EF File Offset: 0x000796EF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FA4 RID: 4004
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetMass.TsAnimNotifyStateSetMass_C";

	// Token: 0x04000FA5 RID: 4005
	private static IntPtr _ClassPtr;

	// Token: 0x04000FA6 RID: 4006
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FA7 RID: 4007
	private static int __PropertyOffset_NewMass;
}

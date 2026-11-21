using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000113 RID: 275
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBonesShowControl.TsAnimNotifyStateBonesShowControl_C")]
public class TsAnimNotifyStateBonesShowControl : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700029D RID: 669
	// (get) Token: 0x06001045 RID: 4165 RVA: 0x0005E2C3 File Offset: 0x0005C4C3
	// (set) Token: 0x06001046 RID: 4166 RVA: 0x0005E2D3 File Offset: 0x0005C4D3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EndPlay
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateBonesShowControl.__PropertyOffset_EndPlay) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateBonesShowControl.__PropertyOffset_EndPlay) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x06001047 RID: 4167 RVA: 0x0005E2E4 File Offset: 0x0005C4E4
	// (set) Token: 0x06001048 RID: 4168 RVA: 0x0005E2F8 File Offset: 0x0005C4F8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName BoneName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateBonesShowControl.__PropertyOffset_BoneName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateBonesShowControl.__PropertyOffset_BoneName) = value;
		}
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0005E310 File Offset: 0x0005C510
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBonesShowControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateBonesShowControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600104A RID: 4170 RVA: 0x0005E3D0 File Offset: 0x0005C5D0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			if (!meshComp.IsBoneHiddenByName(this.BoneName))
			{
				meshComp.HideBoneByName(this.BoneName, EPhysBodyOp.PBO_None);
				CharacterWeaponComponent component = entity.GetComponent<CharacterWeaponComponent>();
				if (component != null)
				{
					component.HideWeaponsWhenHideBones(true, this.BoneName);
				}
			}
		}
		return false;
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0005E444 File Offset: 0x0005C644
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBonesShowControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateBonesShowControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600104C RID: 4172 RVA: 0x0005E4FC File Offset: 0x0005C6FC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			if (meshComp.IsBoneHiddenByName(this.BoneName))
			{
				meshComp.UnHideBoneByName(this.BoneName);
				CharacterWeaponComponent component = entity.GetComponent<CharacterWeaponComponent>();
				if (component != null)
				{
					component.HideWeaponsWhenHideBones(false, this.BoneName);
				}
			}
		}
		return false;
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0005E578 File Offset: 0x0005C778
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBonesShowControl) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateBonesShowControl.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600104E RID: 4174 RVA: 0x0005E608 File Offset: 0x0005C808
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "骨骼显示控制";
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0005E60F File Offset: 0x0005C80F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBonesShowControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBonesShowControl.TsAnimNotifyStateBonesShowControl_C");
		}
		return TsAnimNotifyStateBonesShowControl._ClassPtr;
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x0005E634 File Offset: 0x0005C834
	public TsAnimNotifyStateBonesShowControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBonesShowControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x0005E65C File Offset: 0x0005C85C
	[NullableContext(1)]
	public TsAnimNotifyStateBonesShowControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBonesShowControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x0005E68F File Offset: 0x0005C88F
	protected TsAnimNotifyStateBonesShowControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x0005E698 File Offset: 0x0005C898
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x0005E6D4 File Offset: 0x0005C8D4
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x0005E707 File Offset: 0x0005C907
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C93 RID: 3219
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBonesShowControl.TsAnimNotifyStateBonesShowControl_C";

	// Token: 0x04000C94 RID: 3220
	private static IntPtr _ClassPtr;

	// Token: 0x04000C95 RID: 3221
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C96 RID: 3222
	private static int __PropertyOffset_EndPlay;

	// Token: 0x04000C97 RID: 3223
	private static int __PropertyOffset_BoneName;
}

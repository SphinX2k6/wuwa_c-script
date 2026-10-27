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
	// Token: 0x1700029A RID: 666
	// (get) Token: 0x0600103F RID: 4159 RVA: 0x0005D093 File Offset: 0x0005B293
	// (set) Token: 0x06001040 RID: 4160 RVA: 0x0005D0A3 File Offset: 0x0005B2A3
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

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06001041 RID: 4161 RVA: 0x0005D0B4 File Offset: 0x0005B2B4
	// (set) Token: 0x06001042 RID: 4162 RVA: 0x0005D0C8 File Offset: 0x0005B2C8
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

	// Token: 0x06001043 RID: 4163 RVA: 0x0005D0E0 File Offset: 0x0005B2E0
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

	// Token: 0x06001044 RID: 4164 RVA: 0x0005D188 File Offset: 0x0005B388
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

	// Token: 0x06001045 RID: 4165 RVA: 0x0005D1FC File Offset: 0x0005B3FC
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

	// Token: 0x06001046 RID: 4166 RVA: 0x0005D29C File Offset: 0x0005B49C
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

	// Token: 0x06001047 RID: 4167 RVA: 0x0005D318 File Offset: 0x0005B518
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

	// Token: 0x06001048 RID: 4168 RVA: 0x0005D393 File Offset: 0x0005B593
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "骨骼显示控制";
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0005D39A File Offset: 0x0005B59A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBonesShowControl._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBonesShowControl.TsAnimNotifyStateBonesShowControl_C");
		}
		return TsAnimNotifyStateBonesShowControl._ClassPtr;
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x0005D3C0 File Offset: 0x0005B5C0
	public TsAnimNotifyStateBonesShowControl() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBonesShowControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
	[NullableContext(1)]
	public TsAnimNotifyStateBonesShowControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBonesShowControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x0005D41B File Offset: 0x0005B61B
	protected TsAnimNotifyStateBonesShowControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0005D424 File Offset: 0x0005B624
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x0005D460 File Offset: 0x0005B660
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0005D493 File Offset: 0x0005B693
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C8B RID: 3211
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBonesShowControl.TsAnimNotifyStateBonesShowControl_C";

	// Token: 0x04000C8C RID: 3212
	private static IntPtr _ClassPtr;

	// Token: 0x04000C8D RID: 3213
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C8E RID: 3214
	private static int __PropertyOffset_EndPlay;

	// Token: 0x04000C8F RID: 3215
	private static int __PropertyOffset_BoneName;
}

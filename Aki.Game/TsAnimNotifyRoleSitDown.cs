using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D2 RID: 466
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleSitDown.TsAnimNotifyRoleSitDown_C")]
public class TsAnimNotifyRoleSitDown : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001D1B RID: 7451 RVA: 0x00093524 File Offset: 0x00091724
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

	// Token: 0x06001D1C RID: 7452 RVA: 0x000935C4 File Offset: 0x000917C4
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActionComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterActionComponent>();
			if (component != null)
			{
				component.DoSitDownAction();
				return true;
			}
			NpcSitOnChairComponent component2 = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<NpcSitOnChairComponent>();
			if (((component2 != null) ? component2.CurrentChairEntity : null) != null)
			{
				component2.DoSitDownAction(component2.CurrentChairEntity);
			}
		}
		return true;
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x00093628 File Offset: 0x00091828
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

	// Token: 0x06001D1E RID: 7454 RVA: 0x000936A3 File Offset: 0x000918A3
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色坐下";
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x000936AA File Offset: 0x000918AA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRoleSitDown._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleSitDown.TsAnimNotifyRoleSitDown_C");
		}
		return TsAnimNotifyRoleSitDown._ClassPtr;
	}

	// Token: 0x06001D20 RID: 7456 RVA: 0x000936D0 File Offset: 0x000918D0
	public TsAnimNotifyRoleSitDown() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleSitDown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D21 RID: 7457 RVA: 0x000936F8 File Offset: 0x000918F8
	[NullableContext(1)]
	public TsAnimNotifyRoleSitDown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleSitDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D22 RID: 7458 RVA: 0x0009372B File Offset: 0x0009192B
	protected TsAnimNotifyRoleSitDown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D23 RID: 7459 RVA: 0x00093734 File Offset: 0x00091934
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D24 RID: 7460 RVA: 0x00093767 File Offset: 0x00091967
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400122F RID: 4655
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleSitDown.TsAnimNotifyRoleSitDown_C";

	// Token: 0x04001230 RID: 4656
	private static IntPtr _ClassPtr;

	// Token: 0x04001231 RID: 4657
	private static IntPtr _ClassDefaultObjectPtr;
}

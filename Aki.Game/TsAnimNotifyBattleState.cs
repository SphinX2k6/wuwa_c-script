using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000196 RID: 406
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleState.TsAnimNotifyBattleState_C")]
public class TsAnimNotifyBattleState : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x060019DB RID: 6619 RVA: 0x0008837B File Offset: 0x0008657B
	// (set) Token: 0x060019DC RID: 6620 RVA: 0x0008838B File Offset: 0x0008658B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 取消无敌
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBattleState.__PropertyOffset_取消无敌) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBattleState.__PropertyOffset_取消无敌) = (value ? 1 : 0);
		}
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0008839C File Offset: 0x0008659C
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

	// Token: 0x060019DE RID: 6622 RVA: 0x0008843C File Offset: 0x0008663C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			BaseTagComponent component = ((characterActorComponent != null) ? characterActorComponent.Entity : null).GetComponent<BaseTagComponent>();
			if (this.取消无敌 && component != null)
			{
				component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.通用无敌"]));
			}
		}
		return true;
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x00088498 File Offset: 0x00086698
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

	// Token: 0x060019E0 RID: 6624 RVA: 0x00088513 File Offset: 0x00086713
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置战斗状态";
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0008851A File Offset: 0x0008671A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBattleState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleState.TsAnimNotifyBattleState_C");
		}
		return TsAnimNotifyBattleState._ClassPtr;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00088540 File Offset: 0x00086740
	public TsAnimNotifyBattleState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x00088568 File Offset: 0x00086768
	[NullableContext(1)]
	public TsAnimNotifyBattleState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0008859B File Offset: 0x0008679B
	protected TsAnimNotifyBattleState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x000885A4 File Offset: 0x000867A4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x000885D7 File Offset: 0x000867D7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010EC RID: 4332
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleState.TsAnimNotifyBattleState_C";

	// Token: 0x040010ED RID: 4333
	private static IntPtr _ClassPtr;

	// Token: 0x040010EE RID: 4334
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010EF RID: 4335
	private static int __PropertyOffset_取消无敌;
}

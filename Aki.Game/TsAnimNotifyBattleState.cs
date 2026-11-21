using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019A RID: 410
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleState.TsAnimNotifyBattleState_C")]
public class TsAnimNotifyBattleState : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0008E80B File Offset: 0x0008CA0B
	// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0008E81B File Offset: 0x0008CA1B
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

	// Token: 0x06001A7A RID: 6778 RVA: 0x0008E82C File Offset: 0x0008CA2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBattleState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBattleState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A7B RID: 6779 RVA: 0x0008E8E4 File Offset: 0x0008CAE4
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

	// Token: 0x06001A7C RID: 6780 RVA: 0x0008E940 File Offset: 0x0008CB40
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBattleState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBattleState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A7D RID: 6781 RVA: 0x0008E9D0 File Offset: 0x0008CBD0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置战斗状态";
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x0008E9D7 File Offset: 0x0008CBD7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBattleState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleState.TsAnimNotifyBattleState_C");
		}
		return TsAnimNotifyBattleState._ClassPtr;
	}

	// Token: 0x06001A7F RID: 6783 RVA: 0x0008E9FC File Offset: 0x0008CBFC
	public TsAnimNotifyBattleState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A80 RID: 6784 RVA: 0x0008EA24 File Offset: 0x0008CC24
	[NullableContext(1)]
	public TsAnimNotifyBattleState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x0008EA57 File Offset: 0x0008CC57
	protected TsAnimNotifyBattleState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x0008EA60 File Offset: 0x0008CC60
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x0008EA93 File Offset: 0x0008CC93
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400112F RID: 4399
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleState.TsAnimNotifyBattleState_C";

	// Token: 0x04001130 RID: 4400
	private static IntPtr _ClassPtr;

	// Token: 0x04001131 RID: 4401
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001132 RID: 4402
	private static int __PropertyOffset_取消无敌;
}

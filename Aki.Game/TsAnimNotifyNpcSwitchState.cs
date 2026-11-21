using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C8 RID: 456
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyNpcSwitchState.TsAnimNotifyNpcSwitchState_C")]
public class TsAnimNotifyNpcSwitchState : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000971F7 File Offset: 0x000953F7
	// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0009720B File Offset: 0x0009540B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StateName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyNpcSwitchState.__PropertyOffset_StateName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyNpcSwitchState.__PropertyOffset_StateName)), value);
		}
	}

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00097220 File Offset: 0x00095420
	// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00097230 File Offset: 0x00095430
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedTransition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyNpcSwitchState.__PropertyOffset_NeedTransition) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyNpcSwitchState.__PropertyOffset_NeedTransition) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x00097244 File Offset: 0x00095444
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyNpcSwitchState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyNpcSwitchState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CE5 RID: 7397 RVA: 0x000972FC File Offset: 0x000954FC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return true;
		}
		if (this.StateName == "" || this.StateName == "None")
		{
			return true;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		NpcPerformComponent npcPerformComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<NpcPerformComponent>() : null;
		if (npcPerformComponent != null)
		{
			npcPerformComponent.SwitchAnimState(new SwitchState
			{
				TargetStateName = this.StateName,
				Context = animation.GetName() + ": AN",
				IsNoTransition = new bool?(!this.NeedTransition)
			});
		}
		return true;
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x000973A0 File Offset: 0x000955A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyNpcSwitchState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyNpcSwitchState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CE7 RID: 7399 RVA: 0x00097430 File Offset: 0x00095630
	protected override string GetNotifyName_Implementation()
	{
		return "NPC切换ABP状态";
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x00097437 File Offset: 0x00095637
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyNpcSwitchState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyNpcSwitchState.TsAnimNotifyNpcSwitchState_C");
		}
		return TsAnimNotifyNpcSwitchState._ClassPtr;
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x0009745C File Offset: 0x0009565C
	public TsAnimNotifyNpcSwitchState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyNpcSwitchState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x00097484 File Offset: 0x00095684
	public TsAnimNotifyNpcSwitchState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyNpcSwitchState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CEB RID: 7403 RVA: 0x000974B7 File Offset: 0x000956B7
	protected TsAnimNotifyNpcSwitchState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CEC RID: 7404 RVA: 0x000974C0 File Offset: 0x000956C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x000974F3 File Offset: 0x000956F3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400121A RID: 4634
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyNpcSwitchState.TsAnimNotifyNpcSwitchState_C";

	// Token: 0x0400121B RID: 4635
	private static IntPtr _ClassPtr;

	// Token: 0x0400121C RID: 4636
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400121D RID: 4637
	private static int __PropertyOffset_StateName;

	// Token: 0x0400121E RID: 4638
	private static int __PropertyOffset_NeedTransition;
}

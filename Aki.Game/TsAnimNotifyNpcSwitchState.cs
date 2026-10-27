using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C4 RID: 452
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyNpcSwitchState.TsAnimNotifyNpcSwitchState_C")]
public class TsAnimNotifyNpcSwitchState : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0009065B File Offset: 0x0008E85B
	// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0009066F File Offset: 0x0008E86F
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

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00090684 File Offset: 0x0008E884
	// (set) Token: 0x06001C46 RID: 7238 RVA: 0x00090694 File Offset: 0x0008E894
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

	// Token: 0x06001C47 RID: 7239 RVA: 0x000906A8 File Offset: 0x0008E8A8
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

	// Token: 0x06001C48 RID: 7240 RVA: 0x00090748 File Offset: 0x0008E948
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

	// Token: 0x06001C49 RID: 7241 RVA: 0x000907EC File Offset: 0x0008E9EC
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

	// Token: 0x06001C4A RID: 7242 RVA: 0x00090867 File Offset: 0x0008EA67
	protected override string GetNotifyName_Implementation()
	{
		return "NPC切换ABP状态";
	}

	// Token: 0x06001C4B RID: 7243 RVA: 0x0009086E File Offset: 0x0008EA6E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyNpcSwitchState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyNpcSwitchState.TsAnimNotifyNpcSwitchState_C");
		}
		return TsAnimNotifyNpcSwitchState._ClassPtr;
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x00090894 File Offset: 0x0008EA94
	public TsAnimNotifyNpcSwitchState() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyNpcSwitchState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x000908BC File Offset: 0x0008EABC
	public TsAnimNotifyNpcSwitchState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyNpcSwitchState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x000908EF File Offset: 0x0008EAEF
	protected TsAnimNotifyNpcSwitchState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x000908F8 File Offset: 0x0008EAF8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x0009092B File Offset: 0x0008EB2B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011D7 RID: 4567
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyNpcSwitchState.TsAnimNotifyNpcSwitchState_C";

	// Token: 0x040011D8 RID: 4568
	private static IntPtr _ClassPtr;

	// Token: 0x040011D9 RID: 4569
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011DA RID: 4570
	private static int __PropertyOffset_StateName;

	// Token: 0x040011DB RID: 4571
	private static int __PropertyOffset_NeedTransition;
}

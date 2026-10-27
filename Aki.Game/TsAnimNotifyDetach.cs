using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AD RID: 429
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetach.TsAnimNotifyDetach_C")]
public class TsAnimNotifyDetach : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06001B21 RID: 6945 RVA: 0x0008C527 File Offset: 0x0008A727
	// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0008C537 File Offset: 0x0008A737
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsDetachFollower
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyDetach.__PropertyOffset_IsDetachFollower) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyDetach.__PropertyOffset_IsDetachFollower) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0008C548 File Offset: 0x0008A748
	// (set) Token: 0x06001B24 RID: 6948 RVA: 0x0008C558 File Offset: 0x0008A758
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsRecursion
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyDetach.__PropertyOffset_IsRecursion) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyDetach.__PropertyOffset_IsRecursion) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x0008C56C File Offset: 0x0008A76C
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

	// Token: 0x06001B26 RID: 6950 RVA: 0x0008C60C File Offset: 0x0008A80C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		CharacterSkillComponent component = characterActorComponent.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null && component.Valid)
		{
			EntityHandle skillTarget = component.SkillTarget;
			if (((skillTarget != null) ? skillTarget.Entity : null) != null)
			{
				Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
				CharacterAttachComponent characterAttachComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterAttachComponent>() : null;
				if (characterAttachComponent == null || !characterAttachComponent.Valid)
				{
					return false;
				}
				long? preMessageId = characterActorComponent.Entity.GetComponent<BaseBuffComponent>().CreateAnimNotifyContent(animation.GetName(), base.exportIndex);
				characterAttachComponent.DetachFromHost(this.IsDetachFollower, this.IsRecursion, true, preMessageId);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0008C6E4 File Offset: 0x0008A8E4
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

	// Token: 0x06001B28 RID: 6952 RVA: 0x0008C75F File Offset: 0x0008A95F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "从目标身上解绑";
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0008C766 File Offset: 0x0008A966
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDetach._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetach.TsAnimNotifyDetach_C");
		}
		return TsAnimNotifyDetach._ClassPtr;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x0008C78C File Offset: 0x0008A98C
	public TsAnimNotifyDetach() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x0008C7B4 File Offset: 0x0008A9B4
	[NullableContext(1)]
	public TsAnimNotifyDetach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x0008C7E7 File Offset: 0x0008A9E7
	protected TsAnimNotifyDetach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x0008C7F0 File Offset: 0x0008A9F0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x0008C823 File Offset: 0x0008AA23
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400116C RID: 4460
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetach.TsAnimNotifyDetach_C";

	// Token: 0x0400116D RID: 4461
	private static IntPtr _ClassPtr;

	// Token: 0x0400116E RID: 4462
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400116F RID: 4463
	private static int __PropertyOffset_IsDetachFollower;

	// Token: 0x04001170 RID: 4464
	private static int __PropertyOffset_IsRecursion;
}

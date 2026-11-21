using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B1 RID: 433
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetach.TsAnimNotifyDetach_C")]
public class TsAnimNotifyDetach : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00092D53 File Offset: 0x00090F53
	// (set) Token: 0x06001BBF RID: 7103 RVA: 0x00092D63 File Offset: 0x00090F63
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

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00092D74 File Offset: 0x00090F74
	// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00092D84 File Offset: 0x00090F84
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

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00092D98 File Offset: 0x00090F98
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDetach) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyDetach.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001BC3 RID: 7107 RVA: 0x00092E50 File Offset: 0x00091050
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

	// Token: 0x06001BC4 RID: 7108 RVA: 0x00092F28 File Offset: 0x00091128
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDetach) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyDetach.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001BC5 RID: 7109 RVA: 0x00092FB8 File Offset: 0x000911B8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "从目标身上解绑";
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x00092FBF File Offset: 0x000911BF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDetach._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetach.TsAnimNotifyDetach_C");
		}
		return TsAnimNotifyDetach._ClassPtr;
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00092FE4 File Offset: 0x000911E4
	public TsAnimNotifyDetach() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x0009300C File Offset: 0x0009120C
	[NullableContext(1)]
	public TsAnimNotifyDetach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0009303F File Offset: 0x0009123F
	protected TsAnimNotifyDetach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x00093048 File Offset: 0x00091248
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x0009307B File Offset: 0x0009127B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011AF RID: 4527
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDetach.TsAnimNotifyDetach_C";

	// Token: 0x040011B0 RID: 4528
	private static IntPtr _ClassPtr;

	// Token: 0x040011B1 RID: 4529
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011B2 RID: 4530
	private static int __PropertyOffset_IsDetachFollower;

	// Token: 0x040011B3 RID: 4531
	private static int __PropertyOffset_IsRecursion;
}

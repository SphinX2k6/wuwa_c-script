using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Role.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D4 RID: 468
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleFinishInteract.TsAnimNotifyRoleFinishInteract_C")]
public class TsAnimNotifyRoleFinishInteract : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06001D9E RID: 7582 RVA: 0x00099D7B File Offset: 0x00097F7B
	// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00099D8B File Offset: 0x00097F8B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ERoleInteractType Type
	{
		get
		{
			return (ERoleInteractType)(*(base.NativePtr + (IntPtr)TsAnimNotifyRoleFinishInteract.__PropertyOffset_Type));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRoleFinishInteract.__PropertyOffset_Type) = (byte)value;
		}
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x00099D9C File Offset: 0x00097F9C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRoleFinishInteract) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyRoleFinishInteract.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(MeshComp, Animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x00099E54 File Offset: 0x00098054
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		TsBaseCharacter tsBaseCharacter = MeshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActionComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterActionComponent>();
			if (component != null)
			{
				ERoleInteractType type = this.Type;
				if (type != ERoleInteractType.Bounce)
				{
					if (type == ERoleInteractType.Catapult)
					{
						component.EndCatapult();
					}
				}
				else
				{
					component.EndBounce();
				}
			}
		}
		return true;
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x00099EA4 File Offset: 0x000980A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRoleFinishInteract) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyRoleFinishInteract.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DA3 RID: 7587 RVA: 0x00099F34 File Offset: 0x00098134
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置角色交互";
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x00099F3B File Offset: 0x0009813B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRoleFinishInteract._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleFinishInteract.TsAnimNotifyRoleFinishInteract_C");
		}
		return TsAnimNotifyRoleFinishInteract._ClassPtr;
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x00099F60 File Offset: 0x00098160
	public TsAnimNotifyRoleFinishInteract() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleFinishInteract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x00099F88 File Offset: 0x00098188
	[NullableContext(1)]
	public TsAnimNotifyRoleFinishInteract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleFinishInteract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x00099FBB File Offset: 0x000981BB
	protected TsAnimNotifyRoleFinishInteract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x00099FC4 File Offset: 0x000981C4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x00099FF7 File Offset: 0x000981F7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001269 RID: 4713
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleFinishInteract.TsAnimNotifyRoleFinishInteract_C";

	// Token: 0x0400126A RID: 4714
	private static IntPtr _ClassPtr;

	// Token: 0x0400126B RID: 4715
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400126C RID: 4716
	private static int __PropertyOffset_Type;
}

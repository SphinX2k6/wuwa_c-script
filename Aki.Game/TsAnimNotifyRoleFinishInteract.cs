using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Role.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D0 RID: 464
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleFinishInteract.TsAnimNotifyRoleFinishInteract_C")]
public class TsAnimNotifyRoleFinishInteract : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00093013 File Offset: 0x00091213
	// (set) Token: 0x06001D02 RID: 7426 RVA: 0x00093023 File Offset: 0x00091223
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

	// Token: 0x06001D03 RID: 7427 RVA: 0x00093034 File Offset: 0x00091234
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x000930D4 File Offset: 0x000912D4
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

	// Token: 0x06001D05 RID: 7429 RVA: 0x00093124 File Offset: 0x00091324
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

	// Token: 0x06001D06 RID: 7430 RVA: 0x0009319F File Offset: 0x0009139F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置角色交互";
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x000931A6 File Offset: 0x000913A6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRoleFinishInteract._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleFinishInteract.TsAnimNotifyRoleFinishInteract_C");
		}
		return TsAnimNotifyRoleFinishInteract._ClassPtr;
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x000931CC File Offset: 0x000913CC
	public TsAnimNotifyRoleFinishInteract() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleFinishInteract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x000931F4 File Offset: 0x000913F4
	[NullableContext(1)]
	public TsAnimNotifyRoleFinishInteract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleFinishInteract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x00093227 File Offset: 0x00091427
	protected TsAnimNotifyRoleFinishInteract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00093230 File Offset: 0x00091430
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x00093263 File Offset: 0x00091463
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001226 RID: 4646
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleFinishInteract.TsAnimNotifyRoleFinishInteract_C";

	// Token: 0x04001227 RID: 4647
	private static IntPtr _ClassPtr;

	// Token: 0x04001228 RID: 4648
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001229 RID: 4649
	private static int __PropertyOffset_Type;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D1 RID: 465
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleHoldingHands.TsAnimNotifyRoleHoldingHands_C")]
public class TsAnimNotifyRoleHoldingHands : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00093277 File Offset: 0x00091477
	// (set) Token: 0x06001D0E RID: 7438 RVA: 0x00093287 File Offset: 0x00091487
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool InvitationAccept
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRoleHoldingHands.__PropertyOffset_InvitationAccept) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRoleHoldingHands.__PropertyOffset_InvitationAccept) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00093298 File Offset: 0x00091498
	// (set) Token: 0x06001D10 RID: 7440 RVA: 0x000932A8 File Offset: 0x000914A8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool StartBinding
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRoleHoldingHands.__PropertyOffset_StartBinding) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRoleHoldingHands.__PropertyOffset_StartBinding) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x000932BC File Offset: 0x000914BC
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

	// Token: 0x06001D12 RID: 7442 RVA: 0x0009335C File Offset: 0x0009155C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entity;
			if (tsBaseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			if (entity2 == null || !entity2.Valid)
			{
				return false;
			}
			CharacterHoldingHandsComponent component = entity2.GetComponent<CharacterHoldingHandsComponent>();
			if (this.InvitationAccept && component != null)
			{
				component.FollowerAccept();
			}
			if (this.StartBinding && component != null)
			{
				component.InvitationToBinding();
			}
		}
		return true;
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x000933D0 File Offset: 0x000915D0
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

	// Token: 0x06001D14 RID: 7444 RVA: 0x0009344B File Offset: 0x0009164B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "牵手";
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x00093452 File Offset: 0x00091652
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRoleHoldingHands._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleHoldingHands.TsAnimNotifyRoleHoldingHands_C");
		}
		return TsAnimNotifyRoleHoldingHands._ClassPtr;
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x00093478 File Offset: 0x00091678
	public TsAnimNotifyRoleHoldingHands() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleHoldingHands.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D17 RID: 7447 RVA: 0x000934A0 File Offset: 0x000916A0
	[NullableContext(1)]
	public TsAnimNotifyRoleHoldingHands(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleHoldingHands.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x000934D3 File Offset: 0x000916D3
	protected TsAnimNotifyRoleHoldingHands(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x000934DC File Offset: 0x000916DC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D1A RID: 7450 RVA: 0x0009350F File Offset: 0x0009170F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400122A RID: 4650
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleHoldingHands.TsAnimNotifyRoleHoldingHands_C";

	// Token: 0x0400122B RID: 4651
	private static IntPtr _ClassPtr;

	// Token: 0x0400122C RID: 4652
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400122D RID: 4653
	private static int __PropertyOffset_InvitationAccept;

	// Token: 0x0400122E RID: 4654
	private static int __PropertyOffset_StartBinding;
}

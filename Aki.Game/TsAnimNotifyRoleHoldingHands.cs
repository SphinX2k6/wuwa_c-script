using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D5 RID: 469
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleHoldingHands.TsAnimNotifyRoleHoldingHands_C")]
public class TsAnimNotifyRoleHoldingHands : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0009A00B File Offset: 0x0009820B
	// (set) Token: 0x06001DAB RID: 7595 RVA: 0x0009A01B File Offset: 0x0009821B
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

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0009A02C File Offset: 0x0009822C
	// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0009A03C File Offset: 0x0009823C
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

	// Token: 0x06001DAE RID: 7598 RVA: 0x0009A050 File Offset: 0x00098250
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRoleHoldingHands) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyRoleHoldingHands.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DAF RID: 7599 RVA: 0x0009A108 File Offset: 0x00098308
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

	// Token: 0x06001DB0 RID: 7600 RVA: 0x0009A17C File Offset: 0x0009837C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRoleHoldingHands) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyRoleHoldingHands.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0009A20C File Offset: 0x0009840C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "牵手";
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x0009A213 File Offset: 0x00098413
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRoleHoldingHands._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleHoldingHands.TsAnimNotifyRoleHoldingHands_C");
		}
		return TsAnimNotifyRoleHoldingHands._ClassPtr;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0009A238 File Offset: 0x00098438
	public TsAnimNotifyRoleHoldingHands() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleHoldingHands.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x0009A260 File Offset: 0x00098460
	[NullableContext(1)]
	public TsAnimNotifyRoleHoldingHands(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleHoldingHands.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x0009A293 File Offset: 0x00098493
	protected TsAnimNotifyRoleHoldingHands(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x0009A29C File Offset: 0x0009849C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x0009A2CF File Offset: 0x000984CF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400126D RID: 4717
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleHoldingHands.TsAnimNotifyRoleHoldingHands_C";

	// Token: 0x0400126E RID: 4718
	private static IntPtr _ClassPtr;

	// Token: 0x0400126F RID: 4719
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001270 RID: 4720
	private static int __PropertyOffset_InvitationAccept;

	// Token: 0x04001271 RID: 4721
	private static int __PropertyOffset_StartBinding;
}

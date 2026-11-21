using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D7 RID: 471
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEvent.TsAnimNotifySendGamePlayEvent_C")]
public class TsAnimNotifySendGamePlayEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0009A567 File Offset: 0x00098767
	// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0009A57B File Offset: 0x0009877B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 事件Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySendGamePlayEvent.__PropertyOffset_事件Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySendGamePlayEvent.__PropertyOffset_事件Tag) = value;
		}
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x0009A590 File Offset: 0x00098790
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySendGamePlayEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySendGamePlayEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DC5 RID: 7621 RVA: 0x0009A648 File Offset: 0x00098848
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			BaseAbilityComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<BaseAbilityComponent>();
			if (component == null || !component.Valid)
			{
				return false;
			}
			component.SendGameplayEventToActor(this.事件Tag, null);
		}
		return false;
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x0009A698 File Offset: 0x00098898
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySendGamePlayEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySendGamePlayEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DC7 RID: 7623 RVA: 0x0009A728 File Offset: 0x00098928
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "发送动画通知广播";
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x0009A72F File Offset: 0x0009892F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySendGamePlayEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEvent.TsAnimNotifySendGamePlayEvent_C");
		}
		return TsAnimNotifySendGamePlayEvent._ClassPtr;
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0009A754 File Offset: 0x00098954
	public TsAnimNotifySendGamePlayEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x0009A77C File Offset: 0x0009897C
	[NullableContext(1)]
	public TsAnimNotifySendGamePlayEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x0009A7AF File Offset: 0x000989AF
	protected TsAnimNotifySendGamePlayEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x0009A7B8 File Offset: 0x000989B8
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x0009A7EB File Offset: 0x000989EB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001275 RID: 4725
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEvent.TsAnimNotifySendGamePlayEvent_C";

	// Token: 0x04001276 RID: 4726
	private static IntPtr _ClassPtr;

	// Token: 0x04001277 RID: 4727
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001278 RID: 4728
	private static int __PropertyOffset_事件Tag;
}

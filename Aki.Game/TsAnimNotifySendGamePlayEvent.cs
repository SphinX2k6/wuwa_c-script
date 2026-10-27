using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D3 RID: 467
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEvent.TsAnimNotifySendGamePlayEvent_C")]
public class TsAnimNotifySendGamePlayEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0009377B File Offset: 0x0009197B
	// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0009378F File Offset: 0x0009198F
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

	// Token: 0x06001D27 RID: 7463 RVA: 0x000937A4 File Offset: 0x000919A4
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

	// Token: 0x06001D28 RID: 7464 RVA: 0x00093844 File Offset: 0x00091A44
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

	// Token: 0x06001D29 RID: 7465 RVA: 0x00093894 File Offset: 0x00091A94
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

	// Token: 0x06001D2A RID: 7466 RVA: 0x0009390F File Offset: 0x00091B0F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "发送动画通知广播";
	}

	// Token: 0x06001D2B RID: 7467 RVA: 0x00093916 File Offset: 0x00091B16
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySendGamePlayEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEvent.TsAnimNotifySendGamePlayEvent_C");
		}
		return TsAnimNotifySendGamePlayEvent._ClassPtr;
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x0009393C File Offset: 0x00091B3C
	public TsAnimNotifySendGamePlayEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x00093964 File Offset: 0x00091B64
	[NullableContext(1)]
	public TsAnimNotifySendGamePlayEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x00093997 File Offset: 0x00091B97
	protected TsAnimNotifySendGamePlayEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x000939A0 File Offset: 0x00091BA0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x000939D3 File Offset: 0x00091BD3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001232 RID: 4658
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySendGamePlayEvent.TsAnimNotifySendGamePlayEvent_C";

	// Token: 0x04001233 RID: 4659
	private static IntPtr _ClassPtr;

	// Token: 0x04001234 RID: 4660
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001235 RID: 4661
	private static int __PropertyOffset_事件Tag;
}

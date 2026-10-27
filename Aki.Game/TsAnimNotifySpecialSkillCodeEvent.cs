using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DA RID: 474
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySpecialSkillCodeEvent.TsAnimNotifySpecialSkillCodeEvent_C")]
public class TsAnimNotifySpecialSkillCodeEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00094ADB File Offset: 0x00092CDB
	// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00094AEF File Offset: 0x00092CEF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string EventName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySpecialSkillCodeEvent.__PropertyOffset_EventName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySpecialSkillCodeEvent.__PropertyOffset_EventName)), value);
		}
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00094B04 File Offset: 0x00092D04
	// (set) Token: 0x06001D81 RID: 7553 RVA: 0x00094B3D File Offset: 0x00092D3D
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCodeFunctionPayload Payload
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCodeFunctionPayload result;
			if ((result = this._Payload) == null)
			{
				result = (this._Payload = new FKuroCodeFunctionPayload(base.NativePtr + (IntPtr)TsAnimNotifySpecialSkillCodeEvent.__PropertyOffset_Payload, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCodeFunctionPayload.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifySpecialSkillCodeEvent.__PropertyOffset_Payload, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x00094B68 File Offset: 0x00092D68
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

	// Token: 0x06001D83 RID: 7555 RVA: 0x00094C08 File Offset: 0x00092E08
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return false;
		}
		CharacterSpecialSkillComponent component = entity.GetComponent<CharacterSpecialSkillComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		component.DispatchCodeAnimNotify(this.EventName, this.Payload);
		return true;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x00094C6C File Offset: 0x00092E6C
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

	// Token: 0x06001D85 RID: 7557 RVA: 0x00094CE7 File Offset: 0x00092EE7
	protected override string GetNotifyName_Implementation()
	{
		return "SpecialSkill帧事件";
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x00094CEE File Offset: 0x00092EEE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySpecialSkillCodeEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySpecialSkillCodeEvent.TsAnimNotifySpecialSkillCodeEvent_C");
		}
		return TsAnimNotifySpecialSkillCodeEvent._ClassPtr;
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x00094D14 File Offset: 0x00092F14
	public TsAnimNotifySpecialSkillCodeEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySpecialSkillCodeEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x00094D3C File Offset: 0x00092F3C
	public TsAnimNotifySpecialSkillCodeEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySpecialSkillCodeEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x00094D6F File Offset: 0x00092F6F
	protected TsAnimNotifySpecialSkillCodeEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x00094D78 File Offset: 0x00092F78
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x00094DAB File Offset: 0x00092FAB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001252 RID: 4690
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySpecialSkillCodeEvent.TsAnimNotifySpecialSkillCodeEvent_C";

	// Token: 0x04001253 RID: 4691
	private static IntPtr _ClassPtr;

	// Token: 0x04001254 RID: 4692
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001255 RID: 4693
	private static int __PropertyOffset_EventName;

	// Token: 0x04001256 RID: 4694
	private static int __PropertyOffset_Payload;

	// Token: 0x04001257 RID: 4695
	[Nullable(2)]
	private FKuroCodeFunctionPayload _Payload;
}

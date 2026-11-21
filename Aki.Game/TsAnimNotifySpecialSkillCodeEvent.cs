using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DE RID: 478
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySpecialSkillCodeEvent.TsAnimNotifySpecialSkillCodeEvent_C")]
public class TsAnimNotifySpecialSkillCodeEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0009B9FB File Offset: 0x00099BFB
	// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0009BA0F File Offset: 0x00099C0F
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

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0009BA24 File Offset: 0x00099C24
	// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0009BA5D File Offset: 0x00099C5D
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

	// Token: 0x06001E1F RID: 7711 RVA: 0x0009BA88 File Offset: 0x00099C88
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySpecialSkillCodeEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySpecialSkillCodeEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E20 RID: 7712 RVA: 0x0009BB40 File Offset: 0x00099D40
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

	// Token: 0x06001E21 RID: 7713 RVA: 0x0009BBA4 File Offset: 0x00099DA4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySpecialSkillCodeEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySpecialSkillCodeEvent.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E22 RID: 7714 RVA: 0x0009BC34 File Offset: 0x00099E34
	protected override string GetNotifyName_Implementation()
	{
		return "SpecialSkill帧事件";
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x0009BC3B File Offset: 0x00099E3B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySpecialSkillCodeEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySpecialSkillCodeEvent.TsAnimNotifySpecialSkillCodeEvent_C");
		}
		return TsAnimNotifySpecialSkillCodeEvent._ClassPtr;
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x0009BC60 File Offset: 0x00099E60
	public TsAnimNotifySpecialSkillCodeEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySpecialSkillCodeEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x0009BC88 File Offset: 0x00099E88
	public TsAnimNotifySpecialSkillCodeEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySpecialSkillCodeEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x0009BCBB File Offset: 0x00099EBB
	protected TsAnimNotifySpecialSkillCodeEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x0009BCC4 File Offset: 0x00099EC4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x0009BCF7 File Offset: 0x00099EF7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001295 RID: 4757
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySpecialSkillCodeEvent.TsAnimNotifySpecialSkillCodeEvent_C";

	// Token: 0x04001296 RID: 4758
	private static IntPtr _ClassPtr;

	// Token: 0x04001297 RID: 4759
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001298 RID: 4760
	private static int __PropertyOffset_EventName;

	// Token: 0x04001299 RID: 4761
	private static int __PropertyOffset_Payload;

	// Token: 0x0400129A RID: 4762
	[Nullable(2)]
	private FKuroCodeFunctionPayload _Payload;
}

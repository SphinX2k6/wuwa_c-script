using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000176 RID: 374
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSpecialSkillCodeEvent.TsAnimNotifyStateSpecialSkillCodeEvent_C")]
public class TsAnimNotifyStateSpecialSkillCodeEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0007F18B File Offset: 0x0007D38B
	// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0007F19F File Offset: 0x0007D39F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string EventName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSpecialSkillCodeEvent.__PropertyOffset_EventName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSpecialSkillCodeEvent.__PropertyOffset_EventName)), value);
		}
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0007F1B4 File Offset: 0x0007D3B4
	// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0007F1ED File Offset: 0x0007D3ED
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCodeFunctionPayload Payload
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCodeFunctionPayload result;
			if ((result = this._Payload) == null)
			{
				result = (this._Payload = new FKuroCodeFunctionPayload(base.NativePtr + (IntPtr)TsAnimNotifyStateSpecialSkillCodeEvent.__PropertyOffset_Payload, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCodeFunctionPayload.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateSpecialSkillCodeEvent.__PropertyOffset_Payload, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0007F218 File Offset: 0x0007D418
	[NullableContext(2)]
	private CharacterSpecialSkillComponent GetSpecialSkillComp(USkeletalMeshComponent meshComp)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return null;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return null;
		}
		CharacterSpecialSkillComponent component = entity.GetComponent<CharacterSpecialSkillComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component;
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x0007F26C File Offset: 0x0007D46C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x0007F314 File Offset: 0x0007D514
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		CharacterSpecialSkillComponent specialSkillComp = this.GetSpecialSkillComp(meshComp);
		if (specialSkillComp == null)
		{
			return false;
		}
		specialSkillComp.DispatchCodeAnimNotifyBegin(this.EventName, totalDuration, this.Payload, animation);
		return true;
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x0007F344 File Offset: 0x0007D544
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x0007F3EC File Offset: 0x0007D5EC
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		CharacterSpecialSkillComponent specialSkillComp = this.GetSpecialSkillComp(meshComp);
		if (specialSkillComp == null)
		{
			return false;
		}
		specialSkillComp.DispatchCodeAnimNotifyTick(this.EventName, frameDeltaTime, this.Payload, animation);
		return true;
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x0007F41C File Offset: 0x0007D61C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x060017AF RID: 6063 RVA: 0x0007F4BC File Offset: 0x0007D6BC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		CharacterSpecialSkillComponent specialSkillComp = this.GetSpecialSkillComp(meshComp);
		if (specialSkillComp == null)
		{
			return false;
		}
		specialSkillComp.DispatchCodeAnimNotifyEnd(this.EventName, this.Payload, animation);
		return true;
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x0007F4EC File Offset: 0x0007D6EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x060017B1 RID: 6065 RVA: 0x0007F567 File Offset: 0x0007D767
	protected override string GetNotifyName_Implementation()
	{
		return "SpecialSkill帧事件";
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x0007F56E File Offset: 0x0007D76E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSpecialSkillCodeEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSpecialSkillCodeEvent.TsAnimNotifyStateSpecialSkillCodeEvent_C");
		}
		return TsAnimNotifyStateSpecialSkillCodeEvent._ClassPtr;
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x0007F594 File Offset: 0x0007D794
	public TsAnimNotifyStateSpecialSkillCodeEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x0007F5BC File Offset: 0x0007D7BC
	public TsAnimNotifyStateSpecialSkillCodeEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x0007F5EF File Offset: 0x0007D7EF
	protected TsAnimNotifyStateSpecialSkillCodeEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x0007F5F8 File Offset: 0x0007D7F8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x0007F634 File Offset: 0x0007D834
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x0007F670 File Offset: 0x0007D870
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x0007F6A3 File Offset: 0x0007D8A3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FF9 RID: 4089
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSpecialSkillCodeEvent.TsAnimNotifyStateSpecialSkillCodeEvent_C";

	// Token: 0x04000FFA RID: 4090
	private static IntPtr _ClassPtr;

	// Token: 0x04000FFB RID: 4091
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FFC RID: 4092
	private static int __PropertyOffset_EventName;

	// Token: 0x04000FFD RID: 4093
	private static int __PropertyOffset_Payload;

	// Token: 0x04000FFE RID: 4094
	[Nullable(2)]
	private FKuroCodeFunctionPayload _Payload;
}

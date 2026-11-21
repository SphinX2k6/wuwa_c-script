using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200017A RID: 378
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSpecialSkillCodeEvent.TsAnimNotifyStateSpecialSkillCodeEvent_C")]
public class TsAnimNotifyStateSpecialSkillCodeEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06001842 RID: 6210 RVA: 0x00084F5B File Offset: 0x0008315B
	// (set) Token: 0x06001843 RID: 6211 RVA: 0x00084F6F File Offset: 0x0008316F
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

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06001844 RID: 6212 RVA: 0x00084F84 File Offset: 0x00083184
	// (set) Token: 0x06001845 RID: 6213 RVA: 0x00084FBD File Offset: 0x000831BD
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

	// Token: 0x06001846 RID: 6214 RVA: 0x00084FE8 File Offset: 0x000831E8
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

	// Token: 0x06001847 RID: 6215 RVA: 0x0008503C File Offset: 0x0008323C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSpecialSkillCodeEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x000850FC File Offset: 0x000832FC
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

	// Token: 0x06001849 RID: 6217 RVA: 0x0008512C File Offset: 0x0008332C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSpecialSkillCodeEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x000851EC File Offset: 0x000833EC
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

	// Token: 0x0600184B RID: 6219 RVA: 0x0008521C File Offset: 0x0008341C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSpecialSkillCodeEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x000852D4 File Offset: 0x000834D4
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

	// Token: 0x0600184D RID: 6221 RVA: 0x00085304 File Offset: 0x00083504
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSpecialSkillCodeEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x00085394 File Offset: 0x00083594
	protected override string GetNotifyName_Implementation()
	{
		return "SpecialSkill帧事件";
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x0008539B File Offset: 0x0008359B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSpecialSkillCodeEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSpecialSkillCodeEvent.TsAnimNotifyStateSpecialSkillCodeEvent_C");
		}
		return TsAnimNotifyStateSpecialSkillCodeEvent._ClassPtr;
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x000853C0 File Offset: 0x000835C0
	public TsAnimNotifyStateSpecialSkillCodeEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x000853E8 File Offset: 0x000835E8
	public TsAnimNotifyStateSpecialSkillCodeEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSpecialSkillCodeEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x0008541B File Offset: 0x0008361B
	protected TsAnimNotifyStateSpecialSkillCodeEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x00085424 File Offset: 0x00083624
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x00085460 File Offset: 0x00083660
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x0008549C File Offset: 0x0008369C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x000854CF File Offset: 0x000836CF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400103C RID: 4156
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSpecialSkillCodeEvent.TsAnimNotifyStateSpecialSkillCodeEvent_C";

	// Token: 0x0400103D RID: 4157
	private static IntPtr _ClassPtr;

	// Token: 0x0400103E RID: 4158
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400103F RID: 4159
	private static int __PropertyOffset_EventName;

	// Token: 0x04001040 RID: 4160
	private static int __PropertyOffset_Payload;

	// Token: 0x04001041 RID: 4161
	[Nullable(2)]
	private FKuroCodeFunctionPayload _Payload;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200011C RID: 284
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtTrigger.TsAnimNotifyStateCaughtTrigger_C")]
public class TsAnimNotifyStateCaughtTrigger : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06001103 RID: 4355 RVA: 0x0006192C File Offset: 0x0005FB2C
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> CaughtIds
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._CaughtIds) == null)
			{
				result = (this._CaughtIds = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyStateCaughtTrigger.__PropertyOffset_CaughtIds, this));
			}
			return result;
		}
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00061968 File Offset: 0x0005FB68
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCaughtTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCaughtTrigger.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001105 RID: 4357 RVA: 0x00061A28 File Offset: 0x0005FC28
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
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
		CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
		long? caughtTriggerAnsInfo = (component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
		CharacterCaughtNewComponent component3 = entity.GetComponent<CharacterCaughtNewComponent>();
		if (component3 != null)
		{
			component3.SetCaughtTriggerAnsInfo(caughtTriggerAnsInfo);
			CharacterCaughtNewComponent characterCaughtNewComponent = component3;
			TArray<string> caughtIds = this.CaughtIds;
			int? num;
			if (component2 == null)
			{
				num = null;
			}
			else
			{
				Skill currentSkill = component2.CurrentSkill;
				num = ((currentSkill != null) ? new int?(currentSkill.SkillId) : null);
			}
			int? num2 = num;
			characterCaughtNewComponent.BeginCaughtTrigger(caughtIds, num2.GetValueOrDefault());
			return true;
		}
		return false;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00061AEC File Offset: 0x0005FCEC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCaughtTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCaughtTrigger.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001107 RID: 4359 RVA: 0x00061BA4 File Offset: 0x0005FDA4
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
		CharacterCaughtNewComponent component = entity.GetComponent<CharacterCaughtNewComponent>();
		if (component != null)
		{
			component.EndCaughtTrigger();
			return true;
		}
		return false;
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00061BF0 File Offset: 0x0005FDF0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCaughtTrigger) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCaughtTrigger.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001109 RID: 4361 RVA: 0x00061C80 File Offset: 0x0005FE80
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "抓取判定";
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00061C87 File Offset: 0x0005FE87
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCaughtTrigger._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtTrigger.TsAnimNotifyStateCaughtTrigger_C");
		}
		return TsAnimNotifyStateCaughtTrigger._ClassPtr;
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00061CAC File Offset: 0x0005FEAC
	public TsAnimNotifyStateCaughtTrigger() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCaughtTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00061CD4 File Offset: 0x0005FED4
	[NullableContext(1)]
	public TsAnimNotifyStateCaughtTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCaughtTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00061D07 File Offset: 0x0005FF07
	protected TsAnimNotifyStateCaughtTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00061D10 File Offset: 0x0005FF10
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00061D4C File Offset: 0x0005FF4C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00061D7F File Offset: 0x0005FF7F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CE5 RID: 3301
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtTrigger.TsAnimNotifyStateCaughtTrigger_C";

	// Token: 0x04000CE6 RID: 3302
	private static IntPtr _ClassPtr;

	// Token: 0x04000CE7 RID: 3303
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CE8 RID: 3304
	private static int __PropertyOffset_CaughtIds;

	// Token: 0x04000CE9 RID: 3305
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CaughtIds;
}

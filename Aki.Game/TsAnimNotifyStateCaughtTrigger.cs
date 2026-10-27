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
	// Token: 0x170002BA RID: 698
	// (get) Token: 0x060010FD RID: 4349 RVA: 0x00060484 File Offset: 0x0005E684
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

	// Token: 0x060010FE RID: 4350 RVA: 0x000604C0 File Offset: 0x0005E6C0
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

	// Token: 0x060010FF RID: 4351 RVA: 0x00060568 File Offset: 0x0005E768
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

	// Token: 0x06001100 RID: 4352 RVA: 0x0006062C File Offset: 0x0005E82C
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

	// Token: 0x06001101 RID: 4353 RVA: 0x000606CC File Offset: 0x0005E8CC
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

	// Token: 0x06001102 RID: 4354 RVA: 0x00060718 File Offset: 0x0005E918
	[NullableContext(1)]
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

	// Token: 0x06001103 RID: 4355 RVA: 0x00060793 File Offset: 0x0005E993
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "抓取判定";
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x0006079A File Offset: 0x0005E99A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCaughtTrigger._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtTrigger.TsAnimNotifyStateCaughtTrigger_C");
		}
		return TsAnimNotifyStateCaughtTrigger._ClassPtr;
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x000607C0 File Offset: 0x0005E9C0
	public TsAnimNotifyStateCaughtTrigger() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCaughtTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x000607E8 File Offset: 0x0005E9E8
	[NullableContext(1)]
	public TsAnimNotifyStateCaughtTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCaughtTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x0006081B File Offset: 0x0005EA1B
	protected TsAnimNotifyStateCaughtTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00060824 File Offset: 0x0005EA24
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00060860 File Offset: 0x0005EA60
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00060893 File Offset: 0x0005EA93
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CDD RID: 3293
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtTrigger.TsAnimNotifyStateCaughtTrigger_C";

	// Token: 0x04000CDE RID: 3294
	private static IntPtr _ClassPtr;

	// Token: 0x04000CDF RID: 3295
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CE0 RID: 3296
	private static int __PropertyOffset_CaughtIds;

	// Token: 0x04000CE1 RID: 3297
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CaughtIds;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000174 RID: 372
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkillBehavior.TsAnimNotifyStateSkillBehavior_C")]
public class TsAnimNotifyStateSkillBehavior : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001781 RID: 6017 RVA: 0x0007E757 File Offset: 0x0007C957
	static TsAnimNotifyStateSkillBehavior()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateSkillBehavior.CreateStaticDefaultValue), new Action(TsAnimNotifyStateSkillBehavior.ResetStaticDefaultValue));
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x0007E776 File Offset: 0x0007C976
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateSkillBehavior._skillBehaviorMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, bool>>();
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x0007E782 File Offset: 0x0007C982
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateSkillBehavior._skillBehaviorMap = null;
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06001784 RID: 6020 RVA: 0x0007E78C File Offset: 0x0007C98C
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSkillBehavior> 技能行为
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<SSkillBehavior> result;
			if ((result = this._技能行为) == null)
			{
				result = (this._技能行为 = new TArray<SSkillBehavior>(base.NativePtr + (IntPtr)TsAnimNotifyStateSkillBehavior.__PropertyOffset_技能行为, this));
			}
			return result;
		}
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x0007E7C8 File Offset: 0x0007C9C8
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

	// Token: 0x06001786 RID: 6022 RVA: 0x0007E870 File Offset: 0x0007CA70
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		BaseBuffComponent component2 = entity.GetComponent<BaseBuffComponent>();
		CharacterSkillComponent component3 = entity.GetComponent<CharacterSkillComponent>();
		Skill skill = (component3 != null) ? component3.CurrentSkill : null;
		if (component == null || skill == null || component.IsSkillMontageInvalid(animation.GetName()))
		{
			return false;
		}
		if (TsAnimNotifyStateSkillBehavior._skillBehaviorMap == null)
		{
			return false;
		}
		Dictionary<UAnimNotifyState, bool> dictionary;
		if (!TsAnimNotifyStateSkillBehavior._skillBehaviorMap.TryGetValue(meshComp, out dictionary))
		{
			dictionary = new Dictionary<UAnimNotifyState, bool>();
			TsAnimNotifyStateSkillBehavior._skillBehaviorMap[meshComp] = dictionary;
		}
		bool flag;
		if (dictionary.TryGetValue(this, out flag) && flag)
		{
			return false;
		}
		BeginSkillBehaviorConditionParam param = new BeginSkillBehaviorConditionParam
		{
			Entity = entity,
			SkillComponent = component,
			Skill = skill
		};
		BeginSkillBehaviorActionParam param2 = new BeginSkillBehaviorActionParam
		{
			Entity = entity,
			SkillComponent = component,
			Skill = skill
		};
		for (int i = 0; i < this.技能行为.Num(); i++)
		{
			SSkillBehavior sskillBehavior = this.技能行为.Get(i);
			if (SkillBehaviorCondition.SatisfyGroup(sskillBehavior.SkillBehaviorConditionGroup, sskillBehavior.SkillBehaviorConditionFormula, param))
			{
				dictionary[this] = true;
				long? skillBehaviorAnimNotifyMessageId = (component2 != null) ? component2.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
				skill.SkillBehaviorAnimNotifyMessageId = skillBehaviorAnimNotifyMessageId;
				SkillBehaviorAction.BeginGroup(sskillBehavior.SkillBehaviorActionGroup, param2);
				if (!sskillBehavior.SkillBehaviorContinue)
				{
					break;
				}
			}
		}
		return true;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x0007E9DC File Offset: 0x0007CBDC
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

	// Token: 0x06001788 RID: 6024 RVA: 0x0007EA7C File Offset: 0x0007CC7C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!(meshComp.GetOwner() is TsBaseCharacter))
		{
			return false;
		}
		Dictionary<UAnimNotifyState, bool> dictionary;
		if (TsAnimNotifyStateSkillBehavior._skillBehaviorMap != null && TsAnimNotifyStateSkillBehavior._skillBehaviorMap.TryGetValue(meshComp, out dictionary))
		{
			dictionary.Remove(this);
			if (dictionary.Count == 0)
			{
				TsAnimNotifyStateSkillBehavior._skillBehaviorMap.Remove(meshComp);
			}
		}
		return true;
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x0007EACC File Offset: 0x0007CCCC
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

	// Token: 0x0600178A RID: 6026 RVA: 0x0007EB47 File Offset: 0x0007CD47
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "技能行为";
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x0007EB4E File Offset: 0x0007CD4E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSkillBehavior._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkillBehavior.TsAnimNotifyStateSkillBehavior_C");
		}
		return TsAnimNotifyStateSkillBehavior._ClassPtr;
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x0007EB74 File Offset: 0x0007CD74
	public TsAnimNotifyStateSkillBehavior() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkillBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x0007EB9C File Offset: 0x0007CD9C
	[NullableContext(1)]
	public TsAnimNotifyStateSkillBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkillBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x0007EBCF File Offset: 0x0007CDCF
	protected TsAnimNotifyStateSkillBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x0007EBD8 File Offset: 0x0007CDD8
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0007EC14 File Offset: 0x0007CE14
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x0007EC47 File Offset: 0x0007CE47
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FEF RID: 4079
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, bool>> _skillBehaviorMap;

	// Token: 0x04000FF0 RID: 4080
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkillBehavior.TsAnimNotifyStateSkillBehavior_C";

	// Token: 0x04000FF1 RID: 4081
	private static IntPtr _ClassPtr;

	// Token: 0x04000FF2 RID: 4082
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FF3 RID: 4083
	private static int __PropertyOffset_技能行为;

	// Token: 0x04000FF4 RID: 4084
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehavior> _技能行为;
}

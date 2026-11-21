using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000178 RID: 376
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkillBehavior.TsAnimNotifyStateSkillBehavior_C")]
public class TsAnimNotifyStateSkillBehavior : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600181E RID: 6174 RVA: 0x00084487 File Offset: 0x00082687
	static TsAnimNotifyStateSkillBehavior()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateSkillBehavior.CreateStaticDefaultValue), new Action(TsAnimNotifyStateSkillBehavior.ResetStaticDefaultValue));
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x000844A6 File Offset: 0x000826A6
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateSkillBehavior._skillBehaviorMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, bool>>();
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x000844B2 File Offset: 0x000826B2
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateSkillBehavior._skillBehaviorMap = null;
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06001821 RID: 6177 RVA: 0x000844BC File Offset: 0x000826BC
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

	// Token: 0x06001822 RID: 6178 RVA: 0x000844F8 File Offset: 0x000826F8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSkillBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateSkillBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001823 RID: 6179 RVA: 0x000845B8 File Offset: 0x000827B8
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

	// Token: 0x06001824 RID: 6180 RVA: 0x00084724 File Offset: 0x00082924
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSkillBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSkillBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001825 RID: 6181 RVA: 0x000847DC File Offset: 0x000829DC
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

	// Token: 0x06001826 RID: 6182 RVA: 0x0008482C File Offset: 0x00082A2C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSkillBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSkillBehavior.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001827 RID: 6183 RVA: 0x000848BC File Offset: 0x00082ABC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "技能行为";
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x000848C3 File Offset: 0x00082AC3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSkillBehavior._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkillBehavior.TsAnimNotifyStateSkillBehavior_C");
		}
		return TsAnimNotifyStateSkillBehavior._ClassPtr;
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x000848E8 File Offset: 0x00082AE8
	public TsAnimNotifyStateSkillBehavior() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkillBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x00084910 File Offset: 0x00082B10
	[NullableContext(1)]
	public TsAnimNotifyStateSkillBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSkillBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00084943 File Offset: 0x00082B43
	protected TsAnimNotifyStateSkillBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x0008494C File Offset: 0x00082B4C
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00084988 File Offset: 0x00082B88
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x000849BB File Offset: 0x00082BBB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001032 RID: 4146
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, bool>> _skillBehaviorMap;

	// Token: 0x04001033 RID: 4147
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSkillBehavior.TsAnimNotifyStateSkillBehavior_C";

	// Token: 0x04001034 RID: 4148
	private static IntPtr _ClassPtr;

	// Token: 0x04001035 RID: 4149
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001036 RID: 4150
	private static int __PropertyOffset_技能行为;

	// Token: 0x04001037 RID: 4151
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehavior> _技能行为;
}

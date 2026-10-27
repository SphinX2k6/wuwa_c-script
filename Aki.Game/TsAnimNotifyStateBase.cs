using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000112 RID: 274
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBase.TsAnimNotifyStateBase_C")]
public abstract class TsAnimNotifyStateBase : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06001030 RID: 4144 RVA: 0x0005CDF0 File Offset: 0x0005AFF0
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSkillBehaviorCondition> ANS执行的前提条件
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<SSkillBehaviorCondition> result;
			if ((result = this._ANS执行的前提条件) == null)
			{
				result = (this._ANS执行的前提条件 = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)TsAnimNotifyStateBase.__PropertyOffset_ANS执行的前提条件, this));
			}
			return result;
		}
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0005CE29 File Offset: 0x0005B029
	protected bool SetConditionFail(USkeletalMeshComponent meshComp)
	{
		if (this.ConditionFail == null)
		{
			this.ConditionFail = new HashSet<USkeletalMeshComponent>();
		}
		if (meshComp != null)
		{
			this.ConditionFail.Add(meshComp);
		}
		return false;
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0005CE4F File Offset: 0x0005B04F
	protected bool GetConditionResult(USkeletalMeshComponent meshComp)
	{
		if (meshComp == null)
		{
			return false;
		}
		HashSet<USkeletalMeshComponent> conditionFail = this.ConditionFail;
		return conditionFail == null || !conditionFail.Contains(meshComp);
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0005CE6E File Offset: 0x0005B06E
	protected void ClearConditionResult(USkeletalMeshComponent meshComp)
	{
		if (meshComp != null)
		{
			HashSet<USkeletalMeshComponent> conditionFail = this.ConditionFail;
			if (conditionFail == null)
			{
				return;
			}
			conditionFail.Remove(meshComp);
		}
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x0005CE88 File Offset: 0x0005B088
	protected IBeginSkillBehaviorConditionParam CreateBeginConditionParam(USkeletalMeshComponent meshComp)
	{
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
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
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		Skill skill = (component != null) ? component.CurrentSkill : null;
		return new BeginSkillBehaviorConditionParam
		{
			Entity = entity,
			SkillComponent = component,
			Skill = skill
		};
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x0005CEF4 File Offset: 0x0005B0F4
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyBeginConditionCheck(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.ANS执行的前提条件 == null || this.ANS执行的前提条件.Num() == 0)
		{
			return true;
		}
		IBeginSkillBehaviorConditionParam beginSkillBehaviorConditionParam = this.CreateBeginConditionParam(meshComp);
		if (beginSkillBehaviorConditionParam == null)
		{
			return this.SetConditionFail(meshComp);
		}
		return SkillBehaviorCondition.SatisfyGroup(this.ANS执行的前提条件, string.Empty, beginSkillBehaviorConditionParam) || this.SetConditionFail(meshComp);
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x0005CF47 File Offset: 0x0005B147
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyTickConditionCheck(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		return this.GetConditionResult(meshComp);
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0005CF50 File Offset: 0x0005B150
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyEndConditionCheck(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		bool conditionResult = this.GetConditionResult(meshComp);
		this.ClearConditionResult(meshComp);
		return conditionResult;
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0005CF60 File Offset: 0x0005B160
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBase.TsAnimNotifyStateBase_C");
		}
		return TsAnimNotifyStateBase._ClassPtr;
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0005CF84 File Offset: 0x0005B184
	public TsAnimNotifyStateBase() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x0005CFAC File Offset: 0x0005B1AC
	[NullableContext(1)]
	public TsAnimNotifyStateBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x0005CFDF File Offset: 0x0005B1DF
	protected TsAnimNotifyStateBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBeginConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBeginConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x0005D024 File Offset: 0x0005B224
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTickConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTickConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0005D060 File Offset: 0x0005B260
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEndConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEndConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000C85 RID: 3205
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<USkeletalMeshComponent> ConditionFail;

	// Token: 0x04000C86 RID: 3206
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBase.TsAnimNotifyStateBase_C";

	// Token: 0x04000C87 RID: 3207
	private static IntPtr _ClassPtr;

	// Token: 0x04000C88 RID: 3208
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C89 RID: 3209
	private static int __PropertyOffset_ANS执行的前提条件;

	// Token: 0x04000C8A RID: 3210
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehaviorCondition> _ANS执行的前提条件;
}

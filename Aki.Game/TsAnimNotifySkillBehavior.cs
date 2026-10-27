using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D9 RID: 473
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySkillBehavior.TsAnimNotifySkillBehavior_C")]
public class TsAnimNotifySkillBehavior : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00094784 File Offset: 0x00092984
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSkillBehavior> 技能行为
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SSkillBehavior> result;
			if ((result = this._技能行为) == null)
			{
				result = (this._技能行为 = new TArray<SSkillBehavior>(base.NativePtr + (IntPtr)TsAnimNotifySkillBehavior.__PropertyOffset_技能行为, this));
			}
			return result;
		}
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x000947C0 File Offset: 0x000929C0
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

	// Token: 0x06001D75 RID: 7541 RVA: 0x00094860 File Offset: 0x00092A60
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		BaseBuffComponent component2 = entity.GetComponent<BaseBuffComponent>();
		CharacterSkillComponent component3 = entity.GetComponent<CharacterSkillComponent>();
		Skill skill = (component3 != null) ? component3.CurrentSkill : null;
		if (component == null || skill == null || component.IsSkillMontageInvalid(animation.GetName()))
		{
			return false;
		}
		long? skillBehaviorAnimNotifyMessageId = (component2 != null) ? component2.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		skill.SkillBehaviorAnimNotifyMessageId = skillBehaviorAnimNotifyMessageId;
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
				SkillBehaviorAction.BeginGroup(sskillBehavior.SkillBehaviorActionGroup, param2);
				if (!sskillBehavior.SkillBehaviorContinue)
				{
					break;
				}
			}
		}
		return true;
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x00094988 File Offset: 0x00092B88
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

	// Token: 0x06001D77 RID: 7543 RVA: 0x00094A03 File Offset: 0x00092C03
	protected override string GetNotifyName_Implementation()
	{
		return "技能行为";
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x00094A0A File Offset: 0x00092C0A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySkillBehavior._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySkillBehavior.TsAnimNotifySkillBehavior_C");
		}
		return TsAnimNotifySkillBehavior._ClassPtr;
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x00094A30 File Offset: 0x00092C30
	public TsAnimNotifySkillBehavior() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySkillBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x00094A58 File Offset: 0x00092C58
	public TsAnimNotifySkillBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySkillBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x00094A8B File Offset: 0x00092C8B
	protected TsAnimNotifySkillBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x00094A94 File Offset: 0x00092C94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x00094AC7 File Offset: 0x00092CC7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400124D RID: 4685
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySkillBehavior.TsAnimNotifySkillBehavior_C";

	// Token: 0x0400124E RID: 4686
	private static IntPtr _ClassPtr;

	// Token: 0x0400124F RID: 4687
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001250 RID: 4688
	private static int __PropertyOffset_技能行为;

	// Token: 0x04001251 RID: 4689
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehavior> _技能行为;
}

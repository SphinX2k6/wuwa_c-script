using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DB RID: 475
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonBeginSkill.TsAnimNotifySummonBeginSkill_C")]
public class TsAnimNotifySummonBeginSkill : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00094DBF File Offset: 0x00092FBF
	// (set) Token: 0x06001D8D RID: 7565 RVA: 0x00094DCF File Offset: 0x00092FCF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SummonIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_SummonIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_SummonIndex) = value;
		}
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00094DE0 File Offset: 0x00092FE0
	// (set) Token: 0x06001D8F RID: 7567 RVA: 0x00094E19 File Offset: 0x00093019
	[UProperty(EPropertyFlags.CPF_None)]
	public SSkillBehaviorAction ActionSetLocation
	{
		get
		{
			base.FastCheckIsValid();
			SSkillBehaviorAction result;
			if ((result = this._ActionSetLocation) == null)
			{
				result = (this._ActionSetLocation = new SSkillBehaviorAction(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_ActionSetLocation, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorAction.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_ActionSetLocation, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00094E44 File Offset: 0x00093044
	// (set) Token: 0x06001D91 RID: 7569 RVA: 0x00094E7D File Offset: 0x0009307D
	[UProperty(EPropertyFlags.CPF_None)]
	public SSkillBehaviorAction ActionSetRotation
	{
		get
		{
			base.FastCheckIsValid();
			SSkillBehaviorAction result;
			if ((result = this._ActionSetRotation) == null)
			{
				result = (this._ActionSetRotation = new SSkillBehaviorAction(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_ActionSetRotation, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorAction.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_ActionSetRotation, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00094EA5 File Offset: 0x000930A5
	// (set) Token: 0x06001D93 RID: 7571 RVA: 0x00094EB5 File Offset: 0x000930B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_SkillId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_SkillId) = value;
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00094EC6 File Offset: 0x000930C6
	// (set) Token: 0x06001D95 RID: 7573 RVA: 0x00094ED6 File Offset: 0x000930D6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableEntity
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_EnableEntity) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySummonBeginSkill.__PropertyOffset_EnableEntity) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x00094EE8 File Offset: 0x000930E8
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

	// Token: 0x06001D97 RID: 7575 RVA: 0x00094F88 File Offset: 0x00093188
	[NullableContext(2)]
	protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null || !(owner is TsBaseCharacter))
		{
			return false;
		}
		if (this.ActionSetLocation == null || this.ActionSetRotation == null)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		Entity entity;
		if (tsBaseCharacter == null)
		{
			entity = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 == null || !entity2.Valid)
		{
			return false;
		}
		CharacterSkillComponent component = entity2.GetComponent<CharacterSkillComponent>();
		if (component == null || component.CurrentSkill == null)
		{
			return false;
		}
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(entity2, ESummonType.ConcomitantCustom, this.SummonIndex);
		if (summonedEntity == null || !summonedEntity.Valid)
		{
			return false;
		}
		CharacterSkillComponent component2 = summonedEntity.Entity.GetComponent<CharacterSkillComponent>();
		if (component2 == null)
		{
			return false;
		}
		BeginSkillBehaviorActionParam param = new BeginSkillBehaviorActionParam
		{
			Entity = entity2,
			SkillComponent = component,
			Skill = component.CurrentSkill
		};
		FVectorDouble fvectorDouble = SkillBehaviorAction.CalculateLocation(this.ActionSetLocation, param);
		FRotator frotator = SkillBehaviorAction.CalculateRotation(this.ActionSetRotation, param);
		if (!fvectorDouble.Equals(Vector.ZeroVectorDouble, 9.999999747378752E-05))
		{
			BaseActorComponent component3 = summonedEntity.Entity.GetComponent<CharacterActorComponent>();
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity3 = summonedEntity.Entity;
			string message = "TsAnimNotifySummonBeginSkill.SetActorLocationAndRotation";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("位置", fvectorDouble);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("旋转", frotator);
			instance.Info(flag, entity3, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			component3.SetActorLocationAndRotation(fvectorDouble, frotator, "TsAnimNotifySummonBeginSkill.SetActorLocationAndRotation", false, null);
		}
		if (this.EnableEntity)
		{
			CreatureController.Instance.SetEntityEnable(summonedEntity.Entity, true, "TsAnimNotifySummonBeginSkill.SetEntityEnable", true);
		}
		BaseSkillComponent baseSkillComponent = component2;
		int skillId = this.SkillId;
		SkillParam skillParam = new SkillParam();
		EntityHandle skillTarget = component.SkillTarget;
		skillParam.Target = ((skillTarget != null) ? skillTarget.Entity : null);
		skillParam.Reason = "TsAnimNotifySummonBeginSkill.UseSummonSkill";
		baseSkillComponent.BeginSkillAsync(skillId, skillParam).Forget<bool>();
		return true;
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x0009517C File Offset: 0x0009337C
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

	// Token: 0x06001D99 RID: 7577 RVA: 0x000951F7 File Offset: 0x000933F7
	protected override string GetNotifyName_Implementation()
	{
		return "召唤伴生物释放技能";
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x000951FE File Offset: 0x000933FE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySummonBeginSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonBeginSkill.TsAnimNotifySummonBeginSkill_C");
		}
		return TsAnimNotifySummonBeginSkill._ClassPtr;
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x00095224 File Offset: 0x00093424
	public TsAnimNotifySummonBeginSkill() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonBeginSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x0009524C File Offset: 0x0009344C
	public TsAnimNotifySummonBeginSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonBeginSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x0009527F File Offset: 0x0009347F
	protected TsAnimNotifySummonBeginSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x00095288 File Offset: 0x00093488
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x000952BB File Offset: 0x000934BB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001258 RID: 4696
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonBeginSkill.TsAnimNotifySummonBeginSkill_C";

	// Token: 0x04001259 RID: 4697
	private static IntPtr _ClassPtr;

	// Token: 0x0400125A RID: 4698
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400125B RID: 4699
	private static int __PropertyOffset_SummonIndex;

	// Token: 0x0400125C RID: 4700
	private static int __PropertyOffset_ActionSetLocation;

	// Token: 0x0400125D RID: 4701
	[Nullable(2)]
	private SSkillBehaviorAction _ActionSetLocation;

	// Token: 0x0400125E RID: 4702
	private static int __PropertyOffset_ActionSetRotation;

	// Token: 0x0400125F RID: 4703
	[Nullable(2)]
	private SSkillBehaviorAction _ActionSetRotation;

	// Token: 0x04001260 RID: 4704
	private static int __PropertyOffset_SkillId;

	// Token: 0x04001261 RID: 4705
	private static int __PropertyOffset_EnableEntity;
}

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

// Token: 0x020001DF RID: 479
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonBeginSkill.TsAnimNotifySummonBeginSkill_C")]
public class TsAnimNotifySummonBeginSkill : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0009BD0B File Offset: 0x00099F0B
	// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0009BD1B File Offset: 0x00099F1B
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

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0009BD2C File Offset: 0x00099F2C
	// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0009BD65 File Offset: 0x00099F65
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

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0009BD90 File Offset: 0x00099F90
	// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0009BDC9 File Offset: 0x00099FC9
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

	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0009BDF1 File Offset: 0x00099FF1
	// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0009BE01 File Offset: 0x0009A001
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

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0009BE12 File Offset: 0x0009A012
	// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0009BE22 File Offset: 0x0009A022
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

	// Token: 0x06001E33 RID: 7731 RVA: 0x0009BE34 File Offset: 0x0009A034
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySummonBeginSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySummonBeginSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E34 RID: 7732 RVA: 0x0009BEEC File Offset: 0x0009A0EC
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

	// Token: 0x06001E35 RID: 7733 RVA: 0x0009C0E0 File Offset: 0x0009A2E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySummonBeginSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySummonBeginSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E36 RID: 7734 RVA: 0x0009C170 File Offset: 0x0009A370
	protected override string GetNotifyName_Implementation()
	{
		return "召唤伴生物释放技能";
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x0009C177 File Offset: 0x0009A377
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySummonBeginSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonBeginSkill.TsAnimNotifySummonBeginSkill_C");
		}
		return TsAnimNotifySummonBeginSkill._ClassPtr;
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x0009C19C File Offset: 0x0009A39C
	public TsAnimNotifySummonBeginSkill() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonBeginSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x0009C1C4 File Offset: 0x0009A3C4
	public TsAnimNotifySummonBeginSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonBeginSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x0009C1F7 File Offset: 0x0009A3F7
	protected TsAnimNotifySummonBeginSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x0009C200 File Offset: 0x0009A400
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x0009C233 File Offset: 0x0009A433
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400129B RID: 4763
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonBeginSkill.TsAnimNotifySummonBeginSkill_C";

	// Token: 0x0400129C RID: 4764
	private static IntPtr _ClassPtr;

	// Token: 0x0400129D RID: 4765
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400129E RID: 4766
	private static int __PropertyOffset_SummonIndex;

	// Token: 0x0400129F RID: 4767
	private static int __PropertyOffset_ActionSetLocation;

	// Token: 0x040012A0 RID: 4768
	[Nullable(2)]
	private SSkillBehaviorAction _ActionSetLocation;

	// Token: 0x040012A1 RID: 4769
	private static int __PropertyOffset_ActionSetRotation;

	// Token: 0x040012A2 RID: 4770
	[Nullable(2)]
	private SSkillBehaviorAction _ActionSetRotation;

	// Token: 0x040012A3 RID: 4771
	private static int __PropertyOffset_SkillId;

	// Token: 0x040012A4 RID: 4772
	private static int __PropertyOffset_EnableEntity;
}

using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000197 RID: 407
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBase.TsAnimNotifyBase_C")]
public class TsAnimNotifyBase : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0008DFAC File Offset: 0x0008C1AC
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSkillBehaviorCondition> AN执行的前提条件
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<SSkillBehaviorCondition> result;
			if ((result = this._AN执行的前提条件) == null)
			{
				result = (this._AN执行的前提条件 = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)TsAnimNotifyBase.__PropertyOffset_AN执行的前提条件, this));
			}
			return result;
		}
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x0008DFE8 File Offset: 0x0008C1E8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyConditionCheck(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyConditionCheck"), TsAnimNotifyBase.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyConditionCheck_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
	[NullableContext(2)]
	protected override bool K2_NotifyConditionCheck_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.AN执行的前提条件 == null || this.AN执行的前提条件.Num() == 0)
		{
			return true;
		}
		TsBaseCharacter tsBaseCharacter = ((meshComp != null) ? meshComp.GetOwner() : null) as TsBaseCharacter;
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
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		Skill skill = (component != null) ? component.CurrentSkill : null;
		BeginSkillBehaviorConditionParam param = new BeginSkillBehaviorConditionParam
		{
			Entity = entity,
			SkillComponent = component,
			Skill = skill
		};
		return SkillBehaviorCondition.SatisfyGroup(this.AN执行的前提条件, string.Empty, param);
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x0008E135 File Offset: 0x0008C335
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBase.TsAnimNotifyBase_C");
		}
		return TsAnimNotifyBase._ClassPtr;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x0008E15C File Offset: 0x0008C35C
	public TsAnimNotifyBase() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x0008E184 File Offset: 0x0008C384
	[NullableContext(1)]
	public TsAnimNotifyBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x0008E1B7 File Offset: 0x0008C3B7
	protected TsAnimNotifyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x0008E1C0 File Offset: 0x0008C3C0
	protected unsafe virtual void __CPPCALL_K2_NotifyConditionCheck_Implementation(UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyConditionCheck_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04001120 RID: 4384
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBase.TsAnimNotifyBase_C";

	// Token: 0x04001121 RID: 4385
	private static IntPtr _ClassPtr;

	// Token: 0x04001122 RID: 4386
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001123 RID: 4387
	private static int __PropertyOffset_AN执行的前提条件;

	// Token: 0x04001124 RID: 4388
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehaviorCondition> _AN执行的前提条件;
}

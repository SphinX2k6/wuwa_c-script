using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000193 RID: 403
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBase.TsAnimNotifyBase_C")]
public class TsAnimNotifyBase : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00087B8C File Offset: 0x00085D8C
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

	// Token: 0x060019B8 RID: 6584 RVA: 0x00087BC8 File Offset: 0x00085DC8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyConditionCheck(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyConditionCheck"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams) & -16L);
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

	// Token: 0x060019B9 RID: 6585 RVA: 0x00087C68 File Offset: 0x00085E68
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

	// Token: 0x060019BA RID: 6586 RVA: 0x00087CFD File Offset: 0x00085EFD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBase.TsAnimNotifyBase_C");
		}
		return TsAnimNotifyBase._ClassPtr;
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x00087D24 File Offset: 0x00085F24
	public TsAnimNotifyBase() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x00087D4C File Offset: 0x00085F4C
	[NullableContext(1)]
	public TsAnimNotifyBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x00087D7F File Offset: 0x00085F7F
	protected TsAnimNotifyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x00087D88 File Offset: 0x00085F88
	protected unsafe virtual void __CPPCALL_K2_NotifyConditionCheck_Implementation(UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyConditionCheck_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040010DD RID: 4317
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBase.TsAnimNotifyBase_C";

	// Token: 0x040010DE RID: 4318
	private static IntPtr _ClassPtr;

	// Token: 0x040010DF RID: 4319
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010E0 RID: 4320
	private static int __PropertyOffset_AN执行的前提条件;

	// Token: 0x040010E1 RID: 4321
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehaviorCondition> _AN执行的前提条件;
}

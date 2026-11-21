using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BA RID: 442
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEndSkill.TsAnimNotifyEndSkill_C")]
public class TsAnimNotifyEndSkill : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001C2C RID: 7212 RVA: 0x00094538 File Offset: 0x00092738
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyEndSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyEndSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C2D RID: 7213 RVA: 0x000945F0 File Offset: 0x000927F0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
			CharacterBuffComponent component3 = entity.GetComponent<CharacterBuffComponent>();
			if (component == null || !component.Valid || (component2 == null || !component2.Valid) || (component3 == null || !component3.Valid) || component2.IsSkillMontageInvalid(animation.GetName()))
			{
				return false;
			}
			string pathName = UKismetSystemLibrary.GetPathName(animation);
			if (component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.极限闪避"]) && (pathName.Contains("Move_F") || pathName.Contains("Move_B")))
			{
				return false;
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity2 = entity;
			string message = "结束技能帧事件";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "技能ID";
			Skill currentSkill = component2.CurrentSkill;
			ptr = new ValueTuple<string, object>(item, (currentSkill != null) ? new int?(currentSkill.SkillId) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "技能名称";
			Skill currentSkill2 = component2.CurrentSkill;
			ptr2 = new ValueTuple<string, object>(item2, (currentSkill2 != null) ? currentSkill2.SkillName : null);
			instance.Info(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			component2.IsMainSkillReadyEnd = true;
			if (component3.HasBuffAuthority())
			{
				component3.RemoveBuff(1101006002L, -1, "从TsAnimNotifyEndSkill蓝图移除Buff", null, null, null);
			}
			component2.SetCurrentPriority(0);
			component2.CallAnimBreakPoint();
		}
		return true;
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000947AC File Offset: 0x000929AC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyEndSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyEndSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C2F RID: 7215 RVA: 0x0009483C File Offset: 0x00092A3C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "结束技能";
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x00094843 File Offset: 0x00092A43
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyEndSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEndSkill.TsAnimNotifyEndSkill_C");
		}
		return TsAnimNotifyEndSkill._ClassPtr;
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x00094868 File Offset: 0x00092A68
	public TsAnimNotifyEndSkill() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEndSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x00094890 File Offset: 0x00092A90
	[NullableContext(1)]
	public TsAnimNotifyEndSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyEndSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x000948C3 File Offset: 0x00092AC3
	protected TsAnimNotifyEndSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x000948CC File Offset: 0x00092ACC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x000948FF File Offset: 0x00092AFF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011D8 RID: 4568
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyEndSkill.TsAnimNotifyEndSkill_C";

	// Token: 0x040011D9 RID: 4569
	private static IntPtr _ClassPtr;

	// Token: 0x040011DA RID: 4570
	private static IntPtr _ClassDefaultObjectPtr;
}

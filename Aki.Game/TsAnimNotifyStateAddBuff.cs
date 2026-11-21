using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.CombatMessage;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000103 RID: 259
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddBuff.TsAnimNotifyStateAddBuff_C")]
public class TsAnimNotifyStateAddBuff : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00058B6F File Offset: 0x00056D6F
	// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00058B7F File Offset: 0x00056D7F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long BuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddBuff.__PropertyOffset_BuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddBuff.__PropertyOffset_BuffId) = value;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00058B90 File Offset: 0x00056D90
	// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00058BA0 File Offset: 0x00056DA0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ESkillBehaviorBuffTargetType 施加目标
	{
		get
		{
			return (ESkillBehaviorBuffTargetType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddBuff.__PropertyOffset_施加目标));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddBuff.__PropertyOffset_施加目标) = (byte)value;
		}
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00058BB4 File Offset: 0x00056DB4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddBuff) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAddBuff.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00058C74 File Offset: 0x00056E74
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
			CharacterBuffComponent buffTarget = this.GetBuffTarget(entity);
			if (component == null || buffTarget == null)
			{
				return true;
			}
			if (!component.HasBuffAuthority() && !SkillMessageController.Instance.CloseMonsterServerLogic)
			{
				return true;
			}
			long? preMessageId = component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex);
			BaseBuffComponent baseBuffComponent = buffTarget;
			long buffId = this.BuffId;
			AddBuffParam addBuffParam = new AddBuffParam();
			addBuffParam.InstigatorId = component.CreatureDataId;
			addBuffParam.PreMessageId = preMessageId;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("动画");
			defaultInterpolatedStringHandler.AppendFormatted<UAnimSequenceBase>(animation);
			defaultInterpolatedStringHandler.AppendLiteral("的ANS添加");
			addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
			baseBuffComponent.AddBuff(buffId, addBuffParam);
		}
		return true;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00058D44 File Offset: 0x00056F44
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddBuff) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAddBuff.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F28 RID: 3880 RVA: 0x00058DFC File Offset: 0x00056FFC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
			CharacterBuffComponent buffTarget = this.GetBuffTarget(entity);
			if (characterBuffComponent == null || buffTarget == null)
			{
				return true;
			}
			if (!characterBuffComponent.HasBuffAuthority() && !SkillMessageController.Instance.CloseMonsterServerLogic)
			{
				return true;
			}
			if (buffTarget.Valid)
			{
				buffTarget.RemoveBuff(this.BuffId, -1, "动画" + ((animation != null) ? animation.GetName() : null) + "的ANS移除", null, null, null);
			}
		}
		return true;
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00058EB0 File Offset: 0x000570B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddBuff) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAddBuff.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000F2A RID: 3882 RVA: 0x00058F40 File Offset: 0x00057140
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加BUFF";
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00058F48 File Offset: 0x00057148
	[NullableContext(2)]
	private CharacterBuffComponent GetBuffTarget(Entity entity)
	{
		if (this.施加目标 == ESkillBehaviorBuffTargetType.技能目标)
		{
			object obj;
			if (entity == null)
			{
				obj = null;
			}
			else
			{
				CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
				if (component == null)
				{
					obj = null;
				}
				else
				{
					EntityHandle skillTarget = component.SkillTarget;
					obj = ((skillTarget != null) ? skillTarget.Entity : null);
				}
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return null;
			}
			return obj2.GetComponent<CharacterBuffComponent>();
		}
		else
		{
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<CharacterBuffComponent>();
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00058F99 File Offset: 0x00057199
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddBuff.TsAnimNotifyStateAddBuff_C");
		}
		return TsAnimNotifyStateAddBuff._ClassPtr;
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00058FC0 File Offset: 0x000571C0
	public TsAnimNotifyStateAddBuff() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00058FE8 File Offset: 0x000571E8
	[NullableContext(1)]
	public TsAnimNotifyStateAddBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0005901B File Offset: 0x0005721B
	protected TsAnimNotifyStateAddBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00059024 File Offset: 0x00057224
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00059060 File Offset: 0x00057260
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00059093 File Offset: 0x00057293
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C03 RID: 3075
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddBuff.TsAnimNotifyStateAddBuff_C";

	// Token: 0x04000C04 RID: 3076
	private static IntPtr _ClassPtr;

	// Token: 0x04000C05 RID: 3077
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C06 RID: 3078
	private static int __PropertyOffset_BuffId;

	// Token: 0x04000C07 RID: 3079
	private static int __PropertyOffset_施加目标;
}

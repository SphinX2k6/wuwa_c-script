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
	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00057C2B File Offset: 0x00055E2B
	// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00057C3B File Offset: 0x00055E3B
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

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00057C4C File Offset: 0x00055E4C
	// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00057C5C File Offset: 0x00055E5C
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

	// Token: 0x06000F1F RID: 3871 RVA: 0x00057C70 File Offset: 0x00055E70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00057D18 File Offset: 0x00055F18
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

	// Token: 0x06000F21 RID: 3873 RVA: 0x00057DE8 File Offset: 0x00055FE8
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

	// Token: 0x06000F22 RID: 3874 RVA: 0x00057E88 File Offset: 0x00056088
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

	// Token: 0x06000F23 RID: 3875 RVA: 0x00057F3C File Offset: 0x0005613C
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

	// Token: 0x06000F24 RID: 3876 RVA: 0x00057FB7 File Offset: 0x000561B7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加BUFF";
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00057FC0 File Offset: 0x000561C0
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

	// Token: 0x06000F26 RID: 3878 RVA: 0x00058011 File Offset: 0x00056211
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddBuff.TsAnimNotifyStateAddBuff_C");
		}
		return TsAnimNotifyStateAddBuff._ClassPtr;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00058038 File Offset: 0x00056238
	public TsAnimNotifyStateAddBuff() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00058060 File Offset: 0x00056260
	[NullableContext(1)]
	public TsAnimNotifyStateAddBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00058093 File Offset: 0x00056293
	protected TsAnimNotifyStateAddBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0005809C File Offset: 0x0005629C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x000580D8 File Offset: 0x000562D8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0005810B File Offset: 0x0005630B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000BFB RID: 3067
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddBuff.TsAnimNotifyStateAddBuff_C";

	// Token: 0x04000BFC RID: 3068
	private static IntPtr _ClassPtr;

	// Token: 0x04000BFD RID: 3069
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000BFE RID: 3070
	private static int __PropertyOffset_BuffId;

	// Token: 0x04000BFF RID: 3071
	private static int __PropertyOffset_施加目标;
}

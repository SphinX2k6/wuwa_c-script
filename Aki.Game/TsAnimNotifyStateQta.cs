using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000153 RID: 339
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateQta.TsAnimNotifyStateQta_C")]
public class TsAnimNotifyStateQta : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700036D RID: 877
	// (get) Token: 0x0600150E RID: 5390 RVA: 0x000748A5 File Offset: 0x00072AA5
	// (set) Token: 0x0600150F RID: 5391 RVA: 0x000748B5 File Offset: 0x00072AB5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QtaId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_QtaId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_QtaId) = value;
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06001510 RID: 5392 RVA: 0x000748C6 File Offset: 0x00072AC6
	// (set) Token: 0x06001511 RID: 5393 RVA: 0x000748D6 File Offset: 0x00072AD6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 当前实体为玩家控制时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_当前实体为玩家控制时才触发) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_当前实体为玩家控制时才触发) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06001512 RID: 5394 RVA: 0x000748E7 File Offset: 0x00072AE7
	// (set) Token: 0x06001513 RID: 5395 RVA: 0x000748FB File Offset: 0x00072AFB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 存在Tag时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_存在Tag时才触发);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_存在Tag时才触发) = value;
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06001514 RID: 5396 RVA: 0x00074910 File Offset: 0x00072B10
	// (set) Token: 0x06001515 RID: 5397 RVA: 0x00074920 File Offset: 0x00072B20
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 开始时直接结束其它Qta
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_开始时直接结束其它Qta) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_开始时直接结束其它Qta) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06001516 RID: 5398 RVA: 0x00074931 File Offset: 0x00072B31
	// (set) Token: 0x06001517 RID: 5399 RVA: 0x00074941 File Offset: 0x00072B41
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ANS结束时再结算Qta
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_ANS结束时再结算Qta) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_ANS结束时再结算Qta) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06001518 RID: 5400 RVA: 0x00074952 File Offset: 0x00072B52
	// (set) Token: 0x06001519 RID: 5401 RVA: 0x00074962 File Offset: 0x00072B62
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ANS结束时尝试结算
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_ANS结束时尝试结算) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_ANS结束时尝试结算) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x0600151A RID: 5402 RVA: 0x00074973 File Offset: 0x00072B73
	// (set) Token: 0x0600151B RID: 5403 RVA: 0x00074983 File Offset: 0x00072B83
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 技能被打断时不结算
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_技能被打断时不结算) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_技能被打断时不结算) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x0600151C RID: 5404 RVA: 0x00074994 File Offset: 0x00072B94
	// (set) Token: 0x0600151D RID: 5405 RVA: 0x000749A4 File Offset: 0x00072BA4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ANS结束时停止Qta
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_ANS结束时停止Qta) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateQta.__PropertyOffset_ANS结束时停止Qta) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x000749B8 File Offset: 0x00072BB8
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

	// Token: 0x0600151F RID: 5407 RVA: 0x00074A60 File Offset: 0x00072C60
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (this.当前实体为玩家控制时才触发 && (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(this.存在Tag时才触发.TagName.ToString()) && this.存在Tag时才触发.TagName != "None")
		{
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null || !baseTagComponent.HasTag(this.存在Tag时才触发.TagId()))
			{
				return false;
			}
		}
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		if ((baseSkillComponent != null && !baseSkillComponent.Valid) || (baseSkillComponent != null && baseSkillComponent.IsSkillMontageInvalid(animation.GetName())))
		{
			return false;
		}
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long? num = (baseBuffComponent != null) ? baseBuffComponent.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		if (handleByEntity != null && num != null)
		{
			if (this.开始时直接结束其它Qta)
			{
				QtaController.Instance.StopCurrentQta();
			}
			QtaContextBase qtaContextBase = QtaController.Instance.StartQta(this.QtaId, null, EQtaSource.AnimNotifyState, new IQtaExtraParams
			{
				MessageId = new long?(num.Value),
				EntityHandle = handleByEntity,
				IsPendingExternalCompletion = new bool?(this.ANS结束时再结算Qta)
			});
			int qtaHandleId = (qtaContextBase != null) ? qtaContextBase.HandleId : 0;
			string key = TsAnimNotifyStateQtaParam.GetKey(handleByEntity.Id, base.exportIndex);
			TsAnimNotifyStateQta.ParamCachedMap.Add(key, new TsAnimNotifyStateQtaParam(qtaHandleId));
		}
		return true;
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x00074C20 File Offset: 0x00072E20
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

	// Token: 0x06001521 RID: 5409 RVA: 0x00074CC0 File Offset: 0x00072EC0
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return true;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		string key = TsAnimNotifyStateQtaParam.GetKey(entity.Id, base.exportIndex);
		TsAnimNotifyStateQtaParam tsAnimNotifyStateQtaParam;
		if (!TsAnimNotifyStateQta.ParamCachedMap.TryGetValue(key, out tsAnimNotifyStateQtaParam))
		{
			return false;
		}
		TsAnimNotifyStateQta.ParamCachedMap.Remove(key);
		int num = (tsAnimNotifyStateQtaParam != null) ? tsAnimNotifyStateQtaParam.QtaHandleId : 0;
		if (num > 0)
		{
			BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
			bool flag = baseSkillComponent != null && baseSkillComponent.IsSkillMontageInvalid(animation.GetName());
			if (QtaController.Instance.GetCurrentQtaHandleId() != num)
			{
				return false;
			}
			if (this.技能被打断时不结算 && flag)
			{
				QtaController.Instance.StopQta(num, true);
				return true;
			}
			if (this.ANS结束时再结算Qta)
			{
				QtaController.Instance.OnExternalConditionMet(num, EQtaExternalReason.AnsEnd);
				if (!this.技能被打断时不结算 || !flag)
				{
					QtaController.Instance.ResolveQta(num);
					return true;
				}
			}
			else if (this.ANS结束时尝试结算 && (!this.技能被打断时不结算 || !flag))
			{
				QtaController.Instance.ResolveQta(num);
				return true;
			}
			if (this.ANS结束时停止Qta)
			{
				QtaController.Instance.StopQta(num, false);
			}
		}
		return true;
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x00074DE8 File Offset: 0x00072FE8
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

	// Token: 0x06001523 RID: 5411 RVA: 0x00074E63 File Offset: 0x00073063
	protected override string GetNotifyName_Implementation()
	{
		return "特殊交互QTA";
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x00074E6A File Offset: 0x0007306A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateQta._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateQta.TsAnimNotifyStateQta_C");
		}
		return TsAnimNotifyStateQta._ClassPtr;
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x00074E90 File Offset: 0x00073090
	public TsAnimNotifyStateQta() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateQta.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x00074EB8 File Offset: 0x000730B8
	public TsAnimNotifyStateQta(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateQta.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00074EEB File Offset: 0x000730EB
	protected TsAnimNotifyStateQta(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00074EF4 File Offset: 0x000730F4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00074F30 File Offset: 0x00073130
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00074F63 File Offset: 0x00073163
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EF8 RID: 3832
	[StaticVariableRuleIgnore]
	private static Dictionary<string, TsAnimNotifyStateQtaParam> ParamCachedMap = new Dictionary<string, TsAnimNotifyStateQtaParam>();

	// Token: 0x04000EF9 RID: 3833
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateQta.TsAnimNotifyStateQta_C";

	// Token: 0x04000EFA RID: 3834
	private static IntPtr _ClassPtr;

	// Token: 0x04000EFB RID: 3835
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EFC RID: 3836
	private static int __PropertyOffset_QtaId;

	// Token: 0x04000EFD RID: 3837
	private static int __PropertyOffset_当前实体为玩家控制时才触发;

	// Token: 0x04000EFE RID: 3838
	private static int __PropertyOffset_存在Tag时才触发;

	// Token: 0x04000EFF RID: 3839
	private static int __PropertyOffset_开始时直接结束其它Qta;

	// Token: 0x04000F00 RID: 3840
	private static int __PropertyOffset_ANS结束时再结算Qta;

	// Token: 0x04000F01 RID: 3841
	private static int __PropertyOffset_ANS结束时尝试结算;

	// Token: 0x04000F02 RID: 3842
	private static int __PropertyOffset_技能被打断时不结算;

	// Token: 0x04000F03 RID: 3843
	private static int __PropertyOffset_ANS结束时停止Qta;
}

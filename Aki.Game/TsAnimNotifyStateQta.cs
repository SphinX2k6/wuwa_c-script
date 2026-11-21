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

// Token: 0x02000157 RID: 343
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateQta.TsAnimNotifyStateQta_C")]
public class TsAnimNotifyStateQta : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700038F RID: 911
	// (get) Token: 0x060015AB RID: 5547 RVA: 0x00079DC1 File Offset: 0x00077FC1
	// (set) Token: 0x060015AC RID: 5548 RVA: 0x00079DD1 File Offset: 0x00077FD1
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

	// Token: 0x17000390 RID: 912
	// (get) Token: 0x060015AD RID: 5549 RVA: 0x00079DE2 File Offset: 0x00077FE2
	// (set) Token: 0x060015AE RID: 5550 RVA: 0x00079DF2 File Offset: 0x00077FF2
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

	// Token: 0x17000391 RID: 913
	// (get) Token: 0x060015AF RID: 5551 RVA: 0x00079E03 File Offset: 0x00078003
	// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00079E17 File Offset: 0x00078017
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

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00079E2C File Offset: 0x0007802C
	// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00079E3C File Offset: 0x0007803C
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

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00079E4D File Offset: 0x0007804D
	// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00079E5D File Offset: 0x0007805D
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

	// Token: 0x17000394 RID: 916
	// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00079E6E File Offset: 0x0007806E
	// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00079E7E File Offset: 0x0007807E
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

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x060015B7 RID: 5559 RVA: 0x00079E8F File Offset: 0x0007808F
	// (set) Token: 0x060015B8 RID: 5560 RVA: 0x00079E9F File Offset: 0x0007809F
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

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x060015B9 RID: 5561 RVA: 0x00079EB0 File Offset: 0x000780B0
	// (set) Token: 0x060015BA RID: 5562 RVA: 0x00079EC0 File Offset: 0x000780C0
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

	// Token: 0x060015BB RID: 5563 RVA: 0x00079ED4 File Offset: 0x000780D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateQta) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateQta.StaticClass(), out intPtr, out num))
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

	// Token: 0x060015BC RID: 5564 RVA: 0x00079F94 File Offset: 0x00078194
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

	// Token: 0x060015BD RID: 5565 RVA: 0x0007A154 File Offset: 0x00078354
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateQta) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateQta.StaticClass(), out intPtr, out num))
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

	// Token: 0x060015BE RID: 5566 RVA: 0x0007A20C File Offset: 0x0007840C
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

	// Token: 0x060015BF RID: 5567 RVA: 0x0007A334 File Offset: 0x00078534
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateQta) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateQta.StaticClass(), out intPtr, out num))
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

	// Token: 0x060015C0 RID: 5568 RVA: 0x0007A3C4 File Offset: 0x000785C4
	protected override string GetNotifyName_Implementation()
	{
		return "特殊交互QTA";
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x0007A3CB File Offset: 0x000785CB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateQta._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateQta.TsAnimNotifyStateQta_C");
		}
		return TsAnimNotifyStateQta._ClassPtr;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x0007A3F0 File Offset: 0x000785F0
	public TsAnimNotifyStateQta() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateQta.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x0007A418 File Offset: 0x00078618
	public TsAnimNotifyStateQta(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateQta.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x0007A44B File Offset: 0x0007864B
	protected TsAnimNotifyStateQta(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x0007A454 File Offset: 0x00078654
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x0007A490 File Offset: 0x00078690
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x0007A4C3 File Offset: 0x000786C3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F3B RID: 3899
	[StaticVariableRuleIgnore]
	private static Dictionary<string, TsAnimNotifyStateQtaParam> ParamCachedMap = new Dictionary<string, TsAnimNotifyStateQtaParam>();

	// Token: 0x04000F3C RID: 3900
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateQta.TsAnimNotifyStateQta_C";

	// Token: 0x04000F3D RID: 3901
	private static IntPtr _ClassPtr;

	// Token: 0x04000F3E RID: 3902
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F3F RID: 3903
	private static int __PropertyOffset_QtaId;

	// Token: 0x04000F40 RID: 3904
	private static int __PropertyOffset_当前实体为玩家控制时才触发;

	// Token: 0x04000F41 RID: 3905
	private static int __PropertyOffset_存在Tag时才触发;

	// Token: 0x04000F42 RID: 3906
	private static int __PropertyOffset_开始时直接结束其它Qta;

	// Token: 0x04000F43 RID: 3907
	private static int __PropertyOffset_ANS结束时再结算Qta;

	// Token: 0x04000F44 RID: 3908
	private static int __PropertyOffset_ANS结束时尝试结算;

	// Token: 0x04000F45 RID: 3909
	private static int __PropertyOffset_技能被打断时不结算;

	// Token: 0x04000F46 RID: 3910
	private static int __PropertyOffset_ANS结束时停止Qta;
}

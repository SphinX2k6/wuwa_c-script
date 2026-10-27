using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000CD RID: 205
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskUseSkill.TsTaskUseSkill_C")]
public class TsTaskUseSkill : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000C29 RID: 3113 RVA: 0x0003E22C File Offset: 0x0003C42C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0003E2C5 File Offset: 0x0003C4C5
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.WaitingSkill = false;
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0003E2D0 File Offset: 0x0003C4D0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0003E370 File Offset: 0x0003C570
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsTaskUseSkill.<>c__DisplayClass4_0 CS$<>8__locals1 = new TsTaskUseSkill.<>c__DisplayClass4_0();
		CS$<>8__locals1.<>4__this = this;
		TsTaskUseSkill.<>c__DisplayClass4_0 CS$<>8__locals2 = CS$<>8__locals1;
		TsAiController tsAiController = ownerController as TsAiController;
		CS$<>8__locals2.aiController = ((tsAiController != null) ? tsAiController.AiController : null);
		if (CS$<>8__locals1.aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CS$<>8__locals1.entityId = CS$<>8__locals1.aiController.CharAiDesignComp.Entity.Id;
		CharacterSkillComponent component = CS$<>8__locals1.aiController.CharAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		if (!component.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		string text = BlackboardController.Instance.GetStringValueByEntity(CS$<>8__locals1.entityId, "SkillId");
		if (string.IsNullOrEmpty(text))
		{
			text = "0";
		}
		if (this.WaitingSkill)
		{
			return;
		}
		this.WaitingSkill = true;
		BaseSkillComponent baseSkillComponent = component;
		int skillId = int.Parse(text);
		SkillParam skillParam = new SkillParam();
		EntityHandle currentTarget = CS$<>8__locals1.aiController.AiHateList.GetCurrentTarget();
		skillParam.Target = ((currentTarget != null) ? currentTarget.Entity : null);
		skillParam.Reason = "TsTaskUseSkill.ReceiveTickAI";
		baseSkillComponent.BeginSkillAsync(skillId, skillParam).ContinueWith(delegate(bool result)
		{
			CS$<>8__locals1.<>4__this.FinishExecute(result);
			if (result && CS$<>8__locals1.aiController.AiSkill != null)
			{
				CS$<>8__locals1.aiController.AiSkill.SetSkillCdFromNow(BlackboardController.Instance.GetIntValueByEntity(CS$<>8__locals1.entityId, "SkillInfoId"));
			}
			BlackboardController.Instance.RemoveValueByEntity(CS$<>8__locals1.entityId, "SkillId");
			BlackboardController.Instance.RemoveValueByEntity(CS$<>8__locals1.entityId, "SkillInfoId");
		});
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0003E4AB File Offset: 0x0003C6AB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskUseSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskUseSkill.TsTaskUseSkill_C");
		}
		return TsTaskUseSkill._ClassPtr;
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
	public TsTaskUseSkill() : this(BuiltinUtils.AllocNativeUObject(TsTaskUseSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0003E4F8 File Offset: 0x0003C6F8
	[NullableContext(1)]
	public TsTaskUseSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskUseSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0003E52B File Offset: 0x0003C72B
	protected TsTaskUseSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0003E534 File Offset: 0x0003C734
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0003E564 File Offset: 0x0003C764
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040009BA RID: 2490
	private bool WaitingSkill;

	// Token: 0x040009BB RID: 2491
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskUseSkill.TsTaskUseSkill_C";

	// Token: 0x040009BC RID: 2492
	private static IntPtr _ClassPtr;

	// Token: 0x040009BD RID: 2493
	private static IntPtr _ClassDefaultObjectPtr;
}

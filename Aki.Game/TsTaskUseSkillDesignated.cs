using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000CE RID: 206
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskUseSkillDesignated.TsTaskUseSkillDesignated_C")]
public class TsTaskUseSkillDesignated : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003E597 File Offset: 0x0003C797
	// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0003E5AB File Offset: 0x0003C7AB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTarget
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskUseSkillDesignated.__PropertyOffset_BlackboardKeyTarget)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskUseSkillDesignated.__PropertyOffset_BlackboardKeyTarget)), value);
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
	// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0003E5D0 File Offset: 0x0003C7D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillInfoId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskUseSkillDesignated.__PropertyOffset_SkillInfoId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskUseSkillDesignated.__PropertyOffset_SkillInfoId) = value;
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0003E5E1 File Offset: 0x0003C7E1
	// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0003E5F1 File Offset: 0x0003C7F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugLog
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskUseSkillDesignated.__PropertyOffset_DebugLog) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskUseSkillDesignated.__PropertyOffset_DebugLog) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x0003E602 File Offset: 0x0003C802
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyTarget = this.BlackboardKeyTarget;
			this.TsSkillInfoId = this.SkillInfoId;
			this.TsDebugLog = this.DebugLog;
		}
	}

	// Token: 0x06000C3A RID: 3130 RVA: 0x0003E640 File Offset: 0x0003C840
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

	// Token: 0x06000C3B RID: 3131 RVA: 0x0003E6D9 File Offset: 0x0003C8D9
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.WaitingSkill = false;
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x0003E6E4 File Offset: 0x0003C8E4
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

	// Token: 0x06000C3D RID: 3133 RVA: 0x0003E784 File Offset: 0x0003C984
	[NullableContext(2)]
	protected unsafe virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsTaskUseSkillDesignated.<>c__DisplayClass18_0 CS$<>8__locals1 = new TsTaskUseSkillDesignated.<>c__DisplayClass18_0();
		CS$<>8__locals1.<>4__this = this;
		TsTaskUseSkillDesignated.<>c__DisplayClass18_0 CS$<>8__locals2 = CS$<>8__locals1;
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
		if (CS$<>8__locals1.aiController.AiSkill == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "没有技能信息";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AiBaseId", CS$<>8__locals1.aiController.AiBase.Value.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		if (this.TsDebugLog)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "UseSkillDesignated";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("controller", (ownerController != null) ? ownerController.GetName() : null);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		}
		AiSkillInfos aiSkillInfos;
		if (!CS$<>8__locals1.aiController.AiSkill.SkillInfos.TryGetValue(this.TsSkillInfoId, out aiSkillInfos))
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.BehaviorTree;
			ELogAuthor author4 = ELogAuthor.LCZ;
			string message4 = "当前AI没有对应的技能ID";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AiBaseId", CS$<>8__locals1.aiController.AiBase.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillInfoId", this.TsSkillInfoId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			base.FinishExecute(false);
			return;
		}
		EntityHandle entityHandle = CS$<>8__locals1.aiController.AiHateList.GetCurrentTarget();
		if (this.TsBlackboardKeyTarget != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(CS$<>8__locals1.aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyTarget);
			if (entityIdByEntity != null)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityIdByEntity.Value);
				if (entityById != null)
				{
					entityHandle = entityById;
				}
			}
		}
		CharacterSkillComponent component = CS$<>8__locals1.aiController.CharAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		if (!component.Valid)
		{
			if (this.TsDebugLog)
			{
				Log.Instance.Info(ELogModule.BehaviorTree, ELogAuthor.LCZ, "UseSkillDesignated No SkillComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			base.FinishExecute(false);
			return;
		}
		if (this.TsDebugLog)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.BehaviorTree;
			ELogAuthor author5 = ELogAuthor.LCZ;
			string message5 = "UseSkillDesignated TrySkill";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("skill", aiSkillInfos.SkillId);
			instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		}
		if (this.WaitingSkill)
		{
			return;
		}
		this.WaitingSkill = true;
		component.BeginSkillAsync(int.Parse(aiSkillInfos.SkillId), new SkillParam
		{
			Target = ((entityHandle != null) ? entityHandle.Entity : null),
			Reason = "TsTaskUseSkillDesignated.ReceiveTickAI"
		}).ContinueWith(delegate(bool result)
		{
			CS$<>8__locals1.<>4__this.FinishExecute(result);
			if (result && CS$<>8__locals1.aiController.AiSkill != null)
			{
				CS$<>8__locals1.aiController.AiSkill.SetSkillCdFromNow(new int?(CS$<>8__locals1.<>4__this.TsSkillInfoId));
			}
		});
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x0003EA92 File Offset: 0x0003CC92
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskUseSkillDesignated._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskUseSkillDesignated.TsTaskUseSkillDesignated_C");
		}
		return TsTaskUseSkillDesignated._ClassPtr;
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x0003EAB8 File Offset: 0x0003CCB8
	public TsTaskUseSkillDesignated() : this(BuiltinUtils.AllocNativeUObject(TsTaskUseSkillDesignated.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x0003EAE0 File Offset: 0x0003CCE0
	public TsTaskUseSkillDesignated(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskUseSkillDesignated.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x0003EB13 File Offset: 0x0003CD13
	protected TsTaskUseSkillDesignated(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x0003EB28 File Offset: 0x0003CD28
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0003EB58 File Offset: 0x0003CD58
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040009BE RID: 2494
	private bool IsInitTsVariables;

	// Token: 0x040009BF RID: 2495
	private string TsBlackboardKeyTarget = "";

	// Token: 0x040009C0 RID: 2496
	private int TsSkillInfoId;

	// Token: 0x040009C1 RID: 2497
	private bool TsDebugLog;

	// Token: 0x040009C2 RID: 2498
	private bool WaitingSkill;

	// Token: 0x040009C3 RID: 2499
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskUseSkillDesignated.TsTaskUseSkillDesignated_C";

	// Token: 0x040009C4 RID: 2500
	private static IntPtr _ClassPtr;

	// Token: 0x040009C5 RID: 2501
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040009C6 RID: 2502
	private static int __PropertyOffset_BlackboardKeyTarget;

	// Token: 0x040009C7 RID: 2503
	private static int __PropertyOffset_SkillInfoId;

	// Token: 0x040009C8 RID: 2504
	private static int __PropertyOffset_DebugLog;
}

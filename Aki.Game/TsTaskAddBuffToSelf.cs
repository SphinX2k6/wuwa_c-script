using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000081 RID: 129
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddBuffToSelf.TsTaskAddBuffToSelf_C")]
public class TsTaskAddBuffToSelf : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x0600063C RID: 1596 RVA: 0x00020039 File Offset: 0x0001E239
	// (set) Token: 0x0600063D RID: 1597 RVA: 0x00020049 File Offset: 0x0001E249
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long BuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddBuffToSelf.__PropertyOffset_BuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddBuffToSelf.__PropertyOffset_BuffId) = value;
		}
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0002005A File Offset: 0x0001E25A
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBuffId = new long?(this.BuffId);
		}
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00020084 File Offset: 0x0001E284
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAddBuffToSelf) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAddBuffToSelf.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00020134 File Offset: 0x0001E334
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		if (this.TsBuffId != null)
		{
			long? tsBuffId = this.TsBuffId;
			long num = 0L;
			if (!(tsBuffId.GetValueOrDefault() == num & tsBuffId != null))
			{
				CharacterActorComponent charActorComp = aiController.CharActorComp;
				CharacterBuffComponent characterBuffComponent = (charActorComp != null) ? charActorComp.Entity.GetComponent<CharacterBuffComponent>() : null;
				if (characterBuffComponent == null || !characterBuffComponent.Valid)
				{
					base.FinishExecute(false);
					return;
				}
				characterBuffComponent.AddBuffFromAi(aiController.AiCombatMessageId, this.TsBuffId.Value, new AddBuffParam
				{
					InstigatorId = characterBuffComponent.CreatureDataId,
					Reason = "行为树TsTaskAddBuffToSelf节点"
				});
				base.FinishExecute(true);
				return;
			}
		}
		Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskAddBuffToSelf 未配置BuffId", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.FinishExecute(false);
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00020257 File Offset: 0x0001E457
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAddBuffToSelf._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddBuffToSelf.TsTaskAddBuffToSelf_C");
		}
		return TsTaskAddBuffToSelf._ClassPtr;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x0002027C File Offset: 0x0001E47C
	public TsTaskAddBuffToSelf() : this(BuiltinUtils.AllocNativeUObject(TsTaskAddBuffToSelf.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x000202A4 File Offset: 0x0001E4A4
	[NullableContext(1)]
	public TsTaskAddBuffToSelf(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddBuffToSelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x000202D7 File Offset: 0x0001E4D7
	protected TsTaskAddBuffToSelf(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x000202E0 File Offset: 0x0001E4E0
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400048B RID: 1163
	private bool IsInitTsVariables;

	// Token: 0x0400048C RID: 1164
	private long? TsBuffId;

	// Token: 0x0400048D RID: 1165
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddBuffToSelf.TsTaskAddBuffToSelf_C";

	// Token: 0x0400048E RID: 1166
	private static IntPtr _ClassPtr;

	// Token: 0x0400048F RID: 1167
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000490 RID: 1168
	private static int __PropertyOffset_BuffId;
}

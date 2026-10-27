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
	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000638 RID: 1592 RVA: 0x0001F3E1 File Offset: 0x0001D5E1
	// (set) Token: 0x06000639 RID: 1593 RVA: 0x0001F3F1 File Offset: 0x0001D5F1
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

	// Token: 0x0600063A RID: 1594 RVA: 0x0001F402 File Offset: 0x0001D602
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBuffId = new long?(this.BuffId);
		}
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0001F42C File Offset: 0x0001D62C
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

	// Token: 0x0600063C RID: 1596 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
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

	// Token: 0x0600063D RID: 1597 RVA: 0x0001F5EB File Offset: 0x0001D7EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAddBuffToSelf._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddBuffToSelf.TsTaskAddBuffToSelf_C");
		}
		return TsTaskAddBuffToSelf._ClassPtr;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0001F610 File Offset: 0x0001D810
	public TsTaskAddBuffToSelf() : this(BuiltinUtils.AllocNativeUObject(TsTaskAddBuffToSelf.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x0001F638 File Offset: 0x0001D838
	[NullableContext(1)]
	public TsTaskAddBuffToSelf(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddBuffToSelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x0001F66B File Offset: 0x0001D86B
	protected TsTaskAddBuffToSelf(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0001F674 File Offset: 0x0001D874
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000487 RID: 1159
	private bool IsInitTsVariables;

	// Token: 0x04000488 RID: 1160
	private long? TsBuffId;

	// Token: 0x04000489 RID: 1161
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddBuffToSelf.TsTaskAddBuffToSelf_C";

	// Token: 0x0400048A RID: 1162
	private static IntPtr _ClassPtr;

	// Token: 0x0400048B RID: 1163
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400048C RID: 1164
	private static int __PropertyOffset_BuffId;
}

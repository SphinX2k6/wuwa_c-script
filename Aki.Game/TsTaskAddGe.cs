using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000082 RID: 130
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddGe.TsTaskAddGe_C")]
public class TsTaskAddGe : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001F6A1 File Offset: 0x0001D8A1
	// (set) Token: 0x06000643 RID: 1603 RVA: 0x0001F6B1 File Offset: 0x0001D8B1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long GeId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddGe.__PropertyOffset_GeId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddGe.__PropertyOffset_GeId) = value;
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001F6C2 File Offset: 0x0001D8C2
	// (set) Token: 0x06000645 RID: 1605 RVA: 0x0001F6D2 File Offset: 0x0001D8D2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Level
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAddGe.__PropertyOffset_Level);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAddGe.__PropertyOffset_Level) = value;
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x0001F6E3 File Offset: 0x0001D8E3
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsGeId = new long?(this.GeId);
		}
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x0001F70C File Offset: 0x0001D90C
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

	// Token: 0x06000648 RID: 1608 RVA: 0x0001F7AC File Offset: 0x0001D9AC
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CharacterBuffComponent characterBuffComponent = aiController.CharActorComp.Entity.CheckGetComponent<CharacterBuffComponent>();
		characterBuffComponent.AddBuffFromAi(aiController.AiCombatMessageId, this.TsGeId.Value, new AddBuffParam
		{
			InstigatorId = characterBuffComponent.CreatureDataId,
			Reason = "行为树TsTaskAddGe节点"
		});
		base.FinishExecute(true);
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x0001F854 File Offset: 0x0001DA54
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAddGe._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddGe.TsTaskAddGe_C");
		}
		return TsTaskAddGe._ClassPtr;
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x0001F878 File Offset: 0x0001DA78
	public TsTaskAddGe() : this(BuiltinUtils.AllocNativeUObject(TsTaskAddGe.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x0001F8A0 File Offset: 0x0001DAA0
	[NullableContext(1)]
	public TsTaskAddGe(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddGe.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0001F8D3 File Offset: 0x0001DAD3
	protected TsTaskAddGe(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x0001F8DC File Offset: 0x0001DADC
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400048D RID: 1165
	private bool IsInitTsVariables;

	// Token: 0x0400048E RID: 1166
	private long? TsGeId;

	// Token: 0x0400048F RID: 1167
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddGe.TsTaskAddGe_C";

	// Token: 0x04000490 RID: 1168
	private static IntPtr _ClassPtr;

	// Token: 0x04000491 RID: 1169
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000492 RID: 1170
	private static int __PropertyOffset_GeId;

	// Token: 0x04000493 RID: 1171
	private static int __PropertyOffset_Level;
}

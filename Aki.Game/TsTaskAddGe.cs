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
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000646 RID: 1606 RVA: 0x0002030D File Offset: 0x0001E50D
	// (set) Token: 0x06000647 RID: 1607 RVA: 0x0002031D File Offset: 0x0001E51D
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

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000648 RID: 1608 RVA: 0x0002032E File Offset: 0x0001E52E
	// (set) Token: 0x06000649 RID: 1609 RVA: 0x0002033E File Offset: 0x0001E53E
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

	// Token: 0x0600064A RID: 1610 RVA: 0x0002034F File Offset: 0x0001E54F
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsGeId = new long?(this.GeId);
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00020378 File Offset: 0x0001E578
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAddGe) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskAddGe.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00020430 File Offset: 0x0001E630
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

	// Token: 0x0600064D RID: 1613 RVA: 0x000204D8 File Offset: 0x0001E6D8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAddGe._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddGe.TsTaskAddGe_C");
		}
		return TsTaskAddGe._ClassPtr;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x000204FC File Offset: 0x0001E6FC
	public TsTaskAddGe() : this(BuiltinUtils.AllocNativeUObject(TsTaskAddGe.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00020524 File Offset: 0x0001E724
	[NullableContext(1)]
	public TsTaskAddGe(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAddGe.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00020557 File Offset: 0x0001E757
	protected TsTaskAddGe(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00020560 File Offset: 0x0001E760
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000491 RID: 1169
	private bool IsInitTsVariables;

	// Token: 0x04000492 RID: 1170
	private long? TsGeId;

	// Token: 0x04000493 RID: 1171
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAddGe.TsTaskAddGe_C";

	// Token: 0x04000494 RID: 1172
	private static IntPtr _ClassPtr;

	// Token: 0x04000495 RID: 1173
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000496 RID: 1174
	private static int __PropertyOffset_GeId;

	// Token: 0x04000497 RID: 1175
	private static int __PropertyOffset_Level;
}

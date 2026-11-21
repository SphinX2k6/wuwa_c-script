using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000088 RID: 136
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAnimalDropItem.TsTaskAnimalDropItem_C")]
public class TsTaskAnimalDropItem : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000113 RID: 275
	// (get) Token: 0x060006BC RID: 1724 RVA: 0x00022269 File Offset: 0x00020469
	// (set) Token: 0x060006BD RID: 1725 RVA: 0x00022279 File Offset: 0x00020479
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DoOnce
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalDropItem.__PropertyOffset_DoOnce) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalDropItem.__PropertyOffset_DoOnce) = (value ? 1 : 0);
		}
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0002228A File Offset: 0x0002048A
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDoOnce = this.DoOnce;
		}
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x000222B0 File Offset: 0x000204B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAnimalDropItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAnimalDropItem.StaticClass(), out intPtr, out num))
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

	// Token: 0x060006C0 RID: 1728 RVA: 0x00022360 File Offset: 0x00020560
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
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		Entity entity = aiController.CharActorComp.Entity;
		if (entity.GetComponent<CharacterAiComponent>() == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (this.TsDoOnce && this.HasDone)
		{
			base.FinishExecute(true);
			return;
		}
		long creatureDataId = entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		CreatureController.Instance.AnimalDropItemRequest(creatureDataId);
		this.HasDone = true;
		base.FinishExecute(true);
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x0002241E File Offset: 0x0002061E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAnimalDropItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAnimalDropItem.TsTaskAnimalDropItem_C");
		}
		return TsTaskAnimalDropItem._ClassPtr;
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00022444 File Offset: 0x00020644
	public TsTaskAnimalDropItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDropItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x0002246C File Offset: 0x0002066C
	[NullableContext(1)]
	public TsTaskAnimalDropItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDropItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x0002249F File Offset: 0x0002069F
	protected TsTaskAnimalDropItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x000224B0 File Offset: 0x000206B0
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004E6 RID: 1254
	private bool IsInitTsVariables;

	// Token: 0x040004E7 RID: 1255
	private bool TsDoOnce = true;

	// Token: 0x040004E8 RID: 1256
	private bool HasDone;

	// Token: 0x040004E9 RID: 1257
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAnimalDropItem.TsTaskAnimalDropItem_C";

	// Token: 0x040004EA RID: 1258
	private static IntPtr _ClassPtr;

	// Token: 0x040004EB RID: 1259
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004EC RID: 1260
	private static int __PropertyOffset_DoOnce;
}

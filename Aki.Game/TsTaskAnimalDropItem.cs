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
	// Token: 0x17000111 RID: 273
	// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000215B9 File Offset: 0x0001F7B9
	// (set) Token: 0x060006B9 RID: 1721 RVA: 0x000215C9 File Offset: 0x0001F7C9
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

	// Token: 0x060006BA RID: 1722 RVA: 0x000215DA File Offset: 0x0001F7DA
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDoOnce = this.DoOnce;
		}
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00021600 File Offset: 0x0001F800
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

	// Token: 0x060006BC RID: 1724 RVA: 0x0002169C File Offset: 0x0001F89C
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

	// Token: 0x060006BD RID: 1725 RVA: 0x0002175A File Offset: 0x0001F95A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAnimalDropItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAnimalDropItem.TsTaskAnimalDropItem_C");
		}
		return TsTaskAnimalDropItem._ClassPtr;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00021780 File Offset: 0x0001F980
	public TsTaskAnimalDropItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDropItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x000217A8 File Offset: 0x0001F9A8
	[NullableContext(1)]
	public TsTaskAnimalDropItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDropItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x000217DB File Offset: 0x0001F9DB
	protected TsTaskAnimalDropItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x000217EC File Offset: 0x0001F9EC
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004E2 RID: 1250
	private bool IsInitTsVariables;

	// Token: 0x040004E3 RID: 1251
	private bool TsDoOnce = true;

	// Token: 0x040004E4 RID: 1252
	private bool HasDone;

	// Token: 0x040004E5 RID: 1253
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAnimalDropItem.TsTaskAnimalDropItem_C";

	// Token: 0x040004E6 RID: 1254
	private static IntPtr _ClassPtr;

	// Token: 0x040004E7 RID: 1255
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004E8 RID: 1256
	private static int __PropertyOffset_DoOnce;
}

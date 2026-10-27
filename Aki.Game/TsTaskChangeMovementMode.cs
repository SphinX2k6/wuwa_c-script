using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000090 RID: 144
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMovementMode.TsTaskChangeMovementMode_C")]
public class TsTaskChangeMovementMode : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000122 RID: 290
	// (get) Token: 0x0600073F RID: 1855 RVA: 0x000246AD File Offset: 0x000228AD
	// (set) Token: 0x06000740 RID: 1856 RVA: 0x000246C1 File Offset: 0x000228C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EMovementMode> MovementMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeMovementMode.__PropertyOffset_MovementMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeMovementMode.__PropertyOffset_MovementMode) = value;
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x000246D8 File Offset: 0x000228D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00024748 File Offset: 0x00022948
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMovementMode = this.MovementMode;
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00024774 File Offset: 0x00022974
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

	// Token: 0x06000744 RID: 1860 RVA: 0x00024810 File Offset: 0x00022A10
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			base.FinishExecute(true);
			return;
		}
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(charActorComp.Actor, true);
		if (entityByActor == null)
		{
			base.FinishExecute(true);
			return;
		}
		if (entityByActor.Entity.GetComponent<BaseMoveComponent>() == null)
		{
			base.FinishExecute(true);
			return;
		}
		charActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = this.TsMovementMode,
			Context = "[TsTaskChangeMovementMode.ReceiveExecuteAI]"
		});
		base.FinishExecute(true);
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x000248E2 File Offset: 0x00022AE2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeMovementMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMovementMode.TsTaskChangeMovementMode_C");
		}
		return TsTaskChangeMovementMode._ClassPtr;
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00024908 File Offset: 0x00022B08
	public TsTaskChangeMovementMode() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMovementMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00024930 File Offset: 0x00022B30
	[NullableContext(1)]
	public TsTaskChangeMovementMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00024963 File Offset: 0x00022B63
	protected TsTaskChangeMovementMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x0002496C File Offset: 0x00022B6C
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00024974 File Offset: 0x00022B74
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000551 RID: 1361
	private bool IsInitTsVariables;

	// Token: 0x04000552 RID: 1362
	private EMovementMode TsMovementMode;

	// Token: 0x04000553 RID: 1363
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMovementMode.TsTaskChangeMovementMode_C";

	// Token: 0x04000554 RID: 1364
	private static IntPtr _ClassPtr;

	// Token: 0x04000555 RID: 1365
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000556 RID: 1366
	private static int __PropertyOffset_MovementMode;
}

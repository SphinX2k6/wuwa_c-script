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
	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000743 RID: 1859 RVA: 0x000253C5 File Offset: 0x000235C5
	// (set) Token: 0x06000744 RID: 1860 RVA: 0x000253D9 File Offset: 0x000235D9
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

	// Token: 0x06000745 RID: 1861 RVA: 0x000253F0 File Offset: 0x000235F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskChangeMovementMode.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00025449 File Offset: 0x00023649
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMovementMode = this.MovementMode;
		}
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00025474 File Offset: 0x00023674
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeMovementMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskChangeMovementMode.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000748 RID: 1864 RVA: 0x00025524 File Offset: 0x00023724
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

	// Token: 0x06000749 RID: 1865 RVA: 0x000255F6 File Offset: 0x000237F6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeMovementMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMovementMode.TsTaskChangeMovementMode_C");
		}
		return TsTaskChangeMovementMode._ClassPtr;
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x0002561C File Offset: 0x0002381C
	public TsTaskChangeMovementMode() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMovementMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00025644 File Offset: 0x00023844
	[NullableContext(1)]
	public TsTaskChangeMovementMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00025677 File Offset: 0x00023877
	protected TsTaskChangeMovementMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00025680 File Offset: 0x00023880
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00025688 File Offset: 0x00023888
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000555 RID: 1365
	private bool IsInitTsVariables;

	// Token: 0x04000556 RID: 1366
	private EMovementMode TsMovementMode;

	// Token: 0x04000557 RID: 1367
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMovementMode.TsTaskChangeMovementMode_C";

	// Token: 0x04000558 RID: 1368
	private static IntPtr _ClassPtr;

	// Token: 0x04000559 RID: 1369
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400055A RID: 1370
	private static int __PropertyOffset_MovementMode;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000091 RID: 145
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMoveSpeed.TsTaskChangeMoveSpeed_C")]
public class TsTaskChangeMoveSpeed : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000125 RID: 293
	// (get) Token: 0x0600074F RID: 1871 RVA: 0x000256B5 File Offset: 0x000238B5
	// (set) Token: 0x06000750 RID: 1872 RVA: 0x000256C5 File Offset: 0x000238C5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MoveSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeMoveSpeed.__PropertyOffset_MoveSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeMoveSpeed.__PropertyOffset_MoveSpeed) = value;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000751 RID: 1873 RVA: 0x000256D6 File Offset: 0x000238D6
	// (set) Token: 0x06000752 RID: 1874 RVA: 0x000256E6 File Offset: 0x000238E6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ResetDefault
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeMoveSpeed.__PropertyOffset_ResetDefault) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeMoveSpeed.__PropertyOffset_ResetDefault) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x000256F7 File Offset: 0x000238F7
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveSpeed = this.MoveSpeed;
			this.TsResetDefault = this.ResetDefault;
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00025728 File Offset: 0x00023928
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeMoveSpeed) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskChangeMoveSpeed.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000755 RID: 1877 RVA: 0x000257D8 File Offset: 0x000239D8
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
		BaseMoveComponent component = entityByActor.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			base.FinishExecute(true);
			return;
		}
		if (this.TsResetDefault)
		{
			ECharMoveState moveState = entityByActor.Entity.GetComponent<CharacterUnifiedStateComponent>().MoveState;
			component.ResetMaxSpeed(new ECharMoveState?(moveState));
		}
		else
		{
			component.SetMaxSpeed(this.TsMoveSpeed);
			component.SetSpeedLock();
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x000258C0 File Offset: 0x00023AC0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeMoveSpeed._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMoveSpeed.TsTaskChangeMoveSpeed_C");
		}
		return TsTaskChangeMoveSpeed._ClassPtr;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x000258E4 File Offset: 0x00023AE4
	public TsTaskChangeMoveSpeed() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMoveSpeed.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0002590C File Offset: 0x00023B0C
	[NullableContext(1)]
	public TsTaskChangeMoveSpeed(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMoveSpeed.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x0002593F File Offset: 0x00023B3F
	protected TsTaskChangeMoveSpeed(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00025948 File Offset: 0x00023B48
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400055B RID: 1371
	private bool IsInitTsVariables;

	// Token: 0x0400055C RID: 1372
	private float TsMoveSpeed;

	// Token: 0x0400055D RID: 1373
	private bool TsResetDefault;

	// Token: 0x0400055E RID: 1374
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMoveSpeed.TsTaskChangeMoveSpeed_C";

	// Token: 0x0400055F RID: 1375
	private static IntPtr _ClassPtr;

	// Token: 0x04000560 RID: 1376
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000561 RID: 1377
	private static int __PropertyOffset_MoveSpeed;

	// Token: 0x04000562 RID: 1378
	private static int __PropertyOffset_ResetDefault;
}

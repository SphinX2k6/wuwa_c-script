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
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600074B RID: 1867 RVA: 0x000249A1 File Offset: 0x00022BA1
	// (set) Token: 0x0600074C RID: 1868 RVA: 0x000249B1 File Offset: 0x00022BB1
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

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x0600074D RID: 1869 RVA: 0x000249C2 File Offset: 0x00022BC2
	// (set) Token: 0x0600074E RID: 1870 RVA: 0x000249D2 File Offset: 0x00022BD2
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

	// Token: 0x0600074F RID: 1871 RVA: 0x000249E3 File Offset: 0x00022BE3
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveSpeed = this.MoveSpeed;
			this.TsResetDefault = this.ResetDefault;
		}
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00024A14 File Offset: 0x00022C14
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

	// Token: 0x06000751 RID: 1873 RVA: 0x00024AB0 File Offset: 0x00022CB0
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

	// Token: 0x06000752 RID: 1874 RVA: 0x00024B98 File Offset: 0x00022D98
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeMoveSpeed._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMoveSpeed.TsTaskChangeMoveSpeed_C");
		}
		return TsTaskChangeMoveSpeed._ClassPtr;
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00024BBC File Offset: 0x00022DBC
	public TsTaskChangeMoveSpeed() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMoveSpeed.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00024BE4 File Offset: 0x00022DE4
	[NullableContext(1)]
	public TsTaskChangeMoveSpeed(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMoveSpeed.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00024C17 File Offset: 0x00022E17
	protected TsTaskChangeMoveSpeed(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00024C20 File Offset: 0x00022E20
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000557 RID: 1367
	private bool IsInitTsVariables;

	// Token: 0x04000558 RID: 1368
	private float TsMoveSpeed;

	// Token: 0x04000559 RID: 1369
	private bool TsResetDefault;

	// Token: 0x0400055A RID: 1370
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeMoveSpeed.TsTaskChangeMoveSpeed_C";

	// Token: 0x0400055B RID: 1371
	private static IntPtr _ClassPtr;

	// Token: 0x0400055C RID: 1372
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400055D RID: 1373
	private static int __PropertyOffset_MoveSpeed;

	// Token: 0x0400055E RID: 1374
	private static int __PropertyOffset_ResetDefault;
}

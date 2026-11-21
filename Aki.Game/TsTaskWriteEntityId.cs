using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000D1 RID: 209
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWriteEntityId.TsTaskWriteEntityId_C")]
public class TsTaskWriteEntityId : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000410F7 File Offset: 0x0003F2F7
	// (set) Token: 0x06000C8A RID: 3210 RVA: 0x0004110B File Offset: 0x0003F30B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTarget
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyTarget)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyTarget)), value);
		}
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00041120 File Offset: 0x0003F320
	// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00041134 File Offset: 0x0003F334
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyWriteTo
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyWriteTo)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWriteEntityId.__PropertyOffset_BlackboardKeyWriteTo)), value);
		}
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00041149 File Offset: 0x0003F349
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyTarget = this.BlackboardKeyTarget;
			this.TsBlackboardKeyWriteTo = this.BlackboardKeyWriteTo;
		}
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0004117C File Offset: 0x0003F37C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskWriteEntityId) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskWriteEntityId.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000C8F RID: 3215 RVA: 0x00041234 File Offset: 0x0003F434
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
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
		this.InitTsVariables();
		if (this.TsBlackboardKeyTarget == "")
		{
			base.FinishExecute(false);
			return;
		}
		int num = 0;
		if (this.TsBlackboardKeyTarget != "")
		{
			num = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyTarget).GetValueOrDefault();
			if (num == 0)
			{
				base.FinishExecute(false);
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(num);
			object obj;
			if (entityById == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = entityById.Entity;
				if (entity == null)
				{
					obj = null;
				}
				else
				{
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					obj = ((component != null) ? component.Owner : null);
				}
			}
			if (!(obj is TsBaseCharacter))
			{
				base.FinishExecute(false);
				return;
			}
		}
		BlackboardController.Instance.SetEntityIdByEntity(num, this.TsBlackboardKeyWriteTo, aiController.CharAiDesignComp.Entity.Id);
		base.FinishExecute(true);
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x00041361 File Offset: 0x0003F561
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskWriteEntityId._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWriteEntityId.TsTaskWriteEntityId_C");
		}
		return TsTaskWriteEntityId._ClassPtr;
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00041388 File Offset: 0x0003F588
	public TsTaskWriteEntityId() : this(BuiltinUtils.AllocNativeUObject(TsTaskWriteEntityId.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x000413B0 File Offset: 0x0003F5B0
	public TsTaskWriteEntityId(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWriteEntityId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x000413E3 File Offset: 0x0003F5E3
	protected TsTaskWriteEntityId(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00041404 File Offset: 0x0003F604
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000A0C RID: 2572
	private bool IsInitTsVariables;

	// Token: 0x04000A0D RID: 2573
	private string TsBlackboardKeyTarget = "";

	// Token: 0x04000A0E RID: 2574
	private string TsBlackboardKeyWriteTo = "";

	// Token: 0x04000A0F RID: 2575
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWriteEntityId.TsTaskWriteEntityId_C";

	// Token: 0x04000A10 RID: 2576
	private static IntPtr _ClassPtr;

	// Token: 0x04000A11 RID: 2577
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000A12 RID: 2578
	private static int __PropertyOffset_BlackboardKeyTarget;

	// Token: 0x04000A13 RID: 2579
	private static int __PropertyOffset_BlackboardKeyWriteTo;
}

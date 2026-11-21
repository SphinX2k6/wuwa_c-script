using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000AC RID: 172
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolPerformanceQuery.TsTaskPatrolPerformanceQuery_C")]
public class TsTaskPatrolPerformanceQuery : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060009A0 RID: 2464 RVA: 0x00031A4C File Offset: 0x0002FC4C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPatrolPerformanceQuery) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPatrolPerformanceQuery.StaticClass(), out intPtr, out num))
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

	// Token: 0x060009A1 RID: 2465 RVA: 0x00031AFC File Offset: 0x0002FCFC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.Finish(false);
			return;
		}
		AiController aiController = tsAiController.AiController;
		AiPatrolController aiPatrolController = (aiController != null) ? aiController.AiPatrol : null;
		if (aiPatrolController == null)
		{
			base.Finish(false);
			return;
		}
		Entity entity = tsAiController.AiController.CharActorComp.Entity;
		BaseAbilityComponent component = entity.GetComponent<BaseAbilityComponent>();
		BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
		if (component == null || component2 == null)
		{
			base.Finish(false);
			return;
		}
		component.ClearLastPerformanceTag();
		string nextPerformanceTag = aiPatrolController.GetNextPerformanceTag();
		if (nextPerformanceTag != null)
		{
			component.AddPerformanceTag(nextPerformanceTag);
		}
		else
		{
			int num = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.开始表演"];
			if (component2.HasTag(num))
			{
				component2.RemoveTag(new int?(num));
			}
		}
		base.Finish(true);
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00031BE4 File Offset: 0x0002FDE4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolPerformanceQuery._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolPerformanceQuery.TsTaskPatrolPerformanceQuery_C");
		}
		return TsTaskPatrolPerformanceQuery._ClassPtr;
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00031C08 File Offset: 0x0002FE08
	public TsTaskPatrolPerformanceQuery() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolPerformanceQuery.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00031C30 File Offset: 0x0002FE30
	[NullableContext(1)]
	public TsTaskPatrolPerformanceQuery(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolPerformanceQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00031C63 File Offset: 0x0002FE63
	protected TsTaskPatrolPerformanceQuery(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00031C6C File Offset: 0x0002FE6C
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000772 RID: 1906
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolPerformanceQuery.TsTaskPatrolPerformanceQuery_C";

	// Token: 0x04000773 RID: 1907
	private static IntPtr _ClassPtr;

	// Token: 0x04000774 RID: 1908
	private static IntPtr _ClassDefaultObjectPtr;
}

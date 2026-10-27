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
	// Token: 0x0600099A RID: 2458 RVA: 0x000309A4 File Offset: 0x0002EBA4
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

	// Token: 0x0600099B RID: 2459 RVA: 0x00030A40 File Offset: 0x0002EC40
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

	// Token: 0x0600099C RID: 2460 RVA: 0x00030B28 File Offset: 0x0002ED28
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolPerformanceQuery._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolPerformanceQuery.TsTaskPatrolPerformanceQuery_C");
		}
		return TsTaskPatrolPerformanceQuery._ClassPtr;
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00030B4C File Offset: 0x0002ED4C
	public TsTaskPatrolPerformanceQuery() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolPerformanceQuery.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00030B74 File Offset: 0x0002ED74
	[NullableContext(1)]
	public TsTaskPatrolPerformanceQuery(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolPerformanceQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00030BA7 File Offset: 0x0002EDA7
	protected TsTaskPatrolPerformanceQuery(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00030BB0 File Offset: 0x0002EDB0
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400076A RID: 1898
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolPerformanceQuery.TsTaskPatrolPerformanceQuery_C";

	// Token: 0x0400076B RID: 1899
	private static IntPtr _ClassPtr;

	// Token: 0x0400076C RID: 1900
	private static IntPtr _ClassDefaultObjectPtr;
}

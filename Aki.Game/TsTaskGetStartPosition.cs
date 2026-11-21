using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A4 RID: 164
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGetStartPosition.TsTaskGetStartPosition_C")]
public class TsTaskGetStartPosition : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060008CF RID: 2255 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskGetStartPosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskGetStartPosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x060008D0 RID: 2256 RVA: 0x0002DA94 File Offset: 0x0002BC94
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = tsAiController.AiController.CharActorComp;
		Entity entity = charActorComp.Entity;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		Aki.Protocol.Vector initLocation = entity.GetComponent<CreatureDataComponent>().GetInitLocation();
		BlackboardController.Instance.SetVectorValueByEntity(id, "StartPosition", (double)initLocation.X, (double)initLocation.Y, (double)initLocation.Z);
		base.FinishExecute(true);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x0002DB5F File Offset: 0x0002BD5F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGetStartPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGetStartPosition.TsTaskGetStartPosition_C");
		}
		return TsTaskGetStartPosition._ClassPtr;
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x0002DB84 File Offset: 0x0002BD84
	public TsTaskGetStartPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskGetStartPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x0002DBAC File Offset: 0x0002BDAC
	[NullableContext(1)]
	public TsTaskGetStartPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetStartPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x0002DBDF File Offset: 0x0002BDDF
	protected TsTaskGetStartPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040006C5 RID: 1733
	[Nullable(1)]
	private const string START_POSITION_KEY = "StartPosition";

	// Token: 0x040006C6 RID: 1734
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGetStartPosition.TsTaskGetStartPosition_C";

	// Token: 0x040006C7 RID: 1735
	private static IntPtr _ClassPtr;

	// Token: 0x040006C8 RID: 1736
	private static IntPtr _ClassDefaultObjectPtr;
}

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
	// Token: 0x060008CB RID: 2251 RVA: 0x0002CAB8 File Offset: 0x0002ACB8
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

	// Token: 0x060008CC RID: 2252 RVA: 0x0002CB54 File Offset: 0x0002AD54
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

	// Token: 0x060008CD RID: 2253 RVA: 0x0002CC1F File Offset: 0x0002AE1F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGetStartPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGetStartPosition.TsTaskGetStartPosition_C");
		}
		return TsTaskGetStartPosition._ClassPtr;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x0002CC44 File Offset: 0x0002AE44
	public TsTaskGetStartPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskGetStartPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x0002CC6C File Offset: 0x0002AE6C
	[NullableContext(1)]
	public TsTaskGetStartPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetStartPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x0002CC9F File Offset: 0x0002AE9F
	protected TsTaskGetStartPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x0002CCA8 File Offset: 0x0002AEA8
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040006C1 RID: 1729
	[Nullable(1)]
	private const string START_POSITION_KEY = "StartPosition";

	// Token: 0x040006C2 RID: 1730
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGetStartPosition.TsTaskGetStartPosition_C";

	// Token: 0x040006C3 RID: 1731
	private static IntPtr _ClassPtr;

	// Token: 0x040006C4 RID: 1732
	private static IntPtr _ClassDefaultObjectPtr;
}

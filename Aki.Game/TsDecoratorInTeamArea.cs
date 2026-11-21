using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000047 RID: 71
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorInTeamArea.TsDecoratorInTeamArea_C")]
public class TsDecoratorInTeamArea : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060002A6 RID: 678 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorInTeamArea) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorInTeamArea.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000CD60 File Offset: 0x0000AF60
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		if (currentTarget == null || !currentTarget.Valid)
		{
			return true;
		}
		if (currentTarget.Entity.GetComponent<CharacterActorComponent>() == null)
		{
			return true;
		}
		int id = aiController.CharAiDesignComp.Entity.Id;
		if (this.TmpVector == null)
		{
			this.TmpVector = Vector.Create();
		}
		this.TmpVector.FromUeVector(BlackboardController.Instance.GetVectorValueByEntity(id, "TeamTargetLocation"));
		AiAreaMemberData aiTeamAreaMemberData = aiController.AiTeam.GetAiTeamAreaMemberData(aiController);
		return aiTeamAreaMemberData == null || AiControllerLibrary.InTeamArea(aiController, aiTeamAreaMemberData, 1f);
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0000CE3D File Offset: 0x0000B03D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorInTeamArea._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorInTeamArea.TsDecoratorInTeamArea_C");
		}
		return TsDecoratorInTeamArea._ClassPtr;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000CE64 File Offset: 0x0000B064
	public TsDecoratorInTeamArea() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInTeamArea.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0000CE8C File Offset: 0x0000B08C
	[NullableContext(1)]
	public TsDecoratorInTeamArea(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInTeamArea.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000CEBF File Offset: 0x0000B0BF
	protected TsDecoratorInTeamArea(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001BF RID: 447
	[Nullable(2)]
	private Vector TmpVector;

	// Token: 0x040001C0 RID: 448
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorInTeamArea.TsDecoratorInTeamArea_C";

	// Token: 0x040001C1 RID: 449
	private static IntPtr _ClassPtr;

	// Token: 0x040001C2 RID: 450
	private static IntPtr _ClassDefaultObjectPtr;
}

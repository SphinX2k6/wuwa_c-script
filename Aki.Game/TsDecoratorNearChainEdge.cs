using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200004A RID: 74
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorNearChainEdge.TsDecoratorNearChainEdge_C")]
public class TsDecoratorNearChainEdge : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060002BE RID: 702 RVA: 0x0000CD87 File Offset: 0x0000AF87
	// (set) Token: 0x060002BF RID: 703 RVA: 0x0000CD97 File Offset: 0x0000AF97
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DistToChainEdgeLessThan
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorNearChainEdge.__PropertyOffset_DistToChainEdgeLessThan);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorNearChainEdge.__PropertyOffset_DistToChainEdgeLessThan) = value;
		}
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDistToChainEdgeLessThan = this.DistToChainEdgeLessThan;
		}
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0000CDCC File Offset: 0x0000AFCC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0000CE6C File Offset: 0x0000B06C
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
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
		AiHate? aiHate;
		float? num = (aiController.AiHateList.AiHate != null) ? new float?(aiHate.GetValueOrDefault().MaxMoveFromBorn) : null;
		if (num != null)
		{
			float? num2 = num;
			float num3 = 0f;
			if (!(num2.GetValueOrDefault() < num3 & num2 != null))
			{
				num2 = num;
				num3 = this.TsDistToChainEdgeLessThan;
				if (num2.GetValueOrDefault() < num3 & num2 != null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "TsDecoratorNearChainEdge配置的距离比ChainEdge要短，因此永远为True";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BT", base.TreeAsset);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return true;
				}
				Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(aiController.CharActorComp.Entity.Id, "CenterLocation");
				TsDecoratorNearChainEdge.TmpVector.FromUeVector(vectorValueByEntity ?? aiController.CharActorComp.GetInitLocation());
				return global::Vector.DistSquared2D(TsDecoratorNearChainEdge.TmpVector, aiController.CharActorComp.ActorLocationProxy) >= MathUtils.Instance.Square((double)(num.Value - this.TsDistToChainEdgeLessThan));
			}
		}
		return false;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorNearChainEdge._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorNearChainEdge.TsDecoratorNearChainEdge_C");
		}
		return TsDecoratorNearChainEdge._ClassPtr;
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0000D004 File Offset: 0x0000B204
	public TsDecoratorNearChainEdge() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorNearChainEdge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0000D02C File Offset: 0x0000B22C
	[NullableContext(1)]
	public TsDecoratorNearChainEdge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorNearChainEdge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0000D05F File Offset: 0x0000B25F
	protected TsDecoratorNearChainEdge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0000D068 File Offset: 0x0000B268
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001CC RID: 460
	private bool IsInitTsVariables;

	// Token: 0x040001CD RID: 461
	private float TsDistToChainEdgeLessThan;

	// Token: 0x040001CE RID: 462
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x040001CF RID: 463
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorNearChainEdge.TsDecoratorNearChainEdge_C";

	// Token: 0x040001D0 RID: 464
	private static IntPtr _ClassPtr;

	// Token: 0x040001D1 RID: 465
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001D2 RID: 466
	private static int __PropertyOffset_DistToChainEdgeLessThan;
}

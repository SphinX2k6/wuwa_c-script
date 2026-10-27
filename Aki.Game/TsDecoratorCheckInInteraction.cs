using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000039 RID: 57
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInInteraction.TsDecoratorCheckInInteraction_C")]
public class TsDecoratorCheckInInteraction : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600020E RID: 526 RVA: 0x0000A164 File Offset: 0x00008364
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

	// Token: 0x0600020F RID: 527 RVA: 0x0000A204 File Offset: 0x00008404
	[NullableContext(2)]
	protected bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		if (currentInteractEntityId == null || currentInteractEntityId.Value == 0)
		{
			return false;
		}
		Entity entity = EntitySystem.Instance.Get(currentInteractEntityId.Value);
		EEntityType? eentityType;
		if (entity == null)
		{
			eentityType = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			eentityType = ((component != null) ? new EEntityType?(component.GetEntityType()) : null);
		}
		EEntityType? eentityType2 = eentityType;
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			return false;
		}
		int id = aiController.CharAiDesignComp.Entity.Id;
		return eentityType2.GetValueOrDefault() == EEntityType.Npc && currentInteractEntityId.Value != id;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000A2B3 File Offset: 0x000084B3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckInInteraction._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInInteraction.TsDecoratorCheckInInteraction_C");
		}
		return TsDecoratorCheckInInteraction._ClassPtr;
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000A2D8 File Offset: 0x000084D8
	public TsDecoratorCheckInInteraction() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000A300 File Offset: 0x00008500
	[NullableContext(1)]
	public TsDecoratorCheckInInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000A333 File Offset: 0x00008533
	protected TsDecoratorCheckInInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000A33C File Offset: 0x0000853C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000162 RID: 354
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInInteraction.TsDecoratorCheckInInteraction_C";

	// Token: 0x04000163 RID: 355
	private static IntPtr _ClassPtr;

	// Token: 0x04000164 RID: 356
	private static IntPtr _ClassDefaultObjectPtr;
}

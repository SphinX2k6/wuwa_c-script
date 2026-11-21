using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000056 RID: 86
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceNpcPerceptionDecision.TsServiceNpcPerceptionDecision_C")]
public class TsServiceNpcPerceptionDecision : UBTService_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600034B RID: 843 RVA: 0x0000FB50 File Offset: 0x0000DD50
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsServiceNpcPerceptionDecision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsServiceNpcPerceptionDecision.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600034C RID: 844 RVA: 0x0000FC08 File Offset: 0x0000DE08
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			return;
		}
		AiController aiController = (ownerController as TsAiController).AiController;
		int id = aiController.CharActorComp.Entity.Id;
		HashSet<int> allEnemies = aiController.AiPerception.AllEnemies;
		int num = 0;
		int value = 0;
		if (allEnemies.Count > 0)
		{
			foreach (int num2 in allEnemies)
			{
				EEntityType entityTypeByEntity = (EEntityType)WorldFunctionLibrary.GetEntityTypeByEntity(num2);
				if (entityTypeByEntity != EEntityType.Player)
				{
					if (entityTypeByEntity == EEntityType.Monster)
					{
						num++;
					}
				}
				else
				{
					value = num2;
				}
			}
		}
		foreach (int num3 in aiController.AiPerception.Allies)
		{
			Entity entity = EntitySystem.Instance.Get(num3);
			bool flag;
			if (entity == null)
			{
				flag = false;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				flag = ((component != null) ? new bool?(component.IsRole()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				value = num3;
				break;
			}
		}
		int count = aiController.AiPerception.Neutrals.Count;
		BlackboardController.Instance.SetIntValueByEntity(id, ENpcBlackBoardKeys.MonsterCount.ToString(), num);
		BlackboardController.Instance.SetEntityIdByEntity(id, ENpcBlackBoardKeys.NearerPlayerId.ToString(), value);
		BlackboardController.Instance.SetIntValueByEntity(id, ENpcBlackBoardKeys.NeutralCount.ToString(), count);
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsServiceNpcPerceptionDecision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceNpcPerceptionDecision.TsServiceNpcPerceptionDecision_C");
		}
		return TsServiceNpcPerceptionDecision._ClassPtr;
	}

	// Token: 0x0600034E RID: 846 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
	public TsServiceNpcPerceptionDecision() : this(BuiltinUtils.AllocNativeUObject(TsServiceNpcPerceptionDecision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0000FDEC File Offset: 0x0000DFEC
	[NullableContext(1)]
	public TsServiceNpcPerceptionDecision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceNpcPerceptionDecision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0000FE1F File Offset: 0x0000E01F
	protected TsServiceNpcPerceptionDecision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0000FE28 File Offset: 0x0000E028
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000228 RID: 552
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Service/TsServiceNpcPerceptionDecision.TsServiceNpcPerceptionDecision_C";

	// Token: 0x04000229 RID: 553
	private static IntPtr _ClassPtr;

	// Token: 0x0400022A RID: 554
	private static IntPtr _ClassDefaultObjectPtr;
}

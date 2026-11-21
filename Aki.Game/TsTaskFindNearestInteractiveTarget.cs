using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000075 RID: 117
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskFindNearestInteractiveTarget.TsTaskFindNearestInteractiveTarget_C")]
public class TsTaskFindNearestInteractiveTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000567 RID: 1383 RVA: 0x0001A7BF File Offset: 0x000189BF
	// (set) Token: 0x06000568 RID: 1384 RVA: 0x0001A7CF File Offset: 0x000189CF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SearchRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindNearestInteractiveTarget.__PropertyOffset_SearchRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindNearestInteractiveTarget.__PropertyOffset_SearchRange) = value;
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001A7E0 File Offset: 0x000189E0
	// (set) Token: 0x0600056A RID: 1386 RVA: 0x0001A7F4 File Offset: 0x000189F4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SaveTargetBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindNearestInteractiveTarget.__PropertyOffset_SaveTargetBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindNearestInteractiveTarget.__PropertyOffset_SaveTargetBlackboardKey)), value);
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0001A809 File Offset: 0x00018A09
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSearchRange = this.SearchRange;
			this.TsSaveTargetBlackboardKey = this.SaveTargetBlackboardKey;
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0001A83C File Offset: 0x00018A3C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFindNearestInteractiveTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFindNearestInteractiveTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600056D RID: 1389 RVA: 0x0001A8EC File Offset: 0x00018AEC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			base.FinishExecute(false);
			return;
		}
		if (this.TmpHandles == null)
		{
			this.TmpHandles = new List<EntityHandle>();
		}
		CharacterActorComponent charActorComp = ((TsAiController)ownerController).AiController.CharActorComp;
		this.NowLocation = charActorComp.ActorLocationProxy;
		int id = charActorComp.Entity.Id;
		long? nearestInteractiveEntity = this.GetNearestInteractiveEntity(charActorComp, this.TsSearchRange);
		if (nearestInteractiveEntity != null)
		{
			BlackboardController.Instance.SetEntityIdByEntity(id, this.TsSaveTargetBlackboardKey, (int)nearestInteractiveEntity.Value);
			base.FinishExecute(true);
			return;
		}
		base.FinishExecute(false);
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001A98C File Offset: 0x00018B8C
	private long? GetNearestInteractiveEntity(CharacterActorComponent self, float searchRange)
	{
		CreatureModel.Instance.GetEntitiesInRangeWithLocation(this.NowLocation, this.TsSearchRange, EEntityTypeQuery.SceneItemOrCharacter, this.TmpHandles, true);
		double num = double.MaxValue;
		long? result = null;
		foreach (EntityHandle entityHandle in this.TmpHandles)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Active && entityHandle.Entity != self.Entity)
			{
				BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
				EEntityType entityType = component.CreatureData.GetEntityType();
				bool flag = entityType == EEntityType.Npc || entityType == EEntityType.SceneItem;
				if (flag)
				{
					InteractItemComponent component2 = component.Entity.GetComponent<InteractItemComponent>();
					if (component2 != null && component2.IsInit)
					{
						double num2 = global::Vector.Dist(self.ActorLocationProxy, component.ActorLocationProxy);
						if (num2 < num)
						{
							num = num2;
							result = new long?((long)entityHandle.Id);
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0001AAB4 File Offset: 0x00018CB4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindNearestInteractiveTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskFindNearestInteractiveTarget.TsTaskFindNearestInteractiveTarget_C");
		}
		return TsTaskFindNearestInteractiveTarget._ClassPtr;
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001AAD8 File Offset: 0x00018CD8
	public TsTaskFindNearestInteractiveTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestInteractiveTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0001AB00 File Offset: 0x00018D00
	public TsTaskFindNearestInteractiveTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestInteractiveTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0001AB33 File Offset: 0x00018D33
	protected TsTaskFindNearestInteractiveTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0001AB48 File Offset: 0x00018D48
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040003E1 RID: 993
	[Nullable(2)]
	private global::Vector NowLocation;

	// Token: 0x040003E2 RID: 994
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<EntityHandle> TmpHandles;

	// Token: 0x040003E3 RID: 995
	private bool IsInitTsVariables;

	// Token: 0x040003E4 RID: 996
	private float TsSearchRange;

	// Token: 0x040003E5 RID: 997
	private string TsSaveTargetBlackboardKey = "";

	// Token: 0x040003E6 RID: 998
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskFindNearestInteractiveTarget.TsTaskFindNearestInteractiveTarget_C";

	// Token: 0x040003E7 RID: 999
	private static IntPtr _ClassPtr;

	// Token: 0x040003E8 RID: 1000
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003E9 RID: 1001
	private static int __PropertyOffset_SearchRange;

	// Token: 0x040003EA RID: 1002
	private static int __PropertyOffset_SaveTargetBlackboardKey;
}

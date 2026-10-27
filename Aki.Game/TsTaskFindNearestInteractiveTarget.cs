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
	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06000563 RID: 1379 RVA: 0x00019CF7 File Offset: 0x00017EF7
	// (set) Token: 0x06000564 RID: 1380 RVA: 0x00019D07 File Offset: 0x00017F07
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

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000565 RID: 1381 RVA: 0x00019D18 File Offset: 0x00017F18
	// (set) Token: 0x06000566 RID: 1382 RVA: 0x00019D2C File Offset: 0x00017F2C
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

	// Token: 0x06000567 RID: 1383 RVA: 0x00019D41 File Offset: 0x00017F41
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSearchRange = this.SearchRange;
			this.TsSaveTargetBlackboardKey = this.SaveTargetBlackboardKey;
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00019D74 File Offset: 0x00017F74
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

	// Token: 0x06000569 RID: 1385 RVA: 0x00019E10 File Offset: 0x00018010
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

	// Token: 0x0600056A RID: 1386 RVA: 0x00019EB0 File Offset: 0x000180B0
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

	// Token: 0x0600056B RID: 1387 RVA: 0x00019FD8 File Offset: 0x000181D8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindNearestInteractiveTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskFindNearestInteractiveTarget.TsTaskFindNearestInteractiveTarget_C");
		}
		return TsTaskFindNearestInteractiveTarget._ClassPtr;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00019FFC File Offset: 0x000181FC
	public TsTaskFindNearestInteractiveTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestInteractiveTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0001A024 File Offset: 0x00018224
	public TsTaskFindNearestInteractiveTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestInteractiveTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001A057 File Offset: 0x00018257
	protected TsTaskFindNearestInteractiveTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0001A06C File Offset: 0x0001826C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040003DD RID: 989
	[Nullable(2)]
	private global::Vector NowLocation;

	// Token: 0x040003DE RID: 990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<EntityHandle> TmpHandles;

	// Token: 0x040003DF RID: 991
	private bool IsInitTsVariables;

	// Token: 0x040003E0 RID: 992
	private float TsSearchRange;

	// Token: 0x040003E1 RID: 993
	private string TsSaveTargetBlackboardKey = "";

	// Token: 0x040003E2 RID: 994
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskFindNearestInteractiveTarget.TsTaskFindNearestInteractiveTarget_C";

	// Token: 0x040003E3 RID: 995
	private static IntPtr _ClassPtr;

	// Token: 0x040003E4 RID: 996
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003E5 RID: 997
	private static int __PropertyOffset_SearchRange;

	// Token: 0x040003E6 RID: 998
	private static int __PropertyOffset_SaveTargetBlackboardKey;
}

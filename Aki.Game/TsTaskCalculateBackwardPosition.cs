using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008E RID: 142
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCalculateBackwardPosition.TsTaskCalculateBackwardPosition_C")]
public class TsTaskCalculateBackwardPosition : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000729 RID: 1833 RVA: 0x00024D19 File Offset: 0x00022F19
	// (set) Token: 0x0600072A RID: 1834 RVA: 0x00024D29 File Offset: 0x00022F29
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskCalculateBackwardPosition.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskCalculateBackwardPosition.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x0600072B RID: 1835 RVA: 0x00024D3A File Offset: 0x00022F3A
	// (set) Token: 0x0600072C RID: 1836 RVA: 0x00024D4E File Offset: 0x00022F4E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskCalculateBackwardPosition.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskCalculateBackwardPosition.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00024D64 File Offset: 0x00022F64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskCalculateBackwardPosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskCalculateBackwardPosition.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00024DBD File Offset: 0x00022FBD
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDistance = this.Distance;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00024DF0 File Offset: 0x00022FF0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskCalculateBackwardPosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskCalculateBackwardPosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000730 RID: 1840 RVA: 0x00024EA0 File Offset: 0x000230A0
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		global::Vector actorLocationProxy = charActorComp.ActorLocationProxy;
		global::Vector vector = charActorComp.ActorForwardProxy;
		Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(charActorComp.Entity.Id, "InputDirect");
		if (vectorValueByEntity != null)
		{
			vector = global::Vector.Create(vectorValueByEntity);
			if (vector.IsNearlyZero(9.999999747378752E-05))
			{
				vector = charActorComp.ActorForwardProxy;
			}
			BlackboardController.Instance.RemoveValueByEntity(charActorComp.Entity.Id, "InputDirect");
		}
		global::Vector vector2 = global::Vector.Create(vector);
		vector2.MultiplyEqual((double)(-(double)this.TsDistance));
		vector2.AdditionEqual(actorLocationProxy);
		BlackboardController.Instance.SetVectorValueByEntity(charActorComp.Entity.Id, this.TsBlackboardKey, (double)((float)vector2.X), (double)((float)vector2.Y), (double)((float)vector2.Z));
		base.FinishExecute(true);
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00024FD2 File Offset: 0x000231D2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskCalculateBackwardPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCalculateBackwardPosition.TsTaskCalculateBackwardPosition_C");
		}
		return TsTaskCalculateBackwardPosition._ClassPtr;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00024FF8 File Offset: 0x000231F8
	public TsTaskCalculateBackwardPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskCalculateBackwardPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00025020 File Offset: 0x00023220
	public TsTaskCalculateBackwardPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskCalculateBackwardPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00025053 File Offset: 0x00023253
	protected TsTaskCalculateBackwardPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00025067 File Offset: 0x00023267
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00025070 File Offset: 0x00023270
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000547 RID: 1351
	private bool IsInitTsVariables;

	// Token: 0x04000548 RID: 1352
	private float TsDistance;

	// Token: 0x04000549 RID: 1353
	private string TsBlackboardKey = "";

	// Token: 0x0400054A RID: 1354
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCalculateBackwardPosition.TsTaskCalculateBackwardPosition_C";

	// Token: 0x0400054B RID: 1355
	private static IntPtr _ClassPtr;

	// Token: 0x0400054C RID: 1356
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400054D RID: 1357
	private static int __PropertyOffset_Distance;

	// Token: 0x0400054E RID: 1358
	private static int __PropertyOffset_BlackboardKey;
}

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
	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000725 RID: 1829 RVA: 0x00024001 File Offset: 0x00022201
	// (set) Token: 0x06000726 RID: 1830 RVA: 0x00024011 File Offset: 0x00022211
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

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000727 RID: 1831 RVA: 0x00024022 File Offset: 0x00022222
	// (set) Token: 0x06000728 RID: 1832 RVA: 0x00024036 File Offset: 0x00022236
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

	// Token: 0x06000729 RID: 1833 RVA: 0x0002404C File Offset: 0x0002224C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x000240BC File Offset: 0x000222BC
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDistance = this.Distance;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000240EC File Offset: 0x000222EC
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

	// Token: 0x0600072C RID: 1836 RVA: 0x00024188 File Offset: 0x00022388
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

	// Token: 0x0600072D RID: 1837 RVA: 0x000242BA File Offset: 0x000224BA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskCalculateBackwardPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCalculateBackwardPosition.TsTaskCalculateBackwardPosition_C");
		}
		return TsTaskCalculateBackwardPosition._ClassPtr;
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x000242E0 File Offset: 0x000224E0
	public TsTaskCalculateBackwardPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskCalculateBackwardPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00024308 File Offset: 0x00022508
	public TsTaskCalculateBackwardPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskCalculateBackwardPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x0002433B File Offset: 0x0002253B
	protected TsTaskCalculateBackwardPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x0002434F File Offset: 0x0002254F
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00024358 File Offset: 0x00022558
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000543 RID: 1347
	private bool IsInitTsVariables;

	// Token: 0x04000544 RID: 1348
	private float TsDistance;

	// Token: 0x04000545 RID: 1349
	private string TsBlackboardKey = "";

	// Token: 0x04000546 RID: 1350
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskCalculateBackwardPosition.TsTaskCalculateBackwardPosition_C";

	// Token: 0x04000547 RID: 1351
	private static IntPtr _ClassPtr;

	// Token: 0x04000548 RID: 1352
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000549 RID: 1353
	private static int __PropertyOffset_Distance;

	// Token: 0x0400054A RID: 1354
	private static int __PropertyOffset_BlackboardKey;
}

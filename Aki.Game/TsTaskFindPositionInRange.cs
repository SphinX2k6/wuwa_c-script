using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200009D RID: 157
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPositionInRange.TsTaskFindPositionInRange_C")]
public class TsTaskFindPositionInRange : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000832 RID: 2098 RVA: 0x000297E9 File Offset: 0x000279E9
	// (set) Token: 0x06000833 RID: 2099 RVA: 0x000297FD File Offset: 0x000279FD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string RangeCenterKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindPositionInRange.__PropertyOffset_RangeCenterKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindPositionInRange.__PropertyOffset_RangeCenterKey)), value);
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000834 RID: 2100 RVA: 0x00029812 File Offset: 0x00027A12
	// (set) Token: 0x06000835 RID: 2101 RVA: 0x00029822 File Offset: 0x00027A22
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RangeRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPositionInRange.__PropertyOffset_RangeRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPositionInRange.__PropertyOffset_RangeRadius) = value;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000836 RID: 2102 RVA: 0x00029833 File Offset: 0x00027A33
	// (set) Token: 0x06000837 RID: 2103 RVA: 0x00029847 File Offset: 0x00027A47
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindPositionInRange.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindPositionInRange.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x0002985C File Offset: 0x00027A5C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsRangeCenterKey = this.RangeCenterKey;
			this.TsRangeRadius = this.RangeRadius;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00029898 File Offset: 0x00027A98
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFindPositionInRange) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFindPositionInRange.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600083A RID: 2106 RVA: 0x00029948 File Offset: 0x00027B48
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		Entity entity = charActorComp.Entity;
		int id = entity.Id;
		if (!string.IsNullOrEmpty(this.TsRangeCenterKey))
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(id, this.TsRangeCenterKey);
			if (vectorValueByEntity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.CJH;
				string message2 = "不存在BlackboardKey";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Key", this.TsRangeCenterKey);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			this.RangeCenter = global::Vector.Create(vectorValueByEntity);
		}
		else
		{
			Aki.Protocol.Vector initLocation = entity.GetComponent<CreatureDataComponent>().GetInitLocation();
			this.RangeCenter = global::Vector.Create((double)initLocation.X, (double)initLocation.Y, (double)initLocation.Z);
		}
		global::Vector vector = global::Vector.Create();
		ValueTuple<float, float> valueTuple3 = this.RandomPointInCircle(this.TsRangeRadius);
		vector.X = this.RangeCenter.X + (double)valueTuple3.Item1;
		vector.Y = this.RangeCenter.Y + (double)valueTuple3.Item2;
		BlackboardController.Instance.SetVectorValueByEntity(id, this.TsBlackboardKey, (double)((float)vector.X), (double)((float)vector.Y), (double)((float)vector.Z));
		base.FinishExecute(true);
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00029AF4 File Offset: 0x00027CF4
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	private ValueTuple<float, float> RandomPointInCircle(float radius)
	{
		if (radius <= 0f)
		{
			return new ValueTuple<float, float>(0f, 0f);
		}
		double randomRange = MathUtils.Instance.GetRandomRange(0.0, (double)(radius * radius));
		double randomRange2 = MathUtils.Instance.GetRandomRange(0.0, 6.28000020980835);
		double num = Math.Sqrt(randomRange);
		return new ValueTuple<float, float>((float)(num * Math.Cos(randomRange2)), (float)(num * Math.Sin(randomRange2)));
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00029B6A File Offset: 0x00027D6A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindPositionInRange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPositionInRange.TsTaskFindPositionInRange_C");
		}
		return TsTaskFindPositionInRange._ClassPtr;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00029B90 File Offset: 0x00027D90
	public TsTaskFindPositionInRange() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindPositionInRange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00029BB8 File Offset: 0x00027DB8
	public TsTaskFindPositionInRange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindPositionInRange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00029BEB File Offset: 0x00027DEB
	protected TsTaskFindPositionInRange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00029C0C File Offset: 0x00027E0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000622 RID: 1570
	private const float PI = 3.14f;

	// Token: 0x04000623 RID: 1571
	private bool IsInitTsVariables;

	// Token: 0x04000624 RID: 1572
	private string TsRangeCenterKey = "";

	// Token: 0x04000625 RID: 1573
	private float TsRangeRadius;

	// Token: 0x04000626 RID: 1574
	private string TsBlackboardKey = "";

	// Token: 0x04000627 RID: 1575
	[Nullable(2)]
	private global::Vector RangeCenter;

	// Token: 0x04000628 RID: 1576
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPositionInRange.TsTaskFindPositionInRange_C";

	// Token: 0x04000629 RID: 1577
	private static IntPtr _ClassPtr;

	// Token: 0x0400062A RID: 1578
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400062B RID: 1579
	private static int __PropertyOffset_RangeCenterKey;

	// Token: 0x0400062C RID: 1580
	private static int __PropertyOffset_RangeRadius;

	// Token: 0x0400062D RID: 1581
	private static int __PropertyOffset_BlackboardKey;
}

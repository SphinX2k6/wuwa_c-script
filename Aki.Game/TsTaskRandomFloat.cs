using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B4 RID: 180
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomFloat.TsTaskRandomFloat_C")]
public class TsTaskRandomFloat : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000335F3 File Offset: 0x000317F3
	// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00033603 File Offset: 0x00031803
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Min
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomFloat.__PropertyOffset_Min);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomFloat.__PropertyOffset_Min) = value;
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00033614 File Offset: 0x00031814
	// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00033624 File Offset: 0x00031824
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Max
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomFloat.__PropertyOffset_Max);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomFloat.__PropertyOffset_Max) = value;
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00033635 File Offset: 0x00031835
	// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00033649 File Offset: 0x00031849
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyWriteTo
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskRandomFloat.__PropertyOffset_BlackboardKeyWriteTo)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskRandomFloat.__PropertyOffset_BlackboardKeyWriteTo)), value);
		}
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0003365E File Offset: 0x0003185E
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMin = this.Min;
			this.TsMax = this.Max;
			this.TsBlackboardKeyWriteTo = this.BlackboardKeyWriteTo;
		}
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0003369C File Offset: 0x0003189C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0003373C File Offset: 0x0003193C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
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
		BlackboardController.Instance.SetFloatValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyWriteTo, (float)MathUtils.Instance.GetRandomRange((double)this.TsMin, (double)this.TsMax));
		base.FinishExecute(true);
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x000337E0 File Offset: 0x000319E0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskRandomFloat._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomFloat.TsTaskRandomFloat_C");
		}
		return TsTaskRandomFloat._ClassPtr;
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00033804 File Offset: 0x00031A04
	public TsTaskRandomFloat() : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x0003382C File Offset: 0x00031A2C
	public TsTaskRandomFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x0003385F File Offset: 0x00031A5F
	protected TsTaskRandomFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00033874 File Offset: 0x00031A74
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040007F1 RID: 2033
	private bool IsInitTsVariables;

	// Token: 0x040007F2 RID: 2034
	private float TsMin;

	// Token: 0x040007F3 RID: 2035
	private float TsMax;

	// Token: 0x040007F4 RID: 2036
	private string TsBlackboardKeyWriteTo = "";

	// Token: 0x040007F5 RID: 2037
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomFloat.TsTaskRandomFloat_C";

	// Token: 0x040007F6 RID: 2038
	private static IntPtr _ClassPtr;

	// Token: 0x040007F7 RID: 2039
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007F8 RID: 2040
	private static int __PropertyOffset_Min;

	// Token: 0x040007F9 RID: 2041
	private static int __PropertyOffset_Max;

	// Token: 0x040007FA RID: 2042
	private static int __PropertyOffset_BlackboardKeyWriteTo;
}

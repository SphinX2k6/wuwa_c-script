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
	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00034783 File Offset: 0x00032983
	// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00034793 File Offset: 0x00032993
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

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000347A4 File Offset: 0x000329A4
	// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000347B4 File Offset: 0x000329B4
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

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000347C5 File Offset: 0x000329C5
	// (set) Token: 0x06000A54 RID: 2644 RVA: 0x000347D9 File Offset: 0x000329D9
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

	// Token: 0x06000A55 RID: 2645 RVA: 0x000347EE File Offset: 0x000329EE
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

	// Token: 0x06000A56 RID: 2646 RVA: 0x0003482C File Offset: 0x00032A2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskRandomFloat) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskRandomFloat.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x000348E4 File Offset: 0x00032AE4
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

	// Token: 0x06000A58 RID: 2648 RVA: 0x00034988 File Offset: 0x00032B88
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskRandomFloat._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomFloat.TsTaskRandomFloat_C");
		}
		return TsTaskRandomFloat._ClassPtr;
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x000349AC File Offset: 0x00032BAC
	public TsTaskRandomFloat() : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x000349D4 File Offset: 0x00032BD4
	public TsTaskRandomFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00034A07 File Offset: 0x00032C07
	protected TsTaskRandomFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00034A1C File Offset: 0x00032C1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040007F9 RID: 2041
	private bool IsInitTsVariables;

	// Token: 0x040007FA RID: 2042
	private float TsMin;

	// Token: 0x040007FB RID: 2043
	private float TsMax;

	// Token: 0x040007FC RID: 2044
	private string TsBlackboardKeyWriteTo = "";

	// Token: 0x040007FD RID: 2045
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomFloat.TsTaskRandomFloat_C";

	// Token: 0x040007FE RID: 2046
	private static IntPtr _ClassPtr;

	// Token: 0x040007FF RID: 2047
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000800 RID: 2048
	private static int __PropertyOffset_Min;

	// Token: 0x04000801 RID: 2049
	private static int __PropertyOffset_Max;

	// Token: 0x04000802 RID: 2050
	private static int __PropertyOffset_BlackboardKeyWriteTo;
}

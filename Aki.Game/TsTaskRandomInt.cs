using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B5 RID: 181
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomInt.TsTaskRandomInt_C")]
public class TsTaskRandomInt : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00034A4F File Offset: 0x00032C4F
	// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00034A5F File Offset: 0x00032C5F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Mode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_Mode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_Mode) = value;
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00034A70 File Offset: 0x00032C70
	// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00034A80 File Offset: 0x00032C80
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Min
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_Min);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_Min) = value;
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00034A91 File Offset: 0x00032C91
	// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00034AA1 File Offset: 0x00032CA1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Max
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_Max);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_Max) = value;
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00034AB4 File Offset: 0x00032CB4
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> IntValueArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._IntValueArray) == null)
			{
				result = (this._IntValueArray = new TArray<int>(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_IntValueArray, this));
			}
			return result;
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00034AF0 File Offset: 0x00032CF0
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> IntWeightArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._IntWeightArray) == null)
			{
				result = (this._IntWeightArray = new TArray<int>(base.NativePtr + (IntPtr)TsTaskRandomInt.__PropertyOffset_IntWeightArray, this));
			}
			return result;
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00034B29 File Offset: 0x00032D29
	// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00034B3D File Offset: 0x00032D3D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyWriteTo
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskRandomInt.__PropertyOffset_BlackboardKeyWriteTo)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskRandomInt.__PropertyOffset_BlackboardKeyWriteTo)), value);
		}
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00034B54 File Offset: 0x00032D54
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMode = this.Mode;
			this.TsMin = this.Min;
			this.TsMax = this.Max;
			this.TsBlackboardKeyWriteTo = this.BlackboardKeyWriteTo;
			if (this.TsMode == 1)
			{
				this.TsValues = new List<int>();
				this.TsWeights = new List<int>();
				this.TsTotalWeight = 0;
				int num = this.IntValueArray.Num();
				int num2 = this.IntWeightArray.Num();
				for (int i = 0; i < num; i++)
				{
					int item = this.IntValueArray.Get(i);
					int num3 = (i < num2) ? this.IntWeightArray.Get(i) : 1;
					this.TsValues.Add(item);
					this.TsWeights.Add(num3);
					this.TsTotalWeight += num3;
				}
			}
		}
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00034C44 File Offset: 0x00032E44
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
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
		int value = 0;
		if (this.TsMode == 1)
		{
			if (this.TsValues.Count == 0 || this.TsTotalWeight <= 0)
			{
				Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.LCZ, "TsTaskRandomInt集合为空或权重总和为0", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			double num = MathUtils.Instance.GetRandomRange(0.0, (double)this.TsTotalWeight);
			for (int i = 0; i < this.TsValues.Count; i++)
			{
				num -= (double)this.TsWeights[i];
				if (num <= 0.0)
				{
					value = this.TsValues[i];
					break;
				}
			}
		}
		else
		{
			value = Math.Min(this.TsMax, (int)Math.Floor(MathUtils.Instance.GetRandomRange((double)this.TsMin, (double)(this.TsMax + 1))));
		}
		BlackboardController.Instance.SetIntValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyWriteTo, value);
		base.FinishExecute(true);
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00034DAC File Offset: 0x00032FAC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskRandomInt._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomInt.TsTaskRandomInt_C");
		}
		return TsTaskRandomInt._ClassPtr;
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00034DD0 File Offset: 0x00032FD0
	public TsTaskRandomInt() : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00034DF8 File Offset: 0x00032FF8
	public TsTaskRandomInt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00034E2B File Offset: 0x0003302B
	protected TsTaskRandomInt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00034E58 File Offset: 0x00033058
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000803 RID: 2051
	private bool IsInitTsVariables;

	// Token: 0x04000804 RID: 2052
	private int TsMode;

	// Token: 0x04000805 RID: 2053
	private int TsMin;

	// Token: 0x04000806 RID: 2054
	private int TsMax;

	// Token: 0x04000807 RID: 2055
	private List<int> TsValues = new List<int>();

	// Token: 0x04000808 RID: 2056
	private List<int> TsWeights = new List<int>();

	// Token: 0x04000809 RID: 2057
	private int TsTotalWeight;

	// Token: 0x0400080A RID: 2058
	private string TsBlackboardKeyWriteTo = "";

	// Token: 0x0400080B RID: 2059
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomInt.TsTaskRandomInt_C";

	// Token: 0x0400080C RID: 2060
	private static IntPtr _ClassPtr;

	// Token: 0x0400080D RID: 2061
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400080E RID: 2062
	private static int __PropertyOffset_Mode;

	// Token: 0x0400080F RID: 2063
	private static int __PropertyOffset_Min;

	// Token: 0x04000810 RID: 2064
	private static int __PropertyOffset_Max;

	// Token: 0x04000811 RID: 2065
	private static int __PropertyOffset_IntValueArray;

	// Token: 0x04000812 RID: 2066
	[Nullable(2)]
	private TArray<int> _IntValueArray;

	// Token: 0x04000813 RID: 2067
	private static int __PropertyOffset_IntWeightArray;

	// Token: 0x04000814 RID: 2068
	[Nullable(2)]
	private TArray<int> _IntWeightArray;

	// Token: 0x04000815 RID: 2069
	private static int __PropertyOffset_BlackboardKeyWriteTo;
}

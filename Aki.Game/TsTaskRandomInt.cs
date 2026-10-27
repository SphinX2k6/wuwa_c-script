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
	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000A57 RID: 2647 RVA: 0x000338A7 File Offset: 0x00031AA7
	// (set) Token: 0x06000A58 RID: 2648 RVA: 0x000338B7 File Offset: 0x00031AB7
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

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000A59 RID: 2649 RVA: 0x000338C8 File Offset: 0x00031AC8
	// (set) Token: 0x06000A5A RID: 2650 RVA: 0x000338D8 File Offset: 0x00031AD8
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

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000A5B RID: 2651 RVA: 0x000338E9 File Offset: 0x00031AE9
	// (set) Token: 0x06000A5C RID: 2652 RVA: 0x000338F9 File Offset: 0x00031AF9
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

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003390C File Offset: 0x00031B0C
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

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00033948 File Offset: 0x00031B48
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

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00033981 File Offset: 0x00031B81
	// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00033995 File Offset: 0x00031B95
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

	// Token: 0x06000A61 RID: 2657 RVA: 0x000339AC File Offset: 0x00031BAC
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

	// Token: 0x06000A62 RID: 2658 RVA: 0x00033A9C File Offset: 0x00031C9C
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

	// Token: 0x06000A63 RID: 2659 RVA: 0x00033C04 File Offset: 0x00031E04
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskRandomInt._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomInt.TsTaskRandomInt_C");
		}
		return TsTaskRandomInt._ClassPtr;
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00033C28 File Offset: 0x00031E28
	public TsTaskRandomInt() : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00033C50 File Offset: 0x00031E50
	public TsTaskRandomInt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00033C83 File Offset: 0x00031E83
	protected TsTaskRandomInt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00033CB0 File Offset: 0x00031EB0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040007FB RID: 2043
	private bool IsInitTsVariables;

	// Token: 0x040007FC RID: 2044
	private int TsMode;

	// Token: 0x040007FD RID: 2045
	private int TsMin;

	// Token: 0x040007FE RID: 2046
	private int TsMax;

	// Token: 0x040007FF RID: 2047
	private List<int> TsValues = new List<int>();

	// Token: 0x04000800 RID: 2048
	private List<int> TsWeights = new List<int>();

	// Token: 0x04000801 RID: 2049
	private int TsTotalWeight;

	// Token: 0x04000802 RID: 2050
	private string TsBlackboardKeyWriteTo = "";

	// Token: 0x04000803 RID: 2051
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomInt.TsTaskRandomInt_C";

	// Token: 0x04000804 RID: 2052
	private static IntPtr _ClassPtr;

	// Token: 0x04000805 RID: 2053
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000806 RID: 2054
	private static int __PropertyOffset_Mode;

	// Token: 0x04000807 RID: 2055
	private static int __PropertyOffset_Min;

	// Token: 0x04000808 RID: 2056
	private static int __PropertyOffset_Max;

	// Token: 0x04000809 RID: 2057
	private static int __PropertyOffset_IntValueArray;

	// Token: 0x0400080A RID: 2058
	[Nullable(2)]
	private TArray<int> _IntValueArray;

	// Token: 0x0400080B RID: 2059
	private static int __PropertyOffset_IntWeightArray;

	// Token: 0x0400080C RID: 2060
	[Nullable(2)]
	private TArray<int> _IntWeightArray;

	// Token: 0x0400080D RID: 2061
	private static int __PropertyOffset_BlackboardKeyWriteTo;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000012 RID: 18
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Composite/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Composite/TsCompositeIfBlackboardIntCompare.TsCompositeIfBlackboardIntCompare_C")]
public class TsCompositeIfBlackboardIntCompare : UBTComposite_If, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00002057 File Offset: 0x00000257
	// (set) Token: 0x06000021 RID: 33 RVA: 0x0000206B File Offset: 0x0000026B
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsCompositeIfBlackboardIntCompare.__PropertyOffset_BlackboardKey)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsCompositeIfBlackboardIntCompare.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00002080 File Offset: 0x00000280
	// (set) Token: 0x06000023 RID: 35 RVA: 0x00002094 File Offset: 0x00000294
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> Operation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCompositeIfBlackboardIntCompare.__PropertyOffset_Operation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCompositeIfBlackboardIntCompare.__PropertyOffset_Operation) = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000024 RID: 36 RVA: 0x000020A9 File Offset: 0x000002A9
	// (set) Token: 0x06000025 RID: 37 RVA: 0x000020B9 File Offset: 0x000002B9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsCompositeIfBlackboardIntCompare.__PropertyOffset_CompareValue);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsCompositeIfBlackboardIntCompare.__PropertyOffset_CompareValue) = value;
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000020CC File Offset: 0x000002CC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsOperation = this.Operation;
			this.TsCompareValue = this.CompareValue;
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002118 File Offset: 0x00000318
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
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
			return false;
		}
		CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
		if (charAiDesignComp == null)
		{
			return false;
		}
		this.InitTsVariables();
		int? num = null;
		CharacterStateMachineNewComponent component = charAiDesignComp.Entity.GetComponent<CharacterStateMachineNewComponent>();
		if (component != null)
		{
			AiStateMachineGroup stateMachineGroup = component.StateMachineGroup;
			num = ((stateMachineGroup != null) ? stateMachineGroup.GetCustomBlackboard(this.TsBlackboardKey) : null);
		}
		if (num == null)
		{
			num = BlackboardController.Instance.GetIntValueByEntity(charAiDesignComp.Entity.Id, this.TsBlackboardKey);
		}
		if (num == null)
		{
			num = new int?(0);
		}
		switch (this.TsOperation)
		{
		case EArithmeticKeyOperation.Equal:
		{
			int? num2 = num;
			int tsCompareValue = this.TsCompareValue;
			return num2.GetValueOrDefault() == tsCompareValue & num2 != null;
		}
		case EArithmeticKeyOperation.NotEqual:
		{
			int? num2 = num;
			int tsCompareValue = this.TsCompareValue;
			return !(num2.GetValueOrDefault() == tsCompareValue & num2 != null);
		}
		case EArithmeticKeyOperation.Less:
		{
			int? num2 = num;
			int tsCompareValue = this.TsCompareValue;
			return num2.GetValueOrDefault() < tsCompareValue & num2 != null;
		}
		case EArithmeticKeyOperation.LessOrEqual:
		{
			int? num2 = num;
			int tsCompareValue = this.TsCompareValue;
			return num2.GetValueOrDefault() <= tsCompareValue & num2 != null;
		}
		case EArithmeticKeyOperation.Greater:
		{
			int? num2 = num;
			int tsCompareValue = this.TsCompareValue;
			return num2.GetValueOrDefault() > tsCompareValue & num2 != null;
		}
		case EArithmeticKeyOperation.GreaterOrEqual:
		{
			int? num2 = num;
			int tsCompareValue = this.TsCompareValue;
			return num2.GetValueOrDefault() >= tsCompareValue & num2 != null;
		}
		default:
			return false;
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000022E2 File Offset: 0x000004E2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsCompositeIfBlackboardIntCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Composite/TsCompositeIfBlackboardIntCompare.TsCompositeIfBlackboardIntCompare_C");
		}
		return TsCompositeIfBlackboardIntCompare._ClassPtr;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002308 File Offset: 0x00000508
	public TsCompositeIfBlackboardIntCompare() : this(BuiltinUtils.AllocNativeUObject(TsCompositeIfBlackboardIntCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002330 File Offset: 0x00000530
	[NullableContext(1)]
	public TsCompositeIfBlackboardIntCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCompositeIfBlackboardIntCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002363 File Offset: 0x00000563
	protected TsCompositeIfBlackboardIntCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002378 File Offset: 0x00000578
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTComposite_If.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000007 RID: 7
	private bool IsInitTsVariables;

	// Token: 0x04000008 RID: 8
	[Nullable(1)]
	private string TsBlackboardKey = "";

	// Token: 0x04000009 RID: 9
	private EArithmeticKeyOperation TsOperation;

	// Token: 0x0400000A RID: 10
	private int TsCompareValue;

	// Token: 0x0400000B RID: 11
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Composite/TsCompositeIfBlackboardIntCompare.TsCompositeIfBlackboardIntCompare_C";

	// Token: 0x0400000C RID: 12
	private static IntPtr _ClassPtr;

	// Token: 0x0400000D RID: 13
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400000E RID: 14
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x0400000F RID: 15
	private static int __PropertyOffset_Operation;

	// Token: 0x04000010 RID: 16
	private static int __PropertyOffset_CompareValue;
}

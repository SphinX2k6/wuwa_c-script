using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000032 RID: 50
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardIntCompare.TsDecoratorBlackboardIntCompare_C")]
public class TsDecoratorBlackboardIntCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060001B8 RID: 440 RVA: 0x00008D27 File Offset: 0x00006F27
	// (set) Token: 0x060001B9 RID: 441 RVA: 0x00008D3B File Offset: 0x00006F3B
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardIntCompare.__PropertyOffset_BlackboardKey)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardIntCompare.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060001BA RID: 442 RVA: 0x00008D50 File Offset: 0x00006F50
	// (set) Token: 0x060001BB RID: 443 RVA: 0x00008D64 File Offset: 0x00006F64
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> Operation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardIntCompare.__PropertyOffset_Operation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardIntCompare.__PropertyOffset_Operation) = value;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060001BC RID: 444 RVA: 0x00008D79 File Offset: 0x00006F79
	// (set) Token: 0x060001BD RID: 445 RVA: 0x00008D89 File Offset: 0x00006F89
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardIntCompare.__PropertyOffset_CompareValue);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardIntCompare.__PropertyOffset_CompareValue) = value;
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00008D9C File Offset: 0x00006F9C
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

	// Token: 0x060001BF RID: 447 RVA: 0x00008DE8 File Offset: 0x00006FE8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00008E88 File Offset: 0x00007088
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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

	// Token: 0x060001C1 RID: 449 RVA: 0x0000904B File Offset: 0x0000724B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardIntCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardIntCompare.TsDecoratorBlackboardIntCompare_C");
		}
		return TsDecoratorBlackboardIntCompare._ClassPtr;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00009070 File Offset: 0x00007270
	public TsDecoratorBlackboardIntCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardIntCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00009098 File Offset: 0x00007298
	[NullableContext(1)]
	public TsDecoratorBlackboardIntCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardIntCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x000090CB File Offset: 0x000072CB
	protected TsDecoratorBlackboardIntCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x000090E0 File Offset: 0x000072E0
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000126 RID: 294
	private bool IsInitTsVariables;

	// Token: 0x04000127 RID: 295
	[Nullable(1)]
	private string TsBlackboardKey = "";

	// Token: 0x04000128 RID: 296
	private EArithmeticKeyOperation TsOperation;

	// Token: 0x04000129 RID: 297
	private int TsCompareValue;

	// Token: 0x0400012A RID: 298
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardIntCompare.TsDecoratorBlackboardIntCompare_C";

	// Token: 0x0400012B RID: 299
	private static IntPtr _ClassPtr;

	// Token: 0x0400012C RID: 300
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400012D RID: 301
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x0400012E RID: 302
	private static int __PropertyOffset_Operation;

	// Token: 0x0400012F RID: 303
	private static int __PropertyOffset_CompareValue;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000030 RID: 48
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardFloatCompare.TsDecoratorBlackboardFloatCompare_C")]
public class TsDecoratorBlackboardFloatCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600019E RID: 414 RVA: 0x000084A7 File Offset: 0x000066A7
	// (set) Token: 0x0600019F RID: 415 RVA: 0x000084BB File Offset: 0x000066BB
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardFloatCompare.__PropertyOffset_BlackboardKey)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardFloatCompare.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x000084D0 File Offset: 0x000066D0
	// (set) Token: 0x060001A1 RID: 417 RVA: 0x000084E4 File Offset: 0x000066E4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> Operation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardFloatCompare.__PropertyOffset_Operation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardFloatCompare.__PropertyOffset_Operation) = value;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x000084F9 File Offset: 0x000066F9
	// (set) Token: 0x060001A3 RID: 419 RVA: 0x00008509 File Offset: 0x00006709
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardFloatCompare.__PropertyOffset_CompareValue);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardFloatCompare.__PropertyOffset_CompareValue) = value;
		}
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0000851C File Offset: 0x0000671C
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

	// Token: 0x060001A5 RID: 421 RVA: 0x00008568 File Offset: 0x00006768
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

	// Token: 0x060001A6 RID: 422 RVA: 0x00008608 File Offset: 0x00006808
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
		float? floatValueByEntity = BlackboardController.Instance.GetFloatValueByEntity(charAiDesignComp.Entity.Id, this.TsBlackboardKey);
		if (floatValueByEntity == null)
		{
			floatValueByEntity = new float?(0f);
		}
		switch (this.TsOperation)
		{
		case EArithmeticKeyOperation.Equal:
		{
			float? num = floatValueByEntity;
			float tsCompareValue = this.TsCompareValue;
			return num.GetValueOrDefault() == tsCompareValue & num != null;
		}
		case EArithmeticKeyOperation.NotEqual:
		{
			float? num = floatValueByEntity;
			float tsCompareValue = this.TsCompareValue;
			return !(num.GetValueOrDefault() == tsCompareValue & num != null);
		}
		case EArithmeticKeyOperation.Less:
		{
			float? num = floatValueByEntity;
			float tsCompareValue = this.TsCompareValue;
			return num.GetValueOrDefault() < tsCompareValue & num != null;
		}
		case EArithmeticKeyOperation.LessOrEqual:
		{
			float? num = floatValueByEntity;
			float tsCompareValue = this.TsCompareValue;
			return num.GetValueOrDefault() <= tsCompareValue & num != null;
		}
		case EArithmeticKeyOperation.Greater:
		{
			float? num = floatValueByEntity;
			float tsCompareValue = this.TsCompareValue;
			return num.GetValueOrDefault() > tsCompareValue & num != null;
		}
		case EArithmeticKeyOperation.GreaterOrEqual:
		{
			float? num = floatValueByEntity;
			float tsCompareValue = this.TsCompareValue;
			return num.GetValueOrDefault() >= tsCompareValue & num != null;
		}
		default:
			return false;
		}
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0000878D File Offset: 0x0000698D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardFloatCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardFloatCompare.TsDecoratorBlackboardFloatCompare_C");
		}
		return TsDecoratorBlackboardFloatCompare._ClassPtr;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000087B4 File Offset: 0x000069B4
	public TsDecoratorBlackboardFloatCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardFloatCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000087DC File Offset: 0x000069DC
	[NullableContext(1)]
	public TsDecoratorBlackboardFloatCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardFloatCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x0000880F File Offset: 0x00006A0F
	protected TsDecoratorBlackboardFloatCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00008824 File Offset: 0x00006A24
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000114 RID: 276
	private bool IsInitTsVariables;

	// Token: 0x04000115 RID: 277
	[Nullable(1)]
	private string TsBlackboardKey = "";

	// Token: 0x04000116 RID: 278
	private EArithmeticKeyOperation TsOperation;

	// Token: 0x04000117 RID: 279
	private float TsCompareValue;

	// Token: 0x04000118 RID: 280
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardFloatCompare.TsDecoratorBlackboardFloatCompare_C";

	// Token: 0x04000119 RID: 281
	private static IntPtr _ClassPtr;

	// Token: 0x0400011A RID: 282
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400011B RID: 283
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x0400011C RID: 284
	private static int __PropertyOffset_Operation;

	// Token: 0x0400011D RID: 285
	private static int __PropertyOffset_CompareValue;
}

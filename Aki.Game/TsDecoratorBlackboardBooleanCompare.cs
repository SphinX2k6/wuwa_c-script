using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200002E RID: 46
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardBooleanCompare.TsDecoratorBlackboardBooleanCompare_C")]
public class TsDecoratorBlackboardBooleanCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000184 RID: 388 RVA: 0x00007DA3 File Offset: 0x00005FA3
	// (set) Token: 0x06000185 RID: 389 RVA: 0x00007DB7 File Offset: 0x00005FB7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardBooleanCompare.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardBooleanCompare.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000186 RID: 390 RVA: 0x00007DCC File Offset: 0x00005FCC
	// (set) Token: 0x06000187 RID: 391 RVA: 0x00007DDC File Offset: 0x00005FDC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardBooleanCompare.__PropertyOffset_CompareValue) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardBooleanCompare.__PropertyOffset_CompareValue) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00007DED File Offset: 0x00005FED
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsCompareValue = this.CompareValue;
		}
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00007E20 File Offset: 0x00006020
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

	// Token: 0x0600018A RID: 394 RVA: 0x00007EC0 File Offset: 0x000060C0
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
		if (BlackboardController.Instance.GetBooleanValueByEntity(charAiDesignComp.Entity.Id, this.TsBlackboardKey).GetValueOrDefault())
		{
			return this.TsCompareValue;
		}
		return !this.TsCompareValue;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00007F59 File Offset: 0x00006159
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardBooleanCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardBooleanCompare.TsDecoratorBlackboardBooleanCompare_C");
		}
		return TsDecoratorBlackboardBooleanCompare._ClassPtr;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00007F80 File Offset: 0x00006180
	public TsDecoratorBlackboardBooleanCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardBooleanCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00007FA8 File Offset: 0x000061A8
	public TsDecoratorBlackboardBooleanCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardBooleanCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00007FDB File Offset: 0x000061DB
	protected TsDecoratorBlackboardBooleanCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00007FF0 File Offset: 0x000061F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000FF RID: 255
	private bool IsInitTsVariables;

	// Token: 0x04000100 RID: 256
	private string TsBlackboardKey = "";

	// Token: 0x04000101 RID: 257
	private bool TsCompareValue;

	// Token: 0x04000102 RID: 258
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardBooleanCompare.TsDecoratorBlackboardBooleanCompare_C";

	// Token: 0x04000103 RID: 259
	private static IntPtr _ClassPtr;

	// Token: 0x04000104 RID: 260
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000105 RID: 261
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x04000106 RID: 262
	private static int __PropertyOffset_CompareValue;
}

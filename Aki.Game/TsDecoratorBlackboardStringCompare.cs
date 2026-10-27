using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000033 RID: 51
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardStringCompare.TsDecoratorBlackboardStringCompare_C")]
public class TsDecoratorBlackboardStringCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060001C6 RID: 454 RVA: 0x00009113 File Offset: 0x00007313
	// (set) Token: 0x060001C7 RID: 455 RVA: 0x00009127 File Offset: 0x00007327
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000913C File Offset: 0x0000733C
	// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000914C File Offset: 0x0000734C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Positive
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_Positive) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_Positive) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060001CA RID: 458 RVA: 0x0000915D File Offset: 0x0000735D
	// (set) Token: 0x060001CB RID: 459 RVA: 0x0000916D File Offset: 0x0000736D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Exactly
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_Exactly) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_Exactly) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060001CC RID: 460 RVA: 0x0000917E File Offset: 0x0000737E
	// (set) Token: 0x060001CD RID: 461 RVA: 0x00009192 File Offset: 0x00007392
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CompareValue
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_CompareValue)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardStringCompare.__PropertyOffset_CompareValue)), value);
		}
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000091A8 File Offset: 0x000073A8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsPositive = this.Positive;
			this.TsExactly = this.Exactly;
			this.TsCompareValue = this.CompareValue;
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000091FC File Offset: 0x000073FC
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

	// Token: 0x060001D0 RID: 464 RVA: 0x0000929C File Offset: 0x0000749C
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
		string stringValueByEntity = BlackboardController.Instance.GetStringValueByEntity(charAiDesignComp.Entity.Id, this.TsBlackboardKey);
		return (this.TsExactly ? (stringValueByEntity == this.TsCompareValue) : stringValueByEntity.Contains(this.TsCompareValue)) == this.TsPositive;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00009346 File Offset: 0x00007546
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardStringCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardStringCompare.TsDecoratorBlackboardStringCompare_C");
		}
		return TsDecoratorBlackboardStringCompare._ClassPtr;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000936C File Offset: 0x0000756C
	public TsDecoratorBlackboardStringCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardStringCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00009394 File Offset: 0x00007594
	public TsDecoratorBlackboardStringCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardStringCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000093C7 File Offset: 0x000075C7
	protected TsDecoratorBlackboardStringCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000093E8 File Offset: 0x000075E8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000130 RID: 304
	private bool IsInitTsVariables;

	// Token: 0x04000131 RID: 305
	private string TsBlackboardKey = "";

	// Token: 0x04000132 RID: 306
	private bool TsPositive;

	// Token: 0x04000133 RID: 307
	private bool TsExactly;

	// Token: 0x04000134 RID: 308
	private string TsCompareValue = "";

	// Token: 0x04000135 RID: 309
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardStringCompare.TsDecoratorBlackboardStringCompare_C";

	// Token: 0x04000136 RID: 310
	private static IntPtr _ClassPtr;

	// Token: 0x04000137 RID: 311
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000138 RID: 312
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x04000139 RID: 313
	private static int __PropertyOffset_Positive;

	// Token: 0x0400013A RID: 314
	private static int __PropertyOffset_Exactly;

	// Token: 0x0400013B RID: 315
	private static int __PropertyOffset_CompareValue;
}

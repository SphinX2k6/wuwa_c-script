using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200004B RID: 75
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorNowTimeCompare.TsDecoratorNowTimeCompare_C")]
public class TsDecoratorNowTimeCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000D697 File Offset: 0x0000B897
	// (set) Token: 0x060002CA RID: 714 RVA: 0x0000D6AB File Offset: 0x0000B8AB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorNowTimeCompare.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorNowTimeCompare.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060002CB RID: 715 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
	// (set) Token: 0x060002CC RID: 716 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsGreaterThan
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorNowTimeCompare.__PropertyOffset_IsGreaterThan) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorNowTimeCompare.__PropertyOffset_IsGreaterThan) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060002CD RID: 717 RVA: 0x0000D6E1 File Offset: 0x0000B8E1
	// (set) Token: 0x060002CE RID: 718 RVA: 0x0000D6F1 File Offset: 0x0000B8F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorNowTimeCompare.__PropertyOffset_CompareValue);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorNowTimeCompare.__PropertyOffset_CompareValue) = value;
		}
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000D702 File Offset: 0x0000B902
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsIsGreaterThan = this.IsGreaterThan;
			this.TsCompareValue = this.CompareValue;
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000D740 File Offset: 0x0000B940
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorNowTimeCompare) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorNowTimeCompare.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (this.TsBlackboardKey == "")
		{
			return false;
		}
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
		int id = aiController.CharActorComp.Entity.Id;
		double worldTime = Time.Instance.WorldTime;
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(id, this.TsBlackboardKey);
		if (intValueByEntity == null)
		{
			return true;
		}
		double num = worldTime;
		int? num2 = intValueByEntity;
		double? num3 = num - ((num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null);
		double? num5;
		if (!this.TsIsGreaterThan)
		{
			double num4 = (double)this.TsCompareValue;
			num5 = num3;
			return num4 > num5.GetValueOrDefault() & num5 != null;
		}
		num5 = num3;
		num = (double)this.TsCompareValue;
		return num5.GetValueOrDefault() > num & num5 != null;
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000D932 File Offset: 0x0000BB32
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorNowTimeCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorNowTimeCompare.TsDecoratorNowTimeCompare_C");
		}
		return TsDecoratorNowTimeCompare._ClassPtr;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000D958 File Offset: 0x0000BB58
	public TsDecoratorNowTimeCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorNowTimeCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000D980 File Offset: 0x0000BB80
	public TsDecoratorNowTimeCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorNowTimeCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000D9B3 File Offset: 0x0000BBB3
	protected TsDecoratorNowTimeCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001D3 RID: 467
	private bool IsInitTsVariables;

	// Token: 0x040001D4 RID: 468
	private string TsBlackboardKey = "";

	// Token: 0x040001D5 RID: 469
	private bool TsIsGreaterThan;

	// Token: 0x040001D6 RID: 470
	private int TsCompareValue;

	// Token: 0x040001D7 RID: 471
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorNowTimeCompare.TsDecoratorNowTimeCompare_C";

	// Token: 0x040001D8 RID: 472
	private static IntPtr _ClassPtr;

	// Token: 0x040001D9 RID: 473
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001DA RID: 474
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x040001DB RID: 475
	private static int __PropertyOffset_IsGreaterThan;

	// Token: 0x040001DC RID: 476
	private static int __PropertyOffset_CompareValue;
}

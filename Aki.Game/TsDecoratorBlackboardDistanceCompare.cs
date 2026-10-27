using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200002F RID: 47
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardDistanceCompare.TsDecoratorBlackboardDistanceCompare_C")]
public class TsDecoratorBlackboardDistanceCompare : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000190 RID: 400 RVA: 0x00008023 File Offset: 0x00006223
	// (set) Token: 0x06000191 RID: 401 RVA: 0x00008037 File Offset: 0x00006237
	[Nullable(0)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> CompareType
	{
		[NullableContext(0)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardDistanceCompare.__PropertyOffset_CompareType);
		}
		[NullableContext(0)]
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardDistanceCompare.__PropertyOffset_CompareType) = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000192 RID: 402 RVA: 0x0000804C File Offset: 0x0000624C
	// (set) Token: 0x06000193 RID: 403 RVA: 0x00008060 File Offset: 0x00006260
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string OtherLocationKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardDistanceCompare.__PropertyOffset_OtherLocationKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardDistanceCompare.__PropertyOffset_OtherLocationKey)), value);
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000194 RID: 404 RVA: 0x00008075 File Offset: 0x00006275
	// (set) Token: 0x06000195 RID: 405 RVA: 0x00008085 File Offset: 0x00006285
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardDistanceCompare.__PropertyOffset_CompareValue);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardDistanceCompare.__PropertyOffset_CompareValue) = value;
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00008098 File Offset: 0x00006298
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCompareType = this.CompareType;
			this.TsOtherLocationKey = this.OtherLocationKey;
			this.TsCompareValue = this.CompareValue;
			this.LocationCache = global::Vector.Create();
			this.OtherLocationCache = global::Vector.Create();
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x000080FC File Offset: 0x000062FC
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

	// Token: 0x06000198 RID: 408 RVA: 0x0000819C File Offset: 0x0000639C
	[NullableContext(2)]
	protected unsafe virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if ((ownerController as TsAiController).AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Entity entity = (ownerController as TsAiController).GetEntity();
		if (!entity)
		{
			return false;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp = (ownerController as TsAiController).AiController.CharActorComp;
		this.LocationCache.DeepCopy(charActorComp.ActorLocationProxy);
		if (this.TsOtherLocationKey != "")
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(entity.Id, this.TsOtherLocationKey);
			if (vectorValueByEntity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.CJH;
				string message2 = "不存在BlackboardKey";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.TsOtherLocationKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tree", base.TreeAsset);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			this.OtherLocationCache.DeepCopy(vectorValueByEntity);
		}
		else
		{
			Aki.Protocol.Vector initLocation = charActorComp.CreatureData.GetInitLocation();
			if (initLocation == null)
			{
				return false;
			}
			this.OtherLocationCache.DeepCopy(initLocation);
		}
		if (this.LocationCache == null || this.OtherLocationCache == null)
		{
			return false;
		}
		double num = global::Vector.DistSquared(this.LocationCache, this.OtherLocationCache);
		float num2 = this.TsCompareValue * this.TsCompareValue;
		switch (this.TsCompareType)
		{
		case EArithmeticKeyOperation.Equal:
			return Math.Abs(num - (double)num2) <= 10.0;
		case EArithmeticKeyOperation.NotEqual:
			return Math.Abs(num - (double)num2) > 10.0;
		case EArithmeticKeyOperation.Less:
			return num < (double)num2;
		case EArithmeticKeyOperation.LessOrEqual:
			return num <= (double)num2;
		case EArithmeticKeyOperation.Greater:
			return num > (double)num2;
		case EArithmeticKeyOperation.GreaterOrEqual:
			return num >= (double)num2;
		default:
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.CJH;
			string message3 = "不支持的比较类型";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		}
	}

	// Token: 0x06000199 RID: 409 RVA: 0x000083C5 File Offset: 0x000065C5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardDistanceCompare._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardDistanceCompare.TsDecoratorBlackboardDistanceCompare_C");
		}
		return TsDecoratorBlackboardDistanceCompare._ClassPtr;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x000083EC File Offset: 0x000065EC
	public TsDecoratorBlackboardDistanceCompare() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardDistanceCompare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00008414 File Offset: 0x00006614
	public TsDecoratorBlackboardDistanceCompare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardDistanceCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00008447 File Offset: 0x00006647
	protected TsDecoratorBlackboardDistanceCompare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00008474 File Offset: 0x00006674
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000107 RID: 263
	private const float MAX_ERROR = 10f;

	// Token: 0x04000108 RID: 264
	private global::Vector LocationCache = global::Vector.Create();

	// Token: 0x04000109 RID: 265
	private global::Vector OtherLocationCache = global::Vector.Create();

	// Token: 0x0400010A RID: 266
	private bool IsInitTsVariables;

	// Token: 0x0400010B RID: 267
	private EArithmeticKeyOperation TsCompareType;

	// Token: 0x0400010C RID: 268
	private string TsOtherLocationKey = "";

	// Token: 0x0400010D RID: 269
	private float TsCompareValue;

	// Token: 0x0400010E RID: 270
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardDistanceCompare.TsDecoratorBlackboardDistanceCompare_C";

	// Token: 0x0400010F RID: 271
	private static IntPtr _ClassPtr;

	// Token: 0x04000110 RID: 272
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000111 RID: 273
	private static int __PropertyOffset_CompareType;

	// Token: 0x04000112 RID: 274
	private static int __PropertyOffset_OtherLocationKey;

	// Token: 0x04000113 RID: 275
	private static int __PropertyOffset_CompareValue;
}

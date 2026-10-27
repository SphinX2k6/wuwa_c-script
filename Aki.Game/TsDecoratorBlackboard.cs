using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200002C RID: 44
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboard.TsDecoratorBlackboard_C")]
public class TsDecoratorBlackboard : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600015B RID: 347 RVA: 0x00007313 File Offset: 0x00005513
	// (set) Token: 0x0600015C RID: 348 RVA: 0x00007327 File Offset: 0x00005527
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboard.__PropertyOffset_BlackboardKeyName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboard.__PropertyOffset_BlackboardKeyName)), value);
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600015D RID: 349 RVA: 0x0000733C File Offset: 0x0000553C
	// (set) Token: 0x0600015E RID: 350 RVA: 0x0000734C File Offset: 0x0000554C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsSet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboard.__PropertyOffset_IsSet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboard.__PropertyOffset_IsSet) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0000735D File Offset: 0x0000555D
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyName = this.BlackboardKeyName;
			this.TsIsSet = this.IsSet;
		}
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00007390 File Offset: 0x00005590
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

	// Token: 0x06000161 RID: 353 RVA: 0x00007430 File Offset: 0x00005630
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
		this.InitTsVariables();
		bool flag = BlackboardController.Instance.HasValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyName);
		return this.TsIsSet == flag;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x000074B1 File Offset: 0x000056B1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboard.TsDecoratorBlackboard_C");
		}
		return TsDecoratorBlackboard._ClassPtr;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x000074D8 File Offset: 0x000056D8
	public TsDecoratorBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00007500 File Offset: 0x00005700
	public TsDecoratorBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00007533 File Offset: 0x00005733
	protected TsDecoratorBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00007548 File Offset: 0x00005748
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000DA RID: 218
	private bool IsInitTsVariables;

	// Token: 0x040000DB RID: 219
	private string TsBlackboardKeyName = "";

	// Token: 0x040000DC RID: 220
	private bool TsIsSet;

	// Token: 0x040000DD RID: 221
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboard.TsDecoratorBlackboard_C";

	// Token: 0x040000DE RID: 222
	private static IntPtr _ClassPtr;

	// Token: 0x040000DF RID: 223
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040000E0 RID: 224
	private static int __PropertyOffset_BlackboardKeyName;

	// Token: 0x040000E1 RID: 225
	private static int __PropertyOffset_IsSet;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200003C RID: 60
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckPlayerNetHealthy.TsDecoratorCheckPlayerNetHealthy_C")]
public class TsDecoratorCheckPlayerNetHealthy : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000231 RID: 561 RVA: 0x0000ABC0 File Offset: 0x00008DC0
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

	// Token: 0x06000232 RID: 562 RVA: 0x0000AC60 File Offset: 0x00008E60
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
		int playerId = aiController.CharAiDesignComp.Entity.GetComponent<CreatureDataComponent>().GetPlayerId();
		return OnlineController.Instance.CheckPlayerNetHealthy(playerId);
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000ACD2 File Offset: 0x00008ED2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckPlayerNetHealthy._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckPlayerNetHealthy.TsDecoratorCheckPlayerNetHealthy_C");
		}
		return TsDecoratorCheckPlayerNetHealthy._ClassPtr;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000ACF8 File Offset: 0x00008EF8
	public TsDecoratorCheckPlayerNetHealthy() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckPlayerNetHealthy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0000AD20 File Offset: 0x00008F20
	[NullableContext(1)]
	public TsDecoratorCheckPlayerNetHealthy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckPlayerNetHealthy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000AD53 File Offset: 0x00008F53
	protected TsDecoratorCheckPlayerNetHealthy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000AD5C File Offset: 0x00008F5C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000176 RID: 374
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckPlayerNetHealthy.TsDecoratorCheckPlayerNetHealthy_C";

	// Token: 0x04000177 RID: 375
	private static IntPtr _ClassPtr;

	// Token: 0x04000178 RID: 376
	private static IntPtr _ClassDefaultObjectPtr;
}

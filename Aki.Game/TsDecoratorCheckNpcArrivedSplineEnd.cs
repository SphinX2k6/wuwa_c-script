using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200001A RID: 26
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckNpcArrivedSplineEnd.TsDecoratorCheckNpcArrivedSplineEnd_C")]
public class TsDecoratorCheckNpcArrivedSplineEnd : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000085 RID: 133 RVA: 0x00003D34 File Offset: 0x00001F34
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

	// Token: 0x06000086 RID: 134 RVA: 0x00003DD4 File Offset: 0x00001FD4
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		return charActorComp != null && NpcVehicleRiderController.Instance.GetNpcVehicleRideState(charActorComp.Entity.Id) == ENpcVehicleRideState.WaitingToDismount;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00003E4A File Offset: 0x0000204A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckNpcArrivedSplineEnd._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckNpcArrivedSplineEnd.TsDecoratorCheckNpcArrivedSplineEnd_C");
		}
		return TsDecoratorCheckNpcArrivedSplineEnd._ClassPtr;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00003E70 File Offset: 0x00002070
	public TsDecoratorCheckNpcArrivedSplineEnd() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedSplineEnd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00003E98 File Offset: 0x00002098
	[NullableContext(1)]
	public TsDecoratorCheckNpcArrivedSplineEnd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedSplineEnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00003ECB File Offset: 0x000020CB
	protected TsDecoratorCheckNpcArrivedSplineEnd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00003ED4 File Offset: 0x000020D4
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400004D RID: 77
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckNpcArrivedSplineEnd.TsDecoratorCheckNpcArrivedSplineEnd_C";

	// Token: 0x0400004E RID: 78
	private static IntPtr _ClassPtr;

	// Token: 0x0400004F RID: 79
	private static IntPtr _ClassDefaultObjectPtr;
}

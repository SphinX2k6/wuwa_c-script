using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200001E RID: 30
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckVehicleHasRouteSpline.TsDecoratorCheckVehicleHasRouteSpline_C")]
public class TsDecoratorCheckVehicleHasRouteSpline : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00004490 File Offset: 0x00002690
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

	// Token: 0x060000A2 RID: 162 RVA: 0x00004530 File Offset: 0x00002730
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
		return charActorComp != null && NpcVehicleRiderController.Instance.HasAvailableRouteSpline(charActorComp.Entity.Id);
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000045A3 File Offset: 0x000027A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckVehicleHasRouteSpline._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckVehicleHasRouteSpline.TsDecoratorCheckVehicleHasRouteSpline_C");
		}
		return TsDecoratorCheckVehicleHasRouteSpline._ClassPtr;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000045C8 File Offset: 0x000027C8
	public TsDecoratorCheckVehicleHasRouteSpline() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleHasRouteSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000045F0 File Offset: 0x000027F0
	[NullableContext(1)]
	public TsDecoratorCheckVehicleHasRouteSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleHasRouteSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00004623 File Offset: 0x00002823
	protected TsDecoratorCheckVehicleHasRouteSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000462C File Offset: 0x0000282C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000059 RID: 89
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckVehicleHasRouteSpline.TsDecoratorCheckVehicleHasRouteSpline_C";

	// Token: 0x0400005A RID: 90
	private static IntPtr _ClassPtr;

	// Token: 0x0400005B RID: 91
	private static IntPtr _ClassDefaultObjectPtr;
}

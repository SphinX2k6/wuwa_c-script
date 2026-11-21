using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000020 RID: 32
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckVehicleWaiting.TsDecoratorCheckVehicleWaiting_C")]
public class TsDecoratorCheckVehicleWaiting : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000AF RID: 175 RVA: 0x0000497B File Offset: 0x00002B7B
	// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000498B File Offset: 0x00002B8B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float VehicleWaitState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckVehicleWaiting.__PropertyOffset_VehicleWaitState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckVehicleWaiting.__PropertyOffset_VehicleWaitState) = value;
		}
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000499C File Offset: 0x00002B9C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckVehicleWaiting) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckVehicleWaiting.StaticClass(), out intPtr, out num))
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

	// Token: 0x060000B2 RID: 178 RVA: 0x00004A54 File Offset: 0x00002C54
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (this.VehicleWaitState != 0f && this.VehicleWaitState != 1f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的VehicleWaitState值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", this.VehicleWaitState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "错误的Controller类型";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			return false;
		}
		int id = charActorComp.Entity.Id;
		return NpcVehicleRiderController.Instance.GetVehicleIsWaitingNpc(id, (int)this.VehicleWaitState);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00004B1E File Offset: 0x00002D1E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckVehicleWaiting._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckVehicleWaiting.TsDecoratorCheckVehicleWaiting_C");
		}
		return TsDecoratorCheckVehicleWaiting._ClassPtr;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00004B44 File Offset: 0x00002D44
	public TsDecoratorCheckVehicleWaiting() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleWaiting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00004B6C File Offset: 0x00002D6C
	[NullableContext(1)]
	public TsDecoratorCheckVehicleWaiting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleWaiting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00004B9F File Offset: 0x00002D9F
	protected TsDecoratorCheckVehicleWaiting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00004BA8 File Offset: 0x00002DA8
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400005F RID: 95
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckVehicleWaiting.TsDecoratorCheckVehicleWaiting_C";

	// Token: 0x04000060 RID: 96
	private static IntPtr _ClassPtr;

	// Token: 0x04000061 RID: 97
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000062 RID: 98
	private static int __PropertyOffset_VehicleWaitState;
}

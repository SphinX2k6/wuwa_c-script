using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000014 RID: 20
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Animal/TsDecoratorCheckAnimalState.TsDecoratorCheckAnimalState_C")]
public class TsDecoratorCheckAnimalState : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000036 RID: 54 RVA: 0x0000271B File Offset: 0x0000091B
	// (set) Token: 0x06000037 RID: 55 RVA: 0x0000272B File Offset: 0x0000092B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnimalEcologicalState State
	{
		get
		{
			return (EAnimalEcologicalState)(*(base.NativePtr + (IntPtr)TsDecoratorCheckAnimalState.__PropertyOffset_State));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckAnimalState.__PropertyOffset_State) = (byte)value;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000038 RID: 56 RVA: 0x0000273C File Offset: 0x0000093C
	// (set) Token: 0x06000039 RID: 57 RVA: 0x0000274C File Offset: 0x0000094C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Inverse
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckAnimalState.__PropertyOffset_Inverse) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckAnimalState.__PropertyOffset_Inverse) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000275D File Offset: 0x0000095D
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsState = this.State;
			this.TsInverse = this.Inverse;
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002790 File Offset: 0x00000990
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

	// Token: 0x0600003C RID: 60 RVA: 0x00002830 File Offset: 0x00000A30
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
		AnimalStateMachineComponent component = aiController.CharActorComp.Entity.GetComponent<AnimalStateMachineComponent>();
		if (this.TsInverse)
		{
			return component.CurrentState() != this.TsState;
		}
		return component.CurrentState() == this.TsState;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000028C0 File Offset: 0x00000AC0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckAnimalState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Animal/TsDecoratorCheckAnimalState.TsDecoratorCheckAnimalState_C");
		}
		return TsDecoratorCheckAnimalState._ClassPtr;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000028E4 File Offset: 0x00000AE4
	public TsDecoratorCheckAnimalState() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAnimalState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000290C File Offset: 0x00000B0C
	[NullableContext(1)]
	public TsDecoratorCheckAnimalState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAnimalState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000293F File Offset: 0x00000B3F
	protected TsDecoratorCheckAnimalState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002948 File Offset: 0x00000B48
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000016 RID: 22
	private bool IsInitTsVariables;

	// Token: 0x04000017 RID: 23
	private EAnimalEcologicalState TsState;

	// Token: 0x04000018 RID: 24
	private bool TsInverse;

	// Token: 0x04000019 RID: 25
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Animal/TsDecoratorCheckAnimalState.TsDecoratorCheckAnimalState_C";

	// Token: 0x0400001A RID: 26
	private static IntPtr _ClassPtr;

	// Token: 0x0400001B RID: 27
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400001C RID: 28
	private static int __PropertyOffset_State;

	// Token: 0x0400001D RID: 29
	private static int __PropertyOffset_Inverse;
}

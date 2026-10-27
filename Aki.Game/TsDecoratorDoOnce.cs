using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000022 RID: 34
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDoOnce.TsDecoratorDoOnce_C")]
public class TsDecoratorDoOnce : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000CD RID: 205 RVA: 0x00004F07 File Offset: 0x00003107
	// (set) Token: 0x060000CE RID: 206 RVA: 0x00004F1B File Offset: 0x0000311B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackBoardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorDoOnce.__PropertyOffset_BlackBoardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorDoOnce.__PropertyOffset_BlackBoardKey)), value);
		}
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00004F30 File Offset: 0x00003130
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

	// Token: 0x060000D0 RID: 208 RVA: 0x00004FD0 File Offset: 0x000031D0
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = (charActorComp != null) ? charActorComp.Entity : null;
		if (!entity)
		{
			return false;
		}
		if (this.HasDone)
		{
			return false;
		}
		this.HasDone = BlackboardController.Instance.GetBooleanValueByEntity(entity.Id, this.BlackBoardKey).GetValueOrDefault();
		if (this.HasDone)
		{
			return false;
		}
		this.HasDone = true;
		BlackboardController.Instance.SetBooleanValueByEntity(entity.Id, this.BlackBoardKey, true);
		return true;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00005096 File Offset: 0x00003296
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorDoOnce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDoOnce.TsDecoratorDoOnce_C");
		}
		return TsDecoratorDoOnce._ClassPtr;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x000050BC File Offset: 0x000032BC
	public TsDecoratorDoOnce() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDoOnce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x000050E4 File Offset: 0x000032E4
	public TsDecoratorDoOnce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDoOnce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00005117 File Offset: 0x00003317
	protected TsDecoratorDoOnce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00005120 File Offset: 0x00003320
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000077 RID: 119
	private bool HasDone;

	// Token: 0x04000078 RID: 120
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDoOnce.TsDecoratorDoOnce_C";

	// Token: 0x04000079 RID: 121
	private static IntPtr _ClassPtr;

	// Token: 0x0400007A RID: 122
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400007B RID: 123
	private static int __PropertyOffset_BlackBoardKey;
}

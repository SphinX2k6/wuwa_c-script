using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000051 RID: 81
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorTagCount.TsDecoratorTagCount_C")]
public class TsDecoratorTagCount : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000314 RID: 788 RVA: 0x0000E3EB File Offset: 0x0000C5EB
	// (set) Token: 0x06000315 RID: 789 RVA: 0x0000E3FF File Offset: 0x0000C5FF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTarget
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorTagCount.__PropertyOffset_BlackboardKeyTarget)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorTagCount.__PropertyOffset_BlackboardKeyTarget)), value);
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000316 RID: 790 RVA: 0x0000E414 File Offset: 0x0000C614
	// (set) Token: 0x06000317 RID: 791 RVA: 0x0000E428 File Offset: 0x0000C628
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorTagCount.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorTagCount.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000318 RID: 792 RVA: 0x0000E43D File Offset: 0x0000C63D
	// (set) Token: 0x06000319 RID: 793 RVA: 0x0000E451 File Offset: 0x0000C651
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange Range
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorTagCount.__PropertyOffset_Range);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorTagCount.__PropertyOffset_Range) = value;
		}
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0000E468 File Offset: 0x0000C668
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyTarget = this.BlackboardKeyTarget;
			this.TsTag = new FGameplayTag?(this.Tag);
			this.TsRange = new FastUeFloatRange(this.Range);
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0000E4BC File Offset: 0x0000C6BC
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

	// Token: 0x0600031C RID: 796 RVA: 0x0000E55C File Offset: 0x0000C75C
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
		CharacterActorComponent characterActorComponent = aiController.CharActorComp;
		if (this.TsBlackboardKeyTarget != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyTarget);
			if (entityIdByEntity == null)
			{
				return false;
			}
			CharacterActorComponent characterActorComponentById = CharacterController.Instance.GetCharacterActorComponentById(entityIdByEntity.Value);
			if (characterActorComponentById == null)
			{
				return false;
			}
			characterActorComponent = characterActorComponentById;
		}
		int tagCount = characterActorComponent.Entity.CheckGetComponent<BaseTagComponent>().GetTagCount(this.TsTag.Value.TagId());
		return MathUtils.Instance.InFastUeRange((double)tagCount, this.TsRange);
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000E64B File Offset: 0x0000C84B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorTagCount._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorTagCount.TsDecoratorTagCount_C");
		}
		return TsDecoratorTagCount._ClassPtr;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0000E670 File Offset: 0x0000C870
	public TsDecoratorTagCount() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCount.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0000E698 File Offset: 0x0000C898
	public TsDecoratorTagCount(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0000E6CB File Offset: 0x0000C8CB
	protected TsDecoratorTagCount(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000206 RID: 518
	private bool IsInitTsVariables;

	// Token: 0x04000207 RID: 519
	private string TsBlackboardKeyTarget;

	// Token: 0x04000208 RID: 520
	private FGameplayTag? TsTag;

	// Token: 0x04000209 RID: 521
	[Nullable(2)]
	private FastUeFloatRange TsRange;

	// Token: 0x0400020A RID: 522
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorTagCount.TsDecoratorTagCount_C";

	// Token: 0x0400020B RID: 523
	private static IntPtr _ClassPtr;

	// Token: 0x0400020C RID: 524
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400020D RID: 525
	private static int __PropertyOffset_BlackboardKeyTarget;

	// Token: 0x0400020E RID: 526
	private static int __PropertyOffset_Tag;

	// Token: 0x0400020F RID: 527
	private static int __PropertyOffset_Range;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200003D RID: 61
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckSkillUsable.TsDecoratorCheckSkillUsable_C")]
public class TsDecoratorCheckSkillUsable : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000238 RID: 568 RVA: 0x0000AD8F File Offset: 0x00008F8F
	// (set) Token: 0x06000239 RID: 569 RVA: 0x0000AD9F File Offset: 0x00008F9F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckSkillUsable.__PropertyOffset_SkillId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckSkillUsable.__PropertyOffset_SkillId) = value;
		}
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000ADB0 File Offset: 0x00008FB0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSkillId = this.SkillId;
		}
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000ADD4 File Offset: 0x00008FD4
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

	// Token: 0x0600023C RID: 572 RVA: 0x0000AE74 File Offset: 0x00009074
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.InitTsVariables();
		CharacterSkillComponent component = aiController.CharAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		return component != null && component.Valid && component.IsCanUseSkill(this.TsSkillId);
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000AF02 File Offset: 0x00009102
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckSkillUsable._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckSkillUsable.TsDecoratorCheckSkillUsable_C");
		}
		return TsDecoratorCheckSkillUsable._ClassPtr;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000AF28 File Offset: 0x00009128
	public TsDecoratorCheckSkillUsable() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckSkillUsable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000AF50 File Offset: 0x00009150
	[NullableContext(1)]
	public TsDecoratorCheckSkillUsable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckSkillUsable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000AF83 File Offset: 0x00009183
	protected TsDecoratorCheckSkillUsable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000AF8C File Offset: 0x0000918C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000179 RID: 377
	private bool IsInitTsVariables;

	// Token: 0x0400017A RID: 378
	private int TsSkillId;

	// Token: 0x0400017B RID: 379
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckSkillUsable.TsDecoratorCheckSkillUsable_C";

	// Token: 0x0400017C RID: 380
	private static IntPtr _ClassPtr;

	// Token: 0x0400017D RID: 381
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400017E RID: 382
	private static int __PropertyOffset_SkillId;
}

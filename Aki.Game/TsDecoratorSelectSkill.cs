using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200004E RID: 78
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorSelectSkill.TsDecoratorSelectSkill_C")]
public class TsDecoratorSelectSkill : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060002EF RID: 751 RVA: 0x0000DE97 File Offset: 0x0000C097
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000DEA7 File Offset: 0x0000C0A7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorSelectSkill.__PropertyOffset_SkillType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorSelectSkill.__PropertyOffset_SkillType) = value;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
	// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugLog
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorSelectSkill.__PropertyOffset_DebugLog) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorSelectSkill.__PropertyOffset_DebugLog) = (value ? 1 : 0);
		}
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000DED9 File Offset: 0x0000C0D9
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSkillType = this.SkillType;
			this.TsDebugLog = this.DebugLog;
		}
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0000DF0C File Offset: 0x0000C10C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorSelectSkill) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorSelectSkill.StaticClass(), out intPtr, out num))
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

	// Token: 0x060002F5 RID: 757 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
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
		if (aiController.AiSkill == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "没有配置技能";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		CharacterSkillComponent component = aiController.CharAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		if (!component.Valid)
		{
			return false;
		}
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		if (currentTarget != null && currentTarget.Valid)
		{
			return AiLibrary.SelectSkillWithTarget(aiController, component, currentTarget.Entity.GetComponent<CharacterActorComponent>(), this.TsSkillType, this.TsDebugLog);
		}
		return AiLibrary.SelectSkillWithoutTarget(aiController, component, this.TsSkillType);
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0000E0C2 File Offset: 0x0000C2C2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorSelectSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorSelectSkill.TsDecoratorSelectSkill_C");
		}
		return TsDecoratorSelectSkill._ClassPtr;
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
	public TsDecoratorSelectSkill() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSelectSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0000E110 File Offset: 0x0000C310
	[NullableContext(1)]
	public TsDecoratorSelectSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorSelectSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0000E143 File Offset: 0x0000C343
	protected TsDecoratorSelectSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0000E14C File Offset: 0x0000C34C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001EC RID: 492
	private bool IsInitTsVariables;

	// Token: 0x040001ED RID: 493
	private int TsSkillType;

	// Token: 0x040001EE RID: 494
	private bool TsDebugLog;

	// Token: 0x040001EF RID: 495
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorSelectSkill.TsDecoratorSelectSkill_C";

	// Token: 0x040001F0 RID: 496
	private static IntPtr _ClassPtr;

	// Token: 0x040001F1 RID: 497
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001F2 RID: 498
	private static int __PropertyOffset_SkillType;

	// Token: 0x040001F3 RID: 499
	private static int __PropertyOffset_DebugLog;
}

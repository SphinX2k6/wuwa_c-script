using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000034 RID: 52
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckAiNoMove.TsDecoratorCheckAiNoMove_C")]
public class TsDecoratorCheckAiNoMove : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060001D6 RID: 470 RVA: 0x00009757 File Offset: 0x00007957
	// (set) Token: 0x060001D7 RID: 471 RVA: 0x00009767 File Offset: 0x00007967
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckAiNoMove.__PropertyOffset_CheckTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckAiNoMove.__PropertyOffset_CheckTime) = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060001D8 RID: 472 RVA: 0x00009778 File Offset: 0x00007978
	// (set) Token: 0x060001D9 RID: 473 RVA: 0x00009788 File Offset: 0x00007988
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ShouldIgnoreNoMoveTimeWhenSitting
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckAiNoMove.__PropertyOffset_ShouldIgnoreNoMoveTimeWhenSitting) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckAiNoMove.__PropertyOffset_ShouldIgnoreNoMoveTimeWhenSitting) = (value ? 1 : 0);
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000979C File Offset: 0x0000799C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckTime = this.CheckTime * (float)TimeUtil.Instance.InverseMillisecond;
			this.TsResetConditionMask = (this.ShouldIgnoreNoMoveTimeWhenSitting ? EAiNoMoveResetCondition.SitOnChairTask : EAiNoMoveResetCondition.None);
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000097EC File Offset: 0x000079EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckAiNoMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckAiNoMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x060001DC RID: 476 RVA: 0x000098A4 File Offset: 0x00007AA4
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
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
		this.InitTsVariables();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			return false;
		}
		int id = charActorComp.Entity.Id;
		return IdlePerformModel.Instance.CheckAiNoMoveTime(id, this.TsCheckTime, this.TsResetConditionMask);
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00009941 File Offset: 0x00007B41
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckAiNoMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckAiNoMove.TsDecoratorCheckAiNoMove_C");
		}
		return TsDecoratorCheckAiNoMove._ClassPtr;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00009968 File Offset: 0x00007B68
	public TsDecoratorCheckAiNoMove() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAiNoMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00009990 File Offset: 0x00007B90
	[NullableContext(1)]
	public TsDecoratorCheckAiNoMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAiNoMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x000099C3 File Offset: 0x00007BC3
	protected TsDecoratorCheckAiNoMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x000099CC File Offset: 0x00007BCC
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400013C RID: 316
	private bool IsInitTsVariables;

	// Token: 0x0400013D RID: 317
	private float TsCheckTime;

	// Token: 0x0400013E RID: 318
	private EAiNoMoveResetCondition TsResetConditionMask;

	// Token: 0x0400013F RID: 319
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckAiNoMove.TsDecoratorCheckAiNoMove_C";

	// Token: 0x04000140 RID: 320
	private static IntPtr _ClassPtr;

	// Token: 0x04000141 RID: 321
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000142 RID: 322
	private static int __PropertyOffset_CheckTime;

	// Token: 0x04000143 RID: 323
	private static int __PropertyOffset_ShouldIgnoreNoMoveTimeWhenSitting;
}

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
	// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000941B File Offset: 0x0000761B
	// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000942B File Offset: 0x0000762B
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
	// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000943C File Offset: 0x0000763C
	// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000944C File Offset: 0x0000764C
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

	// Token: 0x060001DA RID: 474 RVA: 0x00009460 File Offset: 0x00007660
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckTime = this.CheckTime * (float)TimeUtil.Instance.InverseMillisecond;
			this.TsResetConditionMask = (this.ShouldIgnoreNoMoveTimeWhenSitting ? EAiNoMoveResetCondition.SitOnChairTask : EAiNoMoveResetCondition.None);
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000094B0 File Offset: 0x000076B0
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

	// Token: 0x060001DC RID: 476 RVA: 0x00009550 File Offset: 0x00007750
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

	// Token: 0x060001DD RID: 477 RVA: 0x000095ED File Offset: 0x000077ED
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckAiNoMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckAiNoMove.TsDecoratorCheckAiNoMove_C");
		}
		return TsDecoratorCheckAiNoMove._ClassPtr;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00009614 File Offset: 0x00007814
	public TsDecoratorCheckAiNoMove() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAiNoMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000963C File Offset: 0x0000783C
	[NullableContext(1)]
	public TsDecoratorCheckAiNoMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAiNoMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000966F File Offset: 0x0000786F
	protected TsDecoratorCheckAiNoMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00009678 File Offset: 0x00007878
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

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000046 RID: 70
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorInGazeAwareness.TsDecoratorInGazeAwareness_C")]
public class TsDecoratorInGazeAwareness : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600029C RID: 668 RVA: 0x0000C4CB File Offset: 0x0000A6CB
	// (set) Token: 0x0600029D RID: 669 RVA: 0x0000C4DB File Offset: 0x0000A6DB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float GazeTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorInGazeAwareness.__PropertyOffset_GazeTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorInGazeAwareness.__PropertyOffset_GazeTime) = value;
		}
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0000C4EC File Offset: 0x0000A6EC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsGazeTime = this.GazeTime * (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0000C520 File Offset: 0x0000A720
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

	// Token: 0x060002A0 RID: 672 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
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
		IdlePerformModel instance2 = IdlePerformModel.Instance;
		return instance2 != null && instance2.CheckGazeAwarenessByEntityId(charActorComp.Entity.Id, this.TsGazeTime);
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000C65C File Offset: 0x0000A85C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorInGazeAwareness._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorInGazeAwareness.TsDecoratorInGazeAwareness_C");
		}
		return TsDecoratorInGazeAwareness._ClassPtr;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000C680 File Offset: 0x0000A880
	public TsDecoratorInGazeAwareness() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInGazeAwareness.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
	[NullableContext(1)]
	public TsDecoratorInGazeAwareness(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorInGazeAwareness.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000C6DB File Offset: 0x0000A8DB
	protected TsDecoratorInGazeAwareness(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001B9 RID: 441
	private bool IsInitTsVariables;

	// Token: 0x040001BA RID: 442
	private float TsGazeTime;

	// Token: 0x040001BB RID: 443
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorInGazeAwareness.TsDecoratorInGazeAwareness_C";

	// Token: 0x040001BC RID: 444
	private static IntPtr _ClassPtr;

	// Token: 0x040001BD RID: 445
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001BE RID: 446
	private static int __PropertyOffset_GazeTime;
}

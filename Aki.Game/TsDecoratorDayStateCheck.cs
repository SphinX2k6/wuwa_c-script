using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000040 RID: 64
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDayStateCheck.TsDecoratorDayStateCheck_C")]
public class TsDecoratorDayStateCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700005E RID: 94
	// (get) Token: 0x0600025C RID: 604 RVA: 0x0000B997 File Offset: 0x00009B97
	// (set) Token: 0x0600025D RID: 605 RVA: 0x0000B9AB File Offset: 0x00009BAB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorDayStateCheck.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorDayStateCheck.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B9C0 File Offset: 0x00009BC0
	// (set) Token: 0x0600025F RID: 607 RVA: 0x0000B9D0 File Offset: 0x00009BD0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EDayState CheckValue
	{
		get
		{
			return (EDayState)(*(base.NativePtr + (IntPtr)TsDecoratorDayStateCheck.__PropertyOffset_CheckValue));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDayStateCheck.__PropertyOffset_CheckValue) = (byte)value;
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000B9E1 File Offset: 0x00009BE1
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsCheckValue = this.CheckValue;
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000BA14 File Offset: 0x00009C14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorDayStateCheck) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorDayStateCheck.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000262 RID: 610 RVA: 0x0000BACC File Offset: 0x00009CCC
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
		if (!this.IsCollected)
		{
			NpcDecisionController npcDecision = aiController.NpcDecision;
			if (npcDecision != null)
			{
				this.IsCollected = true;
				npcDecision.CheckDayState = true;
			}
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			return false;
		}
		int id = charActorComp.Entity.Id;
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(id, this.TsBlackboardKey);
		int tsCheckValue = (int)this.TsCheckValue;
		return intValueByEntity.GetValueOrDefault() == tsCheckValue & intValueByEntity != null;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0000BB8D File Offset: 0x00009D8D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorDayStateCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDayStateCheck.TsDecoratorDayStateCheck_C");
		}
		return TsDecoratorDayStateCheck._ClassPtr;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0000BBB4 File Offset: 0x00009DB4
	public TsDecoratorDayStateCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDayStateCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000BBDC File Offset: 0x00009DDC
	public TsDecoratorDayStateCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDayStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0000BC0F File Offset: 0x00009E0F
	protected TsDecoratorDayStateCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000BC24 File Offset: 0x00009E24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400018F RID: 399
	private bool IsCollected;

	// Token: 0x04000190 RID: 400
	private bool IsInitTsVariables;

	// Token: 0x04000191 RID: 401
	private string TsBlackboardKey = "";

	// Token: 0x04000192 RID: 402
	private EDayState TsCheckValue;

	// Token: 0x04000193 RID: 403
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDayStateCheck.TsDecoratorDayStateCheck_C";

	// Token: 0x04000194 RID: 404
	private static IntPtr _ClassPtr;

	// Token: 0x04000195 RID: 405
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000196 RID: 406
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x04000197 RID: 407
	private static int __PropertyOffset_CheckValue;
}

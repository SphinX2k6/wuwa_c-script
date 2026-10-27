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
	// (get) Token: 0x0600025C RID: 604 RVA: 0x0000B4B7 File Offset: 0x000096B7
	// (set) Token: 0x0600025D RID: 605 RVA: 0x0000B4CB File Offset: 0x000096CB
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
	// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B4E0 File Offset: 0x000096E0
	// (set) Token: 0x0600025F RID: 607 RVA: 0x0000B4F0 File Offset: 0x000096F0
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

	// Token: 0x06000260 RID: 608 RVA: 0x0000B501 File Offset: 0x00009701
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsCheckValue = this.CheckValue;
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000B534 File Offset: 0x00009734
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

	// Token: 0x06000262 RID: 610 RVA: 0x0000B5D4 File Offset: 0x000097D4
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

	// Token: 0x06000263 RID: 611 RVA: 0x0000B695 File Offset: 0x00009895
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorDayStateCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDayStateCheck.TsDecoratorDayStateCheck_C");
		}
		return TsDecoratorDayStateCheck._ClassPtr;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0000B6BC File Offset: 0x000098BC
	public TsDecoratorDayStateCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDayStateCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0000B6E4 File Offset: 0x000098E4
	public TsDecoratorDayStateCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDayStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0000B717 File Offset: 0x00009917
	protected TsDecoratorDayStateCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000B72C File Offset: 0x0000992C
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

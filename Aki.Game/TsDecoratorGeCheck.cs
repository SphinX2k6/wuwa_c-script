using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Condition.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000043 RID: 67
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorGeCheck.TsDecoratorGeCheck_C")]
public class TsDecoratorGeCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600027B RID: 635 RVA: 0x0000C19B File Offset: 0x0000A39B
	// (set) Token: 0x0600027C RID: 636 RVA: 0x0000C1AF File Offset: 0x0000A3AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTarget
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorGeCheck.__PropertyOffset_BlackboardKeyTarget)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorGeCheck.__PropertyOffset_BlackboardKeyTarget)), value);
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600027D RID: 637 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
	// (set) Token: 0x0600027E RID: 638 RVA: 0x0000C1FD File Offset: 0x0000A3FD
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<long, bool> Checks
	{
		get
		{
			base.FastCheckIsValid();
			TMap<long, bool> result;
			if ((result = this._Checks) == null)
			{
				result = (this._Checks = new TMap<long, bool>(base.NativePtr + (IntPtr)TsDecoratorGeCheck.__PropertyOffset_Checks, this));
			}
			return result;
		}
		set
		{
			this.Checks.CopyAssign(value);
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600027F RID: 639 RVA: 0x0000C20B File Offset: 0x0000A40B
	// (set) Token: 0x06000280 RID: 640 RVA: 0x0000C21B File Offset: 0x0000A41B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe SConditionGroupType Logic
	{
		get
		{
			return (SConditionGroupType)(*(base.NativePtr + (IntPtr)TsDecoratorGeCheck.__PropertyOffset_Logic));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorGeCheck.__PropertyOffset_Logic) = (byte)value;
		}
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0000C22C File Offset: 0x0000A42C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKeyTarget = this.BlackboardKeyTarget;
			int num = this.Checks.Num();
			this.TsChecks = new Dictionary<long, bool>(num);
			if (num > 0)
			{
				foreach (KeyValuePair<long, bool> keyValuePair in this.Checks)
				{
					long num2;
					bool flag;
					keyValuePair.Deconstruct(out num2, out flag);
					long key = num2;
					bool value = flag;
					this.TsChecks.Add(key, value);
				}
			}
			this.TsLogic = new SConditionGroupType?(this.Logic);
		}
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000C2EC File Offset: 0x0000A4EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorGeCheck) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorGeCheck.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000283 RID: 643 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
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
		CharacterBuffComponent characterBuffComponent = characterActorComponent.Entity.CheckGetComponent<CharacterBuffComponent>();
		if (characterBuffComponent == null)
		{
			return false;
		}
		SConditionGroupType? tsLogic = this.TsLogic;
		if (tsLogic != null)
		{
			SConditionGroupType valueOrDefault = tsLogic.GetValueOrDefault();
			if (valueOrDefault != SConditionGroupType.AND && valueOrDefault == SConditionGroupType.OR)
			{
				foreach (KeyValuePair<long, bool> keyValuePair in this.TsChecks)
				{
					long num;
					bool flag;
					keyValuePair.Deconstruct(out num, out flag);
					long buffId = num;
					bool flag2 = flag;
					if (characterBuffComponent.GetBuffTotalStackById(buffId, false) > 0 == flag2)
					{
						return true;
					}
				}
				return false;
			}
		}
		foreach (KeyValuePair<long, bool> keyValuePair in this.Checks)
		{
			long num;
			bool flag3;
			keyValuePair.Deconstruct(out num, out flag3);
			long buffId2 = num;
			bool flag4 = flag3;
			if (characterBuffComponent.GetBuffTotalStackById(buffId2, false) > 0 != flag4)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000C568 File Offset: 0x0000A768
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorGeCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorGeCheck.TsDecoratorGeCheck_C");
		}
		return TsDecoratorGeCheck._ClassPtr;
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0000C58C File Offset: 0x0000A78C
	public TsDecoratorGeCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
	public TsDecoratorGeCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0000C5E7 File Offset: 0x0000A7E7
	protected TsDecoratorGeCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0000C5FC File Offset: 0x0000A7FC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001A3 RID: 419
	private bool IsInitTsVariables;

	// Token: 0x040001A4 RID: 420
	private string TsBlackboardKeyTarget = "";

	// Token: 0x040001A5 RID: 421
	private Dictionary<long, bool> TsChecks;

	// Token: 0x040001A6 RID: 422
	private SConditionGroupType? TsLogic;

	// Token: 0x040001A7 RID: 423
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorGeCheck.TsDecoratorGeCheck_C";

	// Token: 0x040001A8 RID: 424
	private static IntPtr _ClassPtr;

	// Token: 0x040001A9 RID: 425
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001AA RID: 426
	private static int __PropertyOffset_BlackboardKeyTarget;

	// Token: 0x040001AB RID: 427
	private static int __PropertyOffset_Checks;

	// Token: 0x040001AC RID: 428
	[Nullable(2)]
	private TMap<long, bool> _Checks;

	// Token: 0x040001AD RID: 429
	private static int __PropertyOffset_Logic;
}

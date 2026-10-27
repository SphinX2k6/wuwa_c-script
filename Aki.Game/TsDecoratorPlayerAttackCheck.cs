using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000029 RID: 41
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/TsDecoratorPlayerAttackCheck.TsDecoratorPlayerAttackCheck_C")]
public class TsDecoratorPlayerAttackCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000135 RID: 309 RVA: 0x000068E3 File Offset: 0x00004AE3
	// (set) Token: 0x06000136 RID: 310 RVA: 0x000068F7 File Offset: 0x00004AF7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorPlayerAttackCheck.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorPlayerAttackCheck.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000690C File Offset: 0x00004B0C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00006930 File Offset: 0x00004B30
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

	// Token: 0x06000139 RID: 313 RVA: 0x000069D0 File Offset: 0x00004BD0
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			return false;
		}
		if (!this.IsCollected)
		{
			NpcDecisionController npcDecision = (ownerController as TsAiController).AiController.NpcDecision;
			if (npcDecision != null)
			{
				this.IsCollected = true;
				npcDecision.CheckPlayerAttack = true;
			}
		}
		CharacterActorComponent charActorComp = (ownerController as TsAiController).AiController.CharActorComp;
		if (charActorComp == null)
		{
			return false;
		}
		int id = charActorComp.Entity.Id;
		return BlackboardController.Instance.GetIntValueByEntity(id, this.TsBlackboardKey).GetValueOrDefault() == 1;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00006A55 File Offset: 0x00004C55
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorPlayerAttackCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/TsDecoratorPlayerAttackCheck.TsDecoratorPlayerAttackCheck_C");
		}
		return TsDecoratorPlayerAttackCheck._ClassPtr;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00006A7C File Offset: 0x00004C7C
	public TsDecoratorPlayerAttackCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerAttackCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00006AA4 File Offset: 0x00004CA4
	public TsDecoratorPlayerAttackCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerAttackCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00006AD7 File Offset: 0x00004CD7
	protected TsDecoratorPlayerAttackCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00006AEC File Offset: 0x00004CEC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000BD RID: 189
	private bool IsCollected;

	// Token: 0x040000BE RID: 190
	private bool IsInitTsVariables;

	// Token: 0x040000BF RID: 191
	private string TsBlackboardKey = "";

	// Token: 0x040000C0 RID: 192
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/TsDecoratorPlayerAttackCheck.TsDecoratorPlayerAttackCheck_C";

	// Token: 0x040000C1 RID: 193
	private static IntPtr _ClassPtr;

	// Token: 0x040000C2 RID: 194
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040000C3 RID: 195
	private static int __PropertyOffset_BlackboardKey;
}

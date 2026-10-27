using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200002A RID: 42
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/TsDecoratorPlayerImpactCheck.TsDecoratorPlayerImpactCheck_C")]
public class TsDecoratorPlayerImpactCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600013F RID: 319 RVA: 0x00006B1F File Offset: 0x00004D1F
	// (set) Token: 0x06000140 RID: 320 RVA: 0x00006B33 File Offset: 0x00004D33
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorPlayerImpactCheck.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorPlayerImpactCheck.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00006B48 File Offset: 0x00004D48
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00006B6C File Offset: 0x00004D6C
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

	// Token: 0x06000143 RID: 323 RVA: 0x00006C0C File Offset: 0x00004E0C
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (!(ownerController is TsAiController))
		{
			return false;
		}
		this.InitTsVariables();
		if (!this.IsCollected)
		{
			NpcDecisionController npcDecision = (ownerController as TsAiController).AiController.NpcDecision;
			if (npcDecision != null)
			{
				this.IsCollected = true;
				npcDecision.CheckPlayerImpact = true;
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

	// Token: 0x06000144 RID: 324 RVA: 0x00006C91 File Offset: 0x00004E91
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorPlayerImpactCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/TsDecoratorPlayerImpactCheck.TsDecoratorPlayerImpactCheck_C");
		}
		return TsDecoratorPlayerImpactCheck._ClassPtr;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00006CB8 File Offset: 0x00004EB8
	public TsDecoratorPlayerImpactCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerImpactCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00006CE0 File Offset: 0x00004EE0
	public TsDecoratorPlayerImpactCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerImpactCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00006D13 File Offset: 0x00004F13
	protected TsDecoratorPlayerImpactCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00006D28 File Offset: 0x00004F28
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000C4 RID: 196
	private bool IsCollected;

	// Token: 0x040000C5 RID: 197
	private bool IsInitTsVariables;

	// Token: 0x040000C6 RID: 198
	private string TsBlackboardKey = "";

	// Token: 0x040000C7 RID: 199
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/TsDecoratorPlayerImpactCheck.TsDecoratorPlayerImpactCheck_C";

	// Token: 0x040000C8 RID: 200
	private static IntPtr _ClassPtr;

	// Token: 0x040000C9 RID: 201
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040000CA RID: 202
	private static int __PropertyOffset_BlackboardKey;
}

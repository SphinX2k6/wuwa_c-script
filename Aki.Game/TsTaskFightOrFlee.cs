using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000098 RID: 152
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFightOrFlee.TsTaskFightOrFlee_C")]
public class TsTaskFightOrFlee : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00026989 File Offset: 0x00024B89
	// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0002699D File Offset: 0x00024B9D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FightOrFlee
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFightOrFlee.__PropertyOffset_FightOrFlee)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFightOrFlee.__PropertyOffset_FightOrFlee)), value);
		}
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x000269B2 File Offset: 0x00024BB2
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFightOrFlee = this.FightOrFlee;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060007C7 RID: 1991 RVA: 0x000269D6 File Offset: 0x00024BD6
	// (set) Token: 0x060007C8 RID: 1992 RVA: 0x000269E6 File Offset: 0x00024BE6
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe float FightProbability
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFightOrFlee.__PropertyOffset_FightProbability);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFightOrFlee.__PropertyOffset_FightProbability) = value;
		}
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x000269F8 File Offset: 0x00024BF8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00026A94 File Offset: 0x00024C94
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
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
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int id = charActorComp.Entity.Id;
		if (this.FightProbability == 0f)
		{
			CreatureDataComponent creatureData = charActorComp.CreatureData;
			AnimalComponent component = TdUtils.GetComponent<AnimalComponent>(creatureData.GetPbEntityInitData().ComponentsData, EConfigComponent.AnimalComponent);
			if (component == null || component.AnimalAttackRange == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.CJH;
				string message2 = "缺少战斗概率配置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityConfigId", creatureData.GetPbDataId());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			this.FightProbability = (float)component.AnimalAttackRange.Value;
		}
		int num = 100;
		bool value = MathUtils.Instance.GetRandomRange(0.0, (double)num) < (double)this.FightProbability;
		BlackboardController.Instance.SetBooleanValueByEntity(id, this.TsFightOrFlee, value);
		base.FinishExecute(true);
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00026BDD File Offset: 0x00024DDD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFightOrFlee._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFightOrFlee.TsTaskFightOrFlee_C");
		}
		return TsTaskFightOrFlee._ClassPtr;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00026C04 File Offset: 0x00024E04
	public TsTaskFightOrFlee() : this(BuiltinUtils.AllocNativeUObject(TsTaskFightOrFlee.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00026C2C File Offset: 0x00024E2C
	public TsTaskFightOrFlee(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFightOrFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00026C5F File Offset: 0x00024E5F
	protected TsTaskFightOrFlee(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00026C74 File Offset: 0x00024E74
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005B0 RID: 1456
	private bool IsInitTsVariables;

	// Token: 0x040005B1 RID: 1457
	private string TsFightOrFlee = "";

	// Token: 0x040005B2 RID: 1458
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFightOrFlee.TsTaskFightOrFlee_C";

	// Token: 0x040005B3 RID: 1459
	private static IntPtr _ClassPtr;

	// Token: 0x040005B4 RID: 1460
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005B5 RID: 1461
	private static int __PropertyOffset_FightOrFlee;

	// Token: 0x040005B6 RID: 1462
	private static int __PropertyOffset_FightProbability;
}

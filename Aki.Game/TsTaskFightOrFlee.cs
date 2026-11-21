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
	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002774D File Offset: 0x0002594D
	// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00027761 File Offset: 0x00025961
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

	// Token: 0x060007CA RID: 1994 RVA: 0x00027776 File Offset: 0x00025976
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFightOrFlee = this.FightOrFlee;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060007CB RID: 1995 RVA: 0x0002779A File Offset: 0x0002599A
	// (set) Token: 0x060007CC RID: 1996 RVA: 0x000277AA File Offset: 0x000259AA
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

	// Token: 0x060007CD RID: 1997 RVA: 0x000277BC File Offset: 0x000259BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFightOrFlee) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFightOrFlee.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x0002786C File Offset: 0x00025A6C
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

	// Token: 0x060007CF RID: 1999 RVA: 0x000279B5 File Offset: 0x00025BB5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFightOrFlee._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFightOrFlee.TsTaskFightOrFlee_C");
		}
		return TsTaskFightOrFlee._ClassPtr;
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x000279DC File Offset: 0x00025BDC
	public TsTaskFightOrFlee() : this(BuiltinUtils.AllocNativeUObject(TsTaskFightOrFlee.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00027A04 File Offset: 0x00025C04
	public TsTaskFightOrFlee(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFightOrFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00027A37 File Offset: 0x00025C37
	protected TsTaskFightOrFlee(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00027A4C File Offset: 0x00025C4C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005B4 RID: 1460
	private bool IsInitTsVariables;

	// Token: 0x040005B5 RID: 1461
	private string TsFightOrFlee = "";

	// Token: 0x040005B6 RID: 1462
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFightOrFlee.TsTaskFightOrFlee_C";

	// Token: 0x040005B7 RID: 1463
	private static IntPtr _ClassPtr;

	// Token: 0x040005B8 RID: 1464
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005B9 RID: 1465
	private static int __PropertyOffset_FightOrFlee;

	// Token: 0x040005BA RID: 1466
	private static int __PropertyOffset_FightProbability;
}

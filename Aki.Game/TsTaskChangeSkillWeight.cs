using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000093 RID: 147
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeSkillWeight.TsTaskChangeSkillWeight_C")]
public class TsTaskChangeSkillWeight : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x00025C25 File Offset: 0x00023E25
	// (set) Token: 0x06000768 RID: 1896 RVA: 0x00025C35 File Offset: 0x00023E35
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillInfoId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeSkillWeight.__PropertyOffset_SkillInfoId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeSkillWeight.__PropertyOffset_SkillInfoId) = value;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000769 RID: 1897 RVA: 0x00025C46 File Offset: 0x00023E46
	// (set) Token: 0x0600076A RID: 1898 RVA: 0x00025C56 File Offset: 0x00023E56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Weight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskChangeSkillWeight.__PropertyOffset_Weight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskChangeSkillWeight.__PropertyOffset_Weight) = value;
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00025C67 File Offset: 0x00023E67
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSkillInfoId = this.SkillInfoId;
			this.TsWeight = this.Weight;
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00025C98 File Offset: 0x00023E98
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskChangeSkillWeight) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskChangeSkillWeight.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00025D50 File Offset: 0x00023F50
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
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
		if (aiController.AiSkill == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "没有技能信息";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		aiController.AiSkill.ChangeSkillWeight(this.TsSkillInfoId, this.TsWeight);
		base.FinishExecute(true);
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00025E20 File Offset: 0x00024020
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeSkillWeight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeSkillWeight.TsTaskChangeSkillWeight_C");
		}
		return TsTaskChangeSkillWeight._ClassPtr;
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00025E44 File Offset: 0x00024044
	public TsTaskChangeSkillWeight() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeSkillWeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00025E6C File Offset: 0x0002406C
	[NullableContext(1)]
	public TsTaskChangeSkillWeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeSkillWeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00025E9F File Offset: 0x0002409F
	protected TsTaskChangeSkillWeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00025EA8 File Offset: 0x000240A8
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400056B RID: 1387
	private bool IsInitTsVariables;

	// Token: 0x0400056C RID: 1388
	private int TsSkillInfoId;

	// Token: 0x0400056D RID: 1389
	private float TsWeight;

	// Token: 0x0400056E RID: 1390
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeSkillWeight.TsTaskChangeSkillWeight_C";

	// Token: 0x0400056F RID: 1391
	private static IntPtr _ClassPtr;

	// Token: 0x04000570 RID: 1392
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000571 RID: 1393
	private static int __PropertyOffset_SkillInfoId;

	// Token: 0x04000572 RID: 1394
	private static int __PropertyOffset_Weight;
}

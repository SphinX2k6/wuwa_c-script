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
	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000763 RID: 1891 RVA: 0x00024EE9 File Offset: 0x000230E9
	// (set) Token: 0x06000764 RID: 1892 RVA: 0x00024EF9 File Offset: 0x000230F9
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

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000765 RID: 1893 RVA: 0x00024F0A File Offset: 0x0002310A
	// (set) Token: 0x06000766 RID: 1894 RVA: 0x00024F1A File Offset: 0x0002311A
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

	// Token: 0x06000767 RID: 1895 RVA: 0x00024F2B File Offset: 0x0002312B
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSkillInfoId = this.SkillInfoId;
			this.TsWeight = this.Weight;
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00024F5C File Offset: 0x0002315C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00024FFC File Offset: 0x000231FC
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

	// Token: 0x0600076A RID: 1898 RVA: 0x000250CC File Offset: 0x000232CC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskChangeSkillWeight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeSkillWeight.TsTaskChangeSkillWeight_C");
		}
		return TsTaskChangeSkillWeight._ClassPtr;
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x000250F0 File Offset: 0x000232F0
	public TsTaskChangeSkillWeight() : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeSkillWeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00025118 File Offset: 0x00023318
	[NullableContext(1)]
	public TsTaskChangeSkillWeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeSkillWeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0002514B File Offset: 0x0002334B
	protected TsTaskChangeSkillWeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00025154 File Offset: 0x00023354
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000567 RID: 1383
	private bool IsInitTsVariables;

	// Token: 0x04000568 RID: 1384
	private int TsSkillInfoId;

	// Token: 0x04000569 RID: 1385
	private float TsWeight;

	// Token: 0x0400056A RID: 1386
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskChangeSkillWeight.TsTaskChangeSkillWeight_C";

	// Token: 0x0400056B RID: 1387
	private static IntPtr _ClassPtr;

	// Token: 0x0400056C RID: 1388
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400056D RID: 1389
	private static int __PropertyOffset_SkillInfoId;

	// Token: 0x0400056E RID: 1390
	private static int __PropertyOffset_Weight;
}

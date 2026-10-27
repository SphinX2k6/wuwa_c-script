using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B9 RID: 185
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSelectSkill.TsTaskSelectSkill_C")]
public class TsTaskSelectSkill : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000349CD File Offset: 0x00032BCD
	// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000349DD File Offset: 0x00032BDD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectSkill.__PropertyOffset_SkillType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectSkill.__PropertyOffset_SkillType) = value;
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000349EE File Offset: 0x00032BEE
	// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000349FE File Offset: 0x00032BFE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugLog
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectSkill.__PropertyOffset_DebugLog) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectSkill.__PropertyOffset_DebugLog) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00034A0F File Offset: 0x00032C0F
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsSkillType = this.SkillType;
			this.TsDebugLog = this.DebugLog;
		}
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00034A40 File Offset: 0x00032C40
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

	// Token: 0x06000A9F RID: 2719 RVA: 0x00034AE0 File Offset: 0x00032CE0
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
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
		this.InitTsVariables();
		if (aiController.AiSkill == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "没有配置技能";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		CharacterSkillComponent component = aiController.CharAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		if (!component.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		if (currentTarget != null && currentTarget.Valid)
		{
			if (AiLibrary.SelectSkillWithTarget(aiController, component, currentTarget.Entity.GetComponent<CharacterActorComponent>(), this.TsSkillType, this.TsDebugLog))
			{
				base.FinishExecute(true);
				return;
			}
			base.FinishExecute(false);
			return;
		}
		else
		{
			if (AiLibrary.SelectSkillWithoutTarget(aiController, component, this.TsSkillType))
			{
				base.FinishExecute(true);
				return;
			}
			base.FinishExecute(false);
			return;
		}
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00034C19 File Offset: 0x00032E19
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSelectSkill._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSelectSkill.TsTaskSelectSkill_C");
		}
		return TsTaskSelectSkill._ClassPtr;
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00034C40 File Offset: 0x00032E40
	public TsTaskSelectSkill() : this(BuiltinUtils.AllocNativeUObject(TsTaskSelectSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00034C68 File Offset: 0x00032E68
	[NullableContext(1)]
	public TsTaskSelectSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSelectSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00034C9B File Offset: 0x00032E9B
	protected TsTaskSelectSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00034CA4 File Offset: 0x00032EA4
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000830 RID: 2096
	private bool IsInitTsVariables;

	// Token: 0x04000831 RID: 2097
	private int TsSkillType;

	// Token: 0x04000832 RID: 2098
	private bool TsDebugLog;

	// Token: 0x04000833 RID: 2099
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSelectSkill.TsTaskSelectSkill_C";

	// Token: 0x04000834 RID: 2100
	private static IntPtr _ClassPtr;

	// Token: 0x04000835 RID: 2101
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000836 RID: 2102
	private static int __PropertyOffset_SkillType;

	// Token: 0x04000837 RID: 2103
	private static int __PropertyOffset_DebugLog;
}

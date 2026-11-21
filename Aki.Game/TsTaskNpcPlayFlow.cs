using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200007C RID: 124
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPlayFlow.TsTaskNpcPlayFlow_C")]
public class TsTaskNpcPlayFlow : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001E531 File Offset: 0x0001C731
	// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0001E545 File Offset: 0x0001C745
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FlowListName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcPlayFlow.__PropertyOffset_FlowListName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcPlayFlow.__PropertyOffset_FlowListName)), value);
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001E55A File Offset: 0x0001C75A
	// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0001E56E File Offset: 0x0001C76E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FlowSubTitle
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcPlayFlow.__PropertyOffset_FlowSubTitle)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcPlayFlow.__PropertyOffset_FlowSubTitle)), value);
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0001E583 File Offset: 0x0001C783
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFlowListName = this.FlowListName;
			this.TsFlowSubTitle = this.FlowSubTitle;
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcPlayFlow) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskNpcPlayFlow.StaticClass(), out intPtr, out num))
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

	// Token: 0x060005FB RID: 1531 RVA: 0x0001E664 File Offset: 0x0001C864
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			base.FinishExecute(false);
			return;
		}
		if (string.IsNullOrEmpty(this.TsFlowListName) || string.IsNullOrEmpty(this.TsFlowSubTitle))
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = ((TsAiController)ownerController).AiController.CharActorComp;
		if (charActorComp == null)
		{
			base.FinishExecute(false);
			return;
		}
		this.Reset();
		this.HeadInfoComp = charActorComp.Entity.GetComponent<PawnHeadInfoComponent>();
		this.AnimComp = charActorComp.Entity.GetComponent<CharacterAnimationComponent>();
		this.PerformComp = charActorComp.Entity.GetComponent<BasePerformComponent>();
		if (!this.HandlePlayFlow())
		{
			base.Finish(false);
			return;
		}
		this.HandleFlowAction(0);
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0001E718 File Offset: 0x0001C918
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcPlayFlow) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskNpcPlayFlow.StaticClass(), out intPtr, out num))
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

	// Token: 0x060005FD RID: 1533 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.FlowEnd)
		{
			base.Finish(true);
			return;
		}
		if (this.TimeRemain > 0f)
		{
			this.TimeRemain -= deltaSeconds;
			if (this.TimeRemain < 0f)
			{
				this.HandleFlowAction(this.TempFlowIndex + 1);
			}
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x0001E824 File Offset: 0x0001CA24
	private bool HandlePlayFlow()
	{
		int flowId;
		if (!int.TryParse(this.TsFlowSubTitle, out flowId))
		{
			flowId = 0;
		}
		ShowTalk randomFlow = FlowConfig.Instance.GetRandomFlow(this.TsFlowListName, flowId, null, null);
		if (randomFlow != null)
		{
			this.TempTalkItems = randomFlow.TalkItems;
			return true;
		}
		return false;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0001E870 File Offset: 0x0001CA70
	private void HandleFlowAction(int index)
	{
		this.TempFlowIndex = index;
		List<ITalkItem> tempTalkItems = this.TempTalkItems;
		if (tempTalkItems.Count <= index)
		{
			this.FlowEnd = true;
			return;
		}
		ITalkItem talkItem = tempTalkItems[index];
		if (this.ExecuteNpcFlow(talkItem))
		{
			this.FlowEnd = false;
			this.TimeRemain = ((talkItem.WaitTime != null && talkItem.WaitTime.Value > 0f) ? talkItem.WaitTime.Value : 3f);
			return;
		}
		this.HandleFlowAction(index + 1);
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0001E900 File Offset: 0x0001CB00
	private bool ExecuteNpcFlow(ITalkItem config)
	{
		bool result = false;
		string flowText = this.GetFlowText(config.TidTalk);
		if (!string.IsNullOrEmpty(flowText))
		{
			result = true;
			if (this.HeadInfoComp != null)
			{
				this.HeadInfoComp.SetDialogueText(flowText, -1f, false);
			}
		}
		if (this.AnimComp != null)
		{
			if (config.Montage != null)
			{
				result = true;
				string path = config.Montage.ActionMontage.Path;
				ResourceSystem.Instance.LoadAsync<UAnimMontage>(path, delegate([Nullable(2)] UAnimMontage montageObject, string _)
				{
					if (montageObject == null || !montageObject.IsValid())
					{
						return;
					}
					if (this.PerformComp != null)
					{
						this.PerformComp.PlayPerformMontage(EPerformMode.Ecology, new IPlayMontageParam
						{
							MontageAsset = montageObject
						}, null, null, false);
					}
				}, 100, "js_undefined");
			}
			else if (this.PerformComp != null)
			{
				this.PerformComp.StopPerformMontage(EPerformMode.Ecology, new IStopMontageParam
				{
					Method = new EStopMethod?(EStopMethod.BlendOut),
					BlendOutTime = new float?(0.1f)
				}, null, null);
			}
		}
		return result;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0001E9BE File Offset: 0x0001CBBE
	[NullableContext(2)]
	private string GetFlowText(string textId)
	{
		if (!string.IsNullOrEmpty(textId) && !StringUtils.IsEmpty(textId))
		{
			return ConfigMultiTextLang.GetLocalTextNew(textId, null);
		}
		return null;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0001E9D9 File Offset: 0x0001CBD9
	private void Reset()
	{
		this.TempTalkItems = null;
		this.TempFlowIndex = 0;
		this.TimeRemain = 0f;
		this.FlowEnd = true;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0001E9FC File Offset: 0x0001CBFC
	protected override void OnClear()
	{
		this.Reset();
		if (this.HeadInfoComp != null)
		{
			this.HeadInfoComp.HideDialogueText();
			this.HeadInfoComp = null;
		}
		if (this.PerformComp != null)
		{
			this.PerformComp.StopPerformMontage(EPerformMode.Ecology, new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0.1f)
			}, null, null);
		}
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0001EA61 File Offset: 0x0001CC61
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcPlayFlow._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPlayFlow.TsTaskNpcPlayFlow_C");
		}
		return TsTaskNpcPlayFlow._ClassPtr;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0001EA88 File Offset: 0x0001CC88
	public TsTaskNpcPlayFlow() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPlayFlow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
	public TsTaskNpcPlayFlow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPlayFlow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0001EAE3 File Offset: 0x0001CCE3
	protected TsTaskNpcPlayFlow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0001EB0C File Offset: 0x0001CD0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0001EB3C File Offset: 0x0001CD3C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400045F RID: 1119
	private const float DEFAULT_WAIT_TIME = 3f;

	// Token: 0x04000460 RID: 1120
	private const float STOP_MONTAGE_BLEND_OUT_TIME = 0.1f;

	// Token: 0x04000461 RID: 1121
	private bool IsInitTsVariables;

	// Token: 0x04000462 RID: 1122
	private string TsFlowListName = "";

	// Token: 0x04000463 RID: 1123
	private string TsFlowSubTitle = "";

	// Token: 0x04000464 RID: 1124
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ITalkItem> TempTalkItems;

	// Token: 0x04000465 RID: 1125
	private int TempFlowIndex;

	// Token: 0x04000466 RID: 1126
	private float TimeRemain;

	// Token: 0x04000467 RID: 1127
	private bool FlowEnd = true;

	// Token: 0x04000468 RID: 1128
	[Nullable(2)]
	private PawnHeadInfoComponent HeadInfoComp;

	// Token: 0x04000469 RID: 1129
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400046A RID: 1130
	[Nullable(2)]
	private BasePerformComponent PerformComp;

	// Token: 0x0400046B RID: 1131
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPlayFlow.TsTaskNpcPlayFlow_C";

	// Token: 0x0400046C RID: 1132
	private static IntPtr _ClassPtr;

	// Token: 0x0400046D RID: 1133
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400046E RID: 1134
	private static int __PropertyOffset_FlowListName;

	// Token: 0x0400046F RID: 1135
	private static int __PropertyOffset_FlowSubTitle;
}

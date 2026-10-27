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
	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001D971 File Offset: 0x0001BB71
	// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0001D985 File Offset: 0x0001BB85
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

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001D99A File Offset: 0x0001BB9A
	// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0001D9AE File Offset: 0x0001BBAE
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

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001D9C3 File Offset: 0x0001BBC3
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFlowListName = this.FlowListName;
			this.TsFlowSubTitle = this.FlowSubTitle;
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
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

	// Token: 0x060005F7 RID: 1527 RVA: 0x0001DA90 File Offset: 0x0001BC90
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

	// Token: 0x060005F8 RID: 1528 RVA: 0x0001DB44 File Offset: 0x0001BD44
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

	// Token: 0x060005F9 RID: 1529 RVA: 0x0001DBE4 File Offset: 0x0001BDE4
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

	// Token: 0x060005FA RID: 1530 RVA: 0x0001DC38 File Offset: 0x0001BE38
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

	// Token: 0x060005FB RID: 1531 RVA: 0x0001DC84 File Offset: 0x0001BE84
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

	// Token: 0x060005FC RID: 1532 RVA: 0x0001DD14 File Offset: 0x0001BF14
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

	// Token: 0x060005FD RID: 1533 RVA: 0x0001DDD2 File Offset: 0x0001BFD2
	[NullableContext(2)]
	private string GetFlowText(string textId)
	{
		if (!string.IsNullOrEmpty(textId) && !StringUtils.IsEmpty(textId))
		{
			return ConfigMultiTextLang.GetLocalTextNew(textId, null);
		}
		return null;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x0001DDED File Offset: 0x0001BFED
	private void Reset()
	{
		this.TempTalkItems = null;
		this.TempFlowIndex = 0;
		this.TimeRemain = 0f;
		this.FlowEnd = true;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0001DE10 File Offset: 0x0001C010
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

	// Token: 0x06000600 RID: 1536 RVA: 0x0001DE75 File Offset: 0x0001C075
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcPlayFlow._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPlayFlow.TsTaskNpcPlayFlow_C");
		}
		return TsTaskNpcPlayFlow._ClassPtr;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0001DE9C File Offset: 0x0001C09C
	public TsTaskNpcPlayFlow() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPlayFlow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
	public TsTaskNpcPlayFlow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPlayFlow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0001DEF7 File Offset: 0x0001C0F7
	protected TsTaskNpcPlayFlow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0001DF20 File Offset: 0x0001C120
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0001DF50 File Offset: 0x0001C150
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400045B RID: 1115
	private const float DEFAULT_WAIT_TIME = 3f;

	// Token: 0x0400045C RID: 1116
	private const float STOP_MONTAGE_BLEND_OUT_TIME = 0.1f;

	// Token: 0x0400045D RID: 1117
	private bool IsInitTsVariables;

	// Token: 0x0400045E RID: 1118
	private string TsFlowListName = "";

	// Token: 0x0400045F RID: 1119
	private string TsFlowSubTitle = "";

	// Token: 0x04000460 RID: 1120
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ITalkItem> TempTalkItems;

	// Token: 0x04000461 RID: 1121
	private int TempFlowIndex;

	// Token: 0x04000462 RID: 1122
	private float TimeRemain;

	// Token: 0x04000463 RID: 1123
	private bool FlowEnd = true;

	// Token: 0x04000464 RID: 1124
	[Nullable(2)]
	private PawnHeadInfoComponent HeadInfoComp;

	// Token: 0x04000465 RID: 1125
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x04000466 RID: 1126
	[Nullable(2)]
	private BasePerformComponent PerformComp;

	// Token: 0x04000467 RID: 1127
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPlayFlow.TsTaskNpcPlayFlow_C";

	// Token: 0x04000468 RID: 1128
	private static IntPtr _ClassPtr;

	// Token: 0x04000469 RID: 1129
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400046A RID: 1130
	private static int __PropertyOffset_FlowListName;

	// Token: 0x0400046B RID: 1131
	private static int __PropertyOffset_FlowSubTitle;
}

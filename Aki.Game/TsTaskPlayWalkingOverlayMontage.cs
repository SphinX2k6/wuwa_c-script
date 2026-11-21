using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B2 RID: 178
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayWalkingOverlayMontage.TsTaskPlayWalkingOverlayMontage_C")]
public class TsTaskPlayWalkingOverlayMontage : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00033E83 File Offset: 0x00032083
	// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00033E93 File Offset: 0x00032093
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MontageId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayWalkingOverlayMontage.__PropertyOffset_MontageId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayWalkingOverlayMontage.__PropertyOffset_MontageId) = value;
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00033EA4 File Offset: 0x000320A4
	// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00033EB4 File Offset: 0x000320B4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayWalkingOverlayMontage.__PropertyOffset_LoopDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayWalkingOverlayMontage.__PropertyOffset_LoopDuration) = value;
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00033EC5 File Offset: 0x000320C5
	// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00033ED5 File Offset: 0x000320D5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RepeatTimes
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayWalkingOverlayMontage.__PropertyOffset_RepeatTimes);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayWalkingOverlayMontage.__PropertyOffset_RepeatTimes) = value;
		}
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00033EE6 File Offset: 0x000320E6
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMontageId = (int)this.MontageId;
			this.TsLoopDuration = this.LoopDuration;
			this.TsRepeatTimes = this.RepeatTimes;
		}
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00033F24 File Offset: 0x00032124
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPlayWalkingOverlayMontage) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPlayWalkingOverlayMontage.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000A2E RID: 2606 RVA: 0x00033FD4 File Offset: 0x000321D4
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
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(true);
			return;
		}
		Entity entity = aiController.CharActorComp.Entity;
		this.AnimComp = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
		if (this.AnimComp == null)
		{
			base.FinishExecute(true);
			return;
		}
		PlayMontageConfig config = new PlayMontageConfig(this.TsRepeatTimes, (double)this.TsLoopDuration, false, false);
		if (this.PlayingMontageId != 0)
		{
			PlayMontageUtils.Instance.ClearAndEndMontage(this.PlayingMontageId, true, null);
		}
		this.PlayingMontageId = PlayMontageUtils.Instance.LoadAndPlayMontageByOverlapId(this.AnimComp, this.TsMontageId, config, null, null, null);
		base.FinishExecute(true);
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x000340BC File Offset: 0x000322BC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayWalkingOverlayMontage._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayWalkingOverlayMontage.TsTaskPlayWalkingOverlayMontage_C");
		}
		return TsTaskPlayWalkingOverlayMontage._ClassPtr;
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x000340E0 File Offset: 0x000322E0
	public TsTaskPlayWalkingOverlayMontage() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayWalkingOverlayMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00034108 File Offset: 0x00032308
	[NullableContext(1)]
	public TsTaskPlayWalkingOverlayMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayWalkingOverlayMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x0003413B File Offset: 0x0003233B
	protected TsTaskPlayWalkingOverlayMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00034144 File Offset: 0x00032344
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040007D8 RID: 2008
	private bool IsInitTsVariables;

	// Token: 0x040007D9 RID: 2009
	private int TsMontageId;

	// Token: 0x040007DA RID: 2010
	private float TsLoopDuration;

	// Token: 0x040007DB RID: 2011
	private int TsRepeatTimes;

	// Token: 0x040007DC RID: 2012
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x040007DD RID: 2013
	private int PlayingMontageId;

	// Token: 0x040007DE RID: 2014
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayWalkingOverlayMontage.TsTaskPlayWalkingOverlayMontage_C";

	// Token: 0x040007DF RID: 2015
	private static IntPtr _ClassPtr;

	// Token: 0x040007E0 RID: 2016
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007E1 RID: 2017
	private static int __PropertyOffset_MontageId;

	// Token: 0x040007E2 RID: 2018
	private static int __PropertyOffset_LoopDuration;

	// Token: 0x040007E3 RID: 2019
	private static int __PropertyOffset_RepeatTimes;
}

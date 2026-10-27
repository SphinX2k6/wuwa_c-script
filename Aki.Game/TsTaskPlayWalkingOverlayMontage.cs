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
	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00032D33 File Offset: 0x00030F33
	// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00032D43 File Offset: 0x00030F43
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

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00032D54 File Offset: 0x00030F54
	// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00032D64 File Offset: 0x00030F64
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

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00032D75 File Offset: 0x00030F75
	// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00032D85 File Offset: 0x00030F85
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

	// Token: 0x06000A26 RID: 2598 RVA: 0x00032D96 File Offset: 0x00030F96
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

	// Token: 0x06000A27 RID: 2599 RVA: 0x00032DD4 File Offset: 0x00030FD4
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

	// Token: 0x06000A28 RID: 2600 RVA: 0x00032E70 File Offset: 0x00031070
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

	// Token: 0x06000A29 RID: 2601 RVA: 0x00032F58 File Offset: 0x00031158
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayWalkingOverlayMontage._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayWalkingOverlayMontage.TsTaskPlayWalkingOverlayMontage_C");
		}
		return TsTaskPlayWalkingOverlayMontage._ClassPtr;
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00032F7C File Offset: 0x0003117C
	public TsTaskPlayWalkingOverlayMontage() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayWalkingOverlayMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00032FA4 File Offset: 0x000311A4
	[NullableContext(1)]
	public TsTaskPlayWalkingOverlayMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayWalkingOverlayMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00032FD7 File Offset: 0x000311D7
	protected TsTaskPlayWalkingOverlayMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00032FE0 File Offset: 0x000311E0
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040007D0 RID: 2000
	private bool IsInitTsVariables;

	// Token: 0x040007D1 RID: 2001
	private int TsMontageId;

	// Token: 0x040007D2 RID: 2002
	private float TsLoopDuration;

	// Token: 0x040007D3 RID: 2003
	private int TsRepeatTimes;

	// Token: 0x040007D4 RID: 2004
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x040007D5 RID: 2005
	private int PlayingMontageId;

	// Token: 0x040007D6 RID: 2006
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayWalkingOverlayMontage.TsTaskPlayWalkingOverlayMontage_C";

	// Token: 0x040007D7 RID: 2007
	private static IntPtr _ClassPtr;

	// Token: 0x040007D8 RID: 2008
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007D9 RID: 2009
	private static int __PropertyOffset_MontageId;

	// Token: 0x040007DA RID: 2010
	private static int __PropertyOffset_LoopDuration;

	// Token: 0x040007DB RID: 2011
	private static int __PropertyOffset_RepeatTimes;
}

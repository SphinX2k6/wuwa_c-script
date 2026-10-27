using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BB RID: 187
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetCoolDown.TsTaskSetCoolDown_C")]
public class TsTaskSetCoolDown : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00035B17 File Offset: 0x00033D17
	// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00035B27 File Offset: 0x00033D27
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00035B38 File Offset: 0x00033D38
	// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00035B48 File Offset: 0x00033D48
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CoolDownTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_CoolDownTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_CoolDownTime) = value;
		}
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00035B59 File Offset: 0x00033D59
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsId = this.Id;
			this.TsCoolDownTime = this.CoolDownTime * (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00035B98 File Offset: 0x00033D98
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

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00035C34 File Offset: 0x00033E34
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
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ((ownerController != null) ? ownerController.GetClass().GetName() : null) ?? "undefined");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		double num = GameModeModel.Instance.IsMulti ? TimeUtil.Instance.GetServerTimeStamp() : Time.Instance.WorldTime;
		aiController.SetCoolDownTime(this.TsId, num + (double)this.TsCoolDownTime, true, "行为树Task");
		base.FinishExecute(true);
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00035CED File Offset: 0x00033EED
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetCoolDown._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetCoolDown.TsTaskSetCoolDown_C");
		}
		return TsTaskSetCoolDown._ClassPtr;
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00035D14 File Offset: 0x00033F14
	public TsTaskSetCoolDown() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetCoolDown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00035D3C File Offset: 0x00033F3C
	[NullableContext(1)]
	public TsTaskSetCoolDown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00035D6F File Offset: 0x00033F6F
	protected TsTaskSetCoolDown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00035D78 File Offset: 0x00033F78
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400086D RID: 2157
	private bool IsInitTsVariables;

	// Token: 0x0400086E RID: 2158
	private int TsId;

	// Token: 0x0400086F RID: 2159
	private float TsCoolDownTime;

	// Token: 0x04000870 RID: 2160
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetCoolDown.TsTaskSetCoolDown_C";

	// Token: 0x04000871 RID: 2161
	private static IntPtr _ClassPtr;

	// Token: 0x04000872 RID: 2162
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000873 RID: 2163
	private static int __PropertyOffset_Id;

	// Token: 0x04000874 RID: 2164
	private static int __PropertyOffset_CoolDownTime;
}
